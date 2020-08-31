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
    public class Valve_a : RSIControlModel
    {
        static Valve_a()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Valve_a), new FrameworkPropertyMetadata(typeof(Valve_a)));
        }

		public Valve_a()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Valve_a));

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
            DependencyProperty.Register("Value", typeof(bool), typeof(Valve_a));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates Valve is Openned.")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// FillColor Property
        /// </summary>
        public static readonly DependencyProperty FillColorProperty =
            DependencyProperty.Register("FillColor", typeof(string), typeof(Valve_a));

        /// <summary>
        /// Gets or sets the FillColor.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This is the color when value is true.  The color may be one of the following: Red, Green, Blue, Yellow, Orange, Brown, or Gray.")]
        public string FillColor
        {
            get { return (string)this.GetValue(FillColorProperty); }
            set { this.SetValue(FillColorProperty, value); }
        }

        /// <summary>
        /// DisplayColor Property
        /// </summary>
        public static readonly DependencyProperty DisplayColorProperty =
            DependencyProperty.Register("DisplayColor", typeof(string), typeof(Valve_a));

        /// <summary>
        /// Gets or sets the DisplayColor.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal sets the display color.")]
        public string DisplayColor
        {
            get { return (string)this.GetValue(DisplayColorProperty); }
            set { this.SetValue(DisplayColorProperty, value); }
        }

        /// <summary>
        /// ScriptTrigger Property
        /// </summary>
        public static readonly DependencyProperty ScriptTriggerProperty =
            DependencyProperty.Register("ScriptTrigger", typeof(bool), typeof(Valve_a));

        /// <summary>
        /// Gets or sets the ScriptTrigger.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal invokes color calculation.")]
        public bool ScriptTrigger
        {
            get { return (bool)this.GetValue(ScriptTriggerProperty); }
            set { this.SetValue(ScriptTriggerProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.FillColor)) yield return new Param("$FillColor", this.FillColor);
if (!string.IsNullOrWhiteSpace(this.DisplayColor)) yield return new Param("$DisplayColor", this.DisplayColor);

            }
        }

		
    }
}
