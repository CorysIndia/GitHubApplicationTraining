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
    public class NEXT_SEQ : RSIControlModel
    {
        static NEXT_SEQ()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NEXT_SEQ), new FrameworkPropertyMetadata(typeof(NEXT_SEQ)));
        }

		public NEXT_SEQ()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(NEXT_SEQ));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(NEXT_SEQ));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(NEXT_SEQ));

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
            DependencyProperty.Register("PAR", typeof(string), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR
        {
            get { return (string)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// CONN Property
        /// </summary>
        public static readonly DependencyProperty CONNProperty =
            DependencyProperty.Register("CONN", typeof(bool), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CONN
        {
            get { return (bool)this.GetValue(CONNProperty); }
            set { this.SetValue(CONNProperty, value); }
        }

        /// <summary>
        /// DISABLE Property
        /// </summary>
        public static readonly DependencyProperty DISABLEProperty =
            DependencyProperty.Register("DISABLE", typeof(bool), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the DISABLE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DISABLE
        {
            get { return (bool)this.GetValue(DISABLEProperty); }
            set { this.SetValue(DISABLEProperty, value); }
        }

        /// <summary>
        /// DISABLE_CONN Property
        /// </summary>
        public static readonly DependencyProperty DISABLE_CONNProperty =
            DependencyProperty.Register("DISABLE_CONN", typeof(string), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the DISABLE_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DISABLE_CONN
        {
            get { return (string)this.GetValue(DISABLE_CONNProperty); }
            set { this.SetValue(DISABLE_CONNProperty, value); }
        }

        /// <summary>
        /// STOP Property
        /// </summary>
        public static readonly DependencyProperty STOPProperty =
            DependencyProperty.Register("STOP", typeof(bool), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the STOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOP
        {
            get { return (bool)this.GetValue(STOPProperty); }
            set { this.SetValue(STOPProperty, value); }
        }

        /// <summary>
        /// STOP_CONN Property
        /// </summary>
        public static readonly DependencyProperty STOP_CONNProperty =
            DependencyProperty.Register("STOP_CONN", typeof(string), typeof(NEXT_SEQ));

        /// <summary>
        /// Gets or sets the STOP_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STOP_CONN
        {
            get { return (string)this.GetValue(STOP_CONNProperty); }
            set { this.SetValue(STOP_CONNProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
if (!string.IsNullOrWhiteSpace(this.DISABLE_CONN)) yield return new Param("$DISABLE_CONN", this.DISABLE_CONN);
if (!string.IsNullOrWhiteSpace(this.STOP_CONN)) yield return new Param("$STOP_CONN", this.STOP_CONN);

            }
        }

		
    }
}
