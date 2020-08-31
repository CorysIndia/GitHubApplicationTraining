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
    public class PID1_Bar_III : RSIControlModel
    {
        static PID1_Bar_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PID1_Bar_III), new FrameworkPropertyMetadata(typeof(PID1_Bar_III)));
        }

		public PID1_Bar_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PID1_Bar_III));

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
        /// OPMin Property
        /// </summary>
        public static readonly DependencyProperty OPMinProperty =
            DependencyProperty.Register("OPMin", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double OPMin
        {
            get { return (double)this.GetValue(OPMinProperty); }
            set { this.SetValue(OPMinProperty, value); }
        }

        /// <summary>
        /// OPMax Property
        /// </summary>
        public static readonly DependencyProperty OPMaxProperty =
            DependencyProperty.Register("OPMax", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double OPMax
        {
            get { return (double)this.GetValue(OPMaxProperty); }
            set { this.SetValue(OPMaxProperty, value); }
        }

        /// <summary>
        /// PV Property
        /// </summary>
        public static readonly DependencyProperty PVProperty =
            DependencyProperty.Register("PV", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV
        {
            get { return (double)this.GetValue(PVProperty); }
            set { this.SetValue(PVProperty, value); }
        }

        /// <summary>
        /// OP Property
        /// </summary>
        public static readonly DependencyProperty OPProperty =
            DependencyProperty.Register("OP", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OP
        {
            get { return (double)this.GetValue(OPProperty); }
            set { this.SetValue(OPProperty, value); }
        }

        /// <summary>
        /// SP Property
        /// </summary>
        public static readonly DependencyProperty SPProperty =
            DependencyProperty.Register("SP", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SP
        {
            get { return (double)this.GetValue(SPProperty); }
            set { this.SetValue(SPProperty, value); }
        }

        /// <summary>
        /// MD Property
        /// </summary>
        public static readonly DependencyProperty MDProperty =
            DependencyProperty.Register("MD", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MD
        {
            get { return (double)this.GetValue(MDProperty); }
            set { this.SetValue(MDProperty, value); }
        }

        /// <summary>
        /// MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty MD_VISProperty =
            DependencyProperty.Register("MD_VIS", typeof(bool), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MD_VIS
        {
            get { return (bool)this.GetValue(MD_VISProperty); }
            set { this.SetValue(MD_VISProperty, value); }
        }

        /// <summary>
        /// PVMax Property
        /// </summary>
        public static readonly DependencyProperty PVMaxProperty =
            DependencyProperty.Register("PVMax", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PVMax
        {
            get { return (double)this.GetValue(PVMaxProperty); }
            set { this.SetValue(PVMaxProperty, value); }
        }

        /// <summary>
        /// PVMin Property
        /// </summary>
        public static readonly DependencyProperty PVMinProperty =
            DependencyProperty.Register("PVMin", typeof(double), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PVMin
        {
            get { return (double)this.GetValue(PVMinProperty); }
            set { this.SetValue(PVMinProperty, value); }
        }

        /// <summary>
        /// SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty SP_VISProperty =
            DependencyProperty.Register("SP_VIS", typeof(bool), typeof(PID1_Bar_III));

        /// <summary>
        /// Gets or sets the SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SP_VIS
        {
            get { return (bool)this.GetValue(SP_VISProperty); }
            set { this.SetValue(SP_VISProperty, value); }
        }


		
		
    }
}
