#Testning av triangle.exe
Dokumentering av testfall och dess utfall.

Whitebox testningen återfinns i mappen Whitebox

#Blackbox

##Indata för testning
triangel.exe indata

##Testfall

    Testfall	|	Indata		|	Förväntat	|	Motivering
-----------|----------------------|----------------|----------------
	1	|	1 1 1			|	liksidig	|	Funktionskontroll - liksidig	
	2	|	10 10 15		|	likbent	|	Funktionskontroll - likbent
	3	|	10 20 15		|	inga lika	|	Funktionskontroll - inga lika	
	4	|	0 1 1			|	ogiltig	|	Giltighetskontroll - sida som är 0
	5	|	-1 1 1		|	ogiltig	|	Giltighetskontroll - negativ sida
	6	|	a 1 1			|	ogiltig	|	Indatakontroll - värden som inte är siffror
	7	|	1 2 3			|	ogiltig	|	Giltighetskontroll - triangel som inte går att rita
	8	|	1.00000001 1 1	|	likbent	|	Decimalhantering - kan programmet hantera minst 8 decimaler?
	9	|	1.5 1 1		|	likbent	|	Decimalhantering - kan programmet hantera decimaler överhuvudtaget?
	10	| 	(inget) 		|    meddelande	|	Indatakontroll - inga värden
	11	|	1			|    meddelande	|	Indatakontroll - 1 värde
	12	|	1 1			|    meddelande	|	Indatakontroll - 1 värde
	13	|	2 2			|    meddelande	|	Eftersom tidigare input gett liksidig, ger det här då likbent?
	14	|	1 2			|    meddelande	|	Ger det här då likbent kan vi anta att programmet bara jämför de parametrar som ges
	15	|	1 1 1 1		|    meddelande	|	För många värden?
	16	|	1 1 1 2		|    meddelande	|	likbent?
	17	|	1 1 2 3		|    meddelande	|	inga lika?
	18	|	1 2 3 4		|    meddelande	|	Vad händer vid fler än 3 olika värden

##Resultat
   Testfall	|	Utdata	|	Resultat	|	Kommentar
   ---------|-----------------|----------------|---------------------
	1	|	liksidig	|	Lyckat	|	Kan hantera heltal och se att 3 värden är lika
	2	|	likbent	|	Lyckat	|	Kan göra jämförelser och svarar att en triangel med 2 lika sidor är likbent
	3	|	inga lika	|	Lyckat	|	Uppfattar att 3 olika sidor ger en triangel utan lika sidor
	4	|	likbent	|	Misslyckat	|	Ingen kontroll görs för triangel med sidan 0
	5	|	likbent	|	Misslyckat	|	Ingren kontroll görs för triangel med negativ sida
	6	|	undantag	|	Misslyckat	|	Ingen kontroll av indata, undantag kastas
	7	|	inga lika	|	Misslyckat	|	Ingen kontroll för att triangeln går att rita
	8	|	liksidig	|	Misslyckat	|	Kan inte hantera 8 decimaler
	9	| 	liksidig	|	Misslyckat	|	Kan inte hantera decimaler alls
	10	|	liksidig	|	Misslyckat	|	Ingen kontroll av att parametrar angivits
	11	|	liksidig	|	Misslyckat	|	Ingen kontroll görs att rätt antal parametrar angivits
	12	|	liksidig	|	Misslyckat	|	Programmet verkar anta 1 som standardvärde, intressant
	13	|	liksidig	|	Misslyckat	|	Programmet jämför tydligen bara de parametrar som anges
	14	|	likbent	|	Misslyckat	|	Programmmet jämför bara de parametrar som anges
	15	|	liksidig	|	Misslyckat	|	Nu testar tydligen programmet rektanglar också
	16	|	likbent	|	Misslyckat	|	Jämförelser verkar göras mellan alla inmatade värden
	17	|	inga lika	|	Misslyckat	|	Ger inga lika eftersom det nu finns 3 olika värden	
	18	|	inga lika	|	Misslyckat	|	Samma resultat för fler olika värden än 3

##Analys
Inga kontroller görs av indata, vare sig gällande antal parametrar eller att det faktiskt är siffror. Inga kontroller görs för att resultatet blir en giltig triangel. Programmet verkar bara ta de parametrar som anges och kontrollera om de är lika varandra. Programmet kan inte hantera tal med decimaler. Det kastas undantag till användaren vid inmatning av annat än siffror.
