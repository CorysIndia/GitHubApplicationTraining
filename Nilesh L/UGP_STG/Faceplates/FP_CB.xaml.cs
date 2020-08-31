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
	[Export("FP_CB")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_CB
    {
        public FP_CB()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_CB));

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
        /// CBP1 Property
        /// </summary>
        public static readonly DependencyProperty CBP1Property =
            DependencyProperty.Register("CBP1", typeof(string), typeof(FP_CB));

        /// <summary>
        /// Gets or sets the CBP1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP1
        {
            get { return (string)this.GetValue(CBP1Property); }
            set { this.SetValue(CBP1Property, value); }
        }

        /// <summary>
        /// CBP2 Property
        /// </summary>
        public static readonly DependencyProperty CBP2Property =
            DependencyProperty.Register("CBP2", typeof(string), typeof(FP_CB));

        /// <summary>
        /// Gets or sets the CBP2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP2
        {
            get { return (string)this.GetValue(CBP2Property); }
            set { this.SetValue(CBP2Property, value); }
        }

        /// <summary>
        /// CBP3 Property
        /// </summary>
        public static readonly DependencyProperty CBP3Property =
            DependencyProperty.Register("CBP3", typeof(string), typeof(FP_CB));

        /// <summary>
        /// Gets or sets the CBP3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP3
        {
            get { return (string)this.GetValue(CBP3Property); }
            set { this.SetValue(CBP3Property, value); }
        }

        /// <summary>
        /// CBP4 Property
        /// </summary>
        public static readonly DependencyProperty CBP4Property =
            DependencyProperty.Register("CBP4", typeof(string), typeof(FP_CB));

        /// <summary>
        /// Gets or sets the CBP4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP4
        {
            get { return (string)this.GetValue(CBP4Property); }
            set { this.SetValue(CBP4Property, value); }
        }


		
    }
}
