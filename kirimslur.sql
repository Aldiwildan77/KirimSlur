-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 02, 2019 at 03:02 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kirimslur`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `berat` int(11) NOT NULL,
  `jenis` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id`, `nama`, `berat`, `jenis`) VALUES
(1, 'SKHUN', 8, 'Dokumen'),
(2, 'rapot', 6, 'Dokumen');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `id` int(11) NOT NULL,
  `no_resi` varchar(255) NOT NULL,
  `tanggal` datetime NOT NULL,
  `id_pengirim` int(11) NOT NULL,
  `id_penerima` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `id_kurir` int(11) NOT NULL,
  `kategori` varchar(255) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`id`, `no_resi`, `tanggal`, `id_pengirim`, `id_penerima`, `id_barang`, `id_kurir`, `kategori`, `total`) VALUES
(1, '972626319378615', '2019-10-02 06:46:43', 1, 2, 1, 2, 'Regular', 70000),
(2, '596644642013776', '2019-10-02 07:48:47', 3, 2, 2, 3, 'Express', 120000),
(3, '129317592007877', '2019-10-02 08:00:19', 2, 1, 2, 1, 'Regular', 70000);

-- --------------------------------------------------------

--
-- Table structure for table `invoice_status`
--

CREATE TABLE `invoice_status` (
  `id_invoice` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  `tanggal` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice_status`
--

INSERT INTO `invoice_status` (`id_invoice`, `id_status`, `tanggal`) VALUES
(11, 1, '2019-09-25 14:58:10'),
(11, 2, '2019-09-25 14:58:19'),
(13, 1, '2019-09-25 00:00:00'),
(13, 3, '2019-09-25 22:23:21'),
(13, 4, '2019-09-25 22:26:22'),
(14, 1, '2019-09-25 22:29:11'),
(0, 1, '2019-10-02 07:40:32'),
(0, 1, '2019-10-02 07:40:34'),
(0, 1, '2019-10-02 07:40:34'),
(0, 1, '2019-10-02 07:40:34'),
(0, 1, '2019-10-02 07:40:34'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:35'),
(0, 1, '2019-10-02 07:40:43'),
(0, 1, '2019-10-02 07:40:47'),
(1, 2, '2019-10-02 07:43:30'),
(1, 3, '2019-10-02 07:43:34'),
(1, 4, '2019-10-02 07:43:36'),
(1, 5, '2019-10-02 07:43:42'),
(1, 6, '2019-10-02 07:43:44'),
(2, 2, '2019-10-02 07:49:15'),
(2, 4, '2019-10-02 07:49:18'),
(2, 5, '2019-10-02 07:49:20'),
(2, 6, '2019-10-02 07:49:29'),
(2, 3, '2019-10-02 07:49:31'),
(1, 1, '2019-10-02 07:56:28'),
(2, 2, '2019-10-02 07:56:42'),
(2, 4, '2019-10-02 07:57:02'),
(3, 3, '2019-10-02 08:00:40'),
(3, 4, '2019-10-02 08:00:46'),
(3, 5, '2019-10-02 08:01:05'),
(3, 6, '2019-10-02 08:01:08');

-- --------------------------------------------------------

--
-- Table structure for table `kurir`
--

CREATE TABLE `kurir` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `no_ktp` varchar(50) NOT NULL,
  `no_telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kurir`
--

INSERT INTO `kurir` (`id`, `nama`, `no_ktp`, `no_telp`) VALUES
(1, 'alif', '123', '123'),
(2, 'Aldi', '123456778', '12334'),
(3, 'dasdas', '876567890', '345678765');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `kota` varchar(50) NOT NULL,
  `kodepos` varchar(10) NOT NULL,
  `no_telp` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`id`, `nama`, `alamat`, `kota`, `kodepos`, `no_telp`) VALUES
(1, 'Alif', 'Wagir', 'Malang', '67202', '1234'),
(2, 'Aldik', 'Sanan', 'Malang', '67202', '1234'),
(3, 'lia', 'sumbersari', 'sidoarjo', '56789', '098765');

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

CREATE TABLE `status` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `status`
--

INSERT INTO `status` (`id`, `nama`) VALUES
(1, 'Kantor menerima barang'),
(2, 'Dalam Proses pengiriman'),
(3, 'Diterima di pusat'),
(4, 'Diterima di cabang I'),
(5, 'Diterima di cabang II'),
(6, 'Diterima di cabang III');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_pengirim` (`id_pengirim`),
  ADD KEY `id_penerima` (`id_penerima`),
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_kurir` (`id_kurir`);

--
-- Indexes for table `invoice_status`
--
ALTER TABLE `invoice_status`
  ADD KEY `id_invoice` (`id_invoice`),
  ADD KEY `id_status` (`id_status`);

--
-- Indexes for table `kurir`
--
ALTER TABLE `kurir`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kurir`
--
ALTER TABLE `kurir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pelanggan`
--
ALTER TABLE `pelanggan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `status`
--
ALTER TABLE `status`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`id_pengirim`) REFERENCES `pelanggan` (`id`),
  ADD CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`id_penerima`) REFERENCES `pelanggan` (`id`),
  ADD CONSTRAINT `invoice_ibfk_3` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id`),
  ADD CONSTRAINT `invoice_ibfk_4` FOREIGN KEY (`id_kurir`) REFERENCES `kurir` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
