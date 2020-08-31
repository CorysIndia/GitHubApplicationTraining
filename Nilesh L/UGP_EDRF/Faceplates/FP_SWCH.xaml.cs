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
	[Export("FP_SWCH")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_SWCH
    {
        public FP_SWCH()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_SWCH));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_SWCH));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_SWCH));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_SWCH));

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
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_SWCH));

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
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_SWCH));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_SWCH));

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
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_SWCH));

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
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(int), typeof(FP_SWCH));

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
        /// PICK_B Property
        /// </summary>
        public static readonly DependencyProperty PICK_BProperty =
            DependencyProperty.Register("PICK_B", typeof(bool), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the PICK_B.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PICK_B
        {
            get { return (bool)this.GetValue(PICK_BProperty); }
            set { this.SetValue(PICK_BProperty, value); }
        }

        /// <summary>
        /// OUTPUT Property
        /// </summary>
        public static readonly DependencyProperty OUTPUTProperty =
            DependencyProperty.Register("OUTPUT", typeof(double), typeof(FP_SWCH));

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
        /// INP1 Property
        /// </summary>
        public static readonly DependencyProperty INP1Property =
            DependencyProperty.Register("INP1", typeof(double), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the INP1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double INP1
        {
            get { return (double)this.GetValue(INP1Property); }
            set { this.SetValue(INP1Property, value); }
        }

        /// <summary>
        /// INP2 Property
        /// </summary>
        public static readonly DependencyProperty INP2Property =
            DependencyProperty.Register("INP2", typeof(double), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the INP2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double INP2
        {
            get { return (double)this.GetValue(INP2Property); }
            set { this.SetValue(INP2Property, value); }
        }

        /// <summary>
        /// TOGGLE Property
        /// </summary>
        public static readonly DependencyProperty TOGGLEProperty =
            DependencyProperty.Register("TOGGLE", typeof(bool), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the TOGGLE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TOGGLE
        {
            get { return (bool)this.GetValue(TOGGLEProperty); }
            set { this.SetValue(TOGGLEProperty, value); }
        }

        /// <summary>
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_SWCH));

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
        /// EI2 Property
        /// </summary>
        public static readonly DependencyProperty EI2Property =
            DependencyProperty.Register("EI2", typeof(string), typeof(FP_SWCH));

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
        /// EO1 Property
        /// </summary>
        public static readonly DependencyProperty EO1Property =
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_SWCH));

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
            DependencyProperty.Register("HSCI1", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("LSCI1", typeof(double), typeof(FP_SWCH));

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
        /// HSCI2 Property
        /// </summary>
        public static readonly DependencyProperty HSCI2Property =
            DependencyProperty.Register("HSCI2", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("LSCI2", typeof(double), typeof(FP_SWCH));

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
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_SWCH));

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
        /// PICK_R Property
        /// </summary>
        public static readonly DependencyProperty PICK_RProperty =
            DependencyProperty.Register("PICK_R", typeof(bool), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the PICK_R.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PICK_R
        {
            get { return (bool)this.GetValue(PICK_RProperty); }
            set { this.SetValue(PICK_RProperty, value); }
        }

        /// <summary>
        /// SYM_FP_CLOSE_011_CON1 Property
        /// </summary>
        public static readonly DependencyProperty SYM_FP_CLOSE_011_CON1Property =
            DependencyProperty.Register("SYM_FP_CLOSE_011_CON1", typeof(bool), typeof(FP_SWCH));

        /// <summary>
        /// Gets or sets the SYM_FP_CLOSE_011_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SYM_FP_CLOSE_011_CON1
        {
            get { return (bool)this.GetValue(SYM_FP_CLOSE_011_CON1Property); }
            set { this.SetValue(SYM_FP_CLOSE_011_CON1Property, value); }
        }

        /// <summary>
        /// Faceplate_Body_Bar_OUT_PV Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_Bar_OUT_PVProperty =
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PV", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PvRangeFullScaleMax", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_PVRangeFullScaleMin", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_Bar_OUT_ShowInhibState", typeof(bool), typeof(FP_SWCH));

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
        /// Faceplate_Body_FP_Value_OUT_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_OUT_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_EU", typeof(string), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Max", typeof(double), typeof(FP_SWCH));

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
            DependencyProperty.Register("Faceplate_Body_FP_Value_OUT_CB_P_Min", typeof(double), typeof(FP_SWCH));

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
