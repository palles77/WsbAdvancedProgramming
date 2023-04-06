## Instrukcja obsługi

Rzeczy na który należy zwracać uwagę:

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

## Zadania do zrobienia

1. 
a) 

![Przykład zadania](https://github.com/palles77/WsbAdvancedProgramming/blob/main/AdvancedProgramming_Lesson3/Images/ImieNazwisko.png?raw=true)

Zrobić formatkę osobną stronę osoba.html oraz person.js, umieścić w katalogu wwwrooot. Za przykład użyć index.html i site.js. Dodać odpowiedni kontroler api. Stronka powinna wczytywać imię i nazwisko w osobnej głównej formatce i umożliwia dodawanie nowych osób, edycji ich imion i nazwisk zgodnie z przykładem podanym na laboratorium.

-------------------------------------------------

2. Zrobić stronkę dla jednej ze wskazanych encji:

a) Właściwości dla samochodu:
* Make (marka) - typ: string
* Model (model) - typ: string
* Year (rok produkcji) - typ: int
* Color (kolor) - typ: string

b) Książka (Book):
* Title (tytuł) - typ: string
* Author (autor) - typ: string
* Genre (gatunek) - typ: string
* ISBN (numer ISBN) - typ: string

c) Rower (Bicycle):
a) Type (typ) - typ: string
b) Frame size (rozmiar ramy) - typ: int
c) Wheel size (rozmiar kół) - typ: int
d) Color (kolor) - typ: string

d) Narzędzie (Tool):
* Type (typ) - typ: string
* Brand (marka) - typ: string
* Model (model) - typ: string
* Condition (stan) - typ: string

e) Właściwości dla sprzętu sportowego (SportEquipment):
* Type (typ) - typ: string
* Size (rozmiar) - typ: string
* Brand (marka) - typ: string
* Condition (stan) - typ: string

Dla właściwości takich jak: typ, marka, model zastosować pole opcji (combo box). Mogą to być wpisy zdefiniowane w kodzie programu (stałe wartości z jakiejś kolekcji).

-------------------------------------------------

3. Wybrać trzy dodatkowe cechy dla osoby spośród wskazanej listy i dodać je do właściwości osoby z zadania:

* Age (wiek)
* Address (adres)
* Email (adres e-mail)
* Phone (numer telefonu)
* Occupation (zawód)
* Income (dochód)
* Education (wykształcenie)
* Marital status (stan cywilny)
* Nationality (narodowość)
* Gender (płeć)

-------------------------------------------------

4. Dodać powiązanie dla osoby oraz typu na zasadzie tabeli wypożyczeń dla jednego wybranego podpunktu:

Różne rodzaje rzeczy, które można wypożyczyć:

* Samochód
* Książka
* Rowerek
* Narzędzia
* Sprzęt sportowy

Właściwości dla tabeli wypożyczeń z każdej zeczy:

a) Tabela PersonCarRental dla samochodu:
* Rental ID (ID wypożyczenia) - typ: int
* Person ID (ID osoby) - typ: int
* Car ID (ID samochodu) - typ: int 
* Rental Date (data wypożyczenia) - typ: date

b) Tabela PersonBookRental dla książki:
* Rental ID (ID wypożyczenia) - typ: int
* Person ID (ID osoby) - typ: int
* Book ID (ID książki) - typ: int
* Rental Date (data wypożyczenia) - typ: date

c) Tabela PersonBicycleRental dla rowerka:
* Rental ID (ID wypożyczenia) - typ: int
* Person ID (ID osoby) - typ: int
* Bike ID (ID rowerka) - typ: int
* Rental Date (data wypożyczenia) - typ: date

d) Tabela PersonToolRental dla narzędzi:
* Rental ID (ID wypożyczenia) - typ: int
* Person ID (ID osoby) - typ: int
* Tool ID (ID narzędzi) - typ: int
* Rental Date (data wypożyczenia) - typ: date

e) Tabela PersonSportEquiptmentRental dla sprzętu sportowego:
* Rental ID (ID wypożyczenia) - typ: int
* Person ID (ID osoby) - typ: int
* Equipment ID (ID sprzętu sportowego) - typ: int
* Rental Date (data wypożyczenia) - typ: date

-------------------------------------------------

5. Dodać dodatkową stronę dla innego rodzaju zasobu z punktu 2 oraz wypożyczenie dla tego zasobu.

-------------------------------------------------

6. Wykonać stronę dla języka polskiego z wyborem wpisanych w combo box (patrz Ćwiczenia 2) w prawym górnym rogu.

-------------------------------------------------

## Ocenianie

1. Ocena dst - wykonanie zadania 1, 2
2. Ocena dst plus - zadania 1, 2 i 3
2. Ocena db - zadanie 1, 2, 3 i 4.
3. Ocena db plus - zadania 1 do  5.
4. Ocena bdb - zadania 1 do 6.

## Sprawozdania

Sprawozdania wysłać na adres leslaw dot pawlaczyk at chorzow dot wsb dot pl
Sprawozdania wysłać w postaci linku do repo na GitHub. 
W mejlu podać nr albumu.
Sprawozdania wysłać do 2023/09/15.

## Ostatnie zmiany

2023/04/06

Można pozostawić zapisywanie danych do pamięci zamiast bazy danych.
