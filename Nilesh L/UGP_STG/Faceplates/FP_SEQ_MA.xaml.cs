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
	[Export("FP_SEQ_MA")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_SEQ_MA
    {
        public FP_SEQ_MA()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_SEQ_MA));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_SEQ_MA));

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
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_SEQ_MA));

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
        /// HS Property
        /// </summary>
        public static readonly DependencyProperty HSProperty =
            DependencyProperty.Register("HS", typeof(bool), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the HS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HS
        {
            get { return (bool)this.GetValue(HSProperty); }
            set { this.SetValue(HSProperty, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_SEQ_MA));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_SEQ_MA));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PRT
        {
            get { return (string)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// PAROVL Property
        /// </summary>
        public static readonly DependencyProperty PAROVLProperty =
            DependencyProperty.Register("PAROVL", typeof(string), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL
        {
            get { return (string)this.GetValue(PAROVLProperty); }
            set { this.SetValue(PAROVLProperty, value); }
        }

        /// <summary>
        /// PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL2Property =
            DependencyProperty.Register("PAROVL2", typeof(string), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL2
        {
            get { return (string)this.GetValue(PAROVL2Property); }
            set { this.SetValue(PAROVL2Property, value); }
        }

        /// <summary>
        /// MANUAL Property
        /// </summary>
        public static readonly DependencyProperty MANUALProperty =
            DependencyProperty.Register("MANUAL", typeof(bool), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the MANUAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MANUAL
        {
            get { return (bool)this.GetValue(MANUALProperty); }
            set { this.SetValue(MANUALProperty, value); }
        }

        /// <summary>
        /// PERMESSIVE Property
        /// </summary>
        public static readonly DependencyProperty PERMESSIVEProperty =
            DependencyProperty.Register("PERMESSIVE", typeof(bool), typeof(FP_SEQ_MA));

        /// <summary>
        /// Gets or sets the PERMESSIVE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PERMESSIVE
        {
            get { return (bool)this.GetValue(PERMESSIVEProperty); }
            set { this.SetValue(PERMESSIVEProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_SEQ_MA));

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


		
    }
}
