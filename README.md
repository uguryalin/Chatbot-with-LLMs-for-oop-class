# Gemini AI Destekli OOP Konsol Chatbot / Gemini AI-Powered OOP Console Chatbot

[English version below](#english-version)

---

## Türkçe Versiyon

Bu proje, Nesne Tabanlı Programlama (OOP) dersi kapsamında geliştirilmiş, Gemini API kullanarak çalışan konsol tabanlı bir yapay zeka sohbet uygulamasıdır. Proje, harici üçüncü taraf NuGet paketlerine bağımlı olmadan, tamamen .NET'in yerleşik sınıfları (`HttpClient` ve `System.Text.Json`) kullanılarak geliştirilmiştir.

### 🌟 Temel Özellikler
*   **İnteraktif Konsol Arayüzü:** Renkli menüler, ASCII başlık tasarımı.
*   **Daktilo Yazı Efekti:** Yapay zekanın cevaplarını harf harf ekrana yazdıran premium hissi veren efekt.
*   **Asenkron Çalışma:** Gemini yanıt bekletirken ekranda dönen dinamik yükleme animasyonu (Task & Thread yönetimi).
*   **Yerel Geçmiş Yönetimi:** Sohbet geçmişini JSON formatında yerel diskte saklama ve kaldığı yerden devam etme.
*   **Dinamik Ayarlar:** API anahtarını ve yapay zeka modelini uygulama açıkken konsoldan değiştirebilme.

### 🛠️ Uygulanan OOP Prensipleri

Proje yapısı, nesne yönelimli programlamanın temel ilkelerini gösterecek şekilde tasarlanmıştır:

1.  **Soyutlama (Abstraction):**
    *   `IChatService` ve `IHistoryManager` arayüzleri (interface) tanımlanmıştır. Bu arayüzler, sistemin diğer parçalarına arka planda hangi işlemlerin yapıldığını bilmeden sadece metotları çağırma imkanı verir.
2.  **Kapsülleme (Encapsulation):**
    *   `ChatSession` sınıfı, mesaj geçmişi listesini (`List<ChatMessage>`) `private` olarak tutar. Dışarıdaki sınıfların bu listeyi doğrudan manipüle etmesi engellenmiş, mesaj ekleme ve silme işlemleri `SendUserMessageAsync` ve `ClearHistory` metotları ile sınırlandırılarak kontrol altına alınmıştır.
3.  **Çok Biçimlilik (Polymorphism) & Bağımlılık Enjeksiyonu (DI):**
    *   `ChatSession` sınıfı somut sınıflara değil, `IChatService` ve `IHistoryManager` arayüzlerine bağımlıdır. Nesneler sınıfa dışarıdan enjekte edilir. Bu sayede, gelecekte Gemini yerine başka bir servis (örn. GPT veya Mock) eklenmek istendiğinde kodun yapısı bozulmaz.
4.  **Tek Sorumluluk İlkesi (Single Responsibility Principle - SOLID):**
    *   Her sınıfın tek bir görevi vardır. `ChatMessage` mesaj verisini tutar, `GeminiChatService` sadece ağ isteklerini yönetir, `FileHistoryManager` disk işlemlerini yapar, `ConfigManager` ise ayarları yönetir.

---

### 📂 Proje Klasör Yapısı

```text
├── Models/
│   ├── ChatMessage.cs     # Mesaj veri yapısı (Role, Text, Timestamp)
│   └── ChatSession.cs     # Sohbet oturum yönetimi ve akışı
├── Services/
│   ├── IChatService.cs    # Yapay zeka servis arayüzü
│   ├── IHistoryManager.cs # Kayıt yöneticisi arayüzü
│   ├── GeminiChatService.cs # Gemini REST API istemcisi
│   └── FileHistoryManager.cs # JSON Dosya tabanlı kayıt yöneticisi
├── Helpers/
│   └── ConfigManager.cs   # appsettings.json dosyasını okuyan/yazan yardımcı sınıf
├── appsettings.json       # API Anahtarı ve Model ayarları
├── ChatbotApp.csproj      # Proje yapılandırma dosyası
├── nuget.config           # Nuget ayarları (Bağımsız derleme için)
└── Program.cs             # Konsol arayüzü ve uygulamanın ana giriş noktası
```

### 🚀 Nasıl Çalıştırılır?

1.  Bilgisayarınızda .NET SDK (8.0 veya üzeri) yüklü olduğundan emin olun.
2.  Proje klasörünün içinde bir terminal açın ve şu komutla projeyi derleyin:
    ```powershell
    dotnet build
    ```
3.  Uygulamayı çalıştırmak için:
    ```powershell
    dotnet run
    ```
4.  Konsol menüsündeki adımları izleyin. API anahtarınız `appsettings.json` dosyasına kaydedilmiştir ve menüden güncellenebilir.

---

<a name="english-version"></a>
## English Version

This project is a console-based artificial intelligence chatbot application developed using the Gemini API for an Object-Oriented Programming (OOP) course. The application is built entirely using .NET's native classes (`HttpClient` and `System.Text.Json`) with no external third-party NuGet dependencies.

### 🌟 Key Features
*   **Interactive Console UI:** Colored menus, ASCII banner design.
*   **Typewriter Printing Effect:** A premium visual effect that displays AI answers letter by letter.
*   **Asynchronous Processing:** Dynamic thinking spinner (Task & Thread management) while waiting for Gemini API responses.
*   **Local History Management:** Store conversation logs locally in JSON format and resume conversations seamlessly.
*   **Dynamic Configuration:** Update the API key or switch AI models directly from the settings console.

### 🛠️ Applied OOP Principles

The project architecture is structured specifically to showcase the core concepts of OOP:

1.  **Abstraction:**
    *   Interfaces like `IChatService` and `IHistoryManager` define contracts. Other parts of the system only interact with these contracts, ignoring their implementation details.
2.  **Encapsulation:**
    *   The `ChatSession` class maintains the message history (`List<ChatMessage>`) as a `private` member. Direct modification of the list is restricted; adding or resetting messages can only be done safely via `SendUserMessageAsync` and `ClearHistory` methods.
3.  **Polymorphism & Dependency Injection (DI):**
    *   `ChatSession` is loosely coupled, depending on `IChatService` and `IHistoryManager` interfaces rather than concrete classes. Implementations are injected via the constructor, allowing easy swaps (e.g. from Gemini to a Mock test service) without changing session logic.
4.  **Single Responsibility Principle (SOLID - SRP):**
    *   Each class has a single responsibility. `ChatMessage` represents data, `GeminiChatService` handles network communication, `FileHistoryManager` handles local file persistence, and `ConfigManager` parses configurations.

---

### 📂 Directory Structure

```text
├── Models/
│   ├── ChatMessage.cs     # Message data structure (Role, Text, Timestamp)
│   └── ChatSession.cs     # Chat session manager and state machine
├── Services/
│   ├── IChatService.cs    # AI service contract interface
│   ├── IHistoryManager.cs # History manager contract interface
│   ├── GeminiChatService.cs # Gemini REST API HTTP client
│   └── FileHistoryManager.cs # JSON File-based history storage client
├── Helpers/
│   └── ConfigManager.cs   # Config helper to read/write appsettings.json
├── appsettings.json       # Config settings (API Key, Model name)
├── ChatbotApp.csproj      # .NET Project configuration
├── nuget.config           # Nuget configuration (Clears package issues)
└── Program.cs             # Interactive main UI console loop
```

### 🚀 How to Run

1.  Ensure you have .NET SDK (8.0 or higher) installed on your system.
2.  Open your terminal inside the project directory and build the project:
    ```powershell
    dotnet build
    ```
3.  Run the application using:
    ```powershell
    dotnet run
    ```
4.  Follow the instructions in the terminal. Your API key is loaded from `appsettings.json` and can be managed directly via the menu.
