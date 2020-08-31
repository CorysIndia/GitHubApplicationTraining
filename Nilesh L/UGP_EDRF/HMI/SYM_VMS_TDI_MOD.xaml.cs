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
    public class SYM_VMS_TDI_MOD : RSIControlModel
    {
        static SYM_VMS_TDI_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_TDI_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_TDI_MOD)));
        }

		public SYM_VMS_TDI_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_TDI_MOD));

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
        /// VALUE Property
        /// </summary>
        public static readonly DependencyProperty VALUEProperty =
            DependencyProperty.Register("VALUE", typeof(bool), typeof(SYM_VMS_TDI_MOD));

        /// <summary>
        /// Gets or sets the VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool VALUE
        {
            get { return (bool)this.GetValue(VALUEProperty); }
            set { this.SetValue(VALUEProperty, value); }
        }

        /// <summary>
        /// COK_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty COK_IND_OKProperty =
            DependencyProperty.Register("COK_IND_OK", typeof(bool), typeof(SYM_VMS_TDI_MOD));

        /// <summary>
        /// Gets or sets the COK_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool COK_IND_OK
        {
            get { return (bool)this.GetValue(COK_IND_OKProperty); }
            set { this.SetValue(COK_IND_OKProperty, value); }
        }


		
		
    }
}
