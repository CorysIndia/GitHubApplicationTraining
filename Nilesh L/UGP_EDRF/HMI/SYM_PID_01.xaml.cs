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
    public class SYM_PID_01 : RSIControlModel
    {
        static SYM_PID_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_PID_01), new FrameworkPropertyMetadata(typeof(SYM_PID_01)));
        }

		public SYM_PID_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_PID_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_PID_01));

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
        /// _UNIT Property
        /// </summary>
        public static readonly DependencyProperty _UNITProperty =
            DependencyProperty.Register("_UNIT", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _UNIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _UNIT
        {
            get { return (string)this.GetValue(_UNITProperty); }
            set { this.SetValue(_UNITProperty, value); }
        }

        /// <summary>
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_PID_01));

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
        /// BADI_1_CBP Property
        /// </summary>
        public static readonly DependencyProperty BADI_1_CBPProperty =
            DependencyProperty.Register("BADI_1_CBP", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADI_1_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BADI_1_CBP
        {
            get { return (string)this.GetValue(BADI_1_CBPProperty); }
            set { this.SetValue(BADI_1_CBPProperty, value); }
        }

        /// <summary>
        /// BADO_2_CBP Property
        /// </summary>
        public static readonly DependencyProperty BADO_2_CBPProperty =
            DependencyProperty.Register("BADO_2_CBP", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADO_2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BADO_2_CBP
        {
            get { return (string)this.GetValue(BADO_2_CBPProperty); }
            set { this.SetValue(BADO_2_CBPProperty, value); }
        }

        /// <summary>
        /// BADI_2_CBP Property
        /// </summary>
        public static readonly DependencyProperty BADI_2_CBPProperty =
            DependencyProperty.Register("BADI_2_CBP", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADI_2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BADI_2_CBP
        {
            get { return (string)this.GetValue(BADI_2_CBPProperty); }
            set { this.SetValue(BADI_2_CBPProperty, value); }
        }

        /// <summary>
        /// BADO_1_CBP Property
        /// </summary>
        public static readonly DependencyProperty BADO_1_CBPProperty =
            DependencyProperty.Register("BADO_1_CBP", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADO_1_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BADO_1_CBP
        {
            get { return (string)this.GetValue(BADO_1_CBPProperty); }
            set { this.SetValue(BADO_1_CBPProperty, value); }
        }

        /// <summary>
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _ALMSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA
        {
            get { return (int)this.GetValue(_ALMSTAProperty); }
            set { this.SetValue(_ALMSTAProperty, value); }
        }

        /// <summary>
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_PID_01));

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
        /// _BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty _BLKSTAProperty =
            DependencyProperty.Register("_BLKSTA", typeof(int), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _BLKSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _BLKSTA
        {
            get { return (int)this.GetValue(_BLKSTAProperty); }
            set { this.SetValue(_BLKSTAProperty, value); }
        }

        /// <summary>
        /// _HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _HSCO1Property =
            DependencyProperty.Register("_HSCO1", typeof(double), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _HSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HSCO1
        {
            get { return (double)this.GetValue(_HSCO1Property); }
            set { this.SetValue(_HSCO1Property, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_PID_01));

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
        /// _LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _LSCO1Property =
            DependencyProperty.Register("_LSCO1", typeof(double), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _LSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LSCO1
        {
            get { return (double)this.GetValue(_LSCO1Property); }
            set { this.SetValue(_LSCO1Property, value); }
        }

        /// <summary>
        /// _OUT Property
        /// </summary>
        public static readonly DependencyProperty _OUTProperty =
            DependencyProperty.Register("_OUT", typeof(double), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _OUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _OUT
        {
            get { return (double)this.GetValue(_OUTProperty); }
            set { this.SetValue(_OUTProperty, value); }
        }

        /// <summary>
        /// _BADI_1 Property
        /// </summary>
        public static readonly DependencyProperty _BADI_1Property =
            DependencyProperty.Register("_BADI_1", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _BADI_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BADI_1
        {
            get { return (bool)this.GetValue(_BADI_1Property); }
            set { this.SetValue(_BADI_1Property, value); }
        }

        /// <summary>
        /// _BADI_2 Property
        /// </summary>
        public static readonly DependencyProperty _BADI_2Property =
            DependencyProperty.Register("_BADI_2", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _BADI_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BADI_2
        {
            get { return (bool)this.GetValue(_BADI_2Property); }
            set { this.SetValue(_BADI_2Property, value); }
        }

        /// <summary>
        /// _BADO_1 Property
        /// </summary>
        public static readonly DependencyProperty _BADO_1Property =
            DependencyProperty.Register("_BADO_1", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _BADO_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BADO_1
        {
            get { return (bool)this.GetValue(_BADO_1Property); }
            set { this.SetValue(_BADO_1Property, value); }
        }

        /// <summary>
        /// _SPT Property
        /// </summary>
        public static readonly DependencyProperty _SPTProperty =
            DependencyProperty.Register("_SPT", typeof(double), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _SPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _SPT
        {
            get { return (double)this.GetValue(_SPTProperty); }
            set { this.SetValue(_SPTProperty, value); }
        }

        /// <summary>
        /// _BADO_2 Property
        /// </summary>
        public static readonly DependencyProperty _BADO_2Property =
            DependencyProperty.Register("_BADO_2", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _BADO_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BADO_2
        {
            get { return (bool)this.GetValue(_BADO_2Property); }
            set { this.SetValue(_BADO_2Property, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_PID_01));

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
        /// _RSPT Property
        /// </summary>
        public static readonly DependencyProperty _RSPTProperty =
            DependencyProperty.Register("_RSPT", typeof(double), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the _RSPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _RSPT
        {
            get { return (double)this.GetValue(_RSPTProperty); }
            set { this.SetValue(_RSPTProperty, value); }
        }

        /// <summary>
        /// BADINPUT1_BAD Property
        /// </summary>
        public static readonly DependencyProperty BADINPUT1_BADProperty =
            DependencyProperty.Register("BADINPUT1_BAD", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADINPUT1_BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BADINPUT1_BAD
        {
            get { return (bool)this.GetValue(BADINPUT1_BADProperty); }
            set { this.SetValue(BADINPUT1_BADProperty, value); }
        }

        /// <summary>
        /// BADINPUT2_BAD Property
        /// </summary>
        public static readonly DependencyProperty BADINPUT2_BADProperty =
            DependencyProperty.Register("BADINPUT2_BAD", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADINPUT2_BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BADINPUT2_BAD
        {
            get { return (bool)this.GetValue(BADINPUT2_BADProperty); }
            set { this.SetValue(BADINPUT2_BADProperty, value); }
        }

        /// <summary>
        /// BADOUTPUT1_BAD Property
        /// </summary>
        public static readonly DependencyProperty BADOUTPUT1_BADProperty =
            DependencyProperty.Register("BADOUTPUT1_BAD", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADOUTPUT1_BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BADOUTPUT1_BAD
        {
            get { return (bool)this.GetValue(BADOUTPUT1_BADProperty); }
            set { this.SetValue(BADOUTPUT1_BADProperty, value); }
        }

        /// <summary>
        /// BADOUTPUT2_BAD Property
        /// </summary>
        public static readonly DependencyProperty BADOUTPUT2_BADProperty =
            DependencyProperty.Register("BADOUTPUT2_BAD", typeof(bool), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the BADOUTPUT2_BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BADOUTPUT2_BAD
        {
            get { return (bool)this.GetValue(BADOUTPUT2_BADProperty); }
            set { this.SetValue(BADOUTPUT2_BADProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay1_OverlayName", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_Tagname", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_LOC", typeof(int), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL2", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL3", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL4", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL5", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL6", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL2", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL3", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL4", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL2", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL3", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_PRT", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL4", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL5", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL6", typeof(string), typeof(SYM_PID_01));

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
            DependencyProperty.Register("FP_CallOverlay1_DSCRP", typeof(string), typeof(SYM_PID_01));

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

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_PID_01));

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
        /// ALRMBOARDER__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty ALRMBOARDER__CONN1Property =
            DependencyProperty.Register("ALRMBOARDER__CONN1", typeof(int), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the ALRMBOARDER__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALRMBOARDER__CONN1
        {
            get { return (int)this.GetValue(ALRMBOARDER__CONN1Property); }
            set { this.SetValue(ALRMBOARDER__CONN1Property, value); }
        }

        /// <summary>
        /// TAGNAME_T Property
        /// </summary>
        public static readonly DependencyProperty TAGNAME_TProperty =
            DependencyProperty.Register("TAGNAME_T", typeof(string), typeof(SYM_PID_01));

        /// <summary>
        /// Gets or sets the TAGNAME_T.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAGNAME_T
        {
            get { return (string)this.GetValue(TAGNAME_TProperty); }
            set { this.SetValue(TAGNAME_TProperty, value); }
        }

        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_PID_01));

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
if (!string.IsNullOrWhiteSpace(this._UNIT)) yield return new Param("$_UNIT", this._UNIT);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.BADI_1_CBP)) yield return new Param("$BADI_1_CBP", this.BADI_1_CBP);
if (!string.IsNullOrWhiteSpace(this.BADO_2_CBP)) yield return new Param("$BADO_2_CBP", this.BADO_2_CBP);
if (!string.IsNullOrWhiteSpace(this.BADI_2_CBP)) yield return new Param("$BADI_2_CBP", this.BADI_2_CBP);
if (!string.IsNullOrWhiteSpace(this.BADO_1_CBP)) yield return new Param("$BADO_1_CBP", this.BADO_1_CBP);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
                if (!string.IsNullOrWhiteSpace(this.TAGNAME_T)) yield return new Param("$TAGNAME_T", this.TAGNAME_T);
                if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);

            }
        }

		
    }
}
