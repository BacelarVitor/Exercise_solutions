// Package weather provides tools to see the current forecast of Globinocus cities.
package weather

// CurrentCondition represents the current forecast of the city.
var CurrentCondition string

// CurrentLocation represents the current selected city for the forecast.
var CurrentLocation string

// Forecast receives a string value called city that represents the city for the forecast and a string value condition that represents the current weather of the selected city and returns a string value representing the current forecast of the selected city.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
