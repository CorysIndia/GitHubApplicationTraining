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
	[Export("FP_MTR_DT01AB")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_MTR_DT01AB
    {
        public FP_MTR_DT01AB()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("RUN", typeof(bool), typeof(FP_MTR_DT01AB));

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
        /// STAIND Property
        /// </summary>
        public static readonly DependencyProperty STAINDProperty =
            DependencyProperty.Register("STAIND", typeof(int), typeof(FP_MTR_DT01AB));

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
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_MTR_DT01AB));

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
        /// PICK1 Property
        /// </summary>
        public static readonly DependencyProperty PICK1Property =
            DependencyProperty.Register("PICK1", typeof(bool), typeof(FP_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the PICK1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PICK1
        {
            get { return (bool)this.GetValue(PICK1Property); }
            set { this.SetValue(PICK1Property, value); }
        }

        /// <summary>
        /// AUTO_FB Property
        /// </summary>
        public static readonly DependencyProperty AUTO_FBProperty =
            DependencyProperty.Register("AUTO_FB", typeof(bool), typeof(FP_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the AUTO_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AUTO_FB
        {
            get { return (bool)this.GetValue(AUTO_FBProperty); }
            set { this.SetValue(AUTO_FBProperty, value); }
        }

        /// <summary>
        /// _CONN1 Property
        /// </summary>
        public static readonly DependencyProperty _CONN1Property =
            DependencyProperty.Register("_CONN1", typeof(bool), typeof(FP_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the _CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CONN1
        {
            get { return (bool)this.GetValue(_CONN1Property); }
            set { this.SetValue(_CONN1Property, value); }
        }

        /// <summary>
        /// HAND Property
        /// </summary>
        public static readonly DependencyProperty HANDProperty =
            DependencyProperty.Register("HAND", typeof(bool), typeof(FP_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the HAND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HAND
        {
            get { return (bool)this.GetValue(HANDProperty); }
            set { this.SetValue(HANDProperty, value); }
        }

        /// <summary>
        /// STOP Property
        /// </summary>
        public static readonly DependencyProperty STOPProperty =
            DependencyProperty.Register("STOP", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("START", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("FAULT", typeof(bool), typeof(FP_MTR_DT01AB));

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
        /// REMOTE Property
        /// </summary>
        public static readonly DependencyProperty REMOTEProperty =
            DependencyProperty.Register("REMOTE", typeof(bool), typeof(FP_MTR_DT01AB));

        /// <summary>
        /// Gets or sets the REMOTE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool REMOTE
        {
            get { return (bool)this.GetValue(REMOTEProperty); }
            set { this.SetValue(REMOTEProperty, value); }
        }

        /// <summary>
        /// UNACK1 Property
        /// </summary>
        public static readonly DependencyProperty UNACK1Property =
            DependencyProperty.Register("UNACK1", typeof(bool), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("UNACK2", typeof(bool), typeof(FP_MTR_DT01AB));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("START_CMD", typeof(bool), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("STOP_CMD", typeof(bool), typeof(FP_MTR_DT01AB));

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
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_MTR_DT01AB));

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
        /// STARTBLK Property
        /// </summary>
        public static readonly DependencyProperty STARTBLKProperty =
            DependencyProperty.Register("STARTBLK", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("STOPBLK", typeof(string), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("START_F", typeof(bool), typeof(FP_MTR_DT01AB));

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
            DependencyProperty.Register("STOP_F", typeof(bool), typeof(FP_MTR_DT01AB));

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
        /// ACK_CMD_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CMD_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CMD_CB_NAME", typeof(string), typeof(FP_MTR_DT01AB));

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

        /// <summary>
        /// Button_Close_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close_CON1Property =
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_MTR_DT01AB));

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


		
    }
}
