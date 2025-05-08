# AppKasir

## Info penting!!!

Project ini menggunakan Microsoft SQL Server Management Studio (SSMS) sebagai Database server, konfigurasi database diperlukan sebelum menjalankan app ini.

## Berikut adalah langkah-langkah konfigurasi database server

### Install Microsoft SQL Server Express

Link download https://www.microsoft.com/en-us/sql-server/sql-server-downloads

Tutorial install https://www.youtube.com/watch?v=dPs7BQ4Zx_Q

### Import database

Buka SQL Server Management Studio lalu connect ke server

Pergi ke File > Open > File.., Open file 'SQLQueryAppKasir.sql' yang ada di project ini ![image](https://github.com/user-attachments/assets/b0d62952-9589-455f-8555-56812d0fd55b)

![image](https://github.com/user-attachments/assets/e0f7c45a-3c4a-42f9-b8dc-4cd3fafe7ed1)

Klik tombol execute/F5 untuk menjalankan SQL Query

Jika sudah refresh Object Explorer lalu cek database 

### Konfigurasi file Koneksi.cs

Buka project AppKasir di Visual Studio

Buka file Koneksi.cs

Ubah bagian Data source sesuai nama SQL Server yg sedang dipakai

![image](https://github.com/user-attachments/assets/d0b3f3f4-1c42-42a2-a6d9-02b45fd34564)


![image](https://github.com/user-attachments/assets/5f4a0be6-45b5-416d-86cb-bdb04bf62979)

### App sudah bisa dijalankan
