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
    public class PbMomFb_01_Dn_M : RSIControlModel
    {
        static PbMomFb_01_Dn_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PbMomFb_01_Dn_M), new FrameworkPropertyMetadata(typeof(PbMomFb_01_Dn_M)));
        }

		public PbMomFb_01_Dn_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PbMomFb_01_Dn_M));

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
            DependencyProperty.Register("ButtonPressed", typeof(bool), typeof(PbMomFb_01_Dn_M));

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
            DependencyProperty.Register("Colour", typeof(int), typeof(PbMomFb_01_Dn_M));

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
            DependencyProperty.Register("DisableTag", typeof(bool), typeof(PbMomFb_01_Dn_M));

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
        /// DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty DownFeedbackProperty =
            DependencyProperty.Register("DownFeedback", typeof(bool), typeof(PbMomFb_01_Dn_M));

        /// <summary>
        /// Gets or sets the DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when it is true")]
        public bool DownFeedback
        {
            get { return (bool)this.GetValue(DownFeedbackProperty); }
            set { this.SetValue(DownFeedbackProperty, value); }
        }

        /// <summary>
        /// DownPushed Property
        /// </summary>
        public static readonly DependencyProperty DownPushedProperty =
            DependencyProperty.Register("DownPushed", typeof(bool), typeof(PbMomFb_01_Dn_M));

        /// <summary>
        /// Gets or sets the DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here.")]
        public bool DownPushed
        {
            get { return (bool)this.GetValue(DownPushedProperty); }
            set { this.SetValue(DownPushedProperty, value); }
        }

        /// <summary>
        /// Cnt Property
        /// </summary>
        public static readonly DependencyProperty CntProperty =
            DependencyProperty.Register("Cnt", typeof(int), typeof(PbMomFb_01_Dn_M));

        /// <summary>
        /// Gets or sets the Cnt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Cnt
        {
            get { return (int)this.GetValue(CntProperty); }
            set { this.SetValue(CntProperty, value); }
        }

        /// <summary>
        /// Mouse_Release Property
        /// </summary>
        public static readonly DependencyProperty Mouse_ReleaseProperty =
            DependencyProperty.Register("Mouse_Release", typeof(bool), typeof(PbMomFb_01_Dn_M));

        /// <summary>
        /// Gets or sets the Mouse_Release.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'For Unlatching
")]
        public bool Mouse_Release
        {
            get { return (bool)this.GetValue(Mouse_ReleaseProperty); }
            set { this.SetValue(Mouse_ReleaseProperty, value); }
        }


		
		
    }
}
