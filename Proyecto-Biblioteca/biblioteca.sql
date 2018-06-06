-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-06-2018 a las 21:28:15
-- Versión del servidor: 10.1.31-MariaDB
-- Versión de PHP: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `biblioteca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `autor`
--

CREATE TABLE `autor` (
  `cod_autor` int(11) NOT NULL,
  `nacionalidad` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacion`
--

CREATE TABLE `clasificacion` (
  `cod_clas` int(11) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `editorial`
--

CREATE TABLE `editorial` (
  `cod_editorial` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `pais` varchar(255) DEFAULT NULL,
  `anio` varchar(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libro`
--

CREATE TABLE `libro` (
  `cod_libro` int(11) NOT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `cod_autor` int(11) DEFAULT NULL,
  `cod_editorial` int(11) DEFAULT NULL,
  `volumen` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `origen` varchar(255) DEFAULT NULL,
  `observaciones` varchar(255) DEFAULT NULL,
  `estado` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notas`
--

CREATE TABLE `notas` (
  `cod_texto` int(11) NOT NULL,
  `texto` varchar(255) DEFAULT NULL,
  `cedula` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE `prestamo` (
  `cedula` int(11) DEFAULT NULL,
  `cod_libro` int(11) DEFAULT NULL,
  `fecha_salida` varchar(255) DEFAULT NULL,
  `fecha_entrada` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `cedula` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `nacimiento` date DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL,
  `apellido` varchar(255) DEFAULT NULL,
  `contrasenia` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`cedula`, `nombre`, `direccion`, `telefono`, `nacimiento`, `tipo`, `apellido`, `contrasenia`) VALUES
(454, 'guille', 'chile', 4545, NULL, 1, '', NULL),
(4223, 'lolo', 'yata', 34534, NULL, 2, '', NULL),
(4544, 'lolo', 'yata', 5487, NULL, 2, '', NULL),
(12345, 'mateo', 'barrio uruguay', 454, '2018-06-06', 2, 'otako', NULL),
(50432, 'guille', 'chile 1234', 324875, '1990-02-05', 1, 'coelho', NULL),
(5043831, 'pedro', NULL, NULL, NULL, NULL, NULL, 'hola123'),
(50438316, 'Guille ', 'Chile 1489', 998728, NULL, 1, 'Coelho', NULL);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`cod_autor`);

--
-- Indices de la tabla `clasificacion`
--
ALTER TABLE `clasificacion`
  ADD PRIMARY KEY (`cod_clas`);

--
-- Indices de la tabla `editorial`
--
ALTER TABLE `editorial`
  ADD PRIMARY KEY (`cod_editorial`);

--
-- Indices de la tabla `libro`
--
ALTER TABLE `libro`
  ADD PRIMARY KEY (`cod_libro`),
  ADD KEY `cod_autor` (`cod_autor`),
  ADD KEY `cod_editorial` (`cod_editorial`);

--
-- Indices de la tabla `notas`
--
ALTER TABLE `notas`
  ADD PRIMARY KEY (`cod_texto`),
  ADD KEY `cedula` (`cedula`);

--
-- Indices de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD KEY `cedula` (`cedula`),
  ADD KEY `cod_libro` (`cod_libro`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`cedula`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `libro`
--
ALTER TABLE `libro`
  ADD CONSTRAINT `libro_ibfk_1` FOREIGN KEY (`cod_autor`) REFERENCES `autor` (`cod_autor`),
  ADD CONSTRAINT `libro_ibfk_2` FOREIGN KEY (`cod_editorial`) REFERENCES `editorial` (`cod_editorial`);

--
-- Filtros para la tabla `notas`
--
ALTER TABLE `notas`
  ADD CONSTRAINT `notas_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuarios` (`cedula`);

--
-- Filtros para la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD CONSTRAINT `prestamo_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuarios` (`cedula`),
  ADD CONSTRAINT `prestamo_ibfk_2` FOREIGN KEY (`cod_libro`) REFERENCES `libro` (`cod_libro`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
