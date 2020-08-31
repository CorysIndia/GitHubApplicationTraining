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
    public class dIndTxt_01 : RSIControlModel
    {
        static dIndTxt_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(dIndTxt_01), new FrameworkPropertyMetadata(typeof(dIndTxt_01)));
        }

		public dIndTxt_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(dIndTxt_01));

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
        /// ModeInt Property
        /// </summary>
        public static readonly DependencyProperty ModeIntProperty =
            DependencyProperty.Register("ModeInt", typeof(int), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the ModeInt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of integer to change the text description.")]
        public int ModeInt
        {
            get { return (int)this.GetValue(ModeIntProperty); }
            set { this.SetValue(ModeIntProperty, value); }
        }

        /// <summary>
        /// TxtColGreen Property
        /// </summary>
        public static readonly DependencyProperty TxtColGreenProperty =
            DependencyProperty.Register("TxtColGreen", typeof(bool), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the TxtColGreen.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname or expression to change the Value text color.
When True, Value text is Green.")]
        public bool TxtColGreen
        {
            get { return (bool)this.GetValue(TxtColGreenProperty); }
            set { this.SetValue(TxtColGreenProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname, expression or a value of 'true' when Int#Txt needs to blink.")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }

        /// <summary>
        /// Int00Txt Property
        /// </summary>
        public static readonly DependencyProperty Int00TxtProperty =
            DependencyProperty.Register("Int00Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int00Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 0.")]
        public string Int00Txt
        {
            get { return (string)this.GetValue(Int00TxtProperty); }
            set { this.SetValue(Int00TxtProperty, value); }
        }

        /// <summary>
        /// Int01Txt Property
        /// </summary>
        public static readonly DependencyProperty Int01TxtProperty =
            DependencyProperty.Register("Int01Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int01Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 1.")]
        public string Int01Txt
        {
            get { return (string)this.GetValue(Int01TxtProperty); }
            set { this.SetValue(Int01TxtProperty, value); }
        }

        /// <summary>
        /// Int02Txt Property
        /// </summary>
        public static readonly DependencyProperty Int02TxtProperty =
            DependencyProperty.Register("Int02Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int02Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 2.")]
        public string Int02Txt
        {
            get { return (string)this.GetValue(Int02TxtProperty); }
            set { this.SetValue(Int02TxtProperty, value); }
        }

        /// <summary>
        /// Int03Txt Property
        /// </summary>
        public static readonly DependencyProperty Int03TxtProperty =
            DependencyProperty.Register("Int03Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int03Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 3.")]
        public string Int03Txt
        {
            get { return (string)this.GetValue(Int03TxtProperty); }
            set { this.SetValue(Int03TxtProperty, value); }
        }

        /// <summary>
        /// Int04Txt Property
        /// </summary>
        public static readonly DependencyProperty Int04TxtProperty =
            DependencyProperty.Register("Int04Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int04Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 4.")]
        public string Int04Txt
        {
            get { return (string)this.GetValue(Int04TxtProperty); }
            set { this.SetValue(Int04TxtProperty, value); }
        }

        /// <summary>
        /// Int05Txt Property
        /// </summary>
        public static readonly DependencyProperty Int05TxtProperty =
            DependencyProperty.Register("Int05Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int05Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 5.")]
        public string Int05Txt
        {
            get { return (string)this.GetValue(Int05TxtProperty); }
            set { this.SetValue(Int05TxtProperty, value); }
        }

        /// <summary>
        /// Int06Txt Property
        /// </summary>
        public static readonly DependencyProperty Int06TxtProperty =
            DependencyProperty.Register("Int06Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int06Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 6.")]
        public string Int06Txt
        {
            get { return (string)this.GetValue(Int06TxtProperty); }
            set { this.SetValue(Int06TxtProperty, value); }
        }

        /// <summary>
        /// Int07Txt Property
        /// </summary>
        public static readonly DependencyProperty Int07TxtProperty =
            DependencyProperty.Register("Int07Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int07Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 7.")]
        public string Int07Txt
        {
            get { return (string)this.GetValue(Int07TxtProperty); }
            set { this.SetValue(Int07TxtProperty, value); }
        }

        /// <summary>
        /// Int08Txt Property
        /// </summary>
        public static readonly DependencyProperty Int08TxtProperty =
            DependencyProperty.Register("Int08Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int08Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 8.")]
        public string Int08Txt
        {
            get { return (string)this.GetValue(Int08TxtProperty); }
            set { this.SetValue(Int08TxtProperty, value); }
        }

        /// <summary>
        /// Int09Txt Property
        /// </summary>
        public static readonly DependencyProperty Int09TxtProperty =
            DependencyProperty.Register("Int09Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int09Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 9.")]
        public string Int09Txt
        {
            get { return (string)this.GetValue(Int09TxtProperty); }
            set { this.SetValue(Int09TxtProperty, value); }
        }

        /// <summary>
        /// Int10Txt Property
        /// </summary>
        public static readonly DependencyProperty Int10TxtProperty =
            DependencyProperty.Register("Int10Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int10Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 10.")]
        public string Int10Txt
        {
            get { return (string)this.GetValue(Int10TxtProperty); }
            set { this.SetValue(Int10TxtProperty, value); }
        }

        /// <summary>
        /// Int11Txt Property
        /// </summary>
        public static readonly DependencyProperty Int11TxtProperty =
            DependencyProperty.Register("Int11Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int11Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 11.")]
        public string Int11Txt
        {
            get { return (string)this.GetValue(Int11TxtProperty); }
            set { this.SetValue(Int11TxtProperty, value); }
        }

        /// <summary>
        /// Int12Txt Property
        /// </summary>
        public static readonly DependencyProperty Int12TxtProperty =
            DependencyProperty.Register("Int12Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int12Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 12.")]
        public string Int12Txt
        {
            get { return (string)this.GetValue(Int12TxtProperty); }
            set { this.SetValue(Int12TxtProperty, value); }
        }

        /// <summary>
        /// Int13Txt Property
        /// </summary>
        public static readonly DependencyProperty Int13TxtProperty =
            DependencyProperty.Register("Int13Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int13Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 13.")]
        public string Int13Txt
        {
            get { return (string)this.GetValue(Int13TxtProperty); }
            set { this.SetValue(Int13TxtProperty, value); }
        }

        /// <summary>
        /// Int14Txt Property
        /// </summary>
        public static readonly DependencyProperty Int14TxtProperty =
            DependencyProperty.Register("Int14Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int14Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 14.")]
        public string Int14Txt
        {
            get { return (string)this.GetValue(Int14TxtProperty); }
            set { this.SetValue(Int14TxtProperty, value); }
        }

        /// <summary>
        /// Int15Txt Property
        /// </summary>
        public static readonly DependencyProperty Int15TxtProperty =
            DependencyProperty.Register("Int15Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int15Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 15.")]
        public string Int15Txt
        {
            get { return (string)this.GetValue(Int15TxtProperty); }
            set { this.SetValue(Int15TxtProperty, value); }
        }

        /// <summary>
        /// Int16Txt Property
        /// </summary>
        public static readonly DependencyProperty Int16TxtProperty =
            DependencyProperty.Register("Int16Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int16Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 16.")]
        public string Int16Txt
        {
            get { return (string)this.GetValue(Int16TxtProperty); }
            set { this.SetValue(Int16TxtProperty, value); }
        }

        /// <summary>
        /// Int17Txt Property
        /// </summary>
        public static readonly DependencyProperty Int17TxtProperty =
            DependencyProperty.Register("Int17Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int17Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 17.")]
        public string Int17Txt
        {
            get { return (string)this.GetValue(Int17TxtProperty); }
            set { this.SetValue(Int17TxtProperty, value); }
        }

        /// <summary>
        /// Int18Txt Property
        /// </summary>
        public static readonly DependencyProperty Int18TxtProperty =
            DependencyProperty.Register("Int18Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int18Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 18.")]
        public string Int18Txt
        {
            get { return (string)this.GetValue(Int18TxtProperty); }
            set { this.SetValue(Int18TxtProperty, value); }
        }

        /// <summary>
        /// Int19Txt Property
        /// </summary>
        public static readonly DependencyProperty Int19TxtProperty =
            DependencyProperty.Register("Int19Txt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the Int19Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 19.")]
        public string Int19Txt
        {
            get { return (string)this.GetValue(Int19TxtProperty); }
            set { this.SetValue(Int19TxtProperty, value); }
        }

        /// <summary>
        /// TxtColYellow Property
        /// </summary>
        public static readonly DependencyProperty TxtColYellowProperty =
            DependencyProperty.Register("TxtColYellow", typeof(bool), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the TxtColYellow.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname or expression to change the Value text color.
When True, Value text is Yellow.")]
        public bool TxtColYellow
        {
            get { return (bool)this.GetValue(TxtColYellowProperty); }
            set { this.SetValue(TxtColYellowProperty, value); }
        }

        /// <summary>
        /// TxtColRed Property
        /// </summary>
        public static readonly DependencyProperty TxtColRedProperty =
            DependencyProperty.Register("TxtColRed", typeof(bool), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the TxtColRed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname or expression to change the Value text color.
When True, Value text is Red.")]
        public bool TxtColRed
        {
            get { return (bool)this.GetValue(TxtColRedProperty); }
            set { this.SetValue(TxtColRedProperty, value); }
        }

        /// <summary>
        /// ModeTxt Property
        /// </summary>
        public static readonly DependencyProperty ModeTxtProperty =
            DependencyProperty.Register("ModeTxt", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the ModeTxt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal Variable used to select which Int#txt to select.")]
        public string ModeTxt
        {
            get { return (string)this.GetValue(ModeTxtProperty); }
            set { this.SetValue(ModeTxtProperty, value); }
        }

        /// <summary>
        /// TxtCol Property
        /// </summary>
        public static readonly DependencyProperty TxtColProperty =
            DependencyProperty.Register("TxtCol", typeof(string), typeof(dIndTxt_01));

        /// <summary>
        /// Gets or sets the TxtCol.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Used as an internal variable to select which color to display for the description.")]
        public string TxtCol
        {
            get { return (string)this.GetValue(TxtColProperty); }
            set { this.SetValue(TxtColProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Int00Txt)) yield return new Param("$Int00Txt", this.Int00Txt);
if (!string.IsNullOrWhiteSpace(this.Int01Txt)) yield return new Param("$Int01Txt", this.Int01Txt);
if (!string.IsNullOrWhiteSpace(this.Int02Txt)) yield return new Param("$Int02Txt", this.Int02Txt);
if (!string.IsNullOrWhiteSpace(this.Int03Txt)) yield return new Param("$Int03Txt", this.Int03Txt);
if (!string.IsNullOrWhiteSpace(this.Int04Txt)) yield return new Param("$Int04Txt", this.Int04Txt);
if (!string.IsNullOrWhiteSpace(this.Int05Txt)) yield return new Param("$Int05Txt", this.Int05Txt);
if (!string.IsNullOrWhiteSpace(this.Int06Txt)) yield return new Param("$Int06Txt", this.Int06Txt);
if (!string.IsNullOrWhiteSpace(this.Int07Txt)) yield return new Param("$Int07Txt", this.Int07Txt);
if (!string.IsNullOrWhiteSpace(this.Int08Txt)) yield return new Param("$Int08Txt", this.Int08Txt);
if (!string.IsNullOrWhiteSpace(this.Int09Txt)) yield return new Param("$Int09Txt", this.Int09Txt);
if (!string.IsNullOrWhiteSpace(this.Int10Txt)) yield return new Param("$Int10Txt", this.Int10Txt);
if (!string.IsNullOrWhiteSpace(this.Int11Txt)) yield return new Param("$Int11Txt", this.Int11Txt);
if (!string.IsNullOrWhiteSpace(this.Int12Txt)) yield return new Param("$Int12Txt", this.Int12Txt);
if (!string.IsNullOrWhiteSpace(this.Int13Txt)) yield return new Param("$Int13Txt", this.Int13Txt);
if (!string.IsNullOrWhiteSpace(this.Int14Txt)) yield return new Param("$Int14Txt", this.Int14Txt);
if (!string.IsNullOrWhiteSpace(this.Int15Txt)) yield return new Param("$Int15Txt", this.Int15Txt);
if (!string.IsNullOrWhiteSpace(this.Int16Txt)) yield return new Param("$Int16Txt", this.Int16Txt);
if (!string.IsNullOrWhiteSpace(this.Int17Txt)) yield return new Param("$Int17Txt", this.Int17Txt);
if (!string.IsNullOrWhiteSpace(this.Int18Txt)) yield return new Param("$Int18Txt", this.Int18Txt);
if (!string.IsNullOrWhiteSpace(this.Int19Txt)) yield return new Param("$Int19Txt", this.Int19Txt);
if (!string.IsNullOrWhiteSpace(this.ModeTxt)) yield return new Param("$ModeTxt", this.ModeTxt);
if (!string.IsNullOrWhiteSpace(this.TxtCol)) yield return new Param("$TxtCol", this.TxtCol);

            }
        }

		
    }
}
