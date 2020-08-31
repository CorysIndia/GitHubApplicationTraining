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
    public class SYM_ALMIND_02 : RSIControlModel
    {
        static SYM_ALMIND_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ALMIND_02), new FrameworkPropertyMetadata(typeof(SYM_ALMIND_02)));
        }

		public SYM_ALMIND_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("_PAR", typeof(bool), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_ALMIND_02));

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
            DependencyProperty.Register("PAR", typeof(string), typeof(SYM_ALMIND_02));

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
        /// FP_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_NAMEProperty =
            DependencyProperty.Register("FP_NAME", typeof(string), typeof(SYM_ALMIND_02));

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
        /// TAG Property
        /// </summary>
        public static readonly DependencyProperty TAGProperty =
            DependencyProperty.Register("TAG", typeof(string), typeof(SYM_ALMIND_02));

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

        //START
        /// <summary>
        /// IAS_CIN1 Property
        /// </summary>
        public static readonly DependencyProperty IAS_CIN1Property =
            DependencyProperty.Register("IAS_CIN1", typeof(string), typeof(SYM_ALMIND_01));

        /// <summary>
        /// Gets or sets the IAS_CIN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string IAS_CIN1
        {
            get { return (string)this.GetValue(IAS_CIN1Property); }
            set { this.SetValue(IAS_CIN1Property, value); }
        }

        /// <summary>
        /// FP Property
        /// </summary>
        public static readonly DependencyProperty FPProperty =
            DependencyProperty.Register("FP", typeof(string), typeof(SYM_ALMIND_02));

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
        /// Gen_ALarm_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty Gen_ALarm_ALARM_CONProperty =
            DependencyProperty.Register("Gen_ALarm_ALARM_CON", typeof(bool), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the Gen_ALarm_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Gen_ALarm_ALARM_CON
        {
            get { return (bool)this.GetValue(Gen_ALarm_ALARM_CONProperty); }
            set { this.SetValue(Gen_ALarm_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay_OverlayName", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay_Tagname", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay_LOC", typeof(int), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay_LOCProperty); }
            set { this.SetValue(FP_CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL2", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL3", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL4", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL5", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_BLKOVL6", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL2", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL3", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL4", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay_PAROVL", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay_PAROVL2", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay_PAROVL3", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay_PRT", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay_PRTProperty); }
            set { this.SetValue(FP_CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay_PAROVL4", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL5", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_CMPOVL6", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay_DSCRP", typeof(string), typeof(SYM_ALMIND_02));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.FP_NAME)) yield return new Param("$FP_NAME", this.FP_NAME);
if (!string.IsNullOrWhiteSpace(this.IAS_CIN1)) yield return new Param("$IAS_CIN1", this.IAS_CIN1);
            }
        }

		
    }
}
