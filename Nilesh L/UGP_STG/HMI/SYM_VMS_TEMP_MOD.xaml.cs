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
    public class SYM_VMS_TEMP_MOD : RSIControlModel
    {
        static SYM_VMS_TEMP_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_TEMP_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_TEMP_MOD)));
        }

		public SYM_VMS_TEMP_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("VALUE", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH1OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH2OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
        /// CH3OK Property
        /// </summary>
        public static readonly DependencyProperty CH3OKProperty =
            DependencyProperty.Register("CH3OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH3OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH3OK
        {
            get { return (bool)this.GetValue(CH3OKProperty); }
            set { this.SetValue(CH3OKProperty, value); }
        }

        /// <summary>
        /// CH4OK Property
        /// </summary>
        public static readonly DependencyProperty CH4OKProperty =
            DependencyProperty.Register("CH4OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH4OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH4OK
        {
            get { return (bool)this.GetValue(CH4OKProperty); }
            set { this.SetValue(CH4OKProperty, value); }
        }

        /// <summary>
        /// CH5OK Property
        /// </summary>
        public static readonly DependencyProperty CH5OKProperty =
            DependencyProperty.Register("CH5OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH5OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH5OK
        {
            get { return (bool)this.GetValue(CH5OKProperty); }
            set { this.SetValue(CH5OKProperty, value); }
        }

        /// <summary>
        /// CH6OK Property
        /// </summary>
        public static readonly DependencyProperty CH6OKProperty =
            DependencyProperty.Register("CH6OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH6OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH6OK
        {
            get { return (bool)this.GetValue(CH6OKProperty); }
            set { this.SetValue(CH6OKProperty, value); }
        }

        /// <summary>
        /// CH1BP Property
        /// </summary>
        public static readonly DependencyProperty CH1BPProperty =
            DependencyProperty.Register("CH1BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH2BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
        /// CH3BP Property
        /// </summary>
        public static readonly DependencyProperty CH3BPProperty =
            DependencyProperty.Register("CH3BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH3BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH3BP
        {
            get { return (bool)this.GetValue(CH3BPProperty); }
            set { this.SetValue(CH3BPProperty, value); }
        }

        /// <summary>
        /// CH4BP Property
        /// </summary>
        public static readonly DependencyProperty CH4BPProperty =
            DependencyProperty.Register("CH4BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH4BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH4BP
        {
            get { return (bool)this.GetValue(CH4BPProperty); }
            set { this.SetValue(CH4BPProperty, value); }
        }

        /// <summary>
        /// CH5BP Property
        /// </summary>
        public static readonly DependencyProperty CH5BPProperty =
            DependencyProperty.Register("CH5BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH5BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH5BP
        {
            get { return (bool)this.GetValue(CH5BPProperty); }
            set { this.SetValue(CH5BPProperty, value); }
        }

        /// <summary>
        /// CH6BP Property
        /// </summary>
        public static readonly DependencyProperty CH6BPProperty =
            DependencyProperty.Register("CH6BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH6BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH6BP
        {
            get { return (bool)this.GetValue(CH6BPProperty); }
            set { this.SetValue(CH6BPProperty, value); }
        }

        /// <summary>
        /// Channel Property
        /// </summary>
        public static readonly DependencyProperty ChannelProperty =
            DependencyProperty.Register("Channel", typeof(string), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the Channel.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Channel
        {
            get { return (string)this.GetValue(ChannelProperty); }
            set { this.SetValue(ChannelProperty, value); }
        }

        /// <summary>
        /// MODULE_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty MODULE_IND_OKProperty =
            DependencyProperty.Register("MODULE_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
        /// CH6_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH6_IND_OKProperty =
            DependencyProperty.Register("CH6_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH6_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH6_IND_OK
        {
            get { return (bool)this.GetValue(CH6_IND_OKProperty); }
            set { this.SetValue(CH6_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH6_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH6_IND_BPProperty =
            DependencyProperty.Register("CH6_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH6_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH6_IND_BP
        {
            get { return (bool)this.GetValue(CH6_IND_BPProperty); }
            set { this.SetValue(CH6_IND_BPProperty, value); }
        }

        /// <summary>
        /// CH5_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH5_IND_OKProperty =
            DependencyProperty.Register("CH5_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH5_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH5_IND_OK
        {
            get { return (bool)this.GetValue(CH5_IND_OKProperty); }
            set { this.SetValue(CH5_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH5_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH5_IND_BPProperty =
            DependencyProperty.Register("CH5_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH5_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH5_IND_BP
        {
            get { return (bool)this.GetValue(CH5_IND_BPProperty); }
            set { this.SetValue(CH5_IND_BPProperty, value); }
        }

        /// <summary>
        /// CH4_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH4_IND_OKProperty =
            DependencyProperty.Register("CH4_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH4_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH4_IND_OK
        {
            get { return (bool)this.GetValue(CH4_IND_OKProperty); }
            set { this.SetValue(CH4_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH4_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH4_IND_BPProperty =
            DependencyProperty.Register("CH4_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH4_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH4_IND_BP
        {
            get { return (bool)this.GetValue(CH4_IND_BPProperty); }
            set { this.SetValue(CH4_IND_BPProperty, value); }
        }

        /// <summary>
        /// CH3_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH3_IND_OKProperty =
            DependencyProperty.Register("CH3_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH3_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH3_IND_OK
        {
            get { return (bool)this.GetValue(CH3_IND_OKProperty); }
            set { this.SetValue(CH3_IND_OKProperty, value); }
        }

        /// <summary>
        /// CH3_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty CH3_IND_BPProperty =
            DependencyProperty.Register("CH3_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

        /// <summary>
        /// Gets or sets the CH3_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CH3_IND_BP
        {
            get { return (bool)this.GetValue(CH3_IND_BPProperty); }
            set { this.SetValue(CH3_IND_BPProperty, value); }
        }

        /// <summary>
        /// CH2_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty CH2_IND_OKProperty =
            DependencyProperty.Register("CH2_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH2_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH1_IND_OK", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
            DependencyProperty.Register("CH1_IND_BP", typeof(bool), typeof(SYM_VMS_TEMP_MOD));

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
