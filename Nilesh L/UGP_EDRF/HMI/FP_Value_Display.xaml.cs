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
    public class FP_Value_Display : RSIControlModel
    {
        static FP_Value_Display()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FP_Value_Display), new FrameworkPropertyMetadata(typeof(FP_Value_Display)));
        }

		public FP_Value_Display()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(FP_Value_Display));

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
        /// CB_EU Property
        /// </summary>
        public static readonly DependencyProperty CB_EUProperty =
            DependencyProperty.Register("CB_EU", typeof(string), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB_EU
        {
            get { return (string)this.GetValue(CB_EUProperty); }
            set { this.SetValue(CB_EUProperty, value); }
        }

        /// <summary>
        /// CB_P Property
        /// </summary>
        public static readonly DependencyProperty CB_PProperty =
            DependencyProperty.Register("CB_P", typeof(double), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double CB_P
        {
            get { return (double)this.GetValue(CB_PProperty); }
            set { this.SetValue(CB_PProperty, value); }
        }

        /// <summary>
        /// CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty CB_P_MaxProperty =
            DependencyProperty.Register("CB_P_Max", typeof(double), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double CB_P_Max
        {
            get { return (double)this.GetValue(CB_P_MaxProperty); }
            set { this.SetValue(CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty CB_P_MinProperty =
            DependencyProperty.Register("CB_P_Min", typeof(double), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double CB_P_Min
        {
            get { return (double)this.GetValue(CB_P_MinProperty); }
            set { this.SetValue(CB_P_MinProperty, value); }
        }

        /// <summary>
        /// CB_BCALCI Property
        /// </summary>
        public static readonly DependencyProperty CB_BCALCIProperty =
            DependencyProperty.Register("CB_BCALCI", typeof(double), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the CB_BCALCI.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double CB_BCALCI
        {
            get { return (double)this.GetValue(CB_BCALCIProperty); }
            set { this.SetValue(CB_BCALCIProperty, value); }
        }

        /// <summary>
        /// ValueEntry Property
        /// </summary>
        public static readonly DependencyProperty ValueEntryProperty =
            DependencyProperty.Register("ValueEntry", typeof(string), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the ValueEntry.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ValueEntry
        {
            get { return (string)this.GetValue(ValueEntryProperty); }
            set { this.SetValue(ValueEntryProperty, value); }
        }

        /// <summary>
        /// TEXT_TYPE Property
        /// </summary>
        public static readonly DependencyProperty TEXT_TYPEProperty =
            DependencyProperty.Register("TEXT_TYPE", typeof(string), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the TEXT_TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT_TYPE
        {
            get { return (string)this.GetValue(TEXT_TYPEProperty); }
            set { this.SetValue(TEXT_TYPEProperty, value); }
        }

        /// <summary>
        /// UNIT Property
        /// </summary>
        public static readonly DependencyProperty UNITProperty =
            DependencyProperty.Register("UNIT", typeof(string), typeof(FP_Value_Display));

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

        /// <summary>
        /// OUT_BCALCI Property
        /// </summary>
        public static readonly DependencyProperty OUT_BCALCIProperty =
            DependencyProperty.Register("OUT_BCALCI", typeof(string), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the OUT_BCALCI.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OUT_BCALCI
        {
            get { return (string)this.GetValue(OUT_BCALCIProperty); }
            set { this.SetValue(OUT_BCALCIProperty, value); }
        }

        /// <summary>
        /// EU_TXT_COLR Property
        /// </summary>
        public static readonly DependencyProperty EU_TXT_COLRProperty =
            DependencyProperty.Register("EU_TXT_COLR", typeof(string), typeof(FP_Value_Display));

        /// <summary>
        /// Gets or sets the EU_TXT_COLR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EU_TXT_COLR
        {
            get { return (string)this.GetValue(EU_TXT_COLRProperty); }
            set { this.SetValue(EU_TXT_COLRProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CB_EU)) yield return new Param("$CB_EU", this.CB_EU);

            }
        }

		
    }
}
