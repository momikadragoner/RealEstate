# RealEstate

### .NET Core 3.1

Install-Package Microsoft.EntityFrameworkCore -Version 5.0.13

Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.13

Install-Package Pomelo.EntityFrameworkCore.MySql -Version 5.0.3

Install-Package Pomelo.EntityFrameworkCore.MySql.Design -Version 1.1.2

Install-Package Newtonsoft.Json -Version 13.0.1

Scaffold-DbContext "Server=localhost;User=root;Password=;Database=NAMEODDATABASE" "Pomelo.EntityFrameworkCore.MySql" -OutputDir Models
