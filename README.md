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
            - [Instalacija *Unity* pogona i *Visual Studio* razvojnog okruženja](#instalacija-unity-pogona-i-visual-studio-razvojnog-okruženja)
            - [Povezivanje *Unity* pogona sa *Visual Studio* razvojnim okruženjem](#povezivanje-unity-pogona-sa-visual-studio-razvojnim-okruženjem)
            - [*Git* i *Git LFS*](#git-i-git-lfs)
        - [Pokretanje primera sa vežbi](#pokretanje-primera-sa-vežbi)
            - [Nedostatak tekstura ili drugih multimedijalnih fajlova](#nedostatak-tekstura-ili-drugih-multimedijalnih-fajlova)

---

<details>
   <summary><h2>Sadržaj nastave po nedeljama semestra</h2></summary>
    
   - Nedelja 1: [Uvod u Unity pogon - Osnovne rada u Unity pogonu i manipulacija 3D objektima](../../tree/week-1 "Link do materijala")
   - Nedelja 2: [3D modelovanje u Unity-ju - ProBuilder paket](../../tree/week-2  "Link do materijala")
   - Nedelja 3: [Kreiranje virtualnih okruženja](../../tree/week-3 "Link do materijala")
</details>

---

## Grane repozitorijuma
- ***base***: Osnovni kod, starter projekat
- ***demo***: Demonstracija rezultata koje je moguće postići nakon slušanja i polaganja predmeta
- ***week-x***: Materijal za nedelju *X*
- ***additional_materials***: Dodatni materijali za učenje i vežbu, korisni sajtovi za preuzimanje *asset*-a za projekte itd.

---

## Tehnologije i razvojno okruženje 
[![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/download "Link za preuzimanje Unity-ja") 
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/downloads/ "Link za preuzimanje Visual Studio-a")
- ***Unity game engine***: Primeri su napravljeni u verziji editora `2021.3.3f1` *(LTS)*. **Instalirati najnoviju preporučenu *LTS* verziju *Unity* editora.**
- ***Visual Studio* razvojno okruženje** <br>
*Napomena: Ukoliko želite, možete koristiti *Rider*, *Visual Studio Code* ili bilo koje drugo razvojno okruženje koje podržava pisanje *C#* koda i integraciju sa *Unity* pogonom.*

---

## Instalacija i podešavanje
### *Windows*, *macOS*, *Linux*
*Unity pogon* i *Visual Studio* razvojno okruženje su dostupni za sve navedene operativne sisteme i proces instalacije je skoro identičan za svaki od njih. Ispratite uputstvo u nastavku i sve bi trebalo da bude u redu.

#### Instalacija *Unity* pogona i *Visual Studio* razvojnog okruženja
- [Tutorijal](https://www.youtube.com/watch?v=gxX7euQ_2Qc&ab_channel=GDTitans "Video uputstvo za instalaciju Unity pogona i Visual Studio razvojnog okruženja")

- :exclamation: <ins>***VAŽNE NAPOMENE:***</ins> 
    - **Verzija *Unity Editor*-a:**
        - Budući da su primeri sa vežbi napravljeni u `2021.3.3f1` *(LTS)* verziji Unity editora, nećete moći da ih pokrenete ako već imate instaliranu neku verziju stariju od te. 
        - **Najbolje bi bilo da instalirate najnoviju preporučenu *Long Term Support (LTS)* verziju *Unity Editor*-a koja je dostupna u datom trenutku (kao što je urađeno u tutorijalu). *Unity Hub* će je automatski preporučiti i istaknuti na vrhu ("*Recommended version*") prilikom instalacije *Unity Editor*-a.**
    - **Ako već imate instaliran *Visual Studio***: 
        - Proverite da li imate instaliran i *"Game development with Unity"* paket (videti sliku ispod). Ukoliko nemate ovaj paket, možete ga dodati pomoću *Visual Studio Installer*-a. Postupak je kao da od nule instalirate okruženje, samo treba da odaberete *"Modify Installation"* opciju, štiklirate paket koji dodajete i završite redovno proces instalacije.
![Game development with Unity](/images/game-development-with-unity-package.png)
        - Proverite da li su *Unity* i *Visual Studio* ispravno povezani, tj. proverite u *Unity* editoru da li je ta verzija *Visual Studio*-a (koju ste instalirali) ispravno podešena kao editor koda. **Kompletan postupak je prikazan na [tutorijalu za povezivanje](#povezivanje-unity-pogona-sa-visual-studio-razvojnim-okruženjem "Povezivanje Unity pogona sa Visual Studio razvojnim okruženjem")**.
    - **Ako nemate instaliran *Visual Studio***: 
        - Instalirajte *Visual Studio* u sklopu *Unity* instalacije, kao što je urađeno u [tutorijalu za instalaciju](#instalacija-unity-pogona-i-visual-studio-razvojnog-okruženja "Instalacija Unity pogona i Visual Studio razvojnog okruženja").
        - Ispratite [tutorijal za povezivanje radi provere](#povezivanje-unity-pogona-sa-visual-studio-razvojnim-okruženjem "Povezivanje Unity pogona sa Visual Studio razvojnim okruženjem").

#### Povezivanje *Unity* pogona sa *Visual Studio* razvojnim okruženjem
- [Tutorijal](https://www.youtube.com/watch?v=4ElwPXo4oCc&ab_channel=Stachey "Video uputstvo za povezivanje Unity pogona sa Visual Studio razvojnim okruženjem")
- **Provera da li su *Unity* i *Visual Studio* ispravno povezani:**
    - U *Unity*-ju napravite *C#* skriptu, a zatim je otvorite (dvoklikom) u *Visual Studio* okruženju. Ako je sve povezano kako treba, ispod naziva skripte će pisati "*Assembly-CSharp*" (videti sliku ispod).

#### Git i Git LFS
*Git LFS (Git Large File Storage)*
<br>
<br>
Kako bi se svi fajlovi ispravno preuzeli i učitali prilikom pokretanja, neophodno je da **<ins>na računaru na kom se pokreće primer, pre preuzimanja i pokretanja primera</ins>**, budu instalirani *Git* i *Git LFS (Git Large File Storage)*. Linkovi za njihovo preuzimanje su u nastavku.
- [*Git*](https://git-scm.com/ "Link za preuzimanje Git-a")
- [*Git LFS*](https://git-lfs.github.com/ "Link za preuzimanje Git LFS-a")

- *Opciono:* Za brže i slikovitije rukovanje *git* repozitorijumom možete preuzeti [*GitHub Desktop*](https://desktop.github.com/ "Link za preuzimanje GitHub Desktop alata").

<br>

:clap: **To je to! Sve je spremno. Ukoliko naletite na neki problem prilikom instalacije alata ili pokretanja primera, molimo Vas da nas [kontaktirate](#kontakt-za-pitanja-i-predloge-za-unapređenje "Kontakt podaci").**

---

### Pokretanje primera sa vežbi
- :exclamation: <ins>***VAŽNA NAPOMENA*:</ins> Pre preuzimanja i pokretanja primera sa ovog repozitorijuma, obavezno prethodno [instalirajte *Git* i *Git LFS*!](#git-i-git-lfs "Uputstvo za instalaciju Git-a i Git LFS-a")** <br>
- Pozicionirati se u željeni folder i pokrenuti *Git Bash* u njemu (desni klik, pa klik na "*Git Bash Here*").
- Klonirati repozitorijum: 
```
git clone https://github.com/VasilijeBursac/virtual-reality-systems.git
```
- Pozicionirati se u klonirani repozitorijum:
```
cd virtual-reality-systems
```
- Preuzeti najnovije stanje sa udaljenog repozitorijuma i ažurirati lokalni repozitorijum: 
```
git pull
```
- Izlistati sve lokalne i udaljene grane: 
```
git branch -a
```
- Prebaciti se na željenu granu:
```
 git checkout IME_GRANE
```
`IME_GRANE` predstavlja naziv grane na kojoj se nalazi primer koji želite da pokrenete (npr. *week-1*). 
- Alternativno, repozitorijum se može klonirati pomoću *GitHub Desktop* alata, [po ovom uputstvu](https://docs.github.com/en/desktop/contributing-and-collaborating-using-github-desktop/adding-and-cloning-repositories/cloning-a-repository-from-github-to-github-desktop "Uputstvo za kloniranje repozitorijuma preko GitHub Desktop alata").
- Nakon preuzimanja željenog primera sa repozitorijuma, tj. **pozicioniranja na odgovarajuću granu**, *Unity* projekat se pokreće klikom na dugme *Open* u *Projects* sekciji *Unity Hub*-a, a zatim lociranjem korenskog foldera projekta koji želite da pokrenete.
- **Kompletna procedura za kloniranje repozitorijuma i pokretanje primera je prikazana ispod.**

#### Nedostatak tekstura ili drugih multimedijalnih fajlova
Ukoliko nakon pokretanja projekta nedostaju teksture ili neki drugi multimedijalni fajlovi, verovatno niste prethodno instalirali *Git LFS*. U tom slučaju, ispratite sledeći redosled operacija:
1. [Instalirajte *Git LFS*](#git-i-git-lfs "Uputstvo za instalaciju Git-a i Git LFS-a").
2. Ponovo preuzmite dati projekat sa repozitorijuma.
3. Ponovo importujte projekat u *Unity Hub*, a zatim ga pokrenite.
