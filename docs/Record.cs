//=================================================================
// Solution: Contact_Book
//=================================================================
// Programmer: Maurice Antonio Kelly @MAKMaurice
// Description: A Contact Book App with undo, redo and database CRUD features.
// ASP.NET Core 5.0
// Date: 2021-08-28
// Stop: 16:00
//=================================================================

// Todo; add Create form to the Grid Card... Start work on MicroTech...

// Remove AdminItemCard and other templated components; replacing these with plain HTML and CSS (The components were implemented as an exercise to prove my skills).

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

   it: Microsoft.AspNetCore.Components.WebAssembly.Rendering.WebAssemblyRenderer[100]
      Unhandled exception rendering component: Object reference not set to an instance of an object.
System.NullReferenceException: Object reference not set to an instance of an object.
   at Domain.ItemDataBase.get_IsDone() in X:\Contact_Book\Lib_Contact_Book\Contact_Book\Domain\ItemDataBase.cs:line 14
   at Lib_Contact_Book.Contact_Book.Admin.AdminIndexContainer.<>c__DisplayClass8_0.<BuildRenderTree>b__3(RenderTreeBuilder __builder4) in X:\Contact_Book\Lib_Contact_Book\Contact_Book\Admin\AdminIndexContainer.razor:line 23
   at Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.AddContent(Int32 sequence, RenderFragment fragment)
   at Microsoft.AspNetCore.Components.CascadingValue`1[[System.Boolean, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]].Render(RenderTreeBuilder builder)
   at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.RenderInExistingBatch(RenderQueueEntry renderQueueEntry)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()

//*/
