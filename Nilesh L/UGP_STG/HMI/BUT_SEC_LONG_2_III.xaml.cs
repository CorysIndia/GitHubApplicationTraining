using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_STG.HMI
{
    public class BUT_SEC_LONG_2_III : RSIControlModel
    {
        static BUT_SEC_LONG_2_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BUT_SEC_LONG_2_III), new FrameworkPropertyMetadata(typeof(BUT_SEC_LONG_2_III)));
        }

		public BUT_SEC_LONG_2_III()
        {
            this.Loaded += OnLoaded; 
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.ControlMargin = ControlsHelper.GetControlMargin(this);
            this.Loaded -= OnLoaded;
        }

		      /// <summary>
        /// ControlMargin Property
        /// </summary>
        public static readonly DependencyProperty ControlMarginProperty =
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the Margin.  
        /// </summary>
        [Category("RSI")]
        [Description(@"")]
        public Thickness ControlMargin
        {
            get { return (Thickness)this.GetValue(ControlMarginProperty); }
            set { this.SetValue(ControlMarginProperty, value); }
        }


		        /// <summary>
        /// Pushed Property
        /// </summary>
        public static readonly DependencyProperty PushedProperty =
            DependencyProperty.Register("Pushed", typeof(bool), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the Pushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal tracking of when the button is pushed.")]
        public bool Pushed
        {
            get { return (bool)this.GetValue(PushedProperty); }
            set { this.SetValue(PushedProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string NameStore
        {
            get { return (string)this.GetValue(NameStoreProperty); }
            set { this.SetValue(NameStoreProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// ACSL_1 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_1Property =
            DependencyProperty.Register("ACSL_1", typeof(int), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lowest Access Level Range for the application.  The ACSL_NAME1 is displayed when the logged in $AccessLevel is less than or equal to this value. ")]
        public int ACSL_1
        {
            get { return (int)this.GetValue(ACSL_1Property); }
            set { this.SetValue(ACSL_1Property, value); }
        }

        /// <summary>
        /// ACSL_2 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_2Property =
            DependencyProperty.Register("ACSL_2", typeof(int), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The 2nd Lowest Access Level Range for the application.  The ACSL_NAME2 is displayed when the logged in $AccessLevel is greater than ACSL_1 and less or equal to ACSL_2.")]
        public int ACSL_2
        {
            get { return (int)this.GetValue(ACSL_2Property); }
            set { this.SetValue(ACSL_2Property, value); }
        }

        /// <summary>
        /// ACSL_3 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_3Property =
            DependencyProperty.Register("ACSL_3", typeof(int), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The 2nd highest Access Level Range for the application.  The ACSL_NAME3 is displayed when the logged in $AccessLevel is greater than ACSL_2 and less or equal to ACSL_3.")]
        public int ACSL_3
        {
            get { return (int)this.GetValue(ACSL_3Property); }
            set { this.SetValue(ACSL_3Property, value); }
        }

        /// <summary>
        /// ACSL_4 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_4Property =
            DependencyProperty.Register("ACSL_4", typeof(int), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The Highest Access Level Range for the application.  The ACSL_NAME4 is displayed when the logged in $AccessLevel is greater than ACSL_3 and less or equal to ACSL_4.  The ACSL_NAME5 is displayed when the logged in $AccessLevel is greater than this value. ")]
        public int ACSL_4
        {
            get { return (int)this.GetValue(ACSL_4Property); }
            set { this.SetValue(ACSL_4Property, value); }
        }

        /// <summary>
        /// ACSL_NAME1 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_NAME1Property =
            DependencyProperty.Register("ACSL_NAME1", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_NAME1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the lowest $AccessLevel.  (e.g. None)")]
        public string ACSL_NAME1
        {
            get { return (string)this.GetValue(ACSL_NAME1Property); }
            set { this.SetValue(ACSL_NAME1Property, value); }
        }

        /// <summary>
        /// ACSL_NAME2 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_NAME2Property =
            DependencyProperty.Register("ACSL_NAME2", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_NAME2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_1 and ACSL_2. (e.g. Monitor)")]
        public string ACSL_NAME2
        {
            get { return (string)this.GetValue(ACSL_NAME2Property); }
            set { this.SetValue(ACSL_NAME2Property, value); }
        }

        /// <summary>
        /// ACSL_NAME3 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_NAME3Property =
            DependencyProperty.Register("ACSL_NAME3", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_NAME3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_2 and ACSL_3. (e.g. Operator)")]
        public string ACSL_NAME3
        {
            get { return (string)this.GetValue(ACSL_NAME3Property); }
            set { this.SetValue(ACSL_NAME3Property, value); }
        }

        /// <summary>
        /// ACSL_NAME4 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_NAME4Property =
            DependencyProperty.Register("ACSL_NAME4", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_NAME4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the $AccessLevel between ACSL_3 and ACSL_4. (e.g. Supervisor)")]
        public string ACSL_NAME4
        {
            get { return (string)this.GetValue(ACSL_NAME4Property); }
            set { this.SetValue(ACSL_NAME4Property, value); }
        }

        /// <summary>
        /// ACSL_NAME5 Property
        /// </summary>
        public static readonly DependencyProperty ACSL_NAME5Property =
            DependencyProperty.Register("ACSL_NAME5", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the ACSL_NAME5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the name for the highest $AccessLevel.  (e.g. Administrator)")]
        public string ACSL_NAME5
        {
            get { return (string)this.GetValue(ACSL_NAME5Property); }
            set { this.SetValue(ACSL_NAME5Property, value); }
        }

        /// <summary>
        /// WinName Property
        /// </summary>
        public static readonly DependencyProperty WinNameProperty =
            DependencyProperty.Register("WinName", typeof(string), typeof(BUT_SEC_LONG_2_III));

        /// <summary>
        /// Gets or sets the WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string WinName
        {
            get { return (string)this.GetValue(WinNameProperty); }
            set { this.SetValue(WinNameProperty, value); }
        }


		
        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
				foreach (var p in base.IndissLikeParameters)
				{
					yield return p;
				}

				if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);
if (!string.IsNullOrWhiteSpace(this.ACSL_NAME1)) yield return new Param("$ACSL_NAME1", this.ACSL_NAME1);
if (!string.IsNullOrWhiteSpace(this.ACSL_NAME2)) yield return new Param("$ACSL_NAME2", this.ACSL_NAME2);
if (!string.IsNullOrWhiteSpace(this.ACSL_NAME3)) yield return new Param("$ACSL_NAME3", this.ACSL_NAME3);
if (!string.IsNullOrWhiteSpace(this.ACSL_NAME4)) yield return new Param("$ACSL_NAME4", this.ACSL_NAME4);
if (!string.IsNullOrWhiteSpace(this.ACSL_NAME5)) yield return new Param("$ACSL_NAME5", this.ACSL_NAME5);
if (!string.IsNullOrWhiteSpace(this.WinName)) yield return new Param("$WinName", this.WinName);

            }
        }

		
    }
}
