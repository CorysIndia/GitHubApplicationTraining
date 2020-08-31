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
	[Export("FP_PID")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_PID
    {
        public FP_PID()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_PID));

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
            DependencyProperty.Register("CB_NAME", typeof(string), typeof(FP_PID));

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
        /// BP Property
        /// </summary>
        public static readonly DependencyProperty BPProperty =
            DependencyProperty.Register("BP", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP
        {
            get { return (bool)this.GetValue(BPProperty); }
            set { this.SetValue(BPProperty, value); }
        }

        /// <summary>
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the EI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI1
        {
            get { return (string)this.GetValue(EI1Property); }
            set { this.SetValue(EI1Property, value); }
        }

        /// <summary>
        /// EO1 Property
        /// </summary>
        public static readonly DependencyProperty EO1Property =
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_PID));

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
        /// MEASHL Property
        /// </summary>
        public static readonly DependencyProperty MEASHLProperty =
            DependencyProperty.Register("MEASHL", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the MEASHL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MEASHL
        {
            get { return (double)this.GetValue(MEASHLProperty); }
            set { this.SetValue(MEASHLProperty, value); }
        }

        /// <summary>
        /// HHALIM Property
        /// </summary>
        public static readonly DependencyProperty HHALIMProperty =
            DependencyProperty.Register("HHALIM", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the HHALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HHALIM
        {
            get { return (double)this.GetValue(HHALIMProperty); }
            set { this.SetValue(HHALIMProperty, value); }
        }

        /// <summary>
        /// HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty HHAOPTProperty =
            DependencyProperty.Register("HHAOPT", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HHAOPT
        {
            get { return (int)this.GetValue(HHAOPTProperty); }
            set { this.SetValue(HHAOPTProperty, value); }
        }

        /// <summary>
        /// MALOPT Property
        /// </summary>
        public static readonly DependencyProperty MALOPTProperty =
            DependencyProperty.Register("MALOPT", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the MALOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MALOPT
        {
            get { return (int)this.GetValue(MALOPTProperty); }
            set { this.SetValue(MALOPTProperty, value); }
        }

        /// <summary>
        /// HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty HSCI1Property =
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the HSCI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCI1
        {
            get { return (double)this.GetValue(HSCI1Property); }
            set { this.SetValue(HSCI1Property, value); }
        }

        /// <summary>
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_PID));

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
        /// MEASLL Property
        /// </summary>
        public static readonly DependencyProperty MEASLLProperty =
            DependencyProperty.Register("MEASLL", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the MEASLL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MEASLL
        {
            get { return (double)this.GetValue(MEASLLProperty); }
            set { this.SetValue(MEASLLProperty, value); }
        }

        /// <summary>
        /// LLALIM Property
        /// </summary>
        public static readonly DependencyProperty LLALIMProperty =
            DependencyProperty.Register("LLALIM", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the LLALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LLALIM
        {
            get { return (double)this.GetValue(LLALIMProperty); }
            set { this.SetValue(LLALIMProperty, value); }
        }

        /// <summary>
        /// LR Property
        /// </summary>
        public static readonly DependencyProperty LRProperty =
            DependencyProperty.Register("LR", typeof(bool), typeof(FP_PID));

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
        /// LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty LSCI1Property =
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the LSCI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCI1
        {
            get { return (double)this.GetValue(LSCI1Property); }
            set { this.SetValue(LSCI1Property, value); }
        }

        /// <summary>
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_PID));

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
            DependencyProperty.Register("MEAS", typeof(double), typeof(FP_PID));

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
        /// OUTPUT Property
        /// </summary>
        public static readonly DependencyProperty OUTPUTProperty =
            DependencyProperty.Register("OUTPUT", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the OUTPUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OUTPUT
        {
            get { return (double)this.GetValue(OUTPUTProperty); }
            set { this.SetValue(OUTPUTProperty, value); }
        }

        /// <summary>
        /// RSP Property
        /// </summary>
        public static readonly DependencyProperty RSPProperty =
            DependencyProperty.Register("RSP", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the RSP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RSP
        {
            get { return (double)this.GetValue(RSPProperty); }
            set { this.SetValue(RSPProperty, value); }
        }

        /// <summary>
        /// SP_RAMP Property
        /// </summary>
        public static readonly DependencyProperty SP_RAMPProperty =
            DependencyProperty.Register("SP_RAMP", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the SP_RAMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SP_RAMP
        {
            get { return (bool)this.GetValue(SP_RAMPProperty); }
            set { this.SetValue(SP_RAMPProperty, value); }
        }

        /// <summary>
        /// SPT Property
        /// </summary>
        public static readonly DependencyProperty SPTProperty =
            DependencyProperty.Register("SPT", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the SPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SPT
        {
            get { return (double)this.GetValue(SPTProperty); }
            set { this.SetValue(SPTProperty, value); }
        }

        /// <summary>
        /// MA_LOCK Property
        /// </summary>
        public static readonly DependencyProperty MA_LOCKProperty =
            DependencyProperty.Register("MA_LOCK", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the MA_LOCK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MA_LOCK
        {
            get { return (bool)this.GetValue(MA_LOCKProperty); }
            set { this.SetValue(MA_LOCKProperty, value); }
        }

        /// <summary>
        /// LR_LOCK Property
        /// </summary>
        public static readonly DependencyProperty LR_LOCKProperty =
            DependencyProperty.Register("LR_LOCK", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the LR_LOCK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LR_LOCK
        {
            get { return (bool)this.GetValue(LR_LOCKProperty); }
            set { this.SetValue(LR_LOCKProperty, value); }
        }

        /// <summary>
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_PID));

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
        /// INHOPT Property
        /// </summary>
        public static readonly DependencyProperty INHOPTProperty =
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_PID));

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
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_PID));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_PID));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_PID));

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
        /// INTCHID Property
        /// </summary>
        public static readonly DependencyProperty INTCHIDProperty =
            DependencyProperty.Register("INTCHID", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the INTCHID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INTCHID
        {
            get { return (int)this.GetValue(INTCHIDProperty); }
            set { this.SetValue(INTCHIDProperty, value); }
        }

        /// <summary>
        /// LOCSW Property
        /// </summary>
        public static readonly DependencyProperty LOCSWProperty =
            DependencyProperty.Register("LOCSW", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the LOCSW.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LOCSW
        {
            get { return (bool)this.GetValue(LOCSWProperty); }
            set { this.SetValue(LOCSWProperty, value); }
        }

        /// <summary>
        /// REMSW Property
        /// </summary>
        public static readonly DependencyProperty REMSWProperty =
            DependencyProperty.Register("REMSW", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the REMSW.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool REMSW
        {
            get { return (bool)this.GetValue(REMSWProperty); }
            set { this.SetValue(REMSWProperty, value); }
        }

        /// <summary>
        /// MANSW Property
        /// </summary>
        public static readonly DependencyProperty MANSWProperty =
            DependencyProperty.Register("MANSW", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the MANSW.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MANSW
        {
            get { return (bool)this.GetValue(MANSWProperty); }
            set { this.SetValue(MANSWProperty, value); }
        }

        /// <summary>
        /// AUTSW Property
        /// </summary>
        public static readonly DependencyProperty AUTSWProperty =
            DependencyProperty.Register("AUTSW", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the AUTSW.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AUTSW
        {
            get { return (bool)this.GetValue(AUTSWProperty); }
            set { this.SetValue(AUTSWProperty, value); }
        }

        /// <summary>
        /// INITMA Property
        /// </summary>
        public static readonly DependencyProperty INITMAProperty =
            DependencyProperty.Register("INITMA", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the INITMA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INITMA
        {
            get { return (int)this.GetValue(INITMAProperty); }
            set { this.SetValue(INITMAProperty, value); }
        }

        /// <summary>
        /// INITLR Property
        /// </summary>
        public static readonly DependencyProperty INITLRProperty =
            DependencyProperty.Register("INITLR", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the INITLR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INITLR
        {
            get { return (int)this.GetValue(INITLRProperty); }
            set { this.SetValue(INITLRProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_PID));

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
        /// SHFP Property
        /// </summary>
        public static readonly DependencyProperty SHFPProperty =
            DependencyProperty.Register("SHFP", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the SHFP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SHFP
        {
            get { return (bool)this.GetValue(SHFPProperty); }
            set { this.SetValue(SHFPProperty, value); }
        }

        /// <summary>
        /// CurrentDisp Property
        /// </summary>
        public static readonly DependencyProperty CurrentDispProperty =
            DependencyProperty.Register("CurrentDisp", typeof(int), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the CurrentDisp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CurrentDisp
        {
            get { return (int)this.GetValue(CurrentDispProperty); }
            set { this.SetValue(CurrentDispProperty, value); }
        }

        /// <summary>
        /// CB Property
        /// </summary>
        public static readonly DependencyProperty CBProperty =
            DependencyProperty.Register("CB", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB
        {
            get { return (string)this.GetValue(CBProperty); }
            set { this.SetValue(CBProperty, value); }
        }

        /// <summary>
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_PID));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_PID));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_PID));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_PID));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_PID));

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
        /// HSCI2 Property
        /// </summary>
        public static readonly DependencyProperty HSCI2Property =
            DependencyProperty.Register("HSCI2", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the HSCI2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCI2
        {
            get { return (double)this.GetValue(HSCI2Property); }
            set { this.SetValue(HSCI2Property, value); }
        }

        /// <summary>
        /// LSCI2 Property
        /// </summary>
        public static readonly DependencyProperty LSCI2Property =
            DependencyProperty.Register("LSCI2", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the LSCI2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCI2
        {
            get { return (double)this.GetValue(LSCI2Property); }
            set { this.SetValue(LSCI2Property, value); }
        }

        /// <summary>
        /// EI2 Property
        /// </summary>
        public static readonly DependencyProperty EI2Property =
            DependencyProperty.Register("EI2", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the EI2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI2
        {
            get { return (string)this.GetValue(EI2Property); }
            set { this.SetValue(EI2Property, value); }
        }

        /// <summary>
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(FP_PID));

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
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_PID));

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
        /// Ramp_Arrows_Buttons_INC_DEC21_PV Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_Buttons_INC_DEC21_PVProperty =
            DependencyProperty.Register("Ramp_Arrows_Buttons_INC_DEC21_PV", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_Buttons_INC_DEC21_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_Buttons_INC_DEC21_PV
        {
            get { return (double)this.GetValue(Ramp_Arrows_Buttons_INC_DEC21_PVProperty); }
            set { this.SetValue(Ramp_Arrows_Buttons_INC_DEC21_PVProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_Buttons_INC_DEC21_PV_Max Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_Buttons_INC_DEC21_PV_MaxProperty =
            DependencyProperty.Register("Ramp_Arrows_Buttons_INC_DEC21_PV_Max", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_Buttons_INC_DEC21_PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_Buttons_INC_DEC21_PV_Max
        {
            get { return (double)this.GetValue(Ramp_Arrows_Buttons_INC_DEC21_PV_MaxProperty); }
            set { this.SetValue(Ramp_Arrows_Buttons_INC_DEC21_PV_MaxProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_Buttons_INC_DEC21_PV_Min Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_Buttons_INC_DEC21_PV_MinProperty =
            DependencyProperty.Register("Ramp_Arrows_Buttons_INC_DEC21_PV_Min", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_Buttons_INC_DEC21_PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_Buttons_INC_DEC21_PV_Min
        {
            get { return (double)this.GetValue(Ramp_Arrows_Buttons_INC_DEC21_PV_MinProperty); }
            set { this.SetValue(Ramp_Arrows_Buttons_INC_DEC21_PV_MinProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_Buttons_INC_DEC21_option Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_Buttons_INC_DEC21_optionProperty =
            DependencyProperty.Register("Ramp_Arrows_Buttons_INC_DEC21_option", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_Buttons_INC_DEC21_option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Ramp_Arrows_Buttons_INC_DEC21_option
        {
            get { return (string)this.GetValue(Ramp_Arrows_Buttons_INC_DEC21_optionProperty); }
            set { this.SetValue(Ramp_Arrows_Buttons_INC_DEC21_optionProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_EmbeddedSymbol1_PV Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_EmbeddedSymbol1_PVProperty =
            DependencyProperty.Register("Ramp_Arrows_EmbeddedSymbol1_PV", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_EmbeddedSymbol1_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_EmbeddedSymbol1_PV
        {
            get { return (double)this.GetValue(Ramp_Arrows_EmbeddedSymbol1_PVProperty); }
            set { this.SetValue(Ramp_Arrows_EmbeddedSymbol1_PVProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_EmbeddedSymbol1_PV_Max Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_EmbeddedSymbol1_PV_MaxProperty =
            DependencyProperty.Register("Ramp_Arrows_EmbeddedSymbol1_PV_Max", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_EmbeddedSymbol1_PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_EmbeddedSymbol1_PV_Max
        {
            get { return (double)this.GetValue(Ramp_Arrows_EmbeddedSymbol1_PV_MaxProperty); }
            set { this.SetValue(Ramp_Arrows_EmbeddedSymbol1_PV_MaxProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_EmbeddedSymbol1_PV_Min Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_EmbeddedSymbol1_PV_MinProperty =
            DependencyProperty.Register("Ramp_Arrows_EmbeddedSymbol1_PV_Min", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_EmbeddedSymbol1_PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Ramp_Arrows_EmbeddedSymbol1_PV_Min
        {
            get { return (double)this.GetValue(Ramp_Arrows_EmbeddedSymbol1_PV_MinProperty); }
            set { this.SetValue(Ramp_Arrows_EmbeddedSymbol1_PV_MinProperty, value); }
        }

        /// <summary>
        /// Ramp_Arrows_EmbeddedSymbol1_option Property
        /// </summary>
        public static readonly DependencyProperty Ramp_Arrows_EmbeddedSymbol1_optionProperty =
            DependencyProperty.Register("Ramp_Arrows_EmbeddedSymbol1_option", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Ramp_Arrows_EmbeddedSymbol1_option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Ramp_Arrows_EmbeddedSymbol1_option
        {
            get { return (string)this.GetValue(Ramp_Arrows_EmbeddedSymbol1_optionProperty); }
            set { this.SetValue(Ramp_Arrows_EmbeddedSymbol1_optionProperty, value); }
        }

        /// <summary>
        /// ACL_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACL_CB_NAMEProperty =
            DependencyProperty.Register("ACL_CB_NAME", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the ACL_CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACL_CB_NAME
        {
            get { return (string)this.GetValue(ACL_CB_NAMEProperty); }
            set { this.SetValue(ACL_CB_NAMEProperty, value); }
        }

        /// <summary>
        /// RL_Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty RL_Command_BitProperty =
            DependencyProperty.Register("RL_Command_Bit", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the RL_Command_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool RL_Command_Bit
        {
            get { return (bool)this.GetValue(RL_Command_BitProperty); }
            set { this.SetValue(RL_Command_BitProperty, value); }
        }

        /// <summary>
        /// RL_FeedBack_Bit Property
        /// </summary>
        public static readonly DependencyProperty RL_FeedBack_BitProperty =
            DependencyProperty.Register("RL_FeedBack_Bit", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the RL_FeedBack_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool RL_FeedBack_Bit
        {
            get { return (bool)this.GetValue(RL_FeedBack_BitProperty); }
            set { this.SetValue(RL_FeedBack_BitProperty, value); }
        }

        /// <summary>
        /// RL_OFF_Message Property
        /// </summary>
        public static readonly DependencyProperty RL_OFF_MessageProperty =
            DependencyProperty.Register("RL_OFF_Message", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the RL_OFF_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RL_OFF_Message
        {
            get { return (string)this.GetValue(RL_OFF_MessageProperty); }
            set { this.SetValue(RL_OFF_MessageProperty, value); }
        }

        /// <summary>
        /// RL_ON_Message Property
        /// </summary>
        public static readonly DependencyProperty RL_ON_MessageProperty =
            DependencyProperty.Register("RL_ON_Message", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the RL_ON_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RL_ON_Message
        {
            get { return (string)this.GetValue(RL_ON_MessageProperty); }
            set { this.SetValue(RL_ON_MessageProperty, value); }
        }

        /// <summary>
        /// AM_Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty AM_Command_BitProperty =
            DependencyProperty.Register("AM_Command_Bit", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the AM_Command_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AM_Command_Bit
        {
            get { return (bool)this.GetValue(AM_Command_BitProperty); }
            set { this.SetValue(AM_Command_BitProperty, value); }
        }

        /// <summary>
        /// AM_FeedBack_Bit Property
        /// </summary>
        public static readonly DependencyProperty AM_FeedBack_BitProperty =
            DependencyProperty.Register("AM_FeedBack_Bit", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the AM_FeedBack_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AM_FeedBack_Bit
        {
            get { return (bool)this.GetValue(AM_FeedBack_BitProperty); }
            set { this.SetValue(AM_FeedBack_BitProperty, value); }
        }

        /// <summary>
        /// AM_OFF_Message Property
        /// </summary>
        public static readonly DependencyProperty AM_OFF_MessageProperty =
            DependencyProperty.Register("AM_OFF_Message", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the AM_OFF_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AM_OFF_Message
        {
            get { return (string)this.GetValue(AM_OFF_MessageProperty); }
            set { this.SetValue(AM_OFF_MessageProperty, value); }
        }

        /// <summary>
        /// AM_ON_Message Property
        /// </summary>
        public static readonly DependencyProperty AM_ON_MessageProperty =
            DependencyProperty.Register("AM_ON_Message", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the AM_ON_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AM_ON_Message
        {
            get { return (string)this.GetValue(AM_ON_MessageProperty); }
            set { this.SetValue(AM_ON_MessageProperty, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR1Property =
            DependencyProperty.Register("Trend_CMPBLKPAR1", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR1
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR1Property); }
            set { this.SetValue(Trend_CMPBLKPAR1Property, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR2Property =
            DependencyProperty.Register("Trend_CMPBLKPAR2", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR2
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR2Property); }
            set { this.SetValue(Trend_CMPBLKPAR2Property, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR3Property =
            DependencyProperty.Register("Trend_CMPBLKPAR3", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR3
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR3Property); }
            set { this.SetValue(Trend_CMPBLKPAR3Property, value); }
        }

        /// <summary>
        /// Trend_Identity Property
        /// </summary>
        public static readonly DependencyProperty Trend_IdentityProperty =
            DependencyProperty.Register("Trend_Identity", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Trend_Identity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Compound+BLock")]
        public string Trend_Identity
        {
            get { return (string)this.GetValue(Trend_IdentityProperty); }
            set { this.SetValue(Trend_IdentityProperty, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR4Property =
            DependencyProperty.Register("Trend_CMPBLKPAR4", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR4
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR4Property); }
            set { this.SetValue(Trend_CMPBLKPAR4Property, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_MEAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_EU", typeof(string), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_MEAS_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_FP_Value_MEAS_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_FP_Value_MEAS_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_MEAS_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_MEAS_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_MEAS_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_MEAS_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_MEAS_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_MEAS_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_MEAS_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Max", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_MEAS_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_MEAS_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_MEAS_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_MEAS_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_MEAS_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Min", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_MEAS_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_MEAS_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_MEAS_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_MEAS_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_OUT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_EU", typeof(string), typeof(FP_PID));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Max", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Min", typeof(double), typeof(FP_PID));

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
        /// Faceplate_Body_Bar_OUT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_OUT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PV", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_OUT_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_OUT_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_OUT_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_OUT_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_OUT_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_OUT_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PvRangeFullScaleMax", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_OUT_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_OUT_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_OUT_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_OUT_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_OUT_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_OUT_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PVRangeFullScaleMin", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_OUT_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_OUT_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_OUT_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_OUT_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_OUT_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_OUT_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_ShowInhibState", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_OUT_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_OUT_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_OUT_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_Bar_OUT_ShowInhibStateProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_SPT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_SPT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_SPT_PV", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_SPT_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_SPT_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_SPT_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_SPT_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_SPT_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_SPT_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_SPT_PvRangeFullScaleMax", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_SPT_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_SPT_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_SPT_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_SPT_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_SPT_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_SPT_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_SPT_PVRangeFullScaleMin", typeof(double), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_SPT_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_SPT_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_SPT_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_SPT_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_SPT_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_SPT_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_SPT_ShowInhibState", typeof(bool), typeof(FP_PID));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_SPT_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_SPT_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_SPT_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_Bar_SPT_ShowInhibStateProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin", typeof(double), typeof(FP_PID));

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
        /// Faceplate_Body_Bar_MEAS_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PV", typeof(double), typeof(FP_PID));

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
        /// Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_HAL", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_LAL", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_PID));

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
            DependencyProperty.Register("Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_PID));

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
