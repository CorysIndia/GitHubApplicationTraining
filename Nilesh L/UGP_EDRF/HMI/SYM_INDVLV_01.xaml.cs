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
    public class SYM_INDVLV_01 : RSIControlModel
    {
        static SYM_INDVLV_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_INDVLV_01), new FrameworkPropertyMetadata(typeof(SYM_INDVLV_01)));
        }

		public SYM_INDVLV_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_INDVLV_01));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_INDVLV_01));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_INDVLV_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_INDVLV_01));

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
        /// _CIN Property
        /// </summary>
        public static readonly DependencyProperty _CINProperty =
            DependencyProperty.Register("_CIN", typeof(bool), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the _CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CIN
        {
            get { return (bool)this.GetValue(_CINProperty); }
            set { this.SetValue(_CINProperty, value); }
        }

        /// <summary>
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_INDVLV_01));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_INDVLV_01));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_INDVLV_01));

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

        //START
        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_INDVLV_01));

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
        /// BLK_ALM Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALMProperty =
            DependencyProperty.Register("BLK_ALM", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the BLK_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM
        {
            get { return (string)this.GetValue(BLK_ALMProperty); }
            set { this.SetValue(BLK_ALMProperty, value); }
        }

        /// <summary>
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the Orientation.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Orientation
        {
            get { return (string)this.GetValue(OrientationProperty); }
            set { this.SetValue(OrientationProperty, value); }
        }

        /// <summary>
        /// Energized Property
        /// </summary>
        public static readonly DependencyProperty EnergizedProperty =
            DependencyProperty.Register("Energized", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the Energized.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Energized
        {
            get { return (string)this.GetValue(EnergizedProperty); }
            set { this.SetValue(EnergizedProperty, value); }
        }

        /// <summary>
        /// FAIL Property
        /// </summary>
        public static readonly DependencyProperty FAILProperty =
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_INDVLV_01));

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
        /// HEAD Property
        /// </summary>
        public static readonly DependencyProperty HEADProperty =
            DependencyProperty.Register("HEAD", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the HEAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HEAD
        {
            get { return (string)this.GetValue(HEADProperty); }
            set { this.SetValue(HEADProperty, value); }
        }

        /// <summary>
        /// Mismatch Property
        /// </summary>
        public static readonly DependencyProperty MismatchProperty =
            DependencyProperty.Register("Mismatch", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the Mismatch.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Mismatch
        {
            get { return (string)this.GetValue(MismatchProperty); }
            set { this.SetValue(MismatchProperty, value); }
        }

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the ACK_SYMBOL1_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_SYMBOL1_UNACK_1
        {
            get { return (string)this.GetValue(ACK_SYMBOL1_UNACK_1Property); }
            set { this.SetValue(ACK_SYMBOL1_UNACK_1Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_OverlayName", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_Tagname", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_LOC", typeof(int), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL2", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL3", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL4", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL5", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_BLKOVL6", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL2", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL3", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL4", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_PAROVL", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_PAROVL2", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_PAROVL3", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_PRT", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL5", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_CMPOVL6", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_DSCRP", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_DSCRPProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_PAROVL4", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 4")]
        public string CALLOVERLAY_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_PAROVL4Property, value); }
        }

        /// <summary>
        /// MISMATCH_HORZ_NOHEAD_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_HORZ_NOHEAD_CBProperty =
            DependencyProperty.Register("MISMATCH_HORZ_NOHEAD_CB", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the MISMATCH_HORZ_NOHEAD_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MISMATCH_HORZ_NOHEAD_CB
        {
            get { return (string)this.GetValue(MISMATCH_HORZ_NOHEAD_CBProperty); }
            set { this.SetValue(MISMATCH_HORZ_NOHEAD_CBProperty, value); }
        }

        /// <summary>
        /// MISMATCH_VERT_NOHEAD_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_VERT_NOHEAD_CBProperty =
            DependencyProperty.Register("MISMATCH_VERT_NOHEAD_CB", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the MISMATCH_VERT_NOHEAD_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MISMATCH_VERT_NOHEAD_CB
        {
            get { return (string)this.GetValue(MISMATCH_VERT_NOHEAD_CBProperty); }
            set { this.SetValue(MISMATCH_VERT_NOHEAD_CBProperty, value); }
        }

        /// <summary>
        /// MISMATCH_VERT_HEAD_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_VERT_HEAD_CBProperty =
            DependencyProperty.Register("MISMATCH_VERT_HEAD_CB", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the MISMATCH_VERT_HEAD_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MISMATCH_VERT_HEAD_CB
        {
            get { return (string)this.GetValue(MISMATCH_VERT_HEAD_CBProperty); }
            set { this.SetValue(MISMATCH_VERT_HEAD_CBProperty, value); }
        }

        /// <summary>
        /// MISMATCH_HORZ_HEAD_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_HORZ_HEAD_CBProperty =
            DependencyProperty.Register("MISMATCH_HORZ_HEAD_CB", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the MISMATCH_HORZ_HEAD_CB.  
        /// </summary>
       
        
		[Category("RSI")]
        [Description(@"")]
        public string MISMATCH_HORZ_HEAD_CB
        {
            get { return (string)this.GetValue(MISMATCH_HORZ_HEAD_CBProperty); }
            set { this.SetValue(MISMATCH_HORZ_HEAD_CBProperty, value); }
        }
        //START

        /// <summary>
        /// MISMATCH_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_CBProperty =
            DependencyProperty.Register("MISMATCH_CB", typeof(string), typeof(SYM_INDVLV_01));

        /// <summary>
        /// Gets or sets the MISMATCH_CB.  
        /// </summary>


        [Category("RSI")]
        [Description(@"")]
        public string MISMATCH_CB
        {
            get { return (string)this.GetValue(MISMATCH_CBProperty); }
            set { this.SetValue(MISMATCH_CBProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.BLK_ALM)) yield return new Param("$BLK_ALM", this.BLK_ALM);
if (!string.IsNullOrWhiteSpace(this.Mismatch)) yield return new Param("$Mismatch", this.Mismatch);
if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_CB)) yield return new Param("$MISMATCH_CB", this.MISMATCH_CB);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_HORZ_HEAD_CB)) yield return new Param("$MISMATCH_HORZ_HEAD_CB", this.MISMATCH_HORZ_HEAD_CB);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_HORZ_NOHEAD_CB)) yield return new Param("$MISMATCH_HORZ_NOHEAD_CB", this.MISMATCH_HORZ_NOHEAD_CB);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_VERT_HEAD_CB)) yield return new Param("$MISMATCH_VERT_HEAD_CB", this.MISMATCH_VERT_HEAD_CB);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_VERT_NOHEAD_CB)) yield return new Param("$MISMATCH_VERT_NOHEAD_CB", this.MISMATCH_VERT_NOHEAD_CB);

            }
        }

		
    }
}
