using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Ink;
using System.Collections.ObjectModel;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Task> tasks;
        List<Task> activeTasks;
        List<Task> completTasks;
        public MainWindow()
        {
            InitializeComponent();
            tasks = new List<Task>() { };
            Update();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "" || text.Text == null)
            { }
            tasks.Add(new Task(text.Text, Status.Active));
            Update();
        }
        private void list1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (list1.SelectedItem == null) return;
            var b = tasks.FindIndex(u => u == list1.SelectedItem);
            tasks[b].status = Status.Completed;
            Update();
        }
        public void Update()
        {
            activeTasks = tasks.Where(u => u.status == Status.Active).ToList();
            completTasks = tasks.Where(u => u.status == Status.Completed).ToList();
            list1.ItemsSource = activeTasks;
            list2.ItemsSource = completTasks;
        }
        private void list2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (list2.SelectedItem == null) return;
            foreach(var note in list2.SelectedItems)
            {
                tasks.Remove((Task)note);
            }
            Update();
        }
    }
}
