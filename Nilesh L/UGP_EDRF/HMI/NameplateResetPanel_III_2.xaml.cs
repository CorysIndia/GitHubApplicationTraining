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
    public class NameplateResetPanel_III_2 : RSIControlModel
    {
        static NameplateResetPanel_III_2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NameplateResetPanel_III_2), new FrameworkPropertyMetadata(typeof(NameplateResetPanel_III_2)));
        }

		public NameplateResetPanel_III_2()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(NameplateResetPanel_III_2));

        // <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(NameplateResetPanel_III_2));
       
        /// <summary>
        /// Gets or sets the RightName.  
        /// </summary>
        [Category("RSI")]
        [Description(@"")]
        public string LABEL
        {
            get { return (string)this.GetValue(LABELProperty); }
            set { this.SetValue(LABELProperty, value); }
        }
        
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


		
		
		
    }
}
