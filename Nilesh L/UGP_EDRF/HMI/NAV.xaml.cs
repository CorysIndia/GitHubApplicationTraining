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
    public class NAV : RSIControlModel
    {
        static NAV()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NAV), new FrameworkPropertyMetadata(typeof(NAV)));
        }

		public NAV()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(NAV));

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
        /// Display_Name Property
        /// </summary>
        public static readonly DependencyProperty Display_NameProperty =
            DependencyProperty.Register("Display_Name", typeof(string), typeof(NAV));

        /// <summary>
        /// Gets or sets the Display_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Display_Name
        {
            get { return (string)this.GetValue(Display_NameProperty); }
            set { this.SetValue(Display_NameProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(int), typeof(NAV));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRT
        {
            get { return (int)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// Direction Property
        /// </summary>
        public static readonly DependencyProperty DirectionProperty =
            DependencyProperty.Register("Direction", typeof(string), typeof(NAV));

        /// <summary>
        /// Gets or sets the Direction.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Direction
        {
            get { return (string)this.GetValue(DirectionProperty); }
            set { this.SetValue(DirectionProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Display_Name)) yield return new Param("$Display_Name", this.Display_Name);

            }
        }

		
    }
}
