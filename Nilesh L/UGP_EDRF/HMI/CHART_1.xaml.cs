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
    public class CHART_1 : RSIControlModel
    {
        static CHART_1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CHART_1), new FrameworkPropertyMetadata(typeof(CHART_1)));
        }

		public CHART_1()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(CHART_1));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(int), typeof(CHART_1));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PAR
        {
            get { return (int)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// STEP_NO Property
        /// </summary>
        public static readonly DependencyProperty STEP_NOProperty =
            DependencyProperty.Register("STEP_NO", typeof(int), typeof(CHART_1));

        /// <summary>
        /// Gets or sets the STEP_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int STEP_NO
        {
            get { return (int)this.GetValue(STEP_NOProperty); }
            set { this.SetValue(STEP_NOProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(CHART_1));

        /// <summary>
        /// Gets or sets the BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK
        {
            get { return (string)this.GetValue(BLKProperty); }
            set { this.SetValue(BLKProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);

            }
        }

		
    }
}
