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
    public class SYM_VMS_VGA_MOD : RSIControlModel
    {
        static SYM_VMS_VGA_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_VGA_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_VGA_MOD)));
        }

		public SYM_VMS_VGA_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_VGA_MOD));

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
        /// MODULE Property
        /// </summary>
        public static readonly DependencyProperty MODULEProperty =
            DependencyProperty.Register("MODULE", typeof(bool), typeof(SYM_VMS_VGA_MOD));

        /// <summary>
        /// Gets or sets the MODULE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MODULE
        {
            get { return (bool)this.GetValue(MODULEProperty); }
            set { this.SetValue(MODULEProperty, value); }
        }

        /// <summary>
        /// CHOK Property
        /// </summary>
        public static readonly DependencyProperty CHOKProperty =
            DependencyProperty.Register("CHOK", typeof(bool), typeof(SYM_VMS_VGA_MOD));

        /// <summary>
        /// Gets or sets the CHOK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CHOK
        {
            get { return (bool)this.GetValue(CHOKProperty); }
            set { this.SetValue(CHOKProperty, value); }
        }

        /// <summary>
        /// Channels Property
        /// </summary>
        public static readonly DependencyProperty ChannelsProperty =
            DependencyProperty.Register("Channels", typeof(string), typeof(SYM_VMS_VGA_MOD));

        /// <summary>
        /// Gets or sets the Channels.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Channels
        {
            get { return (string)this.GetValue(ChannelsProperty); }
            set { this.SetValue(ChannelsProperty, value); }
        }

        /// <summary>
        /// MODULE_STATUS_OK Property
        /// </summary>
        public static readonly DependencyProperty MODULE_STATUS_OKProperty =
            DependencyProperty.Register("MODULE_STATUS_OK", typeof(bool), typeof(SYM_VMS_VGA_MOD));

        /// <summary>
        /// Gets or sets the MODULE_STATUS_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool MODULE_STATUS_OK
        {
            get { return (bool)this.GetValue(MODULE_STATUS_OKProperty); }
            set { this.SetValue(MODULE_STATUS_OKProperty, value); }
        }

        /// <summary>
        /// CH1_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH1_IND_OKProperty =
            DependencyProperty.Register("CH1_IND_OK", typeof(bool), typeof(SYM_VMS_VGA_MOD));

        /// <summary>
        /// Gets or sets the CH1_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool CH1_IND_OK
        {
            get { return (bool)this.GetValue(CH1_IND_OKProperty); }
            set { this.SetValue(CH1_IND_OKProperty, value); }
        }


		
		
    }
}
