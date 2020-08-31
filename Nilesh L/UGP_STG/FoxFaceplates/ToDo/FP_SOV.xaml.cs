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
	[Export("FP_SOV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_SOV
    {
        public FP_SOV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_SOV));

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
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_SOV));

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
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_SOV));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_SOV));

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
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_SOV));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(bool), typeof(FP_SOV));

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
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_SOV));

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
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_SOV));

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
            DependencyProperty.Register("BLKNAME", typeof(string), typeof(FP_SOV));

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
        /// COUT Property
        /// </summary>
        public static readonly DependencyProperty COUTProperty =
            DependencyProperty.Register("COUT", typeof(bool), typeof(FP_SOV));

        /// <summary>
        /// Gets or sets the COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool COUT
        {
            get { return (bool)this.GetValue(COUTProperty); }
            set { this.SetValue(COUTProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_SOV));

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
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_SOV));

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
