using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using System.ComponentModel.Composition;
using RSI.Common.Locator;
using RSI.IndissLike.Controls.Helpers;
using RSI.IndissPlus.Plots.Components;
using RSI.Common.WPFTools.Extensions;
using RSI.IndissPlus.Plots.OxyPlotTools;
using PlotComponent.Interfaces;

namespace UGP_EDRF.HMI
{
	[Export("DECOUPLE_0003B")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class DECOUPLE_0003B
    {
        public DECOUPLE_0003B()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += DECOUPLE_0003B_Loaded;
            this.InitializeComponent();
        }

        private void DECOUPLE_0003B_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {


            TargetSrgVlvDmdK0003B.ShowAxis = false;
            ActualSrgVlvDmdK0003B.ShowAxis = false;
            TargetStvVlvDmdK0003B.ShowAxis = false;
            ActualStvVlvDmdK0003B.ShowAxis = false;

            DynamicBreakPointLineK0003B.ShowAxis = false;
            SurgeVlvLinePlotK0003B.ShowAxis = false;
            STVSetpointLinK0003B.ShowAxis = false;



        }



        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(DECOUPLE_0003B));

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
        /// dIndDesLab_01_M1_Value Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M1_ValueProperty =
            DependencyProperty.Register("dIndDesLab_01_M1_Value", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool dIndDesLab_01_M1_Value
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M1_ValueProperty); }
            set { this.SetValue(dIndDesLab_01_M1_ValueProperty, value); }
        }

        /// <summary>
        /// dIndDesLab_01_M1_Blink Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M1_BlinkProperty =
            DependencyProperty.Register("dIndDesLab_01_M1_Blink", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M1_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool dIndDesLab_01_M1_Blink
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M1_BlinkProperty); }
            set { this.SetValue(dIndDesLab_01_M1_BlinkProperty, value); }
        }

        /// <summary>
        /// dIndDesLab_01_M2_Blink Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M2_BlinkProperty =
            DependencyProperty.Register("dIndDesLab_01_M2_Blink", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M2_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool dIndDesLab_01_M2_Blink
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M2_BlinkProperty); }
            set { this.SetValue(dIndDesLab_01_M2_BlinkProperty, value); }
        }

        /// <summary>
        /// dIndDesLab_01_M2_Value Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M2_ValueProperty =
            DependencyProperty.Register("dIndDesLab_01_M2_Value", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M2_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool dIndDesLab_01_M2_Value
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M2_ValueProperty); }
            set { this.SetValue(dIndDesLab_01_M2_ValueProperty, value); }
        }

        /// <summary>
        /// dIndDesLab_01_M3_Blink Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M3_BlinkProperty =
            DependencyProperty.Register("dIndDesLab_01_M3_Blink", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M3_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool dIndDesLab_01_M3_Blink
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M3_BlinkProperty); }
            set { this.SetValue(dIndDesLab_01_M3_BlinkProperty, value); }
        }

        /// <summary>
        /// dIndDesLab_01_M3_Value Property
        /// </summary>
        public static readonly DependencyProperty dIndDesLab_01_M3_ValueProperty =
            DependencyProperty.Register("dIndDesLab_01_M3_Value", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the dIndDesLab_01_M3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool dIndDesLab_01_M3_Value
        {
            get { return (bool)this.GetValue(dIndDesLab_01_M3_ValueProperty); }
            set { this.SetValue(dIndDesLab_01_M3_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M1_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M1_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M1_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M1_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M1_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M1_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M1_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M1_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M1_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M1_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M1_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M1_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M1_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M1_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M1_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M1_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M1_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M1_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M2_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M2_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M2_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M2_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M2_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M2_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M2_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M2_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M2_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M2_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M2_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M2_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M2_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M2_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M2_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M2_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M2_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M2_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M2_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M2_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M2_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M3_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M3_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M3_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M3_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M3_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M3_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M3_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M3_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M3_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M3_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M3_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M3_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M3_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M3_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M3_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M3_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M3_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M3_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M3_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M3_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M4_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M4_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M4_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M4_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M4_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M4_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M4_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M4_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M4_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M4_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M4_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M4_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M4_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M4_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M4_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M4_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M4_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M4_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M4_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M4_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M4_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M5_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M5_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M5_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M5_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M5_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M5_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M5_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M5_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M5_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M5_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M5_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M5_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M5_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M5_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M5_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M5_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M5_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M5_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M5_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M5_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M5_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M6_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M6_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M6_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M6_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M6_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M6_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M6_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M6_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M6_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M6_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M6_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M6_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M6_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M6_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M6_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M6_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M6_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M6_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M6_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M6_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M6_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M7_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M7_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M7_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M7_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M7_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M7_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M7_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M7_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M7_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M7_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M7_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M7_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M7_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M7_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M7_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M7_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M7_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M7_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M7_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M7_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M7_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M8_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M8_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M8_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M8_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M8_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M8_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M8_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M8_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M8_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M8_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M8_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M8_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M8_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M8_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M8_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M8_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M8_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M8_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M8_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M8_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M8_SelectedProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M9_Value Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M9_ValueProperty =
            DependencyProperty.Register("aIndDesLab_01_M9_Value", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M9_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double aIndDesLab_01_M9_Value
        {
            get { return (double)this.GetValue(aIndDesLab_01_M9_ValueProperty); }
            set { this.SetValue(aIndDesLab_01_M9_ValueProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M9_Alarm Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M9_AlarmProperty =
            DependencyProperty.Register("aIndDesLab_01_M9_Alarm", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M9_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool aIndDesLab_01_M9_Alarm
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M9_AlarmProperty); }
            set { this.SetValue(aIndDesLab_01_M9_AlarmProperty, value); }
        }

        /// <summary>
        /// aIndDesLab_01_M9_Selected Property
        /// </summary>
        public static readonly DependencyProperty aIndDesLab_01_M9_SelectedProperty =
            DependencyProperty.Register("aIndDesLab_01_M9_Selected", typeof(bool), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the aIndDesLab_01_M9_Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool aIndDesLab_01_M9_Selected
        {
            get { return (bool)this.GetValue(aIndDesLab_01_M9_SelectedProperty); }
            set { this.SetValue(aIndDesLab_01_M9_SelectedProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_ProcOP Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_ProcOPProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_ProcOP", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_ProcOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of the process controller output.  This is the tagname that goes into the demand of the decoupler block.")]
        public double DECOUP_DIS_III1_ProcOP
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_ProcOPProperty); }
            set { this.SetValue(DECOUP_DIS_III1_ProcOPProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_VPoint Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_VPointProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_VPoint", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_VPoint.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the decoupler surge valve/process control V point (typically kDCPL_V_POINT).")]
        public double DECOUP_DIS_III1_VPoint
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_VPointProperty); }
            set { this.SetValue(DECOUP_DIS_III1_VPointProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_DynBP Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_DynBPProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_DynBP", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_DynBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupler dynamic breakpoint (typically rDCPL_DYN_BKPT).")]
        public double DECOUP_DIS_III1_DynBP
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_DynBPProperty); }
            set { this.SetValue(DECOUP_DIS_III1_DynBPProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_ASV Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_ASVProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_ASV", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_ASV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the anti-surge valve demand. ")]
        public double DECOUP_DIS_III1_ASV
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_ASVProperty); }
            set { this.SetValue(DECOUP_DIS_III1_ASVProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_PerfTrk Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_PerfTrkProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_PerfTrk", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_PerfTrk.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of the performance controller tracking value.  It needs to be scaled 0 to 100%.  This is the same tagname that goes to the Process_Trk in the decoupler block.")]
        public double DECOUP_DIS_III1_PerfTrk
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_PerfTrkProperty); }
            set { this.SetValue(DECOUP_DIS_III1_PerfTrkProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_PerfDcpl Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_PerfDcplProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_PerfDcpl", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_PerfDcpl.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupling demand to the performance controller (typically rDCPL_PROC_OP)")]
        public double DECOUP_DIS_III1_PerfDcpl
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_PerfDcplProperty); }
            set { this.SetValue(DECOUP_DIS_III1_PerfDcplProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_ASVDcpl Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_ASVDcplProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_ASVDcpl", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_ASVDcpl.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupling demand to the anti-surge controller (typically rDCPL_SRG_OP)")]
        public double DECOUP_DIS_III1_ASVDcpl
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_ASVDcplProperty); }
            set { this.SetValue(DECOUP_DIS_III1_ASVDcplProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_PerfMax Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_PerfMaxProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_PerfMax", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_PerfMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the value (motor) or tagname (turbine) for the maximum performance controller on the decoupler. (100 for motor, kMAXGOV for turbine)")]
        public double DECOUP_DIS_III1_PerfMax
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_PerfMaxProperty); }
            set { this.SetValue(DECOUP_DIS_III1_PerfMaxProperty, value); }
        }

        /// <summary>
        /// DECOUP_DIS_III1_PerfMin Property
        /// </summary>
        public static readonly DependencyProperty DECOUP_DIS_III1_PerfMinProperty =
            DependencyProperty.Register("DECOUP_DIS_III1_PerfMin", typeof(double), typeof(DECOUPLE_0003B));

        /// <summary>
        /// Gets or sets the DECOUP_DIS_III1_PerfMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the value (motor) or tagname (turbine) for the minimum performance controller on the decoupler. (100 for motor, kMINGOV for turbine)")]
        public double DECOUP_DIS_III1_PerfMin
        {
            get { return (double)this.GetValue(DECOUP_DIS_III1_PerfMinProperty); }
            set { this.SetValue(DECOUP_DIS_III1_PerfMinProperty, value); }
        }


		
    }
}
