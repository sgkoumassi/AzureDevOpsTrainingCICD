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

namespace SqlTrimegiste.UserControls
{
    /// <summary>
    /// Logique d'interaction pour DpControl.xaml
    /// </summary>
    public partial class DpControl : UserControl
    {
        public DpControl()
        {
            InitializeComponent();
        }
        #region DP
        public static readonly DependencyProperty SetTextProperety = DependencyProperty
            .Register("SetText", typeof(string), typeof(DpControl), new PropertyMetadata(""));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperety); }
            set { SetValue(SetTextProperety, value); }
        }

        private static void OnSetTextChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)
        {
            DpControl dpControl1 = d as DpControl;
            dpControl1.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            txtBlock1.Text = e.NewValue.ToString();
        }
        #endregion

        
    }
}
