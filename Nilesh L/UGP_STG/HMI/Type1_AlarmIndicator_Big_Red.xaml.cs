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
    public class Type1_AlarmIndicator_Big_Red : RSIControlModel
    {
        static Type1_AlarmIndicator_Big_Red()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type1_AlarmIndicator_Big_Red), new FrameworkPropertyMetadata(typeof(Type1_AlarmIndicator_Big_Red)));
        }

		public Type1_AlarmIndicator_Big_Red()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type1_AlarmIndicator_Big_Red));

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
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(Type1_AlarmIndicator_Big_Red));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(Type1_AlarmIndicator_Big_Red));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }

        /// <summary>
        /// DESCR Property
        /// </summary>
        public static readonly DependencyProperty DESCRProperty =
            DependencyProperty.Register("DESCR", typeof(string), typeof(Type1_AlarmIndicator_Big_Red));

        /// <summary>
        /// Gets or sets the DESCR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCR
        {
            get { return (string)this.GetValue(DESCRProperty); }
            set { this.SetValue(DESCRProperty, value); }
        }

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(Type1_AlarmIndicator_Big_Red));

        /// <summary>
        /// Gets or sets the TAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG
        {
            get { return (string)this.GetValue(TAGProperty); }
            set { this.SetValue(TAGProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.DESCR)) yield return new Param("$DESCR", this.DESCR);
                if (!string.IsNullOrWhiteSpace(this.TAG)) yield return new Param("$TAG", this.TAG);
            }
        }
    }
}
