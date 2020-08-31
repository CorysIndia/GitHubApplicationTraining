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
    public class DI_ESD_01_CE : RSIControlModel
    {
        static DI_ESD_01_CE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DI_ESD_01_CE), new FrameworkPropertyMetadata(typeof(DI_ESD_01_CE)));
        }

		public DI_ESD_01_CE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DI_ESD_01_CE));

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
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the MA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MA
        {
            get { return (bool)this.GetValue(MAProperty); }
            set { this.SetValue(MAProperty, value); }
        }

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(DI_ESD_01_CE));

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
            DependencyProperty.Register("BLK_T", typeof(string), typeof(DI_ESD_01_CE));

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
            DependencyProperty.Register("CIN", typeof(bool), typeof(DI_ESD_01_CE));

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
        /// BLK_MOS Property
        /// </summary>
        public static readonly DependencyProperty BLK_MOSProperty =
            DependencyProperty.Register("BLK_MOS", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the BLK_MOS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_MOS
        {
            get { return (string)this.GetValue(BLK_MOSProperty); }
            set { this.SetValue(BLK_MOSProperty, value); }
        }

        /// <summary>
        /// BLK_FLT Property
        /// </summary>
        public static readonly DependencyProperty BLK_FLTProperty =
            DependencyProperty.Register("BLK_FLT", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the BLK_FLT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_FLT
        {
            get { return (string)this.GetValue(BLK_FLTProperty); }
            set { this.SetValue(BLK_FLTProperty, value); }
        }

        /// <summary>
        /// FLT Property
        /// </summary>
        public static readonly DependencyProperty FLTProperty =
            DependencyProperty.Register("FLT", typeof(bool), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the FLT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FLT
        {
            get { return (bool)this.GetValue(FLTProperty); }
            set { this.SetValue(FLTProperty, value); }
        }

        /// <summary>
        /// BLK_FU Property
        /// </summary>
        public static readonly DependencyProperty BLK_FUProperty =
            DependencyProperty.Register("BLK_FU", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the BLK_FU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_FU
        {
            get { return (string)this.GetValue(BLK_FUProperty); }
            set { this.SetValue(BLK_FUProperty, value); }
        }

        /// <summary>
        /// FU_ENABLE Property
        /// </summary>
        public static readonly DependencyProperty FU_ENABLEProperty =
            DependencyProperty.Register("FU_ENABLE", typeof(bool), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the FU_ENABLE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FU_ENABLE
        {
            get { return (bool)this.GetValue(FU_ENABLEProperty); }
            set { this.SetValue(FU_ENABLEProperty, value); }
        }

        /// <summary>
        /// DISP Property
        /// </summary>
        public static readonly DependencyProperty DISPProperty =
            DependencyProperty.Register("DISP", typeof(string), typeof(DI_ESD_01_CE));

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
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(DI_ESD_01_CE));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(DI_ESD_01_CE));

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
        /// CMP_FU Property
        /// </summary>
        public static readonly DependencyProperty CMP_FUProperty =
            DependencyProperty.Register("CMP_FU", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the CMP_FU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_FU
        {
            get { return (string)this.GetValue(CMP_FUProperty); }
            set { this.SetValue(CMP_FUProperty, value); }
        }

        /// <summary>
        /// FUP Property
        /// </summary>
        public static readonly DependencyProperty FUPProperty =
            DependencyProperty.Register("FUP", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the FUP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FUP
        {
            get { return (string)this.GetValue(FUPProperty); }
            set { this.SetValue(FUPProperty, value); }
        }

        /// <summary>
        /// FU Property
        /// </summary>
        public static readonly DependencyProperty FUProperty =
            DependencyProperty.Register("FU", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the FU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FU
        {
            get { return (string)this.GetValue(FUProperty); }
            set { this.SetValue(FUProperty, value); }
        }

        /// <summary>
        /// DESCR Property
        /// </summary>
        public static readonly DependencyProperty DESCRProperty =
            DependencyProperty.Register("DESCR", typeof(string), typeof(DI_ESD_01_CE));

        /// <summary>
        /// Gets or sets the FU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCR
        {
            get { return (string)this.GetValue(DESCRProperty); }
            set { this.SetValue(DESCRProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK_MOS)) yield return new Param("$BLK_MOS", this.BLK_MOS);
if (!string.IsNullOrWhiteSpace(this.BLK_FLT)) yield return new Param("$BLK_FLT", this.BLK_FLT);
if (!string.IsNullOrWhiteSpace(this.BLK_FU)) yield return new Param("$BLK_FU", this.BLK_FU);
if (!string.IsNullOrWhiteSpace(this.DISP)) yield return new Param("$DISP", this.DISP);
if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.CMP_FU)) yield return new Param("$CMP_FU", this.CMP_FU);
                if (!string.IsNullOrWhiteSpace(this.DESCR)) yield return new Param("$DESCR", this.DESCR);

            }
        }

		
    }
}
