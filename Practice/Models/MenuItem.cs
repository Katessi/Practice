using Practice.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class MenuGroup
    {
        public MenuGroup()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }

        public ObservableCollection<MenuItem> MenuItems { get; set; }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            TargetType = typeof(MainPage);
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
