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
	[Export("FP_RIN")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_RIN
    {
        public FP_RIN()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_RIN));

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
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_RIN));

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
        /// MEAS Property
        /// </summary>
        public static readonly DependencyProperty MEASProperty =
            DependencyProperty.Register("MEAS", typeof(double), typeof(FP_RIN));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_RIN));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_RIN));

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
        /// HAL Property
        /// </summary>
        public static readonly DependencyProperty HALProperty =
            DependencyProperty.Register("HAL", typeof(double), typeof(FP_RIN));

        /// <summary>
        /// Gets or sets the HAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HAL
        {
            get { return (double)this.GetValue(HALProperty); }
            set { this.SetValue(HALProperty, value); }
        }

        /// <summary>
        /// HHALIM Property
        /// </summary>
        public static readonly DependencyProperty HHALIMProperty =
            DependencyProperty.Register("HHALIM", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("HHAOPT", typeof(int), typeof(FP_RIN));

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
        /// HLOP Property
        /// </summary>
        public static readonly DependencyProperty HLOPProperty =
            DependencyProperty.Register("HLOP", typeof(int), typeof(FP_RIN));

        /// <summary>
        /// Gets or sets the HLOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HLOP
        {
            get { return (int)this.GetValue(HLOPProperty); }
            set { this.SetValue(HLOPProperty, value); }
        }

        /// <summary>
        /// LAL Property
        /// </summary>
        public static readonly DependencyProperty LALProperty =
            DependencyProperty.Register("LAL", typeof(double), typeof(FP_RIN));

        /// <summary>
        /// Gets or sets the LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LAL
        {
            get { return (double)this.GetValue(LALProperty); }
            set { this.SetValue(LALProperty, value); }
        }

        /// <summary>
        /// LLALIM Property
        /// </summary>
        public static readonly DependencyProperty LLALIMProperty =
            DependencyProperty.Register("LLALIM", typeof(double), typeof(FP_RIN));

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
        /// INHOPT Property
        /// </summary>
        public static readonly DependencyProperty INHOPTProperty =
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_RIN));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_RIN));

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
        /// HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty HSCI1Property =
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_RIN));

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
        /// LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty LSCI1Property =
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_RIN));

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
        /// INHSTA Property
        /// </summary>
        public static readonly DependencyProperty INHSTAProperty =
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_RIN));

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
        /// Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Close_CON1Property =
            DependencyProperty.Register("Close_CON1", typeof(bool), typeof(FP_RIN));

        /// <summary>
        /// Gets or sets the Close_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Close_CON1
        {
            get { return (bool)this.GetValue(Close_CON1Property); }
            set { this.SetValue(Close_CON1Property, value); }
        }

        /// <summary>
        /// ACK_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("TREND_CMPBLKPAR1", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("TREND_Identity", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("TREND_CMPBLKPAR2", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("TREND_CMPBLKPAR3", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("TREND_CMPBLKPAR4", typeof(string), typeof(FP_RIN));

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
        /// Faceplate_Body_FP_Value_MEAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_EU", typeof(string), typeof(FP_RIN));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Max", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Min", typeof(double), typeof(FP_RIN));

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
        /// Faceplate_Body_Bar_MEAS_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PV", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin", typeof(double), typeof(FP_RIN));

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
        /// Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_HAL", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_LAL", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_RIN));

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
            DependencyProperty.Register("Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_RIN));

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
