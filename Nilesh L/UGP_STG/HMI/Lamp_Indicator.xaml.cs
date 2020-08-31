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
    public class Lamp_Indicator : RSIControlModel
    {
        static Lamp_Indicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Lamp_Indicator), new FrameworkPropertyMetadata(typeof(Lamp_Indicator)));
        }

		public Lamp_Indicator()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Lamp_Indicator));

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
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(bool), typeof(Lamp_Indicator));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bright green when True, dark green when False")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(Lamp_Indicator));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Light will blink when Blink and Value are True")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }

        /// <summary>
        /// Color Property
        /// </summary>
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(string), typeof(Lamp_Indicator));

        /// <summary>
        /// Gets or sets the Color.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Color
        {
            get { return (string)this.GetValue(ColorProperty); }
            set { this.SetValue(ColorProperty, value); }
        }


		
		
    }
}
