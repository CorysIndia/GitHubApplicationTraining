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
    public class FP_Alarm_Flag : RSIControlModel
    {
        static FP_Alarm_Flag()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FP_Alarm_Flag), new FrameworkPropertyMetadata(typeof(FP_Alarm_Flag)));
        }

		public FP_Alarm_Flag()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(FP_Alarm_Flag));

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
        /// HHAOPT Property
        /// </summary>
        public static readonly DependencyProperty HHAOPTProperty =
            DependencyProperty.Register("HHAOPT", typeof(int), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the HHAOPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HHAOPT
        {
            get { return (int)this.GetValue(HHAOPTProperty); }
            set { this.SetValue(HHAOPTProperty, value); }
        }

        /// <summary>
        /// HLOP Property
        /// </summary>
        public static readonly DependencyProperty HLOPProperty =
            DependencyProperty.Register("HLOP", typeof(int), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the HLOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HLOP
        {
            get { return (int)this.GetValue(HLOPProperty); }
            set { this.SetValue(HLOPProperty, value); }
        }

        /// <summary>
        /// HHALIM Property
        /// </summary>
        public static readonly DependencyProperty HHALIMProperty =
            DependencyProperty.Register("HHALIM", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the HHALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HHALIM
        {
            get { return (double)this.GetValue(HHALIMProperty); }
            set { this.SetValue(HHALIMProperty, value); }
        }

        /// <summary>
        /// LLALIM Property
        /// </summary>
        public static readonly DependencyProperty LLALIMProperty =
            DependencyProperty.Register("LLALIM", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the LLALIM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LLALIM
        {
            get { return (double)this.GetValue(LLALIMProperty); }
            set { this.SetValue(LLALIMProperty, value); }
        }

        /// <summary>
        /// HAL Property
        /// </summary>
        public static readonly DependencyProperty HALProperty =
            DependencyProperty.Register("HAL", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the HAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HAL
        {
            get { return (double)this.GetValue(HALProperty); }
            set { this.SetValue(HALProperty, value); }
        }

        /// <summary>
        /// LAL Property
        /// </summary>
        public static readonly DependencyProperty LALProperty =
            DependencyProperty.Register("LAL", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the LAL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LAL
        {
            get { return (double)this.GetValue(LALProperty); }
            set { this.SetValue(LALProperty, value); }
        }

        /// <summary>
        /// MinRange Property
        /// </summary>
        public static readonly DependencyProperty MinRangeProperty =
            DependencyProperty.Register("MinRange", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the MinRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MinRange
        {
            get { return (double)this.GetValue(MinRangeProperty); }
            set { this.SetValue(MinRangeProperty, value); }
        }

        /// <summary>
        /// MaxRange Property
        /// </summary>
        public static readonly DependencyProperty MaxRangeProperty =
            DependencyProperty.Register("MaxRange", typeof(double), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the MaxRange.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double MaxRange
        {
            get { return (double)this.GetValue(MaxRangeProperty); }
            set { this.SetValue(MaxRangeProperty, value); }
        }

        /// <summary>
        /// MoveUp Property
        /// </summary>
        public static readonly DependencyProperty MoveUpProperty =
            DependencyProperty.Register("MoveUp", typeof(int), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the MoveUp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MoveUp
        {
            get { return (int)this.GetValue(MoveUpProperty); }
            set { this.SetValue(MoveUpProperty, value); }
        }

        /// <summary>
        /// MoveDown Property
        /// </summary>
        public static readonly DependencyProperty MoveDownProperty =
            DependencyProperty.Register("MoveDown", typeof(int), typeof(FP_Alarm_Flag));

        /// <summary>
        /// Gets or sets the MoveDown.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MoveDown
        {
            get { return (int)this.GetValue(MoveDownProperty); }
            set { this.SetValue(MoveDownProperty, value); }
        }


		
		
    }
}
