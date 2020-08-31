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
    public class SYM_VMS_IND : RSIControlModel
    {
        static SYM_VMS_IND()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_IND), new FrameworkPropertyMetadata(typeof(SYM_VMS_IND)));
        }

		public SYM_VMS_IND()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_IND));

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
        /// OK Property
        /// </summary>
        public static readonly DependencyProperty OKProperty =
            DependencyProperty.Register("OK", typeof(bool), typeof(SYM_VMS_IND));

        /// <summary>
        /// Gets or sets the OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OK
        {
            get { return (bool)this.GetValue(OKProperty); }
            set { this.SetValue(OKProperty, value); }
        }

        /// <summary>
        /// BP Property
        /// </summary>
        public static readonly DependencyProperty BPProperty =
            DependencyProperty.Register("BP", typeof(bool), typeof(SYM_VMS_IND));

        /// <summary>
        /// Gets or sets the BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP
        {
            get { return (bool)this.GetValue(BPProperty); }
            set { this.SetValue(BPProperty, value); }
        }

        /// <summary>
        /// Bypass Property
        /// </summary>
        public static readonly DependencyProperty BypassProperty =
            DependencyProperty.Register("Bypass", typeof(string), typeof(SYM_VMS_IND));

        /// <summary>
        /// Gets or sets the Bypass.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Bypass
        {
            get { return (string)this.GetValue(BypassProperty); }
            set { this.SetValue(BypassProperty, value); }
        }


		
		
    }
}
