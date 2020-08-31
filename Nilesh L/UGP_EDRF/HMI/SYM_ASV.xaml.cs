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
    public class SYM_ASV : RSIControlModel
    {
        static SYM_ASV()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ASV), new FrameworkPropertyMetadata(typeof(SYM_ASV)));
        }

		public SYM_ASV()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ASV));

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
        /// CMP_ESD Property
        /// </summary>
        public static readonly DependencyProperty CMP_ESDProperty =
            DependencyProperty.Register("CMP_ESD", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CMP_ESD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_ESD
        {
            get { return (string)this.GetValue(CMP_ESDProperty); }
            set { this.SetValue(CMP_ESDProperty, value); }
        }

        /// <summary>
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_ASV));

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

        //////////////////////////

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(SYM_ASV));

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




        //////////////////////




        /// <summary>
        /// _ALARM Property
        /// </summary>
        public static readonly DependencyProperty _ALARMProperty =
            DependencyProperty.Register("_ALARM", typeof(bool), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the _ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _ALARM
        {
            get { return (bool)this.GetValue(_ALARMProperty); }
            set { this.SetValue(_ALARMProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_ASV));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_ASV));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_ASV));

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
        /// VLV_ID Property
        /// </summary>
        public static readonly DependencyProperty VLV_IDProperty =
            DependencyProperty.Register("VLV_ID", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the VLV_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VLV_ID
        {
            get { return (string)this.GetValue(VLV_IDProperty); }
            set { this.SetValue(VLV_IDProperty, value); }
        }

        /// <summary>
        /// FXA_BLK Property
        /// </summary>
        public static readonly DependencyProperty FXA_BLKProperty =
            DependencyProperty.Register("FXA_BLK", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the FXA_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FXA_BLK
        {
            get { return (string)this.GetValue(FXA_BLKProperty); }
            set { this.SetValue(FXA_BLKProperty, value); }
        }

        /// <summary>
        /// FV_BLK Property
        /// </summary>
        public static readonly DependencyProperty FV_BLKProperty =
            DependencyProperty.Register("FV_BLK", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the FV_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FV_BLK
        {
            get { return (string)this.GetValue(FV_BLKProperty); }
            set { this.SetValue(FV_BLKProperty, value); }
        }

        /// <summary>
        /// CMP_CCS Property
        /// </summary>
        public static readonly DependencyProperty CMP_CCSProperty =
            DependencyProperty.Register("CMP_CCS", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CMP_CCS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_CCS
        {
            get { return (string)this.GetValue(CMP_CCSProperty); }
            set { this.SetValue(CMP_CCSProperty, value); }
        }

        /// <summary>
        /// BLK_CCS Property
        /// </summary>
        public static readonly DependencyProperty BLK_CCSProperty =
            DependencyProperty.Register("BLK_CCS", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the BLK_CCS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_CCS
        {
            get { return (string)this.GetValue(BLK_CCSProperty); }
            set { this.SetValue(BLK_CCSProperty, value); }
        }

        /// <summary>
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_ASV));

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
        /// FXY_BLK Property
        /// </summary>
        public static readonly DependencyProperty FXY_BLKProperty =
            DependencyProperty.Register("FXY_BLK", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the FXY_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FXY_BLK
        {
            get { return (string)this.GetValue(FXY_BLKProperty); }
            set { this.SetValue(FXY_BLKProperty, value); }
        }

        /// <summary>
        /// _TRIP Property
        /// </summary>
        public static readonly DependencyProperty _TRIPProperty =
            DependencyProperty.Register("_TRIP", typeof(bool), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the _TRIP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _TRIP
        {
            get { return (bool)this.GetValue(_TRIPProperty); }
            set { this.SetValue(_TRIPProperty, value); }
        }

        /// <summary>
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_ASV));

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
        /// FAIL Property
        /// </summary>
        public static readonly DependencyProperty FAILProperty =
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_ASV));

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
        /// MISMATCH_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_CBProperty =
            DependencyProperty.Register("MISMATCH_CB", typeof(string), typeof(SYM_ASV));

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

        /// <summary>
        /// ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ACK_SYMBOL_UNACK_1Property, value); }
        }

        /// <summary>
        /// CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_OverlayName", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_TagnameProperty =
            DependencyProperty.Register("CallOverlay_Tagname", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_TagnameProperty); }
            set { this.SetValue(CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_LOCProperty =
            DependencyProperty.Register("CallOverlay_LOC", typeof(int), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_LOC
        {
            get { return (int)this.GetValue(CallOverlay_LOCProperty); }
            set { this.SetValue(CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_BLKOVL", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_BLKOVL2", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_BLKOVL3", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_BLKOVL4", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_BLKOVL5", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_BLKOVL6", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_CMPOVL", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_CMPOVL2", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_CMPOVL3", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_CMPOVL4", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_PAROVL", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_PAROVLProperty); }
            set { this.SetValue(CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_PAROVL2", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL2Property); }
            set { this.SetValue(CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_PAROVL3", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL3Property); }
            set { this.SetValue(CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PRTProperty =
            DependencyProperty.Register("CallOverlay_PRT", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PRT
        {
            get { return (string)this.GetValue(CallOverlay_PRTProperty); }
            set { this.SetValue(CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_PAROVL4", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL4Property); }
            set { this.SetValue(CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_CMPOVL6", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_CMPOVL5", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DSCRP", typeof(string), typeof(SYM_ASV));

        /// <summary>
        /// Gets or sets the CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_DSCRPProperty); }
            set { this.SetValue(CallOverlay_DSCRPProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP_ESD)) yield return new Param("$CMP_ESD", this.CMP_ESD);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.VLV_ID)) yield return new Param("$VLV_ID", this.VLV_ID);
if (!string.IsNullOrWhiteSpace(this.FXA_BLK)) yield return new Param("$FXA_BLK", this.FXA_BLK);
if (!string.IsNullOrWhiteSpace(this.FV_BLK)) yield return new Param("$FV_BLK", this.FV_BLK);
if (!string.IsNullOrWhiteSpace(this.CMP_CCS)) yield return new Param("$CMP_CCS", this.CMP_CCS);
if (!string.IsNullOrWhiteSpace(this.BLK_CCS)) yield return new Param("$BLK_CCS", this.BLK_CCS);
if (!string.IsNullOrWhiteSpace(this.FXY_BLK)) yield return new Param("$FXY_BLK", this.FXY_BLK);
                if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);

            }
        }

		
    }
}
