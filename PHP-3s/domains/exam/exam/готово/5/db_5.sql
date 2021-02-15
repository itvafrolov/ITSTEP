CREATE TABLE IF NOT EXISTS `menu` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `element` varchar(50) NOT NULL,
    `link` varchar(250) NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=19 ;


INSERT INTO `menu` (`id`, `element`, `link`) VALUES
(1, 'Главная', 'index.php'),
(2, 'О нас', 'http://itgis.cc.ua/pages/company.html'),
(3, 'Контакты', 'http://itgis.cc.ua/#contacts'),
(4, 'Услуги', 'http://itgis.cc.ua/pages/services.html')
