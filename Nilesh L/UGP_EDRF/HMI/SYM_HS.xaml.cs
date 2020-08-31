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
    public class SYM_HS : RSIControlModel
    {
        static SYM_HS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_HS), new FrameworkPropertyMetadata(typeof(SYM_HS)));
        }

		public SYM_HS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_HS));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_HS));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR
        {
            get { return (string)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// FP_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_NAMEProperty =
            DependencyProperty.Register("FP_NAME", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the FP_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_NAME
        {
            get { return (string)this.GetValue(FP_NAMEProperty); }
            set { this.SetValue(FP_NAMEProperty, value); }
        }

        /// <summary>
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_HS));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_HS));

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
        /// LOOPID Property
        /// </summary>
        public static readonly DependencyProperty LOOPIDProperty =
            DependencyProperty.Register("LOOPID", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the LOOPID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOOPID
        {
            get { return (string)this.GetValue(LOOPIDProperty); }
            set { this.SetValue(LOOPIDProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_HS));

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
        /// BLKA_FB Property
        /// </summary>
        public static readonly DependencyProperty BLKA_FBProperty =
            DependencyProperty.Register("BLKA_FB", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the BLKA_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKA_FB
        {
            get { return (string)this.GetValue(BLKA_FBProperty); }
            set { this.SetValue(BLKA_FBProperty, value); }
        }

        /// <summary>
        /// BLKB_FB Property
        /// </summary>
        public static readonly DependencyProperty BLKB_FBProperty =
            DependencyProperty.Register("BLKB_FB", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the BLKB_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKB_FB
        {
            get { return (string)this.GetValue(BLKB_FBProperty); }
            set { this.SetValue(BLKB_FBProperty, value); }
        }

        /// <summary>
        /// TEXT0 Property
        /// </summary>
        public static readonly DependencyProperty TEXT0Property =
            DependencyProperty.Register("TEXT0", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the TEXT0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT0
        {
            get { return (string)this.GetValue(TEXT0Property); }
            set { this.SetValue(TEXT0Property, value); }
        }

        /// <summary>
        /// TEXT1 Property
        /// </summary>
        public static readonly DependencyProperty TEXT1Property =
            DependencyProperty.Register("TEXT1", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the TEXT1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT1
        {
            get { return (string)this.GetValue(TEXT1Property); }
            set { this.SetValue(TEXT1Property, value); }
        }

        /// <summary>
        /// _PAR Property
        /// </summary>
        public static readonly DependencyProperty _PARProperty =
            DependencyProperty.Register("_PAR", typeof(bool), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the _PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _PAR
        {
            get { return (bool)this.GetValue(_PARProperty); }
            set { this.SetValue(_PARProperty, value); }
        }

        /// <summary>
        /// PAR2 Property
        /// </summary>
        public static readonly DependencyProperty PAR2Property =
            DependencyProperty.Register("PAR2", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the PAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR2
        {
            get { return (string)this.GetValue(PAR2Property); }
            set { this.SetValue(PAR2Property, value); }
        }

        /// <summary>
        /// FP_TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty FP_TAGNAMEProperty =
            DependencyProperty.Register("FP_TAGNAME", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the FP_TAGNAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_TAGNAME
        {
            get { return (string)this.GetValue(FP_TAGNAMEProperty); }
            set { this.SetValue(FP_TAGNAMEProperty, value); }
        }

        /// <summary>
        /// PAR_FB Property
        /// </summary>
        public static readonly DependencyProperty PAR_FBProperty =
            DependencyProperty.Register("PAR_FB", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the PAR_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR_FB
        {
            get { return (string)this.GetValue(PAR_FBProperty); }
            set { this.SetValue(PAR_FBProperty, value); }
        }

        /// <summary>
        /// FB Property
        /// </summary>
        public static readonly DependencyProperty FBProperty =
            DependencyProperty.Register("FB", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FB
        {
            get { return (string)this.GetValue(FBProperty); }
            set { this.SetValue(FBProperty, value); }
        }

        /// <summary>
        /// Variable_Text Property
        /// </summary>
        public static readonly DependencyProperty Variable_TextProperty =
            DependencyProperty.Register("Variable_Text", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the Variable_Text.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Variable_Text
        {
            get { return (string)this.GetValue(Variable_TextProperty); }
            set { this.SetValue(Variable_TextProperty, value); }
        }

        /// <summary>
        /// CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_OverlayName", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_Tagname", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_LOC", typeof(int), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL2", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL3", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL4", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL5", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_BLKOVL6", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_CMPOVL", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_CMPOVL2", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_CMPOVL3", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_CMPOVL4", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_PAROVL", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_PAROVL2", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_PAROVL3", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_PRT", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_PAROVL4", typeof(string), typeof(SYM_HS));

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
        /// CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DSCRP", typeof(string), typeof(SYM_HS));

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

        /// <summary>
        /// CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_CMPOVL6", typeof(string), typeof(SYM_HS));

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
            DependencyProperty.Register("CallOverlay_CMPOVL5", typeof(string), typeof(SYM_HS));

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
        /// CallOverlayFB_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_OverlayNameProperty =
            DependencyProperty.Register("CallOverlayFB_OverlayName", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_OverlayName
        {
            get { return (string)this.GetValue(CallOverlayFB_OverlayNameProperty); }
            set { this.SetValue(CallOverlayFB_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_TagnameProperty =
            DependencyProperty.Register("CallOverlayFB_Tagname", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_Tagname
        {
            get { return (string)this.GetValue(CallOverlayFB_TagnameProperty); }
            set { this.SetValue(CallOverlayFB_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_LOCProperty =
            DependencyProperty.Register("CallOverlayFB_LOC", typeof(int), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlayFB_LOC
        {
            get { return (int)this.GetValue(CallOverlayFB_LOCProperty); }
            set { this.SetValue(CallOverlayFB_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVLProperty =
            DependencyProperty.Register("CallOverlayFB_BLKOVL", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVLProperty); }
            set { this.SetValue(CallOverlayFB_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVL2Property =
            DependencyProperty.Register("CallOverlayFB_BLKOVL2", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVL2Property); }
            set { this.SetValue(CallOverlayFB_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVL3Property =
            DependencyProperty.Register("CallOverlayFB_BLKOVL3", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVL3Property); }
            set { this.SetValue(CallOverlayFB_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVL4Property =
            DependencyProperty.Register("CallOverlayFB_BLKOVL4", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVL4Property); }
            set { this.SetValue(CallOverlayFB_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVL5Property =
            DependencyProperty.Register("CallOverlayFB_BLKOVL5", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVL5Property); }
            set { this.SetValue(CallOverlayFB_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_BLKOVL6Property =
            DependencyProperty.Register("CallOverlayFB_BLKOVL6", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlayFB_BLKOVL6Property); }
            set { this.SetValue(CallOverlayFB_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVLProperty =
            DependencyProperty.Register("CallOverlayFB_CMPOVL", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVLProperty); }
            set { this.SetValue(CallOverlayFB_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVL2Property =
            DependencyProperty.Register("CallOverlayFB_CMPOVL2", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVL2Property); }
            set { this.SetValue(CallOverlayFB_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVL3Property =
            DependencyProperty.Register("CallOverlayFB_CMPOVL3", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVL3Property); }
            set { this.SetValue(CallOverlayFB_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVL4Property =
            DependencyProperty.Register("CallOverlayFB_CMPOVL4", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVL4Property); }
            set { this.SetValue(CallOverlayFB_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_PAROVLProperty =
            DependencyProperty.Register("CallOverlayFB_PAROVL", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_PAROVL
        {
            get { return (string)this.GetValue(CallOverlayFB_PAROVLProperty); }
            set { this.SetValue(CallOverlayFB_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_PAROVL2Property =
            DependencyProperty.Register("CallOverlayFB_PAROVL2", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlayFB_PAROVL2Property); }
            set { this.SetValue(CallOverlayFB_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_PAROVL3Property =
            DependencyProperty.Register("CallOverlayFB_PAROVL3", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlayFB_PAROVL3Property); }
            set { this.SetValue(CallOverlayFB_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_PRTProperty =
            DependencyProperty.Register("CallOverlayFB_PRT", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_PRT
        {
            get { return (string)this.GetValue(CallOverlayFB_PRTProperty); }
            set { this.SetValue(CallOverlayFB_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_PAROVL4Property =
            DependencyProperty.Register("CallOverlayFB_PAROVL4", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayFB_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlayFB_PAROVL4Property); }
            set { this.SetValue(CallOverlayFB_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_DSCRPProperty =
            DependencyProperty.Register("CallOverlayFB_DSCRP", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlayFB_DSCRP
        {
            get { return (string)this.GetValue(CallOverlayFB_DSCRPProperty); }
            set { this.SetValue(CallOverlayFB_DSCRPProperty, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVL6Property =
            DependencyProperty.Register("CallOverlayFB_CMPOVL6", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlayFB_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVL6Property); }
            set { this.SetValue(CallOverlayFB_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayFB_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayFB_CMPOVL5Property =
            DependencyProperty.Register("CallOverlayFB_CMPOVL5", typeof(string), typeof(SYM_HS));

        /// <summary>
        /// Gets or sets the CallOverlayFB_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlayFB_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlayFB_CMPOVL5Property); }
            set { this.SetValue(CallOverlayFB_CMPOVL5Property, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
if (!string.IsNullOrWhiteSpace(this.FP_NAME)) yield return new Param("$FP_NAME", this.FP_NAME);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.LOOPID)) yield return new Param("$LOOPID", this.LOOPID);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.BLKA_FB)) yield return new Param("$BLKA_FB", this.BLKA_FB);
if (!string.IsNullOrWhiteSpace(this.BLKB_FB)) yield return new Param("$BLKB_FB", this.BLKB_FB);
if (!string.IsNullOrWhiteSpace(this.TEXT0)) yield return new Param("$TEXT0", this.TEXT0);
if (!string.IsNullOrWhiteSpace(this.TEXT1)) yield return new Param("$TEXT1", this.TEXT1);
if (!string.IsNullOrWhiteSpace(this.PAR2)) yield return new Param("$PAR2", this.PAR2);
if (!string.IsNullOrWhiteSpace(this.FP_TAGNAME)) yield return new Param("$FP_TAGNAME", this.FP_TAGNAME);
if (!string.IsNullOrWhiteSpace(this.PAR_FB)) yield return new Param("$PAR_FB", this.PAR_FB);

            }
        }

		
    }
}
