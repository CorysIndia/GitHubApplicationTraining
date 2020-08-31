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
    public class IndicatorAnalogV_Small_New : RSIControlModel
    {
        static IndicatorAnalogV_Small_New()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IndicatorAnalogV_Small_New), new FrameworkPropertyMetadata(typeof(IndicatorAnalogV_Small_New)));
        }

		public IndicatorAnalogV_Small_New()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(IndicatorAnalogV_Small_New));

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
            DependencyProperty.Register("Value", typeof(double), typeof(IndicatorAnalogV_Small_New));

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
            DependencyProperty.Register("Alarm", typeof(bool), typeof(IndicatorAnalogV_Small_New));

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
        /// ZTAG Property
        /// </summary>
        public static readonly DependencyProperty ZTAGProperty =
            DependencyProperty.Register("ZTAG", typeof(string), typeof(IndicatorAnalogV_Small_New));

        /// <summary>
        /// Gets or sets the ZTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTAG
        {
            get { return (string)this.GetValue(ZTAGProperty); }
            set { this.SetValue(ZTAGProperty, value); }
        }

        /// <summary>
        /// ZUNIT Property
        /// </summary>
        public static readonly DependencyProperty ZUNITProperty =
            DependencyProperty.Register("ZUNIT", typeof(string), typeof(IndicatorAnalogV_Small_New));

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
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(IndicatorAnalogV_Small_New));

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

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
                foreach (var p in base.IndissLikeParameters)
                {
                    yield return p;
                }

                if (!string.IsNullOrWhiteSpace(this.ZTAG)) yield return new Param("$ZTAG", this.ZTAG);
                if (!string.IsNullOrWhiteSpace(this.ZUNIT)) yield return new Param("$ZUNIT", this.ZUNIT);



            }
        }




    }
}
