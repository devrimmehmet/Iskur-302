-- ÖDEV : Sinema Otomasyonu en az 10 tabloluk database hazýrlanýp bugün ki sorularýn hepsini uygula.

-- Kapasitesi en az olan salon hangisidir?
--select MIN(kapasite) from TBL_Salon

-- Personellerde adý d-s arasýnda olan ve doðum tarihi 1993 olan kaç personel vardýr?
--select COUNT(PersonelId) from TBL_Personel where PersonelAd like '[D-S]%' and YEAR(PersonelDoðumTarihi)=1993

-- Kaç Film Türü varsa, isimlerini ve idlerini birleþtir getir kolon adý verilsin a'dan z'ye sýralansýn?
--select CONVERT(VARCHAR(10),FilmTurId)+' '+turu as 'Film Türleri' from TBL_FilmTur ORDER BY [Film Türleri]

-- Seanslardan 20.09.2022 ile 20.10.2022 tarihleri arasýnda kaç farklý seans yapýlmýþtýr?
--select * from TBL_Seanslar where  SeansZamani between '09-20-2022' and '10-20-2022'

-- 5 nolu salon dýþýnda dolu koltuklarda ('A','O','Z','B','S') nolu koltuklarda film izleyen toplam kiþi sayýsý kaçtýr?
--select COUNT(KoltukId) from TBL_Koltuk where SalonId!=5 and KoltukHarf IN('A','O','Z','B','S')

-- Soyadý Aile baþlayan kaç oyuncu vardýr kolon adý oyuncu sayýsý olsun?
--select COUNT(FilmOyuncuId) as 'Oyuncu Sayýsý' from TBL_FilmOyunculari where FilmOyuncuSoyadi like '[B]%'

-- oscar biletlerinden kaç tane satýþ yapýlmýþtýr?
--select COUNT(Bilet_Id) from TBL_Bilet where BiletAdý='Oscar'

--Müþterilerden öðrenci olanlarýn isim ve soyismi birleþtir ve ayrý kolonda tel no getirsin.
--select m.MusteriTelefon, m.MusteriAdi+m.MusteriSoyadi as 'ÝsimSoyisim' from TBL_Musteri m where MusteriTipi=1



--select SUM(Freight) from orders where (CustomerID='PERIC' or CustomerID='DUMON' or CustomerID='CACTU') and ShipVia!=2 and  Freight BETWEEN 20 AND 200
