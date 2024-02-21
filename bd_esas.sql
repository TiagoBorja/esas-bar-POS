-- --------------------------------------------------------
-- Anfitrião:                    127.0.0.1
-- Versão do servidor:           10.4.28-MariaDB - mariadb.org binary distribution
-- SO do servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- A despejar estrutura da base de dados para bar_do_esas
DROP DATABASE IF EXISTS `bar_do_esas`;
CREATE DATABASE IF NOT EXISTS `bar_do_esas` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `bar_do_esas`;

-- A despejar estrutura para tabela bar_do_esas.aluno
DROP TABLE IF EXISTS `aluno`;
CREATE TABLE IF NOT EXISTS `aluno` (
  `N_Aluno` int(11) NOT NULL,
  `Nome_Aluno` varchar(50) NOT NULL,
  `Data_Nasc` date NOT NULL,
  `Saldo` double DEFAULT NULL,
  PRIMARY KEY (`N_Aluno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela bar_do_esas.bar
DROP TABLE IF EXISTS `bar`;
CREATE TABLE IF NOT EXISTS `bar` (
  `N_Aluno` int(11) NOT NULL,
  `Cod_Comida` int(11) NOT NULL,
  `Data_Compra` datetime NOT NULL,
  `N_Funcionario` int(11) NOT NULL,
  `Qt_Pedida` int(11) NOT NULL,
  PRIMARY KEY (`N_Aluno`,`Cod_Comida`,`Data_Compra`),
  KEY `N_Funcionario` (`N_Funcionario`),
  KEY `FK_bar_inforcomida` (`Cod_Comida`),
  CONSTRAINT `FK_bar_aluno` FOREIGN KEY (`N_Aluno`) REFERENCES `aluno` (`N_Aluno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_bar_inforcomida` FOREIGN KEY (`Cod_Comida`) REFERENCES `inforcomida` (`Cod_Comida`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `bar_ibfk_1` FOREIGN KEY (`N_Funcionario`) REFERENCES `funcionario` (`N_Funcionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela bar_do_esas.funcionario
DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `N_Funcionario` int(11) NOT NULL,
  `Nome_Funcionario` varchar(50) DEFAULT NULL,
  `Data_Entrada` datetime NOT NULL,
  `Data_Saida` datetime NOT NULL,
  `Senha` int(11) DEFAULT NULL,
  PRIMARY KEY (`N_Funcionario`,`Data_Entrada`,`Data_Saida`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela bar_do_esas.inforcomida
DROP TABLE IF EXISTS `inforcomida`;
CREATE TABLE IF NOT EXISTS `inforcomida` (
  `Cod_Comida` int(11) NOT NULL,
  `Descricao_Comida` varchar(50) DEFAULT NULL,
  `Valor_Comida` double DEFAULT NULL,
  PRIMARY KEY (`Cod_Comida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
