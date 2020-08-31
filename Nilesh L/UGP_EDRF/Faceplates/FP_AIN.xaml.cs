using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using System.ComponentModel.Composition;

namespace UGP_EDRF.HMI
{
	[Export("FP_AIN")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_AIN
    {
        public FP_AIN()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_AIN));

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
        /// CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty CB_NAMEProperty =
            DependencyProperty.Register("CB_NAME", typeof(string), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB_NAME
        {
            get { return (string)this.GetValue(CB_NAMEProperty); }
            set { this.SetValue(CB_NAMEProperty, value); }
        }

        /// <summary>
        /// _EO1 Property
        /// </summary>
        public static readonly DependencyProperty _EO1Property =
            DependencyProperty.Register("_EO1", typeof(string), typeof(FP_AIN));

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
        /// _HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _HSCO1Property =
            DependencyProperty.Register("_HSCO1", typeof(double), typeof(FP_AIN));

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
        /// _MA Property
        /// </summary>
        public static readonly DependencyProperty _MAProperty =
            DependencyProperty.Register("_MA", typeof(bool), typeof(FP_AIN));

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
            DependencyProperty.Register("_MEAS", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("_BLKSTA", typeof(int), typeof(FP_AIN));

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
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(FP_AIN));

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
        /// _HAL Property
        /// </summary>
        public static readonly DependencyProperty _HALProperty =
            DependencyProperty.Register("_HAL", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _HAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HAL
        {
            get { return (double)this.GetValue(_HALProperty); }
            set { this.SetValue(_HALProperty, value); }
        }

        /// <summary>
        /// _HHALIM Property
        /// </summary>
        public static readonly DependencyProperty _HHALIMProperty =
            DependencyProperty.Register("_HHALIM", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _HHALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _HHALIM
        {
            get { return (double)this.GetValue(_HHALIMProperty); }
            set { this.SetValue(_HHALIMProperty, value); }
        }

        /// <summary>
        /// _HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty _HHAOPTProperty =
            DependencyProperty.Register("_HHAOPT", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _HHAOPT
        {
            get { return (int)this.GetValue(_HHAOPTProperty); }
            set { this.SetValue(_HHAOPTProperty, value); }
        }

        /// <summary>
        /// _HLOP Property
        /// </summary>
        public static readonly DependencyProperty _HLOPProperty =
            DependencyProperty.Register("_HLOP", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _HLOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _HLOP
        {
            get { return (int)this.GetValue(_HLOPProperty); }
            set { this.SetValue(_HLOPProperty, value); }
        }

        /// <summary>
        /// _LAL Property
        /// </summary>
        public static readonly DependencyProperty _LALProperty =
            DependencyProperty.Register("_LAL", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LAL
        {
            get { return (double)this.GetValue(_LALProperty); }
            set { this.SetValue(_LALProperty, value); }
        }

        /// <summary>
        /// _LLALIM Property
        /// </summary>
        public static readonly DependencyProperty _LLALIMProperty =
            DependencyProperty.Register("_LLALIM", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the _LLALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _LLALIM
        {
            get { return (double)this.GetValue(_LLALIMProperty); }
            set { this.SetValue(_LLALIMProperty, value); }
        }

        /// <summary>
        /// _LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty _LSCO1Property =
            DependencyProperty.Register("_LSCO1", typeof(double), typeof(FP_AIN));

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
        /// _PNT Property
        /// </summary>
        public static readonly DependencyProperty _PNTProperty =
            DependencyProperty.Register("_PNT", typeof(double), typeof(FP_AIN));

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
        /// _CRIT Property
        /// </summary>
        public static readonly DependencyProperty _CRITProperty =
            DependencyProperty.Register("_CRIT", typeof(int), typeof(FP_AIN));

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
        /// _INHOPT Property
        /// </summary>
        public static readonly DependencyProperty _INHOPTProperty =
            DependencyProperty.Register("_INHOPT", typeof(int), typeof(FP_AIN));

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
            DependencyProperty.Register("_INHSTA", typeof(int), typeof(FP_AIN));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRTYPE
        {
            get { return (int)this.GetValue(PRTYPEProperty); }
            set { this.SetValue(PRTYPEProperty, value); }
        }

        /// <summary>
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_AIN));

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
        /// Reference_Done Property
        /// </summary>
        public static readonly DependencyProperty Reference_DoneProperty =
            DependencyProperty.Register("Reference_Done", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Reference_Done.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Reference_Done
        {
            get { return (bool)this.GetValue(Reference_DoneProperty); }
            set { this.SetValue(Reference_DoneProperty, value); }
        }

        /// <summary>
        /// OptimalRange_Done Property
        /// </summary>
        public static readonly DependencyProperty OptimalRange_DoneProperty =
            DependencyProperty.Register("OptimalRange_Done", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the OptimalRange_Done.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OptimalRange_Done
        {
            get { return (bool)this.GetValue(OptimalRange_DoneProperty); }
            set { this.SetValue(OptimalRange_DoneProperty, value); }
        }

        /// <summary>
        /// TrendON Property
        /// </summary>
        public static readonly DependencyProperty TrendONProperty =
            DependencyProperty.Register("TrendON", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the TrendON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TrendON
        {
            get { return (bool)this.GetValue(TrendONProperty); }
            set { this.SetValue(TrendONProperty, value); }
        }

        /// <summary>
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_AIN));

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
        /// LOC_1 Property
        /// </summary>
        public static readonly DependencyProperty LOC_1Property =
            DependencyProperty.Register("LOC_1", typeof(string), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the LOC_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOC_1
        {
            get { return (string)this.GetValue(LOC_1Property); }
            set { this.SetValue(LOC_1Property, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(FP_AIN));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_AIN));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_AIN));

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
        /// PAROVL Property
        /// </summary>
        public static readonly DependencyProperty PAROVLProperty =
            DependencyProperty.Register("PAROVL", typeof(string), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL
        {
            get { return (string)this.GetValue(PAROVLProperty); }
            set { this.SetValue(PAROVLProperty, value); }
        }

        /// <summary>
        /// C_NAME Property
        /// </summary>
        public static readonly DependencyProperty C_NAMEProperty =
            DependencyProperty.Register("C_NAME", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the C_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool C_NAME
        {
            get { return (bool)this.GetValue(C_NAMEProperty); }
            set { this.SetValue(C_NAMEProperty, value); }
        }

        /// <summary>
        /// B_NAME Property
        /// </summary>
        public static readonly DependencyProperty B_NAMEProperty =
            DependencyProperty.Register("B_NAME", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the B_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool B_NAME
        {
            get { return (bool)this.GetValue(B_NAMEProperty); }
            set { this.SetValue(B_NAMEProperty, value); }
        }

        /// <summary>
        /// _DESCRP Property
        /// </summary>
        public static readonly DependencyProperty _DESCRPProperty =
            DependencyProperty.Register("_DESCRP", typeof(string), typeof(FP_AIN));

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
        /// TRNDVIEW Property
        /// </summary>
        public static readonly DependencyProperty TRNDVIEWProperty =
            DependencyProperty.Register("TRNDVIEW", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the TRNDVIEW.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRNDVIEW
        {
            get { return (bool)this.GetValue(TRNDVIEWProperty); }
            set { this.SetValue(TRNDVIEWProperty, value); }
        }

        /// <summary>
        /// _HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty _HSCI1Property =
            DependencyProperty.Register("_HSCI1", typeof(double), typeof(FP_AIN));

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
        /// _LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty _LSCI1Property =
            DependencyProperty.Register("_LSCI1", typeof(double), typeof(FP_AIN));

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
        /// FLAG Property
        /// </summary>
        public static readonly DependencyProperty FLAGProperty =
            DependencyProperty.Register("FLAG", typeof(bool), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the FLAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FLAG
        {
            get { return (bool)this.GetValue(FLAGProperty); }
            set { this.SetValue(FLAGProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_AIN));

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
        /// ACK_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_AIN));

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
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_AIN));

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
        /// TREND_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR1Property =
            DependencyProperty.Register("TREND_CMPBLKPAR1", typeof(string), typeof(FP_AIN));

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
        /// TREND_Identity Property
        /// </summary>
        public static readonly DependencyProperty TREND_IdentityProperty =
            DependencyProperty.Register("TREND_Identity", typeof(string), typeof(FP_AIN));

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
        /// TREND_CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR2Property =
            DependencyProperty.Register("TREND_CMPBLKPAR2", typeof(string), typeof(FP_AIN));

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
        /// TREND_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty TREND_CMPBLKPAR3Property =
            DependencyProperty.Register("TREND_CMPBLKPAR3", typeof(string), typeof(FP_AIN));

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
            DependencyProperty.Register("TREND_CMPBLKPAR4", typeof(string), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_EU", typeof(string), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P_Max", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_MEAS_CB_P_Min", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_PNT_CB_EU", typeof(string), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P_Max", typeof(double), typeof(FP_AIN));

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
            DependencyProperty.Register("Faceplate_Body_PNT_CB_P_Min", typeof(double), typeof(FP_AIN));

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
        /// Faceplate_Body_Bar_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PV", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PvRangeFullScaleMax", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PVRangeFullScaleMin", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_MoveUp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Flag_AlarmLimits_MoveUp
        {
            get { return (int)this.GetValue(Flag_AlarmLimits_MoveUpProperty); }
            set { this.SetValue(Flag_AlarmLimits_MoveUpProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_HAL Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_HALProperty =
            DependencyProperty.Register("Flag_AlarmLimits_HAL", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_HAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_HAL
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_HALProperty); }
            set { this.SetValue(Flag_AlarmLimits_HALProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_HHALIM Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_HHALIMProperty =
            DependencyProperty.Register("Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_HHALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_HHALIM
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_HHALIMProperty); }
            set { this.SetValue(Flag_AlarmLimits_HHALIMProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_HHAOPTProperty =
            DependencyProperty.Register("Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Flag_AlarmLimits_HHAOPT
        {
            get { return (int)this.GetValue(Flag_AlarmLimits_HHAOPTProperty); }
            set { this.SetValue(Flag_AlarmLimits_HHAOPTProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_HLOP Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_HLOPProperty =
            DependencyProperty.Register("Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_HLOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Flag_AlarmLimits_HLOP
        {
            get { return (int)this.GetValue(Flag_AlarmLimits_HLOPProperty); }
            set { this.SetValue(Flag_AlarmLimits_HLOPProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_LAL Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_LALProperty =
            DependencyProperty.Register("Flag_AlarmLimits_LAL", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_LAL
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_LALProperty); }
            set { this.SetValue(Flag_AlarmLimits_LALProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_LLALIM Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_LLALIMProperty =
            DependencyProperty.Register("Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_LLALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_LLALIM
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_LLALIMProperty); }
            set { this.SetValue(Flag_AlarmLimits_LLALIMProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_MaxRange Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MaxRangeProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_MaxRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_MaxRange
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_MaxRangeProperty); }
            set { this.SetValue(Flag_AlarmLimits_MaxRangeProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_MinRange Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MinRangeProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_MinRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Flag_AlarmLimits_MinRange
        {
            get { return (double)this.GetValue(Flag_AlarmLimits_MinRangeProperty); }
            set { this.SetValue(Flag_AlarmLimits_MinRangeProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_MoveDown Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MoveDownProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_AIN));

        /// <summary>
        /// Gets or sets the Flag_AlarmLimits_MoveDown.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Flag_AlarmLimits_MoveDown
        {
            get { return (int)this.GetValue(Flag_AlarmLimits_MoveDownProperty); }
            set { this.SetValue(Flag_AlarmLimits_MoveDownProperty, value); }
        }


		
    }
}
