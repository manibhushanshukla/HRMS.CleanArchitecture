# HRMS.CleanArchitecture
# git init
# dotnet new gitignore
# git add .
# git branch -M master
# git remote add origin https://github.com/manibhushanshukla/HRMS.CleanArchitecture.git
# git push -u origin master
# dotnet new classlib --name HRMS.Domain
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.Domain/HRMS.Domain.csproj 
# dotnet new classlib --name HRMS.Application
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.Application/HRMS.Application.csproj
# dotnet new classlib --name HRMS.Infrastructure
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.Infrastructure/HRMS.Infrastructure.csproj
# dotnet new classlib --name HRMS.Persistence
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.Persistence/HRMS.Persistence.csproj
# dotnet new classlib --name HRMS.API
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.API/HRMS.API.csproj 
# dotnet new classlib --name HRMS.Identity
# dotnet sln HRMS.CleanArchitecture.sln add Infrastructure/HRMS.Identity/HRMS.Identity.csproj
# dotnet new classlib --name HRMS.Application.Test
# dotnet sln HRMS.CleanArchitecture.sln add HRMS.Application.Test/HRMS.Application.Test.csproj
# dotnet add package FluentValidation --version 11.5.2
# dotnet add package AutoMapper --version 12.0.1
# dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

# dotnet add package MediatR --version 12.0.1
# dotnet add package Microsoft.AspNetCore.Http --version 2.2.2
# dotnet add package Microsoft.EntityFrameworkCore
# dotnet add reference ../../Core/HRMS.Application/HRMS.Application.csproj
# dotnet add reference ../../Core/HRMS.Domain/HRMS.Domain.csproj
# dotnet add package Microsoft.Extensions.Configuration --version 7.0.0
# dotnet add package Microsoft.Extensions.Options --version 7.0.1
# dotnet add package SendGrid --version 9.28.1
# dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 7.0.5
# dotnet add package Microsoft.IdentityModel --version 7.0.0
# dotnet add package System.IdentityModel.Tokens.Jwt --version 6.30.1
# dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
# dotnet add package Newtonsoft.Json
# dotnet add package Microsoft.EntityFrameworkCore.Sqlite
# dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions
# dotnet add reference ../../Infrastructure/HRMS.Identity/HRMS.Identity.csproj
# dotnet add reference ../../Infrastructure/HRMS.Persistence/HRMS.Persistence.csproj
# dotnet add reference ../../Infrastructure/HRMS.Infrastructure/HRMS.Infrastructure.csproj
# dotnet add LAyered.API package Microsoft.EntityFrameworkCore.Design
# dotnet ef --startup-project ../../API/HRMS.API/ migrations add "Initial" -c LeaveManagementDbContext
# dotnet ef --startup-project ../../API/HRMS.API/ database update -c LeaveManagementDbContext
# dotnet ef --startup-project ../../API/HRMS.API/ migrations add "Initial" -c LeaveManagementIdentityDbContext  
# dotnet ef --startup-project ../../API/HRMS.API/ database update -c LeaveManagementIdentityDbContext  























