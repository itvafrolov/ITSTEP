<?php
    $menuArr = array(
        'Главная' => 'index.php', 
        'О нас' => 'aboute.php', 
        'Контакты' => 'contacts.php', 
        'Проекты' => 'projects.php', 
    );    
   /* foreach($menuArr as $key => $value)
    {
        echo "$key : $value<br>";        
    }*/
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GISAPR</title>
    <style>
.header {
    background-image: url(../img/header.jpg);
    background-size: cover;
}
.site-title {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 70px;
}
.site-title > h1 {
    color: #eee;
    font-size: 4rem;
    text-shadow: 0 0 5px #000;
}
.menu {
    display: flex;
    justify-content: flex-start;
    background-color: #00000080;
}
.menu-element {
    color: #aaa;
    text-transform: uppercase;
    text-decoration: none;
    font-size: 2rem;
    padding: 1rem 2rem;
    margin-right: 2.5rem;
}
.menu-element:hover {
    background-color: #000000a0;
}
.content-container {
    display: flex;
    justify-content: flex-start;
}
.v-menu{
    font-size: 2rem;    
}
.sidebar {
    width: 20%;
    padding: 5em;
}
.sidebar > h2 {
    margin-bottom: 1em;
    color: #646886;
}
.sidebar > ul {
    font-size: 1.5em;
    padding-left: 1rem;    
}
.content-page{        
    
    font-size: 1.5rem;    
    background-color: #eee;
    padding: 2rem;
     /* 10rem 10rem 10rem; */
    display: flex;
    flex-direction: row; 
    justify-content: flex-end;
    width: 100%; 
}

.panel {
    width: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
}

.panel-contacts {
    flex-direction: column;
    justify-content: center;
    width: 500px;
}


    </style>
</head>
<body>
<div class="header">
    <div class="site-title">
            <h1>GISAPR company</h1>
    </div>    
    <div class="menu">
            <?php
                foreach($menuArr as $key => $value)
                {                    
                    echo "<a class="."menu-element"." href=".$value.">".$key."</a></li>";        
                }
            ?> 
    </div>       
</div>
<div class="content-container">
        <div class="sidebar">
            <h2>BЫБЕРИТЕ:</h2>
            <ul>
                <?php
                foreach($menuArr as $key => $value)
                {                    
                    echo "<li><a href=".$value.">".$key."</a></li>";        
                }
                ?>    
            </ul>
        </div>  
        <div class="content-page">
        <div>
            <div class="panel-contacts">
                <h2 id="contacts">Контакты</h2>
                <p>+38 (067) 575-01-35</p>
                <p>+38 (050) 981-61-12</p>
                <p>+38 (057) 717-07-55</p>
                <p>email: gisapr2009@gmail.com</p>
                <p>г. Харьков, ул. Гимназическая</p> 
                <p>Набережная, д. 16</p>
            </div>
        </div>
        <div class="panel">
            <iframe width="525" height="500" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://www.openstreetmap.org/export/embed.html?bbox=36.23849451541901%2C49.98277171809379%2C36.24557554721833%2C49.98581400762889&amp;layer=mapnik&amp;marker=49.98429288691235%2C36.242035031318665" style="border: 1px solid black"></iframe><br/><small><a href="https://www.openstreetmap.org/?mlat=49.98429&amp;mlon=36.24204#map=18/49.98429/36.24204&amp;layers=N"></a></small>
        </div>
        </div>
</div>
</body>
</html>
