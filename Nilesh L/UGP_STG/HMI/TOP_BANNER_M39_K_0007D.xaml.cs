using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;

namespace UGP_STG.HMI
{
    public class TOP_BANNER_M39_K_0007D : RSIControlModel
    {
        static TOP_BANNER_M39_K_0007D()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TOP_BANNER_M39_K_0007D), new FrameworkPropertyMetadata(typeof(TOP_BANNER_M39_K_0007D)));
        }

		
         public static readonly DependencyProperty QuickLinkTab_N2_III1_NameStoreProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string QuickLinkTab_N2_III1_NameStorePropertyName = "QuickLinkTab_N2_III1_NameStore";
         public string QuickLinkTab_N2_III1_NameStore
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_NameStoreProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_SelectedProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string QuickLinkTab_N2_III1_SelectedPropertyName = "QuickLinkTab_N2_III1_Selected";
         public string QuickLinkTab_N2_III1_Selected
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_SelectedProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_SelectedProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabNameProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string QuickLinkTab_N2_III1_TabNamePropertyName = "QuickLinkTab_N2_III1_TabName";
         public string QuickLinkTab_N2_III1_TabName
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabNameProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabNameProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabVisibleProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string QuickLinkTab_N2_III1_TabVisiblePropertyName = "QuickLinkTab_N2_III1_TabVisible";
         public string QuickLinkTab_N2_III1_TabVisible
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabVisibleProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_AlarmProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string QuickLinkTab_N2_III1_AlarmPropertyName = "QuickLinkTab_N2_III1_Alarm";
         public string QuickLinkTab_N2_III1_Alarm
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_AlarmProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_AlarmProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_NameStoreProperty = DependencyProperty.Register(EmbeddedSymbol1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol1_NameStorePropertyName = "EmbeddedSymbol1_NameStore";
         public string EmbeddedSymbol1_NameStore
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_NameStoreProperty); }
             set { this.SetValue(EmbeddedSymbol1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_SelectedProperty = DependencyProperty.Register(EmbeddedSymbol1_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol1_SelectedPropertyName = "EmbeddedSymbol1_Selected";
         public string EmbeddedSymbol1_Selected
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_SelectedProperty); }
             set { this.SetValue(EmbeddedSymbol1_SelectedProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_TabNameProperty = DependencyProperty.Register(EmbeddedSymbol1_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol1_TabNamePropertyName = "EmbeddedSymbol1_TabName";
         public string EmbeddedSymbol1_TabName
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_TabNameProperty); }
             set { this.SetValue(EmbeddedSymbol1_TabNameProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_TabVisibleProperty = DependencyProperty.Register(EmbeddedSymbol1_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol1_TabVisiblePropertyName = "EmbeddedSymbol1_TabVisible";
         public string EmbeddedSymbol1_TabVisible
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_TabVisibleProperty); }
             set { this.SetValue(EmbeddedSymbol1_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_AlarmProperty = DependencyProperty.Register(EmbeddedSymbol1_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol1_AlarmPropertyName = "EmbeddedSymbol1_Alarm";
         public string EmbeddedSymbol1_Alarm
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_AlarmProperty); }
             set { this.SetValue(EmbeddedSymbol1_AlarmProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol3_NameStoreProperty = DependencyProperty.Register(EmbeddedSymbol3_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol3_NameStorePropertyName = "EmbeddedSymbol3_NameStore";
         public string EmbeddedSymbol3_NameStore
         {
             get { return (string)this.GetValue(EmbeddedSymbol3_NameStoreProperty); }
             set { this.SetValue(EmbeddedSymbol3_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol3_SelectedProperty = DependencyProperty.Register(EmbeddedSymbol3_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol3_SelectedPropertyName = "EmbeddedSymbol3_Selected";
         public string EmbeddedSymbol3_Selected
         {
             get { return (string)this.GetValue(EmbeddedSymbol3_SelectedProperty); }
             set { this.SetValue(EmbeddedSymbol3_SelectedProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol3_TabNameProperty = DependencyProperty.Register(EmbeddedSymbol3_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol3_TabNamePropertyName = "EmbeddedSymbol3_TabName";
         public string EmbeddedSymbol3_TabName
         {
             get { return (string)this.GetValue(EmbeddedSymbol3_TabNameProperty); }
             set { this.SetValue(EmbeddedSymbol3_TabNameProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol3_TabVisibleProperty = DependencyProperty.Register(EmbeddedSymbol3_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol3_TabVisiblePropertyName = "EmbeddedSymbol3_TabVisible";
         public string EmbeddedSymbol3_TabVisible
         {
             get { return (string)this.GetValue(EmbeddedSymbol3_TabVisibleProperty); }
             set { this.SetValue(EmbeddedSymbol3_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol3_AlarmProperty = DependencyProperty.Register(EmbeddedSymbol3_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007D)); 
         public const string EmbeddedSymbol3_AlarmPropertyName = "EmbeddedSymbol3_Alarm";
         public string EmbeddedSymbol3_Alarm
         {
             get { return (string)this.GetValue(EmbeddedSymbol3_AlarmProperty); }
             set { this.SetValue(EmbeddedSymbol3_AlarmProperty, value); }
         }

		
		
    }
}
