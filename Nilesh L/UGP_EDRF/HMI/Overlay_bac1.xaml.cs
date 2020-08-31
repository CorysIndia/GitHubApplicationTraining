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
    public class Overlay_bac1 : RSIControlModel
    {
        static Overlay_bac1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Overlay_bac1), new FrameworkPropertyMetadata(typeof(Overlay_bac1)));
        }

		public Overlay_bac1()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Overlay_bac1));

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
        /// Background_Disp1_Train Property
        /// </summary>
        public static readonly DependencyProperty Background_Disp1_TrainProperty =
            DependencyProperty.Register("Background_Disp1_Train", typeof(string), typeof(Overlay_bac1));

        /// <summary>
        /// Gets or sets the Background_Disp1_Train.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Background_Disp1_Train
        {
            get { return (string)this.GetValue(Background_Disp1_TrainProperty); }
            set { this.SetValue(Background_Disp1_TrainProperty, value); }
        }


		
		
    }
}
