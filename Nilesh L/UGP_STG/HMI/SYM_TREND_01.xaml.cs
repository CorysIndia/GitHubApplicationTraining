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
    public class SYM_TREND_01 : RSIControlModel
    {
        static SYM_TREND_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_TREND_01), new FrameworkPropertyMetadata(typeof(SYM_TREND_01)));
        }

		public SYM_TREND_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_TREND_01));

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
        /// CBP1 Property
        /// </summary>
        public static readonly DependencyProperty CBP1Property =
            DependencyProperty.Register("CBP1", typeof(string), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the CBP1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"BLOCK   (Do not include the parameter. The parameter used depends on the TrendType property)")]
        public string CBP1
        {
            get { return (string)this.GetValue(CBP1Property); }
            set { this.SetValue(CBP1Property, value); }
        }

        /// <summary>
        /// SERVER Property
        /// </summary>
        public static readonly DependencyProperty SERVERProperty =
            DependencyProperty.Register("SERVER", typeof(string), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the SERVER.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Name of the Historian Server")]
        public string SERVER
        {
            get { return (string)this.GetValue(SERVERProperty); }
            set { this.SetValue(SERVERProperty, value); }
        }

        /// <summary>
        /// Delay Property
        /// </summary>
        public static readonly DependencyProperty DelayProperty =
            DependencyProperty.Register("Delay", typeof(bool), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the Delay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Delay
        {
            get { return (bool)this.GetValue(DelayProperty); }
            set { this.SetValue(DelayProperty, value); }
        }

        /// <summary>
        /// CBP4 Property
        /// </summary>
        public static readonly DependencyProperty CBP4Property =
            DependencyProperty.Register("CBP4", typeof(string), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the CBP4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP4
        {
            get { return (string)this.GetValue(CBP4Property); }
            set { this.SetValue(CBP4Property, value); }
        }

        /// <summary>
        /// CBP3 Property
        /// </summary>
        public static readonly DependencyProperty CBP3Property =
            DependencyProperty.Register("CBP3", typeof(string), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the CBP3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP3
        {
            get { return (string)this.GetValue(CBP3Property); }
            set { this.SetValue(CBP3Property, value); }
        }

        /// <summary>
        /// CBP2 Property
        /// </summary>
        public static readonly DependencyProperty CBP2Property =
            DependencyProperty.Register("CBP2", typeof(string), typeof(SYM_TREND_01));

        /// <summary>
        /// Gets or sets the CBP2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP2
        {
            get { return (string)this.GetValue(CBP2Property); }
            set { this.SetValue(CBP2Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CBP1)) yield return new Param("$CBP1", this.CBP1);
if (!string.IsNullOrWhiteSpace(this.SERVER)) yield return new Param("$SERVER", this.SERVER);
if (!string.IsNullOrWhiteSpace(this.CBP4)) yield return new Param("$CBP4", this.CBP4);
if (!string.IsNullOrWhiteSpace(this.CBP3)) yield return new Param("$CBP3", this.CBP3);
if (!string.IsNullOrWhiteSpace(this.CBP2)) yield return new Param("$CBP2", this.CBP2);

            }
        }

		
    }
}
