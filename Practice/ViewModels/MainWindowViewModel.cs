using Practice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MenuGroup> Menu { get; set; }

        public MainWindowViewModel()
        {
            Menu = new ObservableCollection<MenuGroup>(new[]
            {
                    new MenuGroup{ Id = 0, Title = "Главная", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Все задания" }
                        }
                    },
                    new MenuGroup{ Id = 1, Title = "Задание 1", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 2, Title = "Задание 2", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 3, Title = "Задание 3", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 4, Title = "Задание 4", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 4", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 5, Title = "Задание 5", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 6, Title = "Задание 6", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 7, Title = "Задание 7", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 8, Title = "Задание 8", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 9, Title = "Задание 9", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    },
                    new MenuGroup{ Id = 10, Title = "Задание 10", MenuItems =
                        new ObservableCollection<MenuItem>{
                            new MenuItem { Id=1, Title="Задача 1", TargetType = typeof(Pages.Task1.Task1) }
                        }
                    }
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
