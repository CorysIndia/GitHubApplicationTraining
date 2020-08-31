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
    public class Timer2_CCS : RSIControlModel
    {
        static Timer2_CCS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Timer2_CCS), new FrameworkPropertyMetadata(typeof(Timer2_CCS)));
        }

		public Timer2_CCS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Timer2_CCS));

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
        /// ElapsedTime Property
        /// </summary>
        public static readonly DependencyProperty ElapsedTimeProperty =
            DependencyProperty.Register("ElapsedTime", typeof(TimeSpan), typeof(Timer2_CCS));

        /// <summary>
        /// Gets or sets the ElapsedTime.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public TimeSpan ElapsedTime
        {
            get { return (TimeSpan)this.GetValue(ElapsedTimeProperty); }
            set { this.SetValue(ElapsedTimeProperty, value); }
        }

        /// <summary>
        /// DisplayDigit4 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit4Property =
            DependencyProperty.Register("DisplayDigit4", typeof(string), typeof(Timer2_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DisplayDigit4
        {
            get { return (string)this.GetValue(DisplayDigit4Property); }
            set { this.SetValue(DisplayDigit4Property, value); }
        }

        /// <summary>
        /// DisplayDigit5 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit5Property =
            DependencyProperty.Register("DisplayDigit5", typeof(string), typeof(Timer2_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DisplayDigit5
        {
            get { return (string)this.GetValue(DisplayDigit5Property); }
            set { this.SetValue(DisplayDigit5Property, value); }
        }

        /// <summary>
        /// DisplayDigit6 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit6Property =
            DependencyProperty.Register("DisplayDigit6", typeof(string), typeof(Timer2_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DisplayDigit6
        {
            get { return (string)this.GetValue(DisplayDigit6Property); }
            set { this.SetValue(DisplayDigit6Property, value); }
        }

        /// <summary>
        /// DisplayDigit7 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit7Property =
            DependencyProperty.Register("DisplayDigit7", typeof(string), typeof(Timer2_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit7.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DisplayDigit7
        {
            get { return (string)this.GetValue(DisplayDigit7Property); }
            set { this.SetValue(DisplayDigit7Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.DisplayDigit4)) yield return new Param("$DisplayDigit4", this.DisplayDigit4);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit5)) yield return new Param("$DisplayDigit5", this.DisplayDigit5);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit6)) yield return new Param("$DisplayDigit6", this.DisplayDigit6);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit7)) yield return new Param("$DisplayDigit7", this.DisplayDigit7);

            }
        }

		
    }
}
