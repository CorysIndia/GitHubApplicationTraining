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
    public class SYM_STATIND_COM : RSIControlModel
    {
        static SYM_STATIND_COM()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_STATIND_COM), new FrameworkPropertyMetadata(typeof(SYM_STATIND_COM)));
        }

		public SYM_STATIND_COM()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_STATIND_COM));

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
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("_UNACK", typeof(bool), typeof(SYM_STATIND_COM));

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
        /// _BAD Property
        /// </summary>
        public static readonly DependencyProperty _BADProperty =
            DependencyProperty.Register("_BAD", typeof(bool), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the _BAD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _BAD
        {
            get { return (bool)this.GetValue(_BADProperty); }
            set { this.SetValue(_BADProperty, value); }
        }

        /// <summary>
        /// _UNCERTAIN Property
        /// </summary>
        public static readonly DependencyProperty _UNCERTAINProperty =
            DependencyProperty.Register("_UNCERTAIN", typeof(bool), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the _UNCERTAIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _UNCERTAIN
        {
            get { return (bool)this.GetValue(_UNCERTAINProperty); }
            set { this.SetValue(_UNCERTAINProperty, value); }
        }

        /// <summary>
        /// _OOS Property
        /// </summary>
        public static readonly DependencyProperty _OOSProperty =
            DependencyProperty.Register("_OOS", typeof(bool), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the _OOS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _OOS
        {
            get { return (bool)this.GetValue(_OOSProperty); }
            set { this.SetValue(_OOSProperty, value); }
        }

        /// <summary>
        /// _CIN Property
        /// </summary>
        public static readonly DependencyProperty _CINProperty =
            DependencyProperty.Register("_CIN", typeof(bool), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the _CIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CIN
        {
            get { return (bool)this.GetValue(_CINProperty); }
            set { this.SetValue(_CINProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_STATIND_COM));

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
        /// TEXT0 Property
        /// </summary>
        public static readonly DependencyProperty TEXT0Property =
            DependencyProperty.Register("TEXT0", typeof(string), typeof(SYM_STATIND_COM));

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
            DependencyProperty.Register("TEXT1", typeof(string), typeof(SYM_STATIND_COM));

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
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type
        {
            get { return (string)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
        }

        /// <summary>
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(SYM_STATIND_COM));

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
        /// HH_LL__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty HH_LL__CONN1Property =
            DependencyProperty.Register("HH_LL__CONN1", typeof(int), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the HH_LL__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int HH_LL__CONN1
        {
            get { return (int)this.GetValue(HH_LL__CONN1Property); }
            set { this.SetValue(HH_LL__CONN1Property, value); }
        }

        /// <summary>
        /// H_L_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty H_L_ALARM_CONProperty =
            DependencyProperty.Register("H_L_ALARM_CON", typeof(int), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the H_L_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int H_L_ALARM_CON
        {
            get { return (int)this.GetValue(H_L_ALARM_CONProperty); }
            set { this.SetValue(H_L_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay1_OverlayName", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay1_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay1_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay1_Tagname", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay1_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay1_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay1_LOC", typeof(int), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay1_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay1_LOCProperty); }
            set { this.SetValue(FP_CallOverlay1_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL2", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL3", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL4", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL5", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL6", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL2", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL3", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL4", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay1_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL2", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL3", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay1_PRT", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PRTProperty); }
            set { this.SetValue(FP_CallOverlay1_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL4", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay1_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay1_DSCRP", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay1_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay1_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay1_DSCRPProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL6", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay1_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL5", typeof(string), typeof(SYM_STATIND_COM));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay1_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL5Property, value); }
        }

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_STATIND_COM));

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
if (!string.IsNullOrWhiteSpace(this.TEXT0)) yield return new Param("$TEXT0", this.TEXT0);
if (!string.IsNullOrWhiteSpace(this.TEXT1)) yield return new Param("$TEXT1", this.TEXT1);

            }
        }

		
    }
}
