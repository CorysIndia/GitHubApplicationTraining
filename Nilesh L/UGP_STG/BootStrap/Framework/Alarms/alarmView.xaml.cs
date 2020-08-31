
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlarmView.xaml.cs)" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for AlarmView.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;
using RSI.Common.Locator;
using RSI.Common.WPFTools.Extensions;
using RSI.FoxboroEVO.Core.Services;
using RSI.IndissLike.Controls.Helpers;

namespace UGP_STG.BootStrap.Framework.Alarms
{
    /// <summary>
    /// Interaction logic for AlarmView.xaml
    /// </summary>
    [Export("AlarmView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AlarmView
    {
        public AlarmView()
        {
            this.InitializeComponent();
            this.OnceLoaded(fe => this.OnLoaded());
        }

        /// <summary>
        /// Called when [loaded].
        /// </summary>
        private void OnLoaded()
        {
        }

        

        public List<object> VisibleAlarms
        {
            get { return (List<object>)GetValue(VisibleAlarmsPropertyProperty); }
            set
            {
                SetValue(VisibleAlarmsPropertyProperty, value);
                CommandManager.InvalidateRequerySuggested();
            }
        }

        // Using a DependencyProperty as the backing store for VisibleAlarmsProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VisibleAlarmsPropertyProperty =
            DependencyProperty.Register("VisibleAlarms", typeof(List<object>), typeof(AlarmView), new PropertyMetadata(null));

        public static string[] AlarmStatusText = new[] { "Inactive", "Returned", "Acknowledged", "Active" };

    }
}
