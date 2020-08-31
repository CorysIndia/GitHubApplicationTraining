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
    public class dIndLED_02_L : RSIControlModel
    {
        static dIndLED_02_L()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(dIndLED_02_L), new FrameworkPropertyMetadata(typeof(dIndLED_02_L)));
        }

		public dIndLED_02_L()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(dIndLED_02_L));

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
        /// COLOUR1 Property
        /// </summary>
        public static readonly DependencyProperty COLOUR1Property =
            DependencyProperty.Register("COLOUR1", typeof(int), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the COLOUR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int COLOUR1
        {
            get { return (int)this.GetValue(COLOUR1Property); }
            set { this.SetValue(COLOUR1Property, value); }
        }

        /// <summary>
        /// VALUE1 Property
        /// </summary>
        public static readonly DependencyProperty VALUE1Property =
            DependencyProperty.Register("VALUE1", typeof(bool), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the VALUE1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool VALUE1
        {
            get { return (bool)this.GetValue(VALUE1Property); }
            set { this.SetValue(VALUE1Property, value); }
        }

        /// <summary>
        /// COLOUR2 Property
        /// </summary>
        public static readonly DependencyProperty COLOUR2Property =
            DependencyProperty.Register("COLOUR2", typeof(int), typeof(dIndLED_02_L));

       ///////////////////////////////////VAIBHAV//////////////////////////
        
        /// <summary>
        /// ZDESCRP Property
        /// </summary>
        public static readonly DependencyProperty ZDESCRPProperty =
            DependencyProperty.Register("ZDESCRP", typeof(string), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the ZDESCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZDESCRP
        {
            get { return (string)this.GetValue(ZDESCRPProperty); }
            set { this.SetValue(ZDESCRPProperty, value); }
        }

        /// <summary>
        /// ZFeedBackUO Property
        /// </summary>
        public static readonly DependencyProperty ZFeedBackUOProperty =
            DependencyProperty.Register("ZFeedBackUO", typeof(string), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the ZFeedBackUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZFeedBackUO
        {
            get { return (string)this.GetValue(ZFeedBackUOProperty); }
            set { this.SetValue(ZFeedBackUOProperty, value); }
        }


       

        /// <summary>
        /// ZLeftButtonText Property
        /// </summary>
        public static readonly DependencyProperty ZLeftButtonTextProperty =
            DependencyProperty.Register("ZLeftButtonText", typeof(string), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the ZLeftButtonText.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZLeftButtonText
        {
            get { return (string)this.GetValue(ZLeftButtonTextProperty); }
            set { this.SetValue(ZLeftButtonTextProperty, value); }
        }


        /// <summary>
        /// ZRightButtonText Property
        /// </summary>
        public static readonly DependencyProperty ZRightButtonTextProperty =
            DependencyProperty.Register("ZRightButtonText", typeof(string), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the ZRightButtonText.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZRightButtonText
        {
            get { return (string)this.GetValue(ZRightButtonTextProperty); }
            set { this.SetValue(ZRightButtonTextProperty, value); }
        }

        ///////////////////////////////////VAIBHAV//////////////////////////


        /// <summary>
        /// Gets or sets the COLOUR2.  
        /// </summary>
        [Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int COLOUR2
        {
            get { return (int)this.GetValue(COLOUR2Property); }
            set { this.SetValue(COLOUR2Property, value); }
        }

        /// <summary>
        /// VALUE2 Property
        /// </summary>
        public static readonly DependencyProperty VALUE2Property =
            DependencyProperty.Register("VALUE2", typeof(bool), typeof(dIndLED_02_L));

        /// <summary>
        /// Gets or sets the VALUE2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool VALUE2
        {
            get { return (bool)this.GetValue(VALUE2Property); }
            set { this.SetValue(VALUE2Property, value); }
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

                if (!string.IsNullOrWhiteSpace(this.ZDESCRP)) yield return new Param("$ZDESCRP", this.ZDESCRP);
                if (!string.IsNullOrWhiteSpace(this.ZFeedBackUO)) yield return new Param("$ZFeedBackUO", this.ZFeedBackUO);
                               if (!string.IsNullOrWhiteSpace(this.ZLeftButtonText)) yield return new Param("$ZLeftButtonText", this.ZLeftButtonText);
                if (!string.IsNullOrWhiteSpace(this.ZRightButtonText)) yield return new Param("$ZRightButtonText", this.ZRightButtonText);












            }
        }


    }
}
