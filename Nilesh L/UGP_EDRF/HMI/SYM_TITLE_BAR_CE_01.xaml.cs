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
    public class SYM_TITLE_BAR_CE_01 : RSIControlModel
    {
        static SYM_TITLE_BAR_CE_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_TITLE_BAR_CE_01), new FrameworkPropertyMetadata(typeof(SYM_TITLE_BAR_CE_01)));
        }

		public SYM_TITLE_BAR_CE_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_TITLE_BAR_CE_01));

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


		
         public static readonly DependencyProperty SYM_TITLE_11_DispNameProperty = DependencyProperty.Register(SYM_TITLE_11_DispNamePropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_DispNamePropertyName = "SYM_TITLE_11_DispName";
         public string SYM_TITLE_11_DispName
         {
             get { return (string)this.GetValue(SYM_TITLE_11_DispNameProperty); }
             set { this.SetValue(SYM_TITLE_11_DispNameProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_DisplayTitleProperty = DependencyProperty.Register(SYM_TITLE_11_DisplayTitlePropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_DisplayTitlePropertyName = "SYM_TITLE_11_DisplayTitle";
         public string SYM_TITLE_11_DisplayTitle
         {
             get { return (string)this.GetValue(SYM_TITLE_11_DisplayTitleProperty); }
             set { this.SetValue(SYM_TITLE_11_DisplayTitleProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_PreviousDisplayProperty = DependencyProperty.Register(SYM_TITLE_11_PreviousDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_PreviousDisplayPropertyName = "SYM_TITLE_11_PreviousDisplay";
         public string SYM_TITLE_11_PreviousDisplay
         {
             get { return (string)this.GetValue(SYM_TITLE_11_PreviousDisplayProperty); }
             set { this.SetValue(SYM_TITLE_11_PreviousDisplayProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_NextDisplayProperty = DependencyProperty.Register(SYM_TITLE_11_NextDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_NextDisplayPropertyName = "SYM_TITLE_11_NextDisplay";
         public string SYM_TITLE_11_NextDisplay
         {
             get { return (string)this.GetValue(SYM_TITLE_11_NextDisplayProperty); }
             set { this.SetValue(SYM_TITLE_11_NextDisplayProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_OverviewDisplayProperty = DependencyProperty.Register(SYM_TITLE_11_OverviewDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_OverviewDisplayPropertyName = "SYM_TITLE_11_OverviewDisplay";
         public string SYM_TITLE_11_OverviewDisplay
         {
             get { return (string)this.GetValue(SYM_TITLE_11_OverviewDisplayProperty); }
             set { this.SetValue(SYM_TITLE_11_OverviewDisplayProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_ACKPAGEProperty = DependencyProperty.Register(SYM_TITLE_11_ACKPAGEPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_ACKPAGEPropertyName = "SYM_TITLE_11_ACKPAGE";
         public string SYM_TITLE_11_ACKPAGE
         {
             get { return (string)this.GetValue(SYM_TITLE_11_ACKPAGEProperty); }
             set { this.SetValue(SYM_TITLE_11_ACKPAGEProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_ACK_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_ACK_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_ACK_PRTPropertyName = "SYM_TITLE_11_ACK_PRT";
         public string SYM_TITLE_11_ACK_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_ACK_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_ACK_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_BP_CBPProperty = DependencyProperty.Register(SYM_TITLE_11_BP_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_BP_CBPPropertyName = "SYM_TITLE_11_BP_CBP";
         public string SYM_TITLE_11_BP_CBP
         {
             get { return (string)this.GetValue(SYM_TITLE_11_BP_CBPProperty); }
             set { this.SetValue(SYM_TITLE_11_BP_CBPProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_CBPProperty = DependencyProperty.Register(SYM_TITLE_11_HH_H2S_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_H2S_CBPPropertyName = "SYM_TITLE_11_HH_H2S_CBP";
         public string SYM_TITLE_11_HH_H2S_CBP
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_H2S_CBPProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_H2S_CBPProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_OVLProperty = DependencyProperty.Register(SYM_TITLE_11_HH_H2S_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_H2S_OVLPropertyName = "SYM_TITLE_11_HH_H2S_OVL";
         public string SYM_TITLE_11_HH_H2S_OVL
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_H2S_OVLProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_H2S_OVLProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_H2S_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_HH_H2S_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_H2S_PRTPropertyName = "SYM_TITLE_11_HH_H2S_PRT";
         public string SYM_TITLE_11_HH_H2S_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_H2S_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_H2S_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_H2S_CBPProperty = DependencyProperty.Register(SYM_TITLE_11_H_H2S_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_H2S_CBPPropertyName = "SYM_TITLE_11_H_H2S_CBP";
         public string SYM_TITLE_11_H_H2S_CBP
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_H2S_CBPProperty); }
             set { this.SetValue(SYM_TITLE_11_H_H2S_CBPProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_H2S_OVLProperty = DependencyProperty.Register(SYM_TITLE_11_H_H2S_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_H2S_OVLPropertyName = "SYM_TITLE_11_H_H2S_OVL";
         public string SYM_TITLE_11_H_H2S_OVL
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_H2S_OVLProperty); }
             set { this.SetValue(SYM_TITLE_11_H_H2S_OVLProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_H2S_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_H_H2S_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_H2S_PRTPropertyName = "SYM_TITLE_11_H_H2S_PRT";
         public string SYM_TITLE_11_H_H2S_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_H2S_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_H_H2S_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_LEL_CBPProperty = DependencyProperty.Register(SYM_TITLE_11_H_LEL_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_LEL_CBPPropertyName = "SYM_TITLE_11_H_LEL_CBP";
         public string SYM_TITLE_11_H_LEL_CBP
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_LEL_CBPProperty); }
             set { this.SetValue(SYM_TITLE_11_H_LEL_CBPProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_LEL_OVLProperty = DependencyProperty.Register(SYM_TITLE_11_H_LEL_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_LEL_OVLPropertyName = "SYM_TITLE_11_H_LEL_OVL";
         public string SYM_TITLE_11_H_LEL_OVL
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_LEL_OVLProperty); }
             set { this.SetValue(SYM_TITLE_11_H_LEL_OVLProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_H_LEL_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_H_LEL_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_H_LEL_PRTPropertyName = "SYM_TITLE_11_H_LEL_PRT";
         public string SYM_TITLE_11_H_LEL_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_H_LEL_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_H_LEL_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_CBPProperty = DependencyProperty.Register(SYM_TITLE_11_HH_LEL_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_LEL_CBPPropertyName = "SYM_TITLE_11_HH_LEL_CBP";
         public string SYM_TITLE_11_HH_LEL_CBP
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_LEL_CBPProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_LEL_CBPProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_OVLProperty = DependencyProperty.Register(SYM_TITLE_11_HH_LEL_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_LEL_OVLPropertyName = "SYM_TITLE_11_HH_LEL_OVL";
         public string SYM_TITLE_11_HH_LEL_OVL
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_LEL_OVLProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_LEL_OVLProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_HH_LEL_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_HH_LEL_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_HH_LEL_PRTPropertyName = "SYM_TITLE_11_HH_LEL_PRT";
         public string SYM_TITLE_11_HH_LEL_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_HH_LEL_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_HH_LEL_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_NEX_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_NEX_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_NEX_PRTPropertyName = "SYM_TITLE_11_NEX_PRT";
         public string SYM_TITLE_11_NEX_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_NEX_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_NEX_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_PRV_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_PRV_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_PRV_PRTPropertyName = "SYM_TITLE_11_PRV_PRT";
         public string SYM_TITLE_11_PRV_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_PRV_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_PRV_PRTProperty, value); }
         }

         public static readonly DependencyProperty SYM_TITLE_11_OVR_PRTProperty = DependencyProperty.Register(SYM_TITLE_11_OVR_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_CE_01)); 
         public const string SYM_TITLE_11_OVR_PRTPropertyName = "SYM_TITLE_11_OVR_PRT";
         public string SYM_TITLE_11_OVR_PRT
         {
             get { return (string)this.GetValue(SYM_TITLE_11_OVR_PRTProperty); }
             set { this.SetValue(SYM_TITLE_11_OVR_PRTProperty, value); }
         }

		
		
    }
}
