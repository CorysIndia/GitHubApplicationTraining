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
    public class SYM_CTRVLV_03 : RSIControlModel
    {
        static SYM_CTRVLV_03()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CTRVLV_03), new FrameworkPropertyMetadata(typeof(SYM_CTRVLV_03)));
        }

		public SYM_CTRVLV_03()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CTRVLV_03));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the TAGNAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAGNAME
        {
            get { return (string)this.GetValue(TAGNAMEProperty); }
            set { this.SetValue(TAGNAMEProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the LOOP_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOOP_ID
        {
            get { return (string)this.GetValue(LOOP_IDProperty); }
            set { this.SetValue(LOOP_IDProperty, value); }
        }

        /// <summary>
        /// _MA Property
        /// </summary>
        public static readonly DependencyProperty _MAProperty =
            DependencyProperty.Register("_MA", typeof(bool), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the _MA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _MA
        {
            get { return (bool)this.GetValue(_MAProperty); }
            set { this.SetValue(_MAProperty, value); }
        }

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_CTRVLV_03));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_CTRVLV_03));

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
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the _MEAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _MEAS
        {
            get { return (double)this.GetValue(_MEASProperty); }
            set { this.SetValue(_MEASProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_CTRVLV_03));

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
        /// DISP Property
        /// </summary>
        public static readonly DependencyProperty DISPProperty =
            DependencyProperty.Register("DISP", typeof(string), typeof(SYM_CTRVLV_03));

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
        /// VLV_POS Property
        /// </summary>
        public static readonly DependencyProperty VLV_POSProperty =
            DependencyProperty.Register("VLV_POS", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the VLV_POS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VLV_POS
        {
            get { return (string)this.GetValue(VLV_POSProperty); }
            set { this.SetValue(VLV_POSProperty, value); }
        }

        //START
        /// <summary>
        /// LABEL3 Property
        /// </summary>
        public static readonly DependencyProperty LABEL3Property =
            DependencyProperty.Register("LABEL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the LABEL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABEL3
        {
            get { return (string)this.GetValue(LABEL3Property); }
            set { this.SetValue(LABEL3Property, value); }
        }


        /// <summary>
        /// TAG_VERT Property
        /// </summary>
        public static readonly DependencyProperty TAG_VERTProperty =
            DependencyProperty.Register("TAG_VERT", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the TAG_VERT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG_VERT
        {
            get { return (string)this.GetValue(TAG_VERTProperty); }
            set { this.SetValue(TAG_VERTProperty, value); }
        }

        /// <summary>
        /// FAIL Property
        /// </summary>
        public static readonly DependencyProperty FAILProperty =
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FAIL
        {
            get { return (string)this.GetValue(FAILProperty); }
            set { this.SetValue(FAILProperty, value); }
        }

        /// <summary>
        /// HORZ_OUTVALUE Property
        /// </summary>
        public static readonly DependencyProperty HORZ_OUTVALUEProperty =
            DependencyProperty.Register("HORZ_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the HORZ_OUTVALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HORZ_OUTVALUE
        {
            get { return (string)this.GetValue(HORZ_OUTVALUEProperty); }
            set { this.SetValue(HORZ_OUTVALUEProperty, value); }
        }

        /// <summary>
        /// VERT_L_OUTVALUE Property
        /// </summary>
        public static readonly DependencyProperty VERT_L_OUTVALUEProperty =
            DependencyProperty.Register("VERT_L_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the VERT_L_OUTVALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VERT_L_OUTVALUE
        {
            get { return (string)this.GetValue(VERT_L_OUTVALUEProperty); }
            set { this.SetValue(VERT_L_OUTVALUEProperty, value); }
        }

        /// <summary>
        /// VERT_R_OUTVALUE Property
        /// </summary>
        public static readonly DependencyProperty VERT_R_OUTVALUEProperty =
            DependencyProperty.Register("VERT_R_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the VERT_R_OUTVALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VERT_R_OUTVALUE
        {
            get { return (string)this.GetValue(VERT_R_OUTVALUEProperty); }
            set { this.SetValue(VERT_R_OUTVALUEProperty, value); }
        }

        /// <summary>
        /// Disp_Vertical_DISP Property
        /// </summary>
        public static readonly DependencyProperty Disp_Vertical_DISPProperty =
            DependencyProperty.Register("Disp_Vertical_DISP", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the Disp_Vertical_DISP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Disp_Vertical_DISP
        {
            get { return (string)this.GetValue(Disp_Vertical_DISPProperty); }
            set { this.SetValue(Disp_Vertical_DISPProperty, value); }
        }

        /// <summary>
        /// Disp_Vertical_PRT Property
        /// </summary>
        public static readonly DependencyProperty Disp_Vertical_PRTProperty =
            DependencyProperty.Register("Disp_Vertical_PRT", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the Disp_Vertical_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Disp_Vertical_PRT
        {
            get { return (string)this.GetValue(Disp_Vertical_PRTProperty); }
            set { this.SetValue(Disp_Vertical_PRTProperty, value); }
        }

        /// <summary>
        /// Disp_Horizontal_PRT Property
        /// </summary>
        public static readonly DependencyProperty Disp_Horizontal_PRTProperty =
            DependencyProperty.Register("Disp_Horizontal_PRT", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the Disp_Horizontal_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Disp_Horizontal_PRT
        {
            get { return (string)this.GetValue(Disp_Horizontal_PRTProperty); }
            set { this.SetValue(Disp_Horizontal_PRTProperty, value); }
        }

        /// <summary>
        /// Disp_Horizontal_DISP Property
        /// </summary>
        public static readonly DependencyProperty Disp_Horizontal_DISPProperty =
            DependencyProperty.Register("Disp_Horizontal_DISP", typeof(string), typeof(SYM_CTRVLV_03));

        /// <summary>
        /// Gets or sets the Disp_Horizontal_DISP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Disp_Horizontal_DISP
        {
            get { return (string)this.GetValue(Disp_Horizontal_DISPProperty); }
            set { this.SetValue(Disp_Horizontal_DISPProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.DISP)) yield return new Param("$DISP", this.DISP);
if (!string.IsNullOrWhiteSpace(this.LABEL3)) yield return new Param("$LABEL3", this.LABEL3);
if (!string.IsNullOrWhiteSpace(this.ModelName)) yield return new Param("$ModelName", this.ModelName);
            }
        }

		
    }
}
