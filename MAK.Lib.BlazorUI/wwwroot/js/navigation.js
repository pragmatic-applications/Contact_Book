
(function()
{
  "use strict";

  function ngOnInit()
  {
    onHandleNavigationToggleEvents(document.getElementById("ToggleSidebar"));
    onHandleNavigationToggleEvents(document.getElementById("ToggleSmallScreenMenu"));

    onHandleNavigationCloseEvents(document.getElementById("sidebar"));
    onHandleNavigationCloseEvents(document.getElementById("SmallScreenMenu"));
  }
  ngOnInit();

  // === Navigation S ===
  function onHandleNavigationCloseEvents(element)
  {
    if(element)
    {
      element.addEventListener('click', () =>
      {
        element.classList.toggle('active');
      }, false);
    }
  }

  function onHandleNavigationToggleEvents(element)
  {
    if(element)
    {
      element.addEventListener('click', () =>
      {
        if(element.id === "ToggleSidebar")
        {
          document.getElementById("sidebar").classList.toggle('active');
        }
        else if(element.id === "ToggleSmallScreenMenu")
        {
          document.getElementById("SmallScreenMenu").classList.toggle('active');
        }
      }, false);
    }
  }
  // === Navigation E ===

}());
