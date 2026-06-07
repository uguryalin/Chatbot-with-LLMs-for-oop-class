# Keylogger Clone - OOP Course Project

[Türkçe Açıklama İçin Aşağıya Kaydırın / Scroll Down for Turkish](#türkçe-nesne-tabanlı-programlama-keylogger-projesi)

An educational keylogger simulation built in C# using Windows Forms on .NET 9.0. It is specifically designed to demonstrate core Object-Oriented Programming (OOP) concepts, software design patterns, and clean architecture separation of concerns.

> [!WARNING]
> **DISCLAIMER**: This application is created strictly for educational purposes as part of an academic Object-Oriented Programming course homework. Monitoring keypresses without authorization is illegal. Global system hooks can trigger Windows Defender or external antiviruses; see [Running Safely](#running-safely) below.

---

## 🚀 Key Features

* **Global Keystroke Interception**: Utilizes native Windows Win32 API (`SetWindowsHookEx` with `WH_KEYBOARD_LL`) to intercept keystrokes globally.
* **Active Window Tracking**: Identifies the application/window where typing takes place and organizes log headers accordingly.
* **Premium Dark Theme UI**: A custom flat dark-mode dashboard providing a clean real-time view of intercepted inputs.
* **Telemetry Dashboard**: Displays hook status, character counters, active application header, and application execution elapsed runtime.
* **Triple Output Modes**: Stream logs simultaneously to three channels:
  1. A real-time UI text box.
  2. A local flat-text file.
  3. **An email address asynchronously via SMTP** (logs are buffered in memory and sent automatically to avoid blocking user input).

---

## 🛠️ OOP Architecture & Design Patterns

This project highlights several key Object-Oriented principles and software design patterns:

### 1. The Core OOP Pillars
* **Abstraction**: Interception, logging, and key string formatting are abstracted away behind interfaces:
  * [`IKeyboardListener`](./Listeners/IKeyboardListener.cs)
  * [`ILogger`](./Loggers/ILogger.cs)
  * [`IKeyFormatter`](./Formatters/IKeyFormatter.cs)
* **Encapsulation**: Raw Win32 P/Invoke APIs, pointers, and hook state fields are encapsulated safely inside internal static helpers ([`Win32Api.cs`](./Core/Win32Api.cs)). Only high-level event wrappers are exposed to the rest of the application.
* **Inheritance & Polymorphism**: A template method pattern base class [`BaseLogger`](./Loggers/BaseLogger.cs) implements the core formatting and locking functionality, while concrete subclasses [`FileLogger`](./Loggers/FileLogger.cs), [`EventLogger`](./Loggers/EventLogger.cs), and [`EmailLogger`](./Loggers/EmailLogger.cs) implement polymorphic writing behaviours.

### 2. Design Patterns Applied
* **Singleton Pattern**: The [`KeyloggerEngine`](./Engine/KeyloggerEngine.cs) controls the listener hook and routes events. It runs as a Singleton instance (`Instance`) to ensure only one system-wide global hook is active at any time.
* **Observer Pattern**: The keyboard hook publisher acts as the Subject, notifying registered `ILogger` Observers via standard C# Events and Delegates whenever a key intercept occurs.
* **Factory Pattern**: The [`LoggerFactory`](./Loggers/LoggerFactory.cs) generates loggers dynamically at runtime based on string parameters, abstracting away concrete class instantiations from the GUI.

### 3. Asynchronous Buffering (Email Logging)
* The [`EmailLogger`](./Loggers/EmailLogger.cs) keeps a memory buffer of keystrokes. When the buffer size reaches 200 characters or when the interception is stopped, it spawns a background thread task (`Task.Run`) to connect and send the email over SMTP, ensuring the low-level system keyboard thread never blocks or lags due to network latency.

---

## 💻 Running Safely

Because global keyboard hooking operates on low-level system APIs, **Windows Defender** or third-party antivirus utilities may flag or block the output executable.

To run it without issues:
1. Temporarily allow the threats or add the project folder to Windows Defender exclusions:
   * Go to **Settings > Update & Security > Windows Security > Virus & threat protection**.
   * Under **Virus & threat protection settings**, click **Manage settings**.
   * Under **Exclusions**, click **Add or remove exclusions** and select the folder `KeyLoger-Clone-For-OOP-class`.
2. Compile and run the project using the .NET CLI.

### Compilation and Execution:
Open your shell (PowerShell or CMD) in the project root folder and execute:
```bash
# Build the project
dotnet build

# Run the project
dotnet run
```

---

<br/>

# Türkçe: Nesne Tabanlı Programlama Keylogger Projesi

Bu proje, C# dili ve .NET 9.0 Windows Forms kullanılarak geliştirilmiş eğitsel bir keylogger simülasyonudur. Proje, Nesne Tabanlı Programlama (NTP/OOP) prensiplerini, yazılım tasarım desenlerini (Design Patterns) ve temiz mimari ayrımını uygulamalı olarak göstermek amacıyla hazırlanmıştır.

> [!WARNING]
> **UYARI**: Bu uygulama, yalnızca akademik Nesne Tabanlı Programlama dersi ödevi kapsamında eğitim amacıyla geliştirilmiştir. Yetkisiz klavye takibi yapmak yasalara aykırıdır. Küresel sistem kancaları (global hooks) Windows Defender veya antivirüs yazılımlarını tetikleyebilir; aşağıdaki [Güvenli Çalıştırma](#güvenli-çalıştırma) kısmını inceleyin.

---

## 🚀 Öne Çıkan Özellikler

* **Küresel Klavye Takibi**: Windows API (`SetWindowsHookEx` ile `WH_KEYBOARD_LL`) kullanarak arka planda klavye girdilerini yakalar.
* **Aktif Pencere Algılama**: Tuşların hangi uygulamada yazıldığını algılar ve günlük başlıklarını buna göre gruplar.
* **Modern Karanlık Tema Arayüzü**: Yakalanan tuş vuruşlarını gerçek zamanlı gösteren şık, düz (flat) tasarım karanlık mod ekranı.
* **İletişim ve Metrik Paneli**: Kanca durumu, toplam tuş sayısı, aktif uygulama ismi ve çalışma süresini saniye bazlı gösteren sayaç.
* **Üçlü Çıktı Desteği**: Günlükleri aynı anda üç farklı kanala yönlendirebilir:
  1. Arayüzdeki gerçek zamanlı metin paneli.
  2. Yerel bir metin dosyası (`.txt`).
  3. **SMTP üzerinden e-posta adresi** (tuş vuruşları bellekte biriktirilir ve kullanıcı girişini engellememek için arka planda asenkron olarak gönderilir).

---

## 🛠️ OOP Mimarisi ve Tasarım Desenleri

Projede kullanılan temel Nesne Tabanlı Programlama yapıları ve desenleri şunlardır:

### 1. Temel OOP Prensipleri
* **Soyutlama (Abstraction)**: Tuş dinleme, günlük kaydetme ve tuş formatlama işlemleri arayüzlerle (interfaces) soyutlaştırılmıştır:
  * [`IKeyboardListener`](./Listeners/IKeyboardListener.cs)
  * [`ILogger`](./Loggers/ILogger.cs)
  * [`IKeyFormatter`](./Formatters/IKeyFormatter.cs)
* **Kapsülleme (Encapsulation)**: Ham Win32 API çağrıları, işaretçiler (pointers) ve kanca durumları [`Win32Api.cs`](./Core/Win32Api.cs) sınıfı içinde gizlenmiş olup sadece güvenli olaylar (events) dışa aktarılmıştır.
* **Kalıtım ve Çok Biçimlilik (Inheritance & Polymorphism)**: [`BaseLogger`](./Loggers/BaseLogger.cs) sınıfı, biçimlendirme ve iş parçacığı güvenliğini (thread-safety) üstlenirken; ondan türeyen [`FileLogger`](./Loggers/FileLogger.cs), [`EventLogger`](./Loggers/EventLogger.cs) ve [`EmailLogger`](./Loggers/EmailLogger.cs) sınıfları yazma işlevini çok biçimli olarak gerçekleştirir.

### 2. Kullanılan Tasarım Desenleri
* **Singleton Deseni**: [`KeyloggerEngine`](./Engine/KeyloggerEngine.cs) tüm dinleyiciyi yönetir. Sistemin sadece tek bir kanca ile çalışmasını sağlamak için Singleton (`Instance`) yapısında tasarlanmıştır.
* **Observer Deseni**: Klavye kancasını dinleyen mekanizma (Subject), klavye olayları gerçekleştikçe kayıtlı `ILogger` gözlemcilerini (Observers) C# Olayları (Events) aracılığıyla haberdar eder.
* **Factory Deseni**: [`LoggerFactory`](./Loggers/LoggerFactory.cs) arayüz kodunu doğrudan sınıflarla bağlamadan, girilen metin tipine göre dinamik olarak doğru günlükleyici nesnesini üretir.

### 3. Asenkron Bellek Biriktirme (Email Loglama)
* [`EmailLogger`](./Loggers/EmailLogger.cs) yakalanan tuşları bellekte (`StringBuilder`) saklar. Bellekteki karakter boyutu 200'e ulaştığında veya izleme durdurulduğunda, bir arka plan görevi (`Task.Run`) başlatarak e-postayı SMTP üzerinden gönderir. Bu sayede, ağ gecikmelerinin kullanıcının klavyesini takılmalarla (lag) etkilemesi engellenmiş olur.

---

## 💻 Güvenli Çalıştırma

Küresel klavye kancaları düşük seviyeli sistem çağrıları kullandığından, **Windows Defender** veya antivirüs programınız oluşan `.exe` dosyasını engelleyebilir veya silebilir.

Sorunsuz çalıştırmak için:
1. Windows Defender üzerinde proje klasörünü dışlamalara (istisnalara) ekleyin:
   * **Ayarlar > Güncelleştirme ve Güvenlik > Windows Güvenliği > Virüs ve tehdit koruması** yolunu izleyin.
   * **Virüs ve tehdit koruması ayarları** altındaki **Ayarları yönet** seçeneğine tıklayın.
   * **Dışlamalar** kısmından **Dışlama ekle veya kaldır** diyerek `KeyLoger-Clone-For-OOP-class` klasörünü seçin.
2. .NET CLI kullanarak projeyi derleyin ve çalıştırın.

### Derleme ve Çalıştırma Adımları:
Proje ana dizininde terminali (PowerShell veya CMD) açıp şu komutları çalıştırın:
```bash
# Projeyi derle
dotnet build

# Projeyi çalıştır
dotnet run
```
