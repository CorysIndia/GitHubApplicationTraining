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
    public class button_cout : RSIControlModel
    {
        static button_cout()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(button_cout), new FrameworkPropertyMetadata(typeof(button_cout)));
        }

		public button_cout()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(button_cout));

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
        /// _COUT Property
        /// </summary>
        public static readonly DependencyProperty _COUTProperty =
            DependencyProperty.Register("_COUT", typeof(bool), typeof(button_cout));

        /// <summary>
        /// Gets or sets the _COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _COUT
        {
            get { return (bool)this.GetValue(_COUTProperty); }
            set { this.SetValue(_COUTProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(button_cout));

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

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(button_cout));

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
        /// _IN Property
        /// </summary>
        public static readonly DependencyProperty _INProperty =
            DependencyProperty.Register("_IN", typeof(bool), typeof(button_cout));

        /// <summary>
        /// Gets or sets the _IN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _IN
        {
            get { return (bool)this.GetValue(_INProperty); }
            set { this.SetValue(_INProperty, value); }
        }

        /// <summary>
        /// TEXT0 Property
        /// </summary>
        public static readonly DependencyProperty TEXT0Property =
            DependencyProperty.Register("TEXT0", typeof(string), typeof(button_cout));

        /// <summary>
        /// Gets or sets the TEXT0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT0
        {
            get { return (string)this.GetValue(TEXT0Property); }
            set { this.SetValue(TEXT0Property, value); }
        }

        /// <summary>
        /// TEXT1 Property
        /// </summary>
        public static readonly DependencyProperty TEXT1Property =
            DependencyProperty.Register("TEXT1", typeof(string), typeof(button_cout));

        /// <summary>
        /// Gets or sets the TEXT1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT1
        {
            get { return (string)this.GetValue(TEXT1Property); }
            set { this.SetValue(TEXT1Property, value); }
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
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.TEXT0)) yield return new Param("$TEXT0", this.TEXT0);
if (!string.IsNullOrWhiteSpace(this.TEXT1)) yield return new Param("$TEXT1", this.TEXT1);

            }
        }

		
    }
}
