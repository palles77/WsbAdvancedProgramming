# Laboratorium Programowania Zaawansowanego Nr 4

W tym laboratorium poruszane są następujące zagadnienia:
1. Technologia 'Razor Pages' nazywana inaczej 'Asp.Net Core Web Apps'.
2. Logowanie do systemu i rejestracja użytkowników.
3. Wykorzystywanie technologii SignalR do wysyłania asynchronicznych wiadomości od serwera do aplikacji klienckich napisanych w JavaScript.

# Zadania do wykonania

1. Dodać zapisywanie komunikatów wysyłanych do serwera do bazy danych. W tym celu utworzyć tabelkę 'Messages' i dodać ją jako część migracji bazy danych w górę (patrz laboratorium 2).
2. Zapisane komunikaty w tabeli Messages wyświetlać na osobnej zakładce 'History'. Zakładka ta ma wyświetlać tylko komunikaty wysłane przez zalogowanego użytkownika.
3. Dodać zakładkę 'Users', która będzie wyświetlać listę zarejestrowanych użytkowników. Zakładka ta ma być widoczna tylko dla użytkownika 'admin@email.com'.

# Literatura pomocnicza

1. https://docs.microsoft.com/pl-pl/aspnet/core/tutorials/signalr?view=aspnetcore-5.0&tabs=visual-studio
2. https://stackoverflow.com/questions/50179696/how-add-asp-net-core-identity-to-existing-core-mvc-project
3. https://docs.microsoft.com/pl-pl/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio

# Ostatnia zmiana
14/05/2021
