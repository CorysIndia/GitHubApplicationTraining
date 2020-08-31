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
	[Export("FP_EDR_SP_GEN")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_EDR_SP_GEN
    {
        public FP_EDR_SP_GEN()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_EDR_SP_GEN));

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
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_EDR_SP_GEN));

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
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_EDR_SP_GEN));

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
        /// EXECUTE_EmbeddedSymbol1_LOC Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_LOCProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_LOC", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_LOC
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_LOCProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_LOCProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_OVL Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_OVLProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_OVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_OVL
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_OVLProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_OVLProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_PRT Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_PRTProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_PRT", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_PRT
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_PRTProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_PRTProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVLProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVLProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVLProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVLProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVLProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVLProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVL2Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL2
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVL2Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVL2Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVL3Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL3
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVL3Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVL3Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVL4Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL4
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVL4Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVL4Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVL2Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL2
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVL2Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVL2Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVL3Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL3
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVL3Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVL3Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVL4Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL4
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVL4Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVL4Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVL5Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL5", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL5
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVL5Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVL5Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKOVL6Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLKOVL6", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLKOVL6
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKOVL6Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKOVL6Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_PAROVLProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_PAROVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_PAROVL
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_PAROVLProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_PAROVLProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_PAROVL2Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_PAROVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_PAROVL2
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_PAROVL2Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_PAROVL2Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_PAROVL3Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_PAROVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_PAROVL3
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_PAROVL3Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_PAROVL3Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_DSCRPProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_DSCRP", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_DSCRP
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_DSCRPProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_DSCRPProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMP Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMP", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMP
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_BLK Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_BLKProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_BLK", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_BLK
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_BLKProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_BLKProperty, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_PAROVL4Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_PAROVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_PAROVL4
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_PAROVL4Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_PAROVL4Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVL5Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL5", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL5
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVL5Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVL5Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_CMPOVL6Property =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_CMPOVL6", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_CMPOVL6
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_CMPOVL6Property); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_CMPOVL6Property, value); }
        }

        /// <summary>
        /// EXECUTE_EmbeddedSymbol1_LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty EXECUTE_EmbeddedSymbol1_LOOP_IDProperty =
            DependencyProperty.Register("EXECUTE_EmbeddedSymbol1_LOOP_ID", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the EXECUTE_EmbeddedSymbol1_LOOP_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EXECUTE_EmbeddedSymbol1_LOOP_ID
        {
            get { return (string)this.GetValue(EXECUTE_EmbeddedSymbol1_LOOP_IDProperty); }
            set { this.SetValue(EXECUTE_EmbeddedSymbol1_LOOP_IDProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_LOC Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_LOCProperty =
            DependencyProperty.Register("SYM_ACTION_011_LOC", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_LOC
        {
            get { return (string)this.GetValue(SYM_ACTION_011_LOCProperty); }
            set { this.SetValue(SYM_ACTION_011_LOCProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_OVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_OVLProperty =
            DependencyProperty.Register("SYM_ACTION_011_OVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_OVL
        {
            get { return (string)this.GetValue(SYM_ACTION_011_OVLProperty); }
            set { this.SetValue(SYM_ACTION_011_OVLProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_PRTProperty =
            DependencyProperty.Register("SYM_ACTION_011_PRT", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_PRT
        {
            get { return (string)this.GetValue(SYM_ACTION_011_PRTProperty); }
            set { this.SetValue(SYM_ACTION_011_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVLProperty =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVLProperty); }
            set { this.SetValue(SYM_ACTION_011_BLKOVLProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVLProperty =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVLProperty); }
            set { this.SetValue(SYM_ACTION_011_CMPOVLProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVL2Property =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL2
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVL2Property); }
            set { this.SetValue(SYM_ACTION_011_CMPOVL2Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVL3Property =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL3
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVL3Property); }
            set { this.SetValue(SYM_ACTION_011_CMPOVL3Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVL4Property =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL4
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVL4Property); }
            set { this.SetValue(SYM_ACTION_011_CMPOVL4Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVL2Property =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL2
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVL2Property); }
            set { this.SetValue(SYM_ACTION_011_BLKOVL2Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVL3Property =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL3
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVL3Property); }
            set { this.SetValue(SYM_ACTION_011_BLKOVL3Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVL4Property =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL4
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVL4Property); }
            set { this.SetValue(SYM_ACTION_011_BLKOVL4Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVL5Property =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL5", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL5
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVL5Property); }
            set { this.SetValue(SYM_ACTION_011_BLKOVL5Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKOVL6Property =
            DependencyProperty.Register("SYM_ACTION_011_BLKOVL6", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLKOVL6
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKOVL6Property); }
            set { this.SetValue(SYM_ACTION_011_BLKOVL6Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_PAROVLProperty =
            DependencyProperty.Register("SYM_ACTION_011_PAROVL", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_PAROVL
        {
            get { return (string)this.GetValue(SYM_ACTION_011_PAROVLProperty); }
            set { this.SetValue(SYM_ACTION_011_PAROVLProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_PAROVL2Property =
            DependencyProperty.Register("SYM_ACTION_011_PAROVL2", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_PAROVL2
        {
            get { return (string)this.GetValue(SYM_ACTION_011_PAROVL2Property); }
            set { this.SetValue(SYM_ACTION_011_PAROVL2Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_PAROVL3Property =
            DependencyProperty.Register("SYM_ACTION_011_PAROVL3", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_PAROVL3
        {
            get { return (string)this.GetValue(SYM_ACTION_011_PAROVL3Property); }
            set { this.SetValue(SYM_ACTION_011_PAROVL3Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_DSCRPProperty =
            DependencyProperty.Register("SYM_ACTION_011_DSCRP", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_DSCRP
        {
            get { return (string)this.GetValue(SYM_ACTION_011_DSCRPProperty); }
            set { this.SetValue(SYM_ACTION_011_DSCRPProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMP Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPProperty =
            DependencyProperty.Register("SYM_ACTION_011_CMP", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMP
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPProperty); }
            set { this.SetValue(SYM_ACTION_011_CMPProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_BLK Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_BLKProperty =
            DependencyProperty.Register("SYM_ACTION_011_BLK", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_BLK
        {
            get { return (string)this.GetValue(SYM_ACTION_011_BLKProperty); }
            set { this.SetValue(SYM_ACTION_011_BLKProperty, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_PAROVL4Property =
            DependencyProperty.Register("SYM_ACTION_011_PAROVL4", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_PAROVL4
        {
            get { return (string)this.GetValue(SYM_ACTION_011_PAROVL4Property); }
            set { this.SetValue(SYM_ACTION_011_PAROVL4Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVL5Property =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL5", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL5
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVL5Property); }
            set { this.SetValue(SYM_ACTION_011_CMPOVL5Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_CMPOVL6Property =
            DependencyProperty.Register("SYM_ACTION_011_CMPOVL6", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_CMPOVL6
        {
            get { return (string)this.GetValue(SYM_ACTION_011_CMPOVL6Property); }
            set { this.SetValue(SYM_ACTION_011_CMPOVL6Property, value); }
        }

        /// <summary>
        /// SYM_ACTION_011_LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty SYM_ACTION_011_LOOP_IDProperty =
            DependencyProperty.Register("SYM_ACTION_011_LOOP_ID", typeof(string), typeof(FP_EDR_SP_GEN));

        /// <summary>
        /// Gets or sets the SYM_ACTION_011_LOOP_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_ACTION_011_LOOP_ID
        {
            get { return (string)this.GetValue(SYM_ACTION_011_LOOP_IDProperty); }
            set { this.SetValue(SYM_ACTION_011_LOOP_IDProperty, value); }
        }


		
    }
}
