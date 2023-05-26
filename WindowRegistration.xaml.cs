using _31_05gg.Classes;
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
using System.Windows.Shapes;
using _31_05gg.Classes;

namespace _31_05gg
{
    /// <summary>
    /// Логика взаимодействия для WindowRegistration.xaml
    /// </summary>
    public partial class WindowRegistration : Window
    {
        int mode;
        public WindowRegistration()
        {
            InitializeComponent();
            mode = 0;
        }
        public WindowRegistration(ClassSports bro)
        {
            InitializeComponent();
            TxbName.Text = bro.Fio;
            TxbCount.Text = bro.Nambers.ToString();
            TxbPrice.Text = bro.Result1.ToString();
            TxbMonth.Text = bro.Result2.ToString();
            TxbMonth1.Text = bro.Result3.ToString();
            TxbMonth2.Text = bro.Result4.ToString();
            TxbMonth3.Text = bro.Result5.ToString();
            mode = 1;
            Addtomain.Content = "Сохранить";
        }

        private void Addtomain_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(TxbCount.Text) < 0)
            {
                MessageBox.Show("Результат не может быть отрицательным!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                TxbCount.Clear();
                TxbCount.Focus();
                return;
            }
            if (mode == 0)
            {//добавление данных
                try
                {
                    ClassSports bros = new ClassSports()
                    {
                        Fio = TxbName.Text,
                        Nambers = int.Parse(TxbCount.Text),
                        Result1 = double.Parse(TxbPrice.Text),
                        Result2 = double.Parse(TxbMonth.Text),
                        Result3 = double.Parse(TxbMonth1.Text),
                        Result4 = double.Parse(TxbMonth2.Text),
                        Result5 = double.Parse(TxbMonth3.Text)

                    };

                    ClassHelpers.resultsing.Add(bros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }
            //редактирование
            else
            {
                try
                {
                    for (int i = 0; i < ClassHelpers.resultsing.Count; i++)
                    {
                        if (ClassHelpers.resultsing[i].Fio == TxbName.Text)
                        {
                            ClassHelpers.resultsing[i].Nambers = int.Parse(TxbCount.Text);
                            ClassHelpers.resultsing[i].Result1 = double.Parse(TxbPrice.Text);
                            ClassHelpers.resultsing[i].Result2 = double.Parse(TxbMonth.Text);
                            ClassHelpers.resultsing[i].Result3 = double.Parse(TxbMonth1.Text);
                            ClassHelpers.resultsing[i].Result4 = double.Parse(TxbMonth2.Text);
                            ClassHelpers.resultsing[i].Result5 = double.Parse(TxbMonth3.Text);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }


            }
            ClassHelpers.SaveListToFile(ClassHelpers.fileName);
            this.Close();
        }
    }
}
