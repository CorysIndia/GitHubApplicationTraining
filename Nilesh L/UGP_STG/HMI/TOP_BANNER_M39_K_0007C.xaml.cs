using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;

namespace UGP_STG.HMI
{
    public class TOP_BANNER_M39_K_0007C : RSIControlModel
    {
        static TOP_BANNER_M39_K_0007C()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TOP_BANNER_M39_K_0007C), new FrameworkPropertyMetadata(typeof(TOP_BANNER_M39_K_0007C)));
        }

		
         public static readonly DependencyProperty QuickLinkTab_N2_III1_NameStoreProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string QuickLinkTab_N2_III1_NameStorePropertyName = "QuickLinkTab_N2_III1_NameStore";
         public string QuickLinkTab_N2_III1_NameStore
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_NameStoreProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_SelectedProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string QuickLinkTab_N2_III1_SelectedPropertyName = "QuickLinkTab_N2_III1_Selected";
         public string QuickLinkTab_N2_III1_Selected
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_SelectedProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_SelectedProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabNameProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string QuickLinkTab_N2_III1_TabNamePropertyName = "QuickLinkTab_N2_III1_TabName";
         public string QuickLinkTab_N2_III1_TabName
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabNameProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabNameProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_TabVisibleProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string QuickLinkTab_N2_III1_TabVisiblePropertyName = "QuickLinkTab_N2_III1_TabVisible";
         public string QuickLinkTab_N2_III1_TabVisible
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_TabVisibleProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty QuickLinkTab_N2_III1_AlarmProperty = DependencyProperty.Register(QuickLinkTab_N2_III1_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string QuickLinkTab_N2_III1_AlarmPropertyName = "QuickLinkTab_N2_III1_Alarm";
         public string QuickLinkTab_N2_III1_Alarm
         {
             get { return (string)this.GetValue(QuickLinkTab_N2_III1_AlarmProperty); }
             set { this.SetValue(QuickLinkTab_N2_III1_AlarmProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_NameStoreProperty = DependencyProperty.Register(EmbeddedSymbol1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol1_NameStorePropertyName = "EmbeddedSymbol1_NameStore";
         public string EmbeddedSymbol1_NameStore
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_NameStoreProperty); }
             set { this.SetValue(EmbeddedSymbol1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_SelectedProperty = DependencyProperty.Register(EmbeddedSymbol1_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol1_SelectedPropertyName = "EmbeddedSymbol1_Selected";
         public string EmbeddedSymbol1_Selected
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_SelectedProperty); }
             set { this.SetValue(EmbeddedSymbol1_SelectedProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_TabNameProperty = DependencyProperty.Register(EmbeddedSymbol1_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol1_TabNamePropertyName = "EmbeddedSymbol1_TabName";
         public string EmbeddedSymbol1_TabName
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_TabNameProperty); }
             set { this.SetValue(EmbeddedSymbol1_TabNameProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_TabVisibleProperty = DependencyProperty.Register(EmbeddedSymbol1_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol1_TabVisiblePropertyName = "EmbeddedSymbol1_TabVisible";
         public string EmbeddedSymbol1_TabVisible
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_TabVisibleProperty); }
             set { this.SetValue(EmbeddedSymbol1_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol1_AlarmProperty = DependencyProperty.Register(EmbeddedSymbol1_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol1_AlarmPropertyName = "EmbeddedSymbol1_Alarm";
         public string EmbeddedSymbol1_Alarm
         {
             get { return (string)this.GetValue(EmbeddedSymbol1_AlarmProperty); }
             set { this.SetValue(EmbeddedSymbol1_AlarmProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol2_NameStoreProperty = DependencyProperty.Register(EmbeddedSymbol2_NameStorePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol2_NameStorePropertyName = "EmbeddedSymbol2_NameStore";
         public string EmbeddedSymbol2_NameStore
         {
             get { return (string)this.GetValue(EmbeddedSymbol2_NameStoreProperty); }
             set { this.SetValue(EmbeddedSymbol2_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol2_SelectedProperty = DependencyProperty.Register(EmbeddedSymbol2_SelectedPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol2_SelectedPropertyName = "EmbeddedSymbol2_Selected";
         public string EmbeddedSymbol2_Selected
         {
             get { return (string)this.GetValue(EmbeddedSymbol2_SelectedProperty); }
             set { this.SetValue(EmbeddedSymbol2_SelectedProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol2_TabNameProperty = DependencyProperty.Register(EmbeddedSymbol2_TabNamePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol2_TabNamePropertyName = "EmbeddedSymbol2_TabName";
         public string EmbeddedSymbol2_TabName
         {
             get { return (string)this.GetValue(EmbeddedSymbol2_TabNameProperty); }
             set { this.SetValue(EmbeddedSymbol2_TabNameProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol2_TabVisibleProperty = DependencyProperty.Register(EmbeddedSymbol2_TabVisiblePropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol2_TabVisiblePropertyName = "EmbeddedSymbol2_TabVisible";
         public string EmbeddedSymbol2_TabVisible
         {
             get { return (string)this.GetValue(EmbeddedSymbol2_TabVisibleProperty); }
             set { this.SetValue(EmbeddedSymbol2_TabVisibleProperty, value); }
         }

         public static readonly DependencyProperty EmbeddedSymbol2_AlarmProperty = DependencyProperty.Register(EmbeddedSymbol2_AlarmPropertyName, typeof(string), typeof(TOP_BANNER_M39_K_0007C)); 
         public const string EmbeddedSymbol2_AlarmPropertyName = "EmbeddedSymbol2_Alarm";
         public string EmbeddedSymbol2_Alarm
         {
             get { return (string)this.GetValue(EmbeddedSymbol2_AlarmProperty); }
             set { this.SetValue(EmbeddedSymbol2_AlarmProperty, value); }
         }

		
		
    }
}
