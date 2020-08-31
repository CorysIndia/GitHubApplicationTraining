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
    public class PID_DCS_SP_III : RSIControlModel
    {
        static PID_DCS_SP_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PID_DCS_SP_III), new FrameworkPropertyMetadata(typeof(PID_DCS_SP_III)));
        }

		public PID_DCS_SP_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PID_DCS_SP_III));

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
        /// DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty DCS_Value_FailProperty =
            DependencyProperty.Register("DCS_Value_Fail", typeof(bool), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DCS_Value_Fail
        {
            get { return (bool)this.GetValue(DCS_Value_FailProperty); }
            set { this.SetValue(DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty HMI_ValueProperty =
            DependencyProperty.Register("HMI_Value", typeof(double), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HMI_Value
        {
            get { return (double)this.GetValue(HMI_ValueProperty); }
            set { this.SetValue(HMI_ValueProperty, value); }
        }

        /// <summary>
        /// DEV Property
        /// </summary>
        public static readonly DependencyProperty DEVProperty =
            DependencyProperty.Register("DEV", typeof(bool), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DEV
        {
            get { return (bool)this.GetValue(DEVProperty); }
            set { this.SetValue(DEVProperty, value); }
        }

        /// <summary>
        /// DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty DCS_ValueProperty =
            DependencyProperty.Register("DCS_Value", typeof(double), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double DCS_Value
        {
            get { return (double)this.GetValue(DCS_ValueProperty); }
            set { this.SetValue(DCS_ValueProperty, value); }
        }

        /// <summary>
        /// HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty HMI_Value_FailProperty =
            DependencyProperty.Register("HMI_Value_Fail", typeof(bool), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HMI_Value_Fail
        {
            get { return (bool)this.GetValue(HMI_Value_FailProperty); }
            set { this.SetValue(HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty HMI_Enter_DisableProperty =
            DependencyProperty.Register("HMI_Enter_Disable", typeof(bool), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable")]
        public bool HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(HMI_Enter_DisableProperty); }
            set { this.SetValue(HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty HMI_EnterableProperty =
            DependencyProperty.Register("HMI_Enterable", typeof(double), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HMI_Enterable
        {
            get { return (double)this.GetValue(HMI_EnterableProperty); }
            set { this.SetValue(HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty HMI_Enterable_MaxProperty =
            DependencyProperty.Register("HMI_Enterable_Max", typeof(double), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double HMI_Enterable_Max
        {
            get { return (double)this.GetValue(HMI_Enterable_MaxProperty); }
            set { this.SetValue(HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty HMI_Enterable_MinProperty =
            DependencyProperty.Register("HMI_Enterable_Min", typeof(double), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double HMI_Enterable_Min
        {
            get { return (double)this.GetValue(HMI_Enterable_MinProperty); }
            set { this.SetValue(HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("HMI_Enterable_Keypad", typeof(bool), typeof(PID_DCS_SP_III));

        /// <summary>
        /// Gets or sets the HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(HMI_Enterable_KeypadProperty); }
            set { this.SetValue(HMI_Enterable_KeypadProperty, value); }
        }


		
		
    }
}
