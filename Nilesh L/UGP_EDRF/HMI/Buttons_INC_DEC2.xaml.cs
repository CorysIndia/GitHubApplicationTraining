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
    public class Buttons_INC_DEC2 : RSIControlModel
    {
        static Buttons_INC_DEC2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Buttons_INC_DEC2), new FrameworkPropertyMetadata(typeof(Buttons_INC_DEC2)));
        }

		public Buttons_INC_DEC2()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Buttons_INC_DEC2));

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
        /// PV Property
        /// </summary>
        public static readonly DependencyProperty PVProperty =
            DependencyProperty.Register("PV", typeof(double), typeof(Buttons_INC_DEC2));

        /// <summary>
        /// Gets or sets the PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV
        {
            get { return (double)this.GetValue(PVProperty); }
            set { this.SetValue(PVProperty, value); }
        }

        /// <summary>
        /// PV_Min Property
        /// </summary>
        public static readonly DependencyProperty PV_MinProperty =
            DependencyProperty.Register("PV_Min", typeof(double), typeof(Buttons_INC_DEC2));

        /// <summary>
        /// Gets or sets the PV_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV_Min
        {
            get { return (double)this.GetValue(PV_MinProperty); }
            set { this.SetValue(PV_MinProperty, value); }
        }

        /// <summary>
        /// PV_Max Property
        /// </summary>
        public static readonly DependencyProperty PV_MaxProperty =
            DependencyProperty.Register("PV_Max", typeof(double), typeof(Buttons_INC_DEC2));

        /// <summary>
        /// Gets or sets the PV_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV_Max
        {
            get { return (double)this.GetValue(PV_MaxProperty); }
            set { this.SetValue(PV_MaxProperty, value); }
        }

        /// <summary>
        /// option Property
        /// </summary>
        public static readonly DependencyProperty optionProperty =
            DependencyProperty.Register("option", typeof(string), typeof(Buttons_INC_DEC2));

        /// <summary>
        /// Gets or sets the option.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string option
        {
            get { return (string)this.GetValue(optionProperty); }
            set { this.SetValue(optionProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.option)) yield return new Param("$option", this.option);

            }
        }

		
    }
}
