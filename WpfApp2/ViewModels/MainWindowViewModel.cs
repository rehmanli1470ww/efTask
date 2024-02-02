using ConsoleApp5.Contexts;
using ConsoleApp5.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Whatsapp.Commands;
using Whatsapp.Services;

namespace WpfApp2.ViewModels
{



    public class MainWindowViewModel : ServiceINotifyPropertyChanged
    {
        static bool check = true;
        static bool checkInserted = false;

        public ObservableCollection<object> datas { get => datas1; set { datas1 = value; OnPropertyChanged(); } }
        public ObservableCollection<string> Tables { get => tables; set { tables = value; OnPropertyChanged(); } }
        private MyDbContext context = new();
        private ObservableCollection<string> tables;

        private static int tempCount;
        private ObservableCollection<object> datas1;

        public ICommand GetCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand InsertCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddingNewItem { get; set; }
        public MainWindowViewModel()
        {
            startUp();
            GetCommand = new Command(ExecuteGetCommand, CanExecuteGetCommand);
            UpdateCommand = new Command(ExecuteUpdateCommand, CanExecuteUpdateCommand);
            InsertCommand = new Command(ExecuteInsertCommand, CanExecuteUInsertCommand);
            DeleteCommand = new Command(ExecuteDeleteCommand, CanExecuteDeleteCommand);
            AddingNewItem = new Command(ExecuteAddingNewItem);
        }

        private void ExecuteAddingNewItem(object arg)
        {
            checkInserted = false;
        }

        private bool CanExecuteDeleteCommand(object obj) =>
            ((DataGrid)((Grid)obj).FindName("DataGrid")).SelectedItem is not null
            && check
            && checkInserted;

        private void ExecuteDeleteCommand(object arg)
        {
            dynamic data = ((DataGrid)((Grid)arg).FindName("DataGrid")).SelectedItem;
            int Id = data.Id;
            //context.Find(id);
            var tablename = ((ComboBox)((Grid)arg).FindName("TableName")).SelectedValue;
            switch (tablename)
            {
                case "Author":
                    context?.Authors?.Remove(  context?.Authors?.First(b => b.Id == Id)!); break;
                case "Book":
                    context?.Books?.Remove(  context?.Books?.First(b => b.Id == Id)!); break;
                case "Category":
                    context?.Categories?.Remove(  context?.Categories?.First(b => b.Id == Id)!); break;
                case "Department":
                    context?.Departments?.Remove(  context?.Departments?.First(b => b.Id == Id)!); break;
                case "Facultie":
                    context?.Faculties?.Remove(  context?.Faculties?.First(b => b.Id == Id)!); break;
                case "Group":
                    context?.Groups?.Remove(  context?.Groups?.First(b => b.Id == Id)!); break;
                case "Lib":
                    context?.Libs?.Remove(  context?.Libs?.First(b => b.Id == Id)!); break;
                case "Press":
                    context?.Presses?.Remove(  context?.Presses?.First(b => b.Id == Id)!); break;
                case "S_Card":
                    context?.S_Cards?.Remove(  context?.S_Cards?.First(b => b.Id == Id)!); break;
                case "T_Card":
                    context?.T_Cards?.Remove(  context?.T_Cards?.First(b => b.Id == Id)!); break;
                case "Teacher":
                    context?.Teachers?.Remove(  context?.Teachers?.First(b => b.Id == Id)!); break;
                case "Theme":
                    context?.Themes?.Remove(  context?.Themes?.First(b => b.Id == Id)!); break;
                case "Student":
                    context?.Students?.Remove(  context?.Students?.First(b => b.Id == Id)!); break;
                default:
                    break;
            }
            context?.SaveChanges();
            ExecuteGetCommand(arg);

        }

        private bool CanExecuteUInsertCommand(object obj) =>
           datas?.Count > tempCount;


