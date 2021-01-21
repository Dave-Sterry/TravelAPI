# Travel API Solution
<div align="center">
<img src="https://github.com/Dave-Sterry.png" width="200px" height="auto">
<img src="https://github.com/taylulz.png" width="200px" height="auto">
<img src="https://github.com/cschweig2.png" width="200px" height="auto">
</div>

### A C# website by David Sterry, Chelsea Becker, Taylor Delph
Initialized on 01/19/21
Last updated on 01/21/21


## **Project Description**
An API that allows users to GET and POST reviews about various travel destinations around the world.


## **User Stories**

As a user, I want to GET and POST reviews about travel destinations.
As a user, I want to GET reviews by city.
As a user, I want to see the most popular travel destinations by overall rating.
As a user, I want to PUT and DELETE reviews


## **Required for Use**
* C# and .Net Core installed on your local machine. Download .Net Core [Here](https://dotnet.microsoft.com/download) Follow the instructions to install on your machine
* Console/Terminal access.
* Code Editor like VSCode download [Here](https://code.visualstudio.com/) Follow the instructions to install on your machine
* MySQL Community Server download [Here](https://dev.mysql.com/downloads/mysql/) Follow the instructions to install on your machine
* MySQL Workbench [Here](https://www.mysql.com/products/workbench/) Follow the instructions to install on your machine
* Postman download [Here](https://www.postman.com/downloads/)Follow the instructions to set up an account and install on your machine
* Swashbuckle follow the setup tutorial [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio-code)
* An internet browser of your choice; I prefer Chrome


## **How to get this project**

### Download from Github:
1. Use the browser navigate to my GitHub page [respository](https://github.com/Dave-Sterry/TravelAPI)
2. Click the Green **Code** button and select **Download Zip**

### Alternatively clone from Github via Gitbash:
1. In your terminal, navigate to the folder where you would like to clone the project too
2. Clone this repo to your chosen folder using "git clone https://github.com/Dave-Sterry/TravelAPI in terminal


## **Installation Instructions**
### **Setup Database Connection**

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `TravelAPI` directory.
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=root;pwd=epicodus;"
  }
}

```
* Update the Server, Port, and User ID as needed with your own

Import Database using Entity Framework Core
* Navigate to TravelAPI.Solution/TravelAPI and type `dotnet ef database update` into the terminal. This will update the existing migrations

Launch the API
1. Navigate to TravelAPI.Solution/TravelAPI and type `dotnet run` into the terminal.

## API Documentation
Explore our API endpoints with Swagger Documentation:
* After launching the API, use a browser to navigate to `http://localhost:5000/swagger/`

## Endpoints
Base URL: `https://localhost:5000`

Http Request Structure

```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```
### Example Query
```
https://localhost:5000/api/cities/2
```
### Sample JSON Response
```
{
  "Id": 1,
  "Name": "Renton",
  "Rating": 9,
  "Attraction": "Boeing",
  "Review": "Some hot tubs
}
```
### Cities
Access information on cities people have reviewed

```
GET /api/cities
POST /api/cities
GET /api/cities/{id}
PUT /api/cities/{id}
DELETE /api/cities/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | true | Return matches by city name.
| Attraction | string | none | true | Return cities by attractions. |
| Review | string | none | true | Return user review of city visited. |
| Rating| int | none | true | Return user rating of city |

### Example Query
```
https://localhost:5000/api/cities/?name=Renton
```

### Sample JSON Response
```
{
  "Id": 1,
  "Name": "Renton",
  "Rating": 9,
  "Attraction": "Boeing",
  "Review": "Some hot tubs
}
```
..........................................................................................
### Packlist
Access information on a list of things to pack for a trip

```
GET /api/packlist
POST /api/packlist
GET /api/packlist/{id}
PUT /api/packlist/{id}
DELETE /api/packlist/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Items | string | none | true | Return matches by items to pack.


### Example Query
```
https://localhost:5000/api/packlist/
```

### Sample JSON Response
```
{
  "Id": 1,
  "Items": "Toothbrush, sandles, hot tob shorts"
}
```

## **Known Bugs**
No known bugs at this time

## **Technology Used**
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* CSS
* HMTL
* Bootstrap
* Razor
* dotnet script, REPL
* Identity
* Postman
* Swagger
* Swashbuckle

## **Authors and Contributors**

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>David Sterry</td>
    <td>https://github.com/Dave-Sterry</td>
    <td>sterry.david@gmail.com</td>
  </tr>
  <tr>
    <td>Taylor Delph</td>
    <td>https://github.com/taylulz</td>
    <td>taylulzcode@gmail.com</td>
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
  </tr>
</table>

## **Contact**
If you have any issues during installation delete both the bin and obj folders and follow the set up instructions again. Please contact any of the contributors if you run into any problems.

## **License**

This project is licensed under **MIT 2.0**

Copyright © 2020 David Sterry, Taylor Delph, Chelsea Becker



<!-- **API Versioning**
dotnet add package Newtonsoft.Json --version 12.0.2
Install NuGet package manager from extensions
Open Command Palette ">nuget"
select Nuget Package Manager: Add Package
add "Microsoft.AspNetCore.Mvc.Versioning"
select version 4.0.0
run dotnet restore.


Versioning: for the time being, this is our solve to use api v2.0. Add `o.DefaultApiVersion = new ApiVersion(2, 0);});` to our api Startup.cs under the `ConfigureServices` section. Not sure why this isn't workin in the ApiHelper class in client project.

Adding Swagger:
https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio-code

-`dotnet add ProjectNameApi.csproj package Swashbuckle.AspNetCore -v 5.5.0`
to the ConfigureServices section, add:
-add `services.AddDbContext<TodoContext>(opt =>
        opt.UseInMemoryDatabase("TodoList"));`
-add `services.AddSwaggerGen();`

services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1); USE THIS ONE
 Below version is already in our code. Use the above or edit to change version to 2_2
  // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

to the Configure section, add middleware:
-`app.UseSwagger();`
-`app.UseSwaggerUI(c =>
  {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
  });`
 -->
