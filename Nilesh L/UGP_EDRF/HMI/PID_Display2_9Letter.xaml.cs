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
    public class PID_Display2_9Letter : RSIControlModel
    {
        static PID_Display2_9Letter()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PID_Display2_9Letter), new FrameworkPropertyMetadata(typeof(PID_Display2_9Letter)));
        }

		public PID_Display2_9Letter()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PID_Display2_9Letter));

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
        /// Pushed Property
        /// </summary>
        public static readonly DependencyProperty PushedProperty =
            DependencyProperty.Register("Pushed", typeof(bool), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the Pushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal tracking of when the button is pushed.")]
        public bool Pushed
        {
            get { return (bool)this.GetValue(PushedProperty); }
            set { this.SetValue(PushedProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string NameStore
        {
            get { return (string)this.GetValue(NameStoreProperty); }
            set { this.SetValue(NameStoreProperty, value); }
        }

        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display the value")]
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Auto Property
        /// </summary>
        public static readonly DependencyProperty AutoProperty =
            DependencyProperty.Register("Auto", typeof(bool), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the Auto.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Auto
False - Partial")]
        public bool Auto
        {
            get { return (bool)this.GetValue(AutoProperty); }
            set { this.SetValue(AutoProperty, value); }
        }

        /// <summary>
        /// FullManual Property
        /// </summary>
        public static readonly DependencyProperty FullManualProperty =
            DependencyProperty.Register("FullManual", typeof(bool), typeof(PID_Display2_9Letter));

        /// <summary>
        /// Gets or sets the FullManual.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Full Manual
False - Partial Manual")]
        public bool FullManual
        {
            get { return (bool)this.GetValue(FullManualProperty); }
            set { this.SetValue(FullManualProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);
                if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);


            }
        }

		
    }
}
