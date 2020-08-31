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
    public class Timer1_CCS : RSIControlModel
    {
        static Timer1_CCS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Timer1_CCS), new FrameworkPropertyMetadata(typeof(Timer1_CCS)));
        }

		public Timer1_CCS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Timer1_CCS));

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
        /// DisplayDigit6 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit6Property =
            DependencyProperty.Register("DisplayDigit6", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit6
        {
            get { return (string)this.GetValue(DisplayDigit6Property); }
            set { this.SetValue(DisplayDigit6Property, value); }
        }

        /// <summary>
        /// DisplayDigit5 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit5Property =
            DependencyProperty.Register("DisplayDigit5", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit5
        {
            get { return (string)this.GetValue(DisplayDigit5Property); }
            set { this.SetValue(DisplayDigit5Property, value); }
        }

        /// <summary>
        /// DisplayDigit4 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit4Property =
            DependencyProperty.Register("DisplayDigit4", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit4
        {
            get { return (string)this.GetValue(DisplayDigit4Property); }
            set { this.SetValue(DisplayDigit4Property, value); }
        }

        /// <summary>
        /// DisplayDigit3 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit3Property =
            DependencyProperty.Register("DisplayDigit3", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit3
        {
            get { return (string)this.GetValue(DisplayDigit3Property); }
            set { this.SetValue(DisplayDigit3Property, value); }
        }

        /// <summary>
        /// DisplayDigit2 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit2Property =
            DependencyProperty.Register("DisplayDigit2", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit2
        {
            get { return (string)this.GetValue(DisplayDigit2Property); }
            set { this.SetValue(DisplayDigit2Property, value); }
        }

        /// <summary>
        /// DisplayDigit1 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit1Property =
            DependencyProperty.Register("DisplayDigit1", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit1
        {
            get { return (string)this.GetValue(DisplayDigit1Property); }
            set { this.SetValue(DisplayDigit1Property, value); }
        }

        /// <summary>
        /// DisplayColor Property
        /// </summary>
        public static readonly DependencyProperty DisplayColorProperty =
            DependencyProperty.Register("DisplayColor", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayColor.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This set the color of the display.  The color may be one of the following: Red, Green, Blue, Yellow, Orange, Brown, White, or Gray.")]
        public string DisplayColor
        {
            get { return (string)this.GetValue(DisplayColorProperty); }
            set { this.SetValue(DisplayColorProperty, value); }
        }

        /// <summary>
        /// DisplayDigit7 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit7Property =
            DependencyProperty.Register("DisplayDigit7", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit7.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit7
        {
            get { return (string)this.GetValue(DisplayDigit7Property); }
            set { this.SetValue(DisplayDigit7Property, value); }
        }

        /// <summary>
        /// DisplayDigit8 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit8Property =
            DependencyProperty.Register("DisplayDigit8", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit8.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit8
        {
            get { return (string)this.GetValue(DisplayDigit8Property); }
            set { this.SetValue(DisplayDigit8Property, value); }
        }

        /// <summary>
        /// DisplayDigit9 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit9Property =
            DependencyProperty.Register("DisplayDigit9", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit9.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit9
        {
            get { return (string)this.GetValue(DisplayDigit9Property); }
            set { this.SetValue(DisplayDigit9Property, value); }
        }

        /// <summary>
        /// DisplayDigit10 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit10Property =
            DependencyProperty.Register("DisplayDigit10", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit10.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit10
        {
            get { return (string)this.GetValue(DisplayDigit10Property); }
            set { this.SetValue(DisplayDigit10Property, value); }
        }

        /// <summary>
        /// LCDStyle Property
        /// </summary>
        public static readonly DependencyProperty LCDStyleProperty =
            DependencyProperty.Register("LCDStyle", typeof(bool), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the LCDStyle.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Displays the characters in LCD Style (Black on Color).")]
        public bool LCDStyle
        {
            get { return (bool)this.GetValue(LCDStyleProperty); }
            set { this.SetValue(LCDStyleProperty, value); }
        }

        /// <summary>
        /// BlinkDisplay Property
        /// </summary>
        public static readonly DependencyProperty BlinkDisplayProperty =
            DependencyProperty.Register("BlinkDisplay", typeof(bool), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the BlinkDisplay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Causes the display to blink.")]
        public bool BlinkDisplay
        {
            get { return (bool)this.GetValue(BlinkDisplayProperty); }
            set { this.SetValue(BlinkDisplayProperty, value); }
        }

        /// <summary>
        /// ElapsedTime Property
        /// </summary>
        public static readonly DependencyProperty ElapsedTimeProperty =
            DependencyProperty.Register("ElapsedTime", typeof(TimeSpan), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the ElapsedTime.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Elapsed time to display.")]
        public TimeSpan ElapsedTime
        {
            get { return (TimeSpan)this.GetValue(ElapsedTimeProperty); }
            set { this.SetValue(ElapsedTimeProperty, value); }
        }

        /// <summary>
        /// DisplayDigit11 Property
        /// </summary>
        public static readonly DependencyProperty DisplayDigit11Property =
            DependencyProperty.Register("DisplayDigit11", typeof(string), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the DisplayDigit11.  
        /// </summary>
		[Category("RSI")]
        [Description(@"7 Segment LED Character.")]
        public string DisplayDigit11
        {
            get { return (string)this.GetValue(DisplayDigit11Property); }
            set { this.SetValue(DisplayDigit11Property, value); }
        }

        /// <summary>
        /// Err Property
        /// </summary>
        public static readonly DependencyProperty ErrProperty =
            DependencyProperty.Register("Err", typeof(bool), typeof(Timer1_CCS));

        /// <summary>
        /// Gets or sets the Err.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal tracking for error. (Used here as a place holder, not actually used by this symbol).")]
        public bool Err
        {
            get { return (bool)this.GetValue(ErrProperty); }
            set { this.SetValue(ErrProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.DisplayDigit6)) yield return new Param("$DisplayDigit6", this.DisplayDigit6);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit5)) yield return new Param("$DisplayDigit5", this.DisplayDigit5);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit4)) yield return new Param("$DisplayDigit4", this.DisplayDigit4);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit3)) yield return new Param("$DisplayDigit3", this.DisplayDigit3);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit2)) yield return new Param("$DisplayDigit2", this.DisplayDigit2);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit1)) yield return new Param("$DisplayDigit1", this.DisplayDigit1);
if (!string.IsNullOrWhiteSpace(this.DisplayColor)) yield return new Param("$DisplayColor", this.DisplayColor);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit7)) yield return new Param("$DisplayDigit7", this.DisplayDigit7);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit8)) yield return new Param("$DisplayDigit8", this.DisplayDigit8);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit9)) yield return new Param("$DisplayDigit9", this.DisplayDigit9);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit10)) yield return new Param("$DisplayDigit10", this.DisplayDigit10);
if (!string.IsNullOrWhiteSpace(this.DisplayDigit11)) yield return new Param("$DisplayDigit11", this.DisplayDigit11);

            }
        }

		
    }
}
