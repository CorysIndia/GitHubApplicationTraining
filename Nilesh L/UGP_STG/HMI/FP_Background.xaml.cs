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
    public class FP_Background : RSIControlModel
    {
        static FP_Background()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FP_Background), new FrameworkPropertyMetadata(typeof(FP_Background)));
        }

		public FP_Background()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(FP_Background));

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


		        /// <summary>
        /// TYPE Property
        /// </summary>
        public static readonly DependencyProperty TYPEProperty =
            DependencyProperty.Register("TYPE", typeof(string), typeof(FP_Background));

        /// <summary>
        /// Gets or sets the TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TYPE
        {
            get { return (string)this.GetValue(TYPEProperty); }
            set { this.SetValue(TYPEProperty, value); }
        }


		
		
    }
}
