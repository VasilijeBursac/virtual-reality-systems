# Sistemi virtualne realnosti
Materijali za računarske vežbe sa kursa "Sistemi virtualne realnosti" na [Fakultetu tehničkih nauka](http://www.ftn.uns.ac.rs/ "Zvanični sajt Fakulteta tehničkih nauka"), [Univerziteta u Novom Sadu](https://www.uns.ac.rs/ "Zvanični sajt Univerziteta u Novom Sadu"). Nastavu na kursu izvodi [Grupa za Grafiku, Interakciju i Multimediju (GIM)](http://gim.ftn.uns.ac.rs/Clanovi "Zvanični sajt GIM grupe") u okviru Katedre za primenjene računarske nauke na Departmanu za računarstvo i automatiku.

- **Jezik:** *Srpski* | *[English](https://www.google.com "Click to show ReadMe in English")*
- **Autor nastavnih materijala:** [Vasilije Bursać](https://www.google.com "Autor")

---

## Kontakt za pitanja i predloge za unapređenje
- **email:** vasilijebursac@uns.ac.rs
- **Microsoft Teams:** vasilijebursac

---

## Sadržaj
- [Sistemi virtualne realnosti](#sistemi-virtualne-realnosti)
    - [Kontakt za pitanja i predloge za unapređenje](#kontakt-za-pitanja-i-predloge-za-unapređenje)
    - [Sadržaj](#sadržaj)
    - [Sadržaj nastave po nedeljama semestra](#sadržaj-nastave-po-nedeljama-semestra)
    - [Način rada na vežbama i domaći zadaci](#način-rada-na-vežbama-i-domaći-zadaci)
    - [Grane repozitorijuma](#grane-repozitorijuma)
    - [Tehnologije i razvojno okruženje](#tehnologije-i-razvojno-okruženje)
    - **[Instalacija i podešavanje](#instalacija-i-podešavanje)**
        - [*Windows*, *macOS*, *Linux*](#windows-macos-linux)
            - [Instalacija *Unity* pogona](#instalacija-unity-pogona)
            - [Instalacija *Visual Studio* razvojnog okruženja](#instalacija-visual-studio-razvojnog-okruženja)
            - [Povezivanje *Unity* pogona sa *Visual Studio* razvojnim okruženjem](#podešavanje-visual-studio-a)
            - [*Git* i *Git LFS*](#git-i-git-lfs)
        - [Pokretanje primera sa vežbi](#pokretanje-primera-sa-vežbi)
            - [Preduslov za pokretanje primera](#arch-bazirani)
            - [Pokretanje primera](#debian-bazirani)

---

<details>

  <summary<h2>Sadržaj nastave po nedeljama semestra</h2></summary>
  
  - Nedelja 1: [Uvod u Unity pogon - Osnovne rada u Unity pogonu i manipulacija 3D objektima](https://www.google.com "Link do materijala")
  - Nedelja 2: [3D modelovanje u Unity-ju - ProBuilder paket](https://www.google.com "Link do materijala")
  - Nedelja 3: [Kreiranje virtualnih okruženja](https://www.google.com "Link do materijala")

</details>

---

## Način rada na vežbama i domaći zadaci

---

## Grane repozitorijuma
- ***base***: Osnovni kod, starter projekat
- ***demo***: Demonstracija rezultata koje je moguće postići nakon slušanja i polaganja predmeta
- ***week-x***: Materijal za nedelju *X*
- ***additional_materials***: Dodatni materijali za učenje i vežbu

---

## Tehnologije i razvojno okruženje
- ***Unity game engine***: Primeri su napravljeni u verziji editora `2021.3.3f1` *(LTS)*. **Instalirati najnoviju preporučenu *LTS* verziju *Unity* editora.**
- ***Visual Studio* razvojno okruženje** <br>
*Napomena: Ukoliko želite, možete koristiti *Rider*, *Visual Studio Code* ili bilo koje drugo razvojno okruženje koje podržava pisanje *C#* koda i integraciju sa *Unity* pogonom.*

## Instalacija i podešavanje
### *Windows*, *macOS*, *Linux*
*Unity pogon* i *Visual Studio* razvojno okruženje su dostupni za sve navedene operativne sisteme i proces instalacije je skoro identičan za svaki od njih. Ispratite uputstvo u nastavku i sve bi trebalo da bude u redu.

#### Instalacija *Unity* pogona i *Visual Studio* razvojnog okruženja
- [Tutorijal](https://www.youtube.com/watch?v=gxX7euQ_2Qc&ab_channel=GDTitans "Video uputstvo za instalaciju Unity pogona i Visual Studio razvojnog okruženja")

:exclamation: VAŽNE NAPOMENE: 
- **Verzija *Unity Editor*-a:**
    - Budući da su primeri sa vežbi napravljeni u `2021.3.3f1` *(LTS)* verziji Unity editora, nećete moći da ih pokrenete ako već imate instaliranu neku verziju stariju od te. 
    - **Najbolje bi bilo da instalirate najnoviju *Long Term Support (LTS)* verziju *Unity Editor*-a koja je dostupna u datom trenutku (kao što je urađeno u tutorijalu). *Unity Hub* će je automatski preporučiti i istaknuti na vrhu prilikom instalacije *Unity Editor*-a.**

- **Ako već imate instaliran *Visual Studio***: 
    - Proverite da li imate instaliran i *"Game development with Unity"* paket (videti sliku ispod). Ukoliko nemate ovaj paket, možete ga dodati pomoću *Visual Studio Installer*-a. Postupak je kao da od nule instalirate okruženje, samo treba da odaberete *"Modify Installation"* opciju, štiklirate paket koji dodajete i završite redovno proces instalacije.
    - Proverite da li su *Unity* i *Visual Studio* ispravno povezani, tj. proverite u *Unity* editoru da li je ta verzija *Visual Studio*-a (koju ste instalirali) ispravno podešena kao editor koda. **Kompletan postupak je prikazan na tutorijalu za povezivanje**.

- **Ako nemate instaliran *Visual Studio***: 
    - Instalirajte *Visual Studio* u sklopu *Unity* instalacije, kao što je urađeno u tutorijalu za instalaciju.
    - Ispratite tutorijal za povezivanje radi provere.

#### Povezivanje *Unity* pogona sa *Visual Studio* razvojnim okruženjem
- [Tutorijal](https://www.youtube.com/watch?v=4ElwPXo4oCc&ab_channel=Stachey "Video uputstvo za povezivanje Unity pogona sa Visual Studio razvojnim okruženjem")

- **Provera da li su *Unity* i *Visual Studio* ispravno povezani:**
    - U *Unity*-ju napravite *C#* skriptu, a zatim je otvorite (dvoklikom) u *Visual Studio* okruženju. Ako je sve povezano kako treba, ispod naziva skripte će pisati "*Assembly-CSharp*" (videti sliku ispod).

#### Git i Git LFS
Kako bi se svi fajlovi ispravno preuzeli i učitali prilikom pokretanja, neophodno je da **<ins>na računaru na kom se pokreće primer, pre preuzimanja i pokretanja primera</ins>**, budu instalirani *Git* i *Git LFS (Git Large File Storage*). Linkovi za njihovo preuzimanje su u nastavku.

- [*Git*](https://git-scm.com/ "Link za preuzimanje Git-a")
- [*Git LFS*](https://git-lfs.github.com/ "Link za preuzimanje Git LFS-a")

<br>

:clap: **To je to! Sve je spremno. Ukoliko naletite na neki problem prilikom instalacije ili pokretanja primera, molimo Vas da nas [kontaktirate](#kontakt-za-pitanja-i-predloge-za-unapređenje "Kontakt podaci").**

---

### Pokretanje primera sa vežbi
**:exclamation: *VAŽNA NAPOMENA*: Pre preuzimanja i pokretanja primera sa ovog repozitorijuma, obavezno prethodno [instalirajte *Git* i *Git LFS*!](#git-i-git-lfs "Uputstvo za instalaciju Git-a i Git LFS-a")** <br>

- Nakon preuzimanja željenog primera sa repozitorijuma, *Unity* projekat se pokreće klikom na dugme *Open* u *Projects* sekciji *Unity Hub*-a, a zatim lociranjem korenskog foldera projekta koji ste preuzeli (videti *gif* ispod).

#### Nedostatak tekstura ili drugih multimedijalnih fajlova
Ukoliko nakon pokretanja projekta nedostaju teksture ili neki drugi multimedijalni fajlovi, verovatno niste prethodno instalirali *Git LFS*. U tom slučaju, ispratite sledeći redosled operacija:
1. Instalirajte *Git LFS*.
2. Ponovo preuzmite dati projekat sa repozitorijuma.
3. Ponovo importujte projekat u *Unity Hub*, a zatim ga pokrenite.
