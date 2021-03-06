USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 2/20/2020 9:04:21 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.EAGLEMSSQL17\MSSQL\DATA\QLTV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.EAGLEMSSQL17\MSSQL\DATA\QLTV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV', N'ON'
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 2/20/2020 9:04:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PublisherId] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Author] [nvarchar](255) NOT NULL,
	[Date] [int] NULL,
	[Price] [float] NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 2/20/2020 9:04:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (1, 1, N'Conan', N'Japan', 1990, 15000, NULL, NULL)
INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (2, 1, N'Conan', N'Japan', 1990, 15000, NULL, NULL)
INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (1002, 1, N'123', N'123', 12, 123, N'Book_1_31_2020_4_12_01_PM.jpg', NULL)
INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (2002, 1, N'Conan', N'Japan', 1990, 15000, NULL, N'<p style="text-align:justify"><em><strong>Th&aacute;m tử lừng danh Conan</strong></em>&nbsp;(名探偵コナン<sup>&nbsp;(Danh th&aacute;m trinh Conan)</sup>&nbsp;<em>Meitantei konan</em><a href="https://vi.wikipedia.org/wiki/Tr%E1%BB%A3_gi%C3%BAp:Ti%E1%BA%BFng_Nh%E1%BA%ADt" title="Trợ giúp:Tiếng Nhật"><sup>?</sup></a>, tựa tiếng Anh: &quot;Detective Conan, Case Closed&quot;)&nbsp;l&agrave; một bộ&nbsp;<a href="https://vi.wikipedia.org/wiki/Manga" title="Manga">manga</a>&nbsp;<a href="https://vi.wikipedia.org/wiki/Nh%E1%BA%ADt_B%E1%BA%A3n" title="Nhật Bản">Nhật Bản</a>&nbsp;thuộc loại trinh th&aacute;m được vẽ v&agrave; minh họa bởi&nbsp;<a href="https://vi.wikipedia.org/wiki/Aoyama_Gosho" title="Aoyama Gosho">Aoyama Gosho</a>. Bộ truyện n&agrave;y ban đầu l&agrave; những chương truyện nhỏ được đăng tr&ecirc;n tuần b&aacute;o&nbsp;<em>Shōnen Sunday</em>&nbsp;của Shogakukan từ 19 th&aacute;ng 1 năm 1994 sau đ&oacute; được đ&oacute;ng th&agrave;nh c&aacute;c tập tankōbon. Tại&nbsp;<a href="https://vi.wikipedia.org/wiki/Vi%E1%BB%87t_Nam" title="Việt Nam">Việt Nam</a>&nbsp;bộ truyện được&nbsp;<a href="https://vi.wikipedia.org/wiki/Nh%C3%A0_xu%E1%BA%A5t_b%E1%BA%A3n_Kim_%C4%90%E1%BB%93ng" title="Nhà xuất bản Kim Đồng">Nh&agrave; xuất bản Kim Đồng</a>&nbsp;ấn h&agrave;nh dưới tựa&nbsp;<em>Th&aacute;m tử lừng danh Conan</em>&nbsp;<sup><a href="https://vi.wikipedia.org/wiki/Th%C3%A1m_t%E1%BB%AD_l%E1%BB%ABng_danh_Conan#cite_note-1">[1]</a></sup>&nbsp;T&aacute;c phẩm xoay quanh c&acirc;u chuyện về ch&agrave;ng th&aacute;m tử học sinh&nbsp;<a href="https://vi.wikipedia.org/wiki/Kudo_Shinichi" title="Kudo Shinichi">Kudo Shinichi</a>&nbsp;trong một lần đang điều tra bị th&agrave;nh vi&ecirc;n Tổ chức &Aacute;o Đen &eacute;p uống thuốc độc khiến cơ thể teo nhỏ v&agrave; trở th&agrave;nh Edogawa Conan.</p>

<p style="text-align:justify">X&ecirc;-ri cũng được chuyển thể th&agrave;nh&nbsp;<a href="https://vi.wikipedia.org/wiki/Anime" title="Anime">anime</a>&nbsp;bởi Yomiuri Telecasting Corporation v&agrave; TMS Entertainment. Tiếp nối anime, nhiều tập phim chủ đề, ngoại truyện (OVA),&nbsp;<a href="https://vi.wikipedia.org/wiki/Tr%C3%B2_ch%C6%A1i_%C4%91i%E1%BB%87n_t%E1%BB%AD" title="Trò chơi điện tử">tr&ograve; chơi điện tử</a>, đĩa nhạc, phim live action cũng được ra đời. Ri&ecirc;ng anime được&nbsp;<a href="https://vi.wikipedia.org/w/index.php?title=C%C3%B4ng_ty_C%E1%BB%95_ph%E1%BA%A7n_Truy%E1%BB%81n_th%C3%B4ng_Tr%C3%AD_Vi%E1%BB%87t&amp;action=edit&amp;redlink=1" title="Công ty Cổ phần Truyền thông Trí Việt (trang chưa được viết)">C&ocirc;ng ty Cổ phần Truyền th&ocirc;ng Tr&iacute; Việt</a>&nbsp;(sau n&agrave;y l&agrave; TTN Media v&agrave; nay l&agrave; Purpose Media) mua&nbsp;<a href="https://vi.wikipedia.org/wiki/B%E1%BA%A3n_quy%E1%BB%81n" title="Bản quyền">bản quyền</a>&nbsp;v&agrave; ph&aacute;t s&oacute;ng tại&nbsp;<a href="https://vi.wikipedia.org/wiki/Vi%E1%BB%87t_Nam" title="Việt Nam">Việt Nam</a>&nbsp;tr&ecirc;n k&ecirc;nh&nbsp;<a href="https://vi.wikipedia.org/wiki/HTV3" title="HTV3">HTV3</a>. C&aacute;c tập tankōbon manga đ&atilde; b&aacute;n được khoảng 200 triệu bản tr&ecirc;n to&agrave;n&nbsp;<a href="https://vi.wikipedia.org/wiki/Th%E1%BA%BF_gi%E1%BB%9Bi" title="Thế giới">thế giới</a>. T&iacute;nh đến&nbsp;<a href="https://vi.wikipedia.org/wiki/Th%C3%A1ng_5" title="Tháng 5">th&aacute;ng 5</a>&nbsp;năm&nbsp;<a href="https://vi.wikipedia.org/wiki/2018" title="2018">2018</a>, Th&aacute;m tử lừng danh Conan l&agrave; bộ manga b&aacute;n chạy thứ 4 trong lịch sử, chỉ xếp sau ba c&aacute;i t&ecirc;n&nbsp;<em><a href="https://vi.wikipedia.org/wiki/One_Piece" title="One Piece">One Piece</a></em>,&nbsp;<em><a href="https://vi.wikipedia.org/wiki/B%E1%BA%A3y_vi%C3%AAn_ng%E1%BB%8Dc_r%E1%BB%93ng" title="Bảy viên ngọc rồng">Bảy vi&ecirc;n ngọc rồng</a></em>&nbsp;v&agrave;&nbsp;<em><a href="https://vi.wikipedia.org/wiki/Naruto" title="Naruto">Naruto</a></em>. Năm&nbsp;<a href="https://vi.wikipedia.org/wiki/2001" title="2001">2001</a>, bộ manga nhận được&nbsp;<a href="https://vi.wikipedia.org/wiki/Gi%E1%BA%A3i_Manga_Shogakukan" title="Giải Manga Shogakukan">Giải Manga Shogakukan</a>&nbsp;lần thứ 46 cho hạng mục&nbsp;<em><a href="https://vi.wikipedia.org/wiki/Sh%C5%8Dnen_manga" title="Shōnen manga">shōnen</a></em>.</p>
')
INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (3002, 1, N'Hoàng tử Ai Cập', N'Someone', 2005, 15000, NULL, N'<p style="text-align:center"><strong>Devmaster Academy</strong></p>

<p><a href="https://dantri.com.vn/the-gioi/trung-quoc-lai-thay-doi-cach-tinh-so-ca-nhiem-virus-corona-giam-ky-luc-20200220134406067.htm" title="Trung Quốc lại thay đổi cách tính, số ca nhiễm virus corona giảm kỷ lục">Trung Quốc lại thay đổi c&aacute;ch t&iacute;nh, số ca nhiễm virus corona giảm kỷ lục</a></p>

<p>(D&acirc;n tr&iacute;)&nbsp;- Việc thay đổi định nghĩa người nhiễm virus corona chủng mới lần thứ hai trong v&ograve;ng một tuần khiến số ca nhiễm mới ở Trung Quốc trong ng&agrave;y 19/2 giảm mạnh.</p>
')
INSERT [dbo].[Book] ([Id], [PublisherId], [Name], [Author], [Date], [Price], [Image], [Description]) VALUES (3003, 1, N'Doraemon', N'Nhật', 1999, 20000, NULL, N'<p><img alt="" src="data:image/png;base64,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" style="height:146px; width:238px" /></p>
')
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (1, N'Kim Đồng')
INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (2, N'ĐH BK')
INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (3, N'ĐH GTVT')
INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (4, N'HV BCVT')
INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (5, N'ĐH KTQD')
INSERT [dbo].[Publisher] ([Id], [Name]) VALUES (6, N'ĐH XD')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publisher] ([Id])
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
