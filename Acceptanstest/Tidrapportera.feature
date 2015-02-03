Egenskap: Tidrapportera
	För att kunna fakturera kunder
	Vill jag som anställd på Agio
	Kunna bokföra mina jobbade timmar
	
Bakgrund: Allt utgår inmatningssidan
	Givet att jag befinner mig på inmatningssidan

Scenario: Bokföra timme	
	Givet jag har fyllt i tiden 3 timmar 
	Och jag har fyllt i kunden Gullans 50-talsmöbler 
	När jag trycker på lägg till
	Så skall en ny post för Gullans 50-talsmöbler läggas till

Scenariomall: Alla obligatoriska fält måste vara ifyllda
	Givet jag har fyllt följande värden <tid>, <kund> och <kommentar>
	När jag trycker på lägg till
	Så skall jag få <meddelande>

Exempel: 
	| tid | kund               | kommentar                         | meddelande          |
	|     | Nisses kött och TV | Jag vet inte hur länge jag jobbat | Tid saknas          |
	| 3   |                    | Vem jobbade jag nu åt			   | Kund saknas         |
	|     |                    | ÖÖh vad har jag nu gjort		   | Tid saknas			 |
	|     |                    | ÖÖh vad har jag nu gjort		   | Kund saknas	     |

