## Dotnet Core CLI Commands
- Note: For Bash You can Revert BackSlash / to ForwardSlash /
- Note: For Ubuntu You can Revert BackSlash / to ForwardSlash /
- Create a Folder for your project with that folder run the following commands

### SOLUTION COMMANDS
```bash
dotnet new sln -o SolutionName
```
### CLASS LIBRARY
```bash
dotnet new webapi -o SB.Api
dotnet new classlib -o SB.App
dotnet new classlib -o SB.Contracts
dotnet new classlib -o SB.Infra
dotnet new classlib -o SB.Domain
```
### ADD / REMOVE PROJECTS
```bash
dotnet sln add ./SB.Api
dotnet sln add ./SB.App
dotnet sln add ./SB.Contracts
dotnet sln add ./SB.Infra
dotnet sln add ./SB.Domain

dotnet sln add (ls -r **/*.csproj) # Powershell Command
dotnet sln remove ./SB.Contacts/SB.Contacts.csproj # cmd
dotnet format ./solution.sln # ??
more./SolutionName.sln # ??
```
### ADDING LOCAL PROJECTS
```bash
dotnet build
dotnet add ./SB.Api/ reference ./SB.Contracts/ ./SB.App/ ./SB.Infra/
dotnet add ./SB.Infra/ reference ./SB.App/ ./SB.Domain/
dotnet add ./SB.App/ reference ./SB.Domain/
```
### RUNNING PROJECTS
```bash
dotnet run --project ./SB.Api/
dotnet watch run --project ./SB.Api/
```

#### USER SECRETS
```bash 
dotnet user-secrets init --project ./SB.Api/
dotnet user-secrets set --project ./SB.Api/ "JwtSettings:Secret" "super-secret-key-from-user-secrets"
dotnet user-secrets list --project ./SB.Api/
```
### EXTERNAL PACKAGES
- Adding Packages to Specific Project
```bash
dotnet add ./SB.Api/ package AutoMapper 
dotnet add ./SB.Api/ package AspNetCoreRateLimit 
dotnet add ./SB.Api/ package Marvin.Cache.Headers 
dotnet add ./SB.Api/ package Microsoft.AspNetCore.Mvc.Versioning 
dotnet add ./SB.Api/ package Microsoft.EntityFrameworkCore.Design 
dotnet add ./SB.Api/ package Microsoft.EntityFrameworkCore.Tools 
dotnet add ./SB.Api/ package X.PagedList.Mvc.Core 

dotnet add ./SB.App/ package OneOf # Drawback of Scalability used in App Layer
dotnet add ./SB.App/ package FluentResults # It has Lack Some Ability of OneOf used in App Layer
dotnet add ./SB.App/ package FluentValidation
dotnet add ./SB.App/ package FluentValidation.AspNetCore
dotnet add ./SB.App/ package Mapster
dotnet add ./SB.App/ package MediatR
dotnet add ./SB.App/ package MediatR.Extension.Microsoft.DependencyInjection
dotnet add ./SB.App/ package Microsoft.Extensions.DependencyInjection.Abstractionst

dotnet add ./SB.Domain/ package ErrorOr # Recommended and Final Approach

dotnet add ./SB.Infra/ package DynamicExpressions.NET
dotnet add ./SB.Infra/ package LinqKit.Core
dotnet add ./SB.Infra/ package Microsoft.EntityFrameworkCore 
dotnet add ./SB.Infra/ package Microsoft.EntityFrameworkCore.SqlServer
# dotnet add ./SB.Infra/ package Microsoft.EntityFrameworkCore.Design
dotnet add ./SB.Infra/ package Microsoft.EntityFrameworkCore.DynamicLinq
dotnet add ./SB.Infra/ package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add ./SB.Infra/ package Microsoft.AspNetCore.Authentication.OpenIdConnect
dotnet add ./SB.Infra/ package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add ./SB.Infra/ package Microsoft.Extensions.Configuration
dotnet add ./SB.Infra/ package Microsoft.Extensions.Options.ConfigurationExtensions
dotnet add ./SB.Infra/ package X.PagedList
dotnet add ./SB.Infra/ package X.PagedList.Mvc.Core
```
### GIT
```bash
start . # OPENING FOLDER EXPLORER USING CLI

dotnet new gitignore
git init
git push --set-upstream origin main
git push --set-upstream origin main
git remote set-url stream https://gitlab.com/starbazaar/admin-panel.git
git remote add stream https://gitlab.com/starbazaar/webapp.git
git remote -v
origin  https://gitlab.com/m.ahsan.saifi/webapp.git (fetch)
origin  https://gitlab.com/m.ahsan.saifi/webapp.git (push)
stream  https://gitlab.com/starbazaar/webapp.git (fetch)
stream  https://gitlab.com/starbazaar/webapp.git (push)
dotnet new editorconfig
```

### DOCKER
```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker image ls
docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Asdf@1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
docker container ls
docker ps
# Below Command Run After SQL Container Runs (Keys are Case Insensitive & their alternatives are available)


dotnet ef database update -p SB.Infra -s SB.Api --connection "server=localhost;Database=SB;User Id=sa;password=Asdf@1234;TrustServerCertificate=true"
# This Command won't work b/c of Certificate & Swagger (Run using f5)
```
### MIGRATION
```bash
dotnet tool install --global dotnet-ef
dotnet tool list --global


dotnet ef database add MigrationName --project SB.Infra --startup-project SB.Api --connection "SERVER=127.0.0.1,1433;DATABASE=SB;USER=sa;PASSWORD=Asdf@1234;Encrypt=false"

# ADD
dotnet ef migrations add InitialCreate -p SB.Infra -s SB.Api
# REMOVE
dotnet ef migrations remove  -p SB.Infra -s SB.Api
# UPDATE
dotnet ef database update -p SB.Infra -s SB.Api --connection "Server=localhost;Database=SB;User Id=sa;Password=Asdf@1234;Encrypt=false"
# RUN
dotnet run --project SB.Api
```
### CURL COMMAND
- Undermentioned Commands only works with Bash
- Before Using that you have to Stop Https Middleware
- Running your app with http in Visual Studio
```bash
curl -X 'POST' 'http://localhost:5294/auth/register' -H 'accept: */*' -H 'Content-Type: App/json' -d '{   "firstName": "string", "lastName": "string", "email": "string", "password": "string" }'
curl -X 'POST' 'http://localhost:5294/auth/login' -H 'accept: */*' -H 'Content-Type: App/json' -d '{ "email": "string", "password": "string" }'
curl -X 'GET' 'http://localhost:5294/api/Dinners' -H 'accept: */*' -H 'Authorization: Bearer token.full.goeshere'
```