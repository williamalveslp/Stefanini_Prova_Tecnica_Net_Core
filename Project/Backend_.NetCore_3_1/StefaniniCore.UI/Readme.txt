

	** PACKAGES REQUIRED TO ENTITY FRAMEWORK CORE WITH SQL SERVER **
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer (on Context project, and project to add DI from DbContext)
- Microsoft.EntityFrameworkCore.SqlServer.Design
- Microsoft.EnityFrameworkCore.Tools (Migrations, Scaffold)

	**	ADD SCAFFOLD ENTITY CORE **
Commands
Scaffold-DbContext "<CONNECTION_STRING>" Microsoft.EntityFrameworkCore.SqlServer

	** ADD LAZY LOAD TO ENTITY CORE **
- Microsoft.EntityFrameworkCore.Proxies
	
For Query logs on Console:
- Microsoft.Extensions.Logging.Console

	** SPECFLOW **
- Install the Specflow extension for Visual Studio.

- Some test Provider (xUnit/MSTest/NUnit...)

MSTest.TestFramework
Specflow
Specflow.MsTest

	** HEALTH CHECK UI **
- AspNetCore.HealthChecks.UI 
- AspnetCore.HealthChecks.UI.Client
- AspNetCore.HealthChecks.SqlServer 
- Microsoft.ApplicationInsights.AspNetCore

Microsoft video recommends:
- Microsoft.Extensions.Diagnostics.HealthChecks
- Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions
- Microsoft.Extensions.Diagnostics.HealthChecks.EntityFramework
- Microsoft.AspNetCore.Diagnostics.HealthChecks 
- AspNetCore.HealthChecks.UI.InMemory.Storage
- AspNetCore.HealthChecks.Uris
- AspNetCore.HealthChecks.Publisher.ApplicationInsights
