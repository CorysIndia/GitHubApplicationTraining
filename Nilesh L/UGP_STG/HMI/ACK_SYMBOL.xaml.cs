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
    public class ACK_SYMBOL : RSIControlModel
    {
        static ACK_SYMBOL()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ACK_SYMBOL), new FrameworkPropertyMetadata(typeof(ACK_SYMBOL)));
        }

		public ACK_SYMBOL()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ACK_SYMBOL));

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
        /// UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty UNACK_1Property =
            DependencyProperty.Register("UNACK_1", typeof(string), typeof(ACK_SYMBOL));

        /// <summary>
        /// Gets or sets the UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string UNACK_1
        {
            get { return (string)this.GetValue(UNACK_1Property); }
            set { this.SetValue(UNACK_1Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.UNACK_1)) yield return new Param("$UNACK_1", this.UNACK_1);

            }
        }

		
    }
}
