# Fasada_Potvrda_O_Kupovini
Facade-Design Patterns

Fasada za kreiranje potvrde o kupovini
Pretpostavimo da trgovina
za evidenciju kupovina koristi tri datoteke (ili 3 tablice u bazi podataka). U prvoj
datoteci su zapisani podaci o registriranim kupcima (ime, prezime, adresa,
identifikacijski broj kupca). U drugoj datoteci su identifikacijski brojevi
svih proizvoda, ime proizvoda i cijena. U trećoj datoteci je tablica s
identifikacijskim bojevima pojedinih kupovina,
 a svakoj pojedinoj kupovini pridružen
je identifikacijski broj kupca, identifikacijski brojevi kupljenih artikala a
svakom broju artikla pridružena je cijena. Napraviti fasadu koja će izborom
identifikacijskog broja kupovine prikazati
 podatke o kupcu,
 popis svih artikala
koji su kupljeni i
 ukupnu cijenu.
