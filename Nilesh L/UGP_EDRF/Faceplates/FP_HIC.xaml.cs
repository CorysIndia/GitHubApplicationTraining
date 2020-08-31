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
	[Export("FP_HIC")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_HIC
    {
        public FP_HIC()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_HIC));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the DESCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCRP
        {
            get { return (string)this.GetValue(DESCRPProperty); }
            set { this.SetValue(DESCRPProperty, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_HIC));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the ALMSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALMSTA
        {
            get { return (int)this.GetValue(ALMSTAProperty); }
            set { this.SetValue(ALMSTAProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the BLKSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int BLKSTA
        {
            get { return (int)this.GetValue(BLKSTAProperty); }
            set { this.SetValue(BLKSTAProperty, value); }
        }

        /// <summary>
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_HIC));

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
        /// BIAS Property
        /// </summary>
        public static readonly DependencyProperty BIASProperty =
            DependencyProperty.Register("BIAS", typeof(string), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the BIAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BIAS
        {
            get { return (string)this.GetValue(BIASProperty); }
            set { this.SetValue(BIASProperty, value); }
        }

        /// <summary>
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CRIT
        {
            get { return (int)this.GetValue(CRITProperty); }
            set { this.SetValue(CRITProperty, value); }
        }

        /// <summary>
        /// EO1 Property
        /// </summary>
        public static readonly DependencyProperty EO1Property =
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the EO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EO1
        {
            get { return (string)this.GetValue(EO1Property); }
            set { this.SetValue(EO1Property, value); }
        }

        /// <summary>
        /// HOLIM Property
        /// </summary>
        public static readonly DependencyProperty HOLIMProperty =
            DependencyProperty.Register("HOLIM", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the HOLIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HOLIM
        {
            get { return (double)this.GetValue(HOLIMProperty); }
            set { this.SetValue(HOLIMProperty, value); }
        }

        /// <summary>
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the HSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO1
        {
            get { return (double)this.GetValue(HSCO1Property); }
            set { this.SetValue(HSCO1Property, value); }
        }

        /// <summary>
        /// INHOPT Property
        /// </summary>
        public static readonly DependencyProperty INHOPTProperty =
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INHOPT
        {
            get { return (int)this.GetValue(INHOPTProperty); }
            set { this.SetValue(INHOPTProperty, value); }
        }

        /// <summary>
        /// INHSTA Property
        /// </summary>
        public static readonly DependencyProperty INHSTAProperty =
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INHSTA
        {
            get { return (int)this.GetValue(INHSTAProperty); }
            set { this.SetValue(INHSTAProperty, value); }
        }

        /// <summary>
        /// LOLIM Property
        /// </summary>
        public static readonly DependencyProperty LOLIMProperty =
            DependencyProperty.Register("LOLIM", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the LOLIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LOLIM
        {
            get { return (double)this.GetValue(LOLIMProperty); }
            set { this.SetValue(LOLIMProperty, value); }
        }

        /// <summary>
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the LSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO1
        {
            get { return (double)this.GetValue(LSCO1Property); }
            set { this.SetValue(LSCO1Property, value); }
        }

        /// <summary>
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the MA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MA
        {
            get { return (bool)this.GetValue(MAProperty); }
            set { this.SetValue(MAProperty, value); }
        }

        /// <summary>
        /// MEAS Property
        /// </summary>
        public static readonly DependencyProperty MEASProperty =
            DependencyProperty.Register("MEAS", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the MEAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MEAS
        {
            get { return (double)this.GetValue(MEASProperty); }
            set { this.SetValue(MEASProperty, value); }
        }

        /// <summary>
        /// _OUT Property
        /// </summary>
        public static readonly DependencyProperty _OUTProperty =
            DependencyProperty.Register("_OUT", typeof(double), typeof(FP_HIC));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_HIC));

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
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_HIC));

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
        /// Increment_Decrement_Arrows_PV Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_Arrows_PVProperty =
            DependencyProperty.Register("Increment_Decrement_Arrows_PV", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Increment_Decrement_Arrows_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_Arrows_PV
        {
            get { return (double)this.GetValue(Increment_Decrement_Arrows_PVProperty); }
            set { this.SetValue(Increment_Decrement_Arrows_PVProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_Arrows_PV_Max Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_Arrows_PV_MaxProperty =
            DependencyProperty.Register("Increment_Decrement_Arrows_PV_Max", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Increment_Decrement_Arrows_PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_Arrows_PV_Max
        {
            get { return (double)this.GetValue(Increment_Decrement_Arrows_PV_MaxProperty); }
            set { this.SetValue(Increment_Decrement_Arrows_PV_MaxProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_Arrows_PV_Min Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_Arrows_PV_MinProperty =
            DependencyProperty.Register("Increment_Decrement_Arrows_PV_Min", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Increment_Decrement_Arrows_PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Increment_Decrement_Arrows_PV_Min
        {
            get { return (double)this.GetValue(Increment_Decrement_Arrows_PV_MinProperty); }
            set { this.SetValue(Increment_Decrement_Arrows_PV_MinProperty, value); }
        }

        /// <summary>
        /// Increment_Decrement_Arrows_option Property
        /// </summary>
        public static readonly DependencyProperty Increment_Decrement_Arrows_optionProperty =
            DependencyProperty.Register("Increment_Decrement_Arrows_option", typeof(string), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Increment_Decrement_Arrows_option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Increment_Decrement_Arrows_option
        {
            get { return (string)this.GetValue(Increment_Decrement_Arrows_optionProperty); }
            set { this.SetValue(Increment_Decrement_Arrows_optionProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Button_Close1_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button_Close1_CON1
        {
            get { return (bool)this.GetValue(Button_Close1_CON1Property); }
            set { this.SetValue(Button_Close1_CON1Property, value); }
        }

        /// <summary>
        /// ACK_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("TREND_CMPBLKPAR1", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("TREND_CMPBLKPAR2", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("TREND_Identity", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("TREND_CMPBLKPAR3", typeof(string), typeof(FP_HIC));

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
            DependencyProperty.Register("TREND_CMPBLKPAR4", typeof(string), typeof(FP_HIC));

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
        /// Faceplate_Body_FP_Value_OUT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_EU", typeof(string), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_OUT_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_FP_Value_OUT_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_FP_Value_OUT_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_OUT_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_OUT_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_OUT_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_OUT_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_OUT_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_OUT_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_OUT_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Max", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_OUT_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_OUT_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_OUT_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_OUT_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_OUT_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Min", typeof(double), typeof(FP_HIC));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_OUT_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_OUT_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_OUT_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_OUT_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HAL", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_LAL", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_HIC));

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
        /// Faceplate_Body_Bar_Out_CRIT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_Out_CRITProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_Out_CRIT", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_INHOPT", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_INHSTA", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PRTYPE", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PV", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PvRangeFullScaleMax", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_PVRangeFullScaleMin", typeof(double), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_UNACK", typeof(bool), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_AlarmStateChanged", typeof(int), typeof(FP_HIC));

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
            DependencyProperty.Register("Faceplate_Body_Bar_Out_ShowInhibState", typeof(bool), typeof(FP_HIC));

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
