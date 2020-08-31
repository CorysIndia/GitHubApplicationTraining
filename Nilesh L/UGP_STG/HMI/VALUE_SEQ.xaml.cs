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
    public class VALUE_SEQ : RSIControlModel
    {
        static VALUE_SEQ()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VALUE_SEQ), new FrameworkPropertyMetadata(typeof(VALUE_SEQ)));
        }

		public VALUE_SEQ()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(VALUE_SEQ));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(VALUE_SEQ));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(VALUE_SEQ));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(VALUE_SEQ));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR
        {
            get { return (string)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// TEXT0 Property
        /// </summary>
        public static readonly DependencyProperty TEXT0Property =
            DependencyProperty.Register("TEXT0", typeof(string), typeof(VALUE_SEQ));

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
            DependencyProperty.Register("TEXT1", typeof(string), typeof(VALUE_SEQ));

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

        /// <summary>
        /// _PAR Property
        /// </summary>
        public static readonly DependencyProperty _PARProperty =
            DependencyProperty.Register("_PAR", typeof(bool), typeof(VALUE_SEQ));

        /// <summary>
        /// Gets or sets the _PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _PAR
        {
            get { return (bool)this.GetValue(_PARProperty); }
            set { this.SetValue(_PARProperty, value); }
        }

        /// <summary>
        /// FB Property
        /// </summary>
        public static readonly DependencyProperty FBProperty =
            DependencyProperty.Register("FB", typeof(string), typeof(VALUE_SEQ));

        /// <summary>
        /// Gets or sets the FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FB
        {
            get { return (string)this.GetValue(FBProperty); }
            set { this.SetValue(FBProperty, value); }
        }

        /// <summary>
        /// Variable_Text Property
        /// </summary>
        public static readonly DependencyProperty Variable_TextProperty =
            DependencyProperty.Register("Variable_Text", typeof(string), typeof(VALUE_SEQ));

        /// <summary>
        /// Gets or sets the Variable_Text.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Variable_Text
        {
            get { return (string)this.GetValue(Variable_TextProperty); }
            set { this.SetValue(Variable_TextProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
if (!string.IsNullOrWhiteSpace(this.TEXT0)) yield return new Param("$TEXT0", this.TEXT0);
if (!string.IsNullOrWhiteSpace(this.TEXT1)) yield return new Param("$TEXT1", this.TEXT1);

            }
        }

		
    }
}
