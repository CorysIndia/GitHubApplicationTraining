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
    public class NOT_RST : RSIControlModel
    {
        static NOT_RST()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NOT_RST), new FrameworkPropertyMetadata(typeof(NOT_RST)));
        }

		public NOT_RST()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(NOT_RST));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(NOT_RST));

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
        /// BLK_ZC Property
        /// </summary>
        public static readonly DependencyProperty BLK_ZCProperty =
            DependencyProperty.Register("BLK_ZC", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the BLK_ZC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ZC
        {
            get { return (string)this.GetValue(BLK_ZCProperty); }
            set { this.SetValue(BLK_ZCProperty, value); }
        }

        /// <summary>
        /// _NOT_RST Property
        /// </summary>
        public static readonly DependencyProperty _NOT_RSTProperty =
            DependencyProperty.Register("_NOT_RST", typeof(bool), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the _NOT_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _NOT_RST
        {
            get { return (bool)this.GetValue(_NOT_RSTProperty); }
            set { this.SetValue(_NOT_RSTProperty, value); }
        }

        /// <summary>
        /// BLK_RST Property
        /// </summary>
        public static readonly DependencyProperty BLK_RSTProperty =
            DependencyProperty.Register("BLK_RST", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the BLK_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_RST
        {
            get { return (string)this.GetValue(BLK_RSTProperty); }
            set { this.SetValue(BLK_RSTProperty, value); }
        }

        /// <summary>
        /// PICK1 Property
        /// </summary>
        public static readonly DependencyProperty PICK1Property =
            DependencyProperty.Register("PICK1", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the PICK1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1
        {
            get { return (string)this.GetValue(PICK1Property); }
            set { this.SetValue(PICK1Property, value); }
        }

        /// <summary>
        /// PICK2 Property
        /// </summary>
        public static readonly DependencyProperty PICK2Property =
            DependencyProperty.Register("PICK2", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the PICK2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK2
        {
            get { return (string)this.GetValue(PICK2Property); }
            set { this.SetValue(PICK2Property, value); }
        }

        /// <summary>
        /// PICK1VAR Property
        /// </summary>
        public static readonly DependencyProperty PICK1VARProperty =
            DependencyProperty.Register("PICK1VAR", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the PICK1VAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1VAR
        {
            get { return (string)this.GetValue(PICK1VARProperty); }
            set { this.SetValue(PICK1VARProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PRT
        {
            get { return (string)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// CMP_RST Property
        /// </summary>
        public static readonly DependencyProperty CMP_RSTProperty =
            DependencyProperty.Register("CMP_RST", typeof(string), typeof(NOT_RST));

        /// <summary>
        /// Gets or sets the CMP_RST.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_RST
        {
            get { return (string)this.GetValue(CMP_RSTProperty); }
            set { this.SetValue(CMP_RSTProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK_ZC)) yield return new Param("$BLK_ZC", this.BLK_ZC);
if (!string.IsNullOrWhiteSpace(this.BLK_RST)) yield return new Param("$BLK_RST", this.BLK_RST);
if (!string.IsNullOrWhiteSpace(this.PICK1)) yield return new Param("$PICK1", this.PICK1);
if (!string.IsNullOrWhiteSpace(this.PICK2)) yield return new Param("$PICK2", this.PICK2);
if (!string.IsNullOrWhiteSpace(this.PICK1VAR)) yield return new Param("$PICK1VAR", this.PICK1VAR);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.CMP_RST)) yield return new Param("$CMP_RST", this.CMP_RST);

            }
        }

		
    }
}
