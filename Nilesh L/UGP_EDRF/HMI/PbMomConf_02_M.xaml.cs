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
    public class PbMomConf_02_M : RSIControlModel
    {
        static PbMomConf_02_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PbMomConf_02_M), new FrameworkPropertyMetadata(typeof(PbMomConf_02_M)));
        }

		public PbMomConf_02_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PbMomConf_02_M));

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
            DependencyProperty.Register("DisableTag", typeof(bool), typeof(PbMomConf_02_M));

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
        /// ConfirmIndirect Property
        /// </summary>
        public static readonly DependencyProperty ConfirmIndirectProperty =
            DependencyProperty.Register("ConfirmIndirect", typeof(string), typeof(PbMomConf_02_M));

        /// <summary>
        /// Gets or sets the ConfirmIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gASCAM1.name")]
        public string ConfirmIndirect
        {
            get { return (string)this.GetValue(ConfirmIndirectProperty); }
            set { this.SetValue(ConfirmIndirectProperty, value); }
        }

        /// <summary>
        /// ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty ConfirmationMessageProperty =
            DependencyProperty.Register("ConfirmationMessage", typeof(string), typeof(PbMomConf_02_M));

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
            DependencyProperty.Register("Feedback", typeof(bool), typeof(PbMomConf_02_M));

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
        /// FeedbackIndirect Property
        /// </summary>
        public static readonly DependencyProperty FeedbackIndirectProperty =
            DependencyProperty.Register("FeedbackIndirect", typeof(string), typeof(PbMomConf_02_M));

        /// <summary>
        /// Gets or sets the FeedbackIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag indirect .name here
For example: fASCAM1.name")]
        public string FeedbackIndirect
        {
            get { return (string)this.GetValue(FeedbackIndirectProperty); }
            set { this.SetValue(FeedbackIndirectProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(PbMomConf_02_M));

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
            DependencyProperty.Register("Pushed", typeof(bool), typeof(PbMomConf_02_M));

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
            DependencyProperty.Register("WinSel", typeof(bool), typeof(PbMomConf_02_M));

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


		
        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
				foreach (var p in base.IndissLikeParameters)
				{
					yield return p;
				}

				if (!string.IsNullOrWhiteSpace(this.ConfirmIndirect)) yield return new Param("$ConfirmIndirect", this.ConfirmIndirect);
if (!string.IsNullOrWhiteSpace(this.ConfirmationMessage)) yield return new Param("$ConfirmationMessage", this.ConfirmationMessage);
if (!string.IsNullOrWhiteSpace(this.FeedbackIndirect)) yield return new Param("$FeedbackIndirect", this.FeedbackIndirect);
if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);

            }
        }

		
    }
}
