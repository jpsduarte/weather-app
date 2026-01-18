# 🌤️ Weather App (Blazor + Open-Meteo)

A **Blazor (.NET)** application that uses the **browser geolocation API** to automatically detect the user's location and display **real weather data** based on their current position.

This project demonstrates:
- Browser geolocation with JavaScript
- JS Interop in Blazor SSR
- External API consumption
- Asynchronous rendering and streaming
- Clean integration between C# and JavaScript

---

## 🚀 Technologies

- **.NET 8**
- **Blazor SSR**
- **C#**
- **JavaScript (Browser Geolocation API)**
- **Open-Meteo API** (free, no API key required)
- **Git / GitHub**

---

## 📌 Features

- 📍 Automatically detects the user's location via browser
- 🌡️ Displays real weather data based on latitude and longitude
- 📅 Shows daily minimum and maximum temperatures
- ⏳ Asynchronous loading with streaming rendering
- 🔒 Respects browser permission and security model (HTTPS)

---

## 🌎 Weather API

This project uses the public **Open-Meteo API**:

https://open-meteo.com/

Example endpoint used:

```text
https://api.open-meteo.com/v1/forecast
?latitude={latitude}
&longitude={longitude}
&daily=temperature_2m_max,temperature_2m_min
&timezone=auto
```

---

## 🧱 Project Structure

```text
weather-app/
│
├── Components/
│   └── Pages/
│       └── Weather.razor
│
├── Models/
│   └── OpenMeteoResponse.cs
│
├── wwwroot/
│   └── js/
│       └── geolocation.js
│
├── Program.cs
├── App.razor
├── README.md
└── weather-app.csproj
```

---

## ▶️ Running the project

### Prerequisites
- .NET 8 SDK installed  
- Git installed  

### Steps

```bash
git clone https://github.com/jpsduarte/weather-app.git
cd weather-app
dotnet restore
dotnet run
```

Open in the browser:

```text
https://localhost:xxxx/weather
```

⚠️ **Note:** Browser geolocation only works on `https://` or `localhost`.

---

## 🧠 Key Technical Notes

- JS Interop is enabled using `@rendermode InteractiveServer`
- Geolocation is executed only after the component becomes interactive
- Latitude and longitude are formatted using `InvariantCulture` to avoid API errors
- The application gracefully handles permission denial and errors

---

## 🛠️ Future Improvements

- 📍 Cache user location (localStorage)
- 🏙️ Manual city selection fallback
- 🌡️ Current temperature and feels-like data
- 📊 Charts and visualizations
- 🧪 Automated tests
- 🧼 Service layer abstraction (Clean Architecture)

---

## 📄 License

This project is open-source and intended for learning and portfolio purposes.

---

## 👤 Author

**João Paulo dos Santos Duarte**  
Software Engineer | Product Manager  
🇧🇷 Brazil