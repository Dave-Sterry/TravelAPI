**API Versioning**
dotnet add package Newtonsoft.Json --version 12.0.2
Install NuGet package manager from extensions
Open Command Palette ">nuget" 
select Nuget Package Manager: Add Package
add "Microsoft.AspNetCore.Mvc.Versioning"
select version 4.0.0
run dotnet restore. 


Versioning: for the time being, this is our solve to use api v2.0. Add `o.DefaultApiVersion = new ApiVersion(2, 0);});` to our api Startup.cs under the `ConfigureServices` section. Not sure why this isn't workin in the ApiHelper class in client project.

To-Do:
-add another class aside from City
