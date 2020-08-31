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
	[Export("FP_ACCUM")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_ACCUM
    {
        public FP_ACCUM()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_ACCUM));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_ACCUM));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_ACCUM));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_ACCUM));

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
        /// MEAS Property
        /// </summary>
        public static readonly DependencyProperty MEASProperty =
            DependencyProperty.Register("MEAS", typeof(double), typeof(FP_ACCUM));

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
        /// OP Property
        /// </summary>
        public static readonly DependencyProperty OPProperty =
            DependencyProperty.Register("OP", typeof(double), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OP
        {
            get { return (double)this.GetValue(OPProperty); }
            set { this.SetValue(OPProperty, value); }
        }

        /// <summary>
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_ACCUM));

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
        /// HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty HSCI1Property =
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_ACCUM));

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
        /// LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty LSCI1Property =
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_ACCUM));

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
        /// CLEAR Property
        /// </summary>
        public static readonly DependencyProperty CLEARProperty =
            DependencyProperty.Register("CLEAR", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the CLEAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CLEAR
        {
            get { return (bool)this.GetValue(CLEARProperty); }
            set { this.SetValue(CLEARProperty, value); }
        }

        /// <summary>
        /// SET Property
        /// </summary>
        public static readonly DependencyProperty SETProperty =
            DependencyProperty.Register("SET", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SET.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SET
        {
            get { return (bool)this.GetValue(SETProperty); }
            set { this.SetValue(SETProperty, value); }
        }

        /// <summary>
        /// HOLD Property
        /// </summary>
        public static readonly DependencyProperty HOLDProperty =
            DependencyProperty.Register("HOLD", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HOLD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HOLD
        {
            get { return (bool)this.GetValue(HOLDProperty); }
            set { this.SetValue(HOLDProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_ACCUM));

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
        /// HABLIM Property
        /// </summary>
        public static readonly DependencyProperty HABLIMProperty =
            DependencyProperty.Register("HABLIM", typeof(double), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HABLIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HABLIM
        {
            get { return (double)this.GetValue(HABLIMProperty); }
            set { this.SetValue(HABLIMProperty, value); }
        }

        /// <summary>
        /// HHALIM Property
        /// </summary>
        public static readonly DependencyProperty HHALIMProperty =
            DependencyProperty.Register("HHALIM", typeof(double), typeof(FP_ACCUM));

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
        /// HHAIND Property
        /// </summary>
        public static readonly DependencyProperty HHAINDProperty =
            DependencyProperty.Register("HHAIND", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HHAIND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HHAIND
        {
            get { return (bool)this.GetValue(HHAINDProperty); }
            set { this.SetValue(HHAINDProperty, value); }
        }

        /// <summary>
        /// HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty HHAOPTProperty =
            DependencyProperty.Register("HHAOPT", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HHAOPT
        {
            get { return (bool)this.GetValue(HHAOPTProperty); }
            set { this.SetValue(HHAOPTProperty, value); }
        }

        /// <summary>
        /// HAOPT Property
        /// </summary>
        public static readonly DependencyProperty HAOPTProperty =
            DependencyProperty.Register("HAOPT", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HAOPT
        {
            get { return (bool)this.GetValue(HAOPTProperty); }
            set { this.SetValue(HAOPTProperty, value); }
        }

        /// <summary>
        /// HAIND Property
        /// </summary>
        public static readonly DependencyProperty HAINDProperty =
            DependencyProperty.Register("HAIND", typeof(bool), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HAIND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HAIND
        {
            get { return (bool)this.GetValue(HAINDProperty); }
            set { this.SetValue(HAINDProperty, value); }
        }

        /// <summary>
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_ACCUM));

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
        /// HS Property
        /// </summary>
        public static readonly DependencyProperty HSProperty =
            DependencyProperty.Register("HS", typeof(double), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the HS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HS
        {
            get { return (double)this.GetValue(HSProperty); }
            set { this.SetValue(HSProperty, value); }
        }

        /// <summary>
        /// LS Property
        /// </summary>
        public static readonly DependencyProperty LSProperty =
            DependencyProperty.Register("LS", typeof(double), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the LS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LS
        {
            get { return (double)this.GetValue(LSProperty); }
            set { this.SetValue(LSProperty, value); }
        }

        /// <summary>
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(double), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the PICK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PICK
        {
            get { return (double)this.GetValue(PICKProperty); }
            set { this.SetValue(PICKProperty, value); }
        }

        /// <summary>
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(int), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Selected
        {
            get { return (int)this.GetValue(SelectedProperty); }
            set { this.SetValue(SelectedProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_ACCUM));

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
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_ACCUM));

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
        /// SGUG_CallTrendOvl1_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_CMPBLKPAR1Property =
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR1", typeof(string), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SGUG_CallTrendOvl1_CMPBLKPAR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SGUG_CallTrendOvl1_CMPBLKPAR1
        {
            get { return (string)this.GetValue(SGUG_CallTrendOvl1_CMPBLKPAR1Property); }
            set { this.SetValue(SGUG_CallTrendOvl1_CMPBLKPAR1Property, value); }
        }

        /// <summary>
        /// SGUG_CallTrendOvl1_Identity Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_IdentityProperty =
            DependencyProperty.Register("SGUG_CallTrendOvl1_Identity", typeof(string), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SGUG_CallTrendOvl1_Identity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Compound+BLock")]
        public string SGUG_CallTrendOvl1_Identity
        {
            get { return (string)this.GetValue(SGUG_CallTrendOvl1_IdentityProperty); }
            set { this.SetValue(SGUG_CallTrendOvl1_IdentityProperty, value); }
        }

        /// <summary>
        /// SGUG_CallTrendOvl1_CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_CMPBLKPAR2Property =
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR2", typeof(string), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SGUG_CallTrendOvl1_CMPBLKPAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SGUG_CallTrendOvl1_CMPBLKPAR2
        {
            get { return (string)this.GetValue(SGUG_CallTrendOvl1_CMPBLKPAR2Property); }
            set { this.SetValue(SGUG_CallTrendOvl1_CMPBLKPAR2Property, value); }
        }

        /// <summary>
        /// SGUG_CallTrendOvl1_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_CMPBLKPAR3Property =
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR3", typeof(string), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SGUG_CallTrendOvl1_CMPBLKPAR3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SGUG_CallTrendOvl1_CMPBLKPAR3
        {
            get { return (string)this.GetValue(SGUG_CallTrendOvl1_CMPBLKPAR3Property); }
            set { this.SetValue(SGUG_CallTrendOvl1_CMPBLKPAR3Property, value); }
        }

        /// <summary>
        /// SGUG_CallTrendOvl1_CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_CMPBLKPAR4Property =
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR4", typeof(string), typeof(FP_ACCUM));

        /// <summary>
        /// Gets or sets the SGUG_CallTrendOvl1_CMPBLKPAR4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SGUG_CallTrendOvl1_CMPBLKPAR4
        {
            get { return (string)this.GetValue(SGUG_CallTrendOvl1_CMPBLKPAR4Property); }
            set { this.SetValue(SGUG_CallTrendOvl1_CMPBLKPAR4Property, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_MEAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_EU", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Max", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Min", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_EU", typeof(string), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Max", typeof(double), typeof(FP_ACCUM));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Min", typeof(double), typeof(FP_ACCUM));

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


		
    }
}
