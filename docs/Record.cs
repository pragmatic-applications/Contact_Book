//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A Contact Book App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-25
// Stop: 22:00
//=================================================================

// Put Create and Update form buttons in grid for better layout management.
// Current: Implemented BlazorCard to check that I could do it. Now that I have done it, I have reverted to using plain (HTML and CSS card class) because pragmatic programming is best.
// Todo: Finish Card styles so I can commit to GitHub... ExtraContent...

// Todo: test and update... BIS related features...
// Todo: set time to add feature for HTML Table with all the various elements of a table such as TR...

// Replace Lib_Blazor_UI with Lib_Blazor_Repeater, Lib_Blazor_Uploader and MAK.Lib.BlazorUI to check if these will be added to GitHub.

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
