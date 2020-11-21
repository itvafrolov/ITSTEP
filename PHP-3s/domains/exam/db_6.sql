CREATE TABLE IF NOT EXISTS `birthday` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `Family` varchar(100),
    `Birthday` date,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;


INSERT INTO `birthday` (`Family`, `Birthday`) VALUES
('Фролов', '1977-02-01'),
('Иванов', '1979-03-04'),
('Сидоров', '1982-05-22'),
('Петров', '1956-07-24'),
('Краснов', '2009-09-06'),
('Мордухович', '2012-10-15')
