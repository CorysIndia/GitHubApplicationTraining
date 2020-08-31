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
    public class SYM_CTRVLV_01 : RSIControlModel
    {
        static SYM_CTRVLV_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CTRVLV_01), new FrameworkPropertyMetadata(typeof(SYM_CTRVLV_01)));
        }

		public SYM_CTRVLV_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_CTRVLV_01));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_CTRVLV_01));

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
        /// OUTPUT Property
        /// </summary>
        public static readonly DependencyProperty OUTPUTProperty =
            DependencyProperty.Register("OUTPUT", typeof(double), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the OUTPUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OUTPUT
        {
            get { return (double)this.GetValue(OUTPUTProperty); }
            set { this.SetValue(OUTPUTProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_CTRVLV_01));

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
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOC
        {
            get { return (string)this.GetValue(LOCProperty); }
            set { this.SetValue(LOCProperty, value); }
        }

        /// <summary>
        /// DUTY Property
        /// </summary>
        public static readonly DependencyProperty DUTYProperty =
            DependencyProperty.Register("DUTY", typeof(bool), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the DUTY.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DUTY
        {
            get { return (bool)this.GetValue(DUTYProperty); }
            set { this.SetValue(DUTYProperty, value); }
        }

        /// <summary>
        /// CALCA Property
        /// </summary>
        public static readonly DependencyProperty CALCAProperty =
            DependencyProperty.Register("CALCA", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the CALCA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALCA
        {
            get { return (string)this.GetValue(CALCAProperty); }
            set { this.SetValue(CALCAProperty, value); }
        }

        /// <summary>
        /// SWCH Property
        /// </summary>
        public static readonly DependencyProperty SWCHProperty =
            DependencyProperty.Register("SWCH", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the SWCH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SWCH
        {
            get { return (string)this.GetValue(SWCHProperty); }
            set { this.SetValue(SWCHProperty, value); }
        }

        /// <summary>
        /// VLV_POS Property
        /// </summary>
        public static readonly DependencyProperty VLV_POSProperty =
            DependencyProperty.Register("VLV_POS", typeof(string), typeof(SYM_CTRVLV_01));

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
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the LABEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABEL
        {
            get { return (string)this.GetValue(LABELProperty); }
            set { this.SetValue(LABELProperty, value); }
        }


        /// <summary>
        /// TAG_VERT Property
        /// </summary>
        public static readonly DependencyProperty TAG_VERTProperty =
            DependencyProperty.Register("TAG_VERT", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("HORZ_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("VERT_L_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_01));

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
            DependencyProperty.Register("VERT_R_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_01));

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
        /// SPARE_VLV Property
        /// </summary>
        public static readonly DependencyProperty SPARE_VLVProperty =
            DependencyProperty.Register("SPARE_VLV", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the SPARE_VLV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SPARE_VLV
        {
            get { return (string)this.GetValue(SPARE_VLVProperty); }
            set { this.SetValue(SPARE_VLVProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Spare_V_OverlayName", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Spare_V_OverlayNameProperty); }
            set { this.SetValue(Overlay_Spare_V_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVLProperty); }
            set { this.SetValue(Overlay_Spare_V_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVL2Property); }
            set { this.SetValue(Overlay_Spare_V_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVL3Property); }
            set { this.SetValue(Overlay_Spare_V_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVL4Property); }
            set { this.SetValue(Overlay_Spare_V_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVL5Property); }
            set { this.SetValue(Overlay_Spare_V_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Spare_V_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Spare_V_BLKOVL6Property); }
            set { this.SetValue(Overlay_Spare_V_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVLProperty); }
            set { this.SetValue(Overlay_Spare_V_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVL2Property); }
            set { this.SetValue(Overlay_Spare_V_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVL3Property); }
            set { this.SetValue(Overlay_Spare_V_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVL4Property); }
            set { this.SetValue(Overlay_Spare_V_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVL5Property); }
            set { this.SetValue(Overlay_Spare_V_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Spare_V_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Spare_V_CMPOVL6Property); }
            set { this.SetValue(Overlay_Spare_V_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_DSCRPProperty =
            DependencyProperty.Register("Overlay_Spare_V_DSCRP", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Spare_V_DSCRPProperty); }
            set { this.SetValue(Overlay_Spare_V_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_LOCProperty =
            DependencyProperty.Register("Overlay_Spare_V_LOC", typeof(int), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Spare_V_LOC
        {
            get { return (int)this.GetValue(Overlay_Spare_V_LOCProperty); }
            set { this.SetValue(Overlay_Spare_V_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_PAROVLProperty =
            DependencyProperty.Register("Overlay_Spare_V_PAROVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Spare_V_PAROVLProperty); }
            set { this.SetValue(Overlay_Spare_V_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_PAROVL2Property =
            DependencyProperty.Register("Overlay_Spare_V_PAROVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_V_PAROVL2Property); }
            set { this.SetValue(Overlay_Spare_V_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_PAROVL3Property =
            DependencyProperty.Register("Overlay_Spare_V_PAROVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_V_PAROVL3Property); }
            set { this.SetValue(Overlay_Spare_V_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_PAROVL4Property =
            DependencyProperty.Register("Overlay_Spare_V_PAROVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_V_PAROVL4Property); }
            set { this.SetValue(Overlay_Spare_V_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_PRTProperty =
            DependencyProperty.Register("Overlay_Spare_V_PRT", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_PRT
        {
            get { return (string)this.GetValue(Overlay_Spare_V_PRTProperty); }
            set { this.SetValue(Overlay_Spare_V_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_V_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_V_TagnameProperty =
            DependencyProperty.Register("Overlay_Spare_V_Tagname", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_V_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_V_Tagname
        {
            get { return (string)this.GetValue(Overlay_Spare_V_TagnameProperty); }
            set { this.SetValue(Overlay_Spare_V_TagnameProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Spare_H_OverlayName", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Spare_H_OverlayNameProperty); }
            set { this.SetValue(Overlay_Spare_H_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVLProperty); }
            set { this.SetValue(Overlay_Spare_H_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVL2Property); }
            set { this.SetValue(Overlay_Spare_H_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVL3Property); }
            set { this.SetValue(Overlay_Spare_H_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVL4Property); }
            set { this.SetValue(Overlay_Spare_H_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVL5Property); }
            set { this.SetValue(Overlay_Spare_H_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Spare_H_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Spare_H_BLKOVL6Property); }
            set { this.SetValue(Overlay_Spare_H_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVLProperty); }
            set { this.SetValue(Overlay_Spare_H_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVL2Property); }
            set { this.SetValue(Overlay_Spare_H_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVL3Property); }
            set { this.SetValue(Overlay_Spare_H_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVL4Property); }
            set { this.SetValue(Overlay_Spare_H_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVL5Property); }
            set { this.SetValue(Overlay_Spare_H_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Spare_H_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Spare_H_CMPOVL6Property); }
            set { this.SetValue(Overlay_Spare_H_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_DSCRPProperty =
            DependencyProperty.Register("Overlay_Spare_H_DSCRP", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Spare_H_DSCRPProperty); }
            set { this.SetValue(Overlay_Spare_H_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_LOCProperty =
            DependencyProperty.Register("Overlay_Spare_H_LOC", typeof(int), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Spare_H_LOC
        {
            get { return (int)this.GetValue(Overlay_Spare_H_LOCProperty); }
            set { this.SetValue(Overlay_Spare_H_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_PAROVLProperty =
            DependencyProperty.Register("Overlay_Spare_H_PAROVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Spare_H_PAROVLProperty); }
            set { this.SetValue(Overlay_Spare_H_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_PAROVL2Property =
            DependencyProperty.Register("Overlay_Spare_H_PAROVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Spare_H_PAROVL2Property); }
            set { this.SetValue(Overlay_Spare_H_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_PAROVL3Property =
            DependencyProperty.Register("Overlay_Spare_H_PAROVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Spare_H_PAROVL3Property); }
            set { this.SetValue(Overlay_Spare_H_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_PAROVL4Property =
            DependencyProperty.Register("Overlay_Spare_H_PAROVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Spare_H_PAROVL4Property); }
            set { this.SetValue(Overlay_Spare_H_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_PRTProperty =
            DependencyProperty.Register("Overlay_Spare_H_PRT", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_PRT
        {
            get { return (string)this.GetValue(Overlay_Spare_H_PRTProperty); }
            set { this.SetValue(Overlay_Spare_H_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Spare_H_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Spare_H_TagnameProperty =
            DependencyProperty.Register("Overlay_Spare_H_Tagname", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Spare_H_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Spare_H_Tagname
        {
            get { return (string)this.GetValue(Overlay_Spare_H_TagnameProperty); }
            set { this.SetValue(Overlay_Spare_H_TagnameProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Normal_V_OverlayName", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Normal_V_OverlayNameProperty); }
            set { this.SetValue(Overlay_Normal_V_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVLProperty); }
            set { this.SetValue(Overlay_Normal_V_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVL2Property); }
            set { this.SetValue(Overlay_Normal_V_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVL3Property); }
            set { this.SetValue(Overlay_Normal_V_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVL4Property); }
            set { this.SetValue(Overlay_Normal_V_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVL5Property); }
            set { this.SetValue(Overlay_Normal_V_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Normal_V_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Normal_V_BLKOVL6Property); }
            set { this.SetValue(Overlay_Normal_V_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVLProperty); }
            set { this.SetValue(Overlay_Normal_V_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVL2Property); }
            set { this.SetValue(Overlay_Normal_V_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVL3Property); }
            set { this.SetValue(Overlay_Normal_V_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVL4Property); }
            set { this.SetValue(Overlay_Normal_V_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVL5Property); }
            set { this.SetValue(Overlay_Normal_V_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Normal_V_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Normal_V_CMPOVL6Property); }
            set { this.SetValue(Overlay_Normal_V_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_DSCRPProperty =
            DependencyProperty.Register("Overlay_Normal_V_DSCRP", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Normal_V_DSCRPProperty); }
            set { this.SetValue(Overlay_Normal_V_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_LOCProperty =
            DependencyProperty.Register("Overlay_Normal_V_LOC", typeof(int), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Normal_V_LOC
        {
            get { return (int)this.GetValue(Overlay_Normal_V_LOCProperty); }
            set { this.SetValue(Overlay_Normal_V_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_PAROVLProperty =
            DependencyProperty.Register("Overlay_Normal_V_PAROVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Normal_V_PAROVLProperty); }
            set { this.SetValue(Overlay_Normal_V_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_PAROVL2Property =
            DependencyProperty.Register("Overlay_Normal_V_PAROVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_V_PAROVL2Property); }
            set { this.SetValue(Overlay_Normal_V_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_PAROVL3Property =
            DependencyProperty.Register("Overlay_Normal_V_PAROVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_V_PAROVL3Property); }
            set { this.SetValue(Overlay_Normal_V_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_PAROVL4Property =
            DependencyProperty.Register("Overlay_Normal_V_PAROVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_V_PAROVL4Property); }
            set { this.SetValue(Overlay_Normal_V_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_PRTProperty =
            DependencyProperty.Register("Overlay_Normal_V_PRT", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_PRT
        {
            get { return (string)this.GetValue(Overlay_Normal_V_PRTProperty); }
            set { this.SetValue(Overlay_Normal_V_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_V_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_V_TagnameProperty =
            DependencyProperty.Register("Overlay_Normal_V_Tagname", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_V_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_V_Tagname
        {
            get { return (string)this.GetValue(Overlay_Normal_V_TagnameProperty); }
            set { this.SetValue(Overlay_Normal_V_TagnameProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Normal_H_OverlayName", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Normal_H_OverlayNameProperty); }
            set { this.SetValue(Overlay_Normal_H_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVLProperty); }
            set { this.SetValue(Overlay_Normal_H_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVL2Property); }
            set { this.SetValue(Overlay_Normal_H_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVL3Property); }
            set { this.SetValue(Overlay_Normal_H_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVL4Property); }
            set { this.SetValue(Overlay_Normal_H_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVL5Property); }
            set { this.SetValue(Overlay_Normal_H_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Normal_H_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Normal_H_BLKOVL6Property); }
            set { this.SetValue(Overlay_Normal_H_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVLProperty); }
            set { this.SetValue(Overlay_Normal_H_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVL2Property); }
            set { this.SetValue(Overlay_Normal_H_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVL3Property); }
            set { this.SetValue(Overlay_Normal_H_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVL4Property); }
            set { this.SetValue(Overlay_Normal_H_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVL5Property); }
            set { this.SetValue(Overlay_Normal_H_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Normal_H_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Normal_H_CMPOVL6Property); }
            set { this.SetValue(Overlay_Normal_H_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_DSCRPProperty =
            DependencyProperty.Register("Overlay_Normal_H_DSCRP", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Normal_H_DSCRPProperty); }
            set { this.SetValue(Overlay_Normal_H_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_LOCProperty =
            DependencyProperty.Register("Overlay_Normal_H_LOC", typeof(int), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Normal_H_LOC
        {
            get { return (int)this.GetValue(Overlay_Normal_H_LOCProperty); }
            set { this.SetValue(Overlay_Normal_H_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_PAROVLProperty =
            DependencyProperty.Register("Overlay_Normal_H_PAROVL", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Normal_H_PAROVLProperty); }
            set { this.SetValue(Overlay_Normal_H_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_PAROVL2Property =
            DependencyProperty.Register("Overlay_Normal_H_PAROVL2", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Normal_H_PAROVL2Property); }
            set { this.SetValue(Overlay_Normal_H_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_PAROVL3Property =
            DependencyProperty.Register("Overlay_Normal_H_PAROVL3", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Normal_H_PAROVL3Property); }
            set { this.SetValue(Overlay_Normal_H_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_PAROVL4Property =
            DependencyProperty.Register("Overlay_Normal_H_PAROVL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Normal_H_PAROVL4Property); }
            set { this.SetValue(Overlay_Normal_H_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_PRTProperty =
            DependencyProperty.Register("Overlay_Normal_H_PRT", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_PRT
        {
            get { return (string)this.GetValue(Overlay_Normal_H_PRTProperty); }
            set { this.SetValue(Overlay_Normal_H_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Normal_H_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Normal_H_TagnameProperty =
            DependencyProperty.Register("Overlay_Normal_H_Tagname", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the Overlay_Normal_H_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Normal_H_Tagname
        {
            get { return (string)this.GetValue(Overlay_Normal_H_TagnameProperty); }
            set { this.SetValue(Overlay_Normal_H_TagnameProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.CALCA)) yield return new Param("$CALCA", this.CALCA);
if (!string.IsNullOrWhiteSpace(this.SWCH)) yield return new Param("$SWCH", this.SWCH);
if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);
if (!string.IsNullOrWhiteSpace(this.ModelName)) yield return new Param("$ModelName", this.ModelName);

            }
        }

		
    }
}
