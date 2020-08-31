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
	[Export("FP_CIN")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_CIN
    {
        public FP_CIN()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_CIN));

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
        /// CIN Property
        /// </summary>
        public static readonly DependencyProperty CINProperty =
            DependencyProperty.Register("CIN", typeof(bool), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CIN
        {
            get { return (bool)this.GetValue(CINProperty); }
            set { this.SetValue(CINProperty, value); }
        }

        /// <summary>
        /// SCTXT0 Property
        /// </summary>
        public static readonly DependencyProperty SCTXT0Property =
            DependencyProperty.Register("SCTXT0", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the SCTXT0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SCTXT0
        {
            get { return (string)this.GetValue(SCTXT0Property); }
            set { this.SetValue(SCTXT0Property, value); }
        }

        /// <summary>
        /// SCTXT1 Property
        /// </summary>
        public static readonly DependencyProperty SCTXT1Property =
            DependencyProperty.Register("SCTXT1", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the SCTXT1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SCTXT1
        {
            get { return (string)this.GetValue(SCTXT1Property); }
            set { this.SetValue(SCTXT1Property, value); }
        }

        /// <summary>
        /// PvCB_1 Property
        /// </summary>
        public static readonly DependencyProperty PvCB_1Property =
            DependencyProperty.Register("PvCB_1", typeof(string), typeof(FP_CIN));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_CIN));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_CIN));

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
        /// DESCRP Property
        /// </summary>
        public static readonly DependencyProperty DESCRPProperty =
            DependencyProperty.Register("DESCRP", typeof(string), typeof(FP_CIN));

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
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_CIN));

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
        /// BLKSTA Property
        /// </summary>
        public static readonly DependencyProperty BLKSTAProperty =
            DependencyProperty.Register("BLKSTA", typeof(int), typeof(FP_CIN));

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
        /// MA Property
        /// </summary>
        public static readonly DependencyProperty MAProperty =
            DependencyProperty.Register("MA", typeof(bool), typeof(FP_CIN));

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
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_CIN));

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
        /// Trend_CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR1Property =
            DependencyProperty.Register("Trend_CMPBLKPAR1", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR1
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR1Property); }
            set { this.SetValue(Trend_CMPBLKPAR1Property, value); }
        }

        /// <summary>
        /// Trend_Identity Property
        /// </summary>
        public static readonly DependencyProperty Trend_IdentityProperty =
            DependencyProperty.Register("Trend_Identity", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the Trend_Identity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Compound+BLock")]
        public string Trend_Identity
        {
            get { return (string)this.GetValue(Trend_IdentityProperty); }
            set { this.SetValue(Trend_IdentityProperty, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR2Property =
            DependencyProperty.Register("Trend_CMPBLKPAR2", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR2
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR2Property); }
            set { this.SetValue(Trend_CMPBLKPAR2Property, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR3Property =
            DependencyProperty.Register("Trend_CMPBLKPAR3", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR3
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR3Property); }
            set { this.SetValue(Trend_CMPBLKPAR3Property, value); }
        }

        /// <summary>
        /// Trend_CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty Trend_CMPBLKPAR4Property =
            DependencyProperty.Register("Trend_CMPBLKPAR4", typeof(string), typeof(FP_CIN));

        /// <summary>
        /// Gets or sets the Trend_CMPBLKPAR4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Trend_CMPBLKPAR4
        {
            get { return (string)this.GetValue(Trend_CMPBLKPAR4Property); }
            set { this.SetValue(Trend_CMPBLKPAR4Property, value); }
        }

        /// <summary>
        /// ACK_CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty ACK_CB_NAMEProperty =
            DependencyProperty.Register("ACK_CB_NAME", typeof(string), typeof(FP_CIN));

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
