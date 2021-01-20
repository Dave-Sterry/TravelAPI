**API Versioning**
dotnet add package Newtonsoft.Json --version 12.0.2
Install NuGet package manager from extensions
Open Command Palette ">nuget" 
select Nuget Package Manager: Add Package
add "Microsoft.AspNetCore.Mvc.Versioning"
select version 4.0.0
run dotnet restore. 

leaving off after changing Startup Class (https://neelbhatt.com/2018/04/21/api-versioning-in-net-core/), what's next is adding versioning to our CitiesController.cs
