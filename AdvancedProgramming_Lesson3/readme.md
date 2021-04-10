1. Rzeczy na który należy zwracać uwagę:

a) gdy przekazujemy argumenty typu integer w json pamiętać, aby nie umieszczać ich w cudzysłowiach, czyli np

```
{
  "id": 1
}
```

zamiast
```
{
  "id": "1"
}
```
b) po uruchomieniu przykładu w pliku site.js zwrócić uwagę, aby adres uri u góry pliku odpowiadał portowi, na którym jest hostowany serwis.

c)Jeżeli nie umiemy zobaczyć dlaczego coś nie działa użyć do tego programu Postman wysyłając żądanie na wskazany adres URI i zobaczyć co wypisze w odpowiedzi serwer.

d) Warto użyć swagger tak jak to pokazano na filmie youtube. On może służyć do testowania API https://localhost:44354/swagger/


2. Do zrobienia:

a) 

![Przykład zadania](https://github.com/palles77/WsbAdvancedProgramming/blob/main/AdvancedProgramming_Lesson3/Images/ImieNazwisko.png?raw=true)

Zrobić formatkę osobną stronę osoba.html oraz osoba.js, umieścić w katalogu wwwrooot. Za przykład użyć index.html i site.js. Dodać odpowiedni kontroler api. Stronka powinna wczytywać imię i nazwisko w osobnej głównej formatce i umożliwia dodawanie nowych osób, edycji ich imion i nazwisk zgodnie z przykładem podanym na laboratorium.

b) zrobić stronę ksiazki.html, ksiazki.js podobną do strony wyżej. Powinna zawiarać katalog książek.

Można pozostawić zapisywanie danych do pamięci zamiast bazy danych.
