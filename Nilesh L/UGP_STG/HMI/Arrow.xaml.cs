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
    public class Arrow : RSIControlModel
    {
        static Arrow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Arrow), new FrameworkPropertyMetadata(typeof(Arrow)));
        }

		public Arrow()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Arrow));

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
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(Arrow));

        /// <summary>
        /// Gets or sets the Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type
        {
            get { return (string)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
        }


		
		
    }
}
