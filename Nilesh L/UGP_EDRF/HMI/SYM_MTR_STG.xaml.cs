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
    public class SYM_MTR_STG : RSIControlModel
    {
        static SYM_MTR_STG()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_MTR_STG), new FrameworkPropertyMetadata(typeof(SYM_MTR_STG)));
        }

		public SYM_MTR_STG()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_MTR_STG));

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


		
         public static readonly DependencyProperty TAGNAMEProperty = DependencyProperty.Register(TAGNAMEPropertyName, typeof(string), typeof(SYM_MTR_STG)); 
         public const string TAGNAMEPropertyName = "TAGNAME";
         public string TAGNAME
         {
             get { return (string)this.GetValue(TAGNAMEProperty); }
             set { this.SetValue(TAGNAMEProperty, value); }
         }

         public static readonly DependencyProperty BLKProperty = DependencyProperty.Register(BLKPropertyName, typeof(string), typeof(SYM_MTR_STG)); 
         public const string BLKPropertyName = "BLK";
         public string BLK
         {
             get { return (string)this.GetValue(BLKProperty); }
             set { this.SetValue(BLKProperty, value); }
         }

         public static readonly DependencyProperty CMPProperty = DependencyProperty.Register(CMPPropertyName, typeof(string), typeof(SYM_MTR_STG)); 
         public const string CMPPropertyName = "CMP";
         public string CMP
         {
             get { return (string)this.GetValue(CMPProperty); }
             set { this.SetValue(CMPProperty, value); }
         }

         public static readonly DependencyProperty BLK_REMProperty = DependencyProperty.Register(BLK_REMPropertyName, typeof(string), typeof(SYM_MTR_STG)); 
         public const string BLK_REMPropertyName = "BLK_REM";
         public string BLK_REM
         {
             get { return (string)this.GetValue(BLK_REMProperty); }
             set { this.SetValue(BLK_REMProperty, value); }
         }

        public static readonly DependencyProperty INDICATIONSProperty = DependencyProperty.Register(INDICATIONSPropertyName, typeof(string), typeof(SYM_MTR_STG));
        public const string INDICATIONSPropertyName = "INDICATIONS";
        public string INDICATIONS
        {
            get { return (string)this.GetValue(INDICATIONSProperty); }
            set { this.SetValue(INDICATIONSProperty, value); }
        }       

    }
}
