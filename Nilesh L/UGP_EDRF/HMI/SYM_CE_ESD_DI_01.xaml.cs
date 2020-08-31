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
    public class SYM_CE_ESD_DI_01 : RSIControlModel
    {
        static SYM_CE_ESD_DI_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CE_ESD_DI_01), new FrameworkPropertyMetadata(typeof(SYM_CE_ESD_DI_01)));
        }

		public SYM_CE_ESD_DI_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CE_ESD_DI_01));

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


		
         public static readonly DependencyProperty BLK_TProperty = DependencyProperty.Register(BLK_TPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string BLK_TPropertyName = "BLK_T";
         public string BLK_T
         {
             get { return (string)this.GetValue(BLK_TProperty); }
             set { this.SetValue(BLK_TProperty, value); }
         }

         public static readonly DependencyProperty CMPProperty = DependencyProperty.Register(CMPPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string CMPPropertyName = "CMP";
         public string CMP
         {
             get { return (string)this.GetValue(CMPProperty); }
             set { this.SetValue(CMPProperty, value); }
         }

         public static readonly DependencyProperty BLK_FLTProperty = DependencyProperty.Register(BLK_FLTPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string BLK_FLTPropertyName = "BLK_FLT";
         public string BLK_FLT
         {
             get { return (string)this.GetValue(BLK_FLTProperty); }
             set { this.SetValue(BLK_FLTProperty, value); }
         }

         public static readonly DependencyProperty BLK_MOSProperty = DependencyProperty.Register(BLK_MOSPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string BLK_MOSPropertyName = "BLK_MOS";
         public string BLK_MOS
         {
             get { return (string)this.GetValue(BLK_MOSProperty); }
             set { this.SetValue(BLK_MOSProperty, value); }
         }

         public static readonly DependencyProperty PRTProperty = DependencyProperty.Register(PRTPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string PRTPropertyName = "PRT";
         public string PRT
         {
             get { return (string)this.GetValue(PRTProperty); }
             set { this.SetValue(PRTProperty, value); }
         }

         public static readonly DependencyProperty DISPProperty = DependencyProperty.Register(DISPPropertyName, typeof(string), typeof(SYM_CE_ESD_DI_01)); 
         public const string DISPPropertyName = "DISP";
         public string DISP
         {
             get { return (string)this.GetValue(DISPProperty); }
             set { this.SetValue(DISPProperty, value); }
         }

		
		
    }
}
