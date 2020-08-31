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
    public class ButtonIndicative_Conf_N1 : RSIControlModel
    {
        static ButtonIndicative_Conf_N1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonIndicative_Conf_N1), new FrameworkPropertyMetadata(typeof(ButtonIndicative_Conf_N1)));
        }

		public ButtonIndicative_Conf_N1()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ButtonIndicative_Conf_N1));

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
        /// Pushed Property
        /// </summary>
        public static readonly DependencyProperty PushedProperty =
            DependencyProperty.Register("Pushed", typeof(bool), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the Pushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Pushed
        {
            get { return (bool)this.GetValue(PushedProperty); }
            set { this.SetValue(PushedProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NameStore
        {
            get { return (string)this.GetValue(NameStoreProperty); }
            set { this.SetValue(NameStoreProperty, value); }
        }

        /// <summary>
        /// Colour Property
        /// </summary>
        public static readonly DependencyProperty ColourProperty =
            DependencyProperty.Register("Colour", typeof(int), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int Colour
        {
            get { return (int)this.GetValue(ColourProperty); }
            set { this.SetValue(ColourProperty, value); }
        }

        /// <summary>
        /// ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty ConfirmationMessageProperty =
            DependencyProperty.Register("ConfirmationMessage", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the ConfirmationMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the confirmation message
")]
        public string ConfirmationMessage
        {
            get { return (string)this.GetValue(ConfirmationMessageProperty); }
            set { this.SetValue(ConfirmationMessageProperty, value); }
        }

        /// <summary>
        /// fTagName Property
        /// </summary>
        public static readonly DependencyProperty fTagNameProperty =
            DependencyProperty.Register("fTagName", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the fTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use fTag.Name")]
        public string fTagName
        {
            get { return (string)this.GetValue(fTagNameProperty); }
            set { this.SetValue(fTagNameProperty, value); }
        }

        /// <summary>
        /// gTagName Property
        /// </summary>
        public static readonly DependencyProperty gTagNameProperty =
            DependencyProperty.Register("gTagName", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the gTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use gTag.Name")]
        public string gTagName
        {
            get { return (string)this.GetValue(gTagNameProperty); }
            set { this.SetValue(gTagNameProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Feedback Property
        /// </summary>
        public static readonly DependencyProperty FeedbackProperty =
            DependencyProperty.Register("Feedback", typeof(bool), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Feedback
        {
            get { return (bool)this.GetValue(FeedbackProperty); }
            set { this.SetValue(FeedbackProperty, value); }
        }

        /// <summary>
        /// LeftName Property
        /// </summary>
        public static readonly DependencyProperty LeftNameProperty =
            DependencyProperty.Register("LeftName", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the LeftName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LeftName
        {
            get { return (string)this.GetValue(LeftNameProperty); }
            set { this.SetValue(LeftNameProperty, value); }
        }

        /// <summary>
        /// RightName Property
        /// </summary>
        public static readonly DependencyProperty RightNameProperty =
            DependencyProperty.Register("RightName", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the RightName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RightName
        {
            get { return (string)this.GetValue(RightNameProperty); }
            set { this.SetValue(RightNameProperty, value); }
        }

        /// <summary>
        /// Overlay Property
        /// </summary>
        public static readonly DependencyProperty OverlayProperty =
            DependencyProperty.Register("Overlay", typeof(string), typeof(ButtonIndicative_Conf_N1));

        /// <summary>
        /// Gets or sets the Overlay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay
        {
            get { return (string)this.GetValue(OverlayProperty); }
            set { this.SetValue(OverlayProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);
if (!string.IsNullOrWhiteSpace(this.ConfirmationMessage)) yield return new Param("$ConfirmationMessage", this.ConfirmationMessage);
if (!string.IsNullOrWhiteSpace(this.fTagName)) yield return new Param("$fTagName", this.fTagName);
if (!string.IsNullOrWhiteSpace(this.gTagName)) yield return new Param("$gTagName", this.gTagName);
if (!string.IsNullOrWhiteSpace(this.LeftName)) yield return new Param("$LeftName", this.LeftName);
if (!string.IsNullOrWhiteSpace(this.RightName)) yield return new Param("$RightName", this.RightName);

            }
        }

		
    }
}
