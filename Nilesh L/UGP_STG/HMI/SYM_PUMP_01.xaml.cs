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
    public class SYM_PUMP_01 : RSIControlModel
    {
        static SYM_PUMP_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_PUMP_01), new FrameworkPropertyMetadata(typeof(SYM_PUMP_01)));
        }

		public SYM_PUMP_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_PUMP_01));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_PUMP_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_PUMP_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_PUMP_01));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_PUMP_01));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_PUMP_01));

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
        /// FAULT Property
        /// </summary>
        public static readonly DependencyProperty FAULTProperty =
            DependencyProperty.Register("FAULT", typeof(bool), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the FAULT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FAULT
        {
            get { return (bool)this.GetValue(FAULTProperty); }
            set { this.SetValue(FAULTProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_PUMP_01));

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
        /// LR Property
        /// </summary>
        public static readonly DependencyProperty LRProperty =
            DependencyProperty.Register("LR", typeof(bool), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the LR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LR
        {
            get { return (bool)this.GetValue(LRProperty); }
            set { this.SetValue(LRProperty, value); }
        }

        /// <summary>
        /// CALCA Property
        /// </summary>
        public static readonly DependencyProperty CALCAProperty =
            DependencyProperty.Register("CALCA", typeof(string), typeof(SYM_PUMP_01));

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
        /// FB Property
        /// </summary>
        public static readonly DependencyProperty FBProperty =
            DependencyProperty.Register("FB", typeof(bool), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FB
        {
            get { return (bool)this.GetValue(FBProperty); }
            set { this.SetValue(FBProperty, value); }
        }

        /// <summary>
        /// DS Property
        /// </summary>
        public static readonly DependencyProperty DSProperty =
            DependencyProperty.Register("DS", typeof(bool), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the DS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DS
        {
            get { return (bool)this.GetValue(DSProperty); }
            set { this.SetValue(DSProperty, value); }
        }

        /// <summary>
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_PUMP_01));

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
        /// Label Property
        /// </summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the Label.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Label
        {
            get { return (string)this.GetValue(LabelProperty); }
            set { this.SetValue(LabelProperty, value); }
        }

        ///Start
        /// <summary>
        /// LABEL_Des Property
        /// </summary>
        public static readonly DependencyProperty LABEL_DesProperty =
            DependencyProperty.Register("LABEL_Des", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the LABEL_Des.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABEL_Des
        {
            get { return (string)this.GetValue(LABEL_DesProperty); }
            set { this.SetValue(LABEL_DesProperty, value); }
        }

        /// <summary>
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the MA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MA
        {
            get { return (string)this.GetValue(MAProperty); }
            set { this.SetValue(MAProperty, value); }
        }

        /// <summary>
        /// DUTY Property
        /// </summary>
        public static readonly DependencyProperty DUTYProperty =
            DependencyProperty.Register("DUTY", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the DUTY.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DUTY
        {
            get { return (string)this.GetValue(DUTYProperty); }
            set { this.SetValue(DUTYProperty, value); }
        }

        /// <summary>
        /// TRIP Property
        /// </summary>
        public static readonly DependencyProperty TRIPProperty =
            DependencyProperty.Register("TRIP", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the TRIP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TRIP
        {
            get { return (string)this.GetValue(TRIPProperty); }
            set { this.SetValue(TRIPProperty, value); }
        }

        /// <summary>
        /// RESET Property
        /// </summary>
        public static readonly DependencyProperty RESETProperty =
            DependencyProperty.Register("RESET", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the RESET.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESET
        {
            get { return (string)this.GetValue(RESETProperty); }
            set { this.SetValue(RESETProperty, value); }
        }

        /// <summary>
        /// Mismatch_CB Property
        /// </summary>
        public static readonly DependencyProperty Mismatch_CBProperty =
            DependencyProperty.Register("Mismatch_CB", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the Mismatch_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Mismatch_CB
        {
            get { return (string)this.GetValue(Mismatch_CBProperty); }
            set { this.SetValue(Mismatch_CBProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_OverlayName", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_TagnameProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_Tagname", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_TagnameProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_LOCProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_LOC", typeof(int), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_DS_RESET_LOC
        {
            get { return (int)this.GetValue(CallOverlay_DS_RESET_LOCProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_BLKOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_DS_RESET_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_PAROVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_PAROVLProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_PAROVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_PAROVL2Property); }
            set { this.SetValue(CallOverlay_DS_RESET_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_PAROVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_PAROVL3Property); }
            set { this.SetValue(CallOverlay_DS_RESET_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_PRTProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_PRT", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_PRT
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_PRTProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_PAROVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_PAROVL4Property); }
            set { this.SetValue(CallOverlay_DS_RESET_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_DS_RESET_CMPOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_DS_RESET_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_RESET_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_RESET_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DS_RESET_DSCRP", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_RESET_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_RESET_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_DS_RESET_DSCRPProperty); }
            set { this.SetValue(CallOverlay_DS_RESET_DSCRPProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_OverlayName", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_TagnameProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_Tagname", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_TagnameProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_LOCProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_LOC", typeof(int), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_NODS_NORST_LOC
        {
            get { return (int)this.GetValue(CallOverlay_NODS_NORST_LOCProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_BLKOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_PAROVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_PAROVLProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_PAROVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_PAROVL2Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_PAROVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_PAROVL3Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_PRTProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_PRT", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_PRT
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_PRTProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_PAROVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_PAROVL4Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_NODS_NORST_CMPOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_NODS_NORST_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_NODS_NORST_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_NODS_NORST_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_NODS_NORST_DSCRP", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_NODS_NORST_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_NODS_NORST_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_NODS_NORST_DSCRPProperty); }
            set { this.SetValue(CallOverlay_NODS_NORST_DSCRPProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_OverlayName", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_TagnameProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_Tagname", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_TagnameProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_LOCProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_LOC", typeof(int), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_DS_NORST_LOC
        {
            get { return (int)this.GetValue(CallOverlay_DS_NORST_LOCProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_BLKOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_DS_NORST_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_PAROVL", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_PAROVLProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_PAROVL2", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_PAROVL2Property); }
            set { this.SetValue(CallOverlay_DS_NORST_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_PAROVL3", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_PAROVL3Property); }
            set { this.SetValue(CallOverlay_DS_NORST_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_PRTProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_PRT", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_PRT
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_PRTProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_PAROVL4", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_PAROVL4Property); }
            set { this.SetValue(CallOverlay_DS_NORST_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL5", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_DS_NORST_CMPOVL6", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_DS_NORST_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DS_NORST_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DS_NORST_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DS_NORST_DSCRP", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DS_NORST_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DS_NORST_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_DS_NORST_DSCRPProperty); }
            set { this.SetValue(CallOverlay_DS_NORST_DSCRPProperty, value); }
        }

        /// <summary>
        /// MainACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty MainACK_UNACK_1Property =
            DependencyProperty.Register("MainACK_UNACK_1", typeof(string), typeof(SYM_PUMP_01));

        /// <summary>
        /// Gets or sets the MainACK_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MainACK_UNACK_1
        {
            get { return (string)this.GetValue(MainACK_UNACK_1Property); }
            set { this.SetValue(MainACK_UNACK_1Property, value); }
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
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.CALCA)) yield return new Param("$CALCA", this.CALCA);
if (!string.IsNullOrWhiteSpace(this.LABEL_Des)) yield return new Param("$LABEL_Des", this.LABEL_Des);

            }
        }

		
    }
}
