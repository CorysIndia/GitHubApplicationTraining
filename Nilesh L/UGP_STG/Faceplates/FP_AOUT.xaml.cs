using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using System.ComponentModel.Composition;

namespace UGP_STG.HMI
{
	[Export("FP_AOUT")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_AOUT
    {
        public FP_AOUT()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the GraphicTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string GraphicTagName
        {
            get { return (string)this.GetValue(GraphicTagNameProperty); }
            set { this.SetValue(GraphicTagNameProperty, value); }
        }


		        /// <summary>
        /// _DESCRP Property
        /// </summary>
        public static readonly DependencyProperty _DESCRPProperty =
            DependencyProperty.Register("_DESCRP", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _DESCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _DESCRP
        {
            get { return (string)this.GetValue(_DESCRPProperty); }
            set { this.SetValue(_DESCRPProperty, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL
        {
            get { return (string)this.GetValue(CMPOVLProperty); }
            set { this.SetValue(CMPOVLProperty, value); }
        }

        /// <summary>
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL
        {
            get { return (string)this.GetValue(BLKOVLProperty); }
            set { this.SetValue(BLKOVLProperty, value); }
        }

        /// <summary>
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(FP_AOUT));

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
        /// _BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty _BLKSTAProperty =
            DependencyProperty.Register("_BLKSTA", typeof(int), typeof(FP_AOUT));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the PvCB_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PvCB_1
        {
            get { return (string)this.GetValue(PvCB_1Property); }
            set { this.SetValue(PvCB_1Property, value); }
        }

        /// <summary>
        /// _BIAS Property
        /// </summary>
        public static readonly DependencyProperty _BIASProperty =
            DependencyProperty.Register("_BIAS", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _BIAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _BIAS
        {
            get { return (string)this.GetValue(_BIASProperty); }
            set { this.SetValue(_BIASProperty, value); }
        }

        /// <summary>
        /// _CRIT Property
        /// </summary>
        public static readonly DependencyProperty _CRITProperty =
            DependencyProperty.Register("_CRIT", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _CRIT
        {
            get { return (int)this.GetValue(_CRITProperty); }
            set { this.SetValue(_CRITProperty, value); }
        }

        /// <summary>
        /// _EO1 Property
        /// </summary>
        public static readonly DependencyProperty _EO1Property =
            DependencyProperty.Register("_EO1", typeof(string), typeof(FP_AOUT));

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
        /// _HOLIM Property
        /// </summary>
        public static readonly DependencyProperty _HOLIMProperty =
            DependencyProperty.Register("_HOLIM", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _HOLIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HOLIM
        {
            get { return (double)this.GetValue(_HOLIMProperty); }
            set { this.SetValue(_HOLIMProperty, value); }
        }

        /// <summary>
        /// _HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty _HSCI1Property =
            DependencyProperty.Register("_HSCI1", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _HSCI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HSCI1
        {
            get { return (double)this.GetValue(_HSCI1Property); }
            set { this.SetValue(_HSCI1Property, value); }
        }

        /// <summary>
        /// _HSCI2 Property
        /// </summary>
        public static readonly DependencyProperty _HSCI2Property =
            DependencyProperty.Register("_HSCI2", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _HSCI2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HSCI2
        {
            get { return (double)this.GetValue(_HSCI2Property); }
            set { this.SetValue(_HSCI2Property, value); }
        }

        /// <summary>
        /// _HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _HSCO1Property =
            DependencyProperty.Register("_HSCO1", typeof(double), typeof(FP_AOUT));

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
        /// _INHOPT Property
        /// </summary>
        public static readonly DependencyProperty _INHOPTProperty =
            DependencyProperty.Register("_INHOPT", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _INHOPT
        {
            get { return (int)this.GetValue(_INHOPTProperty); }
            set { this.SetValue(_INHOPTProperty, value); }
        }

        /// <summary>
        /// _INHSTA Property
        /// </summary>
        public static readonly DependencyProperty _INHSTAProperty =
            DependencyProperty.Register("_INHSTA", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _INHSTA
        {
            get { return (int)this.GetValue(_INHSTAProperty); }
            set { this.SetValue(_INHSTAProperty, value); }
        }

        /// <summary>
        /// _LOLIM Property
        /// </summary>
        public static readonly DependencyProperty _LOLIMProperty =
            DependencyProperty.Register("_LOLIM", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _LOLIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LOLIM
        {
            get { return (double)this.GetValue(_LOLIMProperty); }
            set { this.SetValue(_LOLIMProperty, value); }
        }

        /// <summary>
        /// _LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty _LSCI1Property =
            DependencyProperty.Register("_LSCI1", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _LSCI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LSCI1
        {
            get { return (double)this.GetValue(_LSCI1Property); }
            set { this.SetValue(_LSCI1Property, value); }
        }

        /// <summary>
        /// _LSCI2 Property
        /// </summary>
        public static readonly DependencyProperty _LSCI2Property =
            DependencyProperty.Register("_LSCI2", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _LSCI2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LSCI2
        {
            get { return (double)this.GetValue(_LSCI2Property); }
            set { this.SetValue(_LSCI2Property, value); }
        }

        /// <summary>
        /// _LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _LSCO1Property =
            DependencyProperty.Register("_LSCO1", typeof(double), typeof(FP_AOUT));

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
        /// _MA Property
        /// </summary>
        public static readonly DependencyProperty _MAProperty =
            DependencyProperty.Register("_MA", typeof(bool), typeof(FP_AOUT));

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
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(FP_AOUT));

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
        /// _OUT Property
        /// </summary>
        public static readonly DependencyProperty _OUTProperty =
            DependencyProperty.Register("_OUT", typeof(double), typeof(FP_AOUT));

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
        /// _PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty _PRTYPEProperty =
            DependencyProperty.Register("_PRTYPE", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the _PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _PRTYPE
        {
            get { return (int)this.GetValue(_PRTYPEProperty); }
            set { this.SetValue(_PRTYPEProperty, value); }
        }

        /// <summary>
        /// _UNACK Property
        /// </summary>
        public static readonly DependencyProperty _UNACKProperty =
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(FP_AOUT));

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
        /// _EI1 Property
        /// </summary>
        public static readonly DependencyProperty _EI1Property =
            DependencyProperty.Register("_EI1", typeof(string), typeof(FP_AOUT));

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
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the SELECTED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SELECTED
        {
            get { return (int)this.GetValue(SELECTEDProperty); }
            set { this.SetValue(SELECTEDProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_PV Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_PVProperty =
            DependencyProperty.Register("Increment_Decrement_PV", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Increment_Decrement_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_PV
        {
            get { return (double)this.GetValue(Increment_Decrement_PVProperty); }
            set { this.SetValue(Increment_Decrement_PVProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_PV_Max Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_PV_MaxProperty =
            DependencyProperty.Register("Increment_Decrement_PV_Max", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Increment_Decrement_PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_PV_Max
        {
            get { return (double)this.GetValue(Increment_Decrement_PV_MaxProperty); }
            set { this.SetValue(Increment_Decrement_PV_MaxProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_PV_Min Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_PV_MinProperty =
            DependencyProperty.Register("Increment_Decrement_PV_Min", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Increment_Decrement_PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_PV_Min
        {
            get { return (double)this.GetValue(Increment_Decrement_PV_MinProperty); }
            set { this.SetValue(Increment_Decrement_PV_MinProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_option Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_optionProperty =
            DependencyProperty.Register("Increment_Decrement_option", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Increment_Decrement_option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Increment_Decrement_option
        {
            get { return (string)this.GetValue(Increment_Decrement_optionProperty); }
            set { this.SetValue(Increment_Decrement_optionProperty, value); }
        }

        /// <summary>
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Button_Close_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button_Close_CON1
        {
            get { return (bool)this.GetValue(Button_Close_CON1Property); }
            set { this.SetValue(Button_Close_CON1Property, value); }
        }

        /// <summary>
        /// ACK_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the ACK_CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_CB_NAME
        {
            get { return (string)this.GetValue(ACK_CB_NAMEProperty); }
            set { this.SetValue(ACK_CB_NAMEProperty, value); }
        }

        /// <summary>
        /// TREND_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR1Property =
            DependencyProperty.Register("TREND_CMPBLKPAR1", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the TREND_CMPBLKPAR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TREND_CMPBLKPAR1
        {
            get { return (string)this.GetValue(TREND_CMPBLKPAR1Property); }
            set { this.SetValue(TREND_CMPBLKPAR1Property, value); }
        }

        /// <summary>
        /// TREND_CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR2Property =
            DependencyProperty.Register("TREND_CMPBLKPAR2", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the TREND_CMPBLKPAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TREND_CMPBLKPAR2
        {
            get { return (string)this.GetValue(TREND_CMPBLKPAR2Property); }
            set { this.SetValue(TREND_CMPBLKPAR2Property, value); }
        }

        /// <summary>
        /// TREND_Identity Property
        /// </summary>
        public static readonly DependencyProperty TREND_IdentityProperty =
            DependencyProperty.Register("TREND_Identity", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the TREND_Identity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Compound+BLock")]
        public string TREND_Identity
        {
            get { return (string)this.GetValue(TREND_IdentityProperty); }
            set { this.SetValue(TREND_IdentityProperty, value); }
        }

        /// <summary>
        /// TREND_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR3Property =
            DependencyProperty.Register("TREND_CMPBLKPAR3", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the TREND_CMPBLKPAR3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TREND_CMPBLKPAR3
        {
            get { return (string)this.GetValue(TREND_CMPBLKPAR3Property); }
            set { this.SetValue(TREND_CMPBLKPAR3Property, value); }
        }

        /// <summary>
        /// TREND_CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR4Property =
            DependencyProperty.Register("TREND_CMPBLKPAR4", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the TREND_CMPBLKPAR4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TREND_CMPBLKPAR4
        {
            get { return (string)this.GetValue(TREND_CMPBLKPAR4Property); }
            set { this.SetValue(TREND_CMPBLKPAR4Property, value); }
        }

        /// <summary>
        /// Faceplate_Body_MEAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_MEAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_EU", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_MEAS_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_MEAS_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_MEAS_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_MEAS_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_MEAS_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_MEAS_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_MEAS_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_MEAS_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_MEAS_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_MEAS_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_MEAS_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_MEAS_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P_Max", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_MEAS_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_MEAS_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_MEAS_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_MEAS_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_MEAS_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_MEAS_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P_Min", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_MEAS_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_MEAS_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_MEAS_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_MEAS_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_PNT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_PNT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_PNT_CB_EU", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_PNT_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_PNT_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_PNT_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_PNT_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_PNT_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_PNT_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_PNT_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_PNT_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_PNT_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_PNT_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_PNT_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_PNT_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P_Max", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_PNT_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_PNT_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_PNT_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_PNT_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_PNT_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_PNT_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P_Min", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_PNT_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_PNT_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_PNT_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_PNT_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_MoveUp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Flag_AlarmLimits_MoveUp
        {
            get { return (int)this.GetValue(Faceplate_Body_Flag_AlarmLimits_MoveUpProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_MoveUpProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_HAL Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_HALProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HAL", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_HAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_HAL
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_HALProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_HALProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_HHALIM Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_HHALIMProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_HHALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_HHALIM
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_HHALIMProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_HHALIMProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_HHAOPTProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Flag_AlarmLimits_HHAOPT
        {
            get { return (int)this.GetValue(Faceplate_Body_Flag_AlarmLimits_HHAOPTProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_HHAOPTProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_HLOP Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_HLOPProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_HLOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Flag_AlarmLimits_HLOP
        {
            get { return (int)this.GetValue(Faceplate_Body_Flag_AlarmLimits_HLOPProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_HLOPProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_LAL Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_LALProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_LAL", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_LAL
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_LALProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_LALProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_LLALIM Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_LLALIMProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_LLALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_LLALIM
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_LLALIMProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_LLALIMProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_MaxRange Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_MaxRangeProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_MaxRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_MaxRange
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_MaxRangeProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_MaxRangeProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_MinRange Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_MinRangeProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_MinRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Flag_AlarmLimits_MinRange
        {
            get { return (double)this.GetValue(Faceplate_Body_Flag_AlarmLimits_MinRangeProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_MinRangeProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_MoveDown Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_MoveDownProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Flag_AlarmLimits_MoveDown.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Flag_AlarmLimits_MoveDown
        {
            get { return (int)this.GetValue(Faceplate_Body_Flag_AlarmLimits_MoveDownProperty); }
            set { this.SetValue(Faceplate_Body_Flag_AlarmLimits_MoveDownProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_BIAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_BIAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_BIAS_CB_EU", typeof(string), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_BIAS_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_BIAS_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_BIAS_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_BIAS_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_BIAS_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_BIAS_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_BIAS_CB_P", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_BIAS_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_BIAS_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_BIAS_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_BIAS_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_BIAS_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_BIAS_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_BIAS_CB_P_Max", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_BIAS_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_BIAS_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_BIAS_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_BIAS_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_BIAS_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_BIAS_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_BIAS_CB_P_Min", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_BIAS_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_BIAS_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_BIAS_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_BIAS_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_MEAS_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PV", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_MEAS_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_MEAS_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_MEAS_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_MEAS_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_MEAS_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_MEAS_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_MEAS_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_MEAS_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_CRIT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_CRITProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_CRIT", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_Out_CRIT
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_Out_CRITProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_CRITProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_INHOPT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_INHOPTProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_INHOPT", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_Out_INHOPT
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_Out_INHOPTProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_INHOPTProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_INHSTA Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_INHSTAProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_INHSTA", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_Out_INHSTA
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_Out_INHSTAProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_INHSTAProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_PRTYPEProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PRTYPE", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_Out_PRTYPE
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_Out_PRTYPEProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_PRTYPEProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PV", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_Out_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_Out_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PvRangeFullScaleMax", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_Out_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_Out_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PVRangeFullScaleMin", typeof(double), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_Out_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_Out_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_UNACK Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_UNACKProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_UNACK", typeof(bool), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_Out_UNACK
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_Out_UNACKProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_UNACKProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_AlarmStateChanged Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_AlarmStateChangedProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_AlarmStateChanged", typeof(int), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_AlarmStateChanged.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_Out_AlarmStateChanged
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_Out_AlarmStateChangedProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_AlarmStateChangedProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_Out_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_ShowInhibState", typeof(bool), typeof(FP_AOUT));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_Out_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_Out_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_Out_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_Bar_Out_ShowInhibStateProperty, value); }
        }


		
    }
}
