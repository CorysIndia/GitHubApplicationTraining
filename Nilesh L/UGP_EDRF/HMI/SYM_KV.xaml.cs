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
    public class SYM_KV : RSIControlModel
    {
        static SYM_KV()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_KV), new FrameworkPropertyMetadata(typeof(SYM_KV)));
        }

		public SYM_KV()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_KV));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_KV));

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
        //START
        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_KV));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_KV));

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
        /// _STAIND Property
        /// </summary>
        public static readonly DependencyProperty _STAINDProperty =
            DependencyProperty.Register("_STAIND", typeof(int), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the _STAIND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _STAIND
        {
            get { return (int)this.GetValue(_STAINDProperty); }
            set { this.SetValue(_STAINDProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_KV));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_KV));

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
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_KV));

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
            DependencyProperty.Register("VLV_ID", typeof(string), typeof(SYM_KV));

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
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_KV));

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
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_KV));

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
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_KV));

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
            DependencyProperty.Register("MISMATCH_CB", typeof(string), typeof(SYM_KV));

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
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_KV));

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
        /// FP_CallOverlay1_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay1_OverlayName", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay1_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay1_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay1_Tagname", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay1_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay1_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay1_LOC", typeof(int), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay1_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay1_LOCProperty); }
            set { this.SetValue(FP_CallOverlay1_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL2", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL3", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL4", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL5", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL6", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL2", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL3", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL4", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay1_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL2", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL3", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay1_PRT", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PRTProperty); }
            set { this.SetValue(FP_CallOverlay1_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL4", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL5", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay1_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL6", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay1_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay1_DSCRP", typeof(string), typeof(SYM_KV));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay1_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay1_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay1_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.VLV_ID)) yield return new Param("$VLV_ID", this.VLV_ID);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);
if (!string.IsNullOrWhiteSpace(this.MISMATCH_CB)) yield return new Param("$MISMATCH_CB", this.MISMATCH_CB);

            }
        }

		
    }
}
