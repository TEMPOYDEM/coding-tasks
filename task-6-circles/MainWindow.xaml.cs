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

namespace task_6_circles
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RadioCircle.IsChecked.Value)
            {
                
                try
                {
                    //создаем новый объект класса круг
                    Circle myCircle = new Circle();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для круга
                    myCircle.SetRadius(Double.Parse(TextRadius.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для кругов
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Площадь: " + myCircle.Area(); //здесь получаем площадь созданного объекта круга
                    StackCircles.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
            else if (RadioCylinder.IsChecked.Value)
            {

                try
                {
                    //создаем новый объект класса круг
                    Cylinder myCylinder = new Cylinder();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для круга
                    myCylinder.SetRadius(Double.Parse(TextRadius.Text));
                    myCylinder.SetHeight(Double.Parse(TextHeight.Text));
                    //создаем новый блок с текстом, который отправится в StackPanel для кругов
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объем: " + myCylinder.Volume(); //здесь получаем площадь созданного объекта круга
                    StackCylinders.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                    HeightRadius.Foreground = Brushes.Red;
                }
            }
            else if (RadioSphere.IsChecked.Value)
            {

                try
                {
                    //создаем новый объект класса круг
                    Sphere mySphere = new Sphere();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для круга
                    mySphere.SetRadius(Double.Parse(TextRadius.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для кругов
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объем: " + mySphere.Volume(); //здесь получаем площадь созданного объекта круга
                    StackSpheres.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
        }

        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(LabelRadius.Foreground!=Brushes.Black)
                LabelRadius.Foreground = Brushes.Black;
        }
    }
}
