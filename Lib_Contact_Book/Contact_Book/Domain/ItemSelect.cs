using System.Collections.Generic;

using Interfaces;

namespace Domain
{
    public class ItemSelect : ISelect
    {
        public List<string> Options => new List<string>
        {
          { "Id" },
          { "Id DESC" },
          { "ContactName" },
          { "ContactName DESC" },
          { "Email" },
          { "Email DESC" },
          { "IsChecked" },
          { "IsChecked DESC" }
        };
        public List<string> OptionsDisplay => new List<string>
        {
          { "Id" },
          { "Id DESC" },
          { "Contact Name" },
          { "Contact Name DESC" },
          { "Email" },
          { "Email DESC" },
          { "Check" },
          { "Check DESC" }
        };
    }
}

