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
    public class SYM_SOV : RSIControlModel
    {
        static SYM_SOV()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SOV), new FrameworkPropertyMetadata(typeof(SYM_SOV)));
        }

		public SYM_SOV()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SOV));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_SOV));

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

        //START
        /// <summary>
        /// LABEL Property
        /// </summary>
        public static readonly DependencyProperty LABELProperty =
            DependencyProperty.Register("LABEL", typeof(string), typeof(SYM_SOV));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_SOV));

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
        /// COUT Property
        /// </summary>
        public static readonly DependencyProperty COUTProperty =
            DependencyProperty.Register("COUT", typeof(bool), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the COUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool COUT
        {
            get { return (bool)this.GetValue(COUTProperty); }
            set { this.SetValue(COUTProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_SOV));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_SOV));

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
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_SOV));

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
        /// VLV_ID Property
        /// </summary>
        public static readonly DependencyProperty VLV_IDProperty =
            DependencyProperty.Register("VLV_ID", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the VLV_ID.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VLV_ID
        {
            get { return (string)this.GetValue(VLV_IDProperty); }
            set { this.SetValue(VLV_IDProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_SOV));

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
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Orientation.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Orientation
        {
            get { return (string)this.GetValue(OrientationProperty); }
            set { this.SetValue(OrientationProperty, value); }
        }

        /// <summary>
        /// Overlay Property
        /// </summary>
        public static readonly DependencyProperty OverlayProperty =
            DependencyProperty.Register("Overlay", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay
        {
            get { return (string)this.GetValue(OverlayProperty); }
            set { this.SetValue(OverlayProperty, value); }
        }

        /// <summary>
        /// Overlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty Overlay_OverlayNameProperty =
            DependencyProperty.Register("Overlay_OverlayName", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_OverlayName
        {
            get { return (string)this.GetValue(Overlay_OverlayNameProperty); }
            set { this.SetValue(Overlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVLProperty =
            DependencyProperty.Register("Overlay_BLKOVL", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL
        {
            get { return (string)this.GetValue(Overlay_BLKOVLProperty); }
            set { this.SetValue(Overlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVL2Property =
            DependencyProperty.Register("Overlay_BLKOVL2", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL2
        {
            get { return (string)this.GetValue(Overlay_BLKOVL2Property); }
            set { this.SetValue(Overlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVL3Property =
            DependencyProperty.Register("Overlay_BLKOVL3", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL3
        {
            get { return (string)this.GetValue(Overlay_BLKOVL3Property); }
            set { this.SetValue(Overlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVL4Property =
            DependencyProperty.Register("Overlay_BLKOVL4", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL4
        {
            get { return (string)this.GetValue(Overlay_BLKOVL4Property); }
            set { this.SetValue(Overlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVL5Property =
            DependencyProperty.Register("Overlay_BLKOVL5", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL5
        {
            get { return (string)this.GetValue(Overlay_BLKOVL5Property); }
            set { this.SetValue(Overlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_BLKOVL6Property =
            DependencyProperty.Register("Overlay_BLKOVL6", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_BLKOVL6
        {
            get { return (string)this.GetValue(Overlay_BLKOVL6Property); }
            set { this.SetValue(Overlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVLProperty =
            DependencyProperty.Register("Overlay_CMPOVL", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL
        {
            get { return (string)this.GetValue(Overlay_CMPOVLProperty); }
            set { this.SetValue(Overlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVL2Property =
            DependencyProperty.Register("Overlay_CMPOVL2", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL2
        {
            get { return (string)this.GetValue(Overlay_CMPOVL2Property); }
            set { this.SetValue(Overlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVL3Property =
            DependencyProperty.Register("Overlay_CMPOVL3", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL3
        {
            get { return (string)this.GetValue(Overlay_CMPOVL3Property); }
            set { this.SetValue(Overlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVL4Property =
            DependencyProperty.Register("Overlay_CMPOVL4", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL4
        {
            get { return (string)this.GetValue(Overlay_CMPOVL4Property); }
            set { this.SetValue(Overlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVL5Property =
            DependencyProperty.Register("Overlay_CMPOVL5", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL5
        {
            get { return (string)this.GetValue(Overlay_CMPOVL5Property); }
            set { this.SetValue(Overlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// Overlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_CMPOVL6Property =
            DependencyProperty.Register("Overlay_CMPOVL6", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_CMPOVL6
        {
            get { return (string)this.GetValue(Overlay_CMPOVL6Property); }
            set { this.SetValue(Overlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// Overlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty Overlay_DSCRPProperty =
            DependencyProperty.Register("Overlay_DSCRP", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_DSCRP
        {
            get { return (string)this.GetValue(Overlay_DSCRPProperty); }
            set { this.SetValue(Overlay_DSCRPProperty, value); }
        }

        /// <summary>
        /// Overlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty Overlay_LOCProperty =
            DependencyProperty.Register("Overlay_LOC", typeof(int), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Overlay_LOC
        {
            get { return (int)this.GetValue(Overlay_LOCProperty); }
            set { this.SetValue(Overlay_LOCProperty, value); }
        }

        /// <summary>
        /// Overlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty Overlay_PAROVLProperty =
            DependencyProperty.Register("Overlay_PAROVL", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_PAROVL
        {
            get { return (string)this.GetValue(Overlay_PAROVLProperty); }
            set { this.SetValue(Overlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// Overlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_PAROVL2Property =
            DependencyProperty.Register("Overlay_PAROVL2", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_PAROVL2
        {
            get { return (string)this.GetValue(Overlay_PAROVL2Property); }
            set { this.SetValue(Overlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// Overlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_PAROVL3Property =
            DependencyProperty.Register("Overlay_PAROVL3", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_PAROVL3
        {
            get { return (string)this.GetValue(Overlay_PAROVL3Property); }
            set { this.SetValue(Overlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// Overlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty Overlay_PAROVL4Property =
            DependencyProperty.Register("Overlay_PAROVL4", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_PAROVL4
        {
            get { return (string)this.GetValue(Overlay_PAROVL4Property); }
            set { this.SetValue(Overlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// Overlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty Overlay_PRTProperty =
            DependencyProperty.Register("Overlay_PRT", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_PRT
        {
            get { return (string)this.GetValue(Overlay_PRTProperty); }
            set { this.SetValue(Overlay_PRTProperty, value); }
        }

        /// <summary>
        /// Overlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty Overlay_TagnameProperty =
            DependencyProperty.Register("Overlay_Tagname", typeof(string), typeof(SYM_SOV));

        /// <summary>
        /// Gets or sets the Overlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Tagname
        {
            get { return (string)this.GetValue(Overlay_TagnameProperty); }
            set { this.SetValue(Overlay_TagnameProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.VLV_ID)) yield return new Param("$VLV_ID", this.VLV_ID);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.LABEL)) yield return new Param("$LABEL", this.LABEL);

            }
        }

		
    }
}
