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
	[Export("FP_CALCA")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_CALCA
    {
        public FP_CALCA()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_CALCA));

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
        /// BO01 Property
        /// </summary>
        public static readonly DependencyProperty BO01Property =
            DependencyProperty.Register("BO01", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO01
        {
            get { return (bool)this.GetValue(BO01Property); }
            set { this.SetValue(BO01Property, value); }
        }

        /// <summary>
        /// BO02 Property
        /// </summary>
        public static readonly DependencyProperty BO02Property =
            DependencyProperty.Register("BO02", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO02
        {
            get { return (bool)this.GetValue(BO02Property); }
            set { this.SetValue(BO02Property, value); }
        }

        /// <summary>
        /// BO03 Property
        /// </summary>
        public static readonly DependencyProperty BO03Property =
            DependencyProperty.Register("BO03", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO03
        {
            get { return (bool)this.GetValue(BO03Property); }
            set { this.SetValue(BO03Property, value); }
        }

        /// <summary>
        /// BO04 Property
        /// </summary>
        public static readonly DependencyProperty BO04Property =
            DependencyProperty.Register("BO04", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO04
        {
            get { return (bool)this.GetValue(BO04Property); }
            set { this.SetValue(BO04Property, value); }
        }

        /// <summary>
        /// BO05 Property
        /// </summary>
        public static readonly DependencyProperty BO05Property =
            DependencyProperty.Register("BO05", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO05
        {
            get { return (bool)this.GetValue(BO05Property); }
            set { this.SetValue(BO05Property, value); }
        }

        /// <summary>
        /// BO06 Property
        /// </summary>
        public static readonly DependencyProperty BO06Property =
            DependencyProperty.Register("BO06", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO06
        {
            get { return (bool)this.GetValue(BO06Property); }
            set { this.SetValue(BO06Property, value); }
        }

        /// <summary>
        /// BO07 Property
        /// </summary>
        public static readonly DependencyProperty BO07Property =
            DependencyProperty.Register("BO07", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO07.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO07
        {
            get { return (bool)this.GetValue(BO07Property); }
            set { this.SetValue(BO07Property, value); }
        }

        /// <summary>
        /// BO08 Property
        /// </summary>
        public static readonly DependencyProperty BO08Property =
            DependencyProperty.Register("BO08", typeof(bool), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the BO08.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BO08
        {
            get { return (bool)this.GetValue(BO08Property); }
            set { this.SetValue(BO08Property, value); }
        }

        /// <summary>
        /// RI01 Property
        /// </summary>
        public static readonly DependencyProperty RI01Property =
            DependencyProperty.Register("RI01", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI01
        {
            get { return (double)this.GetValue(RI01Property); }
            set { this.SetValue(RI01Property, value); }
        }

        /// <summary>
        /// RI02 Property
        /// </summary>
        public static readonly DependencyProperty RI02Property =
            DependencyProperty.Register("RI02", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI02
        {
            get { return (double)this.GetValue(RI02Property); }
            set { this.SetValue(RI02Property, value); }
        }

        /// <summary>
        /// RI03 Property
        /// </summary>
        public static readonly DependencyProperty RI03Property =
            DependencyProperty.Register("RI03", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI03
        {
            get { return (double)this.GetValue(RI03Property); }
            set { this.SetValue(RI03Property, value); }
        }

        /// <summary>
        /// RI04 Property
        /// </summary>
        public static readonly DependencyProperty RI04Property =
            DependencyProperty.Register("RI04", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI04
        {
            get { return (double)this.GetValue(RI04Property); }
            set { this.SetValue(RI04Property, value); }
        }

        /// <summary>
        /// RI05 Property
        /// </summary>
        public static readonly DependencyProperty RI05Property =
            DependencyProperty.Register("RI05", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI05
        {
            get { return (double)this.GetValue(RI05Property); }
            set { this.SetValue(RI05Property, value); }
        }

        /// <summary>
        /// RI06 Property
        /// </summary>
        public static readonly DependencyProperty RI06Property =
            DependencyProperty.Register("RI06", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI06
        {
            get { return (double)this.GetValue(RI06Property); }
            set { this.SetValue(RI06Property, value); }
        }

        /// <summary>
        /// RI07 Property
        /// </summary>
        public static readonly DependencyProperty RI07Property =
            DependencyProperty.Register("RI07", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI07.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI07
        {
            get { return (double)this.GetValue(RI07Property); }
            set { this.SetValue(RI07Property, value); }
        }

        /// <summary>
        /// RI08 Property
        /// </summary>
        public static readonly DependencyProperty RI08Property =
            DependencyProperty.Register("RI08", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RI08.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RI08
        {
            get { return (double)this.GetValue(RI08Property); }
            set { this.SetValue(RI08Property, value); }
        }

        /// <summary>
        /// RO01 Property
        /// </summary>
        public static readonly DependencyProperty RO01Property =
            DependencyProperty.Register("RO01", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RO01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO01
        {
            get { return (double)this.GetValue(RO01Property); }
            set { this.SetValue(RO01Property, value); }
        }

        /// <summary>
        /// RO02 Property
        /// </summary>
        public static readonly DependencyProperty RO02Property =
            DependencyProperty.Register("RO02", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RO02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO02
        {
            get { return (double)this.GetValue(RO02Property); }
            set { this.SetValue(RO02Property, value); }
        }

        /// <summary>
        /// RO03 Property
        /// </summary>
        public static readonly DependencyProperty RO03Property =
            DependencyProperty.Register("RO03", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RO03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO03
        {
            get { return (double)this.GetValue(RO03Property); }
            set { this.SetValue(RO03Property, value); }
        }

        /// <summary>
        /// RO04 Property
        /// </summary>
        public static readonly DependencyProperty RO04Property =
            DependencyProperty.Register("RO04", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the RO04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO04
        {
            get { return (double)this.GetValue(RO04Property); }
            set { this.SetValue(RO04Property, value); }
        }

        /// <summary>
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(FP_CALCA));

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
        /// HSCO2 Property
        /// </summary>
        public static readonly DependencyProperty HSCO2Property =
            DependencyProperty.Register("HSCO2", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the HSCO2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO2
        {
            get { return (double)this.GetValue(HSCO2Property); }
            set { this.SetValue(HSCO2Property, value); }
        }

        /// <summary>
        /// HSCO3 Property
        /// </summary>
        public static readonly DependencyProperty HSCO3Property =
            DependencyProperty.Register("HSCO3", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the HSCO3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO3
        {
            get { return (double)this.GetValue(HSCO3Property); }
            set { this.SetValue(HSCO3Property, value); }
        }

        /// <summary>
        /// HSCO4 Property
        /// </summary>
        public static readonly DependencyProperty HSCO4Property =
            DependencyProperty.Register("HSCO4", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the HSCO4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO4
        {
            get { return (double)this.GetValue(HSCO4Property); }
            set { this.SetValue(HSCO4Property, value); }
        }

        /// <summary>
        /// EI1 Property
        /// </summary>
        public static readonly DependencyProperty EI1Property =
            DependencyProperty.Register("EI1", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("EI2", typeof(string), typeof(FP_CALCA));

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
        /// EI3 Property
        /// </summary>
        public static readonly DependencyProperty EI3Property =
            DependencyProperty.Register("EI3", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI3
        {
            get { return (string)this.GetValue(EI3Property); }
            set { this.SetValue(EI3Property, value); }
        }

        /// <summary>
        /// EI4 Property
        /// </summary>
        public static readonly DependencyProperty EI4Property =
            DependencyProperty.Register("EI4", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI4
        {
            get { return (string)this.GetValue(EI4Property); }
            set { this.SetValue(EI4Property, value); }
        }

        /// <summary>
        /// EI5 Property
        /// </summary>
        public static readonly DependencyProperty EI5Property =
            DependencyProperty.Register("EI5", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI5
        {
            get { return (string)this.GetValue(EI5Property); }
            set { this.SetValue(EI5Property, value); }
        }

        /// <summary>
        /// EI6 Property
        /// </summary>
        public static readonly DependencyProperty EI6Property =
            DependencyProperty.Register("EI6", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI6
        {
            get { return (string)this.GetValue(EI6Property); }
            set { this.SetValue(EI6Property, value); }
        }

        /// <summary>
        /// EI7 Property
        /// </summary>
        public static readonly DependencyProperty EI7Property =
            DependencyProperty.Register("EI7", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI7.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI7
        {
            get { return (string)this.GetValue(EI7Property); }
            set { this.SetValue(EI7Property, value); }
        }

        /// <summary>
        /// EI8 Property
        /// </summary>
        public static readonly DependencyProperty EI8Property =
            DependencyProperty.Register("EI8", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EI8.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EI8
        {
            get { return (string)this.GetValue(EI8Property); }
            set { this.SetValue(EI8Property, value); }
        }

        /// <summary>
        /// EO1 Property
        /// </summary>
        public static readonly DependencyProperty EO1Property =
            DependencyProperty.Register("EO1", typeof(string), typeof(FP_CALCA));

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
        /// EO2 Property
        /// </summary>
        public static readonly DependencyProperty EO2Property =
            DependencyProperty.Register("EO2", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EO2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EO2
        {
            get { return (string)this.GetValue(EO2Property); }
            set { this.SetValue(EO2Property, value); }
        }

        /// <summary>
        /// EO3 Property
        /// </summary>
        public static readonly DependencyProperty EO3Property =
            DependencyProperty.Register("EO3", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EO3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EO3
        {
            get { return (string)this.GetValue(EO3Property); }
            set { this.SetValue(EO3Property, value); }
        }

        /// <summary>
        /// EO4 Property
        /// </summary>
        public static readonly DependencyProperty EO4Property =
            DependencyProperty.Register("EO4", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the EO4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EO4
        {
            get { return (string)this.GetValue(EO4Property); }
            set { this.SetValue(EO4Property, value); }
        }

        /// <summary>
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(FP_CALCA));

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
        /// LSCO2 Property
        /// </summary>
        public static readonly DependencyProperty LSCO2Property =
            DependencyProperty.Register("LSCO2", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the LSCO2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO2
        {
            get { return (double)this.GetValue(LSCO2Property); }
            set { this.SetValue(LSCO2Property, value); }
        }

        /// <summary>
        /// LSCO3 Property
        /// </summary>
        public static readonly DependencyProperty LSCO3Property =
            DependencyProperty.Register("LSCO3", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the LSCO3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO3
        {
            get { return (double)this.GetValue(LSCO3Property); }
            set { this.SetValue(LSCO3Property, value); }
        }

        /// <summary>
        /// LSCO4 Property
        /// </summary>
        public static readonly DependencyProperty LSCO4Property =
            DependencyProperty.Register("LSCO4", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the LSCO4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO4
        {
            get { return (double)this.GetValue(LSCO4Property); }
            set { this.SetValue(LSCO4Property, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_CALCA));

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
            DependencyProperty.Register("Type", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_CALCA));

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
        /// Trend_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR1Property =
            DependencyProperty.Register("Trend_CMPBLKPAR1", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("Trend_CMPBLKPAR2", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("Trend_CMPBLKPAR3", typeof(string), typeof(FP_CALCA));

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
            DependencyProperty.Register("Trend_CMPBLKPAR4", typeof(string), typeof(FP_CALCA));

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
        /// Trend_Identity Property
        /// </summary>
        public static readonly DependencyProperty Trend_IdentityProperty =
            DependencyProperty.Register("Trend_Identity", typeof(string), typeof(FP_CALCA));

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
        /// Real_Inputs_EmbeddedSymbol8_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol8_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol8_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol8_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol8_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol8_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol8_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol8_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol8_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol8_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol8_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol8_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol8_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol8_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol8_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol8_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol8_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol8_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol8_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol8_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol8_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol4_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol4_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol4_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol4_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol4_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol4_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol4_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol4_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol4_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol4_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol4_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol4_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol4_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol4_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol4_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol4_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol4_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol4_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol4_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol4_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol4_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol5_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol5_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol5_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol5_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol5_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol5_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol5_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol5_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol5_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol5_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol5_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol5_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol5_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol5_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol5_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol5_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol5_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol5_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol5_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol5_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol5_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol6_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol6_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol6_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol6_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol6_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol6_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol6_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol6_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol6_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol6_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol6_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol6_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol6_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol6_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol6_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol6_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol6_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol6_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol6_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol6_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol6_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol7_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol7_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol7_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol7_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol7_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol7_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol7_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol7_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol7_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol7_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol7_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol7_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol7_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol7_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol7_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol7_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol7_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol7_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol7_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol7_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol7_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol9_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol9_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol9_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol9_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol9_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol9_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol9_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol9_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol9_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol9_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol9_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol9_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol9_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol9_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol9_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol9_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol9_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol9_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol9_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol9_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol9_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol10_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol10_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol10_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol10_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol10_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol10_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol10_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol10_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol10_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol10_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol10_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol10_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol10_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol10_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol10_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol10_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol10_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol10_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol10_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol10_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol10_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol11_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol11_CB_PProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol11_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol11_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol11_CB_P
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol11_CB_PProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol11_CB_PProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol11_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol11_CB_P_MaxProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol11_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol11_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol11_CB_P_Max
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol11_CB_P_MaxProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol11_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Real_Inputs_EmbeddedSymbol11_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Real_Inputs_EmbeddedSymbol11_CB_P_MinProperty =
            DependencyProperty.Register("Real_Inputs_EmbeddedSymbol11_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Real_Inputs_EmbeddedSymbol11_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Real_Inputs_EmbeddedSymbol11_CB_P_Min
        {
            get { return (double)this.GetValue(Real_Inputs_EmbeddedSymbol11_CB_P_MinProperty); }
            set { this.SetValue(Real_Inputs_EmbeddedSymbol11_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol14_CB Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol14_CBProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol14_CB", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol14_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_EmbeddedSymbol14_CB
        {
            get { return (string)this.GetValue(Faceplate_Body_EmbeddedSymbol14_CBProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol14_CBProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_Display1_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_Display1_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_Display1_CB_EU", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_Display1_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_FP_Value_Display1_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_FP_Value_Display1_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_Display1_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_Display1_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_Display1_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_Display1_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_Display1_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_Display1_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_Display1_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_Display1_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_Display1_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_Display1_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_Display1_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_Display1_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_Display1_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_Display1_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_Display1_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_FP_Value_Display1_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_FP_Value_Display1_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_FP_Value_Display1_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_FP_Value_Display1_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_FP_Value_Display1_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_FP_Value_Display1_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_FP_Value_Display1_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol1_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol1_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol1_CB_EU", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol1_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_EmbeddedSymbol1_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_EmbeddedSymbol1_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol1_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol1_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol1_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol1_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol1_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol1_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol1_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol1_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol1_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol1_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol1_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol1_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol1_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol1_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol1_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol1_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol1_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol1_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol1_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol1_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol1_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol1_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol2_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol2_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol2_CB_EU", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol2_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_EmbeddedSymbol2_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_EmbeddedSymbol2_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol2_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol2_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol2_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol2_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol2_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol2_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol2_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol2_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol2_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol2_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol2_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol2_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol2_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol2_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol2_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol2_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol2_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol2_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol2_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol2_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol2_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol2_CB_P_MinProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_CB_EU Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_CB_EUProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_CB_EU", typeof(string), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_CB_EU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Faceplate_Body_EmbeddedSymbol3_CB_EU
        {
            get { return (string)this.GetValue(Faceplate_Body_EmbeddedSymbol3_CB_EUProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_CB_EUProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_CB_P Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_CB_PProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_CB_P", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_CB_P.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_CB_P
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_CB_PProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_CB_PProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_CB_P_Max Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_CB_P_MaxProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_CB_P_Max", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_CB_P_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_CB_P_Max
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_CB_P_MaxProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_CB_P_MaxProperty, value); }
        }

        /// <summary>
        /// Faceplate_Body_EmbeddedSymbol3_CB_P_Min Property
        /// </summary>
        public static readonly DependencyProperty Faceplate_Body_EmbeddedSymbol3_CB_P_MinProperty =
            DependencyProperty.Register("Faceplate_Body_EmbeddedSymbol3_CB_P_Min", typeof(double), typeof(FP_CALCA));

        /// <summary>
        /// Gets or sets the Faceplate_Body_EmbeddedSymbol3_CB_P_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Faceplate_Body_EmbeddedSymbol3_CB_P_Min
        {
            get { return (double)this.GetValue(Faceplate_Body_EmbeddedSymbol3_CB_P_MinProperty); }
            set { this.SetValue(Faceplate_Body_EmbeddedSymbol3_CB_P_MinProperty, value); }
        }


		
    }
}
