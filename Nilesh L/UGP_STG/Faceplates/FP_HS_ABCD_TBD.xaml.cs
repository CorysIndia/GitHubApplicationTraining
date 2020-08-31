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
	[Export("FP_HS_ABCD_TBD")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_HS_ABCD_TBD
    {
        public FP_HS_ABCD_TBD()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_HS_ABCD_TBD));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(int), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the PICK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PICK
        {
            get { return (int)this.GetValue(PICKProperty); }
            set { this.SetValue(PICKProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_HS_ABCD_TBD));

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
        /// HS Property
        /// </summary>
        public static readonly DependencyProperty HSProperty =
            DependencyProperty.Register("HS", typeof(int), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the HS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HS
        {
            get { return (int)this.GetValue(HSProperty); }
            set { this.SetValue(HSProperty, value); }
        }

        /// <summary>
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_HS_ABCD_TBD));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_HS_ABCD_TBD));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_HS_ABCD_TBD));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

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
        /// PAROVL Property
        /// </summary>
        public static readonly DependencyProperty PAROVLProperty =
            DependencyProperty.Register("PAROVL", typeof(string), typeof(FP_HS_ABCD_TBD));

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
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_HS_ABCD_TBD));

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
        /// Select_A_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_A_BLKProperty =
            DependencyProperty.Register("Select_A_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the Select_A_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_BLK
        {
            get { return (string)this.GetValue(Select_A_BLKProperty); }
            set { this.SetValue(Select_A_BLKProperty, value); }
        }

        /// <summary>
        /// Select_A_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_A_CMPProperty =
            DependencyProperty.Register("Select_A_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the Select_A_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_CMP
        {
            get { return (string)this.GetValue(Select_A_CMPProperty); }
            set { this.SetValue(Select_A_CMPProperty, value); }
        }

        /// <summary>
        /// Select_A_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_A_PARProperty =
            DependencyProperty.Register("Select_A_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the Select_A_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_PAR
        {
            get { return (string)this.GetValue(Select_A_PARProperty); }
            set { this.SetValue(Select_A_PARProperty, value); }
        }

        /// <summary>
        /// Select_A_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_A_PRTProperty =
            DependencyProperty.Register("Select_A_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the Select_A_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_PRT
        {
            get { return (string)this.GetValue(Select_A_PRTProperty); }
            set { this.SetValue(Select_A_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol1_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol1_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol1_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol1_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol1_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol1_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol1_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol1_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_PARProperty); }
            set { this.SetValue(EmbeddedSymbol1_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol1_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol1_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol1_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol2_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol2_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol2_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol2_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol2_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol2_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol2_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol2_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol2_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol2_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol2_PARProperty); }
            set { this.SetValue(EmbeddedSymbol2_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol2_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol2_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol2_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol2_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol3_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol3_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol3_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol3_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol3_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_PARProperty); }
            set { this.SetValue(EmbeddedSymbol3_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol3_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol3_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol4_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol4_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol4_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol4_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol4_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol4_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol4_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol4_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol4_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol4_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol4_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol4_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol4_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol4_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol4_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol4_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol4_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol4_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol4_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol4_PARProperty); }
            set { this.SetValue(EmbeddedSymbol4_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol4_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol4_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol4_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol4_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol4_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol4_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol4_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol5_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol5_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol5_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol5_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol5_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol5_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol5_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol5_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol5_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol5_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol5_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol5_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol5_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol5_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol5_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol5_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol5_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol5_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol5_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol5_PARProperty); }
            set { this.SetValue(EmbeddedSymbol5_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol5_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol5_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol5_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol5_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol5_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol5_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol5_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol6_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol6_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol6_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol6_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol6_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol6_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol6_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol6_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol6_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol6_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol6_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol6_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol6_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol6_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol6_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol6_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol6_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol6_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol6_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol6_PARProperty); }
            set { this.SetValue(EmbeddedSymbol6_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol6_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol6_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol6_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol6_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol6_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol6_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol6_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol7_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol7_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol7_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol7_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol7_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol7_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol7_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol7_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol7_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol7_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol7_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol7_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol7_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol7_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol7_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol7_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol7_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol7_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol7_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol7_PARProperty); }
            set { this.SetValue(EmbeddedSymbol7_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol7_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol7_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol7_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol7_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol7_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol7_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol7_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol8_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol8_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol8_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol8_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol8_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol8_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol8_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol8_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol8_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol8_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol8_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol8_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol8_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol8_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol8_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol8_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol8_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol8_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol8_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol8_PARProperty); }
            set { this.SetValue(EmbeddedSymbol8_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol8_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol8_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol8_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol8_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol8_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol8_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol8_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol9_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol9_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol9_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol9_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol9_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol9_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol9_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol9_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol9_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol9_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol9_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol9_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol9_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol9_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol9_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol9_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol9_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol9_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol9_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol9_PARProperty); }
            set { this.SetValue(EmbeddedSymbol9_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol9_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol9_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol9_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol9_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol9_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol9_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol9_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol10_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol10_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol10_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol10_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol10_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol10_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol10_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol10_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol10_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol10_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol10_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol10_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol10_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol10_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol10_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol10_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol10_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol10_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol10_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol10_PARProperty); }
            set { this.SetValue(EmbeddedSymbol10_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol10_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol10_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol10_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol10_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol10_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol10_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol10_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol11_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol11_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol11_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol11_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol11_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol11_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol11_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol11_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol11_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol11_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol11_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol11_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol11_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol11_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol11_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol11_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol11_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol11_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol11_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol11_PARProperty); }
            set { this.SetValue(EmbeddedSymbol11_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol11_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol11_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol11_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol11_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol11_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol11_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol11_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol12_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol12_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol12_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol12_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol12_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol12_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol12_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol12_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol12_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol12_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol12_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol12_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol12_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol12_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol12_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol12_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol12_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol12_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol12_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol12_PARProperty); }
            set { this.SetValue(EmbeddedSymbol12_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol12_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol12_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol12_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol12_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol12_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol12_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol12_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol13_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol13_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol13_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol13_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol13_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol13_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol13_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol13_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol13_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol13_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol13_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol13_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol13_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol13_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol13_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol13_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol13_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol13_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol13_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol13_PARProperty); }
            set { this.SetValue(EmbeddedSymbol13_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol13_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol13_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol13_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol13_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol13_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol13_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol13_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol14_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol14_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol14_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol14_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol14_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol14_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol14_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol14_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol14_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol14_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol14_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol14_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol14_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol14_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol14_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol14_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol14_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol14_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol14_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol14_PARProperty); }
            set { this.SetValue(EmbeddedSymbol14_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol14_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol14_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol14_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol14_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol14_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol14_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol14_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol15_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol15_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol15_BLK", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol15_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol15_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol15_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol15_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol15_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol15_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol15_CMP", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol15_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol15_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol15_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol15_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol15_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol15_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol15_PAR", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol15_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol15_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol15_PARProperty); }
            set { this.SetValue(EmbeddedSymbol15_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol15_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol15_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol15_PRT", typeof(string), typeof(FP_HS_ABCD_TBD));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol15_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol15_PRT
        {
            get { return (string)this.GetValue(EmbeddedSymbol15_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol15_PRTProperty, value); }
        }


		
    }
}
