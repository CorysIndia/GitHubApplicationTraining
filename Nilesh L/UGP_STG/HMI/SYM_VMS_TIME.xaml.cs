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
    public class SYM_VMS_TIME : RSIControlModel
    {
        static SYM_VMS_TIME()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VMS_TIME), new FrameworkPropertyMetadata(typeof(SYM_VMS_TIME)));
        }

		public SYM_VMS_TIME()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VMS_TIME));

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
        /// YEAR Property
        /// </summary>
        public static readonly DependencyProperty YEARProperty =
            DependencyProperty.Register("YEAR", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the YEAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int YEAR
        {
            get { return (int)this.GetValue(YEARProperty); }
            set { this.SetValue(YEARProperty, value); }
        }

        /// <summary>
        /// MONTH Property
        /// </summary>
        public static readonly DependencyProperty MONTHProperty =
            DependencyProperty.Register("MONTH", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the MONTH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MONTH
        {
            get { return (int)this.GetValue(MONTHProperty); }
            set { this.SetValue(MONTHProperty, value); }
        }

        /// <summary>
        /// DAY Property
        /// </summary>
        public static readonly DependencyProperty DAYProperty =
            DependencyProperty.Register("DAY", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the DAY.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int DAY
        {
            get { return (int)this.GetValue(DAYProperty); }
            set { this.SetValue(DAYProperty, value); }
        }

        /// <summary>
        /// HOUR Property
        /// </summary>
        public static readonly DependencyProperty HOURProperty =
            DependencyProperty.Register("HOUR", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the HOUR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HOUR
        {
            get { return (int)this.GetValue(HOURProperty); }
            set { this.SetValue(HOURProperty, value); }
        }

        /// <summary>
        /// MIN Property
        /// </summary>
        public static readonly DependencyProperty MINProperty =
            DependencyProperty.Register("MIN", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int MIN
        {
            get { return (int)this.GetValue(MINProperty); }
            set { this.SetValue(MINProperty, value); }
        }

        /// <summary>
        /// SEC Property
        /// </summary>
        public static readonly DependencyProperty SECProperty =
            DependencyProperty.Register("SEC", typeof(int), typeof(SYM_VMS_TIME));

        /// <summary>
        /// Gets or sets the SEC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SEC
        {
            get { return (int)this.GetValue(SECProperty); }
            set { this.SetValue(SECProperty, value); }
        }


		
		
    }
}
