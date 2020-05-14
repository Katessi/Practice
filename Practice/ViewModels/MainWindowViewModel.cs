﻿using Practice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<MenuGroup> Menu { get; set; }
        public List<MenuItem> MenuWithoutGroup { get; set; }

        public MainWindowViewModel()
        {
            //TODO: Может переименовать Task на Lesson
            Menu = new List<MenuGroup>()
            {
                new MenuGroup{ Title = "Главная", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Все задания" }
                    }
                },
                new MenuGroup{ Title = "Задание 1", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Task1.Example1) }
                    }
                },
                new MenuGroup{ Title = "Задание 2", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Task2.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Task2.Example2) },
                        new MenuItem { Title="Пример 3", TargetType = typeof(Pages.Task2.Example3) },
                        new MenuItem { Title="Пример 4", TargetType = typeof(Pages.Task2.Example4) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Task2.FinalTask) },
                    }
                },
                new MenuGroup{ Title = "Задание 3", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Task3.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Task3.Example2) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Task3.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Task3.FinalTask2) }
                    }
                },
                new MenuGroup{ Title = "Задание 4", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Task3.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Task3.Example1) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Task3.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Task3.FinalTask1) },
                        new MenuItem { Title="Задание 3", TargetType = typeof(Pages.Task3.FinalTask1) },
                        new MenuItem { Title="Задание 4", TargetType = typeof(Pages.Task3.FinalTask1) },
                    }
                }
            };

            foreach (var item in Menu)
            {
                if (MenuWithoutGroup == null)
                    MenuWithoutGroup = new List<MenuItem>();

                MenuWithoutGroup.AddRange(item.MenuItems);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
