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
    public class SYM_GM9601 : RSIControlModel
    {
        static SYM_GM9601()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_GM9601), new FrameworkPropertyMetadata(typeof(SYM_GM9601)));
        }

		public SYM_GM9601()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_GM9601));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_GM9601));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_GM9601));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_GM9601));

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
        /// _RUN Property
        /// </summary>
        public static readonly DependencyProperty _RUNProperty =
            DependencyProperty.Register("_RUN", typeof(bool), typeof(SYM_GM9601));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_GM9601));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_GM9601));

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
        /// OVL Property
        /// </summary>
        public static readonly DependencyProperty OVLProperty =
            DependencyProperty.Register("OVL", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the OVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OVL
        {
            get { return (string)this.GetValue(OVLProperty); }
            set { this.SetValue(OVLProperty, value); }
        }

        /// <summary>
        /// _FAULT Property
        /// </summary>
        public static readonly DependencyProperty _FAULTProperty =
            DependencyProperty.Register("_FAULT", typeof(bool), typeof(SYM_GM9601));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_GM9601));

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
        /// _HAND Property
        /// </summary>
        public static readonly DependencyProperty _HANDProperty =
            DependencyProperty.Register("_HAND", typeof(bool), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the _HAND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _HAND
        {
            get { return (bool)this.GetValue(_HANDProperty); }
            set { this.SetValue(_HANDProperty, value); }
        }

        /// <summary>
        /// _REMOTE Property
        /// </summary>
        public static readonly DependencyProperty _REMOTEProperty =
            DependencyProperty.Register("_REMOTE", typeof(bool), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the _REMOTE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _REMOTE
        {
            get { return (bool)this.GetValue(_REMOTEProperty); }
            set { this.SetValue(_REMOTEProperty, value); }
        }

        /// <summary>
        /// _MA Property
        /// </summary>
        public static readonly DependencyProperty _MAProperty =
            DependencyProperty.Register("_MA", typeof(bool), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the _MA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _MA
        {
            get { return (bool)this.GetValue(_MAProperty); }
            set { this.SetValue(_MAProperty, value); }
        }

        /// <summary>
        /// _CALCA Property
        /// </summary>
        public static readonly DependencyProperty _CALCAProperty =
            DependencyProperty.Register("_CALCA", typeof(string), typeof(SYM_GM9601));

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
        /// UNACK Property
        /// </summary>
        public static readonly DependencyProperty UNACKProperty =
            DependencyProperty.Register("UNACK", typeof(bool), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the UNACK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool UNACK
        {
            get { return (bool)this.GetValue(UNACKProperty); }
            set { this.SetValue(UNACKProperty, value); }
        }

        /// <summary>
        /// _DS Property
        /// </summary>
        public static readonly DependencyProperty _DSProperty =
            DependencyProperty.Register("_DS", typeof(bool), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the _DS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _DS
        {
            get { return (bool)this.GetValue(_DSProperty); }
            set { this.SetValue(_DSProperty, value); }
        }

        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_GM9601));

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
        /// MISMATCH_CB Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH_CBProperty =
            DependencyProperty.Register("MISMATCH_CB", typeof(string), typeof(SYM_GM9601));

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

        /// <summary>
        /// MainACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty MainACK_UNACK_1Property =
            DependencyProperty.Register("MainACK_UNACK_1", typeof(string), typeof(SYM_GM9601));

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
            DependencyProperty.Register("FaultAck_UNACK_1", typeof(string), typeof(SYM_GM9601));

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
        /// CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_OverlayName", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_TagnameProperty =
            DependencyProperty.Register("CallOverlay_Tagname", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_TagnameProperty); }
            set { this.SetValue(CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_LOCProperty =
            DependencyProperty.Register("CallOverlay_LOC", typeof(int), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_LOC
        {
            get { return (int)this.GetValue(CallOverlay_LOCProperty); }
            set { this.SetValue(CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_BLKOVL", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_BLKOVL2", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_BLKOVL3", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_BLKOVL4", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_BLKOVL5", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_BLKOVL6", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_CMPOVL", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_CMPOVL2", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_CMPOVL3", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_CMPOVL4", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_PAROVL", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_PAROVLProperty); }
            set { this.SetValue(CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_PAROVL2", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL2Property); }
            set { this.SetValue(CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_PAROVL3", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL3Property); }
            set { this.SetValue(CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PRTProperty =
            DependencyProperty.Register("CallOverlay_PRT", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PRT
        {
            get { return (string)this.GetValue(CallOverlay_PRTProperty); }
            set { this.SetValue(CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_PAROVL4", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_PAROVL4Property); }
            set { this.SetValue(CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_CMPOVL5", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_CMPOVL6", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DSCRP", typeof(string), typeof(SYM_GM9601));

        /// <summary>
        /// Gets or sets the CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_DSCRPProperty); }
            set { this.SetValue(CallOverlay_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.OVL)) yield return new Param("$OVL", this.OVL);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this._CALCA)) yield return new Param("$_CALCA", this._CALCA);

            }
        }

		
    }
}
