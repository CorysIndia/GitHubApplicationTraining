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
    public class DO_ESD_01_CE : RSIControlModel
    {
        static DO_ESD_01_CE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DO_ESD_01_CE), new FrameworkPropertyMetadata(typeof(DO_ESD_01_CE)));
        }

		public DO_ESD_01_CE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("BLK_T", typeof(string), typeof(DO_ESD_01_CE));

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
        /// CIN Property
        /// </summary>
        public static readonly DependencyProperty CINProperty =
            DependencyProperty.Register("CIN", typeof(bool), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CIN
        {
            get { return (bool)this.GetValue(CINProperty); }
            set { this.SetValue(CINProperty, value); }
        }

        /// <summary>
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("DISP", typeof(string), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("PICK1", typeof(string), typeof(DO_ESD_01_CE));

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
            DependencyProperty.Register("PICK2", typeof(string), typeof(DO_ESD_01_CE));

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
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(DO_ESD_01_CE));

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
        /// PICK1VAR Property
        /// </summary>
        public static readonly DependencyProperty PICK1VARProperty =
            DependencyProperty.Register("PICK1VAR", typeof(string), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the PICK1VAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1VAR
        {
            get { return (string)this.GetValue(PICK1VARProperty); }
            set { this.SetValue(PICK1VARProperty, value); }
        }

        /// <summary>
        /// BLK_RST Property
        /// </summary>
        public static readonly DependencyProperty BLK_RSTProperty =
            DependencyProperty.Register("BLK_RST", typeof(string), typeof(DO_ESD_01_CE));

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
        /// BLK_RST2 Property
        /// </summary>
        public static readonly DependencyProperty BLK_RST2Property =
            DependencyProperty.Register("BLK_RST2", typeof(string), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the BLK_RST2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_RST2
        {
            get { return (string)this.GetValue(BLK_RST2Property); }
            set { this.SetValue(BLK_RST2Property, value); }
        }

        /// <summary>
        /// PICK2VAR Property
        /// </summary>
        public static readonly DependencyProperty PICK2VARProperty =
            DependencyProperty.Register("PICK2VAR", typeof(string), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the PICK2VAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK2VAR
        {
            get { return (string)this.GetValue(PICK2VARProperty); }
            set { this.SetValue(PICK2VARProperty, value); }
        }

        /// <summary>
        /// PICK3 Property
        /// </summary>
        public static readonly DependencyProperty PICK3Property =
            DependencyProperty.Register("PICK3", typeof(string), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the PICK3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK3
        {
            get { return (string)this.GetValue(PICK3Property); }
            set { this.SetValue(PICK3Property, value); }
        }

        /// <summary>
        /// DUAL_RST Property
        /// </summary>
        public static readonly DependencyProperty DUAL_RSTProperty =
            DependencyProperty.Register("DUAL_RST", typeof(string), typeof(DO_ESD_01_CE));

        /// <summary>
        /// Gets or sets the DUAL_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DUAL_RST
        {
            get { return (string)this.GetValue(DUAL_RSTProperty); }
            set { this.SetValue(DUAL_RSTProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.PICK1)) yield return new Param("$PICK1", this.PICK1);
if (!string.IsNullOrWhiteSpace(this.PICK2)) yield return new Param("$PICK2", this.PICK2);
if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);
if (!string.IsNullOrWhiteSpace(this.PICK1VAR)) yield return new Param("$PICK1VAR", this.PICK1VAR);
if (!string.IsNullOrWhiteSpace(this.BLK_RST)) yield return new Param("$BLK_RST", this.BLK_RST);
if (!string.IsNullOrWhiteSpace(this.BLK_RST2)) yield return new Param("$BLK_RST2", this.BLK_RST2);
if (!string.IsNullOrWhiteSpace(this.PICK2VAR)) yield return new Param("$PICK2VAR", this.PICK2VAR);
if (!string.IsNullOrWhiteSpace(this.PICK3)) yield return new Param("$PICK3", this.PICK3);

            }
        }

		
    }
}
