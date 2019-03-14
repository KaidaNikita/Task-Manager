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
using System.Diagnostics;
using System.Collections;
using System.Collections.ObjectModel;

namespace DispetcherZadach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pr = Process.GetProcesses();
            ObservableCollection<Proc> PR2 = new ObservableCollection<Proc>();
            foreach (var proc in pr)
            {
                ListViewItem lstwi = new ListViewItem();
                string name = "";
                string id = "";
                string priority = "";
                if (prior_ch.IsChecked == true)
                {
                    priority = proc.BasePriority.ToString();
                }
                if (id_ch.IsChecked == true)
                {
                    id = proc.Id.ToString();
                }
                if (name_ch.IsChecked == true)
                {
                    name =proc.ProcessName;
                }
                Proc PR = new Proc
                {
                    Id = id,
                    Name = name,
                    Priority = priority
                };
                PR2.Add(PR);
            }
            procs.ItemsSource = PR2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int ind = procs.SelectedIndex;
                Proc proc = (Proc)procs.Items[ind];
                var pr = Process.GetProcessesByName(proc.Name)[0];
                pr.Kill();
            }
            catch (Exception){}
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           Start start=new Start();
            start.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
