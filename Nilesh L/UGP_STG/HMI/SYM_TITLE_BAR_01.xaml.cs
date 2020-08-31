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
    public class SYM_TITLE_BAR_01 : RSIControlModel
    {
        static SYM_TITLE_BAR_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_TITLE_BAR_01), new FrameworkPropertyMetadata(typeof(SYM_TITLE_BAR_01)));
        }

		public SYM_TITLE_BAR_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_TITLE_BAR_01));

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


		
         public static readonly DependencyProperty OverviewDisplayProperty = DependencyProperty.Register(OverviewDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string OverviewDisplayPropertyName = "OverviewDisplay";
         public string OverviewDisplay
         {
             get { return (string)this.GetValue(OverviewDisplayProperty); }
             set { this.SetValue(OverviewDisplayProperty, value); }
         }

         public static readonly DependencyProperty DisplayTitleProperty = DependencyProperty.Register(DisplayTitlePropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string DisplayTitlePropertyName = "DisplayTitle";
         public string DisplayTitle
         {
             get { return (string)this.GetValue(DisplayTitleProperty); }
             set { this.SetValue(DisplayTitleProperty, value); }
         }

         public static readonly DependencyProperty DispNameProperty = DependencyProperty.Register(DispNamePropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string DispNamePropertyName = "DispName";
         public string DispName
         {
             get { return (string)this.GetValue(DispNameProperty); }
             set { this.SetValue(DispNameProperty, value); }
         }

         public static readonly DependencyProperty NextDisplayProperty = DependencyProperty.Register(NextDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string NextDisplayPropertyName = "NextDisplay";
         public string NextDisplay
         {
             get { return (string)this.GetValue(NextDisplayProperty); }
             set { this.SetValue(NextDisplayProperty, value); }
         }

         public static readonly DependencyProperty PreviousDisplayProperty = DependencyProperty.Register(PreviousDisplayPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string PreviousDisplayPropertyName = "PreviousDisplay";
         public string PreviousDisplay
         {
             get { return (string)this.GetValue(PreviousDisplayProperty); }
             set { this.SetValue(PreviousDisplayProperty, value); }
         }

         public static readonly DependencyProperty ACKPAGEProperty = DependencyProperty.Register(ACKPAGEPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string ACKPAGEPropertyName = "ACKPAGE";
         public string ACKPAGE
         {
             get { return (string)this.GetValue(ACKPAGEProperty); }
             set { this.SetValue(ACKPAGEProperty, value); }
         }

         public static readonly DependencyProperty ACK_PRTProperty = DependencyProperty.Register(ACK_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string ACK_PRTPropertyName = "ACK_PRT";
         public string ACK_PRT
         {
             get { return (string)this.GetValue(ACK_PRTProperty); }
             set { this.SetValue(ACK_PRTProperty, value); }
         }

         public static readonly DependencyProperty BP_CBPProperty = DependencyProperty.Register(BP_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string BP_CBPPropertyName = "BP_CBP";
         public string BP_CBP
         {
             get { return (string)this.GetValue(BP_CBPProperty); }
             set { this.SetValue(BP_CBPProperty, value); }
         }

         public static readonly DependencyProperty HH_H2S_CBPProperty = DependencyProperty.Register(HH_H2S_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_H2S_CBPPropertyName = "HH_H2S_CBP";
         public string HH_H2S_CBP
         {
             get { return (string)this.GetValue(HH_H2S_CBPProperty); }
             set { this.SetValue(HH_H2S_CBPProperty, value); }
         }

         public static readonly DependencyProperty HH_H2S_OVLProperty = DependencyProperty.Register(HH_H2S_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_H2S_OVLPropertyName = "HH_H2S_OVL";
         public string HH_H2S_OVL
         {
             get { return (string)this.GetValue(HH_H2S_OVLProperty); }
             set { this.SetValue(HH_H2S_OVLProperty, value); }
         }

         public static readonly DependencyProperty HH_H2S_PRTProperty = DependencyProperty.Register(HH_H2S_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_H2S_PRTPropertyName = "HH_H2S_PRT";
         public string HH_H2S_PRT
         {
             get { return (string)this.GetValue(HH_H2S_PRTProperty); }
             set { this.SetValue(HH_H2S_PRTProperty, value); }
         }

         public static readonly DependencyProperty H_H2S_CBPProperty = DependencyProperty.Register(H_H2S_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_H2S_CBPPropertyName = "H_H2S_CBP";
         public string H_H2S_CBP
         {
             get { return (string)this.GetValue(H_H2S_CBPProperty); }
             set { this.SetValue(H_H2S_CBPProperty, value); }
         }

         public static readonly DependencyProperty H_H2S_OVLProperty = DependencyProperty.Register(H_H2S_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_H2S_OVLPropertyName = "H_H2S_OVL";
         public string H_H2S_OVL
         {
             get { return (string)this.GetValue(H_H2S_OVLProperty); }
             set { this.SetValue(H_H2S_OVLProperty, value); }
         }

         public static readonly DependencyProperty H_H2S_PRTProperty = DependencyProperty.Register(H_H2S_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_H2S_PRTPropertyName = "H_H2S_PRT";
         public string H_H2S_PRT
         {
             get { return (string)this.GetValue(H_H2S_PRTProperty); }
             set { this.SetValue(H_H2S_PRTProperty, value); }
         }

         public static readonly DependencyProperty H_LEL_CBPProperty = DependencyProperty.Register(H_LEL_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_LEL_CBPPropertyName = "H_LEL_CBP";
         public string H_LEL_CBP
         {
             get { return (string)this.GetValue(H_LEL_CBPProperty); }
             set { this.SetValue(H_LEL_CBPProperty, value); }
         }

         public static readonly DependencyProperty H_LEL_OVLProperty = DependencyProperty.Register(H_LEL_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_LEL_OVLPropertyName = "H_LEL_OVL";
         public string H_LEL_OVL
         {
             get { return (string)this.GetValue(H_LEL_OVLProperty); }
             set { this.SetValue(H_LEL_OVLProperty, value); }
         }

         public static readonly DependencyProperty H_LEL_PRTProperty = DependencyProperty.Register(H_LEL_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string H_LEL_PRTPropertyName = "H_LEL_PRT";
         public string H_LEL_PRT
         {
             get { return (string)this.GetValue(H_LEL_PRTProperty); }
             set { this.SetValue(H_LEL_PRTProperty, value); }
         }

         public static readonly DependencyProperty HH_LEL_CBPProperty = DependencyProperty.Register(HH_LEL_CBPPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_LEL_CBPPropertyName = "HH_LEL_CBP";
         public string HH_LEL_CBP
         {
             get { return (string)this.GetValue(HH_LEL_CBPProperty); }
             set { this.SetValue(HH_LEL_CBPProperty, value); }
         }

         public static readonly DependencyProperty HH_LEL_OVLProperty = DependencyProperty.Register(HH_LEL_OVLPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_LEL_OVLPropertyName = "HH_LEL_OVL";
         public string HH_LEL_OVL
         {
             get { return (string)this.GetValue(HH_LEL_OVLProperty); }
             set { this.SetValue(HH_LEL_OVLProperty, value); }
         }

         public static readonly DependencyProperty HH_LEL_PRTProperty = DependencyProperty.Register(HH_LEL_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string HH_LEL_PRTPropertyName = "HH_LEL_PRT";
         public string HH_LEL_PRT
         {
             get { return (string)this.GetValue(HH_LEL_PRTProperty); }
             set { this.SetValue(HH_LEL_PRTProperty, value); }
         }

         public static readonly DependencyProperty NEX_PRTProperty = DependencyProperty.Register(NEX_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string NEX_PRTPropertyName = "NEX_PRT";
         public string NEX_PRT
         {
             get { return (string)this.GetValue(NEX_PRTProperty); }
             set { this.SetValue(NEX_PRTProperty, value); }
         }

         public static readonly DependencyProperty PRV_PRTProperty = DependencyProperty.Register(PRV_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string PRV_PRTPropertyName = "PRV_PRT";
         public string PRV_PRT
         {
             get { return (string)this.GetValue(PRV_PRTProperty); }
             set { this.SetValue(PRV_PRTProperty, value); }
         }

         public static readonly DependencyProperty OVR_PRTProperty = DependencyProperty.Register(OVR_PRTPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01)); 
         public const string OVR_PRTPropertyName = "OVR_PRT";
         public string OVR_PRT
         {
             get { return (string)this.GetValue(OVR_PRTProperty); }
             set { this.SetValue(OVR_PRTProperty, value); }
         }

        public static readonly DependencyProperty BP_NAVProperty = DependencyProperty.Register(BP_NAVPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01));
        public const string BP_NAVPropertyName = "BP_NAV";
        public string BP_NAV
        {
            get { return (string)this.GetValue(BP_NAVProperty); }
            set { this.SetValue(BP_NAVProperty, value); }
        }

        public static readonly DependencyProperty BYPASSProperty = DependencyProperty.Register(BYPASSPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01));
        public const string BYPASSPropertyName = "BYPASS";
        public string BYPASS
        {
            get { return (string)this.GetValue(BYPASSProperty); }
            set { this.SetValue(BYPASSProperty, value); }
        }

        public static readonly DependencyProperty ESD_NAVProperty = DependencyProperty.Register(ESD_NAVPropertyName, typeof(string), typeof(SYM_TITLE_BAR_01));
        public const string ESD_NAVPropertyName = "ESD_NAV";
        public string ESD_NAV
        {
            get { return (string)this.GetValue(ESD_NAVProperty); }
            set { this.SetValue(ESD_NAVProperty, value); }
        }

        public static readonly DependencyProperty H_H2S_NAVProperty = DependencyProperty.Register(H_H2S_NAVPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string H_H2S_NAVPropertyName = "H_H2S_NAV";
        public string H_H2S_NAV
        {
            get { return (string)this.GetValue(H_H2S_NAVProperty); }
            set { this.SetValue(H_H2S_NAVProperty, value); }
        }

        public static readonly DependencyProperty H_LEL_NAVProperty = DependencyProperty.Register(H_LEL_NAVPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string H_LEL_NAVPropertyName = "H_LEL_NAV";
        public string H_LEL_NAV
        {
            get { return (string)this.GetValue(H_LEL_NAVProperty); }
            set { this.SetValue(H_LEL_NAVProperty, value); }
        }

        public static readonly DependencyProperty HH_H2S_NAVProperty = DependencyProperty.Register(HH_H2S_NAVPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string HH_H2S_NAVPropertyName = "HH_H2S_NAV";
        public string HH_H2S_NAV
        {
            get { return (string)this.GetValue(HH_H2S_NAVProperty); }
            set { this.SetValue(HH_H2S_NAVProperty, value); }
        }

        public static readonly DependencyProperty HH_LEL_NAVProperty = DependencyProperty.Register(HH_LEL_NAVPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string HH_LEL_NAVPropertyName = "HH_LEL_NAV";
        public string HH_LEL_NAV
        {
            get { return (string)this.GetValue(HH_LEL_NAVProperty); }
            set { this.SetValue(HH_LEL_NAVProperty, value); }
        }

        public static readonly DependencyProperty H2SProperty = DependencyProperty.Register(H2SPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string H2SPropertyName = "H2S";
        public string H2S
        {
            get { return (string)this.GetValue(H2SProperty); }
            set { this.SetValue(H2SProperty, value); }
        }

        public static readonly DependencyProperty H2S_LEL_4Property = DependencyProperty.Register(H2S_LEL_4PropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string H2S_LEL_4PropertyName = "H2S_LEL_4";
        public string H2S_LEL_4
        {
            get { return (string)this.GetValue(H2S_LEL_4Property); }
            set { this.SetValue(H2S_LEL_4Property, value); }
        }

        public static readonly DependencyProperty LELProperty = DependencyProperty.Register(LELPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string LELPropertyName = "LEL";
        public string LEL
        {
            get { return (string)this.GetValue(LELProperty); }
            set { this.SetValue(LELProperty, value); }
        }

        public static readonly DependencyProperty NAV_H2S2Property = DependencyProperty.Register(NAV_H2S2PropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string NAV_H2S2PropertyName = "NAV_H2S2";
        public string NAV_H2S2
        {
            get { return (string)this.GetValue(NAV_H2S2Property); }
            set { this.SetValue(NAV_H2S2Property, value); }
        }

        public static readonly DependencyProperty NAV_LEL2Property = DependencyProperty.Register(NAV_LEL2PropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string NAV_LEL2PropertyName = "NAV_LEL2";
        public string NAV_LEL2
        {
            get { return (string)this.GetValue(NAV_LEL2Property); }
            set { this.SetValue(NAV_LEL2Property, value); }
        }

        public static readonly DependencyProperty NEXT_ALMProperty = DependencyProperty.Register(NEXT_ALMPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string NEXT_ALMPropertyName = "NEXT_ALM";
        public string NEXT_ALM
        {
            get { return (string)this.GetValue(NEXT_ALMProperty); }
            set { this.SetValue(NEXT_ALMProperty, value); }
        }

        public static readonly DependencyProperty PREV_RECENTProperty = DependencyProperty.Register(PREV_RECENTPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string PREV_RECENTPropertyName = "PREV_RECENT";
        public string PREV_RECENT
        {
            get { return (string)this.GetValue(PREV_RECENTProperty); }
            set { this.SetValue(PREV_RECENTProperty, value); }
        }

        public static readonly DependencyProperty TRAIN_CLRProperty = DependencyProperty.Register(TRAIN_CLRPropertyName, typeof(bool), typeof(SYM_TITLE_BAR_01));
        public const string TRAIN_CLRPropertyName = "TRAIN_CLR";
        public string TRAIN_CLR
        {
            get { return (string)this.GetValue(TRAIN_CLRProperty); }
            set { this.SetValue(TRAIN_CLRProperty, value); }
        }
    }
}
