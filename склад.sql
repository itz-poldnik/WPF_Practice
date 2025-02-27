USE [Warehouse]
GO
/****** Object:  Table [dbo].[Balance]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balance](
	[id_balance] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[id_invoice] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[id_product] [int] NULL,
	[Quantity] [int] NULL,
	[id_shop] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[id_invoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[id_supplier] [int] NULL,
	[id_product] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Unit] [nvarchar](50) NULL,
	[id_supplier] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[id_shop] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[id_shop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 06.12.2024 8:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[id_supplier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[id_supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Balance] ON 

INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (91, 1, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (92, 2, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (93, 3, 30)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (94, 4, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (95, 5, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (96, 6, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (97, 7, 30)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (98, 8, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (99, 9, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (100, 10, 40)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (101, 11, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (102, 12, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (103, 13, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (104, 14, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (105, 15, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (106, 16, 0)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (107, 17, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (108, 18, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (109, 19, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (110, 20, 50)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (111, 21, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (112, 22, 30)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (113, 23, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (114, 24, 30)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (115, 25, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (116, 26, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (117, 27, 10)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (118, 28, 40)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (119, 29, 20)
INSERT [dbo].[Balance] ([id_balance], [id_product], [Quantity]) VALUES (120, 30, 30)
SET IDENTITY_INSERT [dbo].[Balance] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (1, CAST(N'2023-01-06' AS Date), 16, 20, 5)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (2, CAST(N'2023-02-08' AS Date), 7, 50, 13)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (3, CAST(N'2023-03-10' AS Date), 14, 20, 24)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (4, CAST(N'2023-04-12' AS Date), 17, 20, 9)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (5, CAST(N'2023-05-14' AS Date), 22, 10, 17)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (6, CAST(N'2023-06-16' AS Date), 1, 30, 30)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (7, CAST(N'2023-07-18' AS Date), 12, 30, 1)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (8, CAST(N'2023-08-20' AS Date), 15, 60, 4)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (9, CAST(N'2023-09-22' AS Date), 6, 20, 23)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (10, CAST(N'2023-10-24' AS Date), 29, 50, 12)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (11, CAST(N'2023-11-26' AS Date), 13, 10, 25)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (12, CAST(N'2023-12-28' AS Date), 28, 40, 10)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (13, CAST(N'2023-12-31' AS Date), 3, 70, 18)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (14, CAST(N'2024-01-04' AS Date), 11, 70, 7)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (15, CAST(N'2024-02-06' AS Date), 23, 20, 16)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (16, CAST(N'2024-02-28' AS Date), 8, 50, 22)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (17, CAST(N'2024-03-08' AS Date), 27, 60, 8)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (18, CAST(N'2024-03-30' AS Date), 2, 10, 28)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (19, CAST(N'2024-04-05' AS Date), 18, 10, 3)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (20, CAST(N'2024-05-03' AS Date), 5, 70, 20)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (21, CAST(N'2024-05-15' AS Date), 26, 40, 14)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (22, CAST(N'2024-06-09' AS Date), 19, 10, 26)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (23, CAST(N'2024-07-01' AS Date), 30, 70, 27)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (24, CAST(N'2024-07-24' AS Date), 9, 10, 6)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (25, CAST(N'2024-08-10' AS Date), 21, 70, 19)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (26, CAST(N'2024-08-20' AS Date), 24, 60, 29)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (27, CAST(N'2024-09-02' AS Date), 4, 20, 2)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (28, CAST(N'2024-09-29' AS Date), 25, 20, 15)
INSERT [dbo].[Invoice] ([id_invoice], [Date], [id_product], [Quantity], [id_shop]) VALUES (29, CAST(N'2024-10-23' AS Date), 20, 50, 21)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (1, CAST(N'2023-01-05' AS Date), 5, 10, 40, 20000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (2, CAST(N'2023-02-07' AS Date), 17, 28, 80, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (3, CAST(N'2023-03-09' AS Date), 8, 16, 20, 10000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (4, CAST(N'2023-04-11' AS Date), 12, 4, 30, 40000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (5, CAST(N'2023-05-13' AS Date), 4, 12, 50, 70000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (6, CAST(N'2023-06-15' AS Date), 19, 29, 70, 60000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (7, CAST(N'2023-07-17' AS Date), 28, 19, 20, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (8, CAST(N'2023-08-19' AS Date), 2, 3, 100, 10000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (9, CAST(N'2023-09-21' AS Date), 13, 17, 30, 90000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (10, CAST(N'2023-10-23' AS Date), 1, 22, 40, 80000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (11, CAST(N'2023-11-25' AS Date), 24, 27, 70, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (12, CAST(N'2023-12-27' AS Date), 3, 13, 20, 70000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (13, CAST(N'2023-12-30' AS Date), 18, 11, 80, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (14, CAST(N'2024-01-03' AS Date), 26, 30, 100, 20000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (15, CAST(N'2024-02-05' AS Date), 20, 5, 90, 80000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (16, CAST(N'2024-02-27' AS Date), 14, 18, 20, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (17, CAST(N'2024-03-07' AS Date), 10, 6, 40, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (18, CAST(N'2024-03-29' AS Date), 6, 21, 90, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (19, CAST(N'2024-04-04' AS Date), 30, 2, 30, 20000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (20, CAST(N'2024-05-02' AS Date), 11, 26, 50, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (21, CAST(N'2024-05-14' AS Date), 27, 7, 80, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (22, CAST(N'2024-06-08' AS Date), 9, 20, 100, 70000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (23, CAST(N'2024-06-30' AS Date), 16, 23, 30, 20000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (24, CAST(N'2024-07-23' AS Date), 23, 8, 60, 80000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (25, CAST(N'2024-08-09' AS Date), 15, 9, 20, 50000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (26, CAST(N'2024-08-19' AS Date), 25, 24, 90, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (27, CAST(N'2024-09-01' AS Date), 7, 1, 50, 60000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (28, CAST(N'2024-09-28' AS Date), 29, 14, 40, 40000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (29, CAST(N'2024-10-22' AS Date), 22, 25, 30, 30000.0000)
INSERT [dbo].[Order] ([id_order], [Date], [id_supplier], [id_product], [Quantity], [Price]) VALUES (30, CAST(N'2024-11-13' AS Date), 21, 15, 70, 60000.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (1, N'Молоко ', N'Пастеризованное молоко жирностью 3,2%', N'литр', 1)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (2, N'Хлеб', N'Белый хлеб формовой', N'штука', 2)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (3, N'Яблоки', N'Сочные яблоки сорта Голден', N'килограмм', 3)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (4, N'Сахар', N'Песок сахарный', N'килограмм', 4)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (5, N'Чай', N'Черный чай в пакетиках', N'упаковка', 5)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (6, N'Гречка', N'Крупа гречневая ядрица', N'килограмм', 6)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (7, N'Масло', N'Подсолнечное масло', N'литр', 7)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (8, N'Сыр', N'Российский сыр', N'килограмм', 8)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (9, N'Шоколад', N'Темный шоколад с орехами', N'плитка', 9)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (10, N'Кофе', N'Молотый кофе', N'упаковка', 10)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (11, N'Овсянка', N'Геркулесовая крупа', N'килограмм', 11)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (12, N'Бананы', N'Спелые бананы', N'килограмм', 12)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (13, N'Йогурт', N'Натуральный йогурт без добавок', N'литр', 13)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (14, N'Рис', N'Круглозернистый рис', N'килограмм', 14)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (15, N'Картофель', N'Молодой картофель', N'килограмм', 15)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (16, N'Морковь', N'Свежая морковь', N'килограмм', 16)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (17, N'Лук', N'Репчатый лук', N'килограмм', 17)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (18, N'Огурцы', N'Свежие огурцы', N'килограмм', 18)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (19, N'Помидоры', N'Спелые помидоры', N'килограмм', 19)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (20, N'Перец', N'Болгарский перец', N'килограмм', 20)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (21, N'Кабачки', N'Молодые кабачки', N'килограмм', 21)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (22, N'Баклажаны', N'Свежие баклажаны', N'килограмм', 22)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (23, N'Апельсины', N'Сладкие апельсины', N'килограмм', 23)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (24, N'Лимоны', N'Кислые лимоны', N'килограмм', 24)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (25, N'Виноград', N'Красный виноград', N'килограмм', 25)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (26, N'Гранаты', N'Зрелые гранаты', N'штука', 26)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (27, N'Арбузы', N'Сочные арбузы', N'штука', 27)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (28, N'Дыни', N'Медовые дыни', N'штука', 28)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (29, N'Грибы', N'Шампиньоны свежие', N'килограмм', 29)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (30, N'Курица', N'Филе куриное', N'килограмм', 30)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (38, N'Сыр твердый', N'Российский сыр, классический вкус', N'килограмм', 7)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (39, N'Сыр', N'Сыр сыр сыр', N'килограмм', 7)
INSERT [dbo].[Product] ([id_product], [Name], [Description], [Unit], [id_supplier]) VALUES (40, N'Орехи', N'Грецкие орехи', N'грамм', 7)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Shop] ON 

INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (1, N'Свежий выбор', N'Кемерово', N'83665873434')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (2, N'Вкусный дом', N'Астрахань', N'84627502355')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (3, N'Городской урожай', N'Новосибирск', N'80353560365')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (4, N'Продуктовый рай', N'Екатеринбург', N'83655066723')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (5, N'Семейное изобилие', N'Казань', N'81440274393')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (6, N'Кухня радости', N'Челябинск', N'82787230234')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (7, N'Зеленый базар', N'Самара', N'89395035632')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (8, N'Домашний вкус', N'Омск', N'83673356023')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (9, N'Едим дома', N'Ровнов-На-Дону', N'82351145563')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (10, N'Урожайные ряды', N'Уфа', N'84365324025')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (11, N'Гурмания', N'Красноярск', N'84966250345')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (12, N'Бахча', N'Воронеж', N'83456250364')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (13, N'Пищевой дворик', N'Пермь', N'82395443035')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (14, N'Магнат продуктов', N'Волгоград', N'82564542340')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (15, N'Овощной бум', N'Краснодар', N'82345342034')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (16, N'Корзинка вкуса', N'Саратов', N'85230774826')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (17, N'Природный клад', N'Тюмень', N'87235450325')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (18, N'Аппетитный мир', N'Тольятти', N'83464505925')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (19, N'Закрома Родины', N'Ижевск', N'83240594364')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (20, N'Сытный уголок', N'Барнаул', N'83459435265')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (21, N'Радуга вкусов', N'Ульяновск', N'84593460035')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (22, N'Дары природы', N'Хабаровск', N'83956540352')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (23, N'Хлебосольный двор', N'Владивосток', N'83904503353')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (24, N'Витаминка', N'Ярославль', N'83053467214')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (25, N'Изобилие', N'Иркутск', N'83201252164')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (26, N'Поле вкуса', N'Оренбург', N'83200215235')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (27, N'Трапезная лавка', N'Новокузнецк', N'82390214632')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (28, N'Рынок свежих идей', N'Рязань', N'83060942156')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (29, N'Гармония вкуса', N'Пенза', N'82302145143')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (30, N'Панорама вкуса', N'Томск', N'82034549234')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (31, N'Альфа-бетта', N'Липецк', N'8346391204')
INSERT [dbo].[Shop] ([id_shop], [Name], [Address], [Phone]) VALUES (32, N'Гамма', N'Тюмень', N'83567153902')
SET IDENTITY_INSERT [dbo].[Shop] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (1, N'Молочный завод', N'83652753657', N'Москва')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (2, N'Хлебозавод №1', N'82647489374', N'Санкт-Петербург')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (3, N'Садоводство', N'84728573853', N'Одинцово')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (4, N'Сахарный комбинат', N'83567542325', N'Борисоглебск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (5, N'Чайная фабрика', N'84367865379', N'Сочи')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (6, N'Крупяной склад', N'81252574475', N'Великий Новгород')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (7, N'Маслоперерабатывающий завод', N'82459366746', N'Новомосковск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (8, N'Сыродельня', N'85356785312', N'Пушкино')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (9, N'Кондитерская фабрика', N'84523891256', N'Торжок')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (10, N'Кофейный дом', N'82134674639', N'Рыбинск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (11, N'Овсяной комбинат', N'84324567624', N'Вязьма')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (12, N'Фруктовый сад', N'85326896432', N'Обнинск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (13, N'Молочная ферма', N'85642680653', N'Ковров')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (14, N'Рисовый завод', N'80953789765', N'Камышин')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (15, N'Картофелеводческое хозяйство', N'86440745753', N'Рассказово')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (16, N'Овощехранилище', N'86420426574', N'Елец')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (17, N'Луковое поле', N'82435678065', N'Ливны')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (18, N'Тепличное хозяйство', N'86354670643', N'Старый Оскол')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (19, N'Томатовое поле', N'86434768076', N'Железногорск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (20, N'Перцевое хозяйство', N'89064760547', N'Навозыбков')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (21, N'Кабачковый огород', N'87540764566', N'Кинешма')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (22, N'Баклажанновое поле', N'80755760657', N'Буй')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (23, N'Цитрусовая плантация', N'85642434706', N'Ахтубинск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (24, N'Лимонный сад', N'85645346066', N'Волгодонск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (25, N'Виноградник', N'86342052327', N'Пятигорск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (26, N'Гранатовый сад', N'86420535760', N'Махачкала')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (27, N'Арбузная бахча', N'86432506547', N'Бакалоко')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (28, N'Дынная плантация', N'89549056065', N'Орск')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (29, N'Гриборазводческая ферма', N'80654064321', N'Кузнецк')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (30, N'Птицефабрика', N'80560643312', N'Димитровград')
INSERT [dbo].[Supplier] ([id_supplier], [Name], [Phone], [Address]) VALUES (31, N'От дяди Васи', N'82830371620', N'Курск')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
ALTER TABLE [dbo].[Balance]  WITH CHECK ADD  CONSTRAINT [FK_Balance_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id_product])
GO
ALTER TABLE [dbo].[Balance] CHECK CONSTRAINT [FK_Balance_Product]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id_product])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Product]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Shop] FOREIGN KEY([id_shop])
REFERENCES [dbo].[Shop] ([id_shop])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Shop]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id_product])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Supplier] FOREIGN KEY([id_supplier])
REFERENCES [dbo].[Supplier] ([id_supplier])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Supplier]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([id_supplier])
REFERENCES [dbo].[Supplier] ([id_supplier])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
