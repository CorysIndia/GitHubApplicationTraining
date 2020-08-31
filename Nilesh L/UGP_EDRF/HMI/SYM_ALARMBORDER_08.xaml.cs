using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_EDRF.HMI
{
    public class SYM_ALARMBORDER_08 : RSIControlModel
    {
        static SYM_ALARMBORDER_08()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALARMBORDER_08), new FrameworkPropertyMetadata(typeof(SYM_ALARMBORDER_08)));
        }

		public SYM_ALARMBORDER_08()
        {
            this.Loaded += OnLoaded; 
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.ControlMargin = ControlsHelper.GetControlMargin(this);
            this.Loaded -= OnLoaded;
        }

		      /// <summary>
        /// ControlMargin Property
        /// </summary>
        public static readonly DependencyProperty ControlMarginProperty =
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALARMBORDER_08));

        /// <summary>
        /// Gets or sets the Margin.  
        /// </summary>
        [Category("RSI")]
        [Description(@"")]
        public Thickness ControlMargin
        {
            get { return (Thickness)this.GetValue(ControlMarginProperty); }
            set { this.SetValue(ControlMarginProperty, value); }
        }


		        /// <summary>
        /// ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty ALARM_CONProperty =
            DependencyProperty.Register("ALARM_CON", typeof(int), typeof(SYM_ALARMBORDER_08));

        /// <summary>
        /// Gets or sets the ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM_CON
        {
            get { return (int)this.GetValue(ALARM_CONProperty); }
            set { this.SetValue(ALARM_CONProperty, value); }
        }


		
		
    }
}
