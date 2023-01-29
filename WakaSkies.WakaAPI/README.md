# WakaSkies.WakaAPI
The WakaAPI project will use WakaTime's public API to retrieve data about a user.

The user must provide their API key into the app. 
Then, it will encode the API key and use the Insights endpoint that the API provides.
The data that is returned is turned into a C# object and should be passed into WakaSkies.ModelBuilder.