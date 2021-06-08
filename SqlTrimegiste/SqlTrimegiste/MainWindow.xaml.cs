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

namespace SqlTrimegiste
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_Click(object sender,RoutedEventArgs e)
        {
            UIElement uIElement = (UIElement)sender;
            MessageBox.Show("Title of my control is : " + GetNewName(uIElement), "AttachedProperty");
        }

        #region AP
        public static string GetNewName(DependencyObject obj)
        {
            return (string)obj.GetValue(NewNameProperty);
        }

        public static void SetNewName(DependencyObject obj, string value)
        {
            obj.SetValue(NewNameProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewNameProperty =
            DependencyProperty.RegisterAttached("NewName", typeof(string), typeof(MainWindow), new PropertyMetadata(""));

        #endregion
    }
}
