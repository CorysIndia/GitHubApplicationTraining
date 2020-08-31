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
    public class SYM_ZV_01 : RSIControlModel
    {
        static SYM_ZV_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ZV_01), new FrameworkPropertyMetadata(typeof(SYM_ZV_01)));
        }

		public SYM_ZV_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ZV_01));

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


		
         public static readonly DependencyProperty TAGNAMEProperty = DependencyProperty.Register(TAGNAMEPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string TAGNAMEPropertyName = "TAGNAME";
         public string TAGNAME
         {
             get { return (string)this.GetValue(TAGNAMEProperty); }
             set { this.SetValue(TAGNAMEProperty, value); }
         }

         public static readonly DependencyProperty LOOP_IDProperty = DependencyProperty.Register(LOOP_IDPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string LOOP_IDPropertyName = "LOOP_ID";
         public string LOOP_ID
         {
             get { return (string)this.GetValue(LOOP_IDProperty); }
             set { this.SetValue(LOOP_IDProperty, value); }
         }

         public static readonly DependencyProperty CMPProperty = DependencyProperty.Register(CMPPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string CMPPropertyName = "CMP";
         public string CMP
         {
             get { return (string)this.GetValue(CMPProperty); }
             set { this.SetValue(CMPProperty, value); }
         }

         public static readonly DependencyProperty PRTProperty = DependencyProperty.Register(PRTPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string PRTPropertyName = "PRT";
         public string PRT
         {
             get { return (string)this.GetValue(PRTProperty); }
             set { this.SetValue(PRTProperty, value); }
         }

         public static readonly DependencyProperty LOCProperty = DependencyProperty.Register(LOCPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string LOCPropertyName = "LOC";
         public string LOC
         {
             get { return (string)this.GetValue(LOCProperty); }
             set { this.SetValue(LOCProperty, value); }
         }

         public static readonly DependencyProperty VLV_IDProperty = DependencyProperty.Register(VLV_IDPropertyName, typeof(string), typeof(SYM_ZV_01)); 
         public const string VLV_IDPropertyName = "VLV_ID";
         public string VLV_ID
         {
             get { return (string)this.GetValue(VLV_IDProperty); }
             set { this.SetValue(VLV_IDProperty, value); }
         }

        public static readonly DependencyProperty FAILProperty = DependencyProperty.Register(FAILPropertyName, typeof(string), typeof(SYM_ZV_01));
        public const string FAILPropertyName = "FAIL";
        public string FAIL
        {
            get { return (string)this.GetValue(FAILProperty); }
            set { this.SetValue(FAILProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(OrientationPropertyName, typeof(string), typeof(SYM_ZV_01));
        public const string OrientationPropertyName = "Orientation";
        public string Orientation
        {
            get { return (string)this.GetValue(OrientationProperty); }
            set { this.SetValue(OrientationProperty, value); }
        }


    }
}
