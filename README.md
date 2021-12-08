# BuyMeACoffeeInterface_ASP.NET_WEBSITE

Example ASP.NET MVC 5 website

To start with you will need to go here and login to get your API token https://developers.buymeacoffee.com/dashboard

Then head on over to the HomeController and edit this line by replacing your access_token with the API token from BMC
private static string access_token = "change me to your token!";


The Views are just examples and you can do whatever you want with the string result you get from the API.

Includes examples of deserializing the response into a model class
