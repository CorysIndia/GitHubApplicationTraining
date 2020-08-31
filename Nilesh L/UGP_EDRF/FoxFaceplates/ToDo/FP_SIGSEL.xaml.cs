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
	[Export("FP_SIGSEL")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_SIGSEL
    {
        public FP_SIGSEL()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_SIGSEL));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_SIGSEL));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_SIGSEL));

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
        /// SELOPT Property
        /// </summary>
        public static readonly DependencyProperty SELOPTProperty =
            DependencyProperty.Register("SELOPT", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the SELOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SELOPT
        {
            get { return (int)this.GetValue(SELOPTProperty); }
            set { this.SetValue(SELOPTProperty, value); }
        }

        /// <summary>
        /// SELNDX Property
        /// </summary>
        public static readonly DependencyProperty SELNDXProperty =
            DependencyProperty.Register("SELNDX", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the SELNDX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SELNDX
        {
            get { return (double)this.GetValue(SELNDXProperty); }
            set { this.SetValue(SELNDXProperty, value); }
        }

        /// <summary>
        /// EO1 Property
        /// </summary>
        public static readonly DependencyProperty EO1Property =
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_SIGSEL));

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
        /// OP Property
        /// </summary>
        public static readonly DependencyProperty OPProperty =
            DependencyProperty.Register("OP", typeof(double), typeof(FP_SIGSEL));

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
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_SIGSEL));

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
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_SIGSEL));

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
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_SIGSEL));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_SIGSEL));

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
        /// INHSTA Property
        /// </summary>
        public static readonly DependencyProperty INHSTAProperty =
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_SIGSEL));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_SIGSEL));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_SIGSEL));

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
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_SIGSEL));

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
        /// SGUG_CallTrendOvl1_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_CallTrendOvl1_CMPBLKPAR1Property =
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR1", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("SGUG_CallTrendOvl1_Identity", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR2", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR3", typeof(string), typeof(FP_SIGSEL));

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
            DependencyProperty.Register("SGUG_CallTrendOvl1_CMPBLKPAR4", typeof(string), typeof(FP_SIGSEL));

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
        /// Faceplate_Body_FP_Value_PNT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_EU", typeof(string), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_FP_Value_PNT_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_FP_Value_PNT_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P_Max", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P_Min", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PV", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PNT_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PNT_PVProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PvRangeFullScaleMax", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PNT_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PNT_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PVRangeFullScaleMin", typeof(double), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Bar_PNT_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_Bar_PNT_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_CRIT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_CRITProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_CRIT", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_PNT_CRIT
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_PNT_CRITProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_CRITProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_INHOPT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_INHOPTProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHOPT", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_PNT_INHOPT
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_PNT_INHOPTProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_INHOPTProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_INHSTA Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_INHSTAProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHSTA", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_PNT_INHSTA
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_PNT_INHSTAProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_INHSTAProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PRTYPEProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PRTYPE", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_PNT_PRTYPE
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_PNT_PRTYPEProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_PRTYPEProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_UNACK Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_UNACKProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_UNACK", typeof(bool), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_PNT_UNACK
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_PNT_UNACKProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_UNACKProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_AlarmStateChanged Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_AlarmStateChangedProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_AlarmStateChanged", typeof(int), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_AlarmStateChanged.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_Bar_PNT_AlarmStateChanged
        {
            get { return (int)this.GetValue(Faceplate_Body_Bar_PNT_AlarmStateChangedProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_AlarmStateChangedProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_PNT_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_ShowInhibState", typeof(bool), typeof(FP_SIGSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Bar_PNT_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_Bar_PNT_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_Bar_PNT_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_Bar_PNT_ShowInhibStateProperty, value); }
        }


		
    }
}
