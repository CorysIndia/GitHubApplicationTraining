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
    public class TITLEBAR : RSIControlModel
    {
        static TITLEBAR()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TITLEBAR), new FrameworkPropertyMetadata(typeof(TITLEBAR)));
        }

		public TITLEBAR()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(TITLEBAR));

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
        /// SYM_TITLE_11_ACKPAGE Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_ACKPAGEProperty =
            DependencyProperty.Register("SYM_TITLE_11_ACKPAGE", typeof(bool), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_ACKPAGE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SYM_TITLE_11_ACKPAGE
        {
            get { return (bool)this.GetValue(SYM_TITLE_11_ACKPAGEProperty); }
            set { this.SetValue(SYM_TITLE_11_ACKPAGEProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_DisplayTitle Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_DisplayTitleProperty =
            DependencyProperty.Register("SYM_TITLE_11_DisplayTitle", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_DisplayTitle.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_DisplayTitle
        {
            get { return (string)this.GetValue(SYM_TITLE_11_DisplayTitleProperty); }
            set { this.SetValue(SYM_TITLE_11_DisplayTitleProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_PreviousDisplay Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_PreviousDisplayProperty =
            DependencyProperty.Register("SYM_TITLE_11_PreviousDisplay", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_PreviousDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_PreviousDisplay
        {
            get { return (string)this.GetValue(SYM_TITLE_11_PreviousDisplayProperty); }
            set { this.SetValue(SYM_TITLE_11_PreviousDisplayProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_NextDisplay Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_NextDisplayProperty =
            DependencyProperty.Register("SYM_TITLE_11_NextDisplay", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_NextDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_NextDisplay
        {
            get { return (string)this.GetValue(SYM_TITLE_11_NextDisplayProperty); }
            set { this.SetValue(SYM_TITLE_11_NextDisplayProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_OverviewDisplay Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_OverviewDisplayProperty =
            DependencyProperty.Register("SYM_TITLE_11_OverviewDisplay", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_OverviewDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_OverviewDisplay
        {
            get { return (string)this.GetValue(SYM_TITLE_11_OverviewDisplayProperty); }
            set { this.SetValue(SYM_TITLE_11_OverviewDisplayProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_DispName Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_DispNameProperty =
            DependencyProperty.Register("SYM_TITLE_11_DispName", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_DispName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_DispName
        {
            get { return (string)this.GetValue(SYM_TITLE_11_DispNameProperty); }
            set { this.SetValue(SYM_TITLE_11_DispNameProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_ACK_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_ACK_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_ACK_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_ACK_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_ACK_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_ACK_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_ACK_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_BP_CBP Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_BP_CBPProperty =
            DependencyProperty.Register("SYM_TITLE_11_BP_CBP", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_BP_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_BP_CBP
        {
            get { return (string)this.GetValue(SYM_TITLE_11_BP_CBPProperty); }
            set { this.SetValue(SYM_TITLE_11_BP_CBPProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_H2S_CBP Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_CBPProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_H2S_CBP", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_H2S_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_HH_H2S_CBP
        {
            get { return (string)this.GetValue(SYM_TITLE_11_HH_H2S_CBPProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_H2S_CBPProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_H2S_OVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_OVLProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_H2S_OVL", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_H2S_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_HH_H2S_OVL
        {
            get { return (string)this.GetValue(SYM_TITLE_11_HH_H2S_OVLProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_H2S_OVLProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_H2S_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_H2S_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_H2S_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_HH_H2S_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_HH_H2S_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_H2S_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_H2S_CBP Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_H2S_CBPProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_H2S_CBP", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_H2S_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_H_H2S_CBP
        {
            get { return (string)this.GetValue(SYM_TITLE_11_H_H2S_CBPProperty); }
            set { this.SetValue(SYM_TITLE_11_H_H2S_CBPProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_H2S_OVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_H2S_OVLProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_H2S_OVL", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_H2S_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_H_H2S_OVL
        {
            get { return (string)this.GetValue(SYM_TITLE_11_H_H2S_OVLProperty); }
            set { this.SetValue(SYM_TITLE_11_H_H2S_OVLProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_H2S_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_H2S_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_H2S_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_H2S_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_H_H2S_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_H_H2S_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_H_H2S_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_LEL_CBP Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_LEL_CBPProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_LEL_CBP", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_LEL_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_H_LEL_CBP
        {
            get { return (string)this.GetValue(SYM_TITLE_11_H_LEL_CBPProperty); }
            set { this.SetValue(SYM_TITLE_11_H_LEL_CBPProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_LEL_OVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_LEL_OVLProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_LEL_OVL", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_LEL_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_H_LEL_OVL
        {
            get { return (string)this.GetValue(SYM_TITLE_11_H_LEL_OVLProperty); }
            set { this.SetValue(SYM_TITLE_11_H_LEL_OVLProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_H_LEL_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_H_LEL_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_H_LEL_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_H_LEL_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_H_LEL_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_H_LEL_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_H_LEL_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_LEL_CBP Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_CBPProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_LEL_CBP", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_LEL_CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_HH_LEL_CBP
        {
            get { return (string)this.GetValue(SYM_TITLE_11_HH_LEL_CBPProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_LEL_CBPProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_LEL_OVL Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_OVLProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_LEL_OVL", typeof(string), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_LEL_OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SYM_TITLE_11_HH_LEL_OVL
        {
            get { return (string)this.GetValue(SYM_TITLE_11_HH_LEL_OVLProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_LEL_OVLProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_HH_LEL_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_HH_LEL_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_HH_LEL_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_HH_LEL_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_HH_LEL_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_HH_LEL_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_NEX_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_NEX_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_NEX_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_NEX_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_NEX_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_NEX_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_NEX_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_PRV_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_PRV_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_PRV_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_PRV_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_PRV_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_PRV_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_PRV_PRTProperty, value); }
        }

        /// <summary>
        /// SYM_TITLE_11_OVR_PRT Property
        /// </summary>
        public static readonly DependencyProperty SYM_TITLE_11_OVR_PRTProperty =
            DependencyProperty.Register("SYM_TITLE_11_OVR_PRT", typeof(int), typeof(TITLEBAR));

        /// <summary>
        /// Gets or sets the SYM_TITLE_11_OVR_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SYM_TITLE_11_OVR_PRT
        {
            get { return (int)this.GetValue(SYM_TITLE_11_OVR_PRTProperty); }
            set { this.SetValue(SYM_TITLE_11_OVR_PRTProperty, value); }
        }


		
		
    }
}
