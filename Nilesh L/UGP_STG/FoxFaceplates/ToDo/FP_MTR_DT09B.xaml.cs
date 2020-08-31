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
	[Export("FP_MTR_DT09B")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_MTR_DT09B
    {
        public FP_MTR_DT09B()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("RUN", typeof(bool), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_MTR_DT09B));

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
        /// PERM Property
        /// </summary>
        public static readonly DependencyProperty PERMProperty =
            DependencyProperty.Register("PERM", typeof(bool), typeof(FP_MTR_DT09B));

        /// <summary>
        /// Gets or sets the PERM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PERM
        {
            get { return (bool)this.GetValue(PERMProperty); }
            set { this.SetValue(PERMProperty, value); }
        }

        /// <summary>
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_MTR_DT09B));

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
        /// TRIP Property
        /// </summary>
        public static readonly DependencyProperty TRIPProperty =
            DependencyProperty.Register("TRIP", typeof(bool), typeof(FP_MTR_DT09B));

        /// <summary>
        /// Gets or sets the TRIP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRIP
        {
            get { return (bool)this.GetValue(TRIPProperty); }
            set { this.SetValue(TRIPProperty, value); }
        }

        /// <summary>
        /// READYRESET Property
        /// </summary>
        public static readonly DependencyProperty READYRESETProperty =
            DependencyProperty.Register("READYRESET", typeof(bool), typeof(FP_MTR_DT09B));

        /// <summary>
        /// Gets or sets the READYRESET.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool READYRESET
        {
            get { return (bool)this.GetValue(READYRESETProperty); }
            set { this.SetValue(READYRESETProperty, value); }
        }

        /// <summary>
        /// READYSTART Property
        /// </summary>
        public static readonly DependencyProperty READYSTARTProperty =
            DependencyProperty.Register("READYSTART", typeof(bool), typeof(FP_MTR_DT09B));

        /// <summary>
        /// Gets or sets the READYSTART.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool READYSTART
        {
            get { return (bool)this.GetValue(READYSTARTProperty); }
            set { this.SetValue(READYSTARTProperty, value); }
        }

        /// <summary>
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_MTR_DT09B));

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
        /// STOPBLK Property
        /// </summary>
        public static readonly DependencyProperty STOPBLKProperty =
            DependencyProperty.Register("STOPBLK", typeof(string), typeof(FP_MTR_DT09B));

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
        /// STOP_CMD Property
        /// </summary>
        public static readonly DependencyProperty STOP_CMDProperty =
            DependencyProperty.Register("STOP_CMD", typeof(bool), typeof(FP_MTR_DT09B));

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
        /// BYPASSBLK Property
        /// </summary>
        public static readonly DependencyProperty BYPASSBLKProperty =
            DependencyProperty.Register("BYPASSBLK", typeof(string), typeof(FP_MTR_DT09B));

        /// <summary>
        /// Gets or sets the BYPASSBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BYPASSBLK
        {
            get { return (string)this.GetValue(BYPASSBLKProperty); }
            set { this.SetValue(BYPASSBLKProperty, value); }
        }

        /// <summary>
        /// STOP_F Property
        /// </summary>
        public static readonly DependencyProperty STOP_FProperty =
            DependencyProperty.Register("STOP_F", typeof(bool), typeof(FP_MTR_DT09B));

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
        /// RST_CMD Property
        /// </summary>
        public static readonly DependencyProperty RST_CMDProperty =
            DependencyProperty.Register("RST_CMD", typeof(bool), typeof(FP_MTR_DT09B));

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
        /// ACK_CMD_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CMD_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CMD_CB_NAME", typeof(string), typeof(FP_MTR_DT09B));

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
            DependencyProperty.Register("Button_Close_CON1", typeof(bool), typeof(FP_MTR_DT09B));

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
