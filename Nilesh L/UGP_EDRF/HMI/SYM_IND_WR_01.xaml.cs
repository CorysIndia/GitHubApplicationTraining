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
    public class SYM_IND_WR_01 : RSIControlModel
    {
        static SYM_IND_WR_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_IND_WR_01), new FrameworkPropertyMetadata(typeof(SYM_IND_WR_01)));
        }

		public SYM_IND_WR_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_IND_WR_01));

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


		
         public static readonly DependencyProperty LOOP_IDProperty = DependencyProperty.Register(LOOP_IDPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string LOOP_IDPropertyName = "LOOP_ID";
         public string LOOP_ID
         {
             get { return (string)this.GetValue(LOOP_IDProperty); }
             set { this.SetValue(LOOP_IDProperty, value); }
         }

         public static readonly DependencyProperty TAGNAMEProperty = DependencyProperty.Register(TAGNAMEPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string TAGNAMEPropertyName = "TAGNAME";
         public string TAGNAME
         {
             get { return (string)this.GetValue(TAGNAMEProperty); }
             set { this.SetValue(TAGNAMEProperty, value); }
         }

         public static readonly DependencyProperty PRTProperty = DependencyProperty.Register(PRTPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string PRTPropertyName = "PRT";
         public string PRT
         {
             get { return (string)this.GetValue(PRTProperty); }
             set { this.SetValue(PRTProperty, value); }
         }

         public static readonly DependencyProperty CMPProperty = DependencyProperty.Register(CMPPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string CMPPropertyName = "CMP";
         public string CMP
         {
             get { return (string)this.GetValue(CMPProperty); }
             set { this.SetValue(CMPProperty, value); }
         }

         public static readonly DependencyProperty BLKProperty = DependencyProperty.Register(BLKPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string BLKPropertyName = "BLK";
         public string BLK
         {
             get { return (string)this.GetValue(BLKProperty); }
             set { this.SetValue(BLKProperty, value); }
         }

         public static readonly DependencyProperty PARProperty = DependencyProperty.Register(PARPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string PARPropertyName = "PAR";
         public string PAR
         {
             get { return (string)this.GetValue(PARProperty); }
             set { this.SetValue(PARProperty, value); }
         }

         public static readonly DependencyProperty LOCProperty = DependencyProperty.Register(LOCPropertyName, typeof(string), typeof(SYM_IND_WR_01)); 
         public const string LOCPropertyName = "LOC";
         public string LOC
         {
             get { return (string)this.GetValue(LOCProperty); }
             set { this.SetValue(LOCProperty, value); }
         }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(LabelPropertyName, typeof(string), typeof(SYM_IND_WR_01));
        public const string LabelPropertyName = "Label";
        public string Label
        {
            get { return (string)this.GetValue(LabelProperty); }
            set { this.SetValue(LabelProperty, value); }
        }




        public static readonly DependencyProperty OverlayProperty = DependencyProperty.Register(OverlayPropertyName, typeof(string), typeof(SYM_IND_WR_01));
        public const string OverlayPropertyName = "Overlay";
        public string Overlay
        {
            get { return (string)this.GetValue(OverlayProperty); }
            set { this.SetValue(OverlayProperty, value); }
        }



    }
}
