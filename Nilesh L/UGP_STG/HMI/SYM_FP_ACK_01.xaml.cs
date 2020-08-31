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
    public class SYM_FP_ACK_01 : RSIControlModel
    {
        static SYM_FP_ACK_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_FP_ACK_01), new FrameworkPropertyMetadata(typeof(SYM_FP_ACK_01)));
        }

		public SYM_FP_ACK_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_FP_ACK_01));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(SYM_FP_ACK_01));

        /// <summary>
        /// Gets or sets the UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK
        {
            get { return (bool)this.GetValue(UNACKProperty); }
            set { this.SetValue(UNACKProperty, value); }
        }

        /// <summary>
        /// CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty CB_NAMEProperty =
            DependencyProperty.Register("CB_NAME", typeof(string), typeof(SYM_FP_ACK_01));

        /// <summary>
        /// Gets or sets the CB_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB_NAME
        {
            get { return (string)this.GetValue(CB_NAMEProperty); }
            set { this.SetValue(CB_NAMEProperty, value); }
        }

        /// <summary>
        /// CB_NAME2 Property
        /// </summary>
        public static readonly DependencyProperty CB_NAME2Property =
            DependencyProperty.Register("CB_NAME2", typeof(string), typeof(SYM_FP_ACK_01));

        /// <summary>
        /// Gets or sets the CB_NAME2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB_NAME2
        {
            get { return (string)this.GetValue(CB_NAME2Property); }
            set { this.SetValue(CB_NAME2Property, value); }
        }

        /// <summary>
        /// CB_PULSE Property
        /// </summary>
        public static readonly DependencyProperty CB_PULSEProperty =
            DependencyProperty.Register("CB_PULSE", typeof(string), typeof(SYM_FP_ACK_01));

        /// <summary>
        /// Gets or sets the CB_PULSE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"CMP.BLK.PAR")]
        public string CB_PULSE
        {
            get { return (string)this.GetValue(CB_PULSEProperty); }
            set { this.SetValue(CB_PULSEProperty, value); }
        }

        /// <summary>
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(SYM_FP_ACK_01));

        /// <summary>
        /// Gets or sets the Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type
        {
            get { return (string)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CB_NAME)) yield return new Param("$CB_NAME", this.CB_NAME);
if (!string.IsNullOrWhiteSpace(this.CB_NAME2)) yield return new Param("$CB_NAME2", this.CB_NAME2);
if (!string.IsNullOrWhiteSpace(this.CB_PULSE)) yield return new Param("$CB_PULSE", this.CB_PULSE);

            }
        }

		
    }
}
