# #VEEBILEHEKÜLG
## PROJEKTI KIRJELDUS

KONKURS on projekt, mis kuvab kasutajale Toimuvatest ja tulevatest üritustest, vajadusel saab ka kasutaja muuta või lisada informatsiooni. Plaan oli nädalaga proovida kõik valmis teha, ilma väljaspoolse abita **(kes teavad sellest rohkem).** Projekti saavutamiseks oli kasutatud:

**--FRONTEND--**
 - HTML, CSS, 
- Bootstrap
- JavaScript
 
**--BACKEND--**
 -  Microsoft SQL Server (SQL)
 - Selenium (Automated Testing)
 - C#

**--PROGRAMMID--**
- GitHub
- Visual Studio Community

**Projekti aeg: 18~ tundi**

# #KUIDAS KASUTADA?
Algselt, minge lehele [Github](https://github.com/Kurgg/KONKURS2/releases/tag/alpha), sealt laadige alla "[KONKURS2-1.0.rar](https://github.com/Kurgg/KONKURS2/releases/download/alpha/KONKURS2-1.0.rar)".
(Arvuti antiviirus võib minna käima sellega, see on false-positive)

Kui see on alla laetud, "extractige" see ja alustage "KONKURS2.exe", kui kõik on hästi siis peaks kõik roheline olema, seega minge http://localhost:5001 (võimalusel võib olla teistsugune, vaadake teist rohelist rida).

Ja kui kõik on senimaani hästi läinud, siis peaks veebirakendus teile ette tulema, kõikide funktsioonidega töötama. Kui midagi on katki, andke Markus.Kurg@gmail.com teada.

# #LISAINFO

[Microsoft Getting Started with ASPNET](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022)
[Microsoft SQL Server with Visual Studio 2022](https://www.youtube.com/watch?v=QwEwRJDxkUE)
[Check Instance Name on Microsoft SQL Server](https://www.youtube.com/watch?v=qFNZNFw_Wf8&t=0s)
[Create ASP.NET Core Web Application With SQL Server Database Connection](https://youtu.be/T-e554Zt3n4)


# #TULEMUS

Aeg, mis mul oli kasutuseks võetud, oli täitsa paras aeg, mida saaks kasutada selle projekti lõpetamiseks. Jõudes lõpuni, sai tehtud veebirakenduse front-end, back-end, SQL ühendatud veebirakendusega ja palju lisa, mis sai õpitud juurde, kuid praktikas mitte kasutada. Seega jõuame järgmise teema peale:

# #PROBLEEMID

Peamised probleemid hakkasid tulema siis, kui oli plaan teise SQL tabeli tuua peamise lehe peale. Ei saanud täpsemalt aru, kuid loogika oli arusaadav, mida tegema pidi. 

Lisa suuremad probleemid tulid Automaat testimise peal ja ka Osalejate lisamisel. 

Automaat testimine oli minu jaoks uus teema, kuid mõned minutid sirvimist oli aru saadav kuidas süsteem ise töötab, aga ei leidnud viisi, kuidas seda oma projekti sisse panna, seda tuleb vaja veel uurida.

Osalejate lisamise all mõtlen seda, kuidas saada eraldi lisada iga "Tulevasele üritusele" oma Osalejate nimekirja, seda tuleb kas rohkem uurida või küsida kogenumate käest.

Üks suur probleem mis tuli GitHub'iga. Täpselt aru ei saanud kuidas Push'ida ja Pull'ida GitHub'i versioone, seega kuidagi Pull'isin enda local faili peale terve projekti, seetõttu kaotasin osa oma projektist. Ei ole suur probleem kuna tean mida tuleb vaja, kuid ajalises mõttes jäid pisiasjad tegemata.

## #PROBLEEMID & LAHENDUSED

Siin näete kas suuremaid või väiksemaid probleeme projektil, mis on järgmine võte sellele või võimalusel lahendus kirja panna:

**--CRITICAL PROBLEMS--**
- Selenium ei ole paigaldatud projekti. 
> (Loogika on arusaadav kuidas süsteem töötab, tuleb peamiselt uurida, kuidas süsteemi paigaldada ja paar testijooksu teha, iseseisev uurimine on võimalus).
- Puudub lehel "OSALEJAD" ja "TOIMUNUD ÜRITUSED" SQL tabelid. 
> (Sama, peamine loogika on olemas sellele, kuid vaadates kui palju vigu tuleb kui on soov lisada kood koos esimese tabeliga, siis ma ei läinud edasi selle jamamisega. Teiseks, osalejate tabelit on minu jaoks keeruline lisada, et eraldi igal vastusel on enda eraldi Osalejate tabel. Jätsin selle tegemata seetõttu. Võimalusel iseseisvalt proovida puhtal veebirakendusel seda lisada ja mitmeid SQL tabelite lisamiseks tuleb küsida kogenuma käest)

**--SMALLER PROBLEMS--**
- Peamise ja Ürituse lisamise lehel on ääred rohkem seespool kui peaksid olema [Postimg.cc](https://i.postimg.cc/DfPtnZ2p/Desktop-Screenshot-2022-08-22-21-39-00-33-2.png)
> (Lahendus on lihtne, aga minu silmis peidus. Eeldatavasti Bootstrapi teema, tuleb vaja natukene mässata container'itega, iseseisvalt peaks saama tehud, kuid vajadusel kindlasti abi küsida)
-  AVALEHT ja ÜRITUSTE LISAMINE tab'id ei ole "Aktiivsed" kui oled sellel lehel [Postimg.cc](https://i.postimg.cc/15RbtQXm/Desktop-Screenshot-2022-08-22-21-39-10-61-2.png)
> (Sama, lahendus on lihtne, olin lisanud skripti, kuid ei tööta, väga palju aega sellele ei kulutanud kuna polnud väga kriitiline. Tuleb vaja skript üle vaadata, eeldan, et veebis on lahendusi palju)
- Tulevased- Ja Toimunud ürituste tabel ei ole õigesti joonel [Postimg.cc](https://i.postimg.cc/9FxKwnwG/Desktop-Screenshot-2022-08-22-21-39-23-54-2.png)
> (Olin pikalt proovinud seda parandada, peamiselt CSS'iga, kuid ei leidnud otsest lahendust. Võimalusel prooviks uuesti, peamiselt CSS'iga leida lahendust, kui liiga pikaks läheb uurimine, siis kogenuma käesti küsida.)
- "Non-nullable field 'X' must contain a non-null value..."
> (Ei ole leidnud lahendust, kuid ei näe, et see oleks kriitiline ka ja see ei peata otsest launchimist, seega hetkeks ei hoia silma sellel peal.)



# #MIDA ÕPPISIN?
- Versiooni Haldus (GitHub);
- C# ja SQL ühildamist;
- C# (```public, void, try, Request.form;``` etc);
- Selenium algseadistamine;

## KOKKUVÕTE & TULEMUS

Kokkuvõtteks võin öelda, et olen uhke kui kiiresti sain selgeks uued teemad, nagu ka eelmiste teemade kohta mida kunagi õppisin. Probleemi selliste projektidega otseselt ei ole, kuid näen, et ilma väliste abivahenditega jõuad lõpuks mingi limiidini, kus oleks kellegi abi vaja. See on üks peamistest asjadest ka tuleviku mõttes Juniorina, et oleks vajadusel abikäsi olemas, niiviisi õpin kiiresti ja eeldatavasti seda probleemi uuesti ei kordu (hoian suuremaid teemasi tavaliselt enda lokaalses dokumentatsioonis). 

Ülesande täitmisega aega ei tahtnud juurde küsida, kuna eeldasin, et olen enda limiidini jõudnud ja ei tahtnud tööpakkumise mõttes seda valikut pikendada. Sain tehtud mis võimalik, kuid teemad, kus ma ise jäin kinni ei ole kõige hullemad, kuna loogika neile on arusaadav (ehk tean mida teha), kuid koodi mõttes ei ole kindel, kuidas seda kõike täpselt kokku panna).

Teemaks ka see, et ei ole kõige kogenud C# arendaja, mul on veel õppida, kuid näen (nagu selle projektiga), et praktika õpetab mind kõige paremini.

Loodan, et te lugesite kõik läbi mis vähemaltki paistis silma, tänan võimaluse eest!

-- Kurg
