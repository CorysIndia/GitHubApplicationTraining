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
    public class PUSH_BUTTOM : RSIControlModel
    {
        static PUSH_BUTTOM()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PUSH_BUTTOM), new FrameworkPropertyMetadata(typeof(PUSH_BUTTOM)));
        }

		public PUSH_BUTTOM()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PUSH_BUTTOM));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(PUSH_BUTTOM));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(PUSH_BUTTOM));

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
            DependencyProperty.Register("PAR", typeof(string), typeof(PUSH_BUTTOM));

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
            DependencyProperty.Register("CONN", typeof(bool), typeof(PUSH_BUTTOM));

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
        /// ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty ALARM_CONNProperty =
            DependencyProperty.Register("ALARM_CONN", typeof(string), typeof(PUSH_BUTTOM));

        /// <summary>
        /// Gets or sets the ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM_CONN
        {
            get { return (string)this.GetValue(ALARM_CONNProperty); }
            set { this.SetValue(ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// ALARM Property
        /// </summary>
        public static readonly DependencyProperty ALARMProperty =
            DependencyProperty.Register("ALARM", typeof(bool), typeof(PUSH_BUTTOM));

        /// <summary>
        /// Gets or sets the ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ALARM
        {
            get { return (bool)this.GetValue(ALARMProperty); }
            set { this.SetValue(ALARMProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.ALARM_CONN)) yield return new Param("$ALARM_CONN", this.ALARM_CONN);

            }
        }

		
    }
}
