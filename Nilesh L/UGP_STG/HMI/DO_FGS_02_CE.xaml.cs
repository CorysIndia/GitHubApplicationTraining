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
    public class DO_FGS_02_CE : RSIControlModel
    {
        static DO_FGS_02_CE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DO_FGS_02_CE), new FrameworkPropertyMetadata(typeof(DO_FGS_02_CE)));
        }

		public DO_FGS_02_CE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DO_FGS_02_CE));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(DO_FGS_02_CE));

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
            DependencyProperty.Register("BLK_T", typeof(string), typeof(DO_FGS_02_CE));

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
        /// H2S_ALM Property
        /// </summary>
        public static readonly DependencyProperty H2S_ALMProperty =
            DependencyProperty.Register("H2S_ALM", typeof(bool), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the H2S_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool H2S_ALM
        {
            get { return (bool)this.GetValue(H2S_ALMProperty); }
            set { this.SetValue(H2S_ALMProperty, value); }
        }

        /// <summary>
        /// DESCRP_LEL Property
        /// </summary>
        public static readonly DependencyProperty DESCRP_LELProperty =
            DependencyProperty.Register("DESCRP_LEL", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the DESCRP_LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCRP_LEL
        {
            get { return (string)this.GetValue(DESCRP_LELProperty); }
            set { this.SetValue(DESCRP_LELProperty, value); }
        }

        /// <summary>
        /// DISP Property
        /// </summary>
        public static readonly DependencyProperty DISPProperty =
            DependencyProperty.Register("DISP", typeof(string), typeof(DO_FGS_02_CE));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(DO_FGS_02_CE));

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
        /// PICK1 Property
        /// </summary>
        public static readonly DependencyProperty PICK1Property =
            DependencyProperty.Register("PICK1", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the PICK1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1
        {
            get { return (string)this.GetValue(PICK1Property); }
            set { this.SetValue(PICK1Property, value); }
        }

        /// <summary>
        /// PICK2 Property
        /// </summary>
        public static readonly DependencyProperty PICK2Property =
            DependencyProperty.Register("PICK2", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the PICK2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK2
        {
            get { return (string)this.GetValue(PICK2Property); }
            set { this.SetValue(PICK2Property, value); }
        }

        /// <summary>
        /// TAG_H2S Property
        /// </summary>
        public static readonly DependencyProperty TAG_H2SProperty =
            DependencyProperty.Register("TAG_H2S", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the TAG_H2S.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG_H2S
        {
            get { return (string)this.GetValue(TAG_H2SProperty); }
            set { this.SetValue(TAG_H2SProperty, value); }
        }

        /// <summary>
        /// PICK1VAR_H2S Property
        /// </summary>
        public static readonly DependencyProperty PICK1VAR_H2SProperty =
            DependencyProperty.Register("PICK1VAR_H2S", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the PICK1VAR_H2S.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1VAR_H2S
        {
            get { return (string)this.GetValue(PICK1VAR_H2SProperty); }
            set { this.SetValue(PICK1VAR_H2SProperty, value); }
        }

        /// <summary>
        /// BLK_RST Property
        /// </summary>
        public static readonly DependencyProperty BLK_RSTProperty =
            DependencyProperty.Register("BLK_RST", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the BLK_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_RST
        {
            get { return (string)this.GetValue(BLK_RSTProperty); }
            set { this.SetValue(BLK_RSTProperty, value); }
        }

        /// <summary>
        /// TAG_LEL Property
        /// </summary>
        public static readonly DependencyProperty TAG_LELProperty =
            DependencyProperty.Register("TAG_LEL", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the TAG_LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG_LEL
        {
            get { return (string)this.GetValue(TAG_LELProperty); }
            set { this.SetValue(TAG_LELProperty, value); }
        }

        /// <summary>
        /// PICK1VAR_LEL Property
        /// </summary>
        public static readonly DependencyProperty PICK1VAR_LELProperty =
            DependencyProperty.Register("PICK1VAR_LEL", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the PICK1VAR_LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1VAR_LEL
        {
            get { return (string)this.GetValue(PICK1VAR_LELProperty); }
            set { this.SetValue(PICK1VAR_LELProperty, value); }
        }

        /// <summary>
        /// DISP2 Property
        /// </summary>
        public static readonly DependencyProperty DISP2Property =
            DependencyProperty.Register("DISP2", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the DISP2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DISP2
        {
            get { return (string)this.GetValue(DISP2Property); }
            set { this.SetValue(DISP2Property, value); }
        }

        /// <summary>
        /// LEL_ALM Property
        /// </summary>
        public static readonly DependencyProperty LEL_ALMProperty =
            DependencyProperty.Register("LEL_ALM", typeof(bool), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the LEL_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LEL_ALM
        {
            get { return (bool)this.GetValue(LEL_ALMProperty); }
            set { this.SetValue(LEL_ALMProperty, value); }
        }

        /// <summary>
        /// DESCRP_H2S Property
        /// </summary>
        public static readonly DependencyProperty DESCRP_H2SProperty =
            DependencyProperty.Register("DESCRP_H2S", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the DESCRP_H2S.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCRP_H2S
        {
            get { return (string)this.GetValue(DESCRP_H2SProperty); }
            set { this.SetValue(DESCRP_H2SProperty, value); }
        }

        /// <summary>
        /// BLK_T_LEL Property
        /// </summary>
        public static readonly DependencyProperty BLK_T_LELProperty =
            DependencyProperty.Register("BLK_T_LEL", typeof(string), typeof(DO_FGS_02_CE));

        /// <summary>
        /// Gets or sets the BLK_T_LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_T_LEL
        {
            get { return (string)this.GetValue(BLK_T_LELProperty); }
            set { this.SetValue(BLK_T_LELProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.DESCRP_LEL)) yield return new Param("$DESCRP_LEL", this.DESCRP_LEL);
if (!string.IsNullOrWhiteSpace(this.DISP)) yield return new Param("$DISP", this.DISP);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.PICK1)) yield return new Param("$PICK1", this.PICK1);
if (!string.IsNullOrWhiteSpace(this.PICK2)) yield return new Param("$PICK2", this.PICK2);
if (!string.IsNullOrWhiteSpace(this.TAG_H2S)) yield return new Param("$TAG_H2S", this.TAG_H2S);
if (!string.IsNullOrWhiteSpace(this.PICK1VAR_H2S)) yield return new Param("$PICK1VAR_H2S", this.PICK1VAR_H2S);
if (!string.IsNullOrWhiteSpace(this.BLK_RST)) yield return new Param("$BLK_RST", this.BLK_RST);
if (!string.IsNullOrWhiteSpace(this.TAG_LEL)) yield return new Param("$TAG_LEL", this.TAG_LEL);
if (!string.IsNullOrWhiteSpace(this.PICK1VAR_LEL)) yield return new Param("$PICK1VAR_LEL", this.PICK1VAR_LEL);
if (!string.IsNullOrWhiteSpace(this.DISP2)) yield return new Param("$DISP2", this.DISP2);
if (!string.IsNullOrWhiteSpace(this.DESCRP_H2S)) yield return new Param("$DESCRP_H2S", this.DESCRP_H2S);
if (!string.IsNullOrWhiteSpace(this.BLK_T_LEL)) yield return new Param("$BLK_T_LEL", this.BLK_T_LEL);

            }
        }

		
    }
}
