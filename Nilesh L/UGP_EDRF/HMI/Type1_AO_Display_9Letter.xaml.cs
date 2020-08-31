using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;
using RSI.Emulation.Controls.Control.FoxBoro;
namespace UGP_EDRF.HMI
{
    public class Type1_AO_Display_9Letter : RSIControlModel
    {
        static Type1_AO_Display_9Letter()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type1_AO_Display_9Letter), new FrameworkPropertyMetadata(typeof(Type1_AO_Display_9Letter)));
        }

		public Type1_AO_Display_9Letter()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type1_AO_Display_9Letter));

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
        /// VALUE Property
        /// </summary>
        public static readonly DependencyProperty VALUEProperty =
            DependencyProperty.Register("VALUE", typeof(double), typeof(Type1_AO_Display_9Letter));

        /// <summary>
        /// Gets or sets the VALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname you want to display the value here")]
        public double VALUE
        {
            get { return (double)this.GetValue(VALUEProperty); }
            set { this.SetValue(VALUEProperty, value); }
        }

        /// <summary>
        /// ZTAG Property
        /// </summary>
        public static readonly DependencyProperty ZTAGProperty =
            DependencyProperty.Register("ZTAG", typeof(string), typeof(Type1_AO_Display_9Letter));

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
