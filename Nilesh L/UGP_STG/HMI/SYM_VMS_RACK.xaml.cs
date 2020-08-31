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
    public class SYM_VMS_RACK : RSIControlModel
    {
        static SYM_VMS_RACK()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_RACK), new FrameworkPropertyMetadata(typeof(SYM_VMS_RACK)));
        }

		public SYM_VMS_RACK()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_RACK));

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
        /// PSU_MR Property
        /// </summary>
        public static readonly DependencyProperty PSU_MRProperty =
            DependencyProperty.Register("PSU_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSU_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PSU_MR
        {
            get { return (bool)this.GetValue(PSU_MRProperty); }
            set { this.SetValue(PSU_MRProperty, value); }
        }

        /// <summary>
        /// PSL_MR Property
        /// </summary>
        public static readonly DependencyProperty PSL_MRProperty =
            DependencyProperty.Register("PSL_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSL_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PSL_MR
        {
            get { return (bool)this.GetValue(PSL_MRProperty); }
            set { this.SetValue(PSL_MRProperty, value); }
        }

        /// <summary>
        /// TDI_MR Property
        /// </summary>
        public static readonly DependencyProperty TDI_MRProperty =
            DependencyProperty.Register("TDI_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the TDI_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TDI_MR
        {
            get { return (bool)this.GetValue(TDI_MRProperty); }
            set { this.SetValue(TDI_MRProperty, value); }
        }

        /// <summary>
        /// S2U_MR Property
        /// </summary>
        public static readonly DependencyProperty S2U_MRProperty =
            DependencyProperty.Register("S2U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S2U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S2U_MR
        {
            get { return (bool)this.GetValue(S2U_MRProperty); }
            set { this.SetValue(S2U_MRProperty, value); }
        }

        /// <summary>
        /// S2L_MR Property
        /// </summary>
        public static readonly DependencyProperty S2L_MRProperty =
            DependencyProperty.Register("S2L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S2L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S2L_MR
        {
            get { return (bool)this.GetValue(S2L_MRProperty); }
            set { this.SetValue(S2L_MRProperty, value); }
        }

        /// <summary>
        /// S3U_MR Property
        /// </summary>
        public static readonly DependencyProperty S3U_MRProperty =
            DependencyProperty.Register("S3U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S3U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S3U_MR
        {
            get { return (bool)this.GetValue(S3U_MRProperty); }
            set { this.SetValue(S3U_MRProperty, value); }
        }

        /// <summary>
        /// S3L_MR Property
        /// </summary>
        public static readonly DependencyProperty S3L_MRProperty =
            DependencyProperty.Register("S3L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S3L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S3L_MR
        {
            get { return (bool)this.GetValue(S3L_MRProperty); }
            set { this.SetValue(S3L_MRProperty, value); }
        }

        /// <summary>
        /// S4U_MR Property
        /// </summary>
        public static readonly DependencyProperty S4U_MRProperty =
            DependencyProperty.Register("S4U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S4U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S4U_MR
        {
            get { return (bool)this.GetValue(S4U_MRProperty); }
            set { this.SetValue(S4U_MRProperty, value); }
        }

        /// <summary>
        /// S4L_MR Property
        /// </summary>
        public static readonly DependencyProperty S4L_MRProperty =
            DependencyProperty.Register("S4L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S4L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S4L_MR
        {
            get { return (bool)this.GetValue(S4L_MRProperty); }
            set { this.SetValue(S4L_MRProperty, value); }
        }

        /// <summary>
        /// S5U_MR Property
        /// </summary>
        public static readonly DependencyProperty S5U_MRProperty =
            DependencyProperty.Register("S5U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S5U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S5U_MR
        {
            get { return (bool)this.GetValue(S5U_MRProperty); }
            set { this.SetValue(S5U_MRProperty, value); }
        }

        /// <summary>
        /// S5L_MR Property
        /// </summary>
        public static readonly DependencyProperty S5L_MRProperty =
            DependencyProperty.Register("S5L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S5L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S5L_MR
        {
            get { return (bool)this.GetValue(S5L_MRProperty); }
            set { this.SetValue(S5L_MRProperty, value); }
        }

        /// <summary>
        /// S6U_MR Property
        /// </summary>
        public static readonly DependencyProperty S6U_MRProperty =
            DependencyProperty.Register("S6U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S6U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S6U_MR
        {
            get { return (bool)this.GetValue(S6U_MRProperty); }
            set { this.SetValue(S6U_MRProperty, value); }
        }

        /// <summary>
        /// S6L_MR Property
        /// </summary>
        public static readonly DependencyProperty S6L_MRProperty =
            DependencyProperty.Register("S6L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S6L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S6L_MR
        {
            get { return (bool)this.GetValue(S6L_MRProperty); }
            set { this.SetValue(S6L_MRProperty, value); }
        }

        /// <summary>
        /// S7U_MR Property
        /// </summary>
        public static readonly DependencyProperty S7U_MRProperty =
            DependencyProperty.Register("S7U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S7U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S7U_MR
        {
            get { return (bool)this.GetValue(S7U_MRProperty); }
            set { this.SetValue(S7U_MRProperty, value); }
        }

        /// <summary>
        /// S7L_MR Property
        /// </summary>
        public static readonly DependencyProperty S7L_MRProperty =
            DependencyProperty.Register("S7L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S7L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S7L_MR
        {
            get { return (bool)this.GetValue(S7L_MRProperty); }
            set { this.SetValue(S7L_MRProperty, value); }
        }

        /// <summary>
        /// S8U_MR Property
        /// </summary>
        public static readonly DependencyProperty S8U_MRProperty =
            DependencyProperty.Register("S8U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S8U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S8U_MR
        {
            get { return (bool)this.GetValue(S8U_MRProperty); }
            set { this.SetValue(S8U_MRProperty, value); }
        }

        /// <summary>
        /// S8L_MR Property
        /// </summary>
        public static readonly DependencyProperty S8L_MRProperty =
            DependencyProperty.Register("S8L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S8L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S8L_MR
        {
            get { return (bool)this.GetValue(S8L_MRProperty); }
            set { this.SetValue(S8L_MRProperty, value); }
        }

        /// <summary>
        /// S9U_MR Property
        /// </summary>
        public static readonly DependencyProperty S9U_MRProperty =
            DependencyProperty.Register("S9U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S9U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S9U_MR
        {
            get { return (bool)this.GetValue(S9U_MRProperty); }
            set { this.SetValue(S9U_MRProperty, value); }
        }

        /// <summary>
        /// S9L_MR Property
        /// </summary>
        public static readonly DependencyProperty S9L_MRProperty =
            DependencyProperty.Register("S9L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S9L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S9L_MR
        {
            get { return (bool)this.GetValue(S9L_MRProperty); }
            set { this.SetValue(S9L_MRProperty, value); }
        }

        /// <summary>
        /// S10U_MR Property
        /// </summary>
        public static readonly DependencyProperty S10U_MRProperty =
            DependencyProperty.Register("S10U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S10U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S10U_MR
        {
            get { return (bool)this.GetValue(S10U_MRProperty); }
            set { this.SetValue(S10U_MRProperty, value); }
        }

        /// <summary>
        /// S10L_MR Property
        /// </summary>
        public static readonly DependencyProperty S10L_MRProperty =
            DependencyProperty.Register("S10L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S10L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S10L_MR
        {
            get { return (bool)this.GetValue(S10L_MRProperty); }
            set { this.SetValue(S10L_MRProperty, value); }
        }

        /// <summary>
        /// S11U_MR Property
        /// </summary>
        public static readonly DependencyProperty S11U_MRProperty =
            DependencyProperty.Register("S11U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S11U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S11U_MR
        {
            get { return (bool)this.GetValue(S11U_MRProperty); }
            set { this.SetValue(S11U_MRProperty, value); }
        }

        /// <summary>
        /// S11L_MR Property
        /// </summary>
        public static readonly DependencyProperty S11L_MRProperty =
            DependencyProperty.Register("S11L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S11L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S11L_MR
        {
            get { return (bool)this.GetValue(S11L_MRProperty); }
            set { this.SetValue(S11L_MRProperty, value); }
        }

        /// <summary>
        /// S12U_MR Property
        /// </summary>
        public static readonly DependencyProperty S12U_MRProperty =
            DependencyProperty.Register("S12U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S12U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S12U_MR
        {
            get { return (bool)this.GetValue(S12U_MRProperty); }
            set { this.SetValue(S12U_MRProperty, value); }
        }

        /// <summary>
        /// S12L_MR Property
        /// </summary>
        public static readonly DependencyProperty S12L_MRProperty =
            DependencyProperty.Register("S12L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S12L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S12L_MR
        {
            get { return (bool)this.GetValue(S12L_MRProperty); }
            set { this.SetValue(S12L_MRProperty, value); }
        }

        /// <summary>
        /// S13U_MR Property
        /// </summary>
        public static readonly DependencyProperty S13U_MRProperty =
            DependencyProperty.Register("S13U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S13U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S13U_MR
        {
            get { return (bool)this.GetValue(S13U_MRProperty); }
            set { this.SetValue(S13U_MRProperty, value); }
        }

        /// <summary>
        /// S14U_MR Property
        /// </summary>
        public static readonly DependencyProperty S14U_MRProperty =
            DependencyProperty.Register("S14U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S14U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S14U_MR
        {
            get { return (bool)this.GetValue(S14U_MRProperty); }
            set { this.SetValue(S14U_MRProperty, value); }
        }

        /// <summary>
        /// S14L_MR Property
        /// </summary>
        public static readonly DependencyProperty S14L_MRProperty =
            DependencyProperty.Register("S14L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S14L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S14L_MR
        {
            get { return (bool)this.GetValue(S14L_MRProperty); }
            set { this.SetValue(S14L_MRProperty, value); }
        }

        /// <summary>
        /// S15U_MR Property
        /// </summary>
        public static readonly DependencyProperty S15U_MRProperty =
            DependencyProperty.Register("S15U_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S15U_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S15U_MR
        {
            get { return (bool)this.GetValue(S15U_MRProperty); }
            set { this.SetValue(S15U_MRProperty, value); }
        }

        /// <summary>
        /// S15L_MR Property
        /// </summary>
        public static readonly DependencyProperty S15L_MRProperty =
            DependencyProperty.Register("S15L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S15L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S15L_MR
        {
            get { return (bool)this.GetValue(S15L_MRProperty); }
            set { this.SetValue(S15L_MRProperty, value); }
        }

        /// <summary>
        /// S13L_MR Property
        /// </summary>
        public static readonly DependencyProperty S13L_MRProperty =
            DependencyProperty.Register("S13L_MR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the S13L_MR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool S13L_MR
        {
            get { return (bool)this.GetValue(S13L_MRProperty); }
            set { this.SetValue(S13L_MRProperty, value); }
        }

        /// <summary>
        /// UNIT_NO Property
        /// </summary>
        public static readonly DependencyProperty UNIT_NOProperty =
            DependencyProperty.Register("UNIT_NO", typeof(string), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the UNIT_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string UNIT_NO
        {
            get { return (string)this.GetValue(UNIT_NOProperty); }
            set { this.SetValue(UNIT_NOProperty, value); }
        }

        /// <summary>
        /// FLAG Property
        /// </summary>
        public static readonly DependencyProperty FLAGProperty =
            DependencyProperty.Register("FLAG", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the FLAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FLAG
        {
            get { return (bool)this.GetValue(FLAGProperty); }
            set { this.SetValue(FLAGProperty, value); }
        }

        /// <summary>
        /// RK_NO Property
        /// </summary>
        public static readonly DependencyProperty RK_NOProperty =
            DependencyProperty.Register("RK_NO", typeof(int), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the RK_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int RK_NO
        {
            get { return (int)this.GetValue(RK_NOProperty); }
            set { this.SetValue(RK_NOProperty, value); }
        }

        /// <summary>
        /// ROR Property
        /// </summary>
        public static readonly DependencyProperty RORProperty =
            DependencyProperty.Register("ROR", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the ROR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ROR
        {
            get { return (bool)this.GetValue(RORProperty); }
            set { this.SetValue(RORProperty, value); }
        }

        /// <summary>
        /// PSU_OK Property
        /// </summary>
        public static readonly DependencyProperty PSU_OKProperty =
            DependencyProperty.Register("PSU_OK", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSU_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PSU_OK
        {
            get { return (bool)this.GetValue(PSU_OKProperty); }
            set { this.SetValue(PSU_OKProperty, value); }
        }

        /// <summary>
        /// PSL_OK Property
        /// </summary>
        public static readonly DependencyProperty PSL_OKProperty =
            DependencyProperty.Register("PSL_OK", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSL_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PSL_OK
        {
            get { return (bool)this.GetValue(PSL_OKProperty); }
            set { this.SetValue(PSL_OKProperty, value); }
        }

        /// <summary>
        /// RACK_RST Property
        /// </summary>
        public static readonly DependencyProperty RACK_RSTProperty =
            DependencyProperty.Register("RACK_RST", typeof(int), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the RACK_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int RACK_RST
        {
            get { return (int)this.GetValue(RACK_RSTProperty); }
            set { this.SetValue(RACK_RSTProperty, value); }
        }

        /// <summary>
        /// RACK_NO Property
        /// </summary>
        public static readonly DependencyProperty RACK_NOProperty =
            DependencyProperty.Register("RACK_NO", typeof(string), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the RACK_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RACK_NO
        {
            get { return (string)this.GetValue(RACK_NOProperty); }
            set { this.SetValue(RACK_NOProperty, value); }
        }

        /// <summary>
        /// PSLOK_OK Property
        /// </summary>
        public static readonly DependencyProperty PSLOK_OKProperty =
            DependencyProperty.Register("PSLOK_OK", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSLOK_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool PSLOK_OK
        {
            get { return (bool)this.GetValue(PSLOK_OKProperty); }
            set { this.SetValue(PSLOK_OKProperty, value); }
        }

        /// <summary>
        /// PSUOK_OK Property
        /// </summary>
        public static readonly DependencyProperty PSUOK_OKProperty =
            DependencyProperty.Register("PSUOK_OK", typeof(bool), typeof(SYM_VMS_RACK));

        /// <summary>
        /// Gets or sets the PSUOK_OK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool PSUOK_OK
        {
            get { return (bool)this.GetValue(PSUOK_OKProperty); }
            set { this.SetValue(PSUOK_OKProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.UNIT_NO)) yield return new Param("$UNIT_NO", this.UNIT_NO);

            }
        }

		
    }
}
