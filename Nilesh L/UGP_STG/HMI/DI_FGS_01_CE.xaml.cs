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
    public class DI_FGS_01_CE : RSIControlModel
    {
        static DI_FGS_01_CE()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DI_FGS_01_CE), new FrameworkPropertyMetadata(typeof(DI_FGS_01_CE)));
        }

		public DI_FGS_01_CE()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DI_FGS_01_CE));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(DI_FGS_01_CE));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(DI_FGS_01_CE));

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
        /// CIN_ALM Property
        /// </summary>
        public static readonly DependencyProperty CIN_ALMProperty =
            DependencyProperty.Register("CIN_ALM", typeof(bool), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the CIN_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CIN_ALM
        {
            get { return (bool)this.GetValue(CIN_ALMProperty); }
            set { this.SetValue(CIN_ALMProperty, value); }
        }

        /// <summary>
        /// BAD Property
        /// </summary>
        public static readonly DependencyProperty BADProperty =
            DependencyProperty.Register("BAD", typeof(bool), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BAD
        {
            get { return (bool)this.GetValue(BADProperty); }
            set { this.SetValue(BADProperty, value); }
        }

        /// <summary>
        /// DISP Property
        /// </summary>
        public static readonly DependencyProperty DISPProperty =
            DependencyProperty.Register("DISP", typeof(string), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the DISP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DISP
        {
            get { return (string)this.GetValue(DISPProperty); }
            set { this.SetValue(DISPProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(DI_FGS_01_CE));

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
        /// ALARM Property
        /// </summary>
        public static readonly DependencyProperty ALARMProperty =
            DependencyProperty.Register("ALARM", typeof(string), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM
        {
            get { return (string)this.GetValue(ALARMProperty); }
            set { this.SetValue(ALARMProperty, value); }
        }

        /// <summary>
        /// PAR2 Property
        /// </summary>
        public static readonly DependencyProperty PAR2Property =
            DependencyProperty.Register("PAR2", typeof(int), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the PAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PAR2
        {
            get { return (int)this.GetValue(PAR2Property); }
            set { this.SetValue(PAR2Property, value); }
        }

        /// <summary>
        /// SPT Property
        /// </summary>
        public static readonly DependencyProperty SPTProperty =
            DependencyProperty.Register("SPT", typeof(int), typeof(DI_FGS_01_CE));

        /// <summary>
        /// Gets or sets the SPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SPT
        {
            get { return (int)this.GetValue(SPTProperty); }
            set { this.SetValue(SPTProperty, value); }
        }

        /// <summary>
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(DI_FGS_01_CE));

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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.DISP)) yield return new Param("$DISP", this.DISP);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.ALARM)) yield return new Param("$ALARM", this.ALARM);

            }
        }

		
    }
}
