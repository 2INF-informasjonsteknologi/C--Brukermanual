## Hvordan du kjører

1. Forsikre deg om at du har .NET 8.0 installert på maskinen din. Du kan laste det ned fra den [offisielle .NET-nettsiden](https://dotnet.microsoft.com/download).
2. Åpne et terminalvindu/kommandoprompt.
3. Naviger til prosjektkatalogen ved å bruke cd-kommandoen.
4. Kjør kommandoen `dotnet run` for å starte spillet.

## Hvordan spillet fungerer

1. Spillet starter med å vise en velkomstmelding og fortelle brukeren at det har valgt et tilfeldig tall mellom 1 og 100.
2. Brukeren blir deretter bedt om å gjette tallet.
3. Hvis brukerens gjetning er for lav, vil spillet fortelle dem "Tallet er for lavt. Prøv igjen.".
4. Hvis brukerens gjetning er for høy, vil spillet fortelle dem "Tallet er for høyt. Prøv igjen.".
5. Spillet fortsetter til brukeren gjetter riktig tall. På det tidspunktet vil spillet gratulere brukeren og fortelle dem hvor mange forsøk det tok å gjette riktig tall.

## Kodestruktur

Hovedlogikken i spillet er inneholdt i `Main`-metoden i `Program`-klassen i [`Program.cs`]filen.
