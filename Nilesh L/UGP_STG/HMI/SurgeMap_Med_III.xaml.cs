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
    public class SurgeMap_Med_III : RSIControlModel
    {
        static SurgeMap_Med_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SurgeMap_Med_III), new FrameworkPropertyMetadata(typeof(SurgeMap_Med_III)));
        }

		public SurgeMap_Med_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SurgeMap_Med_III));

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
        /// HCA Property
        /// </summary>
        public static readonly DependencyProperty HCAProperty =
            DependencyProperty.Register("HCA", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCA
        {
            get { return (double)this.GetValue(HCAProperty); }
            set { this.SetValue(HCAProperty, value); }
        }

        /// <summary>
        /// HCB Property
        /// </summary>
        public static readonly DependencyProperty HCBProperty =
            DependencyProperty.Register("HCB", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCB
        {
            get { return (double)this.GetValue(HCBProperty); }
            set { this.SetValue(HCBProperty, value); }
        }

        /// <summary>
        /// HCC Property
        /// </summary>
        public static readonly DependencyProperty HCCProperty =
            DependencyProperty.Register("HCC", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCC
        {
            get { return (double)this.GetValue(HCCProperty); }
            set { this.SetValue(HCCProperty, value); }
        }

        /// <summary>
        /// HCD Property
        /// </summary>
        public static readonly DependencyProperty HCDProperty =
            DependencyProperty.Register("HCD", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCD
        {
            get { return (double)this.GetValue(HCDProperty); }
            set { this.SetValue(HCDProperty, value); }
        }

        /// <summary>
        /// HCE Property
        /// </summary>
        public static readonly DependencyProperty HCEProperty =
            DependencyProperty.Register("HCE", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCE
        {
            get { return (double)this.GetValue(HCEProperty); }
            set { this.SetValue(HCEProperty, value); }
        }

        /// <summary>
        /// HCF Property
        /// </summary>
        public static readonly DependencyProperty HCFProperty =
            DependencyProperty.Register("HCF", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HCF.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HCF
        {
            get { return (double)this.GetValue(HCFProperty); }
            set { this.SetValue(HCFProperty, value); }
        }

        /// <summary>
        /// HOVPT Property
        /// </summary>
        public static readonly DependencyProperty HOVPTProperty =
            DependencyProperty.Register("HOVPT", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the HOVPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double HOVPT
        {
            get { return (double)this.GetValue(HOVPTProperty); }
            set { this.SetValue(HOVPTProperty, value); }
        }

        /// <summary>
        /// MARA Property
        /// </summary>
        public static readonly DependencyProperty MARAProperty =
            DependencyProperty.Register("MARA", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARA
        {
            get { return (double)this.GetValue(MARAProperty); }
            set { this.SetValue(MARAProperty, value); }
        }

        /// <summary>
        /// MARB Property
        /// </summary>
        public static readonly DependencyProperty MARBProperty =
            DependencyProperty.Register("MARB", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARB
        {
            get { return (double)this.GetValue(MARBProperty); }
            set { this.SetValue(MARBProperty, value); }
        }

        /// <summary>
        /// MARC Property
        /// </summary>
        public static readonly DependencyProperty MARCProperty =
            DependencyProperty.Register("MARC", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARC
        {
            get { return (double)this.GetValue(MARCProperty); }
            set { this.SetValue(MARCProperty, value); }
        }

        /// <summary>
        /// MARD Property
        /// </summary>
        public static readonly DependencyProperty MARDProperty =
            DependencyProperty.Register("MARD", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARD
        {
            get { return (double)this.GetValue(MARDProperty); }
            set { this.SetValue(MARDProperty, value); }
        }

        /// <summary>
        /// MARE Property
        /// </summary>
        public static readonly DependencyProperty MAREProperty =
            DependencyProperty.Register("MARE", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARE
        {
            get { return (double)this.GetValue(MAREProperty); }
            set { this.SetValue(MAREProperty, value); }
        }

        /// <summary>
        /// MARF Property
        /// </summary>
        public static readonly DependencyProperty MARFProperty =
            DependencyProperty.Register("MARF", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MARF.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double MARF
        {
            get { return (double)this.GetValue(MARFProperty); }
            set { this.SetValue(MARFProperty, value); }
        }

        /// <summary>
        /// OP Property
        /// </summary>
        public static readonly DependencyProperty OPProperty =
            DependencyProperty.Register("OP", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double OP
        {
            get { return (double)this.GetValue(OPProperty); }
            set { this.SetValue(OPProperty, value); }
        }

        /// <summary>
        /// PRA Property
        /// </summary>
        public static readonly DependencyProperty PRAProperty =
            DependencyProperty.Register("PRA", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRA
        {
            get { return (double)this.GetValue(PRAProperty); }
            set { this.SetValue(PRAProperty, value); }
        }

        /// <summary>
        /// PRB Property
        /// </summary>
        public static readonly DependencyProperty PRBProperty =
            DependencyProperty.Register("PRB", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRB
        {
            get { return (double)this.GetValue(PRBProperty); }
            set { this.SetValue(PRBProperty, value); }
        }

        /// <summary>
        /// PRC Property
        /// </summary>
        public static readonly DependencyProperty PRCProperty =
            DependencyProperty.Register("PRC", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRC
        {
            get { return (double)this.GetValue(PRCProperty); }
            set { this.SetValue(PRCProperty, value); }
        }

        /// <summary>
        /// PRD Property
        /// </summary>
        public static readonly DependencyProperty PRDProperty =
            DependencyProperty.Register("PRD", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRD
        {
            get { return (double)this.GetValue(PRDProperty); }
            set { this.SetValue(PRDProperty, value); }
        }

        /// <summary>
        /// PRE Property
        /// </summary>
        public static readonly DependencyProperty PREProperty =
            DependencyProperty.Register("PRE", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRE
        {
            get { return (double)this.GetValue(PREProperty); }
            set { this.SetValue(PREProperty, value); }
        }

        /// <summary>
        /// PRF Property
        /// </summary>
        public static readonly DependencyProperty PRFProperty =
            DependencyProperty.Register("PRF", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRF.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRF
        {
            get { return (double)this.GetValue(PRFProperty); }
            set { this.SetValue(PRFProperty, value); }
        }

        /// <summary>
        /// PRAT Property
        /// </summary>
        public static readonly DependencyProperty PRATProperty =
            DependencyProperty.Register("PRAT", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PRAT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Value to be displayed.")]
        public double PRAT
        {
            get { return (double)this.GetValue(PRATProperty); }
            set { this.SetValue(PRATProperty, value); }
        }

        /// <summary>
        /// MINFLOW_ACT Property
        /// </summary>
        public static readonly DependencyProperty MINFLOW_ACTProperty =
            DependencyProperty.Register("MINFLOW_ACT", typeof(bool), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the MINFLOW_ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MINFLOW_ACT
        {
            get { return (bool)this.GetValue(MINFLOW_ACTProperty); }
            set { this.SetValue(MINFLOW_ACTProperty, value); }
        }

        /// <summary>
        /// SRGLINE Property
        /// </summary>
        public static readonly DependencyProperty SRGLINEProperty =
            DependencyProperty.Register("SRGLINE", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the SRGLINE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SRGLINE
        {
            get { return (double)this.GetValue(SRGLINEProperty); }
            set { this.SetValue(SRGLINEProperty, value); }
        }

        /// <summary>
        /// PR_Max Property
        /// </summary>
        public static readonly DependencyProperty PR_MaxProperty =
            DependencyProperty.Register("PR_Max", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the PR_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PR_Max
        {
            get { return (double)this.GetValue(PR_MaxProperty); }
            set { this.SetValue(PR_MaxProperty, value); }
        }

        /// <summary>
        /// CTRLLINE Property
        /// </summary>
        public static readonly DependencyProperty CTRLLINEProperty =
            DependencyProperty.Register("CTRLLINE", typeof(double), typeof(SurgeMap_Med_III));

        /// <summary>
        /// Gets or sets the CTRLLINE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double CTRLLINE
        {
            get { return (double)this.GetValue(CTRLLINEProperty); }
            set { this.SetValue(CTRLLINEProperty, value); }
        }


		
		
    }
}
