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
	[Export("FP_PUMP_03")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_PUMP_03
    {
        public FP_PUMP_03()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_PUMP_03));

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
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_PUMP_03));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_PUMP_03));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_PUMP_03));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_PUMP_03));

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
        /// RUN Property
        /// </summary>
        public static readonly DependencyProperty RUNProperty =
            DependencyProperty.Register("RUN", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the RUN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool RUN
        {
            get { return (bool)this.GetValue(RUNProperty); }
            set { this.SetValue(RUNProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_PUMP_03));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_PUMP_03));

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
        /// STOP Property
        /// </summary>
        public static readonly DependencyProperty STOPProperty =
            DependencyProperty.Register("STOP", typeof(string), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STOP
        {
            get { return (string)this.GetValue(STOPProperty); }
            set { this.SetValue(STOPProperty, value); }
        }

        /// <summary>
        /// START Property
        /// </summary>
        public static readonly DependencyProperty STARTProperty =
            DependencyProperty.Register("START", typeof(string), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the START.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START
        {
            get { return (string)this.GetValue(STARTProperty); }
            set { this.SetValue(STARTProperty, value); }
        }

        /// <summary>
        /// FAULT Property
        /// </summary>
        public static readonly DependencyProperty FAULTProperty =
            DependencyProperty.Register("FAULT", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the FAULT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FAULT
        {
            get { return (bool)this.GetValue(FAULTProperty); }
            set { this.SetValue(FAULTProperty, value); }
        }

        /// <summary>
        /// LR Property
        /// </summary>
        public static readonly DependencyProperty LRProperty =
            DependencyProperty.Register("LR", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the LR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LR
        {
            get { return (bool)this.GetValue(LRProperty); }
            set { this.SetValue(LRProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_PUMP_03));

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
        /// START_CMD Property
        /// </summary>
        public static readonly DependencyProperty START_CMDProperty =
            DependencyProperty.Register("START_CMD", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the START_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool START_CMD
        {
            get { return (bool)this.GetValue(START_CMDProperty); }
            set { this.SetValue(START_CMDProperty, value); }
        }

        /// <summary>
        /// STOP_CMD Property
        /// </summary>
        public static readonly DependencyProperty STOP_CMDProperty =
            DependencyProperty.Register("STOP_CMD", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STOP_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOP_CMD
        {
            get { return (bool)this.GetValue(STOP_CMDProperty); }
            set { this.SetValue(STOP_CMDProperty, value); }
        }

        /// <summary>
        /// STARTBLK Property
        /// </summary>
        public static readonly DependencyProperty STARTBLKProperty =
            DependencyProperty.Register("STARTBLK", typeof(string), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STARTBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STARTBLK
        {
            get { return (string)this.GetValue(STARTBLKProperty); }
            set { this.SetValue(STARTBLKProperty, value); }
        }

        /// <summary>
        /// STOPBLK Property
        /// </summary>
        public static readonly DependencyProperty STOPBLKProperty =
            DependencyProperty.Register("STOPBLK", typeof(string), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STOPBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STOPBLK
        {
            get { return (string)this.GetValue(STOPBLKProperty); }
            set { this.SetValue(STOPBLKProperty, value); }
        }

        /// <summary>
        /// START_F Property
        /// </summary>
        public static readonly DependencyProperty START_FProperty =
            DependencyProperty.Register("START_F", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the START_F.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool START_F
        {
            get { return (bool)this.GetValue(START_FProperty); }
            set { this.SetValue(START_FProperty, value); }
        }

        /// <summary>
        /// STOP_F Property
        /// </summary>
        public static readonly DependencyProperty STOP_FProperty =
            DependencyProperty.Register("STOP_F", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STOP_F.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOP_F
        {
            get { return (bool)this.GetValue(STOP_FProperty); }
            set { this.SetValue(STOP_FProperty, value); }
        }

        /// <summary>
        /// DS Property
        /// </summary>
        public static readonly DependencyProperty DSProperty =
            DependencyProperty.Register("DS", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the DS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DS
        {
            get { return (bool)this.GetValue(DSProperty); }
            set { this.SetValue(DSProperty, value); }
        }

        /// <summary>
        /// MISMATCH Property
        /// </summary>
        public static readonly DependencyProperty MISMATCHProperty =
            DependencyProperty.Register("MISMATCH", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the MISMATCH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MISMATCH
        {
            get { return (bool)this.GetValue(MISMATCHProperty); }
            set { this.SetValue(MISMATCHProperty, value); }
        }

        /// <summary>
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_PUMP_03));

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
        /// RST_CMD Property
        /// </summary>
        public static readonly DependencyProperty RST_CMDProperty =
            DependencyProperty.Register("RST_CMD", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the RST_CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool RST_CMD
        {
            get { return (bool)this.GetValue(RST_CMDProperty); }
            set { this.SetValue(RST_CMDProperty, value); }
        }

        /// <summary>
        /// STARTPERM Property
        /// </summary>
        public static readonly DependencyProperty STARTPERMProperty =
            DependencyProperty.Register("STARTPERM", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STARTPERM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STARTPERM
        {
            get { return (bool)this.GetValue(STARTPERMProperty); }
            set { this.SetValue(STARTPERMProperty, value); }
        }

        /// <summary>
        /// STOPPERM Property
        /// </summary>
        public static readonly DependencyProperty STOPPERMProperty =
            DependencyProperty.Register("STOPPERM", typeof(bool), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the STOPPERM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOPPERM
        {
            get { return (bool)this.GetValue(STOPPERMProperty); }
            set { this.SetValue(STOPPERMProperty, value); }
        }

        /// <summary>
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_PUMP_03));

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
        /// AM_Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty AM_Command_BitProperty =
            DependencyProperty.Register("AM_Command_Bit", typeof(bool), typeof(FP_PUMP_03));

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
            DependencyProperty.Register("AM_FeedBack_Bit", typeof(bool), typeof(FP_PUMP_03));

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
            DependencyProperty.Register("AM_OFF_Message", typeof(string), typeof(FP_PUMP_03));

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
            DependencyProperty.Register("AM_ON_Message", typeof(string), typeof(FP_PUMP_03));

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
        /// ACK_CMD_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CMD_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CMD_CB_NAME", typeof(string), typeof(FP_PUMP_03));

        /// <summary>
        /// Gets or sets the ACK_CMD_CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_CMD_CB_NAME
        {
            get { return (string)this.GetValue(ACK_CMD_CB_NAMEProperty); }
            set { this.SetValue(ACK_CMD_CB_NAMEProperty, value); }
        }


		
    }
}
