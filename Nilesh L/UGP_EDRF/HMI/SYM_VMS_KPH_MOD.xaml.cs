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
    public class SYM_VMS_KPH_MOD : RSIControlModel
    {
        static SYM_VMS_KPH_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_KPH_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_KPH_MOD)));
        }

		public SYM_VMS_KPH_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_KPH_MOD));

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
            DependencyProperty.Register("VALUE", typeof(bool), typeof(SYM_VMS_KPH_MOD));

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
        /// CH1OK Property
        /// </summary>
        public static readonly DependencyProperty CH1OKProperty =
            DependencyProperty.Register("CH1OK", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH1OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH1OK
        {
            get { return (bool)this.GetValue(CH1OKProperty); }
            set { this.SetValue(CH1OKProperty, value); }
        }

        /// <summary>
        /// CH2OK Property
        /// </summary>
        public static readonly DependencyProperty CH2OKProperty =
            DependencyProperty.Register("CH2OK", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH2OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH2OK
        {
            get { return (bool)this.GetValue(CH2OKProperty); }
            set { this.SetValue(CH2OKProperty, value); }
        }

        /// <summary>
        /// CH1BP Property
        /// </summary>
        public static readonly DependencyProperty CH1BPProperty =
            DependencyProperty.Register("CH1BP", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH1BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH1BP
        {
            get { return (bool)this.GetValue(CH1BPProperty); }
            set { this.SetValue(CH1BPProperty, value); }
        }

        /// <summary>
        /// CH2BP Property
        /// </summary>
        public static readonly DependencyProperty CH2BPProperty =
            DependencyProperty.Register("CH2BP", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH2BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH2BP
        {
            get { return (bool)this.GetValue(CH2BPProperty); }
            set { this.SetValue(CH2BPProperty, value); }
        }

        /// <summary>
        /// Channels Property
        /// </summary>
        public static readonly DependencyProperty ChannelsProperty =
            DependencyProperty.Register("Channels", typeof(string), typeof(SYM_VMS_KPH_MOD));

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
        /// MODULE_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty MODULE_IND_OKProperty =
            DependencyProperty.Register("MODULE_IND_OK", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the MODULE_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool MODULE_IND_OK
        {
            get { return (bool)this.GetValue(MODULE_IND_OKProperty); }
            set { this.SetValue(MODULE_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH2_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH2_IND_OKProperty =
            DependencyProperty.Register("CH2_IND_OK", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH2_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH2_IND_OK
        {
            get { return (bool)this.GetValue(CH2_IND_OKProperty); }
            set { this.SetValue(CH2_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH2_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH2_IND_BPProperty =
            DependencyProperty.Register("CH2_IND_BP", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH2_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH2_IND_BP
        {
            get { return (bool)this.GetValue(CH2_IND_BPProperty); }
            set { this.SetValue(CH2_IND_BPProperty, value); }
        }

        /// <summary>
        /// CH1_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH1_IND_OKProperty =
            DependencyProperty.Register("CH1_IND_OK", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH1_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH1_IND_OK
        {
            get { return (bool)this.GetValue(CH1_IND_OKProperty); }
            set { this.SetValue(CH1_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH1_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH1_IND_BPProperty =
            DependencyProperty.Register("CH1_IND_BP", typeof(bool), typeof(SYM_VMS_KPH_MOD));

        /// <summary>
        /// Gets or sets the CH1_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH1_IND_BP
        {
            get { return (bool)this.GetValue(CH1_IND_BPProperty); }
            set { this.SetValue(CH1_IND_BPProperty, value); }
        }


		
		
    }
}
