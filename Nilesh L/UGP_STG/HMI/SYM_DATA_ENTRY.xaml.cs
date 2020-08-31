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
    public class SYM_DATA_ENTRY : RSIControlModel
    {
        static SYM_DATA_ENTRY()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_DATA_ENTRY), new FrameworkPropertyMetadata(typeof(SYM_DATA_ENTRY)));
        }

		public SYM_DATA_ENTRY()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_DATA_ENTRY));

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
        /// CMP_BLK_PAR Property
        /// </summary>
        public static readonly DependencyProperty CMP_BLK_PARProperty =
            DependencyProperty.Register("CMP_BLK_PAR", typeof(string), typeof(SYM_DATA_ENTRY));

        /// <summary>
        /// Gets or sets the CMP_BLK_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_BLK_PAR
        {
            get { return (string)this.GetValue(CMP_BLK_PARProperty); }
            set { this.SetValue(CMP_BLK_PARProperty, value); }
        }

        /// <summary>
        /// _DATA Property
        /// </summary>
        public static readonly DependencyProperty _DATAProperty =
            DependencyProperty.Register("_DATA", typeof(string), typeof(SYM_DATA_ENTRY));

        /// <summary>
        /// Gets or sets the _DATA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _DATA
        {
            get { return (string)this.GetValue(_DATAProperty); }
            set { this.SetValue(_DATAProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP_BLK_PAR)) yield return new Param("$CMP_BLK_PAR", this.CMP_BLK_PAR);
if (!string.IsNullOrWhiteSpace(this._DATA)) yield return new Param("$_DATA", this._DATA);

            }
        }

		
    }
}
