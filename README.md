#Blackbox testning av triangle.exe
Dokumentering av testfall och dess utfall.

Whitebox testningen återfinns i mappen Whitebox

##Indata för testning
triangel.exe x y z

##Testfall
1. om alla sidor är lika är triangeln liksidig
2. om två sidor är lika är triangeln likbent
3. om alla sidor är olika har triangeln inga lika sidor
4. om triangeln för någon sida ges värdet noll är det en ogiltig triangel
5. om triangeln för någon sida ges ett negativt värde är triangeln ogiltig
6. om triangeln för någon sida ges ett värde som inte är ett nummer är triangeln ogiltig.

    Testfall	|	x	|	y	|	z	|	Förväntat	|	Resultat
-----------|-----------|----------|-----------|----------------|--------------
	1	|	1	|	1	|	1	|	liksidig	|	lyckat
	2	|	1	|	1	|	2	|	likbent	|	lyckat
	3	|	1	|	2	|	3	|	inga lika	|	lyckat
	4	|	0	|	1	|	1	|	ogiltig	|	misslyckat
	5	|	-1	|	1	|	1	|	ogiltig	|	misslyckat
	6	|	a	|	1	|	1	|	ogiltig	|	misslyckat

##Analys
Programmet verkar inte kontrollera att inmatat värde resulterar i en giltig triangel. Ogiltiga siffervärden(negativa tal eller 0) används i jämförelseberäkningar. Om värden annat än siffror matas in skapas ett undantag.
