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
    public class DO_FGS_04_CE : RSIControlModel
    {
        static DO_FGS_04_CE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DO_FGS_04_CE), new FrameworkPropertyMetadata(typeof(DO_FGS_04_CE)));
        }

		public DO_FGS_04_CE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DO_FGS_04_CE));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(DO_FGS_04_CE));

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
        /// BLK_T Property
        /// </summary>
        public static readonly DependencyProperty BLK_TProperty =
            DependencyProperty.Register("BLK_T", typeof(string), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the BLK_T.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_T
        {
            get { return (string)this.GetValue(BLK_TProperty); }
            set { this.SetValue(BLK_TProperty, value); }
        }

        /// <summary>
        /// COUT_H2S Property
        /// </summary>
        public static readonly DependencyProperty COUT_H2SProperty =
            DependencyProperty.Register("COUT_H2S", typeof(bool), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the COUT_H2S.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool COUT_H2S
        {
            get { return (bool)this.GetValue(COUT_H2SProperty); }
            set { this.SetValue(COUT_H2SProperty, value); }
        }

        /// <summary>
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the DESCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCRP
        {
            get { return (string)this.GetValue(DESCRPProperty); }
            set { this.SetValue(DESCRPProperty, value); }
        }

        /// <summary>
        /// DISP Property
        /// </summary>
        public static readonly DependencyProperty DISPProperty =
            DependencyProperty.Register("DISP", typeof(string), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the DISP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DISP
        {
            get { return (string)this.GetValue(DISPProperty); }
            set { this.SetValue(DISPProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PRT
        {
            get { return (string)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(DO_FGS_04_CE));

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
        /// COUT_LEL Property
        /// </summary>
        public static readonly DependencyProperty COUT_LELProperty =
            DependencyProperty.Register("COUT_LEL", typeof(bool), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the COUT_LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool COUT_LEL
        {
            get { return (bool)this.GetValue(COUT_LELProperty); }
            set { this.SetValue(COUT_LELProperty, value); }
        }

        /// <summary>
        /// COUT Property
        /// </summary>
        public static readonly DependencyProperty COUTProperty =
            DependencyProperty.Register("COUT", typeof(bool), typeof(DO_FGS_04_CE));

        /// <summary>
        /// Gets or sets the COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool COUT
        {
            get { return (bool)this.GetValue(COUTProperty); }
            set { this.SetValue(COUTProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK_T)) yield return new Param("$BLK_T", this.BLK_T);
if (!string.IsNullOrWhiteSpace(this.DESCRP)) yield return new Param("$DESCRP", this.DESCRP);
if (!string.IsNullOrWhiteSpace(this.DISP)) yield return new Param("$DISP", this.DISP);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);

            }
        }

		
    }
}
