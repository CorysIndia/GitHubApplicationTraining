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
    public class SYM_MTR_DT01AB : RSIControlModel
    {
        static SYM_MTR_DT01AB()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_MTR_DT01AB), new FrameworkPropertyMetadata(typeof(SYM_MTR_DT01AB)));
        }

		public SYM_MTR_DT01AB()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("_RUN", typeof(bool), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// OVL Property
        /// </summary>
        public static readonly DependencyProperty OVLProperty =
            DependencyProperty.Register("OVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OVL
        {
            get { return (string)this.GetValue(OVLProperty); }
            set { this.SetValue(OVLProperty, value); }
        }

        /// <summary>
        /// _FAULT Property
        /// </summary>
        public static readonly DependencyProperty _FAULTProperty =
            DependencyProperty.Register("_FAULT", typeof(bool), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("_TRIP", typeof(bool), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// _HAND Property
        /// </summary>
        public static readonly DependencyProperty _HANDProperty =
            DependencyProperty.Register("_HAND", typeof(bool), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the _HAND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _HAND
        {
            get { return (bool)this.GetValue(_HANDProperty); }
            set { this.SetValue(_HANDProperty, value); }
        }

        /// <summary>
        /// _REMOTE Property
        /// </summary>
        public static readonly DependencyProperty _REMOTEProperty =
            DependencyProperty.Register("_REMOTE", typeof(bool), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the _REMOTE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _REMOTE
        {
            get { return (bool)this.GetValue(_REMOTEProperty); }
            set { this.SetValue(_REMOTEProperty, value); }
        }

        /// <summary>
        /// _MA Property
        /// </summary>
        public static readonly DependencyProperty _MAProperty =
            DependencyProperty.Register("_MA", typeof(bool), typeof(SYM_MTR_DT01AB));

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
        /// _CALCA Property
        /// </summary>
        public static readonly DependencyProperty _CALCAProperty =
            DependencyProperty.Register("_CALCA", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// _TRIPBLK Property
        /// </summary>
        public static readonly DependencyProperty _TRIPBLKProperty =
            DependencyProperty.Register("_TRIPBLK", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the _TRIPBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _TRIPBLK
        {
            get { return (string)this.GetValue(_TRIPBLKProperty); }
            set { this.SetValue(_TRIPBLKProperty, value); }
        }

        /// <summary>
        /// TRIP Property
        /// </summary>
        public static readonly DependencyProperty TRIPProperty =
            DependencyProperty.Register("TRIP", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// FAULT Property
        /// </summary>
        public static readonly DependencyProperty FAULTProperty =
            DependencyProperty.Register("FAULT", typeof(bool), typeof(SYM_MTR_DT01AB));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK
        {
            get { return (bool)this.GetValue(UNACKProperty); }
            set { this.SetValue(UNACKProperty, value); }
        }

        /// <summary>
        /// DS Property
        /// </summary>
        public static readonly DependencyProperty DSProperty =
            DependencyProperty.Register("DS", typeof(bool), typeof(SYM_MTR_DT01AB));

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
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type
        {
            get { return (string)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
        }

        /// <summary>
        /// Shape Property
        /// </summary>
        public static readonly DependencyProperty ShapeProperty =
            DependencyProperty.Register("Shape", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("Label", typeof(string), typeof(SYM_MTR_DT01AB));

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

        //START
        /// <summary>
        /// FAN_POS Property
        /// </summary>
        public static readonly DependencyProperty FAN_POSProperty =
            DependencyProperty.Register("FAN_POS", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the FAN_POS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FAN_POS
        {
            get { return (string)this.GetValue(FAN_POSProperty); }
            set { this.SetValue(FAN_POSProperty, value); }
        }


        /// <summary>
        /// DUTY Property
        /// </summary>
        public static readonly DependencyProperty DUTYProperty =
            DependencyProperty.Register("DUTY", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// CALLOVERLAY_B_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_B_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_B_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_B_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_B_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_B_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_B_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_B_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_B_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_B_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_B_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_B_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_B_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_B_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_B_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_B_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_B_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_B_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_B_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_B_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_B_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_B_PAROVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_B_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_B_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_B_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_B_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_B_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_B_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_B_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_B_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_B_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_B_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_B_DSCRPProperty, value); }
        }

        /// <summary>
        /// MainACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty MainACK_UNACK_1Property =
            DependencyProperty.Register("MainACK_UNACK_1", typeof(string), typeof(SYM_MTR_DT01AB));

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
            DependencyProperty.Register("FaultAck_UNACK_1", typeof(string), typeof(SYM_MTR_DT01AB));

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
        /// CallOverlayA_Motor_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_OverlayNameProperty =
            DependencyProperty.Register("CallOverlayA_Motor_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_OverlayName
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_OverlayNameProperty); }
            set { this.SetValue(CallOverlayA_Motor_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_TagnameProperty =
            DependencyProperty.Register("CallOverlayA_Motor_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_Tagname
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_TagnameProperty); }
            set { this.SetValue(CallOverlayA_Motor_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_LOCProperty =
            DependencyProperty.Register("CallOverlayA_Motor_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlayA_Motor_LOC
        {
            get { return (int)this.GetValue(CallOverlayA_Motor_LOCProperty); }
            set { this.SetValue(CallOverlayA_Motor_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVLProperty =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVLProperty); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVL2Property =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVL2Property); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVL3Property =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVL3Property); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVL4Property =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVL4Property); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVL5Property =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVL5Property); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_BLKOVL6Property =
            DependencyProperty.Register("CallOverlayA_Motor_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_BLKOVL6Property); }
            set { this.SetValue(CallOverlayA_Motor_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVLProperty =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVLProperty); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVL2Property =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVL2Property); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVL3Property =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVL3Property); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVL4Property =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVL4Property); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_PAROVLProperty =
            DependencyProperty.Register("CallOverlayA_Motor_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_PAROVL
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_PAROVLProperty); }
            set { this.SetValue(CallOverlayA_Motor_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_PAROVL2Property =
            DependencyProperty.Register("CallOverlayA_Motor_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_PAROVL2Property); }
            set { this.SetValue(CallOverlayA_Motor_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_PAROVL3Property =
            DependencyProperty.Register("CallOverlayA_Motor_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_PAROVL3Property); }
            set { this.SetValue(CallOverlayA_Motor_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_PRTProperty =
            DependencyProperty.Register("CallOverlayA_Motor_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_PRT
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_PRTProperty); }
            set { this.SetValue(CallOverlayA_Motor_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_PAROVL4Property =
            DependencyProperty.Register("CallOverlayA_Motor_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayA_Motor_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_PAROVL4Property); }
            set { this.SetValue(CallOverlayA_Motor_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVL5Property =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlayA_Motor_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVL5Property); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_CMPOVL6Property =
            DependencyProperty.Register("CallOverlayA_Motor_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlayA_Motor_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_CMPOVL6Property); }
            set { this.SetValue(CallOverlayA_Motor_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayA_Motor_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayA_Motor_DSCRPProperty =
            DependencyProperty.Register("CallOverlayA_Motor_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayA_Motor_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlayA_Motor_DSCRP
        {
            get { return (string)this.GetValue(CallOverlayA_Motor_DSCRPProperty); }
            set { this.SetValue(CallOverlayA_Motor_DSCRPProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_OverlayNameProperty =
            DependencyProperty.Register("CallOverlayB_Motor_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_OverlayName
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_OverlayNameProperty); }
            set { this.SetValue(CallOverlayB_Motor_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_TagnameProperty =
            DependencyProperty.Register("CallOverlayB_Motor_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_Tagname
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_TagnameProperty); }
            set { this.SetValue(CallOverlayB_Motor_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_LOCProperty =
            DependencyProperty.Register("CallOverlayB_Motor_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlayB_Motor_LOC
        {
            get { return (int)this.GetValue(CallOverlayB_Motor_LOCProperty); }
            set { this.SetValue(CallOverlayB_Motor_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVLProperty =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVLProperty); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVL2Property =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVL2Property); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVL3Property =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVL3Property); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVL4Property =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVL4Property); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVL5Property =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVL5Property); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_BLKOVL6Property =
            DependencyProperty.Register("CallOverlayB_Motor_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_BLKOVL6Property); }
            set { this.SetValue(CallOverlayB_Motor_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVLProperty =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVLProperty); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVL2Property =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVL2Property); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVL3Property =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVL3Property); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVL4Property =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVL4Property); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_PAROVLProperty =
            DependencyProperty.Register("CallOverlayB_Motor_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_PAROVL
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_PAROVLProperty); }
            set { this.SetValue(CallOverlayB_Motor_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_PAROVL2Property =
            DependencyProperty.Register("CallOverlayB_Motor_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_PAROVL2Property); }
            set { this.SetValue(CallOverlayB_Motor_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_PAROVL3Property =
            DependencyProperty.Register("CallOverlayB_Motor_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_PAROVL3Property); }
            set { this.SetValue(CallOverlayB_Motor_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_PRTProperty =
            DependencyProperty.Register("CallOverlayB_Motor_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_PRT
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_PRTProperty); }
            set { this.SetValue(CallOverlayB_Motor_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_PAROVL4Property =
            DependencyProperty.Register("CallOverlayB_Motor_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlayB_Motor_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_PAROVL4Property); }
            set { this.SetValue(CallOverlayB_Motor_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVL5Property =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlayB_Motor_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVL5Property); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_CMPOVL6Property =
            DependencyProperty.Register("CallOverlayB_Motor_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlayB_Motor_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_CMPOVL6Property); }
            set { this.SetValue(CallOverlayB_Motor_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlayB_Motor_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlayB_Motor_DSCRPProperty =
            DependencyProperty.Register("CallOverlayB_Motor_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlayB_Motor_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlayB_Motor_DSCRP
        {
            get { return (string)this.GetValue(CallOverlayB_Motor_DSCRPProperty); }
            set { this.SetValue(CallOverlayB_Motor_DSCRPProperty, value); }
        }

        /// <summary>
        /// MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CB Property
        /// </summary>
        public static readonly DependencyProperty MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CBProperty =
            DependencyProperty.Register("MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CB", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CB
        {
            get { return (string)this.GetValue(MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CBProperty); }
            set { this.SetValue(MOTOR_FAN_UP_MISMATCH_FAN_MOTOR_CBProperty, value); }
        }

        /// <summary>
        /// FAN_MOTOR_MISMATCH_FAN_MOTOR_CB Property
        /// </summary>
        public static readonly DependencyProperty FAN_MOTOR_MISMATCH_FAN_MOTOR_CBProperty =
            DependencyProperty.Register("FAN_MOTOR_MISMATCH_FAN_MOTOR_CB", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the FAN_MOTOR_MISMATCH_FAN_MOTOR_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FAN_MOTOR_MISMATCH_FAN_MOTOR_CB
        {
            get { return (string)this.GetValue(FAN_MOTOR_MISMATCH_FAN_MOTOR_CBProperty); }
            set { this.SetValue(FAN_MOTOR_MISMATCH_FAN_MOTOR_CBProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_A_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_A_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_A_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_A_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_A_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_A_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_A_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_A_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_A_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_A_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_A_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_A_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_A_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_A_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_A_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_A_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_A_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_A_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_A_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_A_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_A_PAROVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_A_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_A_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_A_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_A_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_A_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_A_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_A_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_A_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_A_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_A_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_A_DSCRPProperty, value); }
        }

        /// <summary>
        /// Mismatch_PUMP_CB Property
        /// </summary>
        public static readonly DependencyProperty Mismatch_PUMP_CBProperty =
            DependencyProperty.Register("Mismatch_PUMP_CB", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the Mismatch_PUMP_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Mismatch_PUMP_CB
        {
            get { return (string)this.GetValue(Mismatch_PUMP_CBProperty); }
            set { this.SetValue(Mismatch_PUMP_CBProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_OverlayNameProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_OverlayName
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_OverlayNameProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_TagnameProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_Tagname
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_TagnameProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_TagnameProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_LOC Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_LOCProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CALLOVERLAY_FIN_MOTOR_LOC
        {
            get { return (int)this.GetValue(CALLOVERLAY_FIN_MOTOR_LOCProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_LOCProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVLProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL2Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL3Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL4Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL5Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_BLKOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_BLKOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL6Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVLProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVLProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVL2Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL2Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVL3Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL3Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVL4Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL4Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_PAROVLProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_PAROVL
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_PAROVLProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_PAROVLProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_PAROVL2Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_PAROVL2
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_PAROVL2Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_PAROVL2Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_PAROVL3Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_PAROVL3
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_PAROVL3Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_PAROVL3Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_PRT Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_PRTProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_PRT
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_PRTProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_PRTProperty, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_PAROVL4Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CALLOVERLAY_FIN_MOTOR_PAROVL4
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_PAROVL4Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_PAROVL4Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVL5Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL5
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL5Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_CMPOVL6Property =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CALLOVERLAY_FIN_MOTOR_CMPOVL6
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL6Property); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CALLOVERLAY_FIN_MOTOR_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CALLOVERLAY_FIN_MOTOR_DSCRPProperty =
            DependencyProperty.Register("CALLOVERLAY_FIN_MOTOR_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CALLOVERLAY_FIN_MOTOR_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CALLOVERLAY_FIN_MOTOR_DSCRP
        {
            get { return (string)this.GetValue(CALLOVERLAY_FIN_MOTOR_DSCRPProperty); }
            set { this.SetValue(CALLOVERLAY_FIN_MOTOR_DSCRPProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_FIN_OverlayName", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_FIN_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_FIN_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_TagnameProperty =
            DependencyProperty.Register("CallOverlay_FIN_Tagname", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_FIN_TagnameProperty); }
            set { this.SetValue(CallOverlay_FIN_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_LOCProperty =
            DependencyProperty.Register("CallOverlay_FIN_LOC", typeof(int), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_FIN_LOC
        {
            get { return (int)this.GetValue(CallOverlay_FIN_LOCProperty); }
            set { this.SetValue(CallOverlay_FIN_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_FIN_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_FIN_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVLProperty); }
            set { this.SetValue(CallOverlay_FIN_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL2", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL2Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL3", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL3Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PRTProperty =
            DependencyProperty.Register("CallOverlay_FIN_PRT", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PRT
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PRTProperty); }
            set { this.SetValue(CallOverlay_FIN_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL4", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL4Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL5", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlay_FIN_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL6", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlay_FIN_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_FIN_DSCRP", typeof(string), typeof(SYM_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlay_FIN_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_FIN_DSCRPProperty); }
            set { this.SetValue(CallOverlay_FIN_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.OVL)) yield return new Param("$OVL", this.OVL);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this._CALCA)) yield return new Param("$_CALCA", this._CALCA);
if (!string.IsNullOrWhiteSpace(this._TRIPBLK)) yield return new Param("$_TRIPBLK", this._TRIPBLK);
if (!string.IsNullOrWhiteSpace(this.TRIP)) yield return new Param("$TRIP", this.TRIP);
if (!string.IsNullOrWhiteSpace(this.Label)) yield return new Param("$Label", this.Label);
if (!string.IsNullOrWhiteSpace(this.FAN_POS)) yield return new Param("$FAN_POS", this.FAN_POS);

            }
        }

		
    }
}
