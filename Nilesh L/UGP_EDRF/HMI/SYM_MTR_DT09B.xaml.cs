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
    public class SYM_MTR_DT09B : RSIControlModel
    {
        static SYM_MTR_DT09B()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_MTR_DT09B), new FrameworkPropertyMetadata(typeof(SYM_MTR_DT09B)));
        }

		public SYM_MTR_DT09B()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_MTR_DT09B));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_MTR_DT09B));

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

        //START
        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the LABEL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LABEL
        {
            get { return (string)this.GetValue(LABELProperty); }
            set { this.SetValue(LABELProperty, value); }
        }

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_MTR_DT09B));

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
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_MTR_DT09B));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_MTR_DT09B));

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
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LOC
        {
            get { return (string)this.GetValue(LOCProperty); }
            set { this.SetValue(LOCProperty, value); }
        }

        /// <summary>
        /// _UNACK Property
        /// </summary>
        public static readonly DependencyProperty _UNACKProperty =
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(SYM_MTR_DT09B));

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
        /// _FAULT Property
        /// </summary>
        public static readonly DependencyProperty _FAULTProperty =
            DependencyProperty.Register("_FAULT", typeof(bool), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the _FAULT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _FAULT
        {
            get { return (bool)this.GetValue(_FAULTProperty); }
            set { this.SetValue(_FAULTProperty, value); }
        }

        /// <summary>
        /// _TRIP Property
        /// </summary>
        public static readonly DependencyProperty _TRIPProperty =
            DependencyProperty.Register("_TRIP", typeof(bool), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the _TRIP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _TRIP
        {
            get { return (bool)this.GetValue(_TRIPProperty); }
            set { this.SetValue(_TRIPProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_MTR_DT09B));

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
        /// _RUN Property
        /// </summary>
        public static readonly DependencyProperty _RUNProperty =
            DependencyProperty.Register("_RUN", typeof(bool), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the _RUN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _RUN
        {
            get { return (bool)this.GetValue(_RUNProperty); }
            set { this.SetValue(_RUNProperty, value); }
        }

        /// <summary>
        /// _CALCA Property
        /// </summary>
        public static readonly DependencyProperty _CALCAProperty =
            DependencyProperty.Register("_CALCA", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the _CALCA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _CALCA
        {
            get { return (string)this.GetValue(_CALCAProperty); }
            set { this.SetValue(_CALCAProperty, value); }
        }

        /// <summary>
        /// MainACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty MainACK_UNACK_1Property =
            DependencyProperty.Register("MainACK_UNACK_1", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the MainACK_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MainACK_UNACK_1
        {
            get { return (string)this.GetValue(MainACK_UNACK_1Property); }
            set { this.SetValue(MainACK_UNACK_1Property, value); }
        }

        /// <summary>
        /// FaultAck_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty FaultAck_UNACK_1Property =
            DependencyProperty.Register("FaultAck_UNACK_1", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the FaultAck_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FaultAck_UNACK_1
        {
            get { return (string)this.GetValue(FaultAck_UNACK_1Property); }
            set { this.SetValue(FaultAck_UNACK_1Property, value); }
        }

        /// <summary>
        /// MISMATCH_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_CBProperty =
            DependencyProperty.Register("MISMATCH_CB", typeof(string), typeof(SYM_MTR_DT09B));

        /// <summary>
        /// Gets or sets the MISMATCH_CB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MISMATCH_CB
        {
            get { return (string)this.GetValue(MISMATCH_CBProperty); }
            set { this.SetValue(MISMATCH_CBProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this._CALCA)) yield return new Param("$_CALCA", this._CALCA);
if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);

            }
        }

		
    }
}
