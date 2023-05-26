using _31_05gg.Classes;
using Microsoft.Win32;
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

namespace _31_05gg
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
            WindowRegistration windowAdd = new WindowRegistration();
            windowAdd.ShowDialog();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            DtgListRezult.ItemsSource = null;
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ((bool)openFileDialog.ShowDialog())
            {
                // получаем выбранный файл
                ClassHelpers.fileName = openFileDialog.FileName;
                ClassHelpers.ReadListFromFile(ClassHelpers.fileName);
                //ClassHelpers.ReadListFromFile(@"ListSports.txt");
            }
            else
                return;
            DtgListRezult.ItemsSource = ClassHelpers.resultsing.ToList();
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if ((bool)saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                ClassHelpers.SaveListToFile(file);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var resMessage = MessageBox.Show("Удалить запись?", "Подтверждение",
               MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resMessage == MessageBoxResult.Yes)
            {
                int ind = DtgListRezult.SelectedIndex;
                ClassHelpers.resultsing.RemoveAt(ind);
                DtgListRezult.ItemsSource = ClassHelpers.resultsing.ToList();
                ClassHelpers.SaveListToFile(ClassHelpers.fileName);
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {//поиск по ФИО
            DtgListRezult.ItemsSource = ClassHelpers.resultsing.Where(x => x.Fio.Contains(TxtSearch.Text)).ToList();
        }


        private void Combine_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int namber = ClassHelpers.namberses[Combine.SelectedIndex];
            if (Combine.SelectedIndex != 0)
                DtgListRezult.ItemsSource = ClassHelpers.resultsing.Where(x => x.Nambers == namber).ToList();
            else
                DtgListRezult.ItemsSource = ClassHelpers.namberses;
        }

        public void rezult_Click(object sender, RoutedEventArgs e)
        {
           
            
            foreach (ClassSports res in ClassHelpers.resultsing)
            {
                bool flag = true;
                if (res.Result1 < res.Result2 || res.Result2 < res.Result3 || res.Result3 < res.Result4 || res.Result4 < res.Result5)
                {
                    flag = false;
                }
                if (flag)
                {
                    ClassHelpers.Bestys.Add(res.Fio);

                }
            }
            Best windowAdd = new Best();
            windowAdd.ShowDialog();

        }
        private void update_Click(object sender, RoutedEventArgs e)
        {
            DtgListRezult.ItemsSource = ClassHelpers.resultsing.ToList();
        }
    }
}
