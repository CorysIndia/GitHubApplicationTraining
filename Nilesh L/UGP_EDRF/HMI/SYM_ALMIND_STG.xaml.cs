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
    public class SYM_ALMIND_STG : RSIControlModel
    {
        static SYM_ALMIND_STG()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALMIND_STG), new FrameworkPropertyMetadata(typeof(SYM_ALMIND_STG)));
        }

		public SYM_ALMIND_STG()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALMIND_STG));

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


		
         public static readonly DependencyProperty TAGNAMEProperty = DependencyProperty.Register(TAGNAMEPropertyName, typeof(string), typeof(SYM_ALMIND_STG)); 
         public const string TAGNAMEPropertyName = "TAGNAME";
         public string TAGNAME
         {
             get { return (string)this.GetValue(TAGNAMEProperty); }
             set { this.SetValue(TAGNAMEProperty, value); }
         }

         public static readonly DependencyProperty CMPProperty = DependencyProperty.Register(CMPPropertyName, typeof(string), typeof(SYM_ALMIND_STG)); 
         public const string CMPPropertyName = "CMP";
         public string CMP
         {
             get { return (string)this.GetValue(CMPProperty); }
             set { this.SetValue(CMPProperty, value); }
         }

         public static readonly DependencyProperty BLKProperty = DependencyProperty.Register(BLKPropertyName, typeof(string), typeof(SYM_ALMIND_STG)); 
         public const string BLKPropertyName = "BLK";
         public string BLK
         {
             get { return (string)this.GetValue(BLKProperty); }
             set { this.SetValue(BLKProperty, value); }
         }

         public static readonly DependencyProperty LOOP_IDProperty = DependencyProperty.Register(LOOP_IDPropertyName, typeof(string), typeof(SYM_ALMIND_STG)); 
         public const string LOOP_IDPropertyName = "LOOP_ID";
         public string LOOP_ID
         {
             get { return (string)this.GetValue(LOOP_IDProperty); }
             set { this.SetValue(LOOP_IDProperty, value); }
         }

         public static readonly DependencyProperty BITProperty = DependencyProperty.Register(BITPropertyName, typeof(string), typeof(SYM_ALMIND_STG)); 
         public const string BITPropertyName = "BIT";
         public string BIT
         {
             get { return (string)this.GetValue(BITProperty); }
             set { this.SetValue(BITProperty, value); }
         }

        public static readonly DependencyProperty TAGProperty = DependencyProperty.Register(TAGPropertyName, typeof(string), typeof(SYM_ALMIND_STG));
        public const string TAGPropertyName = "TAG";
        public string TAG
        {
            get { return (string)this.GetValue(TAGProperty); }
            set { this.SetValue(TAGProperty, value); }
        }

    }
}
