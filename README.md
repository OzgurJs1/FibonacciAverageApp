# Fibonacci Average App

Bu proje, kullanıcıdan alınan derinliğe göre Fibonacci serisini oluşturan ve serinin ortalamasını hesaplayıp ekrana yazdıran bir **C# konsol uygulamasıdır**.  

---

## Özellikler

- Kullanıcıdan pozitif bir sayı alarak Fibonacci serisi üretir.
- Seriyi ekrana yazdırır.
- Fibonacci serisinin ortalamasını hesaplar ve ekrana yazdırır.
- Kod, **Single Responsibility Principle (SRP)** prensibine uygun şekilde sınıflara ayrılmıştır:
  - `InputReader` → Kullanıcıdan veri alır.
  - `FibonacciGenerator` → Fibonacci serisini üretir.
  - `Calculator` → Ortalama hesaplar.
  - `OutputWriter` → Seriyi ve sonucu ekrana yazdırır.

---

## Gereksinimler

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (C# projelerini çalıştırmak için)
- Visual Studio Code veya başka bir C# IDE/editor
  

---

## Kullanım

1. Terminalden proje klasörüne geçin:
   ```bash
   cd FibonacciAverageApp
2. Projeyi çalıştırın
   ```bash
   dotnet run
   
3. Konsolda derinlik değeri girin:
   ```bash
   Fibonacci serisi için derinlik giriniz: 8
 4. Çıktı Örneği
    ```bash
    Fibonacci Serisi: 0, 1, 1, 2, 3, 5, 8, 13
    Fibonacci serisinin ortalaması: 4.125
