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
    public class FP_Alarm2 : RSIControlModel
    {
        static FP_Alarm2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FP_Alarm2), new FrameworkPropertyMetadata(typeof(FP_Alarm2)));
        }

		public FP_Alarm2()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(FP_Alarm2));

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
        /// CRIT Property
        /// </summary>
        public static readonly DependencyProperty CRITProperty =
            DependencyProperty.Register("CRIT", typeof(int), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the CRIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CRIT
        {
            get { return (int)this.GetValue(CRITProperty); }
            set { this.SetValue(CRITProperty, value); }
        }

        /// <summary>
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(FP_Alarm2));

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
        /// PRTYPE Property
        /// </summary>
        public static readonly DependencyProperty PRTYPEProperty =
            DependencyProperty.Register("PRTYPE", typeof(int), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the PRTYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRTYPE
        {
            get { return (int)this.GetValue(PRTYPEProperty); }
            set { this.SetValue(PRTYPEProperty, value); }
        }

        /// <summary>
        /// INHIB Property
        /// </summary>
        public static readonly DependencyProperty INHIBProperty =
            DependencyProperty.Register("INHIB", typeof(bool), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the INHIB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INHIB
        {
            get { return (bool)this.GetValue(INHIBProperty); }
            set { this.SetValue(INHIBProperty, value); }
        }

        /// <summary>
        /// ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty ALMSTAProperty =
            DependencyProperty.Register("ALMSTA", typeof(int), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the ALMSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALMSTA
        {
            get { return (int)this.GetValue(ALMSTAProperty); }
            set { this.SetValue(ALMSTAProperty, value); }
        }

        /// <summary>
        /// INHOPT Property
        /// </summary>
        public static readonly DependencyProperty INHOPTProperty =
            DependencyProperty.Register("INHOPT", typeof(bool), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the INHOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INHOPT
        {
            get { return (bool)this.GetValue(INHOPTProperty); }
            set { this.SetValue(INHOPTProperty, value); }
        }

        /// <summary>
        /// Severity Property
        /// </summary>
        public static readonly DependencyProperty SeverityProperty =
            DependencyProperty.Register("Severity", typeof(int), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the Severity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Severity
        {
            get { return (int)this.GetValue(SeverityProperty); }
            set { this.SetValue(SeverityProperty, value); }
        }

        /// <summary>
        /// CB_NAME Property
        /// </summary>
        public static readonly DependencyProperty CB_NAMEProperty =
            DependencyProperty.Register("CB_NAME", typeof(string), typeof(FP_Alarm2));

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
            DependencyProperty.Register("CB_NAME2", typeof(string), typeof(FP_Alarm2));

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
            DependencyProperty.Register("CB_PULSE", typeof(string), typeof(FP_Alarm2));

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
        /// AK Property
        /// </summary>
        public static readonly DependencyProperty AKProperty =
            DependencyProperty.Register("AK", typeof(bool), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the AK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool AK
        {
            get { return (bool)this.GetValue(AKProperty); }
            set { this.SetValue(AKProperty, value); }
        }

        /// <summary>
        /// UNACK2 Property
        /// </summary>
        public static readonly DependencyProperty UNACK2Property =
            DependencyProperty.Register("UNACK2", typeof(bool), typeof(FP_Alarm2));

        /// <summary>
        /// Gets or sets the UNACK2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK2
        {
            get { return (bool)this.GetValue(UNACK2Property); }
            set { this.SetValue(UNACK2Property, value); }
        }

        /// <summary>
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(FP_Alarm2));

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
