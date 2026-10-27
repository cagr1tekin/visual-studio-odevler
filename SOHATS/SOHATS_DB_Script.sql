USE [SOHATS]
GO

-- Kullanıcılar Tablosu
CREATE TABLE [dbo].[Kullanicilar](
	[kullaniciKod] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAd] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[yetki] [varchar](50) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[kullaniciKod] ASC
)
)
GO

-- Poliklinik Tablosu
CREATE TABLE [dbo].[Poliklinik](
	[poliklinikAdi] [varchar](50) NOT NULL,
	[aciklama] [varchar](250) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK_Poliklinik] PRIMARY KEY CLUSTERED 
(
	[poliklinikAdi] ASC
)
)
GO

-- Hasta Tablosu
CREATE TABLE [dbo].[Hasta](
	[dosyaNo] [varchar](10) NOT NULL,
	[tcNo] [varchar](11) NULL,
	[ad] [varchar](20) NULL,
	[soyad] [varchar](20) NULL,
	[dogumYeri] [varchar](20) NULL,
	[dogumTarihi] [datetime] NULL,
	[babaAdi] [varchar](20) NULL,
	[anneAdi] [varchar](20) NULL,
	[cinsiyet] [varchar](5) NULL,
	[kanGrubu] [varchar](5) NULL,
	[adres] [varchar](250) NULL,
	[tel] [varchar](15) NULL,
	[kurumSicilNo] [varchar](20) NULL,
	[kurumAdi] [varchar](50) NULL,
	[yakinTel] [varchar](15) NULL,
	[yakinKurumSicilNo] [varchar](20) NULL,
	[yakinKurumAdi] [varchar](50) NULL,
 CONSTRAINT [PK_Hasta] PRIMARY KEY CLUSTERED 
(
	[dosyaNo] ASC
)
)
GO

-- Sevk (İşlemler) Tablosu
CREATE TABLE [dbo].[Sevk](
	[sevkTarihi] [datetime] NOT NULL,
	[dosyaNo] [varchar](10) NOT NULL,
	[poliklinik] [varchar](50) NOT NULL,
	[saat] [varchar](5) NULL,
	[yapilanIslem] [varchar](50) NULL,
	[drKod] [int] NULL,
	[miktar] [int] NULL,
	[birimFiyat] [money] NULL,
	[sira] [int] NULL,
	[toplamTutar] [money] NULL,
	[taburcu] [varchar](5) NULL
)
GO

-- Varsayılan Admin Kullanıcısı Ekleme
INSERT INTO Kullanicilar (kullaniciAd, sifre, yetki) VALUES ('admin', '1234', 'admin');
GO
