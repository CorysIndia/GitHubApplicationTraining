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
    public class SYM_CTRVLV_04 : RSIControlModel
    {
        static SYM_CTRVLV_04()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CTRVLV_04), new FrameworkPropertyMetadata(typeof(SYM_CTRVLV_04)));
        }

		public SYM_CTRVLV_04()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("_MA", typeof(bool), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_CTRVLV_04));

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
        /// BLK_CMD Property
        /// </summary>
        public static readonly DependencyProperty BLK_CMDProperty =
            DependencyProperty.Register("BLK_CMD", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the BLK_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_CMD
        {
            get { return (string)this.GetValue(BLK_CMDProperty); }
            set { this.SetValue(BLK_CMDProperty, value); }
        }

        /// <summary>
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_CTRVLV_04));

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
        /// BLK_FBK Property
        /// </summary>
        public static readonly DependencyProperty BLK_FBKProperty =
            DependencyProperty.Register("BLK_FBK", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the BLK_FBK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_FBK
        {
            get { return (string)this.GetValue(BLK_FBKProperty); }
            set { this.SetValue(BLK_FBKProperty, value); }
        }

        /// <summary>
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_CTRVLV_04));

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
        /// VLV_POS Property
        /// </summary>
        public static readonly DependencyProperty VLV_POSProperty =
            DependencyProperty.Register("VLV_POS", typeof(string), typeof(SYM_CTRVLV_04));

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
        /// LABEL4 Property
        /// </summary>
        public static readonly DependencyProperty LABEL4Property =
            DependencyProperty.Register("LABEL4", typeof(string), typeof(SYM_CTRVLV_01));

        /// <summary>
        /// Gets or sets the LABEL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABEL4
        {
            get { return (string)this.GetValue(LABEL4Property); }
            set { this.SetValue(LABEL4Property, value); }
        }


        /// <summary>
        /// TAG_VERT Property
        /// </summary>
        public static readonly DependencyProperty TAG_VERTProperty =
            DependencyProperty.Register("TAG_VERT", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("HORZ_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("VERT_L_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_04));

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
            DependencyProperty.Register("VERT_R_OUTVALUE", typeof(string), typeof(SYM_CTRVLV_04));

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
        /// Overlay_Vertical_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Vertical_OverlayName", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Vertical_OverlayNameProperty); }
            set { this.SetValue(Overlay_Vertical_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVLProperty); }
            set { this.SetValue(Overlay_Vertical_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVL2Property); }
            set { this.SetValue(Overlay_Vertical_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVL3Property); }
            set { this.SetValue(Overlay_Vertical_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVL4Property); }
            set { this.SetValue(Overlay_Vertical_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVL5Property); }
            set { this.SetValue(Overlay_Vertical_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Vertical_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Vertical_BLKOVL6Property); }
            set { this.SetValue(Overlay_Vertical_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVLProperty); }
            set { this.SetValue(Overlay_Vertical_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVL2Property); }
            set { this.SetValue(Overlay_Vertical_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVL3Property); }
            set { this.SetValue(Overlay_Vertical_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVL4Property); }
            set { this.SetValue(Overlay_Vertical_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVL5Property); }
            set { this.SetValue(Overlay_Vertical_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Vertical_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Vertical_CMPOVL6Property); }
            set { this.SetValue(Overlay_Vertical_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_DSCRPProperty =
            DependencyProperty.Register("Overlay_Vertical_DSCRP", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Vertical_DSCRPProperty); }
            set { this.SetValue(Overlay_Vertical_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_LOCProperty =
            DependencyProperty.Register("Overlay_Vertical_LOC", typeof(int), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Vertical_LOC
        {
            get { return (int)this.GetValue(Overlay_Vertical_LOCProperty); }
            set { this.SetValue(Overlay_Vertical_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_PAROVLProperty =
            DependencyProperty.Register("Overlay_Vertical_PAROVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Vertical_PAROVLProperty); }
            set { this.SetValue(Overlay_Vertical_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_PAROVL2Property =
            DependencyProperty.Register("Overlay_Vertical_PAROVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Vertical_PAROVL2Property); }
            set { this.SetValue(Overlay_Vertical_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_PAROVL3Property =
            DependencyProperty.Register("Overlay_Vertical_PAROVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Vertical_PAROVL3Property); }
            set { this.SetValue(Overlay_Vertical_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_PAROVL4Property =
            DependencyProperty.Register("Overlay_Vertical_PAROVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Vertical_PAROVL4Property); }
            set { this.SetValue(Overlay_Vertical_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Vertical_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_PRTProperty =
            DependencyProperty.Register("Overlay_Vertical_PRT", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_PRT
        {
            get { return (string)this.GetValue(Overlay_Vertical_PRTProperty); }
            set { this.SetValue(Overlay_Vertical_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Vertical_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Vertical_TagnameProperty =
            DependencyProperty.Register("Overlay_Vertical_Tagname", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Vertical_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Vertical_Tagname
        {
            get { return (string)this.GetValue(Overlay_Vertical_TagnameProperty); }
            set { this.SetValue(Overlay_Vertical_TagnameProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_OverlayNameProperty =
            DependencyProperty.Register("Overlay_Horizontal_OverlayName", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_OverlayName
        {
            get { return (string)this.GetValue(Overlay_Horizontal_OverlayNameProperty); }
            set { this.SetValue(Overlay_Horizontal_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVLProperty =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVLProperty); }
            set { this.SetValue(Overlay_Horizontal_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVL2Property =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVL2Property); }
            set { this.SetValue(Overlay_Horizontal_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVL3Property =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVL3Property); }
            set { this.SetValue(Overlay_Horizontal_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVL4Property =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVL4Property); }
            set { this.SetValue(Overlay_Horizontal_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVL5Property =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL5", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVL5Property); }
            set { this.SetValue(Overlay_Horizontal_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_BLKOVL6Property =
            DependencyProperty.Register("Overlay_Horizontal_BLKOVL6", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_Horizontal_BLKOVL6Property); }
            set { this.SetValue(Overlay_Horizontal_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVLProperty =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVLProperty); }
            set { this.SetValue(Overlay_Horizontal_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVL2Property =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVL2Property); }
            set { this.SetValue(Overlay_Horizontal_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVL3Property =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVL3Property); }
            set { this.SetValue(Overlay_Horizontal_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVL4Property =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVL4Property); }
            set { this.SetValue(Overlay_Horizontal_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVL5Property =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL5", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVL5Property); }
            set { this.SetValue(Overlay_Horizontal_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_CMPOVL6Property =
            DependencyProperty.Register("Overlay_Horizontal_CMPOVL6", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_Horizontal_CMPOVL6Property); }
            set { this.SetValue(Overlay_Horizontal_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_DSCRPProperty =
            DependencyProperty.Register("Overlay_Horizontal_DSCRP", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_DSCRP
        {
            get { return (string)this.GetValue(Overlay_Horizontal_DSCRPProperty); }
            set { this.SetValue(Overlay_Horizontal_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_LOCProperty =
            DependencyProperty.Register("Overlay_Horizontal_LOC", typeof(int), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_Horizontal_LOC
        {
            get { return (int)this.GetValue(Overlay_Horizontal_LOCProperty); }
            set { this.SetValue(Overlay_Horizontal_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_PAROVLProperty =
            DependencyProperty.Register("Overlay_Horizontal_PAROVL", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_PAROVL
        {
            get { return (string)this.GetValue(Overlay_Horizontal_PAROVLProperty); }
            set { this.SetValue(Overlay_Horizontal_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_PAROVL2Property =
            DependencyProperty.Register("Overlay_Horizontal_PAROVL2", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_Horizontal_PAROVL2Property); }
            set { this.SetValue(Overlay_Horizontal_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_PAROVL3Property =
            DependencyProperty.Register("Overlay_Horizontal_PAROVL3", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_Horizontal_PAROVL3Property); }
            set { this.SetValue(Overlay_Horizontal_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_PAROVL4Property =
            DependencyProperty.Register("Overlay_Horizontal_PAROVL4", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_Horizontal_PAROVL4Property); }
            set { this.SetValue(Overlay_Horizontal_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_PRTProperty =
            DependencyProperty.Register("Overlay_Horizontal_PRT", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_PRT
        {
            get { return (string)this.GetValue(Overlay_Horizontal_PRTProperty); }
            set { this.SetValue(Overlay_Horizontal_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Horizontal_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_Horizontal_TagnameProperty =
            DependencyProperty.Register("Overlay_Horizontal_Tagname", typeof(string), typeof(SYM_CTRVLV_04));

        /// <summary>
        /// Gets or sets the Overlay_Horizontal_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Horizontal_Tagname
        {
            get { return (string)this.GetValue(Overlay_Horizontal_TagnameProperty); }
            set { this.SetValue(Overlay_Horizontal_TagnameProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK_CMD)) yield return new Param("$BLK_CMD", this.BLK_CMD);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.BLK_FBK)) yield return new Param("$BLK_FBK", this.BLK_FBK);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LABEL4)) yield return new Param("$LABEL4", this.LABEL4);
if (!string.IsNullOrWhiteSpace(this.ModelName)) yield return new Param("$ModelName", this.ModelName);
            }
        }

		
    }
}
