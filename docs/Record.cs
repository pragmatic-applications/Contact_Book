//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A Contact Book App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-26
// Stop: 13:00
//=================================================================

//

//==========================================================================
// Migrations S (2021-08-22)
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

// To style...
<CardHeader TEntity="ContactEntityDto">
    Header Text
</CardHeader>
<CardFooter TEntity="ContactEntityDto">
    (An ID: @this.EntityCascadingParameter.Id)
</CardFooter>

//*/
