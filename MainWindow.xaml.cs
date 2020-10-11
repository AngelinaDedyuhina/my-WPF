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
using System.IO;


namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string writePath1 = @"C:\Users\USER\source\repos\WpfApp7\text\new.txt";
            //string writePath2 = @"C:\Users\USER\source\repos\WpfApp7\text\new.doc";
            string text = TB_text.Text;
            if (RB_TXT.IsChecked == true)

            {
                try
                {
                    FileStream writePath1 = new FileStream("new.txt", FileMode.Open);
                    using (StreamWriter sw = new StreamWriter(writePath1, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                    lB_v.Content = "Запись сохранена в документ. Путь к документу: " + System.Environment.CurrentDirectory;
                }
                catch
                {
                    lB_v.Content = "Невозможно сохранить запись";
                }
            }
            else if (RB_DOC.IsChecked == true)
            {
                try
                {    FileStream writePath2 = new FileStream("new.doc", FileMode.Open);
                    using (StreamWriter sw = new StreamWriter(writePath2, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                    lB_v.Content = "Запись сохранена в документ. Путь к документу: " + System.Environment.CurrentDirectory;
                }
                catch
                {
                    lB_v.Content = "Невозможно сохранить запись";
                }
            }
            else lB_v.Content = "Невозможно сохранить запись";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TB_text.Text = "";
            RB_TXT.IsChecked = false;
            RB_DOC.IsChecked = false;
            lB_v.Content = "";
        }
    }
}
