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
        /// GateBlockName Property
        /// </summary>
        public static readonly DependencyProperty GateBlockNameProperty =
            DependencyProperty.Register("GateBlockName", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the GateBlockName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string GateBlockName
        {
            get { return (string)this.GetValue(GateBlockNameProperty); }
            set { this.SetValue(GateBlockNameProperty, value); }
        }



        /// <summary>
        /// GateBlockInputNumber Property
        /// </summary>
        public static readonly DependencyProperty GateBlockInputNumberProperty =
            DependencyProperty.Register("GateBlockInputNumber", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the GateBlockInputNumber.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string GateBlockInputNumber
        {
            get { return (string)this.GetValue(GateBlockInputNumberProperty); }
            set { this.SetValue(GateBlockInputNumberProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.GateBlockName)) yield return new Param("$GateBlockName", this.GateBlockName);
                if (!string.IsNullOrWhiteSpace(this.GateBlockInputNumber)) yield return new Param("$GateBlockInputNumber", this.GateBlockInputNumber);



            }
        }



    }
}
