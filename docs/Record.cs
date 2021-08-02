//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A To Do App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-02
// Stop: 14:00
//=================================================================

// Add to GitHub...

// Find: Lib_Core, Lib_Core_Interface

// Todo: Separate Contact_Book from Item

//==========================================================================
// Migrations S (2021-08-01)
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

/*//
public static List<ContactEntityCategory> Categories
{
    get => new()
    {
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Unspecified)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Owner)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Family)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Friend)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Home)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Work)
        },
        new ContactEntityCategory
        {
            Id = ++idCount,
            Name = Enum.GetName(ContactCategoryType.Business)
        }
    };
}
//*/

/*

T https://localhost:5001/Default.png 404

551/api/ItemCategories

//*/
