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
	[Export("SECURITY_ACCOUNT")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SECURITY_ACCOUNT
    {
        public SECURITY_ACCOUNT()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SECURITY_ACCOUNT));

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
        /// PbMom_03_M1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_NameStoreProperty =
            DependencyProperty.Register("PbMom_03_M1_NameStore", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_03_M1_NameStore
        {
            get { return (string)this.GetValue(PbMom_03_M1_NameStoreProperty); }
            set { this.SetValue(PbMom_03_M1_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M1_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_DisableProperty =
            DependencyProperty.Register("PbMom_03_M1_Disable", typeof(bool), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool PbMom_03_M1_Disable
        {
            get { return (bool)this.GetValue(PbMom_03_M1_DisableProperty); }
            set { this.SetValue(PbMom_03_M1_DisableProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M1_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_WinNameProperty =
            DependencyProperty.Register("PbMom_03_M1_WinName", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_03_M1_WinName
        {
            get { return (string)this.GetValue(PbMom_03_M1_WinNameProperty); }
            set { this.SetValue(PbMom_03_M1_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_NameStoreProperty =
            DependencyProperty.Register("PbMom_03_M2_NameStore", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_03_M2_NameStore
        {
            get { return (string)this.GetValue(PbMom_03_M2_NameStoreProperty); }
            set { this.SetValue(PbMom_03_M2_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_DisableProperty =
            DependencyProperty.Register("PbMom_03_M2_Disable", typeof(bool), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool PbMom_03_M2_Disable
        {
            get { return (bool)this.GetValue(PbMom_03_M2_DisableProperty); }
            set { this.SetValue(PbMom_03_M2_DisableProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_WinNameProperty =
            DependencyProperty.Register("PbMom_03_M2_WinName", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_03_M2_WinName
        {
            get { return (string)this.GetValue(PbMom_03_M2_WinNameProperty); }
            set { this.SetValue(PbMom_03_M2_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M3_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M3_NameStoreProperty =
            DependencyProperty.Register("PbMom_03_M3_NameStore", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M3_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_03_M3_NameStore
        {
            get { return (string)this.GetValue(PbMom_03_M3_NameStoreProperty); }
            set { this.SetValue(PbMom_03_M3_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M3_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M3_DisableProperty =
            DependencyProperty.Register("PbMom_03_M3_Disable", typeof(bool), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M3_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool PbMom_03_M3_Disable
        {
            get { return (bool)this.GetValue(PbMom_03_M3_DisableProperty); }
            set { this.SetValue(PbMom_03_M3_DisableProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M3_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M3_WinNameProperty =
            DependencyProperty.Register("PbMom_03_M3_WinName", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the PbMom_03_M3_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_03_M3_WinName
        {
            get { return (string)this.GetValue(PbMom_03_M3_WinNameProperty); }
            set { this.SetValue(PbMom_03_M3_WinNameProperty, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_NAME1 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_NAME1Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_NAME1", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_NAME1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the lowest $AccessLevel.  (e.g. None)")]
        public string BUT_SEC_LONG_III1_ACSL_NAME1
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_ACSL_NAME1Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_NAME1Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_NAME2 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_NAME2Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_NAME2", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_NAME2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_1 and ACSL_2. (e.g. Monitor)")]
        public string BUT_SEC_LONG_III1_ACSL_NAME2
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_ACSL_NAME2Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_NAME2Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_NAME3 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_NAME3Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_NAME3", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_NAME3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_2 and ACSL_3. (e.g. Operator)")]
        public string BUT_SEC_LONG_III1_ACSL_NAME3
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_ACSL_NAME3Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_NAME3Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_NAME4 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_NAME4Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_NAME4", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_NAME4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_3 and ACSL_4. (e.g. Supervisor)")]
        public string BUT_SEC_LONG_III1_ACSL_NAME4
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_ACSL_NAME4Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_NAME4Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_NAME5 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_NAME5Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_NAME5", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_NAME5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the highest $AccessLevel.  (e.g. Administrator)")]
        public string BUT_SEC_LONG_III1_ACSL_NAME5
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_ACSL_NAME5Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_NAME5Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_4 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_4Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_4", typeof(int), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The Highest Access Level Range for the application.  The ACSL_NAME4 is displayed when the logged in $AccessLevel is greater than ACSL_3 and less or equal to ACSL_4.  The ACSL_NAME5 is displayed when the logged in $AccessLevel is greater than this value. ")]
        public int BUT_SEC_LONG_III1_ACSL_4
        {
            get { return (int)this.GetValue(BUT_SEC_LONG_III1_ACSL_4Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_4Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_3 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_3Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_3", typeof(int), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The 2nd highest Access Level Range for the application.  The ACSL_NAME3 is displayed when the logged in $AccessLevel is greater than ACSL_2 and less or equal to ACSL_3.")]
        public int BUT_SEC_LONG_III1_ACSL_3
        {
            get { return (int)this.GetValue(BUT_SEC_LONG_III1_ACSL_3Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_3Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_2 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_2Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_2", typeof(int), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The 2nd Lowest Access Level Range for the application.  The ACSL_NAME2 is displayed when the logged in $AccessLevel is greater than ACSL_1 and less or equal to ACSL_2.")]
        public int BUT_SEC_LONG_III1_ACSL_2
        {
            get { return (int)this.GetValue(BUT_SEC_LONG_III1_ACSL_2Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_2Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_ACSL_1 Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_ACSL_1Property =
            DependencyProperty.Register("BUT_SEC_LONG_III1_ACSL_1", typeof(int), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_ACSL_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lowest Access Level Range for the application.  The ACSL_NAME1 is displayed when the logged in $AccessLevel is less than or equal to this value. ")]
        public int BUT_SEC_LONG_III1_ACSL_1
        {
            get { return (int)this.GetValue(BUT_SEC_LONG_III1_ACSL_1Property); }
            set { this.SetValue(BUT_SEC_LONG_III1_ACSL_1Property, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_Disable Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_DisableProperty =
            DependencyProperty.Register("BUT_SEC_LONG_III1_Disable", typeof(bool), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool BUT_SEC_LONG_III1_Disable
        {
            get { return (bool)this.GetValue(BUT_SEC_LONG_III1_DisableProperty); }
            set { this.SetValue(BUT_SEC_LONG_III1_DisableProperty, value); }
        }

        /// <summary>
        /// BUT_SEC_LONG_III1_WinName Property
        /// </summary>
        public static readonly DependencyProperty BUT_SEC_LONG_III1_WinNameProperty =
            DependencyProperty.Register("BUT_SEC_LONG_III1_WinName", typeof(string), typeof(SECURITY_ACCOUNT));

        /// <summary>
        /// Gets or sets the BUT_SEC_LONG_III1_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string BUT_SEC_LONG_III1_WinName
        {
            get { return (string)this.GetValue(BUT_SEC_LONG_III1_WinNameProperty); }
            set { this.SetValue(BUT_SEC_LONG_III1_WinNameProperty, value); }
        }


		
    }
}
