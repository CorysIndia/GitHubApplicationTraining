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
    public class SYM_ALARMBORDER_04 : RSIControlModel
    {
        static SYM_ALARMBORDER_04()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALARMBORDER_04), new FrameworkPropertyMetadata(typeof(SYM_ALARMBORDER_04)));
        }

		public SYM_ALARMBORDER_04()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALARMBORDER_04));

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
            DependencyProperty.Register("CB", typeof(string), typeof(SYM_ALARMBORDER_04));

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
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(bool), typeof(SYM_ALARMBORDER_04));

        /// <summary>
        /// Gets or sets the _ALMSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _ALMSTA
        {
            get { return (bool)this.GetValue(_ALMSTAProperty); }
            set { this.SetValue(_ALMSTAProperty, value); }
        }

        /// <summary>
        /// _UNACK Property
        /// </summary>
        public static readonly DependencyProperty _UNACKProperty =
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(SYM_ALARMBORDER_04));

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
