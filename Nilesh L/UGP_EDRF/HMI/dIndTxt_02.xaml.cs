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
    public class dIndTxt_02 : RSIControlModel
    {
        static dIndTxt_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(dIndTxt_02), new FrameworkPropertyMetadata(typeof(dIndTxt_02)));
        }

		public dIndTxt_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(dIndTxt_02));

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

        ////////////////////VAIBHAV


        /// <summary>
        /// ZModeDescription Property
        /// </summary>
        public static readonly DependencyProperty ZModeDescriptionProperty =
            DependencyProperty.Register("ZModeDescription", typeof(string), typeof(dIndTxt_02));

        /// <summary>
        /// Gets or sets the ZModeDescription.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZModeDescription
        {
            get { return (string)this.GetValue(ZModeDescriptionProperty); }
            set { this.SetValue(ZModeDescriptionProperty, value); }
        }

        /// <summary>
        /// ZModeStatus Property
        /// </summary>
        public static readonly DependencyProperty ZModeStatusProperty =
            DependencyProperty.Register("ZModeStatus", typeof(string), typeof(dIndTxt_02));

        /// <summary>
        /// Gets or sets the ZModeStatus.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZModeStatus
        {
            get { return (string)this.GetValue(ZModeStatusProperty); }
            set { this.SetValue(ZModeStatusProperty, value); }
        }

        /// <summary>
        /// ZModeStatusColour Property
        /// </summary>
        public static readonly DependencyProperty ZModeStatusColourProperty =
            DependencyProperty.Register("ZModeStatusColour", typeof(string), typeof(dIndTxt_02));

        /// <summary>
        /// Gets or sets the ZModeStatusColour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZModeStatusColour
        {
            get { return (string)this.GetValue(ZModeStatusColourProperty); }
            set { this.SetValue(ZModeStatusColourProperty, value); }
        }


        /// <summary>
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(dIndTxt_02));

        /// <summary>
        /// Gets or sets the Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool Selected
        {
            get { return (bool)this.GetValue(SelectedProperty); }
            set { this.SetValue(SelectedProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.ZModeDescription)) yield return new Param("$ZModeDescription", this.ZModeDescription);
                if (!string.IsNullOrWhiteSpace(this.ZModeStatus)) yield return new Param("$ZModeStatus", this.ZModeStatus);
                if (!string.IsNullOrWhiteSpace(this.ZModeStatusColour)) yield return new Param("$ZModeStatusColour", this.ZModeStatusColour);








            }
        }


    }
}
