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
    public class SYM_IND_01 : RSIControlModel
    {
        static SYM_IND_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_IND_01), new FrameworkPropertyMetadata(typeof(SYM_IND_01)));
        }

		public SYM_IND_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_IND_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_IND_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_IND_01));

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
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_IND_01));

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
        /// _EI1 Property
        /// </summary>
        public static readonly DependencyProperty _EI1Property =
            DependencyProperty.Register("_EI1", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the _EI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _EI1
        {
            get { return (string)this.GetValue(_EI1Property); }
            set { this.SetValue(_EI1Property, value); }
        }

        /// <summary>
        /// _PNT Property
        /// </summary>
        public static readonly DependencyProperty _PNTProperty =
            DependencyProperty.Register("_PNT", typeof(double), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the _PNT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _PNT
        {
            get { return (double)this.GetValue(_PNTProperty); }
            set { this.SetValue(_PNTProperty, value); }
        }

        /// <summary>
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_IND_01));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(int), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRT
        {
            get { return (int)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// _EO1 Property
        /// </summary>
        public static readonly DependencyProperty _EO1Property =
            DependencyProperty.Register("_EO1", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the _EO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _EO1
        {
            get { return (string)this.GetValue(_EO1Property); }
            set { this.SetValue(_EO1Property, value); }
        }

        /// <summary>
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_IND_01));

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
        /// BAD_BLK Property
        /// </summary>
        public static readonly DependencyProperty BAD_BLKProperty =
            DependencyProperty.Register("BAD_BLK", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the BAD_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BAD_BLK
        {
            get { return (string)this.GetValue(BAD_BLKProperty); }
            set { this.SetValue(BAD_BLKProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_IND_01));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_IND_01));

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
        /// _BAD_CIN Property
        /// </summary>
        public static readonly DependencyProperty _BAD_CINProperty =
            DependencyProperty.Register("_BAD_CIN", typeof(bool), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the _BAD_CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BAD_CIN
        {
            get { return (bool)this.GetValue(_BAD_CINProperty); }
            set { this.SetValue(_BAD_CINProperty, value); }
        }

        /// <summary>
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(SYM_IND_01));

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
        /// CIN Property
        /// </summary>
        public static readonly DependencyProperty CINProperty =
            DependencyProperty.Register("CIN", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CIN
        {
            get { return (string)this.GetValue(CINProperty); }
            set { this.SetValue(CINProperty, value); }
        }

        /// <summary>
        /// EU Property
        /// </summary>
        public static readonly DependencyProperty EUProperty =
            DependencyProperty.Register("EU", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EU
        {
            get { return (string)this.GetValue(EUProperty); }
            set { this.SetValue(EUProperty, value); }
        }

        /// <summary>
        /// ACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_UNACK_1Property =
            DependencyProperty.Register("ACK_UNACK_1", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the ACK_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_UNACK_1
        {
            get { return (string)this.GetValue(ACK_UNACK_1Property); }
            set { this.SetValue(ACK_UNACK_1Property, value); }
        }

        /// <summary>
        /// Border_AlarmState__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty Border_AlarmState__CONN1Property =
            DependencyProperty.Register("Border_AlarmState__CONN1", typeof(int), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the Border_AlarmState__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Border_AlarmState__CONN1
        {
            get { return (int)this.GetValue(Border_AlarmState__CONN1Property); }
            set { this.SetValue(Border_AlarmState__CONN1Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_OverlayName", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_Tagname", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_LOC", typeof(int), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay_RIN_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay_RIN_LOCProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL5", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_BLKOVL6", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay_RIN_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_PAROVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_PAROVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay_RIN_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_PAROVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay_RIN_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_PRT", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_PRTProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_PAROVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_RIN_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay_RIN_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL5", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay_RIN_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_RIN_CMPOVL6", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay_RIN_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay_RIN_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_RIN_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_RIN_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay_RIN_DSCRP", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_RIN_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay_RIN_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay_RIN_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay_RIN_DSCRPProperty, value); }
        }

        /// <summary>
        /// Border_BAD_CIN_BAD Property
        /// </summary>
        public static readonly DependencyProperty Border_BAD_CIN_BADProperty =
            DependencyProperty.Register("Border_BAD_CIN_BAD", typeof(bool), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the Border_BAD_CIN_BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Border_BAD_CIN_BAD
        {
            get { return (bool)this.GetValue(Border_BAD_CIN_BADProperty); }
            set { this.SetValue(Border_BAD_CIN_BADProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_OverlayName", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_Tagname", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_LOC", typeof(int), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay_AIN_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay_AIN_LOCProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL5", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_BLKOVL6", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay_AIN_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_PAROVL", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_PAROVL2", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay_AIN_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_PAROVL3", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay_AIN_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_PRT", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_PRTProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_PAROVL4", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AIN_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay_AIN_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL5", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay_AIN_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_AIN_CMPOVL6", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay_AIN_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay_AIN_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AIN_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AIN_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay_AIN_DSCRP", typeof(string), typeof(SYM_IND_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AIN_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay_AIN_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay_AIN_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay_AIN_DSCRPProperty, value); }
        }

        /// <summary>
        /// TAGNAME_T Property
        /// </summary>
        public static readonly DependencyProperty TAGNAME_TProperty =
            DependencyProperty.Register("TAGNAME_T", typeof(string), typeof(SYM_IND_01));

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
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_IND_01));

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
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this._EI1)) yield return new Param("$_EI1", this._EI1);
if (!string.IsNullOrWhiteSpace(this._EO1)) yield return new Param("$_EO1", this._EO1);
if (!string.IsNullOrWhiteSpace(this.BAD_BLK)) yield return new Param("$BAD_BLK", this.BAD_BLK);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
                if (!string.IsNullOrWhiteSpace(this.TAGNAME_T)) yield return new Param("$TAGNAME_T", this.TAGNAME_T);
                if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);

            }
        }

		
    }
}