        private void ExecuteInsertCommand(object obj)
        {
            //TakeLast(datas.Count - tempCount)
            //var adds = datas.OfType<Author>().TakeLast(datas.Count-tempCount);
            //  context.AddRange(data);
            //  context.SaveChangesAsync();
            var tablename = ((ComboBox)((Grid)obj).FindName("TableName")).SelectedValue;


            switch (tablename)
            {
                case "Author":
                    context?.Authors?.AddRange(datas.OfType<Author>().TakeLast(datas.Count - tempCount));
                    break;
                case "Book":
                    context?.Books?.AddRange(datas.OfType<Book>().TakeLast(datas.Count - tempCount)); break;
                case "Category":
                    context?.Categories?.AddRange(datas.OfType<Category>().TakeLast(datas.Count - tempCount)); break;
                case "Department":
                    context?.Departments?.AddRange(datas.OfType<Department>().TakeLast(datas.Count - tempCount)); break;
                case "Facultie":
                    context?.Faculties?.AddRange(datas.OfType<Facultie>().TakeLast(datas.Count - tempCount)); break;
                case "Group":
                    context?.Groups?.AddRange(datas.OfType<Group>().TakeLast(datas.Count - tempCount)); break;
                case "Lib":
                    context?.Libs?.AddRange(datas.OfType<Lib>().TakeLast(datas.Count - tempCount)); break;
                case "Press":
                    context?.Presses?.AddRange(datas.OfType<Press>().TakeLast(datas.Count - tempCount)); break;
                case "S_Card":
                    context?.S_Cards?.AddRange(datas.OfType<S_Card>().TakeLast(datas.Count - tempCount)); break;
                case "T_Card":
                    context?.T_Cards?.AddRange(datas.OfType<T_Card>().TakeLast(datas.Count - tempCount)); break;
                case "Teacher":
                    context?.Teachers?.AddRange(datas.OfType<Teacher>().TakeLast(datas.Count - tempCount)); break;
                case "Theme":
                    context?.Themes?.AddRange(datas.OfType<Theme>().TakeLast(datas.Count - tempCount)); break;
                case "Student":
                    context?.Students?.AddRange(datas.OfType<Student>().TakeLast(datas.Count - tempCount)); break;
                default:
                    break;
            }


            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                ((Label)((Grid)obj).FindName("errorCode")).Content = e.Message;
                ((Label)((Grid)obj).FindName("errorCode")).Visibility = System.Windows.Visibility.Visible;
                return;
            }
           ((Label)((Grid)obj).FindName("errorCode")).Visibility = System.Windows.Visibility.Hidden;
            checkInserted = true;
            tempCount = datas.Count;
            ExecuteGetCommand(obj);
        }

        private bool CanExecuteUpdateCommand(object obj) =>
            context.ChangeTracker.HasChanges();

        private void ExecuteUpdateCommand(object arg)
        {
             context.SaveChanges();
             ExecuteGetCommand(arg);
        }

        private bool CanExecuteGetCommand(object obj) =>
             ((ComboBox)((Grid)obj).FindName("TableName")).SelectedIndex != -1;
        private void ExecuteGetCommand(object obj)
        {
            check = true;
            var tablename = ((ComboBox)((Grid)obj).FindName("TableName")).SelectedValue;
            datas = new();

            switch (tablename)
            {
                case "Author":
                    datas = new(context.Authors.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Author());
                        check = false;
                    }
                    break;
                case "Book":
                    datas = new(context.Books.ToList());
                    if (datas.Count == 0)
                        datas.Add(new Book());
                    break;
                case "Category":
                    datas = new(context.Categories.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Category());
                        check = false;
                    }
                    break;
                case "Department":
                    datas = new(context.Departments.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Department());
                        check = false;
                    }
                    break;
                case "Facultie":
                    datas = new(context.Faculties.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Facultie());
                        check = false;
                    }
                    break;
                case "Group":
                    datas = new(context.Groups.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Group());
                        check = false;
                    }
                    break;
                case "Lib":
                    datas = new(context.Libs.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Lib());
                        check = false;
                    }
                    break;
                case "Press":
                    datas = new(context.Presses.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Press());
                        check = false;
                    }
                    break;
                case "S_Card":
                    datas = new(context.S_Cards.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new S_Card());
                        check = false;
                    }
                    break;
                case "T_Card":
                    datas = new(context.T_Cards.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new T_Card());
                        check = false;
                    }
                    break;
                case "Teacher":
                    datas = new(context.Teachers.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Teacher());
                        check = false;
                    }
                    break;
                case "Theme":
                    datas = new(context.Themes.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Theme());
                        check = false;
                    }
                    break;
                case "Student":
                    datas = new(context.Students.ToList());
                    if (datas.Count == 0)
                    {
                        datas.Add(new Student());
                        check = false;
                    }
                    break;
                default:
                    break;
            }
            if (check)
                tempCount = datas.Count;
            else
                tempCount = 0;


        }


        private void startUp()
        {
            Tables = new(context.Model.GetEntityTypes().Select(e => e.Name.Substring(e.Name.LastIndexOf(".") + 1)).ToList());



        }
    }

}
