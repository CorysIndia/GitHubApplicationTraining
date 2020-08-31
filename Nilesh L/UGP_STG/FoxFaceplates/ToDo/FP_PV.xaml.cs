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
	[Export("FP_PV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_PV
    {
        public FP_PV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_PV));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_PV));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_PV));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_PV));

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
        /// STATUS Property
        /// </summary>
        public static readonly DependencyProperty STATUSProperty =
            DependencyProperty.Register("STATUS", typeof(string), typeof(FP_PV));

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
        /// CLOSED Property
        /// </summary>
        public static readonly DependencyProperty CLOSEDProperty =
            DependencyProperty.Register("CLOSED", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the CLOSED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CLOSED
        {
            get { return (bool)this.GetValue(CLOSEDProperty); }
            set { this.SetValue(CLOSEDProperty, value); }
        }

        /// <summary>
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_PV));

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
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_PV));

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
        /// OPEN Property
        /// </summary>
        public static readonly DependencyProperty OPENProperty =
            DependencyProperty.Register("OPEN", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OPEN
        {
            get { return (bool)this.GetValue(OPENProperty); }
            set { this.SetValue(OPENProperty, value); }
        }

        /// <summary>
        /// ALARM Property
        /// </summary>
        public static readonly DependencyProperty ALARMProperty =
            DependencyProperty.Register("ALARM", typeof(bool), typeof(FP_PV));

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
            DependencyProperty.Register("CMD_FB", typeof(bool), typeof(FP_PV));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_PV));

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
        /// UNACK1 Property
        /// </summary>
        public static readonly DependencyProperty UNACK1Property =
            DependencyProperty.Register("UNACK1", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the UNACK1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK1
        {
            get { return (bool)this.GetValue(UNACK1Property); }
            set { this.SetValue(UNACK1Property, value); }
        }

        /// <summary>
        /// UNACK2 Property
        /// </summary>
        public static readonly DependencyProperty UNACK2Property =
            DependencyProperty.Register("UNACK2", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the UNACK2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK2
        {
            get { return (bool)this.GetValue(UNACK2Property); }
            set { this.SetValue(UNACK2Property, value); }
        }

        /// <summary>
        /// OPEN_BP_FB Property
        /// </summary>
        public static readonly DependencyProperty OPEN_BP_FBProperty =
            DependencyProperty.Register("OPEN_BP_FB", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the OPEN_BP_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OPEN_BP_FB
        {
            get { return (bool)this.GetValue(OPEN_BP_FBProperty); }
            set { this.SetValue(OPEN_BP_FBProperty, value); }
        }

        /// <summary>
        /// CLOSED_BP_FB Property
        /// </summary>
        public static readonly DependencyProperty CLOSED_BP_FBProperty =
            DependencyProperty.Register("CLOSED_BP_FB", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the CLOSED_BP_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CLOSED_BP_FB
        {
            get { return (bool)this.GetValue(CLOSED_BP_FBProperty); }
            set { this.SetValue(CLOSED_BP_FBProperty, value); }
        }

        /// <summary>
        /// STAIND Property
        /// </summary>
        public static readonly DependencyProperty STAINDProperty =
            DependencyProperty.Register("STAIND", typeof(int), typeof(FP_PV));

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
        /// OPN_CMD Property
        /// </summary>
        public static readonly DependencyProperty OPN_CMDProperty =
            DependencyProperty.Register("OPN_CMD", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the OPN_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OPN_CMD
        {
            get { return (bool)this.GetValue(OPN_CMDProperty); }
            set { this.SetValue(OPN_CMDProperty, value); }
        }

        /// <summary>
        /// CLS_CMD Property
        /// </summary>
        public static readonly DependencyProperty CLS_CMDProperty =
            DependencyProperty.Register("CLS_CMD", typeof(bool), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the CLS_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CLS_CMD
        {
            get { return (bool)this.GetValue(CLS_CMDProperty); }
            set { this.SetValue(CLS_CMDProperty, value); }
        }

        /// <summary>
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_PV));

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
            DependencyProperty.Register("FP_Alarm21_CB_NAME", typeof(string), typeof(FP_PV));

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
        /// FP_Alarm21_CB_NAME2 Property
        /// </summary>
        public static readonly DependencyProperty FP_Alarm21_CB_NAME2Property =
            DependencyProperty.Register("FP_Alarm21_CB_NAME2", typeof(string), typeof(FP_PV));

        /// <summary>
        /// Gets or sets the FP_Alarm21_CB_NAME2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_Alarm21_CB_NAME2
        {
            get { return (string)this.GetValue(FP_Alarm21_CB_NAME2Property); }
            set { this.SetValue(FP_Alarm21_CB_NAME2Property, value); }
        }


		
    }
}
