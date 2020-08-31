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
    public class SYM_CE_ESD_DO_01 : RSIControlModel
    {
        static SYM_CE_ESD_DO_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CE_ESD_DO_01), new FrameworkPropertyMetadata(typeof(SYM_CE_ESD_DO_01)));
        }

		public SYM_CE_ESD_DO_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CE_ESD_DO_01));

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


		
         public static readonly DependencyProperty BLK_TRPProperty = DependencyProperty.Register(BLK_TRPPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string BLK_TRPPropertyName = "BLK_TRP";
         public string BLK_TRP
         {
             get { return (string)this.GetValue(BLK_TRPProperty); }
             set { this.SetValue(BLK_TRPProperty, value); }
         }

         public static readonly DependencyProperty CMP_TRPProperty = DependencyProperty.Register(CMP_TRPPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string CMP_TRPPropertyName = "CMP_TRP";
         public string CMP_TRP
         {
             get { return (string)this.GetValue(CMP_TRPProperty); }
             set { this.SetValue(CMP_TRPProperty, value); }
         }

         public static readonly DependencyProperty BLK_RSTProperty = DependencyProperty.Register(BLK_RSTPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string BLK_RSTPropertyName = "BLK_RST";
         public string BLK_RST
         {
             get { return (string)this.GetValue(BLK_RSTProperty); }
             set { this.SetValue(BLK_RSTProperty, value); }
         }

         public static readonly DependencyProperty PRTProperty = DependencyProperty.Register(PRTPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string PRTPropertyName = "PRT";
         public string PRT
         {
             get { return (string)this.GetValue(PRTProperty); }
             set { this.SetValue(PRTProperty, value); }
         }

         public static readonly DependencyProperty DISPProperty = DependencyProperty.Register(DISPPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string DISPPropertyName = "DISP";
         public string DISP
         {
             get { return (string)this.GetValue(DISPProperty); }
             set { this.SetValue(DISPProperty, value); }
         }

         public static readonly DependencyProperty CMP_RSTProperty = DependencyProperty.Register(CMP_RSTPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string CMP_RSTPropertyName = "CMP_RST";
         public string CMP_RST
         {
             get { return (string)this.GetValue(CMP_RSTProperty); }
             set { this.SetValue(CMP_RSTProperty, value); }
         }

         public static readonly DependencyProperty PAR_RSTProperty = DependencyProperty.Register(PAR_RSTPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01)); 
         public const string PAR_RSTPropertyName = "PAR_RST";
         public string PAR_RST
         {
             get { return (string)this.GetValue(PAR_RSTProperty); }
             set { this.SetValue(PAR_RSTProperty, value); }
         }

        public static readonly DependencyProperty RESETProperty = DependencyProperty.Register(RESETPropertyPropertyName, typeof(string), typeof(SYM_CE_ESD_DO_01));
        public const string RESETPropertyPropertyName = "RESET";
        public string RESET
        {
            get { return (string)this.GetValue(RESETProperty); }
            set { this.SetValue(RESETProperty, value); }
        }


    }
}
