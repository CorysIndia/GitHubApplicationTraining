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
    public class SGUG_CallTrendOvl : RSIControlModel
    {
        static SGUG_CallTrendOvl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SGUG_CallTrendOvl), new FrameworkPropertyMetadata(typeof(SGUG_CallTrendOvl)));
        }

		public SGUG_CallTrendOvl()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SGUG_CallTrendOvl));

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
        /// CMPBLKPAR1 Property
        /// </summary>
        public static readonly DependencyProperty CMPBLKPAR1Property =
            DependencyProperty.Register("CMPBLKPAR1", typeof(string), typeof(SGUG_CallTrendOvl));

        /// <summary>
        /// Gets or sets the CMPBLKPAR1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPBLKPAR1
        {
            get { return (string)this.GetValue(CMPBLKPAR1Property); }
            set { this.SetValue(CMPBLKPAR1Property, value); }
        }

        /// <summary>
        /// CMPBLKPAR2 Property
        /// </summary>
        public static readonly DependencyProperty CMPBLKPAR2Property =
            DependencyProperty.Register("CMPBLKPAR2", typeof(string), typeof(SGUG_CallTrendOvl));

        /// <summary>
        /// Gets or sets the CMPBLKPAR2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPBLKPAR2
        {
            get { return (string)this.GetValue(CMPBLKPAR2Property); }
            set { this.SetValue(CMPBLKPAR2Property, value); }
        }

        /// <summary>
        /// CMPBLKPAR3 Property
        /// </summary>
        public static readonly DependencyProperty CMPBLKPAR3Property =
            DependencyProperty.Register("CMPBLKPAR3", typeof(string), typeof(SGUG_CallTrendOvl));

        /// <summary>
        /// Gets or sets the CMPBLKPAR3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPBLKPAR3
        {
            get { return (string)this.GetValue(CMPBLKPAR3Property); }
            set { this.SetValue(CMPBLKPAR3Property, value); }
        }

        /// <summary>
        /// CMPBLKPAR4 Property
        /// </summary>
        public static readonly DependencyProperty CMPBLKPAR4Property =
            DependencyProperty.Register("CMPBLKPAR4", typeof(string), typeof(SGUG_CallTrendOvl));

        /// <summary>
        /// Gets or sets the CMPBLKPAR4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPBLKPAR4
        {
            get { return (string)this.GetValue(CMPBLKPAR4Property); }
            set { this.SetValue(CMPBLKPAR4Property, value); }
        }

        /// <summary>
        /// Identity Property
        /// </summary>
        public static readonly DependencyProperty IdentityProperty =
            DependencyProperty.Register("Identity", typeof(string), typeof(SGUG_CallTrendOvl));

        /// <summary>
        /// Gets or sets the Identity.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Compound+BLock")]
        public string Identity
        {
            get { return (string)this.GetValue(IdentityProperty); }
            set { this.SetValue(IdentityProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMPBLKPAR1)) yield return new Param("$CMPBLKPAR1", this.CMPBLKPAR1);
if (!string.IsNullOrWhiteSpace(this.CMPBLKPAR2)) yield return new Param("$CMPBLKPAR2", this.CMPBLKPAR2);
if (!string.IsNullOrWhiteSpace(this.CMPBLKPAR3)) yield return new Param("$CMPBLKPAR3", this.CMPBLKPAR3);
if (!string.IsNullOrWhiteSpace(this.CMPBLKPAR4)) yield return new Param("$CMPBLKPAR4", this.CMPBLKPAR4);
if (!string.IsNullOrWhiteSpace(this.Identity)) yield return new Param("$Identity", this.Identity);

            }
        }

		
    }
}
