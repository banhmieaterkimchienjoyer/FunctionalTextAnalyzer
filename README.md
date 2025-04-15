# 📊 FunctionalTextAnalyzer
### Program napisany w języku C# z użyciem podejścia funkcyjnego

## 🔍 Opis
Ten projekt to **funkcyjny analizator tekstu** napisany w języku **C#**, którego zadaniem jest analiza kolekcji zdań. Program wykorzystuje styl funkcyjny do przetwarzania danych – bez modyfikowania stanu, z wykorzystaniem metod LINQ oraz wyrażeń funkcyjnych (`Select`, `Where`, `GroupBy`, `Aggregate`, `Func<>`).

## ✅ Wymagania
- .NET 6 lub nowszy
- Visual Studio / Rider / VS Code

## 🧠 Podejście funkcyjne
Program wykorzystuje podejście funkcyjne:
- Bez zmiennych mutowanych (wszystko poprzez transformacje danych)
- Operacje na kolekcjach przy pomocy LINQ
- `Select`, `SelectMany`, `GroupBy`, `OrderByDescending`, `Where`, `Aggregate`, `Distinct`
- Brak instrukcji warunkowych i pętli typu `for`/`while`

## 📌 Funkcjonalności
- Obliczanie liczby wszystkich słów
- Zliczanie liczby unikalnych słów
- Wyświetlanie top 5 najczęstszych słów
- Analiza długości zdań
- Wyświetlanie słów zaczynających się na konkretną literę (np. „f”)

## 💡 Przykład działania:
```
--- ANALIZA ZDAŃ ---

Liczba wszystkich słów: 25  
Liczba unikalnych słów: 21  

Top 5 najczęstszych słów:  
programming - 2  
functional - 2  
is - 2  
code - 2  
c# - 1  

Długości zdań (w słowach):  
6  
7  
6  
6  

Słowa zaczynające się na literę 'f':  
functional  
functions
```

## 🔗 Biblioteki funkcyjne
- `System.Linq`
- `System.Func<>`

## ✅ Jak uruchomić:
```bash
dotnet restore
dotnet run
```
