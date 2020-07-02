using System.Collections.Generic;

namespace ConsoleApp19
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        bool IEqualityComparer<Student>.Equals(Student x, Student y)
        {
            return x.ToString() == y.ToString();
        }

        int IEqualityComparer<Student>.GetHashCode(Student obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}