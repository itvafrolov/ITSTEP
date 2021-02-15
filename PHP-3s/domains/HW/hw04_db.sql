-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 30 2020 г., 16:45
-- Версия сервера: 10.3.13-MariaDB
-- Версия PHP: 7.1.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `hw04_db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `brand`
--

CREATE TABLE `brand` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `img` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `brand`
--

INSERT INTO `brand` (`id`, `title`, `img`, `description`) VALUES
(1, 'ASUS', 'images/asus.jpg', 'ASUS'),
(2, 'ACER', 'images/acer.jpg', 'ACER'),
(3, 'Lenovo', 'images/lenovo.jpg', 'Lenovo'),
(4, 'Intel', 'images/intel.jpg', 'Intel'),
(5, 'Samsung', 'images/samsung.jpg', 'Samsung');

-- --------------------------------------------------------

--
-- Структура таблицы `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `keywords` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `categories`
--

INSERT INTO `categories` (`id`, `title`, `keywords`, `description`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'PC', 'компьютеры', 'Персональные компьютеры в сборе', '2020-06-30 12:37:57', NULL, NULL),
(2, 'Notebook', 'Ноутбуки', 'Ноутбуки лаптопы', '2020-06-30 12:37:57', NULL, NULL),
(3, 'Components', 'Комплектрующие', 'Комплектующие запчасти', '2020-06-30 12:37:57', NULL, NULL),
(4, 'Mobile', 'Мобильные устройства', 'Телефоны, планшеты', '2020-06-30 12:37:57', NULL, NULL),
(5, 'Accessories', 'Аксессуары', 'Чехлы Защитные стекла пленки и прочие аксессуары', '2020-06-30 12:37:57', NULL, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `id_brand` int(11) NOT NULL,
  `id_type_product` int(11) NOT NULL,
  `model` varchar(100) NOT NULL,
  `price` double(8,2) DEFAULT 0.00,
  `old_price` double(8,2) DEFAULT 0.00,
  `status` int(11) NOT NULL DEFAULT 1,
  `keywords` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `id_category` int(11) NOT NULL,
  `about` varchar(255) DEFAULT NULL,
  `img` varchar(255) DEFAULT NULL,
  `hit` int(11) NOT NULL DEFAULT 0,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `id_brand`, `id_type_product`, `model`, `price`, `old_price`, `status`, `keywords`, `description`, `id_category`, `about`, `img`, `hit`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 1, 1, 'ZEVS', 9000.00, 8500.00, 1, 'компьютеры', 'Персональные компьютеры', 1, 'Игровой компьютер', 'images/pc.jpg', 0, '2020-06-30 12:37:58', NULL, NULL),
(2, 2, 2, 'Acer', 2500.00, 2600.00, 1, 'Комплектрующие', 'Комплектрующие', 3, 'Материнская плата', 'images/mb.jpg', 0, '2020-06-30 12:37:58', NULL, NULL),
(3, 3, 1, 'Lenovo', 9000.00, 8500.00, 1, 'Ноутбуки', 'Ноутбук', 1, 'Ноутбук', 'images/notebook.jpg', 0, '2020-06-30 12:37:58', NULL, NULL),
(4, 4, 1, 'Core i7', 6500.00, 6600.00, 1, 'Комплектрующие', 'Комплектующие', 3, 'Процессор', 'images/cpu.jpg', 0, '2020-06-30 12:37:58', NULL, NULL),
(5, 5, 1, 'Galaxy s20', 9000.00, 8500.00, 1, 'Мобильные устройства', 'Мобильные телефоны', 4, 'Смартфон', 'images/s20.jpg', 0, '2020-06-30 12:37:58', NULL, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `type_products`
--

CREATE TABLE `type_products` (
  `id` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `img` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `type_products`
--

INSERT INTO `type_products` (`id`, `title`, `img`, `description`) VALUES
(1, 'PC', 'images/pc.jpg', 'Персональные компьютеры'),
(2, 'MB', 'images/mb.jpg', 'Материнские платы'),
(3, 'VC', 'images/vc.jpg', 'Видео карты'),
(4, 'MC', 'images/mc.jpg', 'Карты памяти'),
(5, 'CPU', 'images/cpu.jpg', 'Процессоры'),
(6, 'Phones', 'images/mp.jpg', 'Мобильные телефоны');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT current_timestamp(),
  `password` varchar(255) NOT NULL,
  `role` varchar(20) DEFAULT 'user',
  `remember_token` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `type_products`
--
ALTER TABLE `type_products`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `brand`
--
ALTER TABLE `brand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `type_products`
--
ALTER TABLE `type_products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
