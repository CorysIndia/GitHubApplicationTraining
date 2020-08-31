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
    public class SYM_ALMIND_03 : RSIControlModel
    {
        static SYM_ALMIND_03()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALMIND_03), new FrameworkPropertyMetadata(typeof(SYM_ALMIND_03)));
        }

		public SYM_ALMIND_03()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALMIND_03));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK
        {
            get { return (string)this.GetValue(BLKProperty); }
            set { this.SetValue(BLKProperty, value); }
        }

        /// <summary>
        /// TALL Property
        /// </summary>
        public static readonly DependencyProperty TALLProperty =
            DependencyProperty.Register("TALL", typeof(bool), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the TALL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TALL
        {
            get { return (bool)this.GetValue(TALLProperty); }
            set { this.SetValue(TALLProperty, value); }
        }

        /// <summary>
        /// PAL Property
        /// </summary>
        public static readonly DependencyProperty PALProperty =
            DependencyProperty.Register("PAL", typeof(bool), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the PAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PAL
        {
            get { return (bool)this.GetValue(PALProperty); }
            set { this.SetValue(PALProperty, value); }
        }

        /// <summary>
        /// LAL Property
        /// </summary>
        public static readonly DependencyProperty LALProperty =
            DependencyProperty.Register("LAL", typeof(bool), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool LAL
        {
            get { return (bool)this.GetValue(LALProperty); }
            set { this.SetValue(LALProperty, value); }
        }

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_ALMIND_03));

        /// <summary>
        /// Gets or sets the ACK_SYMBOL1_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_SYMBOL1_UNACK_1
        {
            get { return (string)this.GetValue(ACK_SYMBOL1_UNACK_1Property); }
            set { this.SetValue(ACK_SYMBOL1_UNACK_1Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);

            }
        }

		
    }
}
