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
    public class H2S_LEL_SILENCE : RSIControlModel
    {
        static H2S_LEL_SILENCE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(H2S_LEL_SILENCE), new FrameworkPropertyMetadata(typeof(H2S_LEL_SILENCE)));
        }

		public H2S_LEL_SILENCE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(H2S_LEL_SILENCE));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(H2S_LEL_SILENCE));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(H2S_LEL_SILENCE));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(bool), typeof(H2S_LEL_SILENCE));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PAR
        {
            get { return (bool)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(H2S_LEL_SILENCE));

        /// <summary>
        /// Gets or sets the TAGNAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAGNAME
        {
            get { return (string)this.GetValue(TAGNAMEProperty); }
            set { this.SetValue(TAGNAMEProperty, value); }
        }

        /// <summary>
        /// PAR2 Property
        /// </summary>
        public static readonly DependencyProperty PAR2Property =
            DependencyProperty.Register("PAR2", typeof(bool), typeof(H2S_LEL_SILENCE));

        /// <summary>
        /// Gets or sets the PAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PAR2
        {
            get { return (bool)this.GetValue(PAR2Property); }
            set { this.SetValue(PAR2Property, value); }
        }

        /// <summary>
        /// Button_Pulse_EMPTY1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Pulse_EMPTY1_CON1Property =
            DependencyProperty.Register("Button_Pulse_EMPTY1_CON1", typeof(bool), typeof(H2S_LEL_SILENCE));

        /// <summary>
        /// Gets or sets the Button_Pulse_EMPTY1_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button_Pulse_EMPTY1_CON1
        {
            get { return (bool)this.GetValue(Button_Pulse_EMPTY1_CON1Property); }
            set { this.SetValue(Button_Pulse_EMPTY1_CON1Property, value); }
        }

        /// <summary>
        /// Button_Pulse_EMPTY1_SECONDS Property
        /// </summary>
        public static readonly DependencyProperty Button_Pulse_EMPTY1_SECONDSProperty =
            DependencyProperty.Register("Button_Pulse_EMPTY1_SECONDS", typeof(double), typeof(H2S_LEL_SILENCE));

        /// <summary>
        /// Gets or sets the Button_Pulse_EMPTY1_SECONDS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Button_Pulse_EMPTY1_SECONDS
        {
            get { return (double)this.GetValue(Button_Pulse_EMPTY1_SECONDSProperty); }
            set { this.SetValue(Button_Pulse_EMPTY1_SECONDSProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);

            }
        }

		
    }
}
