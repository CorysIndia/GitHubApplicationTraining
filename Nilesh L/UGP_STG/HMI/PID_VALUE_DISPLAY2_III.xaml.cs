using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_STG.HMI
{
    public class PID_VALUE_DISPLAY2_III : RSIControlModel
    {
        static PID_VALUE_DISPLAY2_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PID_VALUE_DISPLAY2_III), new FrameworkPropertyMetadata(typeof(PID_VALUE_DISPLAY2_III)));
        }

		public PID_VALUE_DISPLAY2_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PID_VALUE_DISPLAY2_III));

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
        /// Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty Value_FailProperty =
            DependencyProperty.Register("Value_Fail", typeof(bool), typeof(PID_VALUE_DISPLAY2_III));

        /// <summary>
        /// Gets or sets the Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Value_Fail
        {
            get { return (bool)this.GetValue(Value_FailProperty); }
            set { this.SetValue(Value_FailProperty, value); }
        }

        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(PID_VALUE_DISPLAY2_III));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }


		
		
    }
}
