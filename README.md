# Dashboard
Dashboard Project

## Modules
* Weather
* Twitter Feed
* Facebook Feed
* RSS Feed
* To-Do

### Weather
Method: JSON  
Class & Model: GetWeather.cs  
Function: PopulateWeather()  

Examples of API calls:  
api.openweathermap.org/data/2.5/weather?id={city id}&appid={your api key}

API Response
```json
{
coord: {
lon: 145.77,
lat: -16.92
},
weather: [
{
id: 802,
main: "Clouds",
description: "scattered clouds",
icon: "03n"
}
],
base: "stations",
main: {
temp: 300.15,
pressure: 1007,
humidity: 74,
temp_min: 300.15,
temp_max: 300.15
},
visibility: 10000,
wind: {
speed: 3.6,
deg: 160
},
clouds: {
all: 40
},
dt: 1485790200,
sys: {
type: 1,
id: 8166,
message: 0.2064,
country: "AU",
sunrise: 1485720272,
sunset: 1485766550
},
id: 2172797,
name: "Cairns",
cod: 200
}
```
**Usage**

1. Form1 variables
   - yourkeys
   - hashtag
   - tweetsQty

url: https://openweathermap.org/api  
extended documentation: https://openweathermap.org/current


### Twitter Feed
Method: API  

**Usage**  

url:  
extended documentation:   

### Facebook Feed
In progress

### RSS Feed
Method: XML  

**Usage**  

url:  
extended documentation:   

### To-Do
In Progress



### Tools
* https://jsonutils.com/  

### Help

