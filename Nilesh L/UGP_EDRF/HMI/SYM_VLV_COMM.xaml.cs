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
    public class SYM_VLV_COMM : RSIControlModel
    {
        static SYM_VLV_COMM()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_VLV_COMM), new FrameworkPropertyMetadata(typeof(SYM_VLV_COMM)));
        }

		public SYM_VLV_COMM()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_VLV_COMM));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK_OPN Property
        /// </summary>
        public static readonly DependencyProperty BLK_OPNProperty =
            DependencyProperty.Register("BLK_OPN", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the BLK_OPN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_OPN
        {
            get { return (string)this.GetValue(BLK_OPNProperty); }
            set { this.SetValue(BLK_OPNProperty, value); }
        }

        /// <summary>
        /// BLK_CLS Property
        /// </summary>
        public static readonly DependencyProperty BLK_CLSProperty =
            DependencyProperty.Register("BLK_CLS", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the BLK_CLS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_CLS
        {
            get { return (string)this.GetValue(BLK_CLSProperty); }
            set { this.SetValue(BLK_CLSProperty, value); }
        }

        /// <summary>
        /// BLK_MIS Property
        /// </summary>
        public static readonly DependencyProperty BLK_MISProperty =
            DependencyProperty.Register("BLK_MIS", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the BLK_MIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_MIS
        {
            get { return (string)this.GetValue(BLK_MISProperty); }
            set { this.SetValue(BLK_MISProperty, value); }
        }

        /// <summary>
        /// OPN Property
        /// </summary>
        public static readonly DependencyProperty OPNProperty =
            DependencyProperty.Register("OPN", typeof(bool), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the OPN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OPN
        {
            get { return (bool)this.GetValue(OPNProperty); }
            set { this.SetValue(OPNProperty, value); }
        }

        /// <summary>
        /// CLS Property
        /// </summary>
        public static readonly DependencyProperty CLSProperty =
            DependencyProperty.Register("CLS", typeof(bool), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the CLS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CLS
        {
            get { return (bool)this.GetValue(CLSProperty); }
            set { this.SetValue(CLSProperty, value); }
        }

        /// <summary>
        /// MIS Property
        /// </summary>
        public static readonly DependencyProperty MISProperty =
            DependencyProperty.Register("MIS", typeof(bool), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the MIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MIS
        {
            get { return (bool)this.GetValue(MISProperty); }
            set { this.SetValue(MISProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_VLV_COMM));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_VLV_COMM));

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
        /// ORIENTATION Property
        /// </summary>
        public static readonly DependencyProperty ORIENTATIONProperty =
            DependencyProperty.Register("ORIENTATION", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the ORIENTATION.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ORIENTATION
        {
            get { return (string)this.GetValue(ORIENTATIONProperty); }
            set { this.SetValue(ORIENTATIONProperty, value); }
        }

        /// <summary>
        /// STAT Property
        /// </summary>
        public static readonly DependencyProperty STATProperty =
            DependencyProperty.Register("STAT", typeof(string), typeof(SYM_VLV_COMM));

        /// <summary>
        /// Gets or sets the STAT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STAT
        {
            get { return (string)this.GetValue(STATProperty); }
            set { this.SetValue(STATProperty, value); }
        }

        /// <summary>
        /// TYPE Property
        /// </summary>
        public static readonly DependencyProperty TYPEProperty =
            DependencyProperty.Register("TYPE", typeof(string), typeof(SYM_VLV_COMM));

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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK_OPN)) yield return new Param("$BLK_OPN", this.BLK_OPN);
if (!string.IsNullOrWhiteSpace(this.BLK_CLS)) yield return new Param("$BLK_CLS", this.BLK_CLS);
if (!string.IsNullOrWhiteSpace(this.BLK_MIS)) yield return new Param("$BLK_MIS", this.BLK_MIS);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);

            }
        }

		
    }
}
