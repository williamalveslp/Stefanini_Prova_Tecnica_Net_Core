

	** PACKAGES REQUIRED TO ENTITY FRAMEWORK CORE WITH SQL SERVER **
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.SqlServer.Design
- Microsoft.EnityFrameworkCore.Tools (Migrations, Scaffold)

	**	ADD SCAFFOLD ENTITY CORE **
Commands
Scaffold-DbContext "<CONNECTION_STRING>" Microsoft.EntityFrameworkCore.SqlServer

	** ADD LAZY LOAD TO ENTITY CORE **
- Microsoft.EntityFrameworkCore.Proxies
	
For Query logs on Console:
- Microsoft.Extensions.Logging.Console
