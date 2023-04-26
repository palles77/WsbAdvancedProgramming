# Laboratorium Programowania Zaawansowanego Nr 5

Na podstawie: https://github.com/microsoft/dotnet-podcasts wykonać następujące zadania:

# Zadania do wykonania

## Ocena dst

1. Uruchomić aplikację z użyciem Dockera i pokazać działającą stronę na porcie http://localhost:5002. Pokazać zrzuty ekranu 5 wybranych funkcjonalności stronki.
2. Uruchomić Swagger w przeglądarce http://localhost:5003/swagger/index.html i pokazać przetestowanie 3 wybranych metod API. Pokazać wyniki w postaci zrzutów ekranu.
3. Uruchomić wersję aplikacji dla urządzeń mobilnych. Pokazać wyniki w postaci zrzutów ekranu, które korespondują 1 do 1 ze zrzutami ekranu dla zadania nr 2.
4. Omówić strukturę jednej z dwóch wybranych bazy danych aplikacji w postaci diagramu UML (diagram klas). 
5. Narysować UML diagram sekwencji wywołań dla jednej z trzech wybranych funkcjonalności:
a) odsłuchania epizodu podcastu (przykład http://localhost:5002/show/7053e28e-72a9-484c-3d6b-08db469fce97)
b) obejrzenia listy podcastów http://localhost:5002/discover
c) wyświetlenia ustawień http://localhost:5002/settings

## Ocena dst plus

6. Dodać nowe ustawienie dla strony odnośnie włączania/wyłączania wyświetlania daty w stronie ustawień. 
Wskazówka: zmodyfkować stronę http://localhost:5002/settings, plik SettingsPage.razor

## Ocena db

7. Dodać nową tabelę Podcast.Infrastructure/Data/Models/FeedRating.cs
Wskazówki:
a) sprawdzić, jak są używane klasy takie jak FeedCategory w całym rozwiązaniu (Solution), sprawdzić ich występowanie.
b) zmodyfikować plik Podcast.Infrastructure/Data/Seed.cs aby wesprzeć 5 rodzajów ocen (od 1 do 5)
c) przeprowadzić migrację bazy danych
d) dodać wyświetlenie domyślne dla wszystkich Feed'ów w postaci liczby od 1 do 5 przy rysunku dla każdego z feedów w liście feedów z http://localhost:5002/discover

## Ocena db plus

8. Dodać wyświetlenie dla feedów w widoku szczegółów (np.: http://localhost:5002/show/4437bb54-36c8-49c9-3d6d-08db469fce97) pod tytułem podcastu w postaci gwiazdek zależnie od ilości.

## Ocena bdb

9. Dodać możliwość usunięcia epizodu poprzez ikonkę na stronie z listą podcastów dla danego feeda (np. http://localhost:5002/show/4437bb54-36c8-49c9-3d6d-08db469fce97)

# Wskazówki

1. Zadanie wykonać indywidualnie.
2. W rozwiązaniu podać link do repo ze sprawozdaniem, a w przypadku wykonania zadań na ocenę co najmniej dst plus dodać zmodyfikowany kod w swoim repozytorium i opisem zmian w dokumencie Word.

# Literatura pomocnicza

1. https://docs.microsoft.com/pl-pl/aspnet/core/tutorials/signalr?view=aspnetcore-5.0&tabs=visual-studio
2. https://stackoverflow.com/questions/50179696/how-add-asp-net-core-identity-to-existing-core-mvc-project
3. https://docs.microsoft.com/pl-pl/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio

# Ostatnia zmiana
27/04/2023
