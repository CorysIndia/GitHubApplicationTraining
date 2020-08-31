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
    public class ContFpSpeedNoDCS : RSIControlModel
    {
        static ContFpSpeedNoDCS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContFpSpeedNoDCS), new FrameworkPropertyMetadata(typeof(ContFpSpeedNoDCS)));
        }

		public ContFpSpeedNoDCS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ContFpSpeedNoDCS));

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
        /// TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPMinProperty =
            DependencyProperty.Register("TargetBar_OPMin", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double TargetBar_OPMin
        {
            get { return (double)this.GetValue(TargetBar_OPMinProperty); }
            set { this.SetValue(TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPMaxProperty =
            DependencyProperty.Register("TargetBar_OPMax", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double TargetBar_OPMax
        {
            get { return (double)this.GetValue(TargetBar_OPMaxProperty); }
            set { this.SetValue(TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVProperty =
            DependencyProperty.Register("TargetBar_PV", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PV
        {
            get { return (double)this.GetValue(TargetBar_PVProperty); }
            set { this.SetValue(TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPProperty =
            DependencyProperty.Register("TargetBar_OP", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_OP
        {
            get { return (double)this.GetValue(TargetBar_OPProperty); }
            set { this.SetValue(TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_SPProperty =
            DependencyProperty.Register("TargetBar_SP", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_SP
        {
            get { return (double)this.GetValue(TargetBar_SPProperty); }
            set { this.SetValue(TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_MDProperty =
            DependencyProperty.Register("TargetBar_MD", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_MD
        {
            get { return (double)this.GetValue(TargetBar_MDProperty); }
            set { this.SetValue(TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_MD_VISProperty =
            DependencyProperty.Register("TargetBar_MD_VIS", typeof(bool), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(TargetBar_MD_VISProperty); }
            set { this.SetValue(TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVMaxProperty =
            DependencyProperty.Register("TargetBar_PVMax", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PVMax
        {
            get { return (double)this.GetValue(TargetBar_PVMaxProperty); }
            set { this.SetValue(TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVMinProperty =
            DependencyProperty.Register("TargetBar_PVMin", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PVMin
        {
            get { return (double)this.GetValue(TargetBar_PVMinProperty); }
            set { this.SetValue(TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_SP_VISProperty =
            DependencyProperty.Register("TargetBar_SP_VIS", typeof(bool), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(TargetBar_SP_VISProperty); }
            set { this.SetValue(TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty SP_Value_FailProperty =
            DependencyProperty.Register("SP_Value_Fail", typeof(bool), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SP_Value_Fail
        {
            get { return (bool)this.GetValue(SP_Value_FailProperty); }
            set { this.SetValue(SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// SP_Value Property
        /// </summary>
        public static readonly DependencyProperty SP_ValueProperty =
            DependencyProperty.Register("SP_Value", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SP_Value
        {
            get { return (double)this.GetValue(SP_ValueProperty); }
            set { this.SetValue(SP_ValueProperty, value); }
        }

        /// <summary>
        /// PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty PV_Value_FailProperty =
            DependencyProperty.Register("PV_Value_Fail", typeof(bool), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PV_Value_Fail
        {
            get { return (bool)this.GetValue(PV_Value_FailProperty); }
            set { this.SetValue(PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// PV_Value Property
        /// </summary>
        public static readonly DependencyProperty PV_ValueProperty =
            DependencyProperty.Register("PV_Value", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV_Value
        {
            get { return (double)this.GetValue(PV_ValueProperty); }
            set { this.SetValue(PV_ValueProperty, value); }
        }

        /// <summary>
        /// OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty OP_Value_FailProperty =
            DependencyProperty.Register("OP_Value_Fail", typeof(bool), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OP_Value_Fail
        {
            get { return (bool)this.GetValue(OP_Value_FailProperty); }
            set { this.SetValue(OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// OP_Value Property
        /// </summary>
        public static readonly DependencyProperty OP_ValueProperty =
            DependencyProperty.Register("OP_Value", typeof(double), typeof(ContFpSpeedNoDCS));

        /// <summary>
        /// Gets or sets the OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OP_Value
        {
            get { return (double)this.GetValue(OP_ValueProperty); }
            set { this.SetValue(OP_ValueProperty, value); }
        }


		
		
    }
}
