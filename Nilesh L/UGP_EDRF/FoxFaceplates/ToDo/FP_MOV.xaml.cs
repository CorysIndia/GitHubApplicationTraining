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
	[Export("FP_MOV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_MOV
    {
        public FP_MOV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_MOV));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_MOV));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_MOV));

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
        /// OPEN Property
        /// </summary>
        public static readonly DependencyProperty OPENProperty =
            DependencyProperty.Register("OPEN", typeof(bool), typeof(FP_MOV));

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
        /// CLOSED Property
        /// </summary>
        public static readonly DependencyProperty CLOSEDProperty =
            DependencyProperty.Register("CLOSED", typeof(bool), typeof(FP_MOV));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_MOV));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_MOV));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_MOV));

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
            DependencyProperty.Register("STATUS", typeof(string), typeof(FP_MOV));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_MOV));

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
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_MOV));

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
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_MOV));

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
        /// LOCAL Property
        /// </summary>
        public static readonly DependencyProperty LOCALProperty =
            DependencyProperty.Register("LOCAL", typeof(bool), typeof(FP_MOV));

        /// <summary>
        /// Gets or sets the LOCAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LOCAL
        {
            get { return (bool)this.GetValue(LOCALProperty); }
            set { this.SetValue(LOCALProperty, value); }
        }

        /// <summary>
        /// STAIND Property
        /// </summary>
        public static readonly DependencyProperty STAINDProperty =
            DependencyProperty.Register("STAIND", typeof(int), typeof(FP_MOV));

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
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_MOV));

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
        /// STOPPED Property
        /// </summary>
        public static readonly DependencyProperty STOPPEDProperty =
            DependencyProperty.Register("STOPPED", typeof(bool), typeof(FP_MOV));

        /// <summary>
        /// Gets or sets the STOPPED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOPPED
        {
            get { return (bool)this.GetValue(STOPPEDProperty); }
            set { this.SetValue(STOPPEDProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_MOV));

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
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_MOV));

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


		
    }
}
