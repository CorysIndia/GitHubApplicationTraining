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
    public class SYM_SEQ_TMR_HMS : RSIControlModel
    {
        static SYM_SEQ_TMR_HMS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SEQ_TMR_HMS), new FrameworkPropertyMetadata(typeof(SYM_SEQ_TMR_HMS)));
        }

		public SYM_SEQ_TMR_HMS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SEQ_TMR_HMS));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK
        {
            get { return (string)this.GetValue(BLKProperty); }
            set { this.SetValue(BLKProperty, value); }
        }

        /// <summary>
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR
        {
            get { return (string)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// HH Property
        /// </summary>
        public static readonly DependencyProperty HHProperty =
            DependencyProperty.Register("HH", typeof(int), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the HH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HH
        {
            get { return (int)this.GetValue(HHProperty); }
            set { this.SetValue(HHProperty, value); }
        }

        /// <summary>
        /// MM Property
        /// </summary>
        public static readonly DependencyProperty MMProperty =
            DependencyProperty.Register("MM", typeof(int), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the MM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MM
        {
            get { return (int)this.GetValue(MMProperty); }
            set { this.SetValue(MMProperty, value); }
        }

        /// <summary>
        /// SS Property
        /// </summary>
        public static readonly DependencyProperty SSProperty =
            DependencyProperty.Register("SS", typeof(int), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the SS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SS
        {
            get { return (int)this.GetValue(SSProperty); }
            set { this.SetValue(SSProperty, value); }
        }

        /// <summary>
        /// SECS Property
        /// </summary>
        public static readonly DependencyProperty SECSProperty =
            DependencyProperty.Register("SECS", typeof(double), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the SECS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SECS
        {
            get { return (double)this.GetValue(SECSProperty); }
            set { this.SetValue(SECSProperty, value); }
        }

        /// <summary>
        /// HRS Property
        /// </summary>
        public static readonly DependencyProperty HRSProperty =
            DependencyProperty.Register("HRS", typeof(double), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the HRS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HRS
        {
            get { return (double)this.GetValue(HRSProperty); }
            set { this.SetValue(HRSProperty, value); }
        }

        /// <summary>
        /// XX Property
        /// </summary>
        public static readonly DependencyProperty XXProperty =
            DependencyProperty.Register("XX", typeof(bool), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the XX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool XX
        {
            get { return (bool)this.GetValue(XXProperty); }
            set { this.SetValue(XXProperty, value); }
        }

        /// <summary>
        /// BLK_SP Property
        /// </summary>
        public static readonly DependencyProperty BLK_SPProperty =
            DependencyProperty.Register("BLK_SP", typeof(string), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the BLK_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_SP
        {
            get { return (string)this.GetValue(BLK_SPProperty); }
            set { this.SetValue(BLK_SPProperty, value); }
        }

        /// <summary>
        /// VALUE Property
        /// </summary>
        public static readonly DependencyProperty VALUEProperty =
            DependencyProperty.Register("VALUE", typeof(double), typeof(SYM_SEQ_TMR_HMS));

        /// <summary>
        /// Gets or sets the VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double VALUE
        {
            get { return (double)this.GetValue(VALUEProperty); }
            set { this.SetValue(VALUEProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
if (!string.IsNullOrWhiteSpace(this.BLK_SP)) yield return new Param("$BLK_SP", this.BLK_SP);

            }
        }

		
    }
}
