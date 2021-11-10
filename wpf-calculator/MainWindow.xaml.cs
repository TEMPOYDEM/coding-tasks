using System;
using System.Collections.Generic;
using System.Data;
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

namespace wpf_calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Buttons.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick ;
                }
            }
        }
        private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            try
            {
                string textButton = ((Button)e.OriginalSource).Content.ToString();
                if (textButton == "C")
                {
                    text.Clear();
                }
                else if (textButton == "x")
                {
                    if (text.Text.EndsWith(".") == true || text.Text.Equals("") || text.Text.EndsWith("/") == true || text.Text.EndsWith("*") == true || text.Text.EndsWith("-") == true || text.Text.EndsWith("+") == true || text.Text.EndsWith("(") == true || text.Text.EndsWith(")") == true)
                    {
                    }
                    else
                    {
                        text.Text += '*';
                    }
                }
                else if (textButton == "/")
                {
                    if (text.Text.EndsWith(".") == true || text.Text.Equals("") || text.Text.EndsWith("/") == true || text.Text.EndsWith("*") == true || text.Text.EndsWith("-") == true || text.Text.EndsWith("+") == true || text.Text.EndsWith("(") == true || text.Text.EndsWith(")") == true)
                    {
                    }
                    else
                    {
                        text.Text += '/';
                    }
                }
                else if (textButton == "=")
                {
                    text.Text = new DataTable().Compute(text.Text, null).ToString();
                }
                else if (textButton == ".")
                {
                    if (text.Text.EndsWith(".") == true || text.Text.Equals("") || text.Text.EndsWith("/") == true || text.Text.EndsWith("*") == true || text.Text.EndsWith("-") == true || text.Text.EndsWith("+") == true || text.Text.EndsWith("(") == true || text.Text.EndsWith(")") == true)
                    {
                    }
                    else
                    {
                        string lastPiece = text.Text.Split(new char[] { '+', '-', '*', '/' })[text.Text.Split(new char[] { '+', '-', '*', '/' }).Count() - 1];
                        if (!lastPiece.Contains('.')) text.Text += ".";

                        lastPiece = text.Text.Split(new char[] { '+', '-', '*', '/' })[text.Text.Split(new char[] { '+', '-', '*', '/' }).Count() - 1];

                        if (!lastPiece.Contains('.')) text.Text += ".";

                    }
                }
                else text.Text += textButton;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
