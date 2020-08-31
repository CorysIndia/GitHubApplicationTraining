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
    public class SYM_MTR_DT09 : RSIControlModel
    {
        static SYM_MTR_DT09()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_MTR_DT09), new FrameworkPropertyMetadata(typeof(SYM_MTR_DT09)));
        }

		public SYM_MTR_DT09()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_MTR_DT09));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_MTR_DT09));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_MTR_DT09));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_MTR_DT09));

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
        /// _RUN Property
        /// </summary>
        public static readonly DependencyProperty _RUNProperty =
            DependencyProperty.Register("_RUN", typeof(bool), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the _RUN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _RUN
        {
            get { return (bool)this.GetValue(_RUNProperty); }
            set { this.SetValue(_RUNProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_MTR_DT09));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_MTR_DT09));

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
        /// _UNACK Property
        /// </summary>
        public static readonly DependencyProperty _UNACKProperty =
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the _UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _UNACK
        {
            get { return (bool)this.GetValue(_UNACKProperty); }
            set { this.SetValue(_UNACKProperty, value); }
        }

        /// <summary>
        /// _FAULT Property
        /// </summary>
        public static readonly DependencyProperty _FAULTProperty =
            DependencyProperty.Register("_FAULT", typeof(bool), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the _FAULT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _FAULT
        {
            get { return (bool)this.GetValue(_FAULTProperty); }
            set { this.SetValue(_FAULTProperty, value); }
        }

        /// <summary>
        /// _TRIP Property
        /// </summary>
        public static readonly DependencyProperty _TRIPProperty =
            DependencyProperty.Register("_TRIP", typeof(bool), typeof(SYM_MTR_DT09));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_MTR_DT09));

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
        /// _CALCA Property
        /// </summary>
        public static readonly DependencyProperty _CALCAProperty =
            DependencyProperty.Register("_CALCA", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the _CALCA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _CALCA
        {
            get { return (string)this.GetValue(_CALCAProperty); }
            set { this.SetValue(_CALCAProperty, value); }
        }

        /// <summary>
        /// Shape Property
        /// </summary>
        public static readonly DependencyProperty ShapeProperty =
            DependencyProperty.Register("Shape", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Shape.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Shape
        {
            get { return (string)this.GetValue(ShapeProperty); }
            set { this.SetValue(ShapeProperty, value); }
        }

        /// <summary>
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_MTR_DT09));

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
        /// CALLOVERLAY_GEN_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_OverlayName", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_Tagname", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_LOC", typeof(int), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_GEN_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_GEN_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_BLKOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_GEN_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_PAROVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_PAROVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_GEN_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_PAROVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_GEN_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_PRT", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_PAROVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_GEN_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_GEN_PAROVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_GEN_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_GEN_CMPOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_GEN_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_GEN_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_GEN_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_GEN_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_GEN_DSCRP", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_GEN_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_GEN_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_GEN_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_GEN_DSCRPProperty, value); }
        }

        /// <summary>
        /// MainACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty MainACK_UNACK_1Property =
            DependencyProperty.Register("MainACK_UNACK_1", typeof(string), typeof(SYM_MTR_DT09));

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

        /// <summary>
        /// FaultAck_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty FaultAck_UNACK_1Property =
            DependencyProperty.Register("FaultAck_UNACK_1", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the FaultAck_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FaultAck_UNACK_1
        {
            get { return (string)this.GetValue(FaultAck_UNACK_1Property); }
            set { this.SetValue(FaultAck_UNACK_1Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_OverlayName", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_Tagname", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_LOC", typeof(int), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_Motor_Down_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_Motor_Down_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_BLKOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_PAROVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_PAROVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_PAROVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_PRT", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_PAROVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_Motor_Down_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_PAROVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_Motor_Down_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_CMPOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_Motor_Down_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_Motor_Down_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_Motor_Down_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_Motor_Down_DSCRP", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_Motor_Down_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_Motor_Down_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_Motor_Down_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_Motor_Down_DSCRPProperty, value); }
        }

        /// <summary>
        /// Mismatch_Pump_CB Property
        /// </summary>
        public static readonly DependencyProperty Mismatch_Pump_CBProperty =
            DependencyProperty.Register("Mismatch_Pump_CB", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Mismatch_Pump_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Mismatch_Pump_CB
        {
            get { return (string)this.GetValue(Mismatch_Pump_CBProperty); }
            set { this.SetValue(Mismatch_Pump_CBProperty, value); }
        }

        /// <summary>
        /// FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CB Property
        /// </summary>
        public static readonly DependencyProperty FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CBProperty =
            DependencyProperty.Register("FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CB", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CB
        {
            get { return (string)this.GetValue(FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CBProperty); }
            set { this.SetValue(FAN_MOTOR_DOWN_MISMATCH_FAN_MOTOR_CBProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_OverlayNameProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_OverlayName", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_OverlayName
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_OverlayNameProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_TagnameProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_Tagname", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_Tagname
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_TagnameProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_TagnameProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_LOC Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_LOCProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_LOC", typeof(int), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Fan_up_CALLOVERLAY_FAN_UP_LOC
        {
            get { return (int)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_LOCProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_LOCProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVLProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVLProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVLProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVLProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_PAROVLProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_PAROVL", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_PAROVL
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVLProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVLProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_PAROVL2Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_PAROVL2", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_PAROVL2
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL2Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL2Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_PAROVL3Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_PAROVL3", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_PAROVL3
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL3Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL3Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_PRT Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_PRTProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_PRT", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_PRT
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_PRTProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_PRTProperty, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_PAROVL4Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_PAROVL4", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_CALLOVERLAY_FAN_UP_PAROVL4
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL4Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_PAROVL4Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6Property =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6Property); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Fan_up_CALLOVERLAY_FAN_UP_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_CALLOVERLAY_FAN_UP_DSCRPProperty =
            DependencyProperty.Register("Fan_up_CALLOVERLAY_FAN_UP_DSCRP", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_CALLOVERLAY_FAN_UP_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string Fan_up_CALLOVERLAY_FAN_UP_DSCRP
        {
            get { return (string)this.GetValue(Fan_up_CALLOVERLAY_FAN_UP_DSCRPProperty); }
            set { this.SetValue(Fan_up_CALLOVERLAY_FAN_UP_DSCRPProperty, value); }
        }

        /// <summary>
        /// Fan_up_MISMATCH_FAN_MOTOR_CB Property
        /// </summary>
        public static readonly DependencyProperty Fan_up_MISMATCH_FAN_MOTOR_CBProperty =
            DependencyProperty.Register("Fan_up_MISMATCH_FAN_MOTOR_CB", typeof(string), typeof(SYM_MTR_DT09));

        /// <summary>
        /// Gets or sets the Fan_up_MISMATCH_FAN_MOTOR_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Fan_up_MISMATCH_FAN_MOTOR_CB
        {
            get { return (string)this.GetValue(Fan_up_MISMATCH_FAN_MOTOR_CBProperty); }
            set { this.SetValue(Fan_up_MISMATCH_FAN_MOTOR_CBProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this._CALCA)) yield return new Param("$_CALCA", this._CALCA);

            }
        }

		
    }
}
