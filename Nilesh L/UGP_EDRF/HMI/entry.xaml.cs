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
    public class entry : RSIControlModel
    {
        static entry()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(entry), new FrameworkPropertyMetadata(typeof(entry)));
        }

		public entry()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(entry));

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
        /// MEAS Property
        /// </summary>
        public static readonly DependencyProperty MEASProperty =
            DependencyProperty.Register("MEAS", typeof(string), typeof(entry));

        /// <summary>
        /// Gets or sets the MEAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MEAS
        {
            get { return (string)this.GetValue(MEASProperty); }
            set { this.SetValue(MEASProperty, value); }
        }

        /// <summary>
        /// HSCO1 Property
        /// </summary>
        public static readonly DependencyProperty HSCO1Property =
            DependencyProperty.Register("HSCO1", typeof(double), typeof(entry));

        /// <summary>
        /// Gets or sets the HSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCO1
        {
            get { return (double)this.GetValue(HSCO1Property); }
            set { this.SetValue(HSCO1Property, value); }
        }

        /// <summary>
        /// LSCO1 Property
        /// </summary>
        public static readonly DependencyProperty LSCO1Property =
            DependencyProperty.Register("LSCO1", typeof(double), typeof(entry));

        /// <summary>
        /// Gets or sets the LSCO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCO1
        {
            get { return (double)this.GetValue(LSCO1Property); }
            set { this.SetValue(LSCO1Property, value); }
        }

        /// <summary>
        /// _OUT Property
        /// </summary>
        public static readonly DependencyProperty _OUTProperty =
            DependencyProperty.Register("_OUT", typeof(double), typeof(entry));

        /// <summary>
        /// Gets or sets the _OUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _OUT
        {
            get { return (double)this.GetValue(_OUTProperty); }
            set { this.SetValue(_OUTProperty, value); }
        }

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(entry));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(entry));

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

				if (!string.IsNullOrWhiteSpace(this.MEAS)) yield return new Param("$MEAS", this.MEAS);
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);

            }
        }

		
    }
}
