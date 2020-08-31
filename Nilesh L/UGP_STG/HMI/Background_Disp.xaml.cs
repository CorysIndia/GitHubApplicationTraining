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
    public class Background_Disp : RSIControlModel
    {
        static Background_Disp()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Background_Disp), new FrameworkPropertyMetadata(typeof(Background_Disp)));
        }

		public Background_Disp()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Background_Disp));

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
        /// Train Property
        /// </summary>
        public static readonly DependencyProperty TrainProperty =
            DependencyProperty.Register("Train", typeof(string), typeof(Background_Disp));

        /// <summary>
        /// Gets or sets the Train.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Train
        {
            get { return (string)this.GetValue(TrainProperty); }
            set { this.SetValue(TrainProperty, value); }
        }


		
        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
				foreach (var p in base.IndissLikeParameters)
				{
					yield return p;
				}

				if (!string.IsNullOrWhiteSpace(this.Train)) yield return new Param("$Train", this.Train);

            }
        }

		
    }
}
