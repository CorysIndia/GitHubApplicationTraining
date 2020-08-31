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
    public class IndicatorAnalogMedium_LED_New : RSIControlModel
    {
        static IndicatorAnalogMedium_LED_New()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IndicatorAnalogMedium_LED_New), new FrameworkPropertyMetadata(typeof(IndicatorAnalogMedium_LED_New)));
        }

		public IndicatorAnalogMedium_LED_New()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(IndicatorAnalogMedium_LED_New));

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
            DependencyProperty.Register("Value", typeof(double), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool Selected
        {
            get { return (bool)this.GetValue(SelectedProperty); }
            set { this.SetValue(SelectedProperty, value); }
        }

        /// <summary>
        /// ZDescription01 Property
        /// </summary>
        public static readonly DependencyProperty ZDescription01Property =
            DependencyProperty.Register("ZDescription01", typeof(string), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the ZDescription01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZDescription01
        {
            get { return (string)this.GetValue(ZDescription01Property); }
            set { this.SetValue(ZDescription01Property, value); }
        }

        /// <summary>
        /// State Property
        /// </summary>
        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(bool), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the State.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True==> Lighted up")]
        public bool State
        {
            get { return (bool)this.GetValue(StateProperty); }
            set { this.SetValue(StateProperty, value); }
        }

        /// <summary>
        /// ZUNIT Property
        /// </summary>
        public static readonly DependencyProperty ZUNITProperty =
            DependencyProperty.Register("ZUNIT", typeof(string), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the ZUNIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUNIT
        {
            get { return (string)this.GetValue(ZUNITProperty); }
            set { this.SetValue(ZUNITProperty, value); }
        }


        /// <summary>
        /// ZBOX Property
        /// </summary>
        public static readonly DependencyProperty ZBOXProperty =
            DependencyProperty.Register("ZBOX", typeof(string), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the ZBOX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZBOX
        {
            get { return (string)this.GetValue(ZBOXProperty); }
            set { this.SetValue(ZBOXProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(IndicatorAnalogMedium_LED_New));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.ZDescription01)) yield return new Param("$ZDescription01", this.ZDescription01);
                if (!string.IsNullOrWhiteSpace(this.ZUNIT)) yield return new Param("$ZUNIT", this.ZUNIT);
                if (!string.IsNullOrWhiteSpace(this.ZBOX)) yield return new Param("$ZBOX", this.ZBOX);






            }
        }


    }
}
