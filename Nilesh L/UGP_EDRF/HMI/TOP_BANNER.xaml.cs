using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;

namespace UGP_EDRF.HMI
{
    public class TOP_BANNER : RSIControlModel
    {
        static TOP_BANNER()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TOP_BANNER), new FrameworkPropertyMetadata(typeof(TOP_BANNER)));
        }

		
         public static readonly DependencyProperty TriconexNamePlate_III1_NameStoreProperty = DependencyProperty.Register(TriconexNamePlate_III1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string TriconexNamePlate_III1_NameStorePropertyName = "TriconexNamePlate_III1_NameStore";
         public string TriconexNamePlate_III1_NameStore
         {
             get { return (string)this.GetValue(TriconexNamePlate_III1_NameStoreProperty); }
             set { this.SetValue(TriconexNamePlate_III1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_ACK1_DisableProperty = DependencyProperty.Register(PbMom_03_ACK1_DisablePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_ACK1_DisablePropertyName = "PbMom_03_ACK1_Disable";
         public string PbMom_03_ACK1_Disable
         {
             get { return (string)this.GetValue(PbMom_03_ACK1_DisableProperty); }
             set { this.SetValue(PbMom_03_ACK1_DisableProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_ACK1_WinNameProperty = DependencyProperty.Register(PbMom_03_ACK1_WinNamePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_ACK1_WinNamePropertyName = "PbMom_03_ACK1_WinName";
         public string PbMom_03_ACK1_WinName
         {
             get { return (string)this.GetValue(PbMom_03_ACK1_WinNameProperty); }
             set { this.SetValue(PbMom_03_ACK1_WinNameProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_ACK1_NameStoreProperty = DependencyProperty.Register(PbMom_03_ACK1_NameStorePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_ACK1_NameStorePropertyName = "PbMom_03_ACK1_NameStore";
         public string PbMom_03_ACK1_NameStore
         {
             get { return (string)this.GetValue(PbMom_03_ACK1_NameStoreProperty); }
             set { this.SetValue(PbMom_03_ACK1_NameStoreProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_M2_DisableProperty = DependencyProperty.Register(PbMom_03_M2_DisablePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_M2_DisablePropertyName = "PbMom_03_M2_Disable";
         public string PbMom_03_M2_Disable
         {
             get { return (string)this.GetValue(PbMom_03_M2_DisableProperty); }
             set { this.SetValue(PbMom_03_M2_DisableProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_M2_WinNameProperty = DependencyProperty.Register(PbMom_03_M2_WinNamePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_M2_WinNamePropertyName = "PbMom_03_M2_WinName";
         public string PbMom_03_M2_WinName
         {
             get { return (string)this.GetValue(PbMom_03_M2_WinNameProperty); }
             set { this.SetValue(PbMom_03_M2_WinNameProperty, value); }
         }

         public static readonly DependencyProperty PbMom_03_M2_NameStoreProperty = DependencyProperty.Register(PbMom_03_M2_NameStorePropertyName, typeof(string), typeof(TOP_BANNER)); 
         public const string PbMom_03_M2_NameStorePropertyName = "PbMom_03_M2_NameStore";
         public string PbMom_03_M2_NameStore
         {
             get { return (string)this.GetValue(PbMom_03_M2_NameStoreProperty); }
             set { this.SetValue(PbMom_03_M2_NameStoreProperty, value); }
         }

		
		
    }
}
