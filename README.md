# 🌤️ Weather App (Blazor + Open-Meteo)

A **Blazor (.NET)** application that consumes a **real weather API** to display daily temperature forecasts in a clean and efficient way.

This project demonstrates:
- External API consumption
- `HttpClient` usage
- Asynchronous rendering
- Good practices with Blazor and .NET

---

## 🚀 Technologies

- **.NET 8**
- **Blazor**
- **C#**
- **Open-Meteo API** (free, no API key required)
- **Git / GitHub**

---

## 📌 Features

- 📅 Displays daily weather forecast
- 🌡️ Shows minimum and maximum temperatures
- ⏳ Asynchronous data loading
- 🌍 Real weather data based on fixed latitude/longitude

---

## 🌎 Weather API

This project uses the public **Open-Meteo API**:

https://open-meteo.com/

Example endpoint used:

```
https://api.open-meteo.com/v1/forecast
?latitude=-23.55
&longitude=-46.63
&daily=temperature_2m_max,temperature_2m_min
&timezone=auto
```

---

## 🧱 Project Structure

```
weather-app/
│
├── Pages/
│   └── Weather.razor
│
├── Models/
│   └── OpenMeteoResponse.cs
│
├── Program.cs
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

```
https://localhost:xxxx/weather
```

---

## 🛠️ Future Improvements

- 📍 User geolocation
- 🏙️ City selection
- 🌡️ Current temperature and feels-like
- 📊 Weather charts
- 🧪 Automated tests
- 🧼 Service layer (Clean Architecture)

---

## 📄 License

This project is open-source and intended for learning and study purposes.

---

## 👤 Author

**João Paulo dos Santos Duarte**  
Software Engineer | Product Manager  
🇧🇷 Brazil  
