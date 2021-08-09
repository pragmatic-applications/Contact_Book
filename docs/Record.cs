//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A Contact Book App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-09
// Stop: 17:00
//=================================================================

// Using NuGet Lib_Generic_Crud_Interface Add Lib_Database and Lib_Repository Remove redundant interfaces

//==========================================================================
// Migrations S (2021-08-09)
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//
// CLI
// dotnet ef migrations add InitialMigration
// dotnet ef database update
//
// -------------------------------------------------------------------------
//
// PMC
// ApplicationDbContext (Current App)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext
// Update-Database -Context ApplicationDbContext
//
// ApplicationDbContext (Web_Api & Blazor_Server)
// Add-Migration ApplicationDbContext_Initial -Context ApplicationDbContext -OutputDir Database/Migrations/ApplicationDbContextMigrations
// Update-Database -Context ApplicationDbContext
//
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Migrations E
//==========================================================================

/*



//*/
