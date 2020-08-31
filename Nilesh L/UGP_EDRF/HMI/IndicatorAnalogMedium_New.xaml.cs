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
    public class IndicatorAnalogMedium_New : RSIControlModel
    {
        static IndicatorAnalogMedium_New()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IndicatorAnalogMedium_New), new FrameworkPropertyMetadata(typeof(IndicatorAnalogMedium_New)));
        }

		public IndicatorAnalogMedium_New()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(IndicatorAnalogMedium_New));

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
            DependencyProperty.Register("Value", typeof(double), typeof(IndicatorAnalogMedium_New));

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
            DependencyProperty.Register("Alarm", typeof(bool), typeof(IndicatorAnalogMedium_New));

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
            DependencyProperty.Register("Selected", typeof(bool), typeof(IndicatorAnalogMedium_New));

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
        /// ZUNIT Property
        /// </summary>
        public static readonly DependencyProperty ZUNITProperty =
            DependencyProperty.Register("ZUNIT", typeof(string), typeof(IndicatorAnalogMedium_New));

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
        /// ZDECRIPTION Property
        /// </summary>
        public static readonly DependencyProperty ZDECRIPTIONProperty =
            DependencyProperty.Register("ZDECRIPTION", typeof(string), typeof(IndicatorAnalogMedium_New));

        /// <summary>
        /// Gets or sets the ZDECRIPTION.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZDECRIPTION
        {
            get { return (string)this.GetValue(ZDECRIPTIONProperty); }
            set { this.SetValue(ZDECRIPTIONProperty, value); }
        }

        /// <summary>
        /// TRXHI Property
        /// </summary>
        public static readonly DependencyProperty TRXHIProperty =
            DependencyProperty.Register("TRXHI", typeof(bool), typeof(IndicatorAnalogMedium_New));

        /// <summary>
        /// Gets or sets the TRXHI.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRXHI
        {
            get { return (bool)this.GetValue(TRXHIProperty); }
            set { this.SetValue(TRXHIProperty, value); }
        }

        /// <summary>
        /// TRXLO Property
        /// </summary>
        public static readonly DependencyProperty TRXLOProperty =
            DependencyProperty.Register("TRXLO", typeof(bool), typeof(IndicatorAnalogMedium_New));

        /// <summary>
        /// Gets or sets the TRXLO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRXLO
        {
            get { return (bool)this.GetValue(TRXLOProperty); }
            set { this.SetValue(TRXLOProperty, value); }
        }

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
                foreach (var p in base.IndissLikeParameters)
                {
                    yield return p;
                }

                if (!string.IsNullOrWhiteSpace(this.ZUNIT)) yield return new Param("$ZUNIT", this.ZUNIT);

                if (!string.IsNullOrWhiteSpace(this.ZDECRIPTION)) yield return new Param("$ZDECRIPTION", this.ZDECRIPTION);

            }
        }


    }
}
