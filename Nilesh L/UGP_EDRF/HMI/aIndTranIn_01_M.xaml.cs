using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;
using RSI.Emulation.Controls.Control.FoxBoro;


namespace UGP_EDRF.HMI
{
    public class aIndTranIn_01_M : FoxboroAI
    {
        static aIndTranIn_01_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(aIndTranIn_01_M), new FrameworkPropertyMetadata(typeof(aIndTranIn_01_M)));
        }

		public aIndTranIn_01_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(aIndTranIn_01_M));

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
            DependencyProperty.Register("VALUE", typeof(double), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname to display its value here

e.g. rPI12345")]
        public double VALUE
        {
            get { return (double)this.GetValue(VALUEProperty); }
            set { this.SetValue(VALUEProperty, value); }
        }

        /// <summary>
        /// LL Property
        /// </summary>
        public static readonly DependencyProperty LLProperty =
            DependencyProperty.Register("LL", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the LL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to change the DisplayValue colour. 
When True, DisplayValue is Green.
When False, DisplayValue is Red.")]
        public bool LL
        {
            get { return (bool)this.GetValue(LLProperty); }
            set { this.SetValue(LLProperty, value); }
        }

        /// <summary>
        /// L Property
        /// </summary>
        public static readonly DependencyProperty LProperty =
            DependencyProperty.Register("L", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the L.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool L
        {
            get { return (bool)this.GetValue(LProperty); }
            set { this.SetValue(LProperty, value); }
        }

        /// <summary>
        /// H Property
        /// </summary>
        public static readonly DependencyProperty HProperty =
            DependencyProperty.Register("H", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the H.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm High tagname here to enable H alarm indicator. 
When True, H indicator is hidden.
When False, H indicator appears.")]
        public bool H
        {
            get { return (bool)this.GetValue(HProperty); }
            set { this.SetValue(HProperty, value); }
        }

        /// <summary>
        /// HH Property
        /// </summary>
        public static readonly DependencyProperty HHProperty =
            DependencyProperty.Register("HH", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the HH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HH
        {
            get { return (bool)this.GetValue(HHProperty); }
            set { this.SetValue(HHProperty, value); }
        }

        /// <summary>
        /// DEV Property
        /// </summary>
        public static readonly DependencyProperty DEVProperty =
            DependencyProperty.Register("DEV", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm DEV tagname here to enable DEV alarm indicator. 
When True, DEV indicator is hidden.
When False, DEV indicator appears.")]
        public bool DEV
        {
            get { return (bool)this.GetValue(DEVProperty); }
            set { this.SetValue(DEVProperty, value); }
        }

        /// <summary>
        /// FAIL Property
        /// </summary>
        public static readonly DependencyProperty FAILProperty =
            DependencyProperty.Register("FAIL", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm FAIL tagname here to change Tagname Background colour. 
When True, Tag Background is Black.
When False, Tag Background is Red.")]
        public bool FAIL
        {
            get { return (bool)this.GetValue(FAILProperty); }
            set { this.SetValue(FAILProperty, value); }
        }

        /// <summary>
        /// BYPASS Property
        /// </summary>
        public static readonly DependencyProperty BYPASSProperty =
            DependencyProperty.Register("BYPASS", typeof(bool), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm BYP tagname here to enable BYP alarm indicator. 
When True, BYP indicator is hidden.
When False, BYP indicator appears.")]
        public bool BYPASS
        {
            get { return (bool)this.GetValue(BYPASSProperty); }
            set { this.SetValue(BYPASSProperty, value); }
        }

        /// <summary>
        /// VALUE_TEXT Property
        /// </summary>
        public static readonly DependencyProperty VALUE_TEXTProperty =
            DependencyProperty.Register("VALUE_TEXT", typeof(int), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the VALUE_TEXT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"VALUE FOR TEXT COLOR;
IF VALUE == 0, TEXT IS GREEN;
IF VALUE == 1, TEXT IS ORANGE;
IF VALUE == 2, TEXT IS RED;")]
        public int VALUE_TEXT
        {
            get { return (int)this.GetValue(VALUE_TEXTProperty); }
            set { this.SetValue(VALUE_TEXTProperty, value); }
        }

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the TAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG
        {
            get { return (string)this.GetValue(TAGProperty); }
            set { this.SetValue(TAGProperty, value); }
        }


        /// <summary>
        /// BYPASSCIN Property
        /// </summary>
        public static readonly DependencyProperty BYPASSCINProperty =
            DependencyProperty.Register("BYPASSCIN", typeof(string), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the BYPASSCIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BYPASSCIN
        {
            get { return (string)this.GetValue(BYPASSCINProperty); }
            set { this.SetValue(BYPASSCINProperty, value); }
        }









        /// <summary>
        /// UNIT Property
        /// </summary>
        public static readonly DependencyProperty UNITProperty =
            DependencyProperty.Register("UNIT", typeof(string), typeof(aIndTranIn_01_M));

        /// <summary>
        /// Gets or sets the UNIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string UNIT
        {
            get { return (string)this.GetValue(UNITProperty); }
            set { this.SetValue(UNITProperty, value); }
        }

        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
                foreach (var p in base.IndissLikeParameters)
                {
                    yield return p;
                }

                if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);
                if (!string.IsNullOrWhiteSpace(this.UNIT)) yield return new Param("$UNIT", this.UNIT);
                if (!string.IsNullOrWhiteSpace(this.BYPASSCIN)) yield return new Param("$BYPASSCIN", this.BYPASSCIN);
            }
        }


    }
}
