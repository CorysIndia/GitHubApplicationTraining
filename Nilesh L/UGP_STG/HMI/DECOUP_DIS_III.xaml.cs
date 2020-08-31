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
    public class DECOUP_DIS_III : RSIControlModel
    {
        static DECOUP_DIS_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DECOUP_DIS_III), new FrameworkPropertyMetadata(typeof(DECOUP_DIS_III)));
        }

		public DECOUP_DIS_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DECOUP_DIS_III));

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
        /// ASV Property
        /// </summary>
        public static readonly DependencyProperty ASVProperty =
            DependencyProperty.Register("ASV", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the ASV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the anti-surge valve demand. ")]
        public double ASV
        {
            get { return (double)this.GetValue(ASVProperty); }
            set { this.SetValue(ASVProperty, value); }
        }

        /// <summary>
        /// ASVDcpl Property
        /// </summary>
        public static readonly DependencyProperty ASVDcplProperty =
            DependencyProperty.Register("ASVDcpl", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the ASVDcpl.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupling demand to the anti-surge controller (typically rDCPL_SRG_OP)")]
        public double ASVDcpl
        {
            get { return (double)this.GetValue(ASVDcplProperty); }
            set { this.SetValue(ASVDcplProperty, value); }
        }

        /// <summary>
        /// VPoint Property
        /// </summary>
        public static readonly DependencyProperty VPointProperty =
            DependencyProperty.Register("VPoint", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the VPoint.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the decoupler surge valve/process control V point (typically kDCPL_V_POINT).")]
        public double VPoint
        {
            get { return (double)this.GetValue(VPointProperty); }
            set { this.SetValue(VPointProperty, value); }
        }

        /// <summary>
        /// DynBP Property
        /// </summary>
        public static readonly DependencyProperty DynBPProperty =
            DependencyProperty.Register("DynBP", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the DynBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupler dynamic breakpoint (typically rDCPL_DYN_BKPT).")]
        public double DynBP
        {
            get { return (double)this.GetValue(DynBPProperty); }
            set { this.SetValue(DynBPProperty, value); }
        }

        /// <summary>
        /// ProcOP Property
        /// </summary>
        public static readonly DependencyProperty ProcOPProperty =
            DependencyProperty.Register("ProcOP", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the ProcOP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of the process controller output.  This is the tagname that goes into the demand of the decoupler block.")]
        public double ProcOP
        {
            get { return (double)this.GetValue(ProcOPProperty); }
            set { this.SetValue(ProcOPProperty, value); }
        }

        /// <summary>
        /// PerfTrk Property
        /// </summary>
        public static readonly DependencyProperty PerfTrkProperty =
            DependencyProperty.Register("PerfTrk", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the PerfTrk.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of the performance controller tracking value.  It needs to be scaled 0 to 100%.  This is the same tagname that goes to the Process_Trk in the decoupler block.")]
        public double PerfTrk
        {
            get { return (double)this.GetValue(PerfTrkProperty); }
            set { this.SetValue(PerfTrkProperty, value); }
        }

        /// <summary>
        /// PerfMin Property
        /// </summary>
        public static readonly DependencyProperty PerfMinProperty =
            DependencyProperty.Register("PerfMin", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the PerfMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the value (motor) or tagname (turbine) for the minimum performance controller on the decoupler. (100 for motor, kMINGOV for turbine)")]
        public double PerfMin
        {
            get { return (double)this.GetValue(PerfMinProperty); }
            set { this.SetValue(PerfMinProperty, value); }
        }

        /// <summary>
        /// PerfMax Property
        /// </summary>
        public static readonly DependencyProperty PerfMaxProperty =
            DependencyProperty.Register("PerfMax", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the PerfMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the value (motor) or tagname (turbine) for the maximum performance controller on the decoupler. (100 for motor, kMAXGOV for turbine)")]
        public double PerfMax
        {
            get { return (double)this.GetValue(PerfMaxProperty); }
            set { this.SetValue(PerfMaxProperty, value); }
        }

        /// <summary>
        /// PerfDcpl Property
        /// </summary>
        public static readonly DependencyProperty PerfDcplProperty =
            DependencyProperty.Register("PerfDcpl", typeof(double), typeof(DECOUP_DIS_III));

        /// <summary>
        /// Gets or sets the PerfDcpl.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname for the decoupling demand to the performance controller (typically rDCPL_PROC_OP)")]
        public double PerfDcpl
        {
            get { return (double)this.GetValue(PerfDcplProperty); }
            set { this.SetValue(PerfDcplProperty, value); }
        }


		
		
    }
}
