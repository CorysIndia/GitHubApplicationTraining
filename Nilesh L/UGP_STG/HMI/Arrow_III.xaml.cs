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
    public class Arrow_III : RSIControlModel
    {
        static Arrow_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Arrow_III), new FrameworkPropertyMetadata(typeof(Arrow_III)));
        }

		public Arrow_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Arrow_III));

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
            DependencyProperty.Register("Value", typeof(bool), typeof(Arrow_III));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"If value True")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Fillcolor Property
        /// </summary>
        public static readonly DependencyProperty FillcolorProperty =
            DependencyProperty.Register("Fillcolor", typeof(string), typeof(Arrow_III));

        /// <summary>
        /// Gets or sets the Fillcolor.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This is the color when value is true.  The color may be one of the following: Dark Red, Dark Blue, Cyan, Orange or White.")]
        public string Fillcolor
        {
            get { return (string)this.GetValue(FillcolorProperty); }
            set { this.SetValue(FillcolorProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Fillcolor)) yield return new Param("$Fillcolor", this.Fillcolor);

            }
        }

		
    }
}
