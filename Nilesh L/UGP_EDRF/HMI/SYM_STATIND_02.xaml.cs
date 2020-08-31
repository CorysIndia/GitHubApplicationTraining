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
    public class SYM_STATIND_02 : RSIControlModel
    {
        static SYM_STATIND_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_STATIND_02), new FrameworkPropertyMetadata(typeof(SYM_STATIND_02)));
        }

		public SYM_STATIND_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_STATIND_02));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_STATIND_02));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_STATIND_02));

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
        /// _PAR Property
        /// </summary>
        public static readonly DependencyProperty _PARProperty =
            DependencyProperty.Register("_PAR", typeof(bool), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the _PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _PAR
        {
            get { return (bool)this.GetValue(_PARProperty); }
            set { this.SetValue(_PARProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_STATIND_02));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAR
        {
            get { return (string)this.GetValue(PARProperty); }
            set { this.SetValue(PARProperty, value); }
        }

        /// <summary>
        /// TEXT0 Property
        /// </summary>
        public static readonly DependencyProperty TEXT0Property =
            DependencyProperty.Register("TEXT0", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the TEXT0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT0
        {
            get { return (string)this.GetValue(TEXT0Property); }
            set { this.SetValue(TEXT0Property, value); }
        }

        /// <summary>
        /// TEXT1 Property
        /// </summary>
        public static readonly DependencyProperty TEXT1Property =
            DependencyProperty.Register("TEXT1", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the TEXT1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TEXT1
        {
            get { return (string)this.GetValue(TEXT1Property); }
            set { this.SetValue(TEXT1Property, value); }
        }

        /// <summary>
        /// FP_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_NAMEProperty =
            DependencyProperty.Register("FP_NAME", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the FP_NAME.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_NAME
        {
            get { return (string)this.GetValue(FP_NAMEProperty); }
            set { this.SetValue(FP_NAMEProperty, value); }
        }

        /// <summary>
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_STATIND_02));

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
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the TAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TAG
        {
            get { return (string)this.GetValue(TAGProperty); }
            set { this.SetValue(TAGProperty, value); }
        }

        /// <summary>
        /// FP Property
        /// </summary>
        public static readonly DependencyProperty FPProperty =
            DependencyProperty.Register("FP", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the FP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP
        {
            get { return (string)this.GetValue(FPProperty); }
            set { this.SetValue(FPProperty, value); }
        }

        /// <summary>
        /// STATUS_ALARM Property
        /// </summary>
        public static readonly DependencyProperty STATUS_ALARMProperty =
            DependencyProperty.Register("STATUS_ALARM", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the STATUS_ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STATUS_ALARM
        {
            get { return (string)this.GetValue(STATUS_ALARMProperty); }
            set { this.SetValue(STATUS_ALARMProperty, value); }
        }

        /// <summary>
        /// BLINK Property
        /// </summary>
        public static readonly DependencyProperty BLINKProperty =
            DependencyProperty.Register("BLINK", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the BLINK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLINK
        {
            get { return (string)this.GetValue(BLINKProperty); }
            set { this.SetValue(BLINKProperty, value); }
        }

        /// <summary>
        /// ALARM_TYPE Property
        /// </summary>
        public static readonly DependencyProperty ALARM_TYPEProperty =
            DependencyProperty.Register("ALARM_TYPE", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the ALARM_TYPE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM_TYPE
        {
            get { return (string)this.GetValue(ALARM_TYPEProperty); }
            set { this.SetValue(ALARM_TYPEProperty, value); }
        }

        /// <summary>
        /// Boolean_NoBlink_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty Boolean_NoBlink_ALARM_CONProperty =
            DependencyProperty.Register("Boolean_NoBlink_ALARM_CON", typeof(bool), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the Boolean_NoBlink_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Boolean_NoBlink_ALARM_CON
        {
            get { return (bool)this.GetValue(Boolean_NoBlink_ALARM_CONProperty); }
            set { this.SetValue(Boolean_NoBlink_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// Boolean_Blink_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty Boolean_Blink_ALARM_CONProperty =
            DependencyProperty.Register("Boolean_Blink_ALARM_CON", typeof(bool), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the Boolean_Blink_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Boolean_Blink_ALARM_CON
        {
            get { return (bool)this.GetValue(Boolean_Blink_ALARM_CONProperty); }
            set { this.SetValue(Boolean_Blink_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// ALMSTA__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty ALMSTA__CONN1Property =
            DependencyProperty.Register("ALMSTA__CONN1", typeof(int), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the ALMSTA__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALMSTA__CONN1
        {
            get { return (int)this.GetValue(ALMSTA__CONN1Property); }
            set { this.SetValue(ALMSTA__CONN1Property, value); }
        }

        /// <summary>
        /// CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_OverlayName", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_Tagname", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_LOC", typeof(int), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL2", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL3", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL4", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL5", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_BLKOVL6", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL2", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL3", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL4", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_PAROVL", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_PAROVL2", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_PAROVL3", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_PRT", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_PAROVL4", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL5", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_CMPOVL6", typeof(string), typeof(SYM_STATIND_02));

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
            DependencyProperty.Register("CallOverlay_DSCRP", typeof(string), typeof(SYM_STATIND_02));

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

        /// <summary>
        /// ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_STATIND_02));

        /// <summary>
        /// Gets or sets the ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ACK_SYMBOL_UNACK_1Property, value); }
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
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
if (!string.IsNullOrWhiteSpace(this.TEXT0)) yield return new Param("$TEXT0", this.TEXT0);
if (!string.IsNullOrWhiteSpace(this.TEXT1)) yield return new Param("$TEXT1", this.TEXT1);
if (!string.IsNullOrWhiteSpace(this.FP_NAME)) yield return new Param("$FP_NAME", this.FP_NAME);

            }
        }

		
    }
}
