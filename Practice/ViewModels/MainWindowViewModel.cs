using Practice.Models;
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
            Menu = new List<MenuGroup>()
            {
                new MenuGroup{ Title = "Главная", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Все задания" }
                    }
                },
                new MenuGroup{ Title = "Занятие 1", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson1.Example1) }
                    }
                },
                new MenuGroup{ Title = "Занятие 2", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson2.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson2.Example2) },
                        new MenuItem { Title="Пример 3", TargetType = typeof(Pages.Lesson2.Example3) },
                        new MenuItem { Title="Пример 4", TargetType = typeof(Pages.Lesson2.Example4) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson2.FinalTask) },
                    }
                },
                new MenuGroup{ Title = "Занятие 3", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson3.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson3.Example2) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson3.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson3.FinalTask2) }
                    }
                },
                new MenuGroup{ Title = "Занятие 4", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson4.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson4.Example2) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson4.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson4.FinalTask2) },
                        new MenuItem { Title="Задание 3", TargetType = typeof(Pages.Lesson4.FinalTask3) },
                        new MenuItem { Title="Задание 4", TargetType = typeof(Pages.Lesson4.FinalTask4) },
                    }
                },
                new MenuGroup{ Title = "Занятие 5", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson5.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson5.Example2) },
                        new MenuItem { Title="Пример 3", TargetType = typeof(Pages.Lesson5.Example3) },
                        new MenuItem { Title="Пример 4", TargetType = typeof(Pages.Lesson5.Example4) },
                        new MenuItem { Title="Пример 5", TargetType = typeof(Pages.Lesson5.Example5) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson5.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson5.FinalTask2) },
                    }
                },
                new MenuGroup{ Title = "Занятие 6", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson6.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson6.Example2) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson6.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson6.FinalTask2) },
                    }
                },
                new MenuGroup{ Title = "Занятие 7", MenuItems =
                    new List<MenuItem>{
                        //Ну тут явных примеров нет
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson7.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson7.FinalTask2) },
                        new MenuItem { Title="Задание 3", TargetType = typeof(Pages.Lesson7.FinalTask3) },
                    }
                },
                new MenuGroup{ Title = "Занятие 8", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson8.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson8.Example2) },
                        new MenuItem { Title="Пример 3", TargetType = typeof(Pages.Lesson8.Example3) },
                        new MenuItem { Title="Пример 4", TargetType = typeof(Pages.Lesson8.Example4) },
                        new MenuItem { Title="Пример 5", TargetType = typeof(Pages.Lesson8.Example5) },
                        new MenuItem { Title="Пример 6", TargetType = typeof(Pages.Lesson8.Example6) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson8.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.Lesson8.FinalTask2) },
                    }
                },
                new MenuGroup{ Title = "Занятие 9", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Пример 1", TargetType = typeof(Pages.Lesson9.Example1) },
                        new MenuItem { Title="Пример 2", TargetType = typeof(Pages.Lesson9.Example2) },
                        new MenuItem { Title="Пример 3", TargetType = typeof(Pages.Lesson9.Example3) },
                        new MenuItem { Title="Пример 4", TargetType = typeof(Pages.Lesson9.Example4) },
                        new MenuItem { Title="Пример 5", TargetType = typeof(Pages.Lesson9.Example5) },
                        new MenuItem { Title="Пример 6", TargetType = typeof(Pages.Lesson9.Example6) },
                        new MenuItem { Title="Пример 7", TargetType = typeof(Pages.Lesson9.Example7) },
                        new MenuItem { Title="Пример 8", TargetType = typeof(Pages.Lesson9.Example8) },
                        new MenuItem { Title="Пример 9", TargetType = typeof(Pages.Lesson9.Example9) },
                        new MenuItem { Title="Пример 10", TargetType = typeof(Pages.Lesson9.Example10) },
                        new MenuItem { Title="Пример 11", TargetType = typeof(Pages.Lesson9.Example11) },
                        new MenuItem { Title="Пример 12", TargetType = typeof(Pages.Lesson9.Example12) },
                        new MenuItem { Title="Пример 13", TargetType = typeof(Pages.Lesson9.Example13) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.Lesson9.FinalTask1) },
                    }
                },
                new MenuGroup{ Title = "Занятие X", MenuItems =
                    new List<MenuItem>{
                        new MenuItem { Title="Примеры", TargetType = typeof(Pages.LessonX.Examples) },
                        new MenuItem { Title="Задание 1", TargetType = typeof(Pages.LessonX.FinalTask1) },
                        new MenuItem { Title="Задание 2", TargetType = typeof(Pages.LessonX.FinalTask2) },
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
