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
    public class fIND_D_01_S1_M_III : RSIControlModel
    {
        static fIND_D_01_S1_M_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(fIND_D_01_S1_M_III), new FrameworkPropertyMetadata(typeof(fIND_D_01_S1_M_III)));
        }

		public fIND_D_01_S1_M_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(fIND_D_01_S1_M_III));

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
            DependencyProperty.Register("Value", typeof(bool), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Value
        {
            get { return (bool)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }

        /// <summary>
        /// TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty TagDescrpProperty =
            DependencyProperty.Register("TagDescrp", typeof(string), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TagDescrp
        {
            get { return (string)this.GetValue(TagDescrpProperty); }
            set { this.SetValue(TagDescrpProperty, value); }
        }

        /// <summary>
        /// TagName Property
        /// </summary>
        public new static readonly DependencyProperty TagNameProperty =
            DependencyProperty.Register("TagName", typeof(string), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public new string TagName
        {
            get { return (string)this.GetValue(TagNameProperty); }
            set { this.SetValue(TagNameProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Tooltip Property
        /// </summary>
        public static readonly DependencyProperty TooltipProperty =
            DependencyProperty.Register("Tooltip", typeof(string), typeof(fIND_D_01_S1_M_III));

        /// <summary>
        /// Gets or sets the Tooltip.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Tooltip
        {
            get { return (string)this.GetValue(TooltipProperty); }
            set { this.SetValue(TooltipProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.TagDescrp)) yield return new Param("$TagDescrp", this.TagDescrp);
if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);

            }
        }

		
    }
}
