-- �DEV : Sinema Otomasyonu en az 10 tabloluk database haz�rlan�p bug�n ki sorular�n hepsini uygula.

-- Kapasitesi en az olan salon hangisidir?
--select MIN(kapasite) from TBL_Salon

-- Personellerde ad� d-s aras�nda olan ve do�um tarihi 1993 olan ka� personel vard�r?
--select COUNT(PersonelId) from TBL_Personel where PersonelAd like '[D-S]%' and YEAR(PersonelDo�umTarihi)=1993

-- Ka� Film T�r� varsa, isimlerini ve idlerini birle�tir getir kolon ad� verilsin a'dan z'ye s�ralans�n?
--select CONVERT(VARCHAR(10),FilmTurId)+' '+turu as 'Film T�rleri' from TBL_FilmTur ORDER BY [Film T�rleri]

-- Seanslardan 20.09.2022 ile 20.10.2022 tarihleri aras�nda ka� farkl� seans yap�lm��t�r?
--select * from TBL_Seanslar where  SeansZamani between '09-20-2022' and '10-20-2022'

-- 5 nolu salon d���nda dolu koltuklarda ('A','O','Z','B','S') nolu koltuklarda film izleyen toplam ki�i say�s� ka�t�r?
--select COUNT(KoltukId) from TBL_Koltuk where SalonId!=5 and KoltukHarf IN('A','O','Z','B','S')

-- Soyad� Aile ba�layan ka� oyuncu vard�r kolon ad� oyuncu say�s� olsun?
--select COUNT(FilmOyuncuId) as 'Oyuncu Say�s�' from TBL_FilmOyunculari where FilmOyuncuSoyadi like '[B]%'

-- oscar biletlerinden ka� tane sat�� yap�lm��t�r?
--select COUNT(Bilet_Id) from TBL_Bilet where BiletAd�='Oscar'

--M��terilerden ��renci olanlar�n isim ve soyismi birle�tir ve ayr� kolonda tel no getirsin.
--select m.MusteriTelefon, m.MusteriAdi+m.MusteriSoyadi as '�simSoyisim' from TBL_Musteri m where MusteriTipi=1



--select SUM(Freight) from orders where (CustomerID='PERIC' or CustomerID='DUMON' or CustomerID='CACTU') and ShipVia!=2 and  Freight BETWEEN 20 AND 200
