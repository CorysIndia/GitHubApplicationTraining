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
    public class SYM_FP_LEVEL_IND_01 : RSIControlModel
    {
        static SYM_FP_LEVEL_IND_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_FP_LEVEL_IND_01), new FrameworkPropertyMetadata(typeof(SYM_FP_LEVEL_IND_01)));
        }

		public SYM_FP_LEVEL_IND_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_FP_LEVEL_IND_01));

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
        /// PV Property
        /// </summary>
        public static readonly DependencyProperty PVProperty =
            DependencyProperty.Register("PV", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV
        {
            get { return (double)this.GetValue(PVProperty); }
            set { this.SetValue(PVProperty, value); }
        }

        /// <summary>
        /// PvRangeFullScaleMax Property
        /// </summary>
        public static readonly DependencyProperty PvRangeFullScaleMaxProperty =
            DependencyProperty.Register("PvRangeFullScaleMax", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the PvRangeFullScaleMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PvRangeFullScaleMax
        {
            get { return (double)this.GetValue(PvRangeFullScaleMaxProperty); }
            set { this.SetValue(PvRangeFullScaleMaxProperty, value); }
        }

        /// <summary>
        /// PVRangeFullScaleMin Property
        /// </summary>
        public static readonly DependencyProperty PVRangeFullScaleMinProperty =
            DependencyProperty.Register("PVRangeFullScaleMin", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the PVRangeFullScaleMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PVRangeFullScaleMin
        {
            get { return (double)this.GetValue(PVRangeFullScaleMinProperty); }
            set { this.SetValue(PVRangeFullScaleMinProperty, value); }
        }

        /// <summary>
        /// AlarmIndicatorVisible Property
        /// </summary>
        public static readonly DependencyProperty AlarmIndicatorVisibleProperty =
            DependencyProperty.Register("AlarmIndicatorVisible", typeof(bool), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmIndicatorVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AlarmIndicatorVisible
        {
            get { return (bool)this.GetValue(AlarmIndicatorVisibleProperty); }
            set { this.SetValue(AlarmIndicatorVisibleProperty, value); }
        }

        /// <summary>
        /// AlarmMostUrgentInAlarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmMostUrgentInAlarmProperty =
            DependencyProperty.Register("AlarmMostUrgentInAlarm", typeof(bool), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmMostUrgentInAlarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AlarmMostUrgentInAlarm
        {
            get { return (bool)this.GetValue(AlarmMostUrgentInAlarmProperty); }
            set { this.SetValue(AlarmMostUrgentInAlarmProperty, value); }
        }

        /// <summary>
        /// AlarmMostUrgentAcked Property
        /// </summary>
        public static readonly DependencyProperty AlarmMostUrgentAckedProperty =
            DependencyProperty.Register("AlarmMostUrgentAcked", typeof(bool), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmMostUrgentAcked.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AlarmMostUrgentAcked
        {
            get { return (bool)this.GetValue(AlarmMostUrgentAckedProperty); }
            set { this.SetValue(AlarmMostUrgentAckedProperty, value); }
        }

        /// <summary>
        /// AlarmMostUrgentMode Property
        /// </summary>
        public static readonly DependencyProperty AlarmMostUrgentModeProperty =
            DependencyProperty.Register("AlarmMostUrgentMode", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmMostUrgentMode.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int AlarmMostUrgentMode
        {
            get { return (int)this.GetValue(AlarmMostUrgentModeProperty); }
            set { this.SetValue(AlarmMostUrgentModeProperty, value); }
        }

        /// <summary>
        /// AlarmMostUrgentSeverity Property
        /// </summary>
        public static readonly DependencyProperty AlarmMostUrgentSeverityProperty =
            DependencyProperty.Register("AlarmMostUrgentSeverity", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmMostUrgentSeverity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int AlarmMostUrgentSeverity
        {
            get { return (int)this.GetValue(AlarmMostUrgentSeverityProperty); }
            set { this.SetValue(AlarmMostUrgentSeverityProperty, value); }
        }

        /// <summary>
        /// ShowInhibState Property
        /// </summary>
        public static readonly DependencyProperty ShowInhibStateProperty =
            DependencyProperty.Register("ShowInhibState", typeof(bool), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the ShowInhibState.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ShowInhibState
        {
            get { return (bool)this.GetValue(ShowInhibStateProperty); }
            set { this.SetValue(ShowInhibStateProperty, value); }
        }

        /// <summary>
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CRIT
        {
            get { return (int)this.GetValue(CRITProperty); }
            set { this.SetValue(CRITProperty, value); }
        }

        /// <summary>
        /// INHOPT Property
        /// </summary>
        public static readonly DependencyProperty INHOPTProperty =
            DependencyProperty.Register("INHOPT", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INHOPT
        {
            get { return (int)this.GetValue(INHOPTProperty); }
            set { this.SetValue(INHOPTProperty, value); }
        }

        /// <summary>
        /// INHSTA Property
        /// </summary>
        public static readonly DependencyProperty INHSTAProperty =
            DependencyProperty.Register("INHSTA", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the INHSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INHSTA
        {
            get { return (int)this.GetValue(INHSTAProperty); }
            set { this.SetValue(INHSTAProperty, value); }
        }

        /// <summary>
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRTYPE
        {
            get { return (int)this.GetValue(PRTYPEProperty); }
            set { this.SetValue(PRTYPEProperty, value); }
        }

        /// <summary>
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK
        {
            get { return (bool)this.GetValue(UNACKProperty); }
            set { this.SetValue(UNACKProperty, value); }
        }

        /// <summary>
        /// AlarmStateChanged Property
        /// </summary>
        public static readonly DependencyProperty AlarmStateChangedProperty =
            DependencyProperty.Register("AlarmStateChanged", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the AlarmStateChanged.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int AlarmStateChanged
        {
            get { return (int)this.GetValue(AlarmStateChangedProperty); }
            set { this.SetValue(AlarmStateChangedProperty, value); }
        }

        /// <summary>
        /// RO01 Property
        /// </summary>
        public static readonly DependencyProperty RO01Property =
            DependencyProperty.Register("RO01", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the RO01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO01
        {
            get { return (double)this.GetValue(RO01Property); }
            set { this.SetValue(RO01Property, value); }
        }

        /// <summary>
        /// RO02 Property
        /// </summary>
        public static readonly DependencyProperty RO02Property =
            DependencyProperty.Register("RO02", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the RO02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO02
        {
            get { return (double)this.GetValue(RO02Property); }
            set { this.SetValue(RO02Property, value); }
        }

        /// <summary>
        /// RO03 Property
        /// </summary>
        public static readonly DependencyProperty RO03Property =
            DependencyProperty.Register("RO03", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the RO03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO03
        {
            get { return (double)this.GetValue(RO03Property); }
            set { this.SetValue(RO03Property, value); }
        }

        /// <summary>
        /// RO04 Property
        /// </summary>
        public static readonly DependencyProperty RO04Property =
            DependencyProperty.Register("RO04", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the RO04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double RO04
        {
            get { return (double)this.GetValue(RO04Property); }
            set { this.SetValue(RO04Property, value); }
        }

        /// <summary>
        /// CB Property
        /// </summary>
        public static readonly DependencyProperty CBProperty =
            DependencyProperty.Register("CB", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB
        {
            get { return (string)this.GetValue(CBProperty); }
            set { this.SetValue(CBProperty, value); }
        }

        /// <summary>
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the HSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO1
        {
            get { return (double)this.GetValue(HSCO1Property); }
            set { this.SetValue(HSCO1Property, value); }
        }

        /// <summary>
        /// HSCO2 Property
        /// </summary>
        public static readonly DependencyProperty HSCO2Property =
            DependencyProperty.Register("HSCO2", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the HSCO2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO2
        {
            get { return (double)this.GetValue(HSCO2Property); }
            set { this.SetValue(HSCO2Property, value); }
        }

        /// <summary>
        /// HSCO3 Property
        /// </summary>
        public static readonly DependencyProperty HSCO3Property =
            DependencyProperty.Register("HSCO3", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the HSCO3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO3
        {
            get { return (double)this.GetValue(HSCO3Property); }
            set { this.SetValue(HSCO3Property, value); }
        }

        /// <summary>
        /// HSCO4 Property
        /// </summary>
        public static readonly DependencyProperty HSCO4Property =
            DependencyProperty.Register("HSCO4", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the HSCO4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO4
        {
            get { return (double)this.GetValue(HSCO4Property); }
            set { this.SetValue(HSCO4Property, value); }
        }

        /// <summary>
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the LSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO1
        {
            get { return (double)this.GetValue(LSCO1Property); }
            set { this.SetValue(LSCO1Property, value); }
        }

        /// <summary>
        /// LSCO2 Property
        /// </summary>
        public static readonly DependencyProperty LSCO2Property =
            DependencyProperty.Register("LSCO2", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the LSCO2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO2
        {
            get { return (double)this.GetValue(LSCO2Property); }
            set { this.SetValue(LSCO2Property, value); }
        }

        /// <summary>
        /// LSCO3 Property
        /// </summary>
        public static readonly DependencyProperty LSCO3Property =
            DependencyProperty.Register("LSCO3", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the LSCO3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO3
        {
            get { return (double)this.GetValue(LSCO3Property); }
            set { this.SetValue(LSCO3Property, value); }
        }

        /// <summary>
        /// LSCO4 Property
        /// </summary>
        public static readonly DependencyProperty LSCO4Property =
            DependencyProperty.Register("LSCO4", typeof(double), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the LSCO4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO4
        {
            get { return (double)this.GetValue(LSCO4Property); }
            set { this.SetValue(LSCO4Property, value); }
        }

        /// <summary>
        /// Show_Min_Max Property
        /// </summary>
        public static readonly DependencyProperty Show_Min_MaxProperty =
            DependencyProperty.Register("Show_Min_Max", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the Show_Min_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Show_Min_Max
        {
            get { return (string)this.GetValue(Show_Min_MaxProperty); }
            set { this.SetValue(Show_Min_MaxProperty, value); }
        }

        /// <summary>
        /// Min_Max_Location Property
        /// </summary>
        public static readonly DependencyProperty Min_Max_LocationProperty =
            DependencyProperty.Register("Min_Max_Location", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the Min_Max_Location.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Min_Max_Location
        {
            get { return (string)this.GetValue(Min_Max_LocationProperty); }
            set { this.SetValue(Min_Max_LocationProperty, value); }
        }

        /// <summary>
        /// Show_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Show_AlarmProperty =
            DependencyProperty.Register("Show_Alarm", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the Show_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Show_Alarm
        {
            get { return (string)this.GetValue(Show_AlarmProperty); }
            set { this.SetValue(Show_AlarmProperty, value); }
        }

        /// <summary>
        /// OptimalRange Property
        /// </summary>
        public static readonly DependencyProperty OptimalRangeProperty =
            DependencyProperty.Register("OptimalRange", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the OptimalRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OptimalRange
        {
            get { return (string)this.GetValue(OptimalRangeProperty); }
            set { this.SetValue(OptimalRangeProperty, value); }
        }

        /// <summary>
        /// BAR_TYPE Property
        /// </summary>
        public static readonly DependencyProperty BAR_TYPEProperty =
            DependencyProperty.Register("BAR_TYPE", typeof(string), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the BAR_TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BAR_TYPE
        {
            get { return (string)this.GetValue(BAR_TYPEProperty); }
            set { this.SetValue(BAR_TYPEProperty, value); }
        }

        /// <summary>
        /// ALARMBORDER_01__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty ALARMBORDER_01__CONN1Property =
            DependencyProperty.Register("ALARMBORDER_01__CONN1", typeof(int), typeof(SYM_FP_LEVEL_IND_01));

        /// <summary>
        /// Gets or sets the ALARMBORDER_01__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARMBORDER_01__CONN1
        {
            get { return (int)this.GetValue(ALARMBORDER_01__CONN1Property); }
            set { this.SetValue(ALARMBORDER_01__CONN1Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CB)) yield return new Param("$CB", this.CB);

            }
        }

		
    }
}
