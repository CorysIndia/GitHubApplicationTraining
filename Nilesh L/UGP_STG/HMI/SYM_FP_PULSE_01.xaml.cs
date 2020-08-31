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
    public class SYM_FP_PULSE_01 : RSIControlModel
    {
        static SYM_FP_PULSE_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_FP_PULSE_01), new FrameworkPropertyMetadata(typeof(SYM_FP_PULSE_01)));
        }

		public SYM_FP_PULSE_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_FP_PULSE_01));

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
        /// CON1 Property
        /// </summary>
        public static readonly DependencyProperty CON1Property =
            DependencyProperty.Register("CON1", typeof(bool), typeof(SYM_FP_PULSE_01));

        /// <summary>
        /// Gets or sets the CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CON1
        {
            get { return (bool)this.GetValue(CON1Property); }
            set { this.SetValue(CON1Property, value); }
        }

        /// <summary>
        /// REQ Property
        /// </summary>
        public static readonly DependencyProperty REQProperty =
            DependencyProperty.Register("REQ", typeof(bool), typeof(SYM_FP_PULSE_01));

        /// <summary>
        /// Gets or sets the REQ.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool REQ
        {
            get { return (bool)this.GetValue(REQProperty); }
            set { this.SetValue(REQProperty, value); }
        }

        /// <summary>
        /// SECONDS Property
        /// </summary>
        public static readonly DependencyProperty SECONDSProperty =
            DependencyProperty.Register("SECONDS", typeof(double), typeof(SYM_FP_PULSE_01));

        /// <summary>
        /// Gets or sets the SECONDS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SECONDS
        {
            get { return (double)this.GetValue(SECONDSProperty); }
            set { this.SetValue(SECONDSProperty, value); }
        }

        /// <summary>
        /// COUNTER Property
        /// </summary>
        public static readonly DependencyProperty COUNTERProperty =
            DependencyProperty.Register("COUNTER", typeof(double), typeof(SYM_FP_PULSE_01));

        /// <summary>
        /// Gets or sets the COUNTER.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double COUNTER
        {
            get { return (double)this.GetValue(COUNTERProperty); }
            set { this.SetValue(COUNTERProperty, value); }
        }


		
		
    }
}
