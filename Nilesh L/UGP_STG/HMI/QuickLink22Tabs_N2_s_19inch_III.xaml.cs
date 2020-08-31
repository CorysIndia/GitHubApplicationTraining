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
    public class QuickLink22Tabs_N2_s_19inch_III : RSIControlModel
    {
        static QuickLink22Tabs_N2_s_19inch_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(QuickLink22Tabs_N2_s_19inch_III), new FrameworkPropertyMetadata(typeof(QuickLink22Tabs_N2_s_19inch_III)));
        }

		public QuickLink22Tabs_N2_s_19inch_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(QuickLink22Tabs_N2_s_19inch_III));

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
        /// SelectedTab Property
        /// </summary>
        public static readonly DependencyProperty SelectedTabProperty =
            DependencyProperty.Register("SelectedTab", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the SelectedTab.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the caption of the selected tab.")]
        public string SelectedTab
        {
            get { return (string)this.GetValue(SelectedTabProperty); }
            set { this.SetValue(SelectedTabProperty, value); }
        }

        /// <summary>
        /// SelectedTabIndex Property
        /// </summary>
        public static readonly DependencyProperty SelectedTabIndexProperty =
            DependencyProperty.Register("SelectedTabIndex", typeof(int), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the SelectedTabIndex.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The index (number) of the selected tab.")]
        public int SelectedTabIndex
        {
            get { return (int)this.GetValue(SelectedTabIndexProperty); }
            set { this.SetValue(SelectedTabIndexProperty, value); }
        }

        /// <summary>
        /// TabCount Property
        /// </summary>
        public static readonly DependencyProperty TabCountProperty =
            DependencyProperty.Register("TabCount", typeof(int), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the TabCount.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Sets how many tabs are visible.")]
        public int TabCount
        {
            get { return (int)this.GetValue(TabCountProperty); }
            set { this.SetValue(TabCountProperty, value); }
        }

        /// <summary>
        /// SetTabIndex Property
        /// </summary>
        public static readonly DependencyProperty SetTabIndexProperty =
            DependencyProperty.Register("SetTabIndex", typeof(int), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the SetTabIndex.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Set this value to change the tab by the index number.  This allows you to force the tabs to change without operator intervention.")]
        public int SetTabIndex
        {
            get { return (int)this.GetValue(SetTabIndexProperty); }
            set { this.SetValue(SetTabIndexProperty, value); }
        }

        /// <summary>
        /// DefaultTabIndex Property
        /// </summary>
        public static readonly DependencyProperty DefaultTabIndexProperty =
            DependencyProperty.Register("DefaultTabIndex", typeof(int), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the DefaultTabIndex.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Sets the default selected tab.  When 'shown' the navigation bar will automatically set this tab as selected.  Set to 0 to not have any tab selected.")]
        public int DefaultTabIndex
        {
            get { return (int)this.GetValue(DefaultTabIndexProperty); }
            set { this.SetValue(DefaultTabIndexProperty, value); }
        }

        /// <summary>
        /// aaReadme Property
        /// </summary>
        public static readonly DependencyProperty aaReadmeProperty =
            DependencyProperty.Register("aaReadme", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the aaReadme.  
        /// </summary>
		[Category("RSI")]
        [Description(@"TODO:
1. Create a Memory Integer Tag 'iWINDOW' on intouch. 
2. At the window script of each linked tab==>
   a) for Condition Type: 'ON SHOW' ==> iWINDOW = #;
        whereby # refers to the corresponding tab number.
   b) for Condition Type: 'ON HIDE' ==> iWINDOW = 999;

FYI:
This symbol can be used to emulate the windows tab control.  
To use the control:
1. Use Substitute Strings to change tab names to the desired caption.
2. Set 'TabCount' property to the number of tabs to display.
3. Use either the 'SelectedTab' or 'SelectedTabIndex' property to 
    track the currently selected tab.
4. If you want to dynamically change the selected tab (by script or 
    external stimulus), change the 'SetTabIndex' property which will 
    change the selected tab automatically.")]
        public string aaReadme
        {
            get { return (string)this.GetValue(aaReadmeProperty); }
            set { this.SetValue(aaReadmeProperty, value); }
        }

        /// <summary>
        /// Initialize Property
        /// </summary>
        public static readonly DependencyProperty InitializeProperty =
            DependencyProperty.Register("Initialize", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Initialize.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal: Forces the tab names to refresh from the embedded symbols before passing back to user.")]
        public bool Initialize
        {
            get { return (bool)this.GetValue(InitializeProperty); }
            set { this.SetValue(InitializeProperty, value); }
        }

        /// <summary>
        /// Button15_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button15_SelectedProperty =
            DependencyProperty.Register("Button15_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button15_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button15_Selected
        {
            get { return (bool)this.GetValue(Button15_SelectedProperty); }
            set { this.SetValue(Button15_SelectedProperty, value); }
        }

        /// <summary>
        /// Button15_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button15_TabNameProperty =
            DependencyProperty.Register("Button15_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button15_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button15_TabName
        {
            get { return (string)this.GetValue(Button15_TabNameProperty); }
            set { this.SetValue(Button15_TabNameProperty, value); }
        }

        /// <summary>
        /// Button15_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button15_TabVisibleProperty =
            DependencyProperty.Register("Button15_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button15_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button15_TabVisible
        {
            get { return (bool)this.GetValue(Button15_TabVisibleProperty); }
            set { this.SetValue(Button15_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button15_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button15_AlarmProperty =
            DependencyProperty.Register("Button15_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button15_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button15_Alarm
        {
            get { return (bool)this.GetValue(Button15_AlarmProperty); }
            set { this.SetValue(Button15_AlarmProperty, value); }
        }

        /// <summary>
        /// Button15_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button15_NameStoreProperty =
            DependencyProperty.Register("Button15_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button15_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button15_NameStore
        {
            get { return (string)this.GetValue(Button15_NameStoreProperty); }
            set { this.SetValue(Button15_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button14_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button14_SelectedProperty =
            DependencyProperty.Register("Button14_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button14_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button14_Selected
        {
            get { return (bool)this.GetValue(Button14_SelectedProperty); }
            set { this.SetValue(Button14_SelectedProperty, value); }
        }

        /// <summary>
        /// Button14_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button14_TabNameProperty =
            DependencyProperty.Register("Button14_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button14_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button14_TabName
        {
            get { return (string)this.GetValue(Button14_TabNameProperty); }
            set { this.SetValue(Button14_TabNameProperty, value); }
        }

        /// <summary>
        /// Button14_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button14_TabVisibleProperty =
            DependencyProperty.Register("Button14_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button14_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button14_TabVisible
        {
            get { return (bool)this.GetValue(Button14_TabVisibleProperty); }
            set { this.SetValue(Button14_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button14_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button14_AlarmProperty =
            DependencyProperty.Register("Button14_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button14_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button14_Alarm
        {
            get { return (bool)this.GetValue(Button14_AlarmProperty); }
            set { this.SetValue(Button14_AlarmProperty, value); }
        }

        /// <summary>
        /// Button14_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button14_NameStoreProperty =
            DependencyProperty.Register("Button14_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button14_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button14_NameStore
        {
            get { return (string)this.GetValue(Button14_NameStoreProperty); }
            set { this.SetValue(Button14_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button13_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button13_SelectedProperty =
            DependencyProperty.Register("Button13_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button13_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button13_Selected
        {
            get { return (bool)this.GetValue(Button13_SelectedProperty); }
            set { this.SetValue(Button13_SelectedProperty, value); }
        }

        /// <summary>
        /// Button13_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button13_TabNameProperty =
            DependencyProperty.Register("Button13_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button13_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button13_TabName
        {
            get { return (string)this.GetValue(Button13_TabNameProperty); }
            set { this.SetValue(Button13_TabNameProperty, value); }
        }

        /// <summary>
        /// Button13_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button13_TabVisibleProperty =
            DependencyProperty.Register("Button13_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button13_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button13_TabVisible
        {
            get { return (bool)this.GetValue(Button13_TabVisibleProperty); }
            set { this.SetValue(Button13_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button13_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button13_AlarmProperty =
            DependencyProperty.Register("Button13_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button13_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button13_Alarm
        {
            get { return (bool)this.GetValue(Button13_AlarmProperty); }
            set { this.SetValue(Button13_AlarmProperty, value); }
        }

        /// <summary>
        /// Button13_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button13_NameStoreProperty =
            DependencyProperty.Register("Button13_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button13_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button13_NameStore
        {
            get { return (string)this.GetValue(Button13_NameStoreProperty); }
            set { this.SetValue(Button13_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button12_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button12_SelectedProperty =
            DependencyProperty.Register("Button12_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button12_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button12_Selected
        {
            get { return (bool)this.GetValue(Button12_SelectedProperty); }
            set { this.SetValue(Button12_SelectedProperty, value); }
        }

        /// <summary>
        /// Button12_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button12_TabNameProperty =
            DependencyProperty.Register("Button12_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button12_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button12_TabName
        {
            get { return (string)this.GetValue(Button12_TabNameProperty); }
            set { this.SetValue(Button12_TabNameProperty, value); }
        }

        /// <summary>
        /// Button12_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button12_TabVisibleProperty =
            DependencyProperty.Register("Button12_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button12_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button12_TabVisible
        {
            get { return (bool)this.GetValue(Button12_TabVisibleProperty); }
            set { this.SetValue(Button12_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button12_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button12_AlarmProperty =
            DependencyProperty.Register("Button12_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button12_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button12_Alarm
        {
            get { return (bool)this.GetValue(Button12_AlarmProperty); }
            set { this.SetValue(Button12_AlarmProperty, value); }
        }

        /// <summary>
        /// Button12_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button12_NameStoreProperty =
            DependencyProperty.Register("Button12_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button12_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button12_NameStore
        {
            get { return (string)this.GetValue(Button12_NameStoreProperty); }
            set { this.SetValue(Button12_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button11_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button11_SelectedProperty =
            DependencyProperty.Register("Button11_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button11_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button11_Selected
        {
            get { return (bool)this.GetValue(Button11_SelectedProperty); }
            set { this.SetValue(Button11_SelectedProperty, value); }
        }

        /// <summary>
        /// Button11_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button11_TabNameProperty =
            DependencyProperty.Register("Button11_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button11_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button11_TabName
        {
            get { return (string)this.GetValue(Button11_TabNameProperty); }
            set { this.SetValue(Button11_TabNameProperty, value); }
        }

        /// <summary>
        /// Button11_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button11_TabVisibleProperty =
            DependencyProperty.Register("Button11_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button11_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button11_TabVisible
        {
            get { return (bool)this.GetValue(Button11_TabVisibleProperty); }
            set { this.SetValue(Button11_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button11_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button11_AlarmProperty =
            DependencyProperty.Register("Button11_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button11_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button11_Alarm
        {
            get { return (bool)this.GetValue(Button11_AlarmProperty); }
            set { this.SetValue(Button11_AlarmProperty, value); }
        }

        /// <summary>
        /// Button11_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button11_NameStoreProperty =
            DependencyProperty.Register("Button11_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button11_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button11_NameStore
        {
            get { return (string)this.GetValue(Button11_NameStoreProperty); }
            set { this.SetValue(Button11_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button10_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button10_SelectedProperty =
            DependencyProperty.Register("Button10_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button10_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button10_Selected
        {
            get { return (bool)this.GetValue(Button10_SelectedProperty); }
            set { this.SetValue(Button10_SelectedProperty, value); }
        }

        /// <summary>
        /// Button10_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button10_TabNameProperty =
            DependencyProperty.Register("Button10_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button10_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button10_TabName
        {
            get { return (string)this.GetValue(Button10_TabNameProperty); }
            set { this.SetValue(Button10_TabNameProperty, value); }
        }

        /// <summary>
        /// Button10_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button10_TabVisibleProperty =
            DependencyProperty.Register("Button10_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button10_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button10_TabVisible
        {
            get { return (bool)this.GetValue(Button10_TabVisibleProperty); }
            set { this.SetValue(Button10_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button10_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button10_AlarmProperty =
            DependencyProperty.Register("Button10_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button10_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button10_Alarm
        {
            get { return (bool)this.GetValue(Button10_AlarmProperty); }
            set { this.SetValue(Button10_AlarmProperty, value); }
        }

        /// <summary>
        /// Button10_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button10_NameStoreProperty =
            DependencyProperty.Register("Button10_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button10_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button10_NameStore
        {
            get { return (string)this.GetValue(Button10_NameStoreProperty); }
            set { this.SetValue(Button10_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button9_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button9_SelectedProperty =
            DependencyProperty.Register("Button9_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button9_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button9_Selected
        {
            get { return (bool)this.GetValue(Button9_SelectedProperty); }
            set { this.SetValue(Button9_SelectedProperty, value); }
        }

        /// <summary>
        /// Button9_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button9_TabNameProperty =
            DependencyProperty.Register("Button9_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button9_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button9_TabName
        {
            get { return (string)this.GetValue(Button9_TabNameProperty); }
            set { this.SetValue(Button9_TabNameProperty, value); }
        }

        /// <summary>
        /// Button9_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button9_TabVisibleProperty =
            DependencyProperty.Register("Button9_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button9_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button9_TabVisible
        {
            get { return (bool)this.GetValue(Button9_TabVisibleProperty); }
            set { this.SetValue(Button9_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button9_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button9_AlarmProperty =
            DependencyProperty.Register("Button9_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button9_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button9_Alarm
        {
            get { return (bool)this.GetValue(Button9_AlarmProperty); }
            set { this.SetValue(Button9_AlarmProperty, value); }
        }

        /// <summary>
        /// Button9_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button9_NameStoreProperty =
            DependencyProperty.Register("Button9_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button9_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button9_NameStore
        {
            get { return (string)this.GetValue(Button9_NameStoreProperty); }
            set { this.SetValue(Button9_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button8_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button8_SelectedProperty =
            DependencyProperty.Register("Button8_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button8_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button8_Selected
        {
            get { return (bool)this.GetValue(Button8_SelectedProperty); }
            set { this.SetValue(Button8_SelectedProperty, value); }
        }

        /// <summary>
        /// Button8_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button8_TabNameProperty =
            DependencyProperty.Register("Button8_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button8_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button8_TabName
        {
            get { return (string)this.GetValue(Button8_TabNameProperty); }
            set { this.SetValue(Button8_TabNameProperty, value); }
        }

        /// <summary>
        /// Button8_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button8_TabVisibleProperty =
            DependencyProperty.Register("Button8_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button8_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button8_TabVisible
        {
            get { return (bool)this.GetValue(Button8_TabVisibleProperty); }
            set { this.SetValue(Button8_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button8_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button8_AlarmProperty =
            DependencyProperty.Register("Button8_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button8_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button8_Alarm
        {
            get { return (bool)this.GetValue(Button8_AlarmProperty); }
            set { this.SetValue(Button8_AlarmProperty, value); }
        }

        /// <summary>
        /// Button8_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button8_NameStoreProperty =
            DependencyProperty.Register("Button8_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button8_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button8_NameStore
        {
            get { return (string)this.GetValue(Button8_NameStoreProperty); }
            set { this.SetValue(Button8_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button7_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button7_SelectedProperty =
            DependencyProperty.Register("Button7_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button7_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button7_Selected
        {
            get { return (bool)this.GetValue(Button7_SelectedProperty); }
            set { this.SetValue(Button7_SelectedProperty, value); }
        }

        /// <summary>
        /// Button7_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button7_TabNameProperty =
            DependencyProperty.Register("Button7_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button7_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button7_TabName
        {
            get { return (string)this.GetValue(Button7_TabNameProperty); }
            set { this.SetValue(Button7_TabNameProperty, value); }
        }

        /// <summary>
        /// Button7_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button7_TabVisibleProperty =
            DependencyProperty.Register("Button7_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button7_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button7_TabVisible
        {
            get { return (bool)this.GetValue(Button7_TabVisibleProperty); }
            set { this.SetValue(Button7_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button7_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button7_AlarmProperty =
            DependencyProperty.Register("Button7_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button7_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button7_Alarm
        {
            get { return (bool)this.GetValue(Button7_AlarmProperty); }
            set { this.SetValue(Button7_AlarmProperty, value); }
        }

        /// <summary>
        /// Button7_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button7_NameStoreProperty =
            DependencyProperty.Register("Button7_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button7_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button7_NameStore
        {
            get { return (string)this.GetValue(Button7_NameStoreProperty); }
            set { this.SetValue(Button7_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button6_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button6_SelectedProperty =
            DependencyProperty.Register("Button6_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button6_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button6_Selected
        {
            get { return (bool)this.GetValue(Button6_SelectedProperty); }
            set { this.SetValue(Button6_SelectedProperty, value); }
        }

        /// <summary>
        /// Button6_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button6_TabNameProperty =
            DependencyProperty.Register("Button6_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button6_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button6_TabName
        {
            get { return (string)this.GetValue(Button6_TabNameProperty); }
            set { this.SetValue(Button6_TabNameProperty, value); }
        }

        /// <summary>
        /// Button6_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button6_TabVisibleProperty =
            DependencyProperty.Register("Button6_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button6_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button6_TabVisible
        {
            get { return (bool)this.GetValue(Button6_TabVisibleProperty); }
            set { this.SetValue(Button6_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button6_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button6_AlarmProperty =
            DependencyProperty.Register("Button6_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button6_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button6_Alarm
        {
            get { return (bool)this.GetValue(Button6_AlarmProperty); }
            set { this.SetValue(Button6_AlarmProperty, value); }
        }

        /// <summary>
        /// Button6_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button6_NameStoreProperty =
            DependencyProperty.Register("Button6_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button6_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button6_NameStore
        {
            get { return (string)this.GetValue(Button6_NameStoreProperty); }
            set { this.SetValue(Button6_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button5_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button5_SelectedProperty =
            DependencyProperty.Register("Button5_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button5_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button5_Selected
        {
            get { return (bool)this.GetValue(Button5_SelectedProperty); }
            set { this.SetValue(Button5_SelectedProperty, value); }
        }

        /// <summary>
        /// Button5_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button5_TabNameProperty =
            DependencyProperty.Register("Button5_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button5_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button5_TabName
        {
            get { return (string)this.GetValue(Button5_TabNameProperty); }
            set { this.SetValue(Button5_TabNameProperty, value); }
        }

        /// <summary>
        /// Button5_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button5_TabVisibleProperty =
            DependencyProperty.Register("Button5_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button5_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button5_TabVisible
        {
            get { return (bool)this.GetValue(Button5_TabVisibleProperty); }
            set { this.SetValue(Button5_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button5_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button5_AlarmProperty =
            DependencyProperty.Register("Button5_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button5_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button5_Alarm
        {
            get { return (bool)this.GetValue(Button5_AlarmProperty); }
            set { this.SetValue(Button5_AlarmProperty, value); }
        }

        /// <summary>
        /// Button5_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button5_NameStoreProperty =
            DependencyProperty.Register("Button5_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button5_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button5_NameStore
        {
            get { return (string)this.GetValue(Button5_NameStoreProperty); }
            set { this.SetValue(Button5_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button4_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button4_SelectedProperty =
            DependencyProperty.Register("Button4_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button4_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button4_Selected
        {
            get { return (bool)this.GetValue(Button4_SelectedProperty); }
            set { this.SetValue(Button4_SelectedProperty, value); }
        }

        /// <summary>
        /// Button4_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button4_TabNameProperty =
            DependencyProperty.Register("Button4_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button4_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button4_TabName
        {
            get { return (string)this.GetValue(Button4_TabNameProperty); }
            set { this.SetValue(Button4_TabNameProperty, value); }
        }

        /// <summary>
        /// Button4_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button4_TabVisibleProperty =
            DependencyProperty.Register("Button4_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button4_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button4_TabVisible
        {
            get { return (bool)this.GetValue(Button4_TabVisibleProperty); }
            set { this.SetValue(Button4_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button4_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button4_AlarmProperty =
            DependencyProperty.Register("Button4_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button4_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button4_Alarm
        {
            get { return (bool)this.GetValue(Button4_AlarmProperty); }
            set { this.SetValue(Button4_AlarmProperty, value); }
        }

        /// <summary>
        /// Button4_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button4_NameStoreProperty =
            DependencyProperty.Register("Button4_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button4_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button4_NameStore
        {
            get { return (string)this.GetValue(Button4_NameStoreProperty); }
            set { this.SetValue(Button4_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button3_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button3_SelectedProperty =
            DependencyProperty.Register("Button3_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button3_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button3_Selected
        {
            get { return (bool)this.GetValue(Button3_SelectedProperty); }
            set { this.SetValue(Button3_SelectedProperty, value); }
        }

        /// <summary>
        /// Button3_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button3_TabNameProperty =
            DependencyProperty.Register("Button3_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button3_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button3_TabName
        {
            get { return (string)this.GetValue(Button3_TabNameProperty); }
            set { this.SetValue(Button3_TabNameProperty, value); }
        }

        /// <summary>
        /// Button3_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button3_TabVisibleProperty =
            DependencyProperty.Register("Button3_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button3_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button3_TabVisible
        {
            get { return (bool)this.GetValue(Button3_TabVisibleProperty); }
            set { this.SetValue(Button3_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button3_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button3_AlarmProperty =
            DependencyProperty.Register("Button3_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button3_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button3_Alarm
        {
            get { return (bool)this.GetValue(Button3_AlarmProperty); }
            set { this.SetValue(Button3_AlarmProperty, value); }
        }

        /// <summary>
        /// Button3_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button3_NameStoreProperty =
            DependencyProperty.Register("Button3_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button3_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button3_NameStore
        {
            get { return (string)this.GetValue(Button3_NameStoreProperty); }
            set { this.SetValue(Button3_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button2_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button2_SelectedProperty =
            DependencyProperty.Register("Button2_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button2_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button2_Selected
        {
            get { return (bool)this.GetValue(Button2_SelectedProperty); }
            set { this.SetValue(Button2_SelectedProperty, value); }
        }

        /// <summary>
        /// Button2_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button2_TabNameProperty =
            DependencyProperty.Register("Button2_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button2_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button2_TabName
        {
            get { return (string)this.GetValue(Button2_TabNameProperty); }
            set { this.SetValue(Button2_TabNameProperty, value); }
        }

        /// <summary>
        /// Button2_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button2_TabVisibleProperty =
            DependencyProperty.Register("Button2_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button2_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button2_TabVisible
        {
            get { return (bool)this.GetValue(Button2_TabVisibleProperty); }
            set { this.SetValue(Button2_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button2_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button2_AlarmProperty =
            DependencyProperty.Register("Button2_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button2_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button2_Alarm
        {
            get { return (bool)this.GetValue(Button2_AlarmProperty); }
            set { this.SetValue(Button2_AlarmProperty, value); }
        }

        /// <summary>
        /// Button2_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button2_NameStoreProperty =
            DependencyProperty.Register("Button2_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button2_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button2_NameStore
        {
            get { return (string)this.GetValue(Button2_NameStoreProperty); }
            set { this.SetValue(Button2_NameStoreProperty, value); }
        }

        /// <summary>
        /// Button1_Selected Property
        /// </summary>
        public static readonly DependencyProperty Button1_SelectedProperty =
            DependencyProperty.Register("Button1_Selected", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button1_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Button1_Selected
        {
            get { return (bool)this.GetValue(Button1_SelectedProperty); }
            set { this.SetValue(Button1_SelectedProperty, value); }
        }

        /// <summary>
        /// Button1_TabName Property
        /// </summary>
        public static readonly DependencyProperty Button1_TabNameProperty =
            DependencyProperty.Register("Button1_TabName", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button1_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Button1_TabName
        {
            get { return (string)this.GetValue(Button1_TabNameProperty); }
            set { this.SetValue(Button1_TabNameProperty, value); }
        }

        /// <summary>
        /// Button1_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Button1_TabVisibleProperty =
            DependencyProperty.Register("Button1_TabVisible", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button1_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button1_TabVisible
        {
            get { return (bool)this.GetValue(Button1_TabVisibleProperty); }
            set { this.SetValue(Button1_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Button1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Button1_AlarmProperty =
            DependencyProperty.Register("Button1_Alarm", typeof(bool), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button1_Alarm
        {
            get { return (bool)this.GetValue(Button1_AlarmProperty); }
            set { this.SetValue(Button1_AlarmProperty, value); }
        }

        /// <summary>
        /// Button1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Button1_NameStoreProperty =
            DependencyProperty.Register("Button1_NameStore", typeof(string), typeof(QuickLink22Tabs_N2_s_19inch_III));

        /// <summary>
        /// Gets or sets the Button1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Button1_NameStore
        {
            get { return (string)this.GetValue(Button1_NameStoreProperty); }
            set { this.SetValue(Button1_NameStoreProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.SelectedTab)) yield return new Param("$SelectedTab", this.SelectedTab);
if (!string.IsNullOrWhiteSpace(this.aaReadme)) yield return new Param("$aaReadme", this.aaReadme);

            }
        }

		
    }
}
