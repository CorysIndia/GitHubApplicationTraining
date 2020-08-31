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
    public class Pipeline : RSIControlModel
    {
        static Pipeline()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Pipeline), new FrameworkPropertyMetadata(typeof(Pipeline)));
        }

		public Pipeline()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Pipeline));

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
        /// Line Property
        /// </summary>
        public static readonly DependencyProperty LineProperty =
            DependencyProperty.Register("Line", typeof(string), typeof(Pipeline));

        /// <summary>
        /// Gets or sets the Line.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Line
        {
            get { return (string)this.GetValue(LineProperty); }
            set { this.SetValue(LineProperty, value); }
        }


		
		
    }
}
