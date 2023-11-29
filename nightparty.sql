-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29/11/2023 às 01:27
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `nightparty`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `artistas`
--

CREATE TABLE `artistas` (
  `idartistas` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `artistas`
--

INSERT INTO `artistas` (`idartistas`, `nome`) VALUES
(1, 'Linkin Park'),
(2, 'Bad Omens'),
(3, 'My Chemical Romance'),
(4, 'Evanescence'),
(5, 'Falling In Reverse'),
(6, 'Stray Kids'),
(8, 'BTS');

-- --------------------------------------------------------

--
-- Estrutura para tabela `categorias`
--

CREATE TABLE `categorias` (
  `idcategorias` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `categorias`
--

INSERT INTO `categorias` (`idcategorias`, `nome`) VALUES
(1, 'Drink'),
(2, 'Whisky'),
(3, 'Chopp'),
(4, 'Cerveja'),
(5, 'Vinho'),
(6, 'Cocktail sem álcool'),
(7, 'Porção'),
(8, 'Espetinho');

-- --------------------------------------------------------

--
-- Estrutura para tabela `musicaplaylist`
--

CREATE TABLE `musicaplaylist` (
  `idmusicaplaylist` int(11) NOT NULL,
  `idmusica` int(11) NOT NULL,
  `idplaylist` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `musicaplaylist`
--

INSERT INTO `musicaplaylist` (`idmusicaplaylist`, `idmusica`, `idplaylist`) VALUES
(1, 2, 1),
(6, 5, 1),
(28, 5, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `musicas`
--

CREATE TABLE `musicas` (
  `idmusicas` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `idartistas` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `musicas`
--

INSERT INTO `musicas` (`idmusicas`, `nome`, `idartistas`, `idusuario`) VALUES
(1, 'In the End', 1, 1),
(2, 'Helena', 3, 1),
(3, 'ARTIFICIAL SUICIDE', 2, 1),
(4, 'Going Under', 4, 1),
(5, 'Popular Monster', 5, 1),
(6, 'Numb', 1, 2),
(8, ' Silent Cry', 6, 2),
(11, 'a', 1, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedidos`
--

CREATE TABLE `pedidos` (
  `idpedidos` int(11) NOT NULL,
  `numpedido` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `idproduto` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `status` tinyint(1) NOT NULL,
  `data` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `pedidos`
--

INSERT INTO `pedidos` (`idpedidos`, `numpedido`, `idusuario`, `idproduto`, `quantidade`, `status`, `data`) VALUES
(1, 1, 2, 4, 1, 1, '2023-11-28 20:25:33'),
(2, 1, 2, 3, 2, 1, '2023-11-28 20:25:39'),
(3, 1, 2, 1, 1, 1, '2023-11-28 20:25:47'),
(4, 7, 2, 1, 1, 0, '2023-11-28 20:46:43'),
(5, 7, 2, 4, 2, 0, '2023-11-28 20:46:53'),
(6, 9, 2, 3, 1, 0, '2023-11-28 20:48:27');

-- --------------------------------------------------------

--
-- Estrutura para tabela `playlist`
--

CREATE TABLE `playlist` (
  `idplaylist` int(31) NOT NULL,
  `idmusica` int(11) NOT NULL,
  `data` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `playlist`
--

INSERT INTO `playlist` (`idplaylist`, `idmusica`, `data`) VALUES
(0, 2, '2023-11-28 00:00:00'),
(1, 1, '2023-11-24 00:00:00'),
(2, 4, '2023-11-24 00:00:00'),
(1, 3, '2023-11-28 02:34:53'),
(2, 5, '2023-11-28 02:36:38'),
(28, 2, '2023-11-28 02:41:57'),
(28, 4, '2023-11-28 02:42:42'),
(28, 1, '2023-11-28 03:07:44'),
(28, 3, '2023-11-28 03:10:53'),
(28, 1, '2023-11-28 03:13:48'),
(28, 8, '2023-11-28 15:32:05');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtos`
--

CREATE TABLE `produtos` (
  `idprodutos` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `preco` double NOT NULL,
  `idcategoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `produtos`
--

INSERT INTO `produtos` (`idprodutos`, `nome`, `preco`, `idcategoria`) VALUES
(1, 'Caipirinha', 7, 1),
(2, 'Carne', 70, 7),
(3, 'Mojito', 10, 1),
(4, 'Batata', 30, 7),
(9, 'a', 1, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome_completo` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL,
  `senha` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome_completo`, `email`, `senha`) VALUES
(1, 'Administrador José', 'admin@admin.com', 'd033e22ae348aeb5660fc2140aec35850c4da997'),
(2, 'a', 'a', '86f7e437faa5a7fce15d1ddcb9eaeaea377667b8'),
(3, 'Brasil da Silva', 'brasilva@gmail.com', '596436301e3425fc9d0c066c54250da087478d32ebd4deda21148e7a90813ba0');

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_bebidas`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_bebidas` (
`IDProduto` int(11)
,`Produto` varchar(200)
,`Preco` double
,`Categoria` varchar(200)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_comidas`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_comidas` (
`IDProduto` int(11)
,`Produto` varchar(200)
,`Preco` double
,`Categoria` varchar(200)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_musicas`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_musicas` (
`IDMusica` int(11)
,`Título` varchar(200)
,`IDArtista(s)` int(11)
,`Artista(s)` varchar(200)
,`RespAdd` varchar(200)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_pedidos`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_pedidos` (
`NumeroDaMesa` int(11)
,`Cliente` varchar(200)
,`Produto` varchar(200)
,`Preco` double
,`Quantidade` int(11)
,`TotalPedido` double
,`Status` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_playlist`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_playlist` (
`IDMusica` int(11)
,`Música` varchar(200)
,`IDPlaylist` int(31)
,`Data` datetime
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_produtos`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_produtos` (
`Id` int(11)
,`Nome` varchar(200)
,`Preco` double
,`IDCategoria` int(11)
,`Categoria` varchar(200)
);

-- --------------------------------------------------------

--
-- Estrutura para view `view_bebidas`
--
DROP TABLE IF EXISTS `view_bebidas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_bebidas`  AS SELECT `produtos`.`idprodutos` AS `IDProduto`, `produtos`.`nome` AS `Produto`, `produtos`.`preco` AS `Preco`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`idcategoria` = `categorias`.`idcategorias`)) WHERE `categorias`.`idcategorias` < 6 ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_comidas`
--
DROP TABLE IF EXISTS `view_comidas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_comidas`  AS SELECT `produtos`.`idprodutos` AS `IDProduto`, `produtos`.`nome` AS `Produto`, `produtos`.`preco` AS `Preco`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`idcategoria` = `categorias`.`idcategorias`)) WHERE `categorias`.`idcategorias` > 6 ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_musicas`
--
DROP TABLE IF EXISTS `view_musicas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_musicas`  AS SELECT `musicas`.`idmusicas` AS `IDMusica`, `musicas`.`nome` AS `Título`, `artistas`.`idartistas` AS `IDArtista(s)`, `artistas`.`nome` AS `Artista(s)`, `usuarios`.`nome_completo` AS `RespAdd` FROM ((`musicas` join `artistas` on(`musicas`.`idartistas` = `artistas`.`idartistas`)) join `usuarios` on(`musicas`.`idusuario` = `usuarios`.`id`)) ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_pedidos`
--
DROP TABLE IF EXISTS `view_pedidos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_pedidos`  AS SELECT `pedidos`.`numpedido` AS `NumeroDaMesa`, `usuarios`.`nome_completo` AS `Cliente`, `produtos`.`nome` AS `Produto`, `produtos`.`preco` AS `Preco`, `pedidos`.`quantidade` AS `Quantidade`, `produtos`.`preco`* `pedidos`.`quantidade` AS `TotalPedido`, `pedidos`.`status` AS `Status` FROM ((`pedidos` join `usuarios` on(`pedidos`.`idusuario` = `usuarios`.`id`)) join `produtos` on(`pedidos`.`idproduto` = `produtos`.`idprodutos`)) ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_playlist`
--
DROP TABLE IF EXISTS `view_playlist`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_playlist`  AS SELECT `musicas`.`idmusicas` AS `IDMusica`, `musicas`.`nome` AS `Música`, `playlist`.`idplaylist` AS `IDPlaylist`, `playlist`.`data` AS `Data` FROM (`playlist` join `musicas` on(`playlist`.`idmusica` = `musicas`.`idmusicas`)) ;

-- --------------------------------------------------------

--
-- Estrutura para view `view_produtos`
--
DROP TABLE IF EXISTS `view_produtos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_produtos`  AS SELECT `produtos`.`idprodutos` AS `Id`, `produtos`.`nome` AS `Nome`, `produtos`.`preco` AS `Preco`, `categorias`.`idcategorias` AS `IDCategoria`, `categorias`.`nome` AS `Categoria` FROM (`produtos` join `categorias` on(`produtos`.`idcategoria` = `categorias`.`idcategorias`)) ;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `artistas`
--
ALTER TABLE `artistas`
  ADD PRIMARY KEY (`idartistas`);

--
-- Índices de tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`idcategorias`);

--
-- Índices de tabela `musicaplaylist`
--
ALTER TABLE `musicaplaylist`
  ADD PRIMARY KEY (`idmusicaplaylist`),
  ADD KEY `fk_MusicaPlaylist_Musicas1_idx` (`idmusica`),
  ADD KEY `fk_MusicaPlaylist_Playlist1_idx` (`idplaylist`);

--
-- Índices de tabela `musicas`
--
ALTER TABLE `musicas`
  ADD PRIMARY KEY (`idmusicas`),
  ADD KEY `fk_Musicas_Usuarios1_idx` (`idusuario`),
  ADD KEY `fk_Musicas_Artistas1_idx` (`idartistas`);

--
-- Índices de tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`idpedidos`),
  ADD KEY `fk_Pedidos_Produtos1_idx` (`idproduto`),
  ADD KEY `fk_Pedidos_Usuarios1_idx` (`idusuario`);

--
-- Índices de tabela `playlist`
--
ALTER TABLE `playlist`
  ADD KEY `fk_Playlist_Musicas1_idx` (`idmusica`),
  ADD KEY `a` (`idplaylist`) USING BTREE;

--
-- Índices de tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idprodutos`),
  ADD KEY `fk_Produtos_Categorias1_idx` (`idcategoria`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`) USING BTREE;

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `artistas`
--
ALTER TABLE `artistas`
  MODIFY `idartistas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `idcategorias` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `musicaplaylist`
--
ALTER TABLE `musicaplaylist`
  MODIFY `idmusicaplaylist` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de tabela `musicas`
--
ALTER TABLE `musicas`
  MODIFY `idmusicas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `idpedidos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `idprodutos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `musicaplaylist`
--
ALTER TABLE `musicaplaylist`
  ADD CONSTRAINT `fk_musica` FOREIGN KEY (`idmusica`) REFERENCES `musicas` (`idmusicas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_playlist` FOREIGN KEY (`idplaylist`) REFERENCES `playlist` (`idplaylist`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `musicas`
--
ALTER TABLE `musicas`
  ADD CONSTRAINT `fk_Artista` FOREIGN KEY (`idartistas`) REFERENCES `artistas` (`idartistas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Usuario` FOREIGN KEY (`idusuario`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `fk_Usuario1` FOREIGN KEY (`idusuario`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_idProduto` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`idprodutos`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `playlist`
--
ALTER TABLE `playlist`
  ADD CONSTRAINT `fk_idMusica2` FOREIGN KEY (`idmusica`) REFERENCES `musicas` (`idmusicas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `fk_idCategoria` FOREIGN KEY (`idcategoria`) REFERENCES `categorias` (`idcategorias`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
