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
    public class ButtonBackPanel_HT : RSIControlModel
    {
        static ButtonBackPanel_HT()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonBackPanel_HT), new FrameworkPropertyMetadata(typeof(ButtonBackPanel_HT)));
        }

		public ButtonBackPanel_HT()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ButtonBackPanel_HT));

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
        /// ZRunningStatus Property
        /// </summary>
        public static readonly DependencyProperty ZRunningStatusProperty =
            DependencyProperty.Register("ZRunningStatus", typeof(string), typeof(ButtonBackPanel_HT));

        /// <summary>
        /// Gets or sets the ZRunningStatus.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ZRunningStatus
        {
            get { return (string)this.GetValue(ZRunningStatusProperty); }
            set { this.SetValue(ZRunningStatusProperty, value); }
        }


        /// <summary>
        /// ZAccel Property
        /// </summary>
        public static readonly DependencyProperty ZAccelProperty =
            DependencyProperty.Register("ZAccel", typeof(string), typeof(ButtonBackPanel_HT));

        /// <summary>
        /// Gets or sets the ZAccel.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ZAccel
        {
            get { return (string)this.GetValue(ZAccelProperty); }
            set { this.SetValue(ZAccelProperty, value); }
        }

        /// <summary>
        /// ZStoppedStatus Property
        /// </summary>
        public static readonly DependencyProperty ZStoppedStatusProperty =
            DependencyProperty.Register("ZStoppedStatus", typeof(string), typeof(ButtonBackPanel_HT));

        /// <summary>
        /// Gets or sets the ZStoppedStatus.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ZStoppedStatus
        {
            get { return (string)this.GetValue(ZStoppedStatusProperty); }
            set { this.SetValue(ZStoppedStatusProperty, value); }
        }

        /// <summary>
        /// ZFullSpeedStatus Property
        /// </summary>
        public static readonly DependencyProperty ZFullSpeedStatusProperty =
            DependencyProperty.Register("ZFullSpeedStatus", typeof(string), typeof(ButtonBackPanel_HT));

        /// <summary>
        /// Gets or sets the ZFullSpeedStatus.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string ZFullSpeedStatus
        {
            get { return (string)this.GetValue(ZFullSpeedStatusProperty); }
            set { this.SetValue(ZFullSpeedStatusProperty, value); }
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

                
                if (!string.IsNullOrWhiteSpace(this.ZRunningStatus)) yield return new Param("$ZRunningStatus", this.ZRunningStatus);
                if (!string.IsNullOrWhiteSpace(this.ZStoppedStatus)) yield return new Param("$ZStoppedStatus", this.ZStoppedStatus);
                if (!string.IsNullOrWhiteSpace(this.ZFullSpeedStatus)) yield return new Param("$ZFullSpeedStatus", this.ZFullSpeedStatus);
                if (!string.IsNullOrWhiteSpace(this.ZAccel)) yield return new Param("$ZAccel", this.ZAccel);


            }
        }

    }
}
