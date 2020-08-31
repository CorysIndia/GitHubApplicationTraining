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
    public class DRAIN_RESET : RSIControlModel
    {
        static DRAIN_RESET()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DRAIN_RESET), new FrameworkPropertyMetadata(typeof(DRAIN_RESET)));
        }

		public DRAIN_RESET()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(DRAIN_RESET));

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
        /// TRIG Property
        /// </summary>
        public static readonly DependencyProperty TRIGProperty =
            DependencyProperty.Register("TRIG", typeof(bool), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the TRIG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRIG
        {
            get { return (bool)this.GetValue(TRIGProperty); }
            set { this.SetValue(TRIGProperty, value); }
        }

        /// <summary>
        /// CONN1 Property
        /// </summary>
        public static readonly DependencyProperty CONN1Property =
            DependencyProperty.Register("CONN1", typeof(bool), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CONN1
        {
            get { return (bool)this.GetValue(CONN1Property); }
            set { this.SetValue(CONN1Property, value); }
        }

        /// <summary>
        /// CONN2 Property
        /// </summary>
        public static readonly DependencyProperty CONN2Property =
            DependencyProperty.Register("CONN2", typeof(bool), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the CONN2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CONN2
        {
            get { return (bool)this.GetValue(CONN2Property); }
            set { this.SetValue(CONN2Property, value); }
        }

        /// <summary>
        /// CONN3 Property
        /// </summary>
        public static readonly DependencyProperty CONN3Property =
            DependencyProperty.Register("CONN3", typeof(bool), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the CONN3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CONN3
        {
            get { return (bool)this.GetValue(CONN3Property); }
            set { this.SetValue(CONN3Property, value); }
        }

        /// <summary>
        /// CONN4 Property
        /// </summary>
        public static readonly DependencyProperty CONN4Property =
            DependencyProperty.Register("CONN4", typeof(bool), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the CONN4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CONN4
        {
            get { return (bool)this.GetValue(CONN4Property); }
            set { this.SetValue(CONN4Property, value); }
        }

        /// <summary>
        /// No_Of_Connections Property
        /// </summary>
        public static readonly DependencyProperty No_Of_ConnectionsProperty =
            DependencyProperty.Register("No_Of_Connections", typeof(string), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the No_Of_Connections.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string No_Of_Connections
        {
            get { return (string)this.GetValue(No_Of_ConnectionsProperty); }
            set { this.SetValue(No_Of_ConnectionsProperty, value); }
        }

        /// <summary>
        /// TRIGGER_TYPE Property
        /// </summary>
        public static readonly DependencyProperty TRIGGER_TYPEProperty =
            DependencyProperty.Register("TRIGGER_TYPE", typeof(string), typeof(DRAIN_RESET));

        /// <summary>
        /// Gets or sets the TRIGGER_TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TRIGGER_TYPE
        {
            get { return (string)this.GetValue(TRIGGER_TYPEProperty); }
            set { this.SetValue(TRIGGER_TYPEProperty, value); }
        }


		
		
    }
}
