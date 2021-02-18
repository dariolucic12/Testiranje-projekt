# Testiranje-projekt

Opis test caseova projekta:
1) TestCase1 - 
U mapi od ovog testnog slučaja nalazi se file (Opis test casea.docx) koji detaljno opisuje korake
koji se provode tokom testiranja korištenja demo aplikacije. Koraci se provode redom ručno 
te se snimaju putem Katalon Recorder alata. Tokom snimanja kreira se skripta koju možemo 
eksportati u C# formatu. Skriptu ubacujemo u Visual Studio u kreirani Unit Test Project, te 
instaliramo pakete:
NUnit framework, Selenium WebDriver, Selenium Support, Nunit3 Test Adapter i Selenium WebDriver
– Gecko Driver. Pokretanjem kreiranog testa koraci se automatski provode.

2) TestCase2 - 
U ovom testnom slučaju testira se da li je nakon unosa ključne riječi "facebook" u Google 
tražilicu prva ponuđena poveznica od početne stranice Facebooka. Za testiranje ovog slučaja 
koristi se program IntelliJ. Na početku se napravi Maven projekt te u kreirani pom.xml file 
dodajemo ovisnosti kao što su selenium-java, testng.. Nakon tog dodaje se java file u kojem
se piše kod za navedenu pretragu.

3) TestCase3 - 
YouTube - U ovom slučaju testiramo značajke stranice YouTube, te pretraživanje iste.
Unutar mape nalazi se file koji detaljno opisuje korake koji automatski provode tokom testiranja. 
Korišteni alati isti su kao i u prvom testnom slučaju.

4) TestCase4
Value Converter - U ovom slučaju testiramo način rada stranice xe.com, točnije grafove kojim se 
uspoređuju dvije odabrane valute. Unutar mape nalazi se file koji detaljno opisuje korake koji 
automatski provode tokom testiranja. Korišteni alati isti su kao i u prvom testnom slučaju.

5) TestCase5
Calculator - U ovom slučaju testiramo rad kalkulatora stranice calculator.net. Testiramo rad 
oduzimanja, te zbrajanja unešenih brojeva. Unutar mape nalazi se file koji detaljno opisuje 
korake koji automatski provode tokom testiranja. Kada se testovi pokrenu, prvo se izvršava
jedan test, te nakon njega i drugi. Korišteni alati isti su kao i u prvom testnom slučaju.


Korišteni alati: Visual Studio, IntelliJ, Katalon Recorder, Mozilla Firefox (obavezna za rad skoro 
svih testnih slučajeva).
Korišteni programski jezici: C#, Java.
