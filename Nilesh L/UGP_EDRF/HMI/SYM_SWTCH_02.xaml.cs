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
    public class SYM_SWTCH_02 : RSIControlModel
    {
        static SYM_SWTCH_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SWTCH_02), new FrameworkPropertyMetadata(typeof(SYM_SWTCH_02)));
        }

		public SYM_SWTCH_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SWTCH_02));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_SWTCH_02));

        /// <summary>
        /// Gets or sets the LOOP_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOOP_ID
        {
            get { return (string)this.GetValue(LOOP_IDProperty); }
            set { this.SetValue(LOOP_IDProperty, value); }
        }

        /// <summary>
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_SWTCH_02));

        /// <summary>
        /// Gets or sets the TAGNAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAGNAME
        {
            get { return (string)this.GetValue(TAGNAMEProperty); }
            set { this.SetValue(TAGNAMEProperty, value); }
        }

        /// <summary>
        /// CBP Property
        /// </summary>
        public static readonly DependencyProperty CBPProperty =
            DependencyProperty.Register("CBP", typeof(string), typeof(SYM_SWTCH_02));

        /// <summary>
        /// Gets or sets the CBP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CBP
        {
            get { return (string)this.GetValue(CBPProperty); }
            set { this.SetValue(CBPProperty, value); }
        }

        /// <summary>
        /// CONN Property
        /// </summary>
        public static readonly DependencyProperty CONNProperty =
            DependencyProperty.Register("CONN", typeof(int), typeof(SYM_SWTCH_02));

        /// <summary>
        /// Gets or sets the CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CONN
        {
            get { return (int)this.GetValue(CONNProperty); }
            set { this.SetValue(CONNProperty, value); }
        }

        /// <summary>
        /// Connection Property
        /// </summary>
        public static readonly DependencyProperty ConnectionProperty =
            DependencyProperty.Register("Connection", typeof(string), typeof(SYM_SWTCH_02));

        /// <summary>
        /// Gets or sets the Connection.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Connection
        {
            get { return (string)this.GetValue(ConnectionProperty); }
            set { this.SetValue(ConnectionProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.CBP)) yield return new Param("$CBP", this.CBP);

            }
        }

		
    }
}
