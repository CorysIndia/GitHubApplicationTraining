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
    public class SYM_VMS_EXP_MOD : RSIControlModel
    {
        static SYM_VMS_EXP_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_EXP_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_EXP_MOD)));
        }

		public SYM_VMS_EXP_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_EXP_MOD));

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
        /// Size Property
        /// </summary>
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(string), typeof(SYM_VMS_EXP_MOD));

        /// <summary>
        /// Gets or sets the Size.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Size
        {
            get { return (string)this.GetValue(SizeProperty); }
            set { this.SetValue(SizeProperty, value); }
        }


		
		
    }
}
