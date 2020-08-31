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
    public class Type2_BaseplatePIDDisplay_III_3 : RSIControlModel
    {
        static Type2_BaseplatePIDDisplay_III_3()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type2_BaseplatePIDDisplay_III_3), new FrameworkPropertyMetadata(typeof(Type2_BaseplatePIDDisplay_III_3)));
        }

		public Type2_BaseplatePIDDisplay_III_3()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type2_BaseplatePIDDisplay_III_3));

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
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(Type2_BaseplatePIDDisplay_III_3));

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

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Enterable Property
        /// </summary>
        public static readonly DependencyProperty EnterableProperty =
            DependencyProperty.Register("Enterable", typeof(double), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Enterable
        {
            get { return (double)this.GetValue(EnterableProperty); }
            set { this.SetValue(EnterableProperty, value); }
        }

        /// <summary>
        /// EnterType Property
        /// </summary>
        public static readonly DependencyProperty EnterTypeProperty =
            DependencyProperty.Register("EnterType", typeof(bool), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool EnterType
        {
            get { return (bool)this.GetValue(EnterTypeProperty); }
            set { this.SetValue(EnterTypeProperty, value); }
        }

        /// <summary>
        /// Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty Enterable_MinProperty =
            DependencyProperty.Register("Enterable_Min", typeof(double), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Enterable_Min
        {
            get { return (double)this.GetValue(Enterable_MinProperty); }
            set { this.SetValue(Enterable_MinProperty, value); }
        }

        /// <summary>
        /// Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty Enterable_MaxProperty =
            DependencyProperty.Register("Enterable_Max", typeof(double), typeof(Type2_BaseplatePIDDisplay_III_3));

        /// <summary>
        /// Gets or sets the Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Enterable_Max
        {
            get { return (double)this.GetValue(Enterable_MaxProperty); }
            set { this.SetValue(Enterable_MaxProperty, value); }
        }


		
		
    }
}
