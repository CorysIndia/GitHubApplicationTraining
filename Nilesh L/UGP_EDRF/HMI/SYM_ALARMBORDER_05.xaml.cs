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
    public class SYM_ALARMBORDER_05 : RSIControlModel
    {
        static SYM_ALARMBORDER_05()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALARMBORDER_05), new FrameworkPropertyMetadata(typeof(SYM_ALARMBORDER_05)));
        }

		public SYM_ALARMBORDER_05()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALARMBORDER_05));

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
        /// CB Property
        /// </summary>
        public static readonly DependencyProperty CBProperty =
            DependencyProperty.Register("CB", typeof(string), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CB
        {
            get { return (string)this.GetValue(CBProperty); }
            set { this.SetValue(CBProperty, value); }
        }

        /// <summary>
        /// _ALARM Property
        /// </summary>
        public static readonly DependencyProperty _ALARMProperty =
            DependencyProperty.Register("_ALARM", typeof(int), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the _ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALARM
        {
            get { return (int)this.GetValue(_ALARMProperty); }
            set { this.SetValue(_ALARMProperty, value); }
        }

        /// <summary>
        /// _UNACK Property
        /// </summary>
        public static readonly DependencyProperty _UNACKProperty =
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the _UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _UNACK
        {
            get { return (bool)this.GetValue(_UNACKProperty); }
            set { this.SetValue(_UNACKProperty, value); }
        }

        /// <summary>
        /// TRIG Property
        /// </summary>
        public static readonly DependencyProperty TRIGProperty =
            DependencyProperty.Register("TRIG", typeof(bool), typeof(SYM_ALARMBORDER_05));

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
        /// START_F Property
        /// </summary>
        public static readonly DependencyProperty START_FProperty =
            DependencyProperty.Register("START_F", typeof(bool), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the START_F.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool START_F
        {
            get { return (bool)this.GetValue(START_FProperty); }
            set { this.SetValue(START_FProperty, value); }
        }

        /// <summary>
        /// STOP_F Property
        /// </summary>
        public static readonly DependencyProperty STOP_FProperty =
            DependencyProperty.Register("STOP_F", typeof(bool), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the STOP_F.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool STOP_F
        {
            get { return (bool)this.GetValue(STOP_FProperty); }
            set { this.SetValue(STOP_FProperty, value); }
        }

        /// <summary>
        /// _CIN Property
        /// </summary>
        public static readonly DependencyProperty _CINProperty =
            DependencyProperty.Register("_CIN", typeof(bool), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the _CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CIN
        {
            get { return (bool)this.GetValue(_CINProperty); }
            set { this.SetValue(_CINProperty, value); }
        }

        /// <summary>
        /// MISMATCH Property
        /// </summary>
        public static readonly DependencyProperty MISMATCHProperty =
            DependencyProperty.Register("MISMATCH", typeof(bool), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the MISMATCH.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MISMATCH
        {
            get { return (bool)this.GetValue(MISMATCHProperty); }
            set { this.SetValue(MISMATCHProperty, value); }
        }

        /// <summary>
        /// TYPE Property
        /// </summary>
        public static readonly DependencyProperty TYPEProperty =
            DependencyProperty.Register("TYPE", typeof(string), typeof(SYM_ALARMBORDER_05));

        /// <summary>
        /// Gets or sets the TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TYPE
        {
            get { return (string)this.GetValue(TYPEProperty); }
            set { this.SetValue(TYPEProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CB)) yield return new Param("$CB", this.CB);

            }
        }

		
    }
}
