using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_EDRF.HMI
{
    public class SYM_SEQ_GRID_01 : RSIControlModel
    {
        static SYM_SEQ_GRID_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SEQ_GRID_01), new FrameworkPropertyMetadata(typeof(SYM_SEQ_GRID_01)));
        }

        public SYM_SEQ_GRID_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SEQ_GRID_01));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK_REGEN Property
        /// </summary>
        public static readonly DependencyProperty BLK_REGENProperty =
            DependencyProperty.Register("BLK_REGEN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the BLK_REGEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_REGEN
        {
            get { return (string)this.GetValue(BLK_REGENProperty); }
            set { this.SetValue(BLK_REGENProperty, value); }
        }

        /// <summary>
        /// PAR_REGEN Property
        /// </summary>
        public static readonly DependencyProperty PAR_REGENProperty =
            DependencyProperty.Register("PAR_REGEN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the PAR_REGEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR_REGEN
        {
            get { return (string)this.GetValue(PAR_REGENProperty); }
            set { this.SetValue(PAR_REGENProperty, value); }
        }

        /// <summary>
        /// SetTabIndex Property
        /// </summary>
        public static readonly DependencyProperty SetTabIndexProperty =
            DependencyProperty.Register("SetTabIndex", typeof(int), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the SetTabIndex.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SetTabIndex
        {
            get { return (int)this.GetValue(SetTabIndexProperty); }
            set { this.SetValue(SetTabIndexProperty, value); }
        }

        /// <summary>
        /// Initialize Property
        /// </summary>
        public static readonly DependencyProperty InitializeProperty =
            DependencyProperty.Register("Initialize", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Initialize.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Initialize
        {
            get { return (bool)this.GetValue(InitializeProperty); }
            set { this.SetValue(InitializeProperty, value); }
        }

        /// <summary>
        /// MODE Property
        /// </summary>
        public static readonly DependencyProperty MODEProperty =
            DependencyProperty.Register("MODE", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the MODE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MODE
        {
            get { return (bool)this.GetValue(MODEProperty); }
            set { this.SetValue(MODEProperty, value); }
        }

        /// <summary>
        /// ONLINE Property
        /// </summary>
        public static readonly DependencyProperty ONLINEProperty =
            DependencyProperty.Register("ONLINE", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the ONLINE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ONLINE
        {
            get { return (bool)this.GetValue(ONLINEProperty); }
            set { this.SetValue(ONLINEProperty, value); }
        }

        /// <summary>
        /// START1 Property
        /// </summary>
        public static readonly DependencyProperty START1Property =
            DependencyProperty.Register("START1", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool START1
        {
            get { return (bool)this.GetValue(START1Property); }
            set { this.SetValue(START1Property, value); }
        }

        /// <summary>
        /// START2 Property
        /// </summary>
        public static readonly DependencyProperty START2Property =
            DependencyProperty.Register("START2", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool START2
        {
            get { return (bool)this.GetValue(START2Property); }
            set { this.SetValue(START2Property, value); }
        }

        /// <summary>
        /// STANDBY Property
        /// </summary>
        public static readonly DependencyProperty STANDBYProperty =
            DependencyProperty.Register("STANDBY", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the STANDBY.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STANDBY
        {
            get { return (bool)this.GetValue(STANDBYProperty); }
            set { this.SetValue(STANDBYProperty, value); }
        }

        /// <summary>
        /// BLK_ADSORB Property
        /// </summary>
        public static readonly DependencyProperty BLK_ADSORBProperty =
            DependencyProperty.Register("BLK_ADSORB", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the BLK_ADSORB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ADSORB
        {
            get { return (string)this.GetValue(BLK_ADSORBProperty); }
            set { this.SetValue(BLK_ADSORBProperty, value); }
        }

        /// <summary>
        /// PAR_ADSORB Property
        /// </summary>
        public static readonly DependencyProperty PAR_ADSORBProperty =
            DependencyProperty.Register("PAR_ADSORB", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the PAR_ADSORB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR_ADSORB
        {
            get { return (string)this.GetValue(PAR_ADSORBProperty); }
            set { this.SetValue(PAR_ADSORBProperty, value); }
        }

        /// <summary>
        /// DRYER Property
        /// </summary>
        public static readonly DependencyProperty DRYERProperty =
            DependencyProperty.Register("DRYER", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the DRYER.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DRYER
        {
            get { return (string)this.GetValue(DRYERProperty); }
            set { this.SetValue(DRYERProperty, value); }
        }

        /// <summary>
        /// BACKGROUND_Train Property
        /// </summary>
        public static readonly DependencyProperty BACKGROUND_TrainProperty =
            DependencyProperty.Register("BACKGROUND_Train", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the BACKGROUND_Train.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BACKGROUND_Train
        {
            get { return (string)this.GetValue(BACKGROUND_TrainProperty); }
            set { this.SetValue(BACKGROUND_TrainProperty, value); }
        }

        /// <summary>
        /// Tab7_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab7_SelectedProperty =
            DependencyProperty.Register("Tab7_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab7_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab7_Selected
        {
            get { return (bool)this.GetValue(Tab7_SelectedProperty); }
            set { this.SetValue(Tab7_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab7_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab7_TabNameProperty =
            DependencyProperty.Register("Tab7_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab7_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab7_TabName
        {
            get { return (string)this.GetValue(Tab7_TabNameProperty); }
            set { this.SetValue(Tab7_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab7_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab7_TabVisibleProperty =
            DependencyProperty.Register("Tab7_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab7_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab7_TabVisible
        {
            get { return (bool)this.GetValue(Tab7_TabVisibleProperty); }
            set { this.SetValue(Tab7_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab7_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab7_AlarmProperty =
            DependencyProperty.Register("Tab7_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab7_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab7_Alarm
        {
            get { return (bool)this.GetValue(Tab7_AlarmProperty); }
            set { this.SetValue(Tab7_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab7_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab7_NameStoreProperty =
            DependencyProperty.Register("Tab7_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab7_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab7_NameStore
        {
            get { return (string)this.GetValue(Tab7_NameStoreProperty); }
            set { this.SetValue(Tab7_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab6_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab6_SelectedProperty =
            DependencyProperty.Register("Tab6_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab6_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab6_Selected
        {
            get { return (bool)this.GetValue(Tab6_SelectedProperty); }
            set { this.SetValue(Tab6_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab6_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab6_TabNameProperty =
            DependencyProperty.Register("Tab6_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab6_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab6_TabName
        {
            get { return (string)this.GetValue(Tab6_TabNameProperty); }
            set { this.SetValue(Tab6_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab6_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab6_TabVisibleProperty =
            DependencyProperty.Register("Tab6_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab6_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab6_TabVisible
        {
            get { return (bool)this.GetValue(Tab6_TabVisibleProperty); }
            set { this.SetValue(Tab6_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab6_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab6_AlarmProperty =
            DependencyProperty.Register("Tab6_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab6_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab6_Alarm
        {
            get { return (bool)this.GetValue(Tab6_AlarmProperty); }
            set { this.SetValue(Tab6_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab6_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab6_NameStoreProperty =
            DependencyProperty.Register("Tab6_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab6_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab6_NameStore
        {
            get { return (string)this.GetValue(Tab6_NameStoreProperty); }
            set { this.SetValue(Tab6_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab5_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab5_SelectedProperty =
            DependencyProperty.Register("Tab5_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab5_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab5_Selected
        {
            get { return (bool)this.GetValue(Tab5_SelectedProperty); }
            set { this.SetValue(Tab5_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab5_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab5_TabNameProperty =
            DependencyProperty.Register("Tab5_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab5_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab5_TabName
        {
            get { return (string)this.GetValue(Tab5_TabNameProperty); }
            set { this.SetValue(Tab5_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab5_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab5_TabVisibleProperty =
            DependencyProperty.Register("Tab5_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab5_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab5_TabVisible
        {
            get { return (bool)this.GetValue(Tab5_TabVisibleProperty); }
            set { this.SetValue(Tab5_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab5_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab5_AlarmProperty =
            DependencyProperty.Register("Tab5_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab5_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab5_Alarm
        {
            get { return (bool)this.GetValue(Tab5_AlarmProperty); }
            set { this.SetValue(Tab5_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab5_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab5_NameStoreProperty =
            DependencyProperty.Register("Tab5_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab5_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab5_NameStore
        {
            get { return (string)this.GetValue(Tab5_NameStoreProperty); }
            set { this.SetValue(Tab5_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab4_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab4_SelectedProperty =
            DependencyProperty.Register("Tab4_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab4_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab4_Selected
        {
            get { return (bool)this.GetValue(Tab4_SelectedProperty); }
            set { this.SetValue(Tab4_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab4_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab4_TabNameProperty =
            DependencyProperty.Register("Tab4_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab4_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab4_TabName
        {
            get { return (string)this.GetValue(Tab4_TabNameProperty); }
            set { this.SetValue(Tab4_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab4_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab4_TabVisibleProperty =
            DependencyProperty.Register("Tab4_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab4_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab4_TabVisible
        {
            get { return (bool)this.GetValue(Tab4_TabVisibleProperty); }
            set { this.SetValue(Tab4_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab4_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab4_AlarmProperty =
            DependencyProperty.Register("Tab4_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab4_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab4_Alarm
        {
            get { return (bool)this.GetValue(Tab4_AlarmProperty); }
            set { this.SetValue(Tab4_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab4_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab4_NameStoreProperty =
            DependencyProperty.Register("Tab4_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab4_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab4_NameStore
        {
            get { return (string)this.GetValue(Tab4_NameStoreProperty); }
            set { this.SetValue(Tab4_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab3_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab3_SelectedProperty =
            DependencyProperty.Register("Tab3_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab3_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab3_Selected
        {
            get { return (bool)this.GetValue(Tab3_SelectedProperty); }
            set { this.SetValue(Tab3_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab3_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab3_TabNameProperty =
            DependencyProperty.Register("Tab3_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab3_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab3_TabName
        {
            get { return (string)this.GetValue(Tab3_TabNameProperty); }
            set { this.SetValue(Tab3_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab3_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab3_TabVisibleProperty =
            DependencyProperty.Register("Tab3_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab3_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab3_TabVisible
        {
            get { return (bool)this.GetValue(Tab3_TabVisibleProperty); }
            set { this.SetValue(Tab3_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab3_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab3_AlarmProperty =
            DependencyProperty.Register("Tab3_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab3_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab3_Alarm
        {
            get { return (bool)this.GetValue(Tab3_AlarmProperty); }
            set { this.SetValue(Tab3_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab3_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab3_NameStoreProperty =
            DependencyProperty.Register("Tab3_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab3_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab3_NameStore
        {
            get { return (string)this.GetValue(Tab3_NameStoreProperty); }
            set { this.SetValue(Tab3_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab2_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab2_SelectedProperty =
            DependencyProperty.Register("Tab2_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab2_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab2_Selected
        {
            get { return (bool)this.GetValue(Tab2_SelectedProperty); }
            set { this.SetValue(Tab2_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab2_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab2_TabNameProperty =
            DependencyProperty.Register("Tab2_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab2_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab2_TabName
        {
            get { return (string)this.GetValue(Tab2_TabNameProperty); }
            set { this.SetValue(Tab2_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab2_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab2_TabVisibleProperty =
            DependencyProperty.Register("Tab2_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab2_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab2_TabVisible
        {
            get { return (bool)this.GetValue(Tab2_TabVisibleProperty); }
            set { this.SetValue(Tab2_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab2_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab2_AlarmProperty =
            DependencyProperty.Register("Tab2_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab2_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab2_Alarm
        {
            get { return (bool)this.GetValue(Tab2_AlarmProperty); }
            set { this.SetValue(Tab2_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab2_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab2_NameStoreProperty =
            DependencyProperty.Register("Tab2_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab2_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab2_NameStore
        {
            get { return (string)this.GetValue(Tab2_NameStoreProperty); }
            set { this.SetValue(Tab2_NameStoreProperty, value); }
        }

        /// <summary>
        /// Tab1_Selected Property
        /// </summary>
        public static readonly DependencyProperty Tab1_SelectedProperty =
            DependencyProperty.Register("Tab1_Selected", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab1_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Tab1_Selected
        {
            get { return (bool)this.GetValue(Tab1_SelectedProperty); }
            set { this.SetValue(Tab1_SelectedProperty, value); }
        }

        /// <summary>
        /// Tab1_TabName Property
        /// </summary>
        public static readonly DependencyProperty Tab1_TabNameProperty =
            DependencyProperty.Register("Tab1_TabName", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab1_TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string Tab1_TabName
        {
            get { return (string)this.GetValue(Tab1_TabNameProperty); }
            set { this.SetValue(Tab1_TabNameProperty, value); }
        }

        /// <summary>
        /// Tab1_TabVisible Property
        /// </summary>
        public static readonly DependencyProperty Tab1_TabVisibleProperty =
            DependencyProperty.Register("Tab1_TabVisible", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab1_TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab1_TabVisible
        {
            get { return (bool)this.GetValue(Tab1_TabVisibleProperty); }
            set { this.SetValue(Tab1_TabVisibleProperty, value); }
        }

        /// <summary>
        /// Tab1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Tab1_AlarmProperty =
            DependencyProperty.Register("Tab1_Alarm", typeof(bool), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Tab1_Alarm
        {
            get { return (bool)this.GetValue(Tab1_AlarmProperty); }
            set { this.SetValue(Tab1_AlarmProperty, value); }
        }

        /// <summary>
        /// Tab1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty Tab1_NameStoreProperty =
            DependencyProperty.Register("Tab1_NameStore", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the Tab1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string Tab1_NameStore
        {
            get { return (string)this.GetValue(Tab1_NameStoreProperty); }
            set { this.SetValue(Tab1_NameStoreProperty, value); }
        }

        /// <summary>
        /// NEXT_CMP Property
        /// </summary>
        public static readonly DependencyProperty NEXT_CMPProperty =
            DependencyProperty.Register("NEXT_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the NEXT_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_CMP
        {
            get { return (string)this.GetValue(NEXT_CMPProperty); }
            set { this.SetValue(NEXT_CMPProperty, value); }
        }

        /// <summary>
        /// NEXT_BLK Property
        /// </summary>
        public static readonly DependencyProperty NEXT_BLKProperty =
            DependencyProperty.Register("NEXT_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the NEXT_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_BLK
        {
            get { return (string)this.GetValue(NEXT_BLKProperty); }
            set { this.SetValue(NEXT_BLKProperty, value); }
        }

        /// <summary>
        /// NEXT_PAR Property
        /// </summary>
        public static readonly DependencyProperty NEXT_PARProperty =
            DependencyProperty.Register("NEXT_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the NEXT_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_PAR
        {
            get { return (string)this.GetValue(NEXT_PARProperty); }
            set { this.SetValue(NEXT_PARProperty, value); }
        }

        /// <summary>
        /// NEXT_DISABLE_CONN Property
        /// </summary>
        public static readonly DependencyProperty NEXT_DISABLE_CONNProperty =
            DependencyProperty.Register("NEXT_DISABLE_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the NEXT_DISABLE_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_DISABLE_CONN
        {
            get { return (string)this.GetValue(NEXT_DISABLE_CONNProperty); }
            set { this.SetValue(NEXT_DISABLE_CONNProperty, value); }
        }

        /// <summary>
        /// NEXT_STOP_CONN Property
        /// </summary>
        public static readonly DependencyProperty NEXT_STOP_CONNProperty =
            DependencyProperty.Register("NEXT_STOP_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the NEXT_STOP_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_STOP_CONN
        {
            get { return (string)this.GetValue(NEXT_STOP_CONNProperty); }
            set { this.SetValue(NEXT_STOP_CONNProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLK Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLK
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMP Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMP
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVLProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVLProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVLProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_PAROVLProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_PAROVL", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_PAROVL
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_PAROVLProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_PAROVLProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_PAROVL2Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_PAROVL2", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_PAROVL2
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_PAROVL2Property); }
            set { this.SetValue(AUTO_MAN_ACTION_PAROVL2Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_LOC Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_LOCProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_LOC", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_LOC
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_LOCProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_LOCProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_OVL Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_OVLProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_OVL", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_OVL
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_OVLProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_OVLProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_PRT Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_PRTProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_PRT", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_PRT
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_PRTProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_PRTProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVLProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVLProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVLProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVL2Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL2", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL2
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVL2Property); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVL2Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVL3Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL3", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL3
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVL3Property); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVL3Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVL4Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL4", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL4
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVL4Property); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVL4Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVL5Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL5", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL5
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVL5Property); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVL5Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_BLKOVL6Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_BLKOVL6", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_BLKOVL6
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_BLKOVL6Property); }
            set { this.SetValue(AUTO_MAN_ACTION_BLKOVL6Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVL2Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL2", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL2
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVL2Property); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVL2Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVL3Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL3", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL3
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVL3Property); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVL3Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVL4Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL4", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL4
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVL4Property); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVL4Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVL5Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL5", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL5
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVL5Property); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVL5Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_CMPOVL6Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_CMPOVL6", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_CMPOVL6
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_CMPOVL6Property); }
            set { this.SetValue(AUTO_MAN_ACTION_CMPOVL6Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_DSCRPProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_DSCRP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_DSCRP
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_DSCRPProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_DSCRPProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_LOOP_IDProperty =
            DependencyProperty.Register("AUTO_MAN_ACTION_LOOP_ID", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_LOOP_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_LOOP_ID
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_LOOP_IDProperty); }
            set { this.SetValue(AUTO_MAN_ACTION_LOOP_IDProperty, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_PAROVL3Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_PAROVL3", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_PAROVL3
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_PAROVL3Property); }
            set { this.SetValue(AUTO_MAN_ACTION_PAROVL3Property, value); }
        }

        /// <summary>
        /// AUTO_MAN_ACTION_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty AUTO_MAN_ACTION_PAROVL4Property =
            DependencyProperty.Register("AUTO_MAN_ACTION_PAROVL4", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the AUTO_MAN_ACTION_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string AUTO_MAN_ACTION_PAROVL4
        {
            get { return (string)this.GetValue(AUTO_MAN_ACTION_PAROVL4Property); }
            set { this.SetValue(AUTO_MAN_ACTION_PAROVL4Property, value); }
        }

        /// <summary>
        /// RESUME_CMP Property
        /// </summary>
        public static readonly DependencyProperty RESUME_CMPProperty =
            DependencyProperty.Register("RESUME_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_CMP
        {
            get { return (string)this.GetValue(RESUME_CMPProperty); }
            set { this.SetValue(RESUME_CMPProperty, value); }
        }

        /// <summary>
        /// RESUME_BLK Property
        /// </summary>
        public static readonly DependencyProperty RESUME_BLKProperty =
            DependencyProperty.Register("RESUME_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_BLK
        {
            get { return (string)this.GetValue(RESUME_BLKProperty); }
            set { this.SetValue(RESUME_BLKProperty, value); }
        }

        /// <summary>
        /// RESUME_DISABLE_CONN Property
        /// </summary>
        public static readonly DependencyProperty RESUME_DISABLE_CONNProperty =
            DependencyProperty.Register("RESUME_DISABLE_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_DISABLE_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_DISABLE_CONN
        {
            get { return (string)this.GetValue(RESUME_DISABLE_CONNProperty); }
            set { this.SetValue(RESUME_DISABLE_CONNProperty, value); }
        }

        /// <summary>
        /// RESUME_PAR Property
        /// </summary>
        public static readonly DependencyProperty RESUME_PARProperty =
            DependencyProperty.Register("RESUME_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_PAR
        {
            get { return (string)this.GetValue(RESUME_PARProperty); }
            set { this.SetValue(RESUME_PARProperty, value); }
        }

        /// <summary>
        /// RESUME_ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty RESUME_ALARM_CONNProperty =
            DependencyProperty.Register("RESUME_ALARM_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_ALARM_CONN
        {
            get { return (string)this.GetValue(RESUME_ALARM_CONNProperty); }
            set { this.SetValue(RESUME_ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// RESUME_MSG Property
        /// </summary>
        public static readonly DependencyProperty RESUME_MSGProperty =
            DependencyProperty.Register("RESUME_MSG", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the RESUME_MSG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RESUME_MSG
        {
            get { return (string)this.GetValue(RESUME_MSGProperty); }
            set { this.SetValue(RESUME_MSGProperty, value); }
        }

        /// <summary>
        /// HOLD_CMP Property
        /// </summary>
        public static readonly DependencyProperty HOLD_CMPProperty =
            DependencyProperty.Register("HOLD_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the HOLD_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HOLD_CMP
        {
            get { return (string)this.GetValue(HOLD_CMPProperty); }
            set { this.SetValue(HOLD_CMPProperty, value); }
        }

        /// <summary>
        /// HOLD_BLK Property
        /// </summary>
        public static readonly DependencyProperty HOLD_BLKProperty =
            DependencyProperty.Register("HOLD_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the HOLD_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HOLD_BLK
        {
            get { return (string)this.GetValue(HOLD_BLKProperty); }
            set { this.SetValue(HOLD_BLKProperty, value); }
        }

        /// <summary>
        /// HOLD_PAR Property
        /// </summary>
        public static readonly DependencyProperty HOLD_PARProperty =
            DependencyProperty.Register("HOLD_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the HOLD_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HOLD_PAR
        {
            get { return (string)this.GetValue(HOLD_PARProperty); }
            set { this.SetValue(HOLD_PARProperty, value); }
        }

        /// <summary>
        /// HOLD_ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty HOLD_ALARM_CONNProperty =
            DependencyProperty.Register("HOLD_ALARM_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the HOLD_ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HOLD_ALARM_CONN
        {
            get { return (string)this.GetValue(HOLD_ALARM_CONNProperty); }
            set { this.SetValue(HOLD_ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// HOLD_MSG Property
        /// </summary>
        public static readonly DependencyProperty HOLD_MSGProperty =
            DependencyProperty.Register("HOLD_MSG", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the HOLD_MSG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HOLD_MSG
        {
            get { return (string)this.GetValue(HOLD_MSGProperty); }
            set { this.SetValue(HOLD_MSGProperty, value); }
        }

        /// <summary>
        /// START_CMP Property
        /// </summary>
        public static readonly DependencyProperty START_CMPProperty =
            DependencyProperty.Register("START_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START_CMP
        {
            get { return (string)this.GetValue(START_CMPProperty); }
            set { this.SetValue(START_CMPProperty, value); }
        }

        /// <summary>
        /// START_BLK Property
        /// </summary>
        public static readonly DependencyProperty START_BLKProperty =
            DependencyProperty.Register("START_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START_BLK
        {
            get { return (string)this.GetValue(START_BLKProperty); }
            set { this.SetValue(START_BLKProperty, value); }
        }

        /// <summary>
        /// START_ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty START_ALARM_CONNProperty =
            DependencyProperty.Register("START_ALARM_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START_ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START_ALARM_CONN
        {
            get { return (string)this.GetValue(START_ALARM_CONNProperty); }
            set { this.SetValue(START_ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// START_PAR Property
        /// </summary>
        public static readonly DependencyProperty START_PARProperty =
            DependencyProperty.Register("START_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START_PAR
        {
            get { return (string)this.GetValue(START_PARProperty); }
            set { this.SetValue(START_PARProperty, value); }
        }

        /// <summary>
        /// START_MSG Property
        /// </summary>
        public static readonly DependencyProperty START_MSGProperty =
            DependencyProperty.Register("START_MSG", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the START_MSG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string START_MSG
        {
            get { return (string)this.GetValue(START_MSGProperty); }
            set { this.SetValue(START_MSGProperty, value); }
        }

        /// <summary>
        /// TIMER_ADSORB_CMP Property
        /// </summary>
        public static readonly DependencyProperty TIMER_ADSORB_CMPProperty =
            DependencyProperty.Register("TIMER_ADSORB_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_ADSORB_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_ADSORB_CMP
        {
            get { return (string)this.GetValue(TIMER_ADSORB_CMPProperty); }
            set { this.SetValue(TIMER_ADSORB_CMPProperty, value); }
        }

        /// <summary>
        /// TIMER_ADSORB_PAR Property
        /// </summary>
        public static readonly DependencyProperty TIMER_ADSORB_PARProperty =
            DependencyProperty.Register("TIMER_ADSORB_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_ADSORB_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_ADSORB_PAR
        {
            get { return (string)this.GetValue(TIMER_ADSORB_PARProperty); }
            set { this.SetValue(TIMER_ADSORB_PARProperty, value); }
        }

        /// <summary>
        /// TIMER_ADSORB_BLK Property
        /// </summary>
        public static readonly DependencyProperty TIMER_ADSORB_BLKProperty =
            DependencyProperty.Register("TIMER_ADSORB_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_ADSORB_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_ADSORB_BLK
        {
            get { return (string)this.GetValue(TIMER_ADSORB_BLKProperty); }
            set { this.SetValue(TIMER_ADSORB_BLKProperty, value); }
        }

        /// <summary>
        /// TIMER_REGEN_CMP Property
        /// </summary>
        public static readonly DependencyProperty TIMER_REGEN_CMPProperty =
            DependencyProperty.Register("TIMER_REGEN_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_REGEN_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_REGEN_CMP
        {
            get { return (string)this.GetValue(TIMER_REGEN_CMPProperty); }
            set { this.SetValue(TIMER_REGEN_CMPProperty, value); }
        }

        /// <summary>
        /// TIMER_REGEN_PAR Property
        /// </summary>
        public static readonly DependencyProperty TIMER_REGEN_PARProperty =
            DependencyProperty.Register("TIMER_REGEN_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_REGEN_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_REGEN_PAR
        {
            get { return (string)this.GetValue(TIMER_REGEN_PARProperty); }
            set { this.SetValue(TIMER_REGEN_PARProperty, value); }
        }

        /// <summary>
        /// TIMER_REGEN_BLK Property
        /// </summary>
        public static readonly DependencyProperty TIMER_REGEN_BLKProperty =
            DependencyProperty.Register("TIMER_REGEN_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the TIMER_REGEN_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER_REGEN_BLK
        {
            get { return (string)this.GetValue(TIMER_REGEN_BLKProperty); }
            set { this.SetValue(TIMER_REGEN_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol3_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol3_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol3_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol3_BLKProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_ALARM_CONNProperty =
            DependencyProperty.Register("EmbeddedSymbol3_ALARM_CONN", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_ALARM_CONN
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_ALARM_CONNProperty); }
            set { this.SetValue(EmbeddedSymbol3_ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol3_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_PARProperty); }
            set { this.SetValue(EmbeddedSymbol3_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol3_MSG Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol3_MSGProperty =
            DependencyProperty.Register("EmbeddedSymbol3_MSG", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol3_MSG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol3_MSG
        {
            get { return (string)this.GetValue(EmbeddedSymbol3_MSGProperty); }
            set { this.SetValue(EmbeddedSymbol3_MSGProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol193_CMP Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol193_CMPProperty =
            DependencyProperty.Register("EmbeddedSymbol193_CMP", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol193_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol193_CMP
        {
            get { return (string)this.GetValue(EmbeddedSymbol193_CMPProperty); }
            set { this.SetValue(EmbeddedSymbol193_CMPProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol193_PAR Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol193_PARProperty =
            DependencyProperty.Register("EmbeddedSymbol193_PAR", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol193_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol193_PAR
        {
            get { return (string)this.GetValue(EmbeddedSymbol193_PARProperty); }
            set { this.SetValue(EmbeddedSymbol193_PARProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol193_BLK Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol193_BLKProperty =
            DependencyProperty.Register("EmbeddedSymbol193_BLK", typeof(string), typeof(SYM_SEQ_GRID_01));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol193_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol193_BLK
        {
            get { return (string)this.GetValue(EmbeddedSymbol193_BLKProperty); }
            set { this.SetValue(EmbeddedSymbol193_BLKProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
                if (!string.IsNullOrWhiteSpace(this.BLK_REGEN)) yield return new Param("$BLK_REGEN", this.BLK_REGEN);
                if (!string.IsNullOrWhiteSpace(this.PAR_REGEN)) yield return new Param("$PAR_REGEN", this.PAR_REGEN);
                if (!string.IsNullOrWhiteSpace(this.BLK_ADSORB)) yield return new Param("$BLK_ADSORB", this.BLK_ADSORB);
                if (!string.IsNullOrWhiteSpace(this.PAR_ADSORB)) yield return new Param("$PAR_ADSORB", this.PAR_ADSORB);

            }
        }


    }
}
