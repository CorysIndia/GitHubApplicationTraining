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
    public class CHART_2 : RSIControlModel
    {
        static CHART_2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CHART_2), new FrameworkPropertyMetadata(typeof(CHART_2)));
        }

		public CHART_2()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(CHART_2));

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
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(CHART_2));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(CHART_2));

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
        /// FP_NAME Property
        /// </summary>
        public static readonly DependencyProperty FP_NAMEProperty =
            DependencyProperty.Register("FP_NAME", typeof(string), typeof(CHART_2));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(CHART_2));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(CHART_2));

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
        /// Title Property
        /// </summary>
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the Title.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
        }

        /// <summary>
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(CHART_2));

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
        /// STEP_NO Property
        /// </summary>
        public static readonly DependencyProperty STEP_NOProperty =
            DependencyProperty.Register("STEP_NO", typeof(int), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the STEP_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int STEP_NO
        {
            get { return (int)this.GetValue(STEP_NOProperty); }
            set { this.SetValue(STEP_NOProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_FIN_OverlayName", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_FIN_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_FIN_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_TagnameProperty =
            DependencyProperty.Register("CallOverlay_FIN_Tagname", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_FIN_TagnameProperty); }
            set { this.SetValue(CallOverlay_FIN_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_LOCProperty =
            DependencyProperty.Register("CallOverlay_FIN_LOC", typeof(int), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_FIN_LOC
        {
            get { return (int)this.GetValue(CallOverlay_FIN_LOCProperty); }
            set { this.SetValue(CallOverlay_FIN_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_FIN_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL2", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL3", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL4", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL5", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_FIN_BLKOVL6", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_FIN_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_FIN_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_FIN_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL2", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL3", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL4", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVLProperty); }
            set { this.SetValue(CallOverlay_FIN_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL2", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL2Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL3", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL3Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PRTProperty =
            DependencyProperty.Register("CallOverlay_FIN_PRT", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PRT
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PRTProperty); }
            set { this.SetValue(CallOverlay_FIN_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_FIN_PAROVL4", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_FIN_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_FIN_PAROVL4Property); }
            set { this.SetValue(CallOverlay_FIN_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL5", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlay_FIN_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_FIN_CMPOVL6", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlay_FIN_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_FIN_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_FIN_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_FIN_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_FIN_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_FIN_DSCRP", typeof(string), typeof(CHART_2));

        /// <summary>
        /// Gets or sets the CallOverlay_FIN_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlay_FIN_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_FIN_DSCRPProperty); }
            set { this.SetValue(CallOverlay_FIN_DSCRPProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.FP_NAME)) yield return new Param("$FP_NAME", this.FP_NAME);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.Title)) yield return new Param("$Title", this.Title);
if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);

            }
        }

		
    }
}
