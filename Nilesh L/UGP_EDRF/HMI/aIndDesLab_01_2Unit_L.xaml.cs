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
    public class aIndDesLab_01_2Unit_L : RSIControlModel
    {
        static aIndDesLab_01_2Unit_L()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(aIndDesLab_01_2Unit_L), new FrameworkPropertyMetadata(typeof(aIndDesLab_01_2Unit_L)));
        }

		public aIndDesLab_01_2Unit_L()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(aIndDesLab_01_2Unit_L));

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
        /// ZTAG Property
        /// </summary>
        public static readonly DependencyProperty ZTAGProperty =
            DependencyProperty.Register("ZTAG", typeof(string), typeof(aIndDesLab_01_2Unit_L));

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
        /// TIMER01 Property
        /// </summary>
        public static readonly DependencyProperty TIMER01Property =
            DependencyProperty.Register("TIMER01", typeof(string), typeof(aIndDesLab_01_2Unit_L));

        /// <summary>
        /// Gets or sets the TIMER01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER01
        {
            get { return (string)this.GetValue(TIMER01Property); }
            set { this.SetValue(TIMER01Property, value); }
        }

        /// <summary>
        /// TIMER02 Property
        /// </summary>
        public static readonly DependencyProperty TIMER02Property =
            DependencyProperty.Register("TIMER02", typeof(string), typeof(aIndDesLab_01_2Unit_L));

        /// <summary>
        /// Gets or sets the TIMER02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TIMER02
        {
            get { return (string)this.GetValue(TIMER02Property); }
            set { this.SetValue(TIMER02Property, value); }
        }

        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(aIndDesLab_01_2Unit_L));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put Total Warm-up timer in Second r-tag here ")]
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.TIMER01)) yield return new Param("$TIMER01", this.TIMER01);
                if (!string.IsNullOrWhiteSpace(this.TIMER02)) yield return new Param("$TIMER02", this.TIMER02);
                if (!string.IsNullOrWhiteSpace(this.ZTAG)) yield return new Param("$ZTAG", this.ZTAG);


            }
        }





    }
}
