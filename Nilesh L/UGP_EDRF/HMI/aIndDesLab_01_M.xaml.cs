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
    public class aIndDesLab_01_M : RSIControlModel
    {
        static aIndDesLab_01_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(aIndDesLab_01_M), new FrameworkPropertyMetadata(typeof(aIndDesLab_01_M)));
        }

		public aIndDesLab_01_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(aIndDesLab_01_M));

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
            DependencyProperty.Register("Value", typeof(double), typeof(aIndDesLab_01_M));

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
            DependencyProperty.Register("Alarm", typeof(bool), typeof(aIndDesLab_01_M));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(aIndDesLab_01_M));

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
        /// DESCR Property
        /// </summary>
        public static readonly DependencyProperty DESCRProperty =
            DependencyProperty.Register("DESCR", typeof(string), typeof(aIndDesLab_01_M));

        /// <summary>
        /// Gets or sets the DESCR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCR
        {
            get { return (string)this.GetValue(DESCRProperty); }
            set { this.SetValue(DESCRProperty, value); }
        }

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(aIndDesLab_01_M));

        /// <summary>
        /// Gets or sets the TAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG
        {
            get { return (string)this.GetValue(TAGProperty); }
            set { this.SetValue(TAGProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.DESCR)) yield return new Param("$DESCR", this.DESCR);
                if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);
            }
        }
    }
}
