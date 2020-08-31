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
    public class COSwitchConf_01 : RSIControlModel
    {
        static COSwitchConf_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(COSwitchConf_01), new FrameworkPropertyMetadata(typeof(COSwitchConf_01)));
        }

		public COSwitchConf_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(COSwitchConf_01));

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
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(COSwitchConf_01));

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
        /// Disabled Property
        /// </summary>
        public static readonly DependencyProperty DisabledProperty =
            DependencyProperty.Register("Disabled", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the Disabled.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fPROCENB_DISHMI

True: disable button
False: enable button")]
        public bool Disabled
        {
            get { return (bool)this.GetValue(DisabledProperty); }
            set { this.SetValue(DisabledProperty, value); }
        }

        /// <summary>
        /// ConfirmIndirect Property
        /// </summary>
        public static readonly DependencyProperty ConfirmIndirectProperty =
            DependencyProperty.Register("ConfirmIndirect", typeof(string), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the ConfirmIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gPROCENB.name")]
        public string ConfirmIndirect
        {
            get { return (string)this.GetValue(ConfirmIndirectProperty); }
            set { this.SetValue(ConfirmIndirectProperty, value); }
        }

        /// <summary>
        /// Feedback Property
        /// </summary>
        public static readonly DependencyProperty FeedbackProperty =
            DependencyProperty.Register("Feedback", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the feedback tagname f-tag here.
For example: fPROCENB")]
        public bool Feedback
        {
            get { return (bool)this.GetValue(FeedbackProperty); }
            set { this.SetValue(FeedbackProperty, value); }
        }

        /// <summary>
        /// FeedbackIndirect Property
        /// </summary>
        public static readonly DependencyProperty FeedbackIndirectProperty =
            DependencyProperty.Register("FeedbackIndirect", typeof(string), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the FeedbackIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag indirect .name here
For example: fPROCENB.name")]
        public string FeedbackIndirect
        {
            get { return (string)this.GetValue(FeedbackIndirectProperty); }
            set { this.SetValue(FeedbackIndirectProperty, value); }
        }

        /// <summary>
        /// RightMessage Property
        /// </summary>
        public static readonly DependencyProperty RightMessageProperty =
            DependencyProperty.Register("RightMessage", typeof(string), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the RightMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"right message for confirmation")]
        public string RightMessage
        {
            get { return (string)this.GetValue(RightMessageProperty); }
            set { this.SetValue(RightMessageProperty, value); }
        }

        /// <summary>
        /// LeftMessage Property
        /// </summary>
        public static readonly DependencyProperty LeftMessageProperty =
            DependencyProperty.Register("LeftMessage", typeof(string), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the LeftMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"left message")]
        public string LeftMessage
        {
            get { return (string)this.GetValue(LeftMessageProperty); }
            set { this.SetValue(LeftMessageProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_ColourProperty =
            DependencyProperty.Register("LeftIndicator_Colour", typeof(int), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the LeftIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int LeftIndicator_Colour
        {
            get { return (int)this.GetValue(LeftIndicator_ColourProperty); }
            set { this.SetValue(LeftIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Value Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_ValueProperty =
            DependencyProperty.Register("LeftIndicator_Value", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the LeftIndicator_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool LeftIndicator_Value
        {
            get { return (bool)this.GetValue(LeftIndicator_ValueProperty); }
            set { this.SetValue(LeftIndicator_ValueProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Fail Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_FailProperty =
            DependencyProperty.Register("LeftIndicator_Fail", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the LeftIndicator_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool LeftIndicator_Fail
        {
            get { return (bool)this.GetValue(LeftIndicator_FailProperty); }
            set { this.SetValue(LeftIndicator_FailProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_ColourProperty =
            DependencyProperty.Register("RightIndicator_Colour", typeof(int), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the RightIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int RightIndicator_Colour
        {
            get { return (int)this.GetValue(RightIndicator_ColourProperty); }
            set { this.SetValue(RightIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Value Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_ValueProperty =
            DependencyProperty.Register("RightIndicator_Value", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the RightIndicator_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool RightIndicator_Value
        {
            get { return (bool)this.GetValue(RightIndicator_ValueProperty); }
            set { this.SetValue(RightIndicator_ValueProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Fail Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_FailProperty =
            DependencyProperty.Register("RightIndicator_Fail", typeof(bool), typeof(COSwitchConf_01));

        /// <summary>
        /// Gets or sets the RightIndicator_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool RightIndicator_Fail
        {
            get { return (bool)this.GetValue(RightIndicator_FailProperty); }
            set { this.SetValue(RightIndicator_FailProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.ConfirmIndirect)) yield return new Param("$ConfirmIndirect", this.ConfirmIndirect);
if (!string.IsNullOrWhiteSpace(this.FeedbackIndirect)) yield return new Param("$FeedbackIndirect", this.FeedbackIndirect);
if (!string.IsNullOrWhiteSpace(this.RightMessage)) yield return new Param("$RightMessage", this.RightMessage);
if (!string.IsNullOrWhiteSpace(this.LeftMessage)) yield return new Param("$LeftMessage", this.LeftMessage);

            }
        }

		
    }
}
