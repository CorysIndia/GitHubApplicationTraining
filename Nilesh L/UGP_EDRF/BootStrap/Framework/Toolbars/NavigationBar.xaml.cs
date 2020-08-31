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

namespace UGP_EDRF.BootStrap.Framework.Toolbars
{
    /// <summary>
    /// Interaction logic for NavigationBar.xaml
    /// </summary>
    public partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            InitializeComponent();
        }
    }


    public class MyDependencyClass : DependencyObject
    {
        #region IsCheckedOnDataProperty

        public static readonly DependencyProperty DataForPathProperty;

        public static void SetDataForPath(DependencyObject DepObject, string value)
        {
            DepObject.SetValue(DataForPathProperty, value);
        }

        public static string GetDataForPath(DependencyObject DepObject)
        {
            return (string)DepObject.GetValue(DataForPathProperty);
        }

        #endregion

        static MyDependencyClass()
        {
            PropertyMetadata MyPropertyMetadata = new PropertyMetadata(String.Empty);

            DataForPathProperty = DependencyProperty.RegisterAttached("DataForPath",
                typeof(string),
                typeof(MyDependencyClass),
                MyPropertyMetadata);
        }
    }

}
