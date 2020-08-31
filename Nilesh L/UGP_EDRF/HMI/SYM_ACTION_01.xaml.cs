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
    public class SYM_ACTION_01 : RSIControlModel
    {
        static SYM_ACTION_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ACTION_01), new FrameworkPropertyMetadata(typeof(SYM_ACTION_01)));
        }

		public SYM_ACTION_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ACTION_01));

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
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL
        {
            get { return (string)this.GetValue(CMPOVLProperty); }
            set { this.SetValue(CMPOVLProperty, value); }
        }

        /// <summary>
        /// CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL2Property =
            DependencyProperty.Register("CMPOVL2", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL2
        {
            get { return (string)this.GetValue(CMPOVL2Property); }
            set { this.SetValue(CMPOVL2Property, value); }
        }

        /// <summary>
        /// CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL3Property =
            DependencyProperty.Register("CMPOVL3", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL3
        {
            get { return (string)this.GetValue(CMPOVL3Property); }
            set { this.SetValue(CMPOVL3Property, value); }
        }

        /// <summary>
        /// CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL4Property =
            DependencyProperty.Register("CMPOVL4", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL4
        {
            get { return (string)this.GetValue(CMPOVL4Property); }
            set { this.SetValue(CMPOVL4Property, value); }
        }

        /// <summary>
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL
        {
            get { return (string)this.GetValue(BLKOVLProperty); }
            set { this.SetValue(BLKOVLProperty, value); }
        }

        /// <summary>
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL2
        {
            get { return (string)this.GetValue(BLKOVL2Property); }
            set { this.SetValue(BLKOVL2Property, value); }
        }

        /// <summary>
        /// BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL3Property =
            DependencyProperty.Register("BLKOVL3", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL3
        {
            get { return (string)this.GetValue(BLKOVL3Property); }
            set { this.SetValue(BLKOVL3Property, value); }
        }

        /// <summary>
        /// BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL4Property =
            DependencyProperty.Register("BLKOVL4", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL4
        {
            get { return (string)this.GetValue(BLKOVL4Property); }
            set { this.SetValue(BLKOVL4Property, value); }
        }

        /// <summary>
        /// BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL5Property =
            DependencyProperty.Register("BLKOVL5", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL5
        {
            get { return (string)this.GetValue(BLKOVL5Property); }
            set { this.SetValue(BLKOVL5Property, value); }
        }

        /// <summary>
        /// BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL6Property =
            DependencyProperty.Register("BLKOVL6", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKOVL6
        {
            get { return (string)this.GetValue(BLKOVL6Property); }
            set { this.SetValue(BLKOVL6Property, value); }
        }

        /// <summary>
        /// PAROVL Property
        /// </summary>
        public static readonly DependencyProperty PAROVLProperty =
            DependencyProperty.Register("PAROVL", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL
        {
            get { return (string)this.GetValue(PAROVLProperty); }
            set { this.SetValue(PAROVLProperty, value); }
        }

        /// <summary>
        /// PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL2Property =
            DependencyProperty.Register("PAROVL2", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL2
        {
            get { return (string)this.GetValue(PAROVL2Property); }
            set { this.SetValue(PAROVL2Property, value); }
        }

        /// <summary>
        /// PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL3Property =
            DependencyProperty.Register("PAROVL3", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL3
        {
            get { return (string)this.GetValue(PAROVL3Property); }
            set { this.SetValue(PAROVL3Property, value); }
        }

        /// <summary>
        /// OVL Property
        /// </summary>
        public static readonly DependencyProperty OVLProperty =
            DependencyProperty.Register("OVL", typeof(string), typeof(SYM_ACTION_01));

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
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_ACTION_01));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_ACTION_01));

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
        /// DSCRP Property
        /// </summary>
        public static readonly DependencyProperty DSCRPProperty =
            DependencyProperty.Register("DSCRP", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DSCRP
        {
            get { return (string)this.GetValue(DSCRPProperty); }
            set { this.SetValue(DSCRPProperty, value); }
        }

        /// <summary>
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_ACTION_01));

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
        /// PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL4Property =
            DependencyProperty.Register("PAROVL4", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PAROVL4
        {
            get { return (string)this.GetValue(PAROVL4Property); }
            set { this.SetValue(PAROVL4Property, value); }
        }

        /// <summary>
        /// CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL5Property =
            DependencyProperty.Register("CMPOVL5", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL5
        {
            get { return (string)this.GetValue(CMPOVL5Property); }
            set { this.SetValue(CMPOVL5Property, value); }
        }

        /// <summary>
        /// CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL6Property =
            DependencyProperty.Register("CMPOVL6", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMPOVL6
        {
            get { return (string)this.GetValue(CMPOVL6Property); }
            set { this.SetValue(CMPOVL6Property, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_ACTION_01));

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
        /// CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_OverlayName", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_Tagname", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_LOC", typeof(int), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL2", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL3", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL4", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL5", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_BLKOVL6", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_CMPOVL", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_CMPOVL2", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_CMPOVL3", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_CMPOVL4", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_PAROVL", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_PAROVL2", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_PAROVL3", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_PRT", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_PAROVL4", typeof(string), typeof(SYM_ACTION_01));

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
            DependencyProperty.Register("CallOverlay_CMPOVL5", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_CMPOVL6", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DSCRP", typeof(string), typeof(SYM_ACTION_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
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

				if (!string.IsNullOrWhiteSpace(this.CMPOVL)) yield return new Param("$CMPOVL", this.CMPOVL);
if (!string.IsNullOrWhiteSpace(this.CMPOVL2)) yield return new Param("$CMPOVL2", this.CMPOVL2);
if (!string.IsNullOrWhiteSpace(this.CMPOVL3)) yield return new Param("$CMPOVL3", this.CMPOVL3);
if (!string.IsNullOrWhiteSpace(this.CMPOVL4)) yield return new Param("$CMPOVL4", this.CMPOVL4);
if (!string.IsNullOrWhiteSpace(this.BLKOVL)) yield return new Param("$BLKOVL", this.BLKOVL);
if (!string.IsNullOrWhiteSpace(this.BLKOVL2)) yield return new Param("$BLKOVL2", this.BLKOVL2);
if (!string.IsNullOrWhiteSpace(this.BLKOVL3)) yield return new Param("$BLKOVL3", this.BLKOVL3);
if (!string.IsNullOrWhiteSpace(this.BLKOVL4)) yield return new Param("$BLKOVL4", this.BLKOVL4);
if (!string.IsNullOrWhiteSpace(this.BLKOVL5)) yield return new Param("$BLKOVL5", this.BLKOVL5);
if (!string.IsNullOrWhiteSpace(this.BLKOVL6)) yield return new Param("$BLKOVL6", this.BLKOVL6);
if (!string.IsNullOrWhiteSpace(this.PAROVL)) yield return new Param("$PAROVL", this.PAROVL);
if (!string.IsNullOrWhiteSpace(this.PAROVL2)) yield return new Param("$PAROVL2", this.PAROVL2);
if (!string.IsNullOrWhiteSpace(this.PAROVL3)) yield return new Param("$PAROVL3", this.PAROVL3);
if (!string.IsNullOrWhiteSpace(this.OVL)) yield return new Param("$OVL", this.OVL);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.DSCRP)) yield return new Param("$DSCRP", this.DSCRP);
if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PAROVL4)) yield return new Param("$PAROVL4", this.PAROVL4);
if (!string.IsNullOrWhiteSpace(this.CMPOVL5)) yield return new Param("$CMPOVL5", this.CMPOVL5);
if (!string.IsNullOrWhiteSpace(this.CMPOVL6)) yield return new Param("$CMPOVL6", this.CMPOVL6);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);

            }
        }

		
    }
}
