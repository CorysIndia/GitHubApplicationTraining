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
    public class NameplateResetPanel_III : RSIControlModel
    {
        static NameplateResetPanel_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NameplateResetPanel_III), new FrameworkPropertyMetadata(typeof(NameplateResetPanel_III)));
        }

		public NameplateResetPanel_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(NameplateResetPanel_III));


        ////////////////////////////VAIBHAV///
        /// <summary>
        /// LABELDescription01 Property
        /// </summary>
        public static readonly DependencyProperty LABELDescription01Property =
            DependencyProperty.Register("LABELDescription01", typeof(string), typeof(NameplateResetPanel_III));

        /// <summary>
        /// Gets or sets the LABELDescription01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABELDescription01
        {
            get { return (string)this.GetValue(LABELDescription01Property); }
            set { this.SetValue(LABELDescription01Property, value); }
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

        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
                foreach (var p in base.IndissLikeParameters)
                {
                    yield return p;
                }

                if (!string.IsNullOrWhiteSpace(this.LABELDescription01)) yield return new Param("$LABELDescription01", this.LABELDescription01);
               



               







            }
        }



    }
}
