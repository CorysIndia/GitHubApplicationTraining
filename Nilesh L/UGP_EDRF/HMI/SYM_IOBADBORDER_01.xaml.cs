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
    public class SYM_IOBADBORDER_01 : RSIControlModel
    {
        static SYM_IOBADBORDER_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_IOBADBORDER_01), new FrameworkPropertyMetadata(typeof(SYM_IOBADBORDER_01)));
        }

		public SYM_IOBADBORDER_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_IOBADBORDER_01));

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
        /// BAD Property
        /// </summary>
        public static readonly DependencyProperty BADProperty =
            DependencyProperty.Register("BAD", typeof(bool), typeof(SYM_IOBADBORDER_01));

        /// <summary>
        /// Gets or sets the BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BAD
        {
            get { return (bool)this.GetValue(BADProperty); }
            set { this.SetValue(BADProperty, value); }
        }


		
		
    }
}
