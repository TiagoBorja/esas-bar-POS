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

-- A despejar dados para tabela bar_do_esas.aluno: ~3 rows (aproximadamente)
DELETE FROM `aluno`;
INSERT INTO `aluno` (`N_Aluno`, `Nome_Aluno`, `Data_Nasc`, `Saldo`) VALUES
	(16742, 'Marcos Santos', '2007-04-29', 1.5),
	(19018, 'Tiago Rodrigues', '2005-12-02', 0),
	(19019, 'Guilherme Rodrigues', '2007-06-21', 0.57);

-- A despejar estrutura para tabela bar_do_esas.bar
DROP TABLE IF EXISTS `bar`;
CREATE TABLE IF NOT EXISTS `bar` (
  `N_Aluno` int(11) NOT NULL,
  `Cod_Comida` int(11) NOT NULL,
  `Data_Compra` datetime NOT NULL,
  `N_Funcionario` int(11) NOT NULL,
  `Qt_Pedida` int(11) NOT NULL,
  PRIMARY KEY (`N_Aluno`,`Cod_Comida`,`Data_Compra`,`N_Funcionario`),
  KEY `FK_bar_infocomida` (`Cod_Comida`),
  KEY `FK_bar_dados_funcionario` (`N_Funcionario`),
  CONSTRAINT `FK_bar_aluno` FOREIGN KEY (`N_Aluno`) REFERENCES `aluno` (`N_Aluno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_bar_dados_funcionario` FOREIGN KEY (`N_Funcionario`) REFERENCES `dados_funcionario` (`N_Funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_bar_infocomida` FOREIGN KEY (`Cod_Comida`) REFERENCES `infocomida` (`Cod_Comida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- A despejar dados para tabela bar_do_esas.bar: ~0 rows (aproximadamente)
DELETE FROM `bar`;

-- A despejar estrutura para tabela bar_do_esas.dados_funcionario
DROP TABLE IF EXISTS `dados_funcionario`;
CREATE TABLE IF NOT EXISTS `dados_funcionario` (
  `N_Funcionario` int(11) NOT NULL,
  `Nome_Funcionario` varchar(140) DEFAULT NULL,
  `Senha` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`N_Funcionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- A despejar dados para tabela bar_do_esas.dados_funcionario: ~0 rows (aproximadamente)
DELETE FROM `dados_funcionario`;

-- A despejar estrutura para tabela bar_do_esas.funcionario
DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `N_Funcionario` int(11) NOT NULL,
  `Horario_Entrada` time NOT NULL,
  `Horario_Saida` time NOT NULL,
  PRIMARY KEY (`Horario_Entrada`,`Horario_Saida`,`N_Funcionario`) USING BTREE,
  KEY `FK_funcionario_dados_funcionario` (`N_Funcionario`),
  CONSTRAINT `FK_funcionario_dados_funcionario` FOREIGN KEY (`N_Funcionario`) REFERENCES `dados_funcionario` (`N_Funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_funcionario_horarios` FOREIGN KEY (`Horario_Entrada`, `Horario_Saida`) REFERENCES `horarios` (`Horario_Entrada`, `Horario_Saida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- A despejar dados para tabela bar_do_esas.funcionario: ~0 rows (aproximadamente)
DELETE FROM `funcionario`;

-- A despejar estrutura para tabela bar_do_esas.horarios
DROP TABLE IF EXISTS `horarios`;
CREATE TABLE IF NOT EXISTS `horarios` (
  `Horario_Entrada` time NOT NULL,
  `Horario_Saida` time NOT NULL,
  PRIMARY KEY (`Horario_Entrada`,`Horario_Saida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- A despejar dados para tabela bar_do_esas.horarios: ~0 rows (aproximadamente)
DELETE FROM `horarios`;

-- A despejar estrutura para tabela bar_do_esas.infocomida
DROP TABLE IF EXISTS `infocomida`;
CREATE TABLE IF NOT EXISTS `infocomida` (
  `Cod_Comida` int(11) NOT NULL,
  `Descricao_Comida` varchar(50) DEFAULT NULL,
  `Valor_Comida` double DEFAULT NULL,
  PRIMARY KEY (`Cod_Comida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- A despejar dados para tabela bar_do_esas.infocomida: ~2 rows (aproximadamente)
DELETE FROM `infocomida`;
INSERT INTO `infocomida` (`Cod_Comida`, `Descricao_Comida`, `Valor_Comida`) VALUES
	(11, 'Pão com Fiambre', 0.35),
	(12, 'Galão e Pão com Manteiga', 0.35),
	(32, 'Queque de Chocolate', 0.55);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
