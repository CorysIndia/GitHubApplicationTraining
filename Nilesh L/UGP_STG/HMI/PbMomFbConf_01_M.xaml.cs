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
    public class PbMomFbConf_01_M : RSIControlModel
    {
        static PbMomFbConf_01_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PbMomFbConf_01_M), new FrameworkPropertyMetadata(typeof(PbMomFbConf_01_M)));
        }

		public PbMomFbConf_01_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PbMomFbConf_01_M));

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
        /// ButtonPressed Property
        /// </summary>
        public static readonly DependencyProperty ButtonPressedProperty =
            DependencyProperty.Register("ButtonPressed", typeof(bool), typeof(PbMomFbConf_01_M));

        /// <summary>
        /// Gets or sets the ButtonPressed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal for tracking ButtonAction.")]
        public bool ButtonPressed
        {
            get { return (bool)this.GetValue(ButtonPressedProperty); }
            set { this.SetValue(ButtonPressedProperty, value); }
        }

        /// <summary>
        /// Colour Property
        /// </summary>
        public static readonly DependencyProperty ColourProperty =
            DependencyProperty.Register("Colour", typeof(int), typeof(PbMomFbConf_01_M));

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
7 - Purple
8 - Grey")]
        public int Colour
        {
            get { return (int)this.GetValue(ColourProperty); }
            set { this.SetValue(ColourProperty, value); }
        }

        /// <summary>
        /// DisableTag Property
        /// </summary>
        public static readonly DependencyProperty DisableTagProperty =
            DependencyProperty.Register("DisableTag", typeof(bool), typeof(PbMomFbConf_01_M));

        /// <summary>
        /// Gets or sets the DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool DisableTag
        {
            get { return (bool)this.GetValue(DisableTagProperty); }
            set { this.SetValue(DisableTagProperty, value); }
        }

        /// <summary>
        /// ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty ConfirmationMessageProperty =
            DependencyProperty.Register("ConfirmationMessage", typeof(string), typeof(PbMomFbConf_01_M));

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
        /// ConfirmIndirect Property
        /// </summary>
        public static readonly DependencyProperty ConfirmIndirectProperty =
            DependencyProperty.Register("ConfirmIndirect", typeof(string), typeof(PbMomFbConf_01_M));

        /// <summary>
        /// Gets or sets the ConfirmIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gTBNSTART_HMI.name")]
        public string ConfirmIndirect
        {
            get { return (string)this.GetValue(ConfirmIndirectProperty); }
            set { this.SetValue(ConfirmIndirectProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(PbMomFbConf_01_M));

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
        /// Feedback Property
        /// </summary>
        public static readonly DependencyProperty FeedbackProperty =
            DependencyProperty.Register("Feedback", typeof(bool), typeof(PbMomFbConf_01_M));

        /// <summary>
        /// Gets or sets the Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the feedback tagname f-tag here.
For example: fTBNSTART")]
        public bool Feedback
        {
            get { return (bool)this.GetValue(FeedbackProperty); }
            set { this.SetValue(FeedbackProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.ConfirmationMessage)) yield return new Param("$ConfirmationMessage", this.ConfirmationMessage);
if (!string.IsNullOrWhiteSpace(this.ConfirmIndirect)) yield return new Param("$ConfirmIndirect", this.ConfirmIndirect);
if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);

            }
        }

		
    }
}
