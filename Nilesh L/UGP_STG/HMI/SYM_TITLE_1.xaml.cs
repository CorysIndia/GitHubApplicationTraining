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
    public class SYM_TITLE_1 : RSIControlModel
    {
        static SYM_TITLE_1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_TITLE_1), new FrameworkPropertyMetadata(typeof(SYM_TITLE_1)));
        }

		public SYM_TITLE_1()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_TITLE_1));

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
        /// ACKPAGE Property
        /// </summary>
        public static readonly DependencyProperty ACKPAGEProperty =
            DependencyProperty.Register("ACKPAGE", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the ACKPAGE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ACKPAGE
        {
            get { return (bool)this.GetValue(ACKPAGEProperty); }
            set { this.SetValue(ACKPAGEProperty, value); }
        }

        /// <summary>
        /// DisplayTitle Property
        /// </summary>
        public static readonly DependencyProperty DisplayTitleProperty =
            DependencyProperty.Register("DisplayTitle", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the DisplayTitle.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DisplayTitle
        {
            get { return (string)this.GetValue(DisplayTitleProperty); }
            set { this.SetValue(DisplayTitleProperty, value); }
        }

        /// <summary>
        /// PreviousDisplay Property
        /// </summary>
        public static readonly DependencyProperty PreviousDisplayProperty =
            DependencyProperty.Register("PreviousDisplay", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the PreviousDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PreviousDisplay
        {
            get { return (string)this.GetValue(PreviousDisplayProperty); }
            set { this.SetValue(PreviousDisplayProperty, value); }
        }

        /// <summary>
        /// NextDisplay Property
        /// </summary>
        public static readonly DependencyProperty NextDisplayProperty =
            DependencyProperty.Register("NextDisplay", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NextDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NextDisplay
        {
            get { return (string)this.GetValue(NextDisplayProperty); }
            set { this.SetValue(NextDisplayProperty, value); }
        }

        /// <summary>
        /// OverviewDisplay Property
        /// </summary>
        public static readonly DependencyProperty OverviewDisplayProperty =
            DependencyProperty.Register("OverviewDisplay", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the OverviewDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OverviewDisplay
        {
            get { return (string)this.GetValue(OverviewDisplayProperty); }
            set { this.SetValue(OverviewDisplayProperty, value); }
        }

        /// <summary>
        /// DispName Property
        /// </summary>
        public static readonly DependencyProperty DispNameProperty =
            DependencyProperty.Register("DispName", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the DispName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DispName
        {
            get { return (string)this.GetValue(DispNameProperty); }
            set { this.SetValue(DispNameProperty, value); }
        }

        /// <summary>
        /// ACK_PRT Property
        /// </summary>
        public static readonly DependencyProperty ACK_PRTProperty =
            DependencyProperty.Register("ACK_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the ACK_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ACK_PRT
        {
            get { return (int)this.GetValue(ACK_PRTProperty); }
            set { this.SetValue(ACK_PRTProperty, value); }
        }

        /// <summary>
        /// BP_CBP Property
        /// </summary>
        public static readonly DependencyProperty BP_CBPProperty =
            DependencyProperty.Register("BP_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP_CBP
        {
            get { return (string)this.GetValue(BP_CBPProperty); }
            set { this.SetValue(BP_CBPProperty, value); }
        }

        /// <summary>
        /// HH_H2S_CBP Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S_CBPProperty =
            DependencyProperty.Register("HH_H2S_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_H2S_CBP
        {
            get { return (string)this.GetValue(HH_H2S_CBPProperty); }
            set { this.SetValue(HH_H2S_CBPProperty, value); }
        }

        /// <summary>
        /// BP_CONN Property
        /// </summary>
        public static readonly DependencyProperty BP_CONNProperty =
            DependencyProperty.Register("BP_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP_CONN
        {
            get { return (bool)this.GetValue(BP_CONNProperty); }
            set { this.SetValue(BP_CONNProperty, value); }
        }

        /// <summary>
        /// BP_OVL Property
        /// </summary>
        public static readonly DependencyProperty BP_OVLProperty =
            DependencyProperty.Register("BP_OVL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP_OVL
        {
            get { return (string)this.GetValue(BP_OVLProperty); }
            set { this.SetValue(BP_OVLProperty, value); }
        }

        /// <summary>
        /// BP_PRT Property
        /// </summary>
        public static readonly DependencyProperty BP_PRTProperty =
            DependencyProperty.Register("BP_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int BP_PRT
        {
            get { return (int)this.GetValue(BP_PRTProperty); }
            set { this.SetValue(BP_PRTProperty, value); }
        }

        /// <summary>
        /// HH_H2S_CONN Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S_CONNProperty =
            DependencyProperty.Register("HH_H2S_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HH_H2S_CONN
        {
            get { return (bool)this.GetValue(HH_H2S_CONNProperty); }
            set { this.SetValue(HH_H2S_CONNProperty, value); }
        }

        /// <summary>
        /// HH_H2S_OVL Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S_OVLProperty =
            DependencyProperty.Register("HH_H2S_OVL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_H2S_OVL
        {
            get { return (string)this.GetValue(HH_H2S_OVLProperty); }
            set { this.SetValue(HH_H2S_OVLProperty, value); }
        }

        /// <summary>
        /// HH_H2S_PRT Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S_PRTProperty =
            DependencyProperty.Register("HH_H2S_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HH_H2S_PRT
        {
            get { return (int)this.GetValue(HH_H2S_PRTProperty); }
            set { this.SetValue(HH_H2S_PRTProperty, value); }
        }

        /// <summary>
        /// H_H2S_CBP Property
        /// </summary>
        public static readonly DependencyProperty H_H2S_CBPProperty =
            DependencyProperty.Register("H_H2S_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_H2S_CBP
        {
            get { return (string)this.GetValue(H_H2S_CBPProperty); }
            set { this.SetValue(H_H2S_CBPProperty, value); }
        }

        /// <summary>
        /// H_H2S_OVL Property
        /// </summary>
        public static readonly DependencyProperty H_H2S_OVLProperty =
            DependencyProperty.Register("H_H2S_OVL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_H2S_OVL
        {
            get { return (string)this.GetValue(H_H2S_OVLProperty); }
            set { this.SetValue(H_H2S_OVLProperty, value); }
        }

        /// <summary>
        /// H_H2S_PRT Property
        /// </summary>
        public static readonly DependencyProperty H_H2S_PRTProperty =
            DependencyProperty.Register("H_H2S_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int H_H2S_PRT
        {
            get { return (int)this.GetValue(H_H2S_PRTProperty); }
            set { this.SetValue(H_H2S_PRTProperty, value); }
        }

        /// <summary>
        /// H_H2S_CONN Property
        /// </summary>
        public static readonly DependencyProperty H_H2S_CONNProperty =
            DependencyProperty.Register("H_H2S_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool H_H2S_CONN
        {
            get { return (bool)this.GetValue(H_H2S_CONNProperty); }
            set { this.SetValue(H_H2S_CONNProperty, value); }
        }

        /// <summary>
        /// H_LEL_CBP Property
        /// </summary>
        public static readonly DependencyProperty H_LEL_CBPProperty =
            DependencyProperty.Register("H_LEL_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_LEL_CBP
        {
            get { return (string)this.GetValue(H_LEL_CBPProperty); }
            set { this.SetValue(H_LEL_CBPProperty, value); }
        }

        /// <summary>
        /// H_LEL_CONN Property
        /// </summary>
        public static readonly DependencyProperty H_LEL_CONNProperty =
            DependencyProperty.Register("H_LEL_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool H_LEL_CONN
        {
            get { return (bool)this.GetValue(H_LEL_CONNProperty); }
            set { this.SetValue(H_LEL_CONNProperty, value); }
        }

        /// <summary>
        /// H_LEL_OVL Property
        /// </summary>
        public static readonly DependencyProperty H_LEL_OVLProperty =
            DependencyProperty.Register("H_LEL_OVL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_LEL_OVL
        {
            get { return (string)this.GetValue(H_LEL_OVLProperty); }
            set { this.SetValue(H_LEL_OVLProperty, value); }
        }

        /// <summary>
        /// H_LEL_PRT Property
        /// </summary>
        public static readonly DependencyProperty H_LEL_PRTProperty =
            DependencyProperty.Register("H_LEL_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int H_LEL_PRT
        {
            get { return (int)this.GetValue(H_LEL_PRTProperty); }
            set { this.SetValue(H_LEL_PRTProperty, value); }
        }

        /// <summary>
        /// HH_LEL_CBP Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL_CBPProperty =
            DependencyProperty.Register("HH_LEL_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_LEL_CBP
        {
            get { return (string)this.GetValue(HH_LEL_CBPProperty); }
            set { this.SetValue(HH_LEL_CBPProperty, value); }
        }

        /// <summary>
        /// HH_LEL_CONN Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL_CONNProperty =
            DependencyProperty.Register("HH_LEL_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HH_LEL_CONN
        {
            get { return (bool)this.GetValue(HH_LEL_CONNProperty); }
            set { this.SetValue(HH_LEL_CONNProperty, value); }
        }

        /// <summary>
        /// HH_LEL_OVL Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL_OVLProperty =
            DependencyProperty.Register("HH_LEL_OVL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_LEL_OVL
        {
            get { return (string)this.GetValue(HH_LEL_OVLProperty); }
            set { this.SetValue(HH_LEL_OVLProperty, value); }
        }

        /// <summary>
        /// HH_LEL_PRT Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL_PRTProperty =
            DependencyProperty.Register("HH_LEL_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HH_LEL_PRT
        {
            get { return (int)this.GetValue(HH_LEL_PRTProperty); }
            set { this.SetValue(HH_LEL_PRTProperty, value); }
        }

        /// <summary>
        /// BP2_CBP Property
        /// </summary>
        public static readonly DependencyProperty BP2_CBPProperty =
            DependencyProperty.Register("BP2_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP2_CBP
        {
            get { return (string)this.GetValue(BP2_CBPProperty); }
            set { this.SetValue(BP2_CBPProperty, value); }
        }

        /// <summary>
        /// BP2_CONN Property
        /// </summary>
        public static readonly DependencyProperty BP2_CONNProperty =
            DependencyProperty.Register("BP2_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP2_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP2_CONN
        {
            get { return (bool)this.GetValue(BP2_CONNProperty); }
            set { this.SetValue(BP2_CONNProperty, value); }
        }

        /// <summary>
        /// BP3_CONN Property
        /// </summary>
        public static readonly DependencyProperty BP3_CONNProperty =
            DependencyProperty.Register("BP3_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP3_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP3_CONN
        {
            get { return (bool)this.GetValue(BP3_CONNProperty); }
            set { this.SetValue(BP3_CONNProperty, value); }
        }

        /// <summary>
        /// BP3_CBP Property
        /// </summary>
        public static readonly DependencyProperty BP3_CBPProperty =
            DependencyProperty.Register("BP3_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP3_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP3_CBP
        {
            get { return (string)this.GetValue(BP3_CBPProperty); }
            set { this.SetValue(BP3_CBPProperty, value); }
        }

        /// <summary>
        /// BP4_CBP Property
        /// </summary>
        public static readonly DependencyProperty BP4_CBPProperty =
            DependencyProperty.Register("BP4_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP4_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP4_CBP
        {
            get { return (string)this.GetValue(BP4_CBPProperty); }
            set { this.SetValue(BP4_CBPProperty, value); }
        }

        /// <summary>
        /// BP4_CONN Property
        /// </summary>
        public static readonly DependencyProperty BP4_CONNProperty =
            DependencyProperty.Register("BP4_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP4_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP4_CONN
        {
            get { return (bool)this.GetValue(BP4_CONNProperty); }
            set { this.SetValue(BP4_CONNProperty, value); }
        }

        /// <summary>
        /// HH_H2S2_CBP Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S2_CBPProperty =
            DependencyProperty.Register("HH_H2S2_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_H2S2_CBP
        {
            get { return (string)this.GetValue(HH_H2S2_CBPProperty); }
            set { this.SetValue(HH_H2S2_CBPProperty, value); }
        }

        /// <summary>
        /// HH_H2S2_CONN Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S2_CONNProperty =
            DependencyProperty.Register("HH_H2S2_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S2_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HH_H2S2_CONN
        {
            get { return (bool)this.GetValue(HH_H2S2_CONNProperty); }
            set { this.SetValue(HH_H2S2_CONNProperty, value); }
        }

        /// <summary>
        /// H_H2S2_CONN Property
        /// </summary>
        public static readonly DependencyProperty H_H2S2_CONNProperty =
            DependencyProperty.Register("H_H2S2_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S2_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool H_H2S2_CONN
        {
            get { return (bool)this.GetValue(H_H2S2_CONNProperty); }
            set { this.SetValue(H_H2S2_CONNProperty, value); }
        }

        /// <summary>
        /// H_H2S2_CBP Property
        /// </summary>
        public static readonly DependencyProperty H_H2S2_CBPProperty =
            DependencyProperty.Register("H_H2S2_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_H2S2_CBP
        {
            get { return (string)this.GetValue(H_H2S2_CBPProperty); }
            set { this.SetValue(H_H2S2_CBPProperty, value); }
        }

        /// <summary>
        /// HH_LEL2_CBP Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL2_CBPProperty =
            DependencyProperty.Register("HH_LEL2_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_LEL2_CBP
        {
            get { return (string)this.GetValue(HH_LEL2_CBPProperty); }
            set { this.SetValue(HH_LEL2_CBPProperty, value); }
        }

        /// <summary>
        /// H_LEL2_CBP Property
        /// </summary>
        public static readonly DependencyProperty H_LEL2_CBPProperty =
            DependencyProperty.Register("H_LEL2_CBP", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL2_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_LEL2_CBP
        {
            get { return (string)this.GetValue(H_LEL2_CBPProperty); }
            set { this.SetValue(H_LEL2_CBPProperty, value); }
        }

        /// <summary>
        /// HH_LEL2_CONN Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL2_CONNProperty =
            DependencyProperty.Register("HH_LEL2_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL2_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HH_LEL2_CONN
        {
            get { return (bool)this.GetValue(HH_LEL2_CONNProperty); }
            set { this.SetValue(HH_LEL2_CONNProperty, value); }
        }

        /// <summary>
        /// H_LEL2_CONN Property
        /// </summary>
        public static readonly DependencyProperty H_LEL2_CONNProperty =
            DependencyProperty.Register("H_LEL2_CONN", typeof(bool), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL2_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool H_LEL2_CONN
        {
            get { return (bool)this.GetValue(H_LEL2_CONNProperty); }
            set { this.SetValue(H_LEL2_CONNProperty, value); }
        }

        /// <summary>
        /// OVL_H2S_EXT Property
        /// </summary>
        public static readonly DependencyProperty OVL_H2S_EXTProperty =
            DependencyProperty.Register("OVL_H2S_EXT", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the OVL_H2S_EXT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OVL_H2S_EXT
        {
            get { return (string)this.GetValue(OVL_H2S_EXTProperty); }
            set { this.SetValue(OVL_H2S_EXTProperty, value); }
        }

        /// <summary>
        /// OVL_LEL_EXT Property
        /// </summary>
        public static readonly DependencyProperty OVL_LEL_EXTProperty =
            DependencyProperty.Register("OVL_LEL_EXT", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the OVL_LEL_EXT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OVL_LEL_EXT
        {
            get { return (string)this.GetValue(OVL_LEL_EXTProperty); }
            set { this.SetValue(OVL_LEL_EXTProperty, value); }
        }

        /// <summary>
        /// Next_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Next_AlarmProperty =
            DependencyProperty.Register("Next_Alarm", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the Next_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Next_Alarm
        {
            get { return (string)this.GetValue(Next_AlarmProperty); }
            set { this.SetValue(Next_AlarmProperty, value); }
        }

        /// <summary>
        /// NEX_ALM Property
        /// </summary>
        public static readonly DependencyProperty NEX_ALMProperty =
            DependencyProperty.Register("NEX_ALM", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NEX_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int NEX_ALM
        {
            get { return (int)this.GetValue(NEX_ALMProperty); }
            set { this.SetValue(NEX_ALMProperty, value); }
        }

        /// <summary>
        /// NEX_PRT Property
        /// </summary>
        public static readonly DependencyProperty NEX_PRTProperty =
            DependencyProperty.Register("NEX_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NEX_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int NEX_PRT
        {
            get { return (int)this.GetValue(NEX_PRTProperty); }
            set { this.SetValue(NEX_PRTProperty, value); }
        }

        /// <summary>
        /// PRV_PRT Property
        /// </summary>
        public static readonly DependencyProperty PRV_PRTProperty =
            DependencyProperty.Register("PRV_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the PRV_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRV_PRT
        {
            get { return (int)this.GetValue(PRV_PRTProperty); }
            set { this.SetValue(PRV_PRTProperty, value); }
        }

        /// <summary>
        /// OVR_PRT Property
        /// </summary>
        public static readonly DependencyProperty OVR_PRTProperty =
            DependencyProperty.Register("OVR_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the OVR_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int OVR_PRT
        {
            get { return (int)this.GetValue(OVR_PRTProperty); }
            set { this.SetValue(OVR_PRTProperty, value); }
        }

        /// <summary>
        /// ESD_Display Property
        /// </summary>
        public static readonly DependencyProperty ESD_DisplayProperty =
            DependencyProperty.Register("ESD_Display", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the ESD_Display.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ESD_Display
        {
            get { return (string)this.GetValue(ESD_DisplayProperty); }
            set { this.SetValue(ESD_DisplayProperty, value); }
        }

        /// <summary>
        /// ESD_PRT Property
        /// </summary>
        public static readonly DependencyProperty ESD_PRTProperty =
            DependencyProperty.Register("ESD_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the ESD_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ESD_PRT
        {
            get { return (int)this.GetValue(ESD_PRTProperty); }
            set { this.SetValue(ESD_PRTProperty, value); }
        }

        /// <summary>
        /// NEXT_ALM Property
        /// </summary>
        public static readonly DependencyProperty NEXT_ALMProperty =
            DependencyProperty.Register("NEXT_ALM", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NEXT_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NEXT_ALM
        {
            get { return (string)this.GetValue(NEXT_ALMProperty); }
            set { this.SetValue(NEXT_ALMProperty, value); }
        }

        /// <summary>
        /// H2S Property
        /// </summary>
        public static readonly DependencyProperty H2SProperty =
            DependencyProperty.Register("H2S", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H2S.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H2S
        {
            get { return (string)this.GetValue(H2SProperty); }
            set { this.SetValue(H2SProperty, value); }
        }

        /// <summary>
        /// HH_H2S_NAV Property
        /// </summary>
        public static readonly DependencyProperty HH_H2S_NAVProperty =
            DependencyProperty.Register("HH_H2S_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_H2S_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_H2S_NAV
        {
            get { return (string)this.GetValue(HH_H2S_NAVProperty); }
            set { this.SetValue(HH_H2S_NAVProperty, value); }
        }

        /// <summary>
        /// H_H2S_NAV Property
        /// </summary>
        public static readonly DependencyProperty H_H2S_NAVProperty =
            DependencyProperty.Register("H_H2S_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_H2S_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_H2S_NAV
        {
            get { return (string)this.GetValue(H_H2S_NAVProperty); }
            set { this.SetValue(H_H2S_NAVProperty, value); }
        }

        /// <summary>
        /// LEL Property
        /// </summary>
        public static readonly DependencyProperty LELProperty =
            DependencyProperty.Register("LEL", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the LEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LEL
        {
            get { return (string)this.GetValue(LELProperty); }
            set { this.SetValue(LELProperty, value); }
        }

        /// <summary>
        /// HH_LEL_NAV Property
        /// </summary>
        public static readonly DependencyProperty HH_LEL_NAVProperty =
            DependencyProperty.Register("HH_LEL_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the HH_LEL_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HH_LEL_NAV
        {
            get { return (string)this.GetValue(HH_LEL_NAVProperty); }
            set { this.SetValue(HH_LEL_NAVProperty, value); }
        }

        /// <summary>
        /// H_LEL_NAV Property
        /// </summary>
        public static readonly DependencyProperty H_LEL_NAVProperty =
            DependencyProperty.Register("H_LEL_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H_LEL_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H_LEL_NAV
        {
            get { return (string)this.GetValue(H_LEL_NAVProperty); }
            set { this.SetValue(H_LEL_NAVProperty, value); }
        }

        /// <summary>
        /// BYPASS Property
        /// </summary>
        public static readonly DependencyProperty BYPASSProperty =
            DependencyProperty.Register("BYPASS", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BYPASS
        {
            get { return (string)this.GetValue(BYPASSProperty); }
            set { this.SetValue(BYPASSProperty, value); }
        }

        /// <summary>
        /// BP_NAV Property
        /// </summary>
        public static readonly DependencyProperty BP_NAVProperty =
            DependencyProperty.Register("BP_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the BP_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BP_NAV
        {
            get { return (string)this.GetValue(BP_NAVProperty); }
            set { this.SetValue(BP_NAVProperty, value); }
        }

        /// <summary>
        /// H2S_LEL_4 Property
        /// </summary>
        public static readonly DependencyProperty H2S_LEL_4Property =
            DependencyProperty.Register("H2S_LEL_4", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the H2S_LEL_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string H2S_LEL_4
        {
            get { return (string)this.GetValue(H2S_LEL_4Property); }
            set { this.SetValue(H2S_LEL_4Property, value); }
        }

        /// <summary>
        /// NAV_H2S2 Property
        /// </summary>
        public static readonly DependencyProperty NAV_H2S2Property =
            DependencyProperty.Register("NAV_H2S2", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NAV_H2S2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NAV_H2S2
        {
            get { return (string)this.GetValue(NAV_H2S2Property); }
            set { this.SetValue(NAV_H2S2Property, value); }
        }

        /// <summary>
        /// NAV_LEL2 Property
        /// </summary>
        public static readonly DependencyProperty NAV_LEL2Property =
            DependencyProperty.Register("NAV_LEL2", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the NAV_LEL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NAV_LEL2
        {
            get { return (string)this.GetValue(NAV_LEL2Property); }
            set { this.SetValue(NAV_LEL2Property, value); }
        }

        /// <summary>
        /// PREV_RECENT Property
        /// </summary>
        public static readonly DependencyProperty PREV_RECENTProperty =
            DependencyProperty.Register("PREV_RECENT", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the PREV_RECENT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PREV_RECENT
        {
            get { return (string)this.GetValue(PREV_RECENTProperty); }
            set { this.SetValue(PREV_RECENTProperty, value); }
        }

        /// <summary>
        /// TRAIN_CLR Property
        /// </summary>
        public static readonly DependencyProperty TRAIN_CLRProperty =
            DependencyProperty.Register("TRAIN_CLR", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the TRAIN_CLR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TRAIN_CLR
        {
            get { return (string)this.GetValue(TRAIN_CLRProperty); }
            set { this.SetValue(TRAIN_CLRProperty, value); }
        }

        /// <summary>
        /// ESD_NAV Property
        /// </summary>
        public static readonly DependencyProperty ESD_NAVProperty =
            DependencyProperty.Register("ESD_NAV", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the ESD_NAV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ESD_NAV
        {
            get { return (string)this.GetValue(ESD_NAVProperty); }
            set { this.SetValue(ESD_NAVProperty, value); }
        }

        /// <summary>
        /// Display_Name1_DisplayName Property
        /// </summary>
        public static readonly DependencyProperty Display_Name1_DisplayNameProperty =
            DependencyProperty.Register("Display_Name1_DisplayName", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the Display_Name1_DisplayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Display_Name1_DisplayName
        {
            get { return (string)this.GetValue(Display_Name1_DisplayNameProperty); }
            set { this.SetValue(Display_Name1_DisplayNameProperty, value); }
        }

        /// <summary>
        /// PERV1_Display_Name Property
        /// </summary>
        public static readonly DependencyProperty PERV1_Display_NameProperty =
            DependencyProperty.Register("PERV1_Display_Name", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the PERV1_Display_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PERV1_Display_Name
        {
            get { return (string)this.GetValue(PERV1_Display_NameProperty); }
            set { this.SetValue(PERV1_Display_NameProperty, value); }
        }

        /// <summary>
        /// PERV1_PRT Property
        /// </summary>
        public static readonly DependencyProperty PERV1_PRTProperty =
            DependencyProperty.Register("PERV1_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the PERV1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PERV1_PRT
        {
            get { return (int)this.GetValue(PERV1_PRTProperty); }
            set { this.SetValue(PERV1_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_Display_Name Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_Display_NameProperty =
            DependencyProperty.Register("EmbeddedSymbol1_Display_Name", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_Display_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol1_Display_Name
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_Display_NameProperty); }
            set { this.SetValue(EmbeddedSymbol1_Display_NameProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol1_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int EmbeddedSymbol1_PRT
        {
            get { return (int)this.GetValue(EmbeddedSymbol1_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol1_PRTProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_Display_Name Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_Display_NameProperty =
            DependencyProperty.Register("EmbeddedSymbol2_Display_Name", typeof(string), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_Display_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string EmbeddedSymbol2_Display_Name
        {
            get { return (string)this.GetValue(EmbeddedSymbol2_Display_NameProperty); }
            set { this.SetValue(EmbeddedSymbol2_Display_NameProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol2_PRT Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol2_PRTProperty =
            DependencyProperty.Register("EmbeddedSymbol2_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol2_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int EmbeddedSymbol2_PRT
        {
            get { return (int)this.GetValue(EmbeddedSymbol2_PRTProperty); }
            set { this.SetValue(EmbeddedSymbol2_PRTProperty, value); }
        }

        /// <summary>
        /// RECENT1_PRT Property
        /// </summary>
        public static readonly DependencyProperty RECENT1_PRTProperty =
            DependencyProperty.Register("RECENT1_PRT", typeof(int), typeof(SYM_TITLE_1));

        /// <summary>
        /// Gets or sets the RECENT1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int RECENT1_PRT
        {
            get { return (int)this.GetValue(RECENT1_PRTProperty); }
            set { this.SetValue(RECENT1_PRTProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.DisplayTitle)) yield return new Param("$DisplayTitle", this.DisplayTitle);
if (!string.IsNullOrWhiteSpace(this.PreviousDisplay)) yield return new Param("$PreviousDisplay", this.PreviousDisplay);
if (!string.IsNullOrWhiteSpace(this.NextDisplay)) yield return new Param("$NextDisplay", this.NextDisplay);
if (!string.IsNullOrWhiteSpace(this.OverviewDisplay)) yield return new Param("$OverviewDisplay", this.OverviewDisplay);
if (!string.IsNullOrWhiteSpace(this.DispName)) yield return new Param("$DispName", this.DispName);
if (!string.IsNullOrWhiteSpace(this.BP_CBP)) yield return new Param("$BP_CBP", this.BP_CBP);
if (!string.IsNullOrWhiteSpace(this.HH_H2S_CBP)) yield return new Param("$HH_H2S_CBP", this.HH_H2S_CBP);
if (!string.IsNullOrWhiteSpace(this.BP_OVL)) yield return new Param("$BP_OVL", this.BP_OVL);
if (!string.IsNullOrWhiteSpace(this.HH_H2S_OVL)) yield return new Param("$HH_H2S_OVL", this.HH_H2S_OVL);
if (!string.IsNullOrWhiteSpace(this.H_H2S_CBP)) yield return new Param("$H_H2S_CBP", this.H_H2S_CBP);
if (!string.IsNullOrWhiteSpace(this.H_H2S_OVL)) yield return new Param("$H_H2S_OVL", this.H_H2S_OVL);
if (!string.IsNullOrWhiteSpace(this.H_LEL_CBP)) yield return new Param("$H_LEL_CBP", this.H_LEL_CBP);
if (!string.IsNullOrWhiteSpace(this.H_LEL_OVL)) yield return new Param("$H_LEL_OVL", this.H_LEL_OVL);
if (!string.IsNullOrWhiteSpace(this.HH_LEL_CBP)) yield return new Param("$HH_LEL_CBP", this.HH_LEL_CBP);
if (!string.IsNullOrWhiteSpace(this.HH_LEL_OVL)) yield return new Param("$HH_LEL_OVL", this.HH_LEL_OVL);
if (!string.IsNullOrWhiteSpace(this.BP2_CBP)) yield return new Param("$BP2_CBP", this.BP2_CBP);
if (!string.IsNullOrWhiteSpace(this.BP3_CBP)) yield return new Param("$BP3_CBP", this.BP3_CBP);
if (!string.IsNullOrWhiteSpace(this.BP4_CBP)) yield return new Param("$BP4_CBP", this.BP4_CBP);
if (!string.IsNullOrWhiteSpace(this.HH_H2S2_CBP)) yield return new Param("$HH_H2S2_CBP", this.HH_H2S2_CBP);
if (!string.IsNullOrWhiteSpace(this.H_H2S2_CBP)) yield return new Param("$H_H2S2_CBP", this.H_H2S2_CBP);
if (!string.IsNullOrWhiteSpace(this.HH_LEL2_CBP)) yield return new Param("$HH_LEL2_CBP", this.HH_LEL2_CBP);
if (!string.IsNullOrWhiteSpace(this.H_LEL2_CBP)) yield return new Param("$H_LEL2_CBP", this.H_LEL2_CBP);
if (!string.IsNullOrWhiteSpace(this.OVL_H2S_EXT)) yield return new Param("$OVL_H2S_EXT", this.OVL_H2S_EXT);
if (!string.IsNullOrWhiteSpace(this.OVL_LEL_EXT)) yield return new Param("$OVL_LEL_EXT", this.OVL_LEL_EXT);
if (!string.IsNullOrWhiteSpace(this.Next_Alarm)) yield return new Param("$Next_Alarm", this.Next_Alarm);
if (!string.IsNullOrWhiteSpace(this.ESD_Display)) yield return new Param("$ESD_Display", this.ESD_Display);

            }
        }

		
    }
}
