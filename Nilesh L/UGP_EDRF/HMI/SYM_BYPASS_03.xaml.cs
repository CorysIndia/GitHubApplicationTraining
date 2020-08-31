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
    public class SYM_BYPASS_03 : RSIControlModel
    {
        static SYM_BYPASS_03()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_BYPASS_03), new FrameworkPropertyMetadata(typeof(SYM_BYPASS_03)));
        }

		public SYM_BYPASS_03()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_BYPASS_03));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_BYPASS_03));

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
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the _ALMSTA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA
        {
            get { return (int)this.GetValue(_ALMSTAProperty); }
            set { this.SetValue(_ALMSTAProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_BYPASS_03));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_BYPASS_03));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_BYPASS_03));

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
        /// PICK1 Property
        /// </summary>
        public static readonly DependencyProperty PICK1Property =
            DependencyProperty.Register("PICK1", typeof(string), typeof(SYM_BYPASS_03));

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
        /// _DESCRP Property
        /// </summary>
        public static readonly DependencyProperty _DESCRPProperty =
            DependencyProperty.Register("_DESCRP", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the _DESCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _DESCRP
        {
            get { return (string)this.GetValue(_DESCRPProperty); }
            set { this.SetValue(_DESCRPProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK
        {
            get { return (string)this.GetValue(BLKProperty); }
            set { this.SetValue(BLKProperty, value); }
        }

        /// <summary>
        /// _FB Property
        /// </summary>
        public static readonly DependencyProperty _FBProperty =
            DependencyProperty.Register("_FB", typeof(bool), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the _FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _FB
        {
            get { return (bool)this.GetValue(_FBProperty); }
            set { this.SetValue(_FBProperty, value); }
        }

        /// <summary>
        /// _BPBLK Property
        /// </summary>
        public static readonly DependencyProperty _BPBLKProperty =
            DependencyProperty.Register("_BPBLK", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the _BPBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _BPBLK
        {
            get { return (string)this.GetValue(_BPBLKProperty); }
            set { this.SetValue(_BPBLKProperty, value); }
        }

        /// <summary>
        /// _FPBLK Property
        /// </summary>
        public static readonly DependencyProperty _FPBLKProperty =
            DependencyProperty.Register("_FPBLK", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the _FPBLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _FPBLK
        {
            get { return (string)this.GetValue(_FPBLKProperty); }
            set { this.SetValue(_FPBLKProperty, value); }
        }

        /// <summary>
        /// PICK2 Property
        /// </summary>
        public static readonly DependencyProperty PICK2Property =
            DependencyProperty.Register("PICK2", typeof(string), typeof(SYM_BYPASS_03));

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
        /// background Property
        /// </summary>
        public static readonly DependencyProperty backgroundProperty =
            DependencyProperty.Register("background", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the background.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string background
        {
            get { return (string)this.GetValue(backgroundProperty); }
            set { this.SetValue(backgroundProperty, value); }
        }

        /// <summary>
        /// SGUG_ALARMBOARDER_21__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty SGUG_ALARMBOARDER_21__CONN1Property =
            DependencyProperty.Register("SGUG_ALARMBOARDER_21__CONN1", typeof(int), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the SGUG_ALARMBOARDER_21__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SGUG_ALARMBOARDER_21__CONN1
        {
            get { return (int)this.GetValue(SGUG_ALARMBOARDER_21__CONN1Property); }
            set { this.SetValue(SGUG_ALARMBOARDER_21__CONN1Property, value); }
        }

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the ACK_SYMBOL1_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_SYMBOL1_UNACK_1
        {
            get { return (string)this.GetValue(ACK_SYMBOL1_UNACK_1Property); }
            set { this.SetValue(ACK_SYMBOL1_UNACK_1Property, value); }
        }

        /// <summary>
        /// TAGNAME_COUT Property
        /// </summary>
        public static readonly DependencyProperty TAGNAME2Property =
            DependencyProperty.Register("TAGNAME2", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the TAGNAME_COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAGNAME2
        {
            get { return (string)this.GetValue(TAGNAME2Property); }
            set { this.SetValue(TAGNAME2Property, value); }
        }

        /// <summary>
        /// TAGNAME_COUT Property
        /// </summary>
        public static readonly DependencyProperty MRST_BLKProperty =
            DependencyProperty.Register("MRST_BLK", typeof(string), typeof(SYM_BYPASS_03));

        /// <summary>
        /// Gets or sets the TAGNAME_COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MRST_BLK
        {
            get { return (string)this.GetValue(MRST_BLKProperty); }
            set { this.SetValue(MRST_BLKProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.PICK1)) yield return new Param("$PICK1", this.PICK1);
if (!string.IsNullOrWhiteSpace(this._DESCRP)) yield return new Param("$_DESCRP", this._DESCRP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this._BPBLK)) yield return new Param("$_BPBLK", this._BPBLK);
if (!string.IsNullOrWhiteSpace(this._FPBLK)) yield return new Param("$_FPBLK", this._FPBLK);
if (!string.IsNullOrWhiteSpace(this.PICK2)) yield return new Param("$PICK2", this.PICK2);
                if (!string.IsNullOrWhiteSpace(this.TAGNAME2)) yield return new Param("$TAGNAME2", this.TAGNAME2);
                if (!string.IsNullOrWhiteSpace(this.MRST_BLK)) yield return new Param("$MRST_BLK", this.MRST_BLK);


            }
        }

		
    }
}
