-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2018 at 02:36 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblab`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbdosen`
--

CREATE TABLE `tbdosen` (
  `id` char(20) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `makul` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbdosen`
--

INSERT INTO `tbdosen` (`id`, `nama`, `makul`) VALUES
('AA01', 'Adam Anan', 'C#'),
('BB02', 'Barbie Margaretha', 'Delphi'),
('TB02', 'Tuti Budionti', 'Visual Studio');

-- --------------------------------------------------------

--
-- Table structure for table `tbjadwal`
--

CREATE TABLE `tbjadwal` (
  `Idjd` char(20) NOT NULL,
  `ruang` varchar(20) NOT NULL,
  `id` varchar(25) NOT NULL,
  `dosen` varchar(20) NOT NULL,
  `makul` varchar(25) NOT NULL,
  `kelas` varchar(25) NOT NULL,
  `fakultas` varchar(20) NOT NULL,
  `tgl` varchar(225) NOT NULL,
  `jawal` varchar(20) NOT NULL,
  `jakir` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbjadwal`
--

INSERT INTO `tbjadwal` (`Idjd`, `ruang`, `id`, `dosen`, `makul`, `kelas`, `fakultas`, `tgl`, `jawal`, `jakir`) VALUES
('001', 'LAB 1', 'BB02', 'Barbie Margaretha', 'Delphi', '17 SI B', 'Sistem Informasi', 'Selasa, 18/12/2018', '14:59 ', '15:59'),
('002', 'LAB 2', 'AA01', 'Adam Anan', 'C++', '17 B2', 'Managemen Informasi', 'Rabu, 19/12/2018', '17:10 ', '18:10');

-- --------------------------------------------------------

--
-- Table structure for table `tblogin`
--

CREATE TABLE `tblogin` (
  `username` char(20) NOT NULL,
  `password` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblogin`
--

INSERT INTO `tblogin` (`username`, `password`) VALUES
('adi', 'adi123'),
('admin', 'admin'),
('dipo', 'dipo');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbdosen`
--
ALTER TABLE `tbdosen`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbjadwal`
--
ALTER TABLE `tbjadwal`
  ADD PRIMARY KEY (`Idjd`);

--
-- Indexes for table `tblogin`
--
ALTER TABLE `tblogin`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
