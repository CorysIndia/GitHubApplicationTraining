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
	[Export("FP_ONOFFVLV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_ONOFFVLV
    {
        public FP_ONOFFVLV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_ONOFFVLV));

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
        /// STATUS Property
        /// </summary>
        public static readonly DependencyProperty STATUSProperty =
            DependencyProperty.Register("STATUS", typeof(string), typeof(FP_ONOFFVLV));

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
        /// STAIND Property
        /// </summary>
        public static readonly DependencyProperty STAINDProperty =
            DependencyProperty.Register("STAIND", typeof(int), typeof(FP_ONOFFVLV));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the PICK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PICK
        {
            get { return (bool)this.GetValue(PICKProperty); }
            set { this.SetValue(PICKProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_ONOFFVLV));

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
        /// AVLLM1 Property
        /// </summary>
        public static readonly DependencyProperty AVLLM1Property =
            DependencyProperty.Register("AVLLM1", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the AVLLM1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AVLLM1
        {
            get { return (bool)this.GetValue(AVLLM1Property); }
            set { this.SetValue(AVLLM1Property, value); }
        }

        /// <summary>
        /// AVLLM2 Property
        /// </summary>
        public static readonly DependencyProperty AVLLM2Property =
            DependencyProperty.Register("AVLLM2", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the AVLLM2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AVLLM2
        {
            get { return (bool)this.GetValue(AVLLM2Property); }
            set { this.SetValue(AVLLM2Property, value); }
        }

        /// <summary>
        /// DEVLM1 Property
        /// </summary>
        public static readonly DependencyProperty DEVLM1Property =
            DependencyProperty.Register("DEVLM1", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the DEVLM1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DEVLM1
        {
            get { return (bool)this.GetValue(DEVLM1Property); }
            set { this.SetValue(DEVLM1Property, value); }
        }

        /// <summary>
        /// DEVLM2 Property
        /// </summary>
        public static readonly DependencyProperty DEVLM2Property =
            DependencyProperty.Register("DEVLM2", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the DEVLM2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DEVLM2
        {
            get { return (bool)this.GetValue(DEVLM2Property); }
            set { this.SetValue(DEVLM2Property, value); }
        }

        /// <summary>
        /// DSRIND Property
        /// </summary>
        public static readonly DependencyProperty DSRINDProperty =
            DependencyProperty.Register("DSRIND", typeof(bool), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the DSRIND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DSRIND
        {
            get { return (bool)this.GetValue(DSRINDProperty); }
            set { this.SetValue(DSRINDProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_ONOFFVLV));

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
        /// BLKNAME Property
        /// </summary>
        public static readonly DependencyProperty BLKNAMEProperty =
            DependencyProperty.Register("BLKNAME", typeof(string), typeof(FP_ONOFFVLV));

        /// <summary>
        /// Gets or sets the BLKNAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKNAME
        {
            get { return (string)this.GetValue(BLKNAMEProperty); }
            set { this.SetValue(BLKNAMEProperty, value); }
        }

        /// <summary>
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_ONOFFVLV));

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
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_ONOFFVLV));

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
        /// AM_Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty AM_Command_BitProperty =
            DependencyProperty.Register("AM_Command_Bit", typeof(bool), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("AM_FeedBack_Bit", typeof(bool), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("AM_OFF_Message", typeof(string), typeof(FP_ONOFFVLV));

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
            DependencyProperty.Register("AM_ON_Message", typeof(string), typeof(FP_ONOFFVLV));

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


		
    }
}
