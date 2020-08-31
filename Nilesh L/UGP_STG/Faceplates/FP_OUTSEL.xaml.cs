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
	[Export("FP_OUTSEL")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_OUTSEL
    {
        public FP_OUTSEL()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("SELOPT", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("SELNDX", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("OP", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_OUTSEL));

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
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_OUTSEL));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_OUTSEL));

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
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(int), typeof(FP_OUTSEL));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(double), typeof(FP_OUTSEL));

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
        /// IN1 Property
        /// </summary>
        public static readonly DependencyProperty IN1Property =
            DependencyProperty.Register("IN1", typeof(string), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the IN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string IN1
        {
            get { return (string)this.GetValue(IN1Property); }
            set { this.SetValue(IN1Property, value); }
        }

        /// <summary>
        /// IN2 Property
        /// </summary>
        public static readonly DependencyProperty IN2Property =
            DependencyProperty.Register("IN2", typeof(string), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the IN2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string IN2
        {
            get { return (string)this.GetValue(IN2Property); }
            set { this.SetValue(IN2Property, value); }
        }

        /// <summary>
        /// LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty LSCI1Property =
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_OUTSEL));

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
        /// HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty HSCI1Property =
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_OUTSEL));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_OUTSEL));

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
        /// HS Property
        /// </summary>
        public static readonly DependencyProperty HSProperty =
            DependencyProperty.Register("HS", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("LS", typeof(double), typeof(FP_OUTSEL));

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
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_OUTSEL));

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
        /// Faceplate_Body_Bar_PNT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PV", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PvRangeFullScaleMax", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PVRangeFullScaleMin", typeof(double), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_CRIT", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHOPT", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHSTA", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PRTYPE", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_UNACK", typeof(bool), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_AlarmStateChanged", typeof(int), typeof(FP_OUTSEL));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_ShowInhibState", typeof(bool), typeof(FP_OUTSEL));

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

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_PVProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_PV", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_PVProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMax", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMin", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_CRIT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_CRITProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_CRIT", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol3_CRIT
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol3_CRITProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_CRITProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_INHOPT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_INHOPTProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_INHOPT", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol3_INHOPT
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol3_INHOPTProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_INHOPTProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_INHSTA Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_INHSTAProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_INHSTA", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol3_INHSTA
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol3_INHSTAProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_INHSTAProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_PRTYPEProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_PRTYPE", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol3_PRTYPE
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol3_PRTYPEProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_PRTYPEProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_UNACK Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_UNACKProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_UNACK", typeof(bool), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_EmbeddedSymbol3_UNACK
        {
            get { return (bool)this.GetValue(Faceplate_Body_EmbeddedSymbol3_UNACKProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_UNACKProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_AlarmStateChanged Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_AlarmStateChangedProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_AlarmStateChanged", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_AlarmStateChanged.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol3_AlarmStateChanged
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol3_AlarmStateChangedProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_AlarmStateChangedProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_ShowInhibState", typeof(bool), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_EmbeddedSymbol3_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_EmbeddedSymbol3_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_ShowInhibStateProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_PVProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_PV", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol4_PV
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol4_PVProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_PVProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMax", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMaxProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMinProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMin", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMinProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_CRIT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_CRITProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_CRIT", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol4_CRIT
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol4_CRITProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_CRITProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_INHOPT Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_INHOPTProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_INHOPT", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol4_INHOPT
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol4_INHOPTProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_INHOPTProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_INHSTA Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_INHSTAProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_INHSTA", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol4_INHSTA
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol4_INHSTAProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_INHSTAProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_PRTYPEProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_PRTYPE", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol4_PRTYPE
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol4_PRTYPEProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_PRTYPEProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_UNACK Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_UNACKProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_UNACK", typeof(bool), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_EmbeddedSymbol4_UNACK
        {
            get { return (bool)this.GetValue(Faceplate_Body_EmbeddedSymbol4_UNACKProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_UNACKProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_AlarmStateChanged Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_AlarmStateChangedProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_AlarmStateChanged", typeof(int), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_AlarmStateChanged.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Faceplate_Body_EmbeddedSymbol4_AlarmStateChanged
        {
            get { return (int)this.GetValue(Faceplate_Body_EmbeddedSymbol4_AlarmStateChangedProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_AlarmStateChangedProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol4_ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol4_ShowInhibStateProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol4_ShowInhibState", typeof(bool), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol4_ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Faceplate_Body_EmbeddedSymbol4_ShowInhibState
        {
            get { return (bool)this.GetValue(Faceplate_Body_EmbeddedSymbol4_ShowInhibStateProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol4_ShowInhibStateProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_NoEntry_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_NoEntry_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_NoEntry_CB_EU", typeof(string), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_NoEntry_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_FP_Value_PNT_NoEntry_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_NoEntry_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_NoEntry_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_NoEntry_CB_P", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_NoEntry_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_NoEntry_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Max", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Min", typeof(double), typeof(FP_OUTSEL));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_PNT_NoEntry_CB_P_MinProperty, value); }
        }


		
    }
}
