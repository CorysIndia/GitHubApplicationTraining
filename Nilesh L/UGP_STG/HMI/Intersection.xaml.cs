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
    public class Intersection : RSIControlModel
    {
        static Intersection()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Intersection), new FrameworkPropertyMetadata(typeof(Intersection)));
        }

		public Intersection()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Intersection));

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
        /// intersection Property
        /// </summary>
        public static readonly DependencyProperty intersectionProperty =
            DependencyProperty.Register("intersection", typeof(string), typeof(Intersection));

        /// <summary>
        /// Gets or sets the intersection.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string intersection
        {
            get { return (string)this.GetValue(intersectionProperty); }
            set { this.SetValue(intersectionProperty, value); }
        }


		
		
    }
}
