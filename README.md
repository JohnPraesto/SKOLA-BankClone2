- [ ]  Identifiera 3 delar av koden som du känner är mer affärskritiska
- [ ]  Fundera på vilka saker som kan gå fel i dessa delar av koden
- [ ]  Skriv ner vilka delar du valde ut, samt vad du tänker kan gå fel i dessa, i din ReadMe-fil för projektet

Klass: UserManager
Metod: CreateInitialUsers
Test: Systemet behöver administratörer för att kunna skapa nya användare och sätta nya växlingskurser. Metoden skapar initiala administratörer för att hantera systemet. Administratörer kan inte skapas inom programmet och detta är därför systemets enda sätt att få in administratörer.
Möjliga fel: Admin-klassens properties kan ha satts fel. Administratörerna läggs in till i administratörs-listan.

Klass: CurrencyConverter
Metod: TotalAsset
Test: En kund får inte låna mer än fem gånger värdet av sina tillgångar. För att veta om en kund får ta ett lån undersöks först kundens totala tillgångar i banken. Denna metod tar fram en kunds totala tillgångar värderat i valutan SEK.
Möjliga fel: En kunds alla konton måste laddas in till metoden. Och eftersom värdet på en kunds alla konton, som kan ha olika valutor, måste alla valutor adderas på rätt sätt till SEK.

Klass: CurrencyConverter
Metod: ConvertCurrency
Test: När pengar överförs mellan konton måste valutan också ändras om kontona har olika valuta. Denna metod tar in vilken valuta det skickande kontot och det mottagande kontot har och gör en beräkning på hur mycket som ska dras av från sändaren och tillsättas mottagaren enligt korrekt valutakurs.
Möjliga fel: Fel i växlingskurser kan leda till att kunden får mer eller mindre pengar vid överföring av pengar. Testet måste kontrollera om de inblandade kontona har rätt värde efter en transaktion.
