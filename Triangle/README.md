#Black box testning av triangle.exe
Dokumentering av testfall och dess utfall.

##Indata f�r testning
triangel.exe x y z

##Testfall
1. om alla sidor �r lika �r triangeln liksidig
2. om tv� sidor �r lika �r triangeln likbent
3. om alla sidor �r olika har triangeln inga lika sidor
4. om triangeln f�r n�gon sida ges v�rdet noll �r det en ogiltig triangel
5. om triangeln f�r n�gon sida ges ett negativt v�rde �r triangeln ogiltig
6. om triangeln f�r n�gon sida ges ett v�rde som inte �r ett nummer �r triangeln ogiltig.

    Testfall	|	x	|	y	|	z	|	F�rv�ntat	|	Resultat
-----------|-----------|----------|-----------|----------------|--------------
	1	|	1	|	1	|	1	|	liksidig	|	lyckat
	2	|	1	|	1	|	2	|	likbent	|	lyckat
	3	|	1	|	2	|	3	|	inga lika	|	lyckat
	4	|	0	|	1	|	1	|	ogiltig	|	misslyckat
	5	|	-1	|	1	|	1	|	ogiltig	|	misslyckat
	6	|	a	|	1	|	1	|	ogiltig	|	misslyckat

##Analys
Programmet verkar inte kontrollera att inmatat v�rde resulterar i en giltig triangel. Ogiltiga sifferv�rden(negativa tal eller 0) anv�nds i j�mf�relseber�kningar. Om v�rden annat �n siffror matas in skapas ett undantag.