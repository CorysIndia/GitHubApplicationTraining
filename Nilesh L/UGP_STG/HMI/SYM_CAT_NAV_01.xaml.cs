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
    public class SYM_CAT_NAV_01 : RSIControlModel
    {
        static SYM_CAT_NAV_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CAT_NAV_01), new FrameworkPropertyMetadata(typeof(SYM_CAT_NAV_01)));
        }

		public SYM_CAT_NAV_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CAT_NAV_01));

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


		
         public static readonly DependencyProperty DISPProperty = DependencyProperty.Register(DISPPropertyName, typeof(string), typeof(SYM_CAT_NAV_01)); 
         public const string DISPPropertyName = "DISP";
         public string DISP
         {
             get { return (string)this.GetValue(DISPProperty); }
             set { this.SetValue(DISPProperty, value); }
         }

         public static readonly DependencyProperty PRTProperty = DependencyProperty.Register(PRTPropertyName, typeof(string), typeof(SYM_CAT_NAV_01)); 
         public const string PRTPropertyName = "PRT";
         public string PRT
         {
             get { return (string)this.GetValue(PRTProperty); }
             set { this.SetValue(PRTProperty, value); }
         }

        public static readonly DependencyProperty BorderProperty = DependencyProperty.Register(BorderPropertyName, typeof(string), typeof(SYM_CAT_NAV_01));
        public const string BorderPropertyName = "Border";
        public string Border
        {
            get { return (string)this.GetValue(BorderProperty); }
            set { this.SetValue(BorderProperty, value); }
        }

    }
}
