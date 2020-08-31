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
    public class SYM_VMS_RELAY_MOD : RSIControlModel
    {
        static SYM_VMS_RELAY_MOD()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_RELAY_MOD), new FrameworkPropertyMetadata(typeof(SYM_VMS_RELAY_MOD)));
        }

		public SYM_VMS_RELAY_MOD()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_RELAY_MOD));

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
            DependencyProperty.Register("VALUE", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

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
        /// R1ACT Property
        /// </summary>
        public static readonly DependencyProperty R1ACTProperty =
            DependencyProperty.Register("R1ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R1ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R1ACT
        {
            get { return (bool)this.GetValue(R1ACTProperty); }
            set { this.SetValue(R1ACTProperty, value); }
        }

        /// <summary>
        /// R2ACT Property
        /// </summary>
        public static readonly DependencyProperty R2ACTProperty =
            DependencyProperty.Register("R2ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R2ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R2ACT
        {
            get { return (bool)this.GetValue(R2ACTProperty); }
            set { this.SetValue(R2ACTProperty, value); }
        }

        /// <summary>
        /// R3ACT Property
        /// </summary>
        public static readonly DependencyProperty R3ACTProperty =
            DependencyProperty.Register("R3ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R3ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R3ACT
        {
            get { return (bool)this.GetValue(R3ACTProperty); }
            set { this.SetValue(R3ACTProperty, value); }
        }

        /// <summary>
        /// R1BP Property
        /// </summary>
        public static readonly DependencyProperty R1BPProperty =
            DependencyProperty.Register("R1BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R1BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R1BP
        {
            get { return (bool)this.GetValue(R1BPProperty); }
            set { this.SetValue(R1BPProperty, value); }
        }

        /// <summary>
        /// R2BP Property
        /// </summary>
        public static readonly DependencyProperty R2BPProperty =
            DependencyProperty.Register("R2BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R2BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R2BP
        {
            get { return (bool)this.GetValue(R2BPProperty); }
            set { this.SetValue(R2BPProperty, value); }
        }

        /// <summary>
        /// R3BP Property
        /// </summary>
        public static readonly DependencyProperty R3BPProperty =
            DependencyProperty.Register("R3BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R3BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R3BP
        {
            get { return (bool)this.GetValue(R3BPProperty); }
            set { this.SetValue(R3BPProperty, value); }
        }

        /// <summary>
        /// R4ACT Property
        /// </summary>
        public static readonly DependencyProperty R4ACTProperty =
            DependencyProperty.Register("R4ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R4ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R4ACT
        {
            get { return (bool)this.GetValue(R4ACTProperty); }
            set { this.SetValue(R4ACTProperty, value); }
        }

        /// <summary>
        /// R4BP Property
        /// </summary>
        public static readonly DependencyProperty R4BPProperty =
            DependencyProperty.Register("R4BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R4BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R4BP
        {
            get { return (bool)this.GetValue(R4BPProperty); }
            set { this.SetValue(R4BPProperty, value); }
        }

        /// <summary>
        /// R5ACT Property
        /// </summary>
        public static readonly DependencyProperty R5ACTProperty =
            DependencyProperty.Register("R5ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R5ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R5ACT
        {
            get { return (bool)this.GetValue(R5ACTProperty); }
            set { this.SetValue(R5ACTProperty, value); }
        }

        /// <summary>
        /// R5BP Property
        /// </summary>
        public static readonly DependencyProperty R5BPProperty =
            DependencyProperty.Register("R5BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R5BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R5BP
        {
            get { return (bool)this.GetValue(R5BPProperty); }
            set { this.SetValue(R5BPProperty, value); }
        }

        /// <summary>
        /// R6ACT Property
        /// </summary>
        public static readonly DependencyProperty R6ACTProperty =
            DependencyProperty.Register("R6ACT", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R6ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R6ACT
        {
            get { return (bool)this.GetValue(R6ACTProperty); }
            set { this.SetValue(R6ACTProperty, value); }
        }

        /// <summary>
        /// R6BP Property
        /// </summary>
        public static readonly DependencyProperty R6BPProperty =
            DependencyProperty.Register("R6BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R6BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R6BP
        {
            get { return (bool)this.GetValue(R6BPProperty); }
            set { this.SetValue(R6BPProperty, value); }
        }

        /// <summary>
        /// Relay Property
        /// </summary>
        public static readonly DependencyProperty RelayProperty =
            DependencyProperty.Register("Relay", typeof(string), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the Relay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Relay
        {
            get { return (string)this.GetValue(RelayProperty); }
            set { this.SetValue(RelayProperty, value); }
        }

        /// <summary>
        /// MODULE_STATUS_OK Property
        /// </summary>
        public static readonly DependencyProperty MODULE_STATUS_OKProperty =
            DependencyProperty.Register("MODULE_STATUS_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

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
        /// R6_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R6_IND_OKProperty =
            DependencyProperty.Register("R6_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R6_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R6_IND_OK
        {
            get { return (bool)this.GetValue(R6_IND_OKProperty); }
            set { this.SetValue(R6_IND_OKProperty, value); }
        }

        /// <summary>
        /// R6_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R6_IND_BPProperty =
            DependencyProperty.Register("R6_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R6_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R6_IND_BP
        {
            get { return (bool)this.GetValue(R6_IND_BPProperty); }
            set { this.SetValue(R6_IND_BPProperty, value); }
        }

        /// <summary>
        /// R5_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R5_IND_OKProperty =
            DependencyProperty.Register("R5_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R5_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R5_IND_OK
        {
            get { return (bool)this.GetValue(R5_IND_OKProperty); }
            set { this.SetValue(R5_IND_OKProperty, value); }
        }

        /// <summary>
        /// R5_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R5_IND_BPProperty =
            DependencyProperty.Register("R5_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R5_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R5_IND_BP
        {
            get { return (bool)this.GetValue(R5_IND_BPProperty); }
            set { this.SetValue(R5_IND_BPProperty, value); }
        }

        /// <summary>
        /// R4_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R4_IND_OKProperty =
            DependencyProperty.Register("R4_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R4_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R4_IND_OK
        {
            get { return (bool)this.GetValue(R4_IND_OKProperty); }
            set { this.SetValue(R4_IND_OKProperty, value); }
        }

        /// <summary>
        /// R4_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R4_IND_BPProperty =
            DependencyProperty.Register("R4_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R4_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R4_IND_BP
        {
            get { return (bool)this.GetValue(R4_IND_BPProperty); }
            set { this.SetValue(R4_IND_BPProperty, value); }
        }

        /// <summary>
        /// R3_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R3_IND_OKProperty =
            DependencyProperty.Register("R3_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R3_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R3_IND_OK
        {
            get { return (bool)this.GetValue(R3_IND_OKProperty); }
            set { this.SetValue(R3_IND_OKProperty, value); }
        }

        /// <summary>
        /// R3_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R3_IND_BPProperty =
            DependencyProperty.Register("R3_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R3_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R3_IND_BP
        {
            get { return (bool)this.GetValue(R3_IND_BPProperty); }
            set { this.SetValue(R3_IND_BPProperty, value); }
        }

        /// <summary>
        /// R2_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R2_IND_OKProperty =
            DependencyProperty.Register("R2_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R2_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R2_IND_OK
        {
            get { return (bool)this.GetValue(R2_IND_OKProperty); }
            set { this.SetValue(R2_IND_OKProperty, value); }
        }

        /// <summary>
        /// R2_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R2_IND_BPProperty =
            DependencyProperty.Register("R2_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R2_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R2_IND_BP
        {
            get { return (bool)this.GetValue(R2_IND_BPProperty); }
            set { this.SetValue(R2_IND_BPProperty, value); }
        }

        /// <summary>
        /// R1_IND_OK Property
        /// </summary>
        public static readonly DependencyProperty R1_IND_OKProperty =
            DependencyProperty.Register("R1_IND_OK", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R1_IND_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R1_IND_OK
        {
            get { return (bool)this.GetValue(R1_IND_OKProperty); }
            set { this.SetValue(R1_IND_OKProperty, value); }
        }

        /// <summary>
        /// R1_IND_BP Property
        /// </summary>
        public static readonly DependencyProperty R1_IND_BPProperty =
            DependencyProperty.Register("R1_IND_BP", typeof(bool), typeof(SYM_VMS_RELAY_MOD));

        /// <summary>
        /// Gets or sets the R1_IND_BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool R1_IND_BP
        {
            get { return (bool)this.GetValue(R1_IND_BPProperty); }
            set { this.SetValue(R1_IND_BPProperty, value); }
        }


		
		
    }
}
