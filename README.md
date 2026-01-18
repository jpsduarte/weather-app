![CI](https://github.com/jpsduarte/weather-app/actions/workflows/ci.yml/badge.svg)

# 🌤️ Weather App (Blazor + Open-Meteo)

A **Blazor (.NET 8)** application that automatically detects the user's location using the **browser geolocation API** and displays **real weather data** based on their current position.

This project was built to demonstrate modern **Blazor SSR**, **JavaScript Interop**, and **CI with GitHub Actions**, following practices commonly required by US-based engineering roles.

---

## 🚀 Technologies

- **.NET 8**
- **Blazor SSR**
- **C#**
- **JavaScript (Browser Geolocation API)**
- **Open-Meteo API** (free, no API key required)
- **GitHub Actions (CI)**
- **Git / GitHub**

---

## 📌 Features

- 📍 Automatically detects the user's location via browser
- 🌡️ Displays real weather data based on latitude and longitude
- 📅 Shows daily minimum and maximum temperatures
- ⏳ Asynchronous loading with streaming rendering
- 🔒 Respects browser permission and security model (HTTPS)
- ✅ Continuous Integration with GitHub Actions

---

## 🌎 Weather API

This project uses the public **Open-Meteo API**:

https://open-meteo.com/

Example endpoint:

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
├── .github/
│   └── workflows/
│       └── ci.yml
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

## 🔄 Continuous Integration (CI)

This project uses **GitHub Actions** to automatically validate code changes.

The CI pipeline runs on:
- Every push to `main`
- Every pull request targeting `main`

### Pipeline steps:
- Restore dependencies
- Build the project
- Run automated tests

This ensures that the application always remains in a deployable state.

---

## 🧠 Key Technical Notes

- JS Interop is enabled using `@rendermode InteractiveServer`
- Geolocation is executed only after the component becomes interactive
- Latitude and longitude are formatted using `InvariantCulture` to avoid API errors
- Errors and permission denials are handled gracefully

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