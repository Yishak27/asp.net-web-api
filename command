dotnet tool install --global dotnet-ef

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore