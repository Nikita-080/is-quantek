-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 26.192.232.27:3306
-- Время создания: Июн 11 2023 г., 14:46
-- Версия сервера: 5.7.39
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `pnppk`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Access`
--

CREATE TABLE `Access` (
  `ID_A` int(11) NOT NULL,
  `hardware_a` int(11) NOT NULL,
  `person` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Department_Dict`
--

CREATE TABLE `Department_Dict` (
  `ID_DD` int(11) NOT NULL,
  `name_d` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Disk`
--

CREATE TABLE `Disk` (
  `ID_D` int(11) NOT NULL,
  `creator` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `model` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `type` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `size` int(11) NOT NULL,
  `hardware_d` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Disk`
--

INSERT INTO `Disk` (`ID_D`, `creator`, `model`, `type`, `size`, `hardware_d`) VALUES
(3, 'unknow', 'HFM512GDJTNG-8310A', 'Fixed hard disk media', 512, 1),
(4, 'Toshiba', 'unknow', 'Fixed hard disk media', 1024, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `hardware`
--

CREATE TABLE `hardware` (
  `ID_H` int(11) NOT NULL,
  `type_h` int(11) NOT NULL,
  `parent` int(11) DEFAULT NULL,
  `iswork` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `hardware`
--

INSERT INTO `hardware` (`ID_H`, `type_h`, `parent`, `iswork`) VALUES
(1, 1, NULL, 1);

--
-- Триггеры `hardware`
--
DELIMITER $$
CREATE TRIGGER `update_history` AFTER UPDATE ON `hardware` FOR EACH ROW BEGIN
IF OLD.parent <> NEW.parent AND OLD.parent=NULL THEN
    INSERT INTO History(computer,hardware_new)
    VALUES(NEW.parent, NEW.ID_H);
END IF;
IF OLD.parent <> NEW.parent AND NEW.parent=NULL THEN
    INSERT INTO History(computer,hardware_old)
    VALUES(OLD.parent, OLD.ID_H);
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `Hardware_Property`
--

CREATE TABLE `Hardware_Property` (
  `ID_HP` int(11) NOT NULL,
  `type_p` int(11) NOT NULL,
  `name_p` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Hardware_Property`
--

INSERT INTO `Hardware_Property` (`ID_HP`, `type_p`, `name_p`) VALUES
(1, 1, 'модель процессора'),
(2, 1, 'производитель процессора'),
(3, 1, 'частота процессора'),
(4, 1, 'оперативная память'),
(5, 1, 'конфигурация памяти'),
(6, 1, 'встроенная видеокарта'),
(7, 1, 'производитель видеокарты'),
(8, 1, 'память видеокарты'),
(9, 1, 'имя видеокарты'),
(10, 3, 'диагональ'),
(11, 2, 'формат');

-- --------------------------------------------------------

--
-- Структура таблицы `Hardware_Type`
--

CREATE TABLE `Hardware_Type` (
  `ID_HT` int(11) NOT NULL,
  `name_t` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Hardware_Type`
--

INSERT INTO `Hardware_Type` (`ID_HT`, `name_t`) VALUES
(1, 'системный блок'),
(2, 'принтер'),
(3, 'монитор'),
(4, 'диск'),
(5, 'smaple');

-- --------------------------------------------------------

--
-- Структура таблицы `Hardware_Value`
--

CREATE TABLE `Hardware_Value` (
  `ID_HV` int(11) NOT NULL,
  `hardware_v` int(11) NOT NULL,
  `property` int(11) NOT NULL,
  `value` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Hardware_Value`
--

INSERT INTO `Hardware_Value` (`ID_HV`, `hardware_v`, `property`, `value`) VALUES
(1, 1, 7, 'unknow'),
(2, 1, 8, '0'),
(3, 1, 9, 'unknow'),
(4, 1, 6, '1'),
(5, 1, 2, 'AMD'),
(6, 1, 3, '2.1'),
(7, 1, 1, 'Ryzen 99'),
(8, 1, 5, '4 4'),
(9, 1, 4, '8');

-- --------------------------------------------------------

--
-- Структура таблицы `History`
--

CREATE TABLE `History` (
  `ID_Hi` int(11) NOT NULL,
  `computer` int(11) NOT NULL,
  `hardware_old` int(11) DEFAULT NULL,
  `hardware_new` int(11) DEFAULT NULL,
  `date_h` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Place`
--

CREATE TABLE `Place` (
  `ID_P` int(11) NOT NULL,
  `hardware_p` int(11) NOT NULL,
  `department_id` int(11) NOT NULL,
  `building` int(11) NOT NULL,
  `floor` int(11) NOT NULL,
  `office` int(11) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Repair`
--

CREATE TABLE `Repair` (
  `ID_R` int(11) NOT NULL,
  `hardware_r` int(11) NOT NULL,
  `date_in` date DEFAULT NULL,
  `date_out` date DEFAULT NULL,
  `document_in` int(11) DEFAULT NULL,
  `document_out` int(11) DEFAULT NULL,
  `reason` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'неизвестно',
  `verdict` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'неизвестно'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Access`
--
ALTER TABLE `Access`
  ADD PRIMARY KEY (`ID_A`),
  ADD KEY `hardware_a` (`hardware_a`);

--
-- Индексы таблицы `Department_Dict`
--
ALTER TABLE `Department_Dict`
  ADD PRIMARY KEY (`ID_DD`);

--
-- Индексы таблицы `Disk`
--
ALTER TABLE `Disk`
  ADD PRIMARY KEY (`ID_D`),
  ADD KEY `hardware_d` (`hardware_d`);

--
-- Индексы таблицы `hardware`
--
ALTER TABLE `hardware`
  ADD PRIMARY KEY (`ID_H`),
  ADD KEY `type_h` (`type_h`),
  ADD KEY `parent` (`parent`);

--
-- Индексы таблицы `Hardware_Property`
--
ALTER TABLE `Hardware_Property`
  ADD PRIMARY KEY (`ID_HP`),
  ADD KEY `type_p` (`type_p`);

--
-- Индексы таблицы `Hardware_Type`
--
ALTER TABLE `Hardware_Type`
  ADD PRIMARY KEY (`ID_HT`);

--
-- Индексы таблицы `Hardware_Value`
--
ALTER TABLE `Hardware_Value`
  ADD PRIMARY KEY (`ID_HV`),
  ADD KEY `hardware_v` (`hardware_v`),
  ADD KEY `property` (`property`);

--
-- Индексы таблицы `History`
--
ALTER TABLE `History`
  ADD PRIMARY KEY (`ID_Hi`),
  ADD KEY `computer` (`computer`),
  ADD KEY `hardware_old` (`hardware_old`),
  ADD KEY `hardware_new` (`hardware_new`);

--
-- Индексы таблицы `Place`
--
ALTER TABLE `Place`
  ADD PRIMARY KEY (`ID_P`),
  ADD KEY `hardware_p` (`hardware_p`),
  ADD KEY `department_id` (`department_id`);

--
-- Индексы таблицы `Repair`
--
ALTER TABLE `Repair`
  ADD PRIMARY KEY (`ID_R`),
  ADD KEY `hardware_r` (`hardware_r`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Access`
--
ALTER TABLE `Access`
  MODIFY `ID_A` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Department_Dict`
--
ALTER TABLE `Department_Dict`
  MODIFY `ID_DD` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Disk`
--
ALTER TABLE `Disk`
  MODIFY `ID_D` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `Hardware_Value`
--
ALTER TABLE `Hardware_Value`
  MODIFY `ID_HV` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `History`
--
ALTER TABLE `History`
  MODIFY `ID_Hi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Place`
--
ALTER TABLE `Place`
  MODIFY `ID_P` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Repair`
--
ALTER TABLE `Repair`
  MODIFY `ID_R` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Access`
--
ALTER TABLE `Access`
  ADD CONSTRAINT `access_ibfk_1` FOREIGN KEY (`hardware_a`) REFERENCES `hardware` (`ID_H`);

--
-- Ограничения внешнего ключа таблицы `Disk`
--
ALTER TABLE `Disk`
  ADD CONSTRAINT `disk_ibfk_1` FOREIGN KEY (`hardware_d`) REFERENCES `hardware` (`ID_H`);

--
-- Ограничения внешнего ключа таблицы `hardware`
--
ALTER TABLE `hardware`
  ADD CONSTRAINT `hardware_ibfk_1` FOREIGN KEY (`type_h`) REFERENCES `Hardware_Type` (`ID_HT`),
  ADD CONSTRAINT `hardware_ibfk_2` FOREIGN KEY (`parent`) REFERENCES `hardware` (`ID_H`);

--
-- Ограничения внешнего ключа таблицы `Hardware_Property`
--
ALTER TABLE `Hardware_Property`
  ADD CONSTRAINT `hardware_property_ibfk_1` FOREIGN KEY (`type_p`) REFERENCES `Hardware_Type` (`ID_HT`);

--
-- Ограничения внешнего ключа таблицы `Hardware_Value`
--
ALTER TABLE `Hardware_Value`
  ADD CONSTRAINT `hardware_value_ibfk_1` FOREIGN KEY (`hardware_v`) REFERENCES `hardware` (`ID_H`),
  ADD CONSTRAINT `hardware_value_ibfk_2` FOREIGN KEY (`property`) REFERENCES `Hardware_Property` (`ID_HP`);

--
-- Ограничения внешнего ключа таблицы `History`
--
ALTER TABLE `History`
  ADD CONSTRAINT `history_ibfk_1` FOREIGN KEY (`computer`) REFERENCES `hardware` (`ID_H`),
  ADD CONSTRAINT `history_ibfk_2` FOREIGN KEY (`hardware_new`) REFERENCES `hardware` (`ID_H`),
  ADD CONSTRAINT `history_ibfk_3` FOREIGN KEY (`hardware_old`) REFERENCES `hardware` (`ID_H`);

--
-- Ограничения внешнего ключа таблицы `Place`
--
ALTER TABLE `Place`
  ADD CONSTRAINT `place_ibfk_1` FOREIGN KEY (`hardware_p`) REFERENCES `hardware` (`ID_H`),
  ADD CONSTRAINT `place_ibfk_2` FOREIGN KEY (`department_id`) REFERENCES `Department_Dict` (`ID_DD`);

--
-- Ограничения внешнего ключа таблицы `Repair`
--
ALTER TABLE `Repair`
  ADD CONSTRAINT `repair_ibfk_1` FOREIGN KEY (`hardware_r`) REFERENCES `hardware` (`ID_H`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
