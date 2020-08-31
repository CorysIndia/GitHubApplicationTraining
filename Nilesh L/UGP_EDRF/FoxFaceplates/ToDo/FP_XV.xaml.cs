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
	[Export("FP_XV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_XV
    {
        public FP_XV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_XV));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"CLOSE/RST")]
        public string CMPOVL
        {
            get { return (string)this.GetValue(CMPOVLProperty); }
            set { this.SetValue(CMPOVLProperty, value); }
        }

        /// <summary>
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"CLOSE")]
        public string BLKOVL
        {
            get { return (string)this.GetValue(BLKOVLProperty); }
            set { this.SetValue(BLKOVLProperty, value); }
        }

        /// <summary>
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_XV));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the PICK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK
        {
            get { return (string)this.GetValue(PICKProperty); }
            set { this.SetValue(PICKProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_XV));

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
        /// ALARM Property
        /// </summary>
        public static readonly DependencyProperty ALARMProperty =
            DependencyProperty.Register("ALARM", typeof(bool), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ALARM
        {
            get { return (bool)this.GetValue(ALARMProperty); }
            set { this.SetValue(ALARMProperty, value); }
        }

        /// <summary>
        /// CMD_FB Property
        /// </summary>
        public static readonly DependencyProperty CMD_FBProperty =
            DependencyProperty.Register("CMD_FB", typeof(bool), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the CMD_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CMD_FB
        {
            get { return (bool)this.GetValue(CMD_FBProperty); }
            set { this.SetValue(CMD_FBProperty, value); }
        }

        /// <summary>
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_XV));

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
        /// STAIND Property
        /// </summary>
        public static readonly DependencyProperty STAINDProperty =
            DependencyProperty.Register("STAIND", typeof(int), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the STAIND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int STAIND
        {
            get { return (int)this.GetValue(STAINDProperty); }
            set { this.SetValue(STAINDProperty, value); }
        }

        /// <summary>
        /// BLK_RST Property
        /// </summary>
        public static readonly DependencyProperty BLK_RSTProperty =
            DependencyProperty.Register("BLK_RST", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the BLK_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_RST
        {
            get { return (string)this.GetValue(BLK_RSTProperty); }
            set { this.SetValue(BLK_RSTProperty, value); }
        }

        /// <summary>
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_XV));

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
        /// BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL3Property =
            DependencyProperty.Register("BLKOVL3", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL3
        {
            get { return (string)this.GetValue(BLKOVL3Property); }
            set { this.SetValue(BLKOVL3Property, value); }
        }

        /// <summary>
        /// BLK_XXY Property
        /// </summary>
        public static readonly DependencyProperty BLK_XXYProperty =
            DependencyProperty.Register("BLK_XXY", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the BLK_XXY.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_XXY
        {
            get { return (string)this.GetValue(BLK_XXYProperty); }
            set { this.SetValue(BLK_XXYProperty, value); }
        }

        /// <summary>
        /// STATUS Property
        /// </summary>
        public static readonly DependencyProperty STATUSProperty =
            DependencyProperty.Register("STATUS", typeof(string), typeof(FP_XV));

        /// <summary>
        /// Gets or sets the STATUS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STATUS
        {
            get { return (string)this.GetValue(STATUSProperty); }
            set { this.SetValue(STATUSProperty, value); }
        }

        /// <summary>
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_XV));

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
        /// FP_Alarm21_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_Alarm21_CB_NAMEProperty =
            DependencyProperty.Register("FP_Alarm21_CB_NAME", typeof(string), typeof(FP_XV));

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


		
    }
}
