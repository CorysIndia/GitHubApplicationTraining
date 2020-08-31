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
    public class PbMomConf_02_S : RSIControlModel
    {
        static PbMomConf_02_S()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PbMomConf_02_S), new FrameworkPropertyMetadata(typeof(PbMomConf_02_S)));
        }

		public PbMomConf_02_S()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PbMomConf_02_S));

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
        /// DisableTag Property
        /// </summary>
        public static readonly DependencyProperty DisableTagProperty =
            DependencyProperty.Register("DisableTag", typeof(bool), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fASCAM1_DISHMI

True: disable button
False: enable button")]
        public bool DisableTag
        {
            get { return (bool)this.GetValue(DisableTagProperty); }
            set { this.SetValue(DisableTagProperty, value); }
        }

        /// <summary>
        /// gTagName Property
        /// </summary>
        public static readonly DependencyProperty gTagNameProperty =
            DependencyProperty.Register("gTagName", typeof(string), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the gTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gASCAM1.name")]
        public string gTagName
        {
            get { return (string)this.GetValue(gTagNameProperty); }
            set { this.SetValue(gTagNameProperty, value); }
        }

        /// <summary>
        /// ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty ConfirmationMessageProperty =
            DependencyProperty.Register("ConfirmationMessage", typeof(string), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the ConfirmationMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the confirmation message")]
        public string ConfirmationMessage
        {
            get { return (string)this.GetValue(ConfirmationMessageProperty); }
            set { this.SetValue(ConfirmationMessageProperty, value); }
        }

        /// <summary>
        /// Feedback Property
        /// </summary>
        public static readonly DependencyProperty FeedbackProperty =
            DependencyProperty.Register("Feedback", typeof(bool), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the feedback tagname f-tag here.
For example: fASCAM1")]
        public bool Feedback
        {
            get { return (bool)this.GetValue(FeedbackProperty); }
            set { this.SetValue(FeedbackProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string NameStore
        {
            get { return (string)this.GetValue(NameStoreProperty); }
            set { this.SetValue(NameStoreProperty, value); }
        }

        /// <summary>
        /// Pushed Property
        /// </summary>
        public static readonly DependencyProperty PushedProperty =
            DependencyProperty.Register("Pushed", typeof(bool), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the Pushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal tracking of when the button is pushed.")]
        public bool Pushed
        {
            get { return (bool)this.GetValue(PushedProperty); }
            set { this.SetValue(PushedProperty, value); }
        }

        /// <summary>
        /// WinSel Property
        /// </summary>
        public static readonly DependencyProperty WinSelProperty =
            DependencyProperty.Register("WinSel", typeof(bool), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the WinSel.  
        /// </summary>
		[Category("RSI")]
        [Description(@"If     NameStore == Intouch:zsWinOpen

then
        WinSel = True;

Else 
        WinSel = False;")]
        public bool WinSel
        {
            get { return (bool)this.GetValue(WinSelProperty); }
            set { this.SetValue(WinSelProperty, value); }
        }

        /// <summary>
        /// fTagName Property
        /// </summary>
        public static readonly DependencyProperty fTagNameProperty =
            DependencyProperty.Register("fTagName", typeof(string), typeof(PbMomConf_02_S));

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
        /// WinName Property
        /// </summary>
        public static readonly DependencyProperty WinNameProperty =
            DependencyProperty.Register("WinName", typeof(string), typeof(PbMomConf_02_S));

        /// <summary>
        /// Gets or sets the WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string WinName
        {
            get { return (string)this.GetValue(WinNameProperty); }
            set { this.SetValue(WinNameProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.gTagName)) yield return new Param("$gTagName", this.gTagName);
if (!string.IsNullOrWhiteSpace(this.ConfirmationMessage)) yield return new Param("$ConfirmationMessage", this.ConfirmationMessage);
if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);
if (!string.IsNullOrWhiteSpace(this.fTagName)) yield return new Param("$fTagName", this.fTagName);
if (!string.IsNullOrWhiteSpace(this.WinName)) yield return new Param("$WinName", this.WinName);

            }
        }

		
    }
}
