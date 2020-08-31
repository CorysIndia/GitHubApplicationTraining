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
	[Export("PI_0195_VOTED")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PI_0195_VOTED
    {
        public PI_0195_VOTED()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PI_0195_VOTED));

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
        /// aIndTranIn_01_M1_VALUE Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_VALUEProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_VALUE", typeof(double), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname to display its value here

e.g. rPI12345")]
        public double aIndTranIn_01_M1_VALUE
        {
            get { return (double)this.GetValue(aIndTranIn_01_M1_VALUEProperty); }
            set { this.SetValue(aIndTranIn_01_M1_VALUEProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_FAIL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_FAILProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_FAIL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm FAIL tagname here to change Tagname Background colour. 
When True, Tag Background is Black.
When False, Tag Background is Red.")]
        public bool aIndTranIn_01_M1_FAIL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_FAILProperty); }
            set { this.SetValue(aIndTranIn_01_M1_FAILProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_LL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_LLProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_LL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_LL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to change the DisplayValue colour. 
When True, DisplayValue is Green.
When False, DisplayValue is Red.")]
        public bool aIndTranIn_01_M1_LL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_LLProperty); }
            set { this.SetValue(aIndTranIn_01_M1_LLProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_L Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_LProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_L", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_L.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M1_L
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_LProperty); }
            set { this.SetValue(aIndTranIn_01_M1_LProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_H Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_HProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_H", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_H.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm High tagname here to enable H alarm indicator. 
When True, H indicator is hidden.
When False, H indicator appears.")]
        public bool aIndTranIn_01_M1_H
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_HProperty); }
            set { this.SetValue(aIndTranIn_01_M1_HProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_HH Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_HHProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_HH", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_HH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M1_HH
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_HHProperty); }
            set { this.SetValue(aIndTranIn_01_M1_HHProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_DEV Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_DEVProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_DEV", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm DEV tagname here to enable DEV alarm indicator. 
When True, DEV indicator is hidden.
When False, DEV indicator appears.")]
        public bool aIndTranIn_01_M1_DEV
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_DEVProperty); }
            set { this.SetValue(aIndTranIn_01_M1_DEVProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M1_BYPASS Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M1_BYPASSProperty =
            DependencyProperty.Register("aIndTranIn_01_M1_BYPASS", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M1_BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm BYP tagname here to enable BYP alarm indicator. 
When True, BYP indicator is hidden.
When False, BYP indicator appears.")]
        public bool aIndTranIn_01_M1_BYPASS
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M1_BYPASSProperty); }
            set { this.SetValue(aIndTranIn_01_M1_BYPASSProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_VALUE Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_VALUEProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_VALUE", typeof(double), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname to display its value here

e.g. rPI12345")]
        public double aIndTranIn_01_M2_VALUE
        {
            get { return (double)this.GetValue(aIndTranIn_01_M2_VALUEProperty); }
            set { this.SetValue(aIndTranIn_01_M2_VALUEProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_FAIL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_FAILProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_FAIL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm FAIL tagname here to change Tagname Background colour. 
When True, Tag Background is Black.
When False, Tag Background is Red.")]
        public bool aIndTranIn_01_M2_FAIL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_FAILProperty); }
            set { this.SetValue(aIndTranIn_01_M2_FAILProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_LL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_LLProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_LL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_LL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to change the DisplayValue colour. 
When True, DisplayValue is Green.
When False, DisplayValue is Red.")]
        public bool aIndTranIn_01_M2_LL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_LLProperty); }
            set { this.SetValue(aIndTranIn_01_M2_LLProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_L Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_LProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_L", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_L.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M2_L
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_LProperty); }
            set { this.SetValue(aIndTranIn_01_M2_LProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_H Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_HProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_H", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_H.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm High tagname here to enable H alarm indicator. 
When True, H indicator is hidden.
When False, H indicator appears.")]
        public bool aIndTranIn_01_M2_H
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_HProperty); }
            set { this.SetValue(aIndTranIn_01_M2_HProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_HH Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_HHProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_HH", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_HH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M2_HH
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_HHProperty); }
            set { this.SetValue(aIndTranIn_01_M2_HHProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_DEV Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_DEVProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_DEV", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm DEV tagname here to enable DEV alarm indicator. 
When True, DEV indicator is hidden.
When False, DEV indicator appears.")]
        public bool aIndTranIn_01_M2_DEV
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_DEVProperty); }
            set { this.SetValue(aIndTranIn_01_M2_DEVProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M2_BYPASS Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M2_BYPASSProperty =
            DependencyProperty.Register("aIndTranIn_01_M2_BYPASS", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M2_BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm BYP tagname here to enable BYP alarm indicator. 
When True, BYP indicator is hidden.
When False, BYP indicator appears.")]
        public bool aIndTranIn_01_M2_BYPASS
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M2_BYPASSProperty); }
            set { this.SetValue(aIndTranIn_01_M2_BYPASSProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_VALUE Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_VALUEProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_VALUE", typeof(double), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname to display its value here

e.g. rPI12345")]
        public double aIndTranIn_01_M3_VALUE
        {
            get { return (double)this.GetValue(aIndTranIn_01_M3_VALUEProperty); }
            set { this.SetValue(aIndTranIn_01_M3_VALUEProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_FAIL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_FAILProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_FAIL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm FAIL tagname here to change Tagname Background colour. 
When True, Tag Background is Black.
When False, Tag Background is Red.")]
        public bool aIndTranIn_01_M3_FAIL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_FAILProperty); }
            set { this.SetValue(aIndTranIn_01_M3_FAILProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_LL Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_LLProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_LL", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_LL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to change the DisplayValue colour. 
When True, DisplayValue is Green.
When False, DisplayValue is Red.")]
        public bool aIndTranIn_01_M3_LL
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_LLProperty); }
            set { this.SetValue(aIndTranIn_01_M3_LLProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_L Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_LProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_L", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_L.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M3_L
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_LProperty); }
            set { this.SetValue(aIndTranIn_01_M3_LProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_H Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_HProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_H", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_H.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm High tagname here to enable H alarm indicator. 
When True, H indicator is hidden.
When False, H indicator appears.")]
        public bool aIndTranIn_01_M3_H
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_HProperty); }
            set { this.SetValue(aIndTranIn_01_M3_HProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_HH Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_HHProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_HH", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_HH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool aIndTranIn_01_M3_HH
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_HHProperty); }
            set { this.SetValue(aIndTranIn_01_M3_HHProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_DEV Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_DEVProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_DEV", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm DEV tagname here to enable DEV alarm indicator. 
When True, DEV indicator is hidden.
When False, DEV indicator appears.")]
        public bool aIndTranIn_01_M3_DEV
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_DEVProperty); }
            set { this.SetValue(aIndTranIn_01_M3_DEVProperty, value); }
        }

        /// <summary>
        /// aIndTranIn_01_M3_BYPASS Property
        /// </summary>
        public static readonly DependencyProperty aIndTranIn_01_M3_BYPASSProperty =
            DependencyProperty.Register("aIndTranIn_01_M3_BYPASS", typeof(bool), typeof(PI_0195_VOTED));

        /// <summary>
        /// Gets or sets the aIndTranIn_01_M3_BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm BYP tagname here to enable BYP alarm indicator. 
When True, BYP indicator is hidden.
When False, BYP indicator appears.")]
        public bool aIndTranIn_01_M3_BYPASS
        {
            get { return (bool)this.GetValue(aIndTranIn_01_M3_BYPASSProperty); }
            set { this.SetValue(aIndTranIn_01_M3_BYPASSProperty, value); }
        }


		
    }
}
