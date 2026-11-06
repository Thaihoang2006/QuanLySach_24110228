IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [TheLoais] (
    [MaLoai] nvarchar(10) NOT NULL,
    [TenLoai] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_TheLoais] PRIMARY KEY ([MaLoai])
);

CREATE TABLE [Sachs] (
    [MaSach] nvarchar(20) NOT NULL,
    [TenSach] nvarchar(150) NOT NULL,
    [NgayNhap] datetime2 NOT NULL,
    [SoLuong] int NOT NULL,
    [DonGia] decimal(18,2) NOT NULL,
    [MaLoai] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_Sachs] PRIMARY KEY ([MaSach]),
    CONSTRAINT [FK_Sachs_TheLoais_MaLoai] FOREIGN KEY ([MaLoai]) REFERENCES [TheLoais] ([MaLoai]) ON DELETE CASCADE
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaLoai', N'TenLoai') AND [object_id] = OBJECT_ID(N'[TheLoais]'))
    SET IDENTITY_INSERT [TheLoais] ON;
INSERT INTO [TheLoais] ([MaLoai], [TenLoai])
VALUES (N'NN', N'Ngoại ngữ'),
(N'TH', N'Tin học'),
(N'TOAN', N'Toán học');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaLoai', N'TenLoai') AND [object_id] = OBJECT_ID(N'[TheLoais]'))
    SET IDENTITY_INSERT [TheLoais] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSach', N'DonGia', N'MaLoai', N'NgayNhap', N'SoLuong', N'TenSach') AND [object_id] = OBJECT_ID(N'[Sachs]'))
    SET IDENTITY_INSERT [Sachs] ON;
INSERT INTO [Sachs] ([MaSach], [DonGia], [MaLoai], [NgayNhap], [SoLuong], [TenSach])
VALUES (N'S001', 150000.0, N'TH', '2026-10-01T00:00:00.0000000', 10, N'Lập trình C# cơ bản'),
(N'S002', 120000.0, N'TH', '2026-10-05T00:00:00.0000000', 15, N'Cơ sở dữ liệu'),
(N'S003', 95000.0, N'TOAN', '2026-10-10T00:00:00.0000000', 12, N'Giải tích 1'),
(N'S004', 110000.0, N'NN', '2026-10-15T00:00:00.0000000', 20, N'Tiếng Anh giao tiếp'),
(N'S005', 85000.0, N'TOAN', '2026-10-20T00:00:00.0000000', 8, N'Đại số tuyến tính');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSach', N'DonGia', N'MaLoai', N'NgayNhap', N'SoLuong', N'TenSach') AND [object_id] = OBJECT_ID(N'[Sachs]'))
    SET IDENTITY_INSERT [Sachs] OFF;

CREATE INDEX [IX_Sachs_MaLoai] ON [Sachs] ([MaLoai]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261105122757_InitialCreate', N'10.0.13');

COMMIT;
GO

