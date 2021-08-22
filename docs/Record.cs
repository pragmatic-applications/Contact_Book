//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A Contact Book App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-22
// Stop: 23:00
//=================================================================

// Todo: Finish Card styles so I can commit to GitHub... ExtraContent...

// Todo: test and update... BIS related features...
// Todo: set time to add feature for HTML Table with all the various elements of a table such as TR...

// Add the Lib_Blazor_UI project to this solution while I am working on Card, Grid and related features. Second commit because Lib_Blazor_UI was not included in the commit.

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
