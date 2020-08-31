using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;

namespace UGP_STG.HMI
{
    public class TOP_BANNER_M39_K_0003B : RSIControlModel
    {
        static TOP_BANNER_M39_K_0003B()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TOP_BANNER_M39_K_0003B), new FrameworkPropertyMetadata(typeof(TOP_BANNER_M39_K_0003B)));
        }

		
         public static readonly DependencyProperty QuickLinkTab_N2_III1_NameStoreProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0003B)); 
         public const string QuickLinkTab_N2_III1_NameStorePropertyName = "QuickLinkTab_N2_III1_NameStore";
         public string QuickLinkTab_N2_III1_NameStore
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_NameStoreProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_SelectedProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0003B)); 
         public const string QuickLinkTab_N2_III1_SelectedPropertyName = "QuickLinkTab_N2_III1_Selected";
         public string QuickLinkTab_N2_III1_Selected
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_SelectedProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_SelectedProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabNameProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0003B)); 
         public const string QuickLinkTab_N2_III1_TabNamePropertyName = "QuickLinkTab_N2_III1_TabName";
         public string QuickLinkTab_N2_III1_TabName
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabNameProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabNameProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabVisibleProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0003B)); 
         public const string QuickLinkTab_N2_III1_TabVisiblePropertyName = "QuickLinkTab_N2_III1_TabVisible";
         public string QuickLinkTab_N2_III1_TabVisible
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabVisibleProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_AlarmProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0003B)); 
         public const string QuickLinkTab_N2_III1_AlarmPropertyName = "QuickLinkTab_N2_III1_Alarm";
         public string QuickLinkTab_N2_III1_Alarm
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_AlarmProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_AlarmProperty, value); }
         }

		
		
    }
}
