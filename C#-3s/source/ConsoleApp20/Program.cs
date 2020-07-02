using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;


// ****   XML   *****

namespace ConsoleApp20
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        XmlTextWriter writer = null;
    //        try
    //        {
    //            writer = new XmlTextWriter("Cars.xml", Encoding.Unicode)
    //            {
    //                Formatting = Formatting.Indented,
    //                Indentation = 2,
    //                IndentChar = '+'
    //            };
    //            writer.WriteStartDocument();

    //            writer.WriteStartElement("Cars");
    //            writer.WriteStartElement("Car");
    //            writer.WriteAttributeString("Image", "Ferrary.jpg");
    //            writer.WriteElementString("Mfnufactured", "Al...");
    //            writer.WriteElementString("Model", "Alonso");
    //            writer.WriteElementString("Year", "2012");
    //            writer.WriteElementString("Color", "Red");
    //            writer.WriteElementString("Speed", "300");
    //            writer.WriteEndElement();


    //            writer.WriteStartElement("Car");
    //            writer.WriteAttributeString("Image", "Ferrary.jpg");
    //            writer.WriteElementString("Mfnufactured", "Detroite");
    //            writer.WriteElementString("Model", "Bongo");
    //            writer.WriteElementString("Year", "2020");
    //            writer.WriteElementString("Color", "Blue");
    //            writer.WriteElementString("Speed", "300");
    //            writer.WriteEndElement();


    //            writer.WriteEndDocument();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //            throw;
    //        }
    //        finally
    //        {
    //            if (writer !=null)
    //            {
    //                writer.Close();
    //            }
    //        }
    //    }
    //}

    /* class Program
     {
         static void OutputNode(XmlNode node)
         {
             switch (node.NodeType)
             {
                 case XmlNodeType.Element:
                     WriteLine($"Type={node.NodeType}\tName={node.Name}");
                     break;
                 case XmlNodeType.Text:
                     WriteLine($"Type={node.NodeType}\tValue={node.Value}");
                     break;
                 default:
                     break;
             }

             if (node.Attributes != null)
             {
                 foreach (XmlAttribute attr in node.Attributes)
                     WriteLine($"Type= {attr.NodeType}\tName={attr.Name}\tValue={attr.Value}");
             }
             if (node.HasChildNodes)
             {
                 foreach (XmlNode child in node.ChildNodes)
                 {
                     OutputNode(child);
                 }
             }
         }

         static void Main(string[] args)
         {
             try
             {
                 XmlDocument doc = new XmlDocument();
                 doc.Load("Cars.xml");
                 OutputNode(doc.DocumentElement);
             }
             catch (Exception ex)
             {
                 WriteLine(ex.Message);
             }
         }
     }*/

    /* class Program
     {
         static void Main(string[] args)
         {
             try
             {
                 XmlDocument doc = new XmlDocument();
                 doc.Load("Cars.xml");

                 XmlNode root = doc.DocumentElement;
                 // удалить первый элемент Cars
                 root.RemoveChild(root.FirstChild);
                 // создать узлы элементов.
                 XmlNode bike = doc.CreateElement("Motorcycle");
                 XmlNode elem1 = doc.CreateElement("Nanufactured");
                 XmlNode elem2 = doc.CreateElement("Model");
                 XmlNode elem3 = doc.CreateElement("Year");
                 XmlNode elem4 = doc.CreateElement("Color");
                 XmlNode elem5 = doc.CreateElement("Engine");
                 // создать текстовые узлы
                 XmlNode text1 = doc.CreateTextNode("Harley-Davidson Motor Co. Inc.");
                 XmlNode text2 = doc.CreateTextNode("Harley 20J");
                 XmlNode text3 = doc.CreateTextNode("1920");
                 XmlNode text4 = doc.CreateTextNode("Olive");
                 XmlNode text5 = doc.CreateTextNode("37 HP");
                 // присоединить текстовые узлы к узлам элементов
                 elem1.AppendChild(text1);
                 elem2.AppendChild(text2);
                 elem3.AppendChild(text3);
                 elem4.AppendChild(text4);
                 elem5.AppendChild(text5);
                 // присоединить узлы элементов к узлу bike
                 bike.AppendChild(elem1);
                 bike.AppendChild(elem2);
                 bike.AppendChild(elem3);
                 bike.AppendChild(elem4);
                 bike.AppendChild(elem5);
                 // присоединить узел bike к корневому узлу
                 root.AppendChild(bike);

                 doc.Save("Motorcycle.xml"); // сохранить измененный документ

                 WriteLine("The Motorcycle.xml file is generated!");
             }
             catch (Exception ex)
             {
                 WriteLine(ex.Message);
             }
         }
     }*/

    /* class Program
     {
         static void Main(string[] args)
         {
             XmlTextReader reader = null;
             try
             {
                 reader = new XmlTextReader("Cars.xml");
                 reader.WhitespaceHandling = WhitespaceHandling.None;
                 while (reader.Read())
                 {
                     WriteLine($"Type={reader.NodeType}\t\tName={reader.Name}\t\tValue={reader.Value}");
                     if (reader.AttributeCount > 0)
                     {
                         while (reader.MoveToNextAttribute())
                         {
                             WriteLine($"Type={reader.NodeType}\tName={reader.Name}\tValue={reader.Value}");
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 WriteLine(ex.Message);
             }
             finally
             {
                 if (reader != null)
                     reader.Close();
             }
         }
     }*/

    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader("Cars.xml");
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Car" && reader.AttributeCount > 0)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "Image")
                            {
                                WriteLine(reader.Value);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }

}
