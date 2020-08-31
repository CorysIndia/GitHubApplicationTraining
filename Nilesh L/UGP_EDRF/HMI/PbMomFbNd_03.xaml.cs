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
    public class PbMomFbNd_03 : RSIControlModel
    {
        static PbMomFbNd_03()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PbMomFbNd_03), new FrameworkPropertyMetadata(typeof(PbMomFbNd_03)));
        }

		public PbMomFbNd_03()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PbMomFbNd_03));

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
        /// UpPushed Property
        /// </summary>
        public static readonly DependencyProperty UpPushedProperty =
            DependencyProperty.Register("UpPushed", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool UpPushed
        {
            get { return (bool)this.GetValue(UpPushedProperty); }
            set { this.SetValue(UpPushedProperty, value); }
        }

        /// <summary>
        /// DownPushed Property
        /// </summary>
        public static readonly DependencyProperty DownPushedProperty =
            DependencyProperty.Register("DownPushed", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool DownPushed
        {
            get { return (bool)this.GetValue(DownPushedProperty); }
            set { this.SetValue(DownPushedProperty, value); }
        }

        /// <summary>
        /// UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty UpFeedbackProperty =
            DependencyProperty.Register("UpFeedback", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool UpFeedback
        {
            get { return (bool)this.GetValue(UpFeedbackProperty); }
            set { this.SetValue(UpFeedbackProperty, value); }
        }

        /// <summary>
        /// DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty DownFeedbackProperty =
            DependencyProperty.Register("DownFeedback", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool DownFeedback
        {
            get { return (bool)this.GetValue(DownFeedbackProperty); }
            set { this.SetValue(DownFeedbackProperty, value); }
        }

        /// <summary>
        /// eTAG Property
        /// </summary>
        public static readonly DependencyProperty eTAGProperty =
            DependencyProperty.Register("eTAG", typeof(double), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double eTAG
        {
            get { return (double)this.GetValue(eTAGProperty); }
            set { this.SetValue(eTAGProperty, value); }
        }

        /// <summary>
        /// kAddValue Property
        /// </summary>
        public static readonly DependencyProperty kAddValueProperty =
            DependencyProperty.Register("kAddValue", typeof(double), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double kAddValue
        {
            get { return (double)this.GetValue(kAddValueProperty); }
            set { this.SetValue(kAddValueProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Cnt Property
        /// </summary>
        public static readonly DependencyProperty CntProperty =
            DependencyProperty.Register("Cnt", typeof(int), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the Cnt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"For Unlatching")]
        public int Cnt
        {
            get { return (int)this.GetValue(CntProperty); }
            set { this.SetValue(CntProperty, value); }
        }

        /// <summary>
        /// Mouse_Release Property
        /// </summary>
        public static readonly DependencyProperty Mouse_ReleaseProperty =
            DependencyProperty.Register("Mouse_Release", typeof(bool), typeof(PbMomFbNd_03));

        /// <summary>
        /// Gets or sets the Mouse_Release.  
        /// </summary>
		[Category("RSI")]
        [Description(@"For Unlatching")]
        public bool Mouse_Release
        {
            get { return (bool)this.GetValue(Mouse_ReleaseProperty); }
            set { this.SetValue(Mouse_ReleaseProperty, value); }
        }


		
		
    }
}
