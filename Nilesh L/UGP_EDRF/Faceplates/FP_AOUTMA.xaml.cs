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
	[Export("FP_AOUTMA")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_AOUTMA
    {
        public FP_AOUTMA()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("BIAS", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the BIAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double BIAS
        {
            get { return (double)this.GetValue(BIASProperty); }
            set { this.SetValue(BIASProperty, value); }
        }

        /// <summary>
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("HOLIM", typeof(double), typeof(FP_AOUTMA));

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
        /// HSCI1 Property
        /// </summary>
        public static readonly DependencyProperty HSCI1Property =
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_AOUTMA));

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
        /// HSCI2 Property
        /// </summary>
        public static readonly DependencyProperty HSCI2Property =
            DependencyProperty.Register("HSCI2", typeof(double), typeof(FP_AOUTMA));

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
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("INHOPT", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("INHSTA", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("LOLIM", typeof(double), typeof(FP_AOUTMA));

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
        /// LSCI1 Property
        /// </summary>
        public static readonly DependencyProperty LSCI1Property =
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_AOUTMA));

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
        /// LSCI2 Property
        /// </summary>
        public static readonly DependencyProperty LSCI2Property =
            DependencyProperty.Register("LSCI2", typeof(double), typeof(FP_AOUTMA));

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
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("MEAS", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("OP", typeof(double), typeof(FP_AOUTMA));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_AOUTMA));

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
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL2
        {
            get { return (string)this.GetValue(BLKOVL2Property); }
            set { this.SetValue(BLKOVL2Property, value); }
        }

        /// <summary>
        /// PvCB_2 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_2Property =
            DependencyProperty.Register("PvCB_2", typeof(string), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the PvCB_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PvCB_2
        {
            get { return (string)this.GetValue(PvCB_2Property); }
            set { this.SetValue(PvCB_2Property, value); }
        }

        /// <summary>
        /// MAACTION Property
        /// </summary>
        public static readonly DependencyProperty MAACTIONProperty =
            DependencyProperty.Register("MAACTION", typeof(bool), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the MAACTION.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MAACTION
        {
            get { return (bool)this.GetValue(MAACTIONProperty); }
            set { this.SetValue(MAACTIONProperty, value); }
        }

        /// <summary>
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_AOUTMA));

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
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_AOUTMA));

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
        /// Faceplate_Body_Bar_MEAS_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_MEAS_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PV", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PvRangeFullScaleMax", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_MEAS_PVRangeFullScaleMin", typeof(double), typeof(FP_AOUTMA));

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
        /// Faceplate_Body_Bar_PNT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_PNT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PV", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PvRangeFullScaleMax", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PVRangeFullScaleMin", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_CRIT", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHOPT", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_INHSTA", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_PRTYPE", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_UNACK", typeof(bool), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_AlarmStateChanged", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_Bar_PNT_ShowInhibState", typeof(bool), typeof(FP_AOUTMA));

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
        /// Faceplate_Body_FP_Value_MEAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_MEAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_EU", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Max", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_MEAS_CB_P_Min", typeof(double), typeof(FP_AOUTMA));

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
        /// Faceplate_Body_FP_Value_PNT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_PNT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_EU", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P_Max", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_PNT_CB_P_Min", typeof(double), typeof(FP_AOUTMA));

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
        /// Faceplate_Body_Button_BIAS_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Button_BIAS_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_Button_BIAS_CB_EU", typeof(string), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Button_BIAS_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_Button_BIAS_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_Button_BIAS_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_Button_BIAS_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Button_BIAS_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Button_BIAS_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_Button_BIAS_CB_P", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Button_BIAS_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Button_BIAS_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_Button_BIAS_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_Button_BIAS_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Button_BIAS_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Button_BIAS_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_Button_BIAS_CB_P_Max", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Button_BIAS_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Button_BIAS_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_Button_BIAS_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_Button_BIAS_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_Button_BIAS_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Button_BIAS_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_Button_BIAS_CB_P_Min", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_Button_BIAS_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_Button_BIAS_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_Button_BIAS_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_Button_BIAS_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR1Property =
            DependencyProperty.Register("Trend_CMPBLKPAR1", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Trend_CMPBLKPAR2", typeof(string), typeof(FP_AOUTMA));

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
        /// Trend_Identity Property
        /// </summary>
        public static readonly DependencyProperty Trend_IdentityProperty =
            DependencyProperty.Register("Trend_Identity", typeof(string), typeof(FP_AOUTMA));

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
        /// Trend_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR3Property =
            DependencyProperty.Register("Trend_CMPBLKPAR3", typeof(string), typeof(FP_AOUTMA));

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
        /// Trend_CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR4Property =
            DependencyProperty.Register("Trend_CMPBLKPAR4", typeof(string), typeof(FP_AOUTMA));

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
        /// AM_Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty AM_Command_BitProperty =
            DependencyProperty.Register("AM_Command_Bit", typeof(bool), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("AM_FeedBack_Bit", typeof(bool), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("AM_OFF_Message", typeof(string), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("AM_ON_Message", typeof(string), typeof(FP_AOUTMA));

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
        /// FP_Alarm21_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_Alarm21_CB_NAMEProperty =
            DependencyProperty.Register("FP_Alarm21_CB_NAME", typeof(string), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the FP_Alarm21_CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_Alarm21_CB_NAME
        {
            get { return (string)this.GetValue(FP_Alarm21_CB_NAMEProperty); }
            set { this.SetValue(FP_Alarm21_CB_NAMEProperty, value); }
        }

        /// <summary>
        /// RAMP_ARROWS_PV Property
        /// </summary>
        public static readonly DependencyProperty RAMP_ARROWS_PVProperty =
            DependencyProperty.Register("RAMP_ARROWS_PV", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the RAMP_ARROWS_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RAMP_ARROWS_PV
        {
            get { return (double)this.GetValue(RAMP_ARROWS_PVProperty); }
            set { this.SetValue(RAMP_ARROWS_PVProperty, value); }
        }

        /// <summary>
        /// RAMP_ARROWS_PV_Max Property
        /// </summary>
        public static readonly DependencyProperty RAMP_ARROWS_PV_MaxProperty =
            DependencyProperty.Register("RAMP_ARROWS_PV_Max", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the RAMP_ARROWS_PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RAMP_ARROWS_PV_Max
        {
            get { return (double)this.GetValue(RAMP_ARROWS_PV_MaxProperty); }
            set { this.SetValue(RAMP_ARROWS_PV_MaxProperty, value); }
        }

        /// <summary>
        /// RAMP_ARROWS_PV_Min Property
        /// </summary>
        public static readonly DependencyProperty RAMP_ARROWS_PV_MinProperty =
            DependencyProperty.Register("RAMP_ARROWS_PV_Min", typeof(double), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the RAMP_ARROWS_PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RAMP_ARROWS_PV_Min
        {
            get { return (double)this.GetValue(RAMP_ARROWS_PV_MinProperty); }
            set { this.SetValue(RAMP_ARROWS_PV_MinProperty, value); }
        }

        /// <summary>
        /// RAMP_ARROWS_option Property
        /// </summary>
        public static readonly DependencyProperty RAMP_ARROWS_optionProperty =
            DependencyProperty.Register("RAMP_ARROWS_option", typeof(string), typeof(FP_AOUTMA));

        /// <summary>
        /// Gets or sets the RAMP_ARROWS_option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RAMP_ARROWS_option
        {
            get { return (string)this.GetValue(RAMP_ARROWS_optionProperty); }
            set { this.SetValue(RAMP_ARROWS_optionProperty, value); }
        }

        /// <summary>
        /// Flag_AlarmLimits_MoveUp Property
        /// </summary>
        public static readonly DependencyProperty Flag_AlarmLimits_MoveUpProperty =
            DependencyProperty.Register("Flag_AlarmLimits_MoveUp", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_HAL", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHALIM", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_HHAOPT", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_HLOP", typeof(int), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_LAL", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_LLALIM", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_MaxRange", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_MinRange", typeof(double), typeof(FP_AOUTMA));

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
            DependencyProperty.Register("Flag_AlarmLimits_MoveDown", typeof(int), typeof(FP_AOUTMA));

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
