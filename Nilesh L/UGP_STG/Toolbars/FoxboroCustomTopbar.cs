using System.Windows;
using System.Windows.Controls;

namespace UGP_EDRF.Toolbars
{
    public class FoxboroCustomTopbar : Control
    {
        static FoxboroCustomTopbar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FoxboroCustomTopbar), new FrameworkPropertyMetadata(typeof(FoxboroCustomTopbar)));
        }
    }
}
