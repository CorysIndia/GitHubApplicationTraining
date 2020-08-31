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
	[Export("PD_K0003B")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PD_K0003B
    {
        public PD_K0003B()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_VALUE", typeof(double), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_FAIL", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_LL", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_L", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_H", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_HH", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_DEV", typeof(bool), typeof(PD_K0003B));

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
            DependencyProperty.Register("aIndTranIn_01_M1_BYPASS", typeof(bool), typeof(PD_K0003B));

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
        /// ConQl_031_Value Property
        /// </summary>
        public static readonly DependencyProperty ConQl_031_ValueProperty =
            DependencyProperty.Register("ConQl_031_Value", typeof(double), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_031_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display the value")]
        public double ConQl_031_Value
        {
            get { return (double)this.GetValue(ConQl_031_ValueProperty); }
            set { this.SetValue(ConQl_031_ValueProperty, value); }
        }

        /// <summary>
        /// ConQl_031_PIDMode Property
        /// </summary>
        public static readonly DependencyProperty ConQl_031_PIDModeProperty =
            DependencyProperty.Register("ConQl_031_PIDMode", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_031_PIDMode.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Auto
False - Manual")]
        public bool ConQl_031_PIDMode
        {
            get { return (bool)this.GetValue(ConQl_031_PIDModeProperty); }
            set { this.SetValue(ConQl_031_PIDModeProperty, value); }
        }

        /// <summary>
        /// ConQl_031_NameStore Property
        /// </summary>
        public static readonly DependencyProperty ConQl_031_NameStoreProperty =
            DependencyProperty.Register("ConQl_031_NameStore", typeof(string), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_031_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ConQl_031_NameStore
        {
            get { return (string)this.GetValue(ConQl_031_NameStoreProperty); }
            set { this.SetValue(ConQl_031_NameStoreProperty, value); }
        }

        /// <summary>
        /// ConQl_031_PIDModeDisable Property
        /// </summary>
        public static readonly DependencyProperty ConQl_031_PIDModeDisableProperty =
            DependencyProperty.Register("ConQl_031_PIDModeDisable", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_031_PIDModeDisable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - If PID is always in Auto")]
        public bool ConQl_031_PIDModeDisable
        {
            get { return (bool)this.GetValue(ConQl_031_PIDModeDisableProperty); }
            set { this.SetValue(ConQl_031_PIDModeDisableProperty, value); }
        }

        /// <summary>
        /// ConQl_031_Disable Property
        /// </summary>
        public static readonly DependencyProperty ConQl_031_DisableProperty =
            DependencyProperty.Register("ConQl_031_Disable", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_031_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ConQl_031_Disable
        {
            get { return (bool)this.GetValue(ConQl_031_DisableProperty); }
            set { this.SetValue(ConQl_031_DisableProperty, value); }
        }

        /// <summary>
        /// Type1_AO_Display_9Letter1_VALUE Property
        /// </summary>
        public static readonly DependencyProperty Type1_AO_Display_9Letter1_VALUEProperty =
            DependencyProperty.Register("Type1_AO_Display_9Letter1_VALUE", typeof(double), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the Type1_AO_Display_9Letter1_VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname you want to display the value here")]
        public double Type1_AO_Display_9Letter1_VALUE
        {
            get { return (double)this.GetValue(Type1_AO_Display_9Letter1_VALUEProperty); }
            set { this.SetValue(Type1_AO_Display_9Letter1_VALUEProperty, value); }
        }

        /// <summary>
        /// ConQl_032_Value Property
        /// </summary>
        public static readonly DependencyProperty ConQl_032_ValueProperty =
            DependencyProperty.Register("ConQl_032_Value", typeof(double), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_032_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display the value")]
        public double ConQl_032_Value
        {
            get { return (double)this.GetValue(ConQl_032_ValueProperty); }
            set { this.SetValue(ConQl_032_ValueProperty, value); }
        }

        /// <summary>
        /// ConQl_032_PIDMode Property
        /// </summary>
        public static readonly DependencyProperty ConQl_032_PIDModeProperty =
            DependencyProperty.Register("ConQl_032_PIDMode", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_032_PIDMode.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Auto
False - Manual")]
        public bool ConQl_032_PIDMode
        {
            get { return (bool)this.GetValue(ConQl_032_PIDModeProperty); }
            set { this.SetValue(ConQl_032_PIDModeProperty, value); }
        }

        /// <summary>
        /// ConQl_032_NameStore Property
        /// </summary>
        public static readonly DependencyProperty ConQl_032_NameStoreProperty =
            DependencyProperty.Register("ConQl_032_NameStore", typeof(string), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_032_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ConQl_032_NameStore
        {
            get { return (string)this.GetValue(ConQl_032_NameStoreProperty); }
            set { this.SetValue(ConQl_032_NameStoreProperty, value); }
        }

        /// <summary>
        /// ConQl_032_PIDModeDisable Property
        /// </summary>
        public static readonly DependencyProperty ConQl_032_PIDModeDisableProperty =
            DependencyProperty.Register("ConQl_032_PIDModeDisable", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_032_PIDModeDisable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - If PID is always in Auto")]
        public bool ConQl_032_PIDModeDisable
        {
            get { return (bool)this.GetValue(ConQl_032_PIDModeDisableProperty); }
            set { this.SetValue(ConQl_032_PIDModeDisableProperty, value); }
        }

        /// <summary>
        /// ConQl_032_Disable Property
        /// </summary>
        public static readonly DependencyProperty ConQl_032_DisableProperty =
            DependencyProperty.Register("ConQl_032_Disable", typeof(bool), typeof(PD_K0003B));

        /// <summary>
        /// Gets or sets the ConQl_032_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ConQl_032_Disable
        {
            get { return (bool)this.GetValue(ConQl_032_DisableProperty); }
            set { this.SetValue(ConQl_032_DisableProperty, value); }
        }


		
    }
}
