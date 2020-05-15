using Practice.Pages;

using System;
using System.Collections.Generic;

namespace Practice.Models
{
    public class MenuGroup
    {
        public MenuGroup()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            TargetType = typeof(MainPage);
        }

        public string Title { get; set; }
        public string Description { get; set; }

        public Type TargetType { get; set; }
    }
}
