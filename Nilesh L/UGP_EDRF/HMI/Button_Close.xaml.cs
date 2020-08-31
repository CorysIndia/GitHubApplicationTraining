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
    public class Button_Close : RSIControlModel
    {
        static Button_Close()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Button_Close), new FrameworkPropertyMetadata(typeof(Button_Close)));
        }

		public Button_Close()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Button_Close));

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
        /// CON1 Property
        /// </summary>
        public static readonly DependencyProperty CON1Property =
            DependencyProperty.Register("CON1", typeof(bool), typeof(Button_Close));

        /// <summary>
        /// Gets or sets the CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CON1
        {
            get { return (bool)this.GetValue(CON1Property); }
            set { this.SetValue(CON1Property, value); }
        }


		
		
    }
}
