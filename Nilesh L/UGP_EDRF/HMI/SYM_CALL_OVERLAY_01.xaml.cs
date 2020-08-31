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
    public class SYM_CALL_OVERLAY_01 : RSIControlModel
    {
        static SYM_CALL_OVERLAY_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CALL_OVERLAY_01), new FrameworkPropertyMetadata(typeof(SYM_CALL_OVERLAY_01)));
        }

		public SYM_CALL_OVERLAY_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CALL_OVERLAY_01));

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
        /// OverlayName Property
        /// </summary>
        public static readonly DependencyProperty OverlayNameProperty =
            DependencyProperty.Register("OverlayName", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Name of Overlay to open")]
        public string OverlayName
        {
            get { return (string)this.GetValue(OverlayNameProperty); }
            set { this.SetValue(OverlayNameProperty, value); }
        }

        /// <summary>
        /// Tagname Property
        /// </summary>
        public static readonly DependencyProperty TagnameProperty =
            DependencyProperty.Register("Tagname", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Tagname of Symbol (Compound.Block) used to show context menu")]
        public string Tagname
        {
            get { return (string)this.GetValue(TagnameProperty); }
            set { this.SetValue(TagnameProperty, value); }
        }

        /// <summary>
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(int), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int LOC
        {
            get { return (int)this.GetValue(LOCProperty); }
            set { this.SetValue(LOCProperty, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Access Protection Level")]
        public string PRT
        {
            get { return (string)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 1")]
        public string CMPOVL
        {
            get { return (string)this.GetValue(CMPOVLProperty); }
            set { this.SetValue(CMPOVLProperty, value); }
        }

        /// <summary>
        /// CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL2Property =
            DependencyProperty.Register("CMPOVL2", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 2")]
        public string CMPOVL2
        {
            get { return (string)this.GetValue(CMPOVL2Property); }
            set { this.SetValue(CMPOVL2Property, value); }
        }

        /// <summary>
        /// CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL3Property =
            DependencyProperty.Register("CMPOVL3", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 3")]
        public string CMPOVL3
        {
            get { return (string)this.GetValue(CMPOVL3Property); }
            set { this.SetValue(CMPOVL3Property, value); }
        }

        /// <summary>
        /// CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL4Property =
            DependencyProperty.Register("CMPOVL4", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 4")]
        public string CMPOVL4
        {
            get { return (string)this.GetValue(CMPOVL4Property); }
            set { this.SetValue(CMPOVL4Property, value); }
        }

        /// <summary>
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 1 ")]
        public string BLKOVL
        {
            get { return (string)this.GetValue(BLKOVLProperty); }
            set { this.SetValue(BLKOVLProperty, value); }
        }

        /// <summary>
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 2")]
        public string BLKOVL2
        {
            get { return (string)this.GetValue(BLKOVL2Property); }
            set { this.SetValue(BLKOVL2Property, value); }
        }

        /// <summary>
        /// BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL3Property =
            DependencyProperty.Register("BLKOVL3", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 3")]
        public string BLKOVL3
        {
            get { return (string)this.GetValue(BLKOVL3Property); }
            set { this.SetValue(BLKOVL3Property, value); }
        }

        /// <summary>
        /// BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL4Property =
            DependencyProperty.Register("BLKOVL4", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 4")]
        public string BLKOVL4
        {
            get { return (string)this.GetValue(BLKOVL4Property); }
            set { this.SetValue(BLKOVL4Property, value); }
        }

        /// <summary>
        /// BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL5Property =
            DependencyProperty.Register("BLKOVL5", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 5")]
        public string BLKOVL5
        {
            get { return (string)this.GetValue(BLKOVL5Property); }
            set { this.SetValue(BLKOVL5Property, value); }
        }

        /// <summary>
        /// BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL6Property =
            DependencyProperty.Register("BLKOVL6", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 6")]
        public string BLKOVL6
        {
            get { return (string)this.GetValue(BLKOVL6Property); }
            set { this.SetValue(BLKOVL6Property, value); }
        }

        /// <summary>
        /// PAROVL Property
        /// </summary>
        public static readonly DependencyProperty PAROVLProperty =
            DependencyProperty.Register("PAROVL", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 1")]
        public string PAROVL
        {
            get { return (string)this.GetValue(PAROVLProperty); }
            set { this.SetValue(PAROVLProperty, value); }
        }

        /// <summary>
        /// PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL2Property =
            DependencyProperty.Register("PAROVL2", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 2")]
        public string PAROVL2
        {
            get { return (string)this.GetValue(PAROVL2Property); }
            set { this.SetValue(PAROVL2Property, value); }
        }

        /// <summary>
        /// PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL3Property =
            DependencyProperty.Register("PAROVL3", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 3")]
        public string PAROVL3
        {
            get { return (string)this.GetValue(PAROVL3Property); }
            set { this.SetValue(PAROVL3Property, value); }
        }

        /// <summary>
        /// Monitor Property
        /// </summary>
        public static readonly DependencyProperty MonitorProperty =
            DependencyProperty.Register("Monitor", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the Monitor.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Monitor
        {
            get { return (string)this.GetValue(MonitorProperty); }
            set { this.SetValue(MonitorProperty, value); }
        }

        /// <summary>
        /// UL_LOCKED Property
        /// </summary>
        public static readonly DependencyProperty UL_LOCKEDProperty =
            DependencyProperty.Register("UL_LOCKED", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the UL_LOCKED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Upper Left Corner is locked")]
        public bool UL_LOCKED
        {
            get { return (bool)this.GetValue(UL_LOCKEDProperty); }
            set { this.SetValue(UL_LOCKEDProperty, value); }
        }

        /// <summary>
        /// LL_LOCKED Property
        /// </summary>
        public static readonly DependencyProperty LL_LOCKEDProperty =
            DependencyProperty.Register("LL_LOCKED", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the LL_LOCKED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lower Left Corner is locked")]
        public bool LL_LOCKED
        {
            get { return (bool)this.GetValue(LL_LOCKEDProperty); }
            set { this.SetValue(LL_LOCKEDProperty, value); }
        }

        /// <summary>
        /// UR_LOCKED Property
        /// </summary>
        public static readonly DependencyProperty UR_LOCKEDProperty =
            DependencyProperty.Register("UR_LOCKED", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the UR_LOCKED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Upper Right Corner is locked")]
        public bool UR_LOCKED
        {
            get { return (bool)this.GetValue(UR_LOCKEDProperty); }
            set { this.SetValue(UR_LOCKEDProperty, value); }
        }

        /// <summary>
        /// LR_LOCKED Property
        /// </summary>
        public static readonly DependencyProperty LR_LOCKEDProperty =
            DependencyProperty.Register("LR_LOCKED", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the LR_LOCKED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lower Right Corner is locked")]
        public bool LR_LOCKED
        {
            get { return (bool)this.GetValue(LR_LOCKEDProperty); }
            set { this.SetValue(LR_LOCKEDProperty, value); }
        }

        /// <summary>
        /// UL_OPEN Property
        /// </summary>
        public static readonly DependencyProperty UL_OPENProperty =
            DependencyProperty.Register("UL_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the UL_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Upper Left Overlay is open")]
        public bool UL_OPEN
        {
            get { return (bool)this.GetValue(UL_OPENProperty); }
            set { this.SetValue(UL_OPENProperty, value); }
        }

        /// <summary>
        /// UR_OPEN Property
        /// </summary>
        public static readonly DependencyProperty UR_OPENProperty =
            DependencyProperty.Register("UR_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the UR_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Upper Right Overlay is open")]
        public bool UR_OPEN
        {
            get { return (bool)this.GetValue(UR_OPENProperty); }
            set { this.SetValue(UR_OPENProperty, value); }
        }

        /// <summary>
        /// LR_OPEN Property
        /// </summary>
        public static readonly DependencyProperty LR_OPENProperty =
            DependencyProperty.Register("LR_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the LR_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lower Right Overlay is open")]
        public bool LR_OPEN
        {
            get { return (bool)this.GetValue(LR_OPENProperty); }
            set { this.SetValue(LR_OPENProperty, value); }
        }

        /// <summary>
        /// LL_OPEN Property
        /// </summary>
        public static readonly DependencyProperty LL_OPENProperty =
            DependencyProperty.Register("LL_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the LL_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Lower Left Overlay is open")]
        public bool LL_OPEN
        {
            get { return (bool)this.GetValue(LL_OPENProperty); }
            set { this.SetValue(LL_OPENProperty, value); }
        }

        /// <summary>
        /// TOP_OPEN Property
        /// </summary>
        public static readonly DependencyProperty TOP_OPENProperty =
            DependencyProperty.Register("TOP_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the TOP_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Upper Center Overlay is open")]
        public bool TOP_OPEN
        {
            get { return (bool)this.GetValue(TOP_OPENProperty); }
            set { this.SetValue(TOP_OPENProperty, value); }
        }

        /// <summary>
        /// BOTTOM_OPEN Property
        /// </summary>
        public static readonly DependencyProperty BOTTOM_OPENProperty =
            DependencyProperty.Register("BOTTOM_OPEN", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the BOTTOM_OPEN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Bottom Center Overlay is open")]
        public bool BOTTOM_OPEN
        {
            get { return (bool)this.GetValue(BOTTOM_OPENProperty); }
            set { this.SetValue(BOTTOM_OPENProperty, value); }
        }

        /// <summary>
        /// OVL_MODE Property
        /// </summary>
        public static readonly DependencyProperty OVL_MODEProperty =
            DependencyProperty.Register("OVL_MODE", typeof(bool), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the OVL_MODE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Moveable / False = Fixed")]
        public bool OVL_MODE
        {
            get { return (bool)this.GetValue(OVL_MODEProperty); }
            set { this.SetValue(OVL_MODEProperty, value); }
        }

        /// <summary>
        /// PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty PAROVL4Property =
            DependencyProperty.Register("PAROVL4", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 4")]
        public string PAROVL4
        {
            get { return (string)this.GetValue(PAROVL4Property); }
            set { this.SetValue(PAROVL4Property, value); }
        }

        /// <summary>
        /// CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL5Property =
            DependencyProperty.Register("CMPOVL5", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CMPOVL5
        {
            get { return (string)this.GetValue(CMPOVL5Property); }
            set { this.SetValue(CMPOVL5Property, value); }
        }


        /// <summary>
        /// Overlay_Type Property
        /// </summary>
        public static readonly DependencyProperty Overlay_TypeProperty =
            DependencyProperty.Register("Overlay_Type", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the Overlay_Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Overlay_Type
        {
            get { return (string)this.GetValue(Overlay_TypeProperty); }
            set { this.SetValue(Overlay_TypeProperty, value); }
        }


        /// <summary>
        /// System_Type Property
        /// </summary>
        public static readonly DependencyProperty System_TypeProperty =
            DependencyProperty.Register("System_Type", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the System_Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string System_Type
        {
            get { return (string)this.GetValue(System_TypeProperty); }
            set { this.SetValue(System_TypeProperty, value); }
        }


        /// <summary>
        /// CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CMPOVL6Property =
            DependencyProperty.Register("CMPOVL6", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CMPOVL6
        {
            get { return (string)this.GetValue(CMPOVL6Property); }
            set { this.SetValue(CMPOVL6Property, value); }
        }

        /// <summary>
        /// DSCRP Property
        /// </summary>
        public static readonly DependencyProperty DSCRPProperty =
            DependencyProperty.Register("DSCRP", typeof(string), typeof(SYM_CALL_OVERLAY_01));

        /// <summary>
        /// Gets or sets the DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string DSCRP
        {
            get { return (string)this.GetValue(DSCRPProperty); }
            set { this.SetValue(DSCRPProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.OverlayName)) yield return new Param("$OverlayName", this.OverlayName);
if (!string.IsNullOrWhiteSpace(this.Tagname)) yield return new Param("$Tagname", this.Tagname);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
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
if (!string.IsNullOrWhiteSpace(this.Monitor)) yield return new Param("$Monitor", this.Monitor);
if (!string.IsNullOrWhiteSpace(this.PAROVL4)) yield return new Param("$PAROVL4", this.PAROVL4);
if (!string.IsNullOrWhiteSpace(this.CMPOVL5)) yield return new Param("$CMPOVL5", this.CMPOVL5);
if (!string.IsNullOrWhiteSpace(this.CMPOVL6)) yield return new Param("$CMPOVL6", this.CMPOVL6);
if (!string.IsNullOrWhiteSpace(this.DSCRP)) yield return new Param("$DSCRP", this.DSCRP);

            }
        }

		
    }
}
