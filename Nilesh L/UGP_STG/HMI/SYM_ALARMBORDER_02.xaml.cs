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
    public class SYM_ALARMBORDER_02 : RSIControlModel
    {
        static SYM_ALARMBORDER_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALARMBORDER_02), new FrameworkPropertyMetadata(typeof(SYM_ALARMBORDER_02)));
        }

		public SYM_ALARMBORDER_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALARMBORDER_02));

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
        /// _CONN1 Property
        /// </summary>
        public static readonly DependencyProperty _CONN1Property =
            DependencyProperty.Register("_CONN1", typeof(int), typeof(SYM_ALARMBORDER_02));

        /// <summary>
        /// Gets or sets the _CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _CONN1
        {
            get { return (int)this.GetValue(_CONN1Property); }
            set { this.SetValue(_CONN1Property, value); }
        }


		
		
    }
}
