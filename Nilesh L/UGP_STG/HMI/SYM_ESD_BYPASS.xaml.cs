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
    public class SYM_ESD_BYPASS : RSIControlModel
    {
        static SYM_ESD_BYPASS()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ESD_BYPASS), new FrameworkPropertyMetadata(typeof(SYM_ESD_BYPASS)));
        }

		public SYM_ESD_BYPASS()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ESD_BYPASS));

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
        /// PICK1 Property
        /// </summary>
        public static readonly DependencyProperty PICK1Property =
            DependencyProperty.Register("PICK1", typeof(string), typeof(SYM_ESD_BYPASS));

        /// <summary>
        /// Gets or sets the PICK1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK1
        {
            get { return (string)this.GetValue(PICK1Property); }
            set { this.SetValue(PICK1Property, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_ESD_BYPASS));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PRT
        {
            get { return (string)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// PICK2 Property
        /// </summary>
        public static readonly DependencyProperty PICK2Property =
            DependencyProperty.Register("PICK2", typeof(string), typeof(SYM_ESD_BYPASS));

        /// <summary>
        /// Gets or sets the PICK2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK2
        {
            get { return (string)this.GetValue(PICK2Property); }
            set { this.SetValue(PICK2Property, value); }
        }

        /// <summary>
        /// BP Property
        /// </summary>
        public static readonly DependencyProperty BPProperty =
            DependencyProperty.Register("BP", typeof(bool), typeof(SYM_ESD_BYPASS));

        /// <summary>
        /// Gets or sets the BP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool BP
        {
            get { return (bool)this.GetValue(BPProperty); }
            set { this.SetValue(BPProperty, value); }
        }

        /// <summary>
        /// FB Property
        /// </summary>
        public static readonly DependencyProperty FBProperty =
            DependencyProperty.Register("FB", typeof(bool), typeof(SYM_ESD_BYPASS));

        /// <summary>
        /// Gets or sets the FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FB
        {
            get { return (bool)this.GetValue(FBProperty); }
            set { this.SetValue(FBProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.PICK1)) yield return new Param("$PICK1", this.PICK1);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.PICK2)) yield return new Param("$PICK2", this.PICK2);

            }
        }

		
    }
}
