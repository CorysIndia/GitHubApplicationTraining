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
    public class SYM_ESD_FO_IND_01 : RSIControlModel
    {
        static SYM_ESD_FO_IND_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ESD_FO_IND_01), new FrameworkPropertyMetadata(typeof(SYM_ESD_FO_IND_01)));
        }

		public SYM_ESD_FO_IND_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ESD_FO_IND_01));

        /// <summary>
        /// DESCR Property
        /// </summary>
        public static readonly DependencyProperty DESCRProperty =
            DependencyProperty.Register("DESCR", typeof(string), typeof(SYM_ESD_FO_IND_01));

        /// <summary>
        /// Gets or sets the FU.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DESCR
        {
            get { return (string)this.GetValue(DESCRProperty); }
            set { this.SetValue(DESCRProperty, value); }
        }

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


		
         public static readonly DependencyProperty AlarmProperty = DependencyProperty.Register(AlarmPropertyName, typeof(string), typeof(SYM_ESD_FO_IND_01)); 
         public const string AlarmPropertyName = "Alarm";
         public string Alarm
         {
             get { return (string)this.GetValue(AlarmProperty); }
             set { this.SetValue(AlarmProperty, value); }
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
               
            }
        }

    }
}
