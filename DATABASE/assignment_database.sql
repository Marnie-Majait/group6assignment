-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 08, 2022 at 07:19 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `assignment_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `assignment_table`
--

CREATE TABLE `assignment_table` (
  `Order_Num` int(11) NOT NULL,
  `First_Name` varchar(255) NOT NULL,
  `Last_Name` varchar(255) NOT NULL,
  `Contact_Num` varchar(15) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Email_Add` varchar(255) NOT NULL,
  `Item_Num` int(11) NOT NULL,
  `Quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `assignment_table`
--

INSERT INTO `assignment_table` (`Order_Num`, `First_Name`, `Last_Name`, `Contact_Num`, `Address`, `Email_Add`, `Item_Num`, `Quantity`) VALUES
(1007, 'Testing', 'Testin', '09123456789', 'Testing', 'test@yahoo.com', 14, 20),
(1009, 'Testing', 'Test', '12345678910', 'testingthis', 'testingthis@gmail.com', 21, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignment_table`
--
ALTER TABLE `assignment_table`
  ADD PRIMARY KEY (`Order_Num`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assignment_table`
--
ALTER TABLE `assignment_table`
  MODIFY `Order_Num` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1010;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
