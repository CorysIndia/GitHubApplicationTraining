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
    public class Type1_StatusIndicator_Small : RSIControlModel
    {
        static Type1_StatusIndicator_Small()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type1_StatusIndicator_Small), new FrameworkPropertyMetadata(typeof(Type1_StatusIndicator_Small)));
        }

		public Type1_StatusIndicator_Small()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type1_StatusIndicator_Small));

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
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(bool), typeof(Type1_StatusIndicator_Small));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }


        /// <summary>
        /// ZTAG Property
        /// </summary>
        public static readonly DependencyProperty ZTAGProperty =
            DependencyProperty.Register("ZTAG", typeof(string), typeof(Type1_StatusIndicator_Small));

        /// <summary>
        /// Gets or sets the ZTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTAG
        {
            get { return (string)this.GetValue(ZTAGProperty); }
            set { this.SetValue(ZTAGProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(Type1_StatusIndicator_Small));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }


        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
                foreach (var p in base.IndissLikeParameters)
                {
                    yield return p;
                }

                if (!string.IsNullOrWhiteSpace(this.ZTAG)) yield return new Param("$ZTAG", this.ZTAG);



            }
        }


    }
}
