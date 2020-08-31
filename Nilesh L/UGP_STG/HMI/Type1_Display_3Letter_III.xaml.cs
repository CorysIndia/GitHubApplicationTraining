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
    public class Type1_Display_3Letter_III : RSIControlModel
    {
        static Type1_Display_3Letter_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type1_Display_3Letter_III), new FrameworkPropertyMetadata(typeof(Type1_Display_3Letter_III)));
        }

		public Type1_Display_3Letter_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type1_Display_3Letter_III));

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
            DependencyProperty.Register("Value", typeof(bool), typeof(Type1_Display_3Letter_III));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Colour Property
        /// </summary>
        public static readonly DependencyProperty ColourProperty =
            DependencyProperty.Register("Colour", typeof(int), typeof(Type1_Display_3Letter_III));

        /// <summary>
        /// Gets or sets the Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int Colour
        {
            get { return (int)this.GetValue(ColourProperty); }
            set { this.SetValue(ColourProperty, value); }
        }

        /// <summary>
        /// Fail Property
        /// </summary>
        public static readonly DependencyProperty FailProperty =
            DependencyProperty.Register("Fail", typeof(bool), typeof(Type1_Display_3Letter_III));

        /// <summary>
        /// Gets or sets the Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Fail
        {
            get { return (bool)this.GetValue(FailProperty); }
            set { this.SetValue(FailProperty, value); }
        }


		
		
    }
}
