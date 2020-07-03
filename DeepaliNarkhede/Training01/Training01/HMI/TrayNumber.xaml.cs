// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TrayNumber.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for TrayNumber.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows;
using RSI.Emulation.Controls.Control;

namespace Training01.HMI
{
    /// <summary>
    /// Interaction logic for TrayNumber.xaml
    /// </summary>
    public class TrayNumber : RSIControlModel
    {
        static TrayNumber()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TrayNumber), new FrameworkPropertyMetadata(typeof(TrayNumber)));
        }
    }
}