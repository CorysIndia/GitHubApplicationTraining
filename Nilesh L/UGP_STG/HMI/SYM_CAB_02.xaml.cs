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
    public class SYM_CAB_02 : RSIControlModel
    {
        static SYM_CAB_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_CAB_02), new FrameworkPropertyMetadata(typeof(SYM_CAB_02)));
        }

		public SYM_CAB_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_CAB_02));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_CAB_02));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_CAB_02));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_CAB_02));

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
        /// BLK_ALM_1 Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALM_1Property =
            DependencyProperty.Register("BLK_ALM_1", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the BLK_ALM_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM_1
        {
            get { return (string)this.GetValue(BLK_ALM_1Property); }
            set { this.SetValue(BLK_ALM_1Property, value); }
        }

        /// <summary>
        /// BLK_ALM_2 Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALM_2Property =
            DependencyProperty.Register("BLK_ALM_2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the BLK_ALM_2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM_2
        {
            get { return (string)this.GetValue(BLK_ALM_2Property); }
            set { this.SetValue(BLK_ALM_2Property, value); }
        }

        /// <summary>
        /// BLK_ALM_3 Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALM_3Property =
            DependencyProperty.Register("BLK_ALM_3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the BLK_ALM_3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM_3
        {
            get { return (string)this.GetValue(BLK_ALM_3Property); }
            set { this.SetValue(BLK_ALM_3Property, value); }
        }

        /// <summary>
        /// _ALMSTA1 Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTA1Property =
            DependencyProperty.Register("_ALMSTA1", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the _ALMSTA1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA1
        {
            get { return (int)this.GetValue(_ALMSTA1Property); }
            set { this.SetValue(_ALMSTA1Property, value); }
        }

        /// <summary>
        /// _ALMSTA2 Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTA2Property =
            DependencyProperty.Register("_ALMSTA2", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the _ALMSTA2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA2
        {
            get { return (int)this.GetValue(_ALMSTA2Property); }
            set { this.SetValue(_ALMSTA2Property, value); }
        }

        /// <summary>
        /// _ALMSTA3 Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTA3Property =
            DependencyProperty.Register("_ALMSTA3", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the _ALMSTA3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA3
        {
            get { return (int)this.GetValue(_ALMSTA3Property); }
            set { this.SetValue(_ALMSTA3Property, value); }
        }

        /// <summary>
        /// _ALMSTA4 Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTA4Property =
            DependencyProperty.Register("_ALMSTA4", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the _ALMSTA4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _ALMSTA4
        {
            get { return (int)this.GetValue(_ALMSTA4Property); }
            set { this.SetValue(_ALMSTA4Property, value); }
        }

        /// <summary>
        /// BLK_ALM_4 Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALM_4Property =
            DependencyProperty.Register("BLK_ALM_4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the BLK_ALM_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM_4
        {
            get { return (string)this.GetValue(BLK_ALM_4Property); }
            set { this.SetValue(BLK_ALM_4Property, value); }
        }

        /// <summary>
        /// ALARMS Property
        /// </summary>
        public static readonly DependencyProperty ALARMSProperty =
            DependencyProperty.Register("ALARMS", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARMS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARMS
        {
            get { return (string)this.GetValue(ALARMSProperty); }
            set { this.SetValue(ALARMSProperty, value); }
        }

        /// <summary>
        /// ALARM4_ALARMBORDER_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_ALARMBORDER_ALARM_CONProperty =
            DependencyProperty.Register("ALARM4_ALARMBORDER_ALARM_CON", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_ALARMBORDER_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM4_ALARMBORDER_ALARM_CON
        {
            get { return (int)this.GetValue(ALARM4_ALARMBORDER_ALARM_CONProperty); }
            set { this.SetValue(ALARM4_ALARMBORDER_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_OverlayName", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_OverlayNameProperty); }
            set { this.SetValue(ALARM4_CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_TagnameProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_Tagname", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_Tagname
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_TagnameProperty); }
            set { this.SetValue(ALARM4_CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_LOCProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_LOC", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM4_CallOverlay_LOC
        {
            get { return (int)this.GetValue(ALARM4_CallOverlay_LOCProperty); }
            set { this.SetValue(ALARM4_CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVLProperty); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVL2Property); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVL3Property); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVL4Property); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVL5Property); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("ALARM4_CallOverlay_BLKOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_BLKOVL6Property); }
            set { this.SetValue(ALARM4_CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVLProperty); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVL2Property); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVL3Property); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVL4Property); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_PAROVLProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_PAROVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_PAROVLProperty); }
            set { this.SetValue(ALARM4_CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_PAROVL2Property =
            DependencyProperty.Register("ALARM4_CallOverlay_PAROVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_PAROVL2Property); }
            set { this.SetValue(ALARM4_CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_PAROVL3Property =
            DependencyProperty.Register("ALARM4_CallOverlay_PAROVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_PAROVL3Property); }
            set { this.SetValue(ALARM4_CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_PRTProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_PRT", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_PRT
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_PRTProperty); }
            set { this.SetValue(ALARM4_CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVL5Property); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("ALARM4_CallOverlay_CMPOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_CMPOVL6Property); }
            set { this.SetValue(ALARM4_CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_PAROVL4Property =
            DependencyProperty.Register("ALARM4_CallOverlay_PAROVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_PAROVL4Property); }
            set { this.SetValue(ALARM4_CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// ALARM4_CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_CallOverlay_DSCRPProperty =
            DependencyProperty.Register("ALARM4_CallOverlay_DSCRP", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(ALARM4_CallOverlay_DSCRPProperty); }
            set { this.SetValue(ALARM4_CallOverlay_DSCRPProperty, value); }
        }

        /// <summary>
        /// ALARM4_ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ALARM4_ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ALARM4_ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM4_ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM4_ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ALARM4_ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ALARM4_ACK_SYMBOL_UNACK_1Property, value); }
        }

        /// <summary>
        /// ALARM3_ALARMBORDER_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_ALARMBORDER_ALARM_CONProperty =
            DependencyProperty.Register("ALARM3_ALARMBORDER_ALARM_CON", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_ALARMBORDER_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM3_ALARMBORDER_ALARM_CON
        {
            get { return (int)this.GetValue(ALARM3_ALARMBORDER_ALARM_CONProperty); }
            set { this.SetValue(ALARM3_ALARMBORDER_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_OverlayName", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_OverlayNameProperty); }
            set { this.SetValue(ALARM3_CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_TagnameProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_Tagname", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_Tagname
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_TagnameProperty); }
            set { this.SetValue(ALARM3_CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_LOCProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_LOC", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM3_CallOverlay_LOC
        {
            get { return (int)this.GetValue(ALARM3_CallOverlay_LOCProperty); }
            set { this.SetValue(ALARM3_CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVLProperty); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVL2Property); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVL3Property); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVL4Property); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVL5Property); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("ALARM3_CallOverlay_BLKOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_BLKOVL6Property); }
            set { this.SetValue(ALARM3_CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVLProperty); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVL2Property); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVL3Property); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVL4Property); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_PAROVLProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_PAROVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_PAROVLProperty); }
            set { this.SetValue(ALARM3_CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_PAROVL2Property =
            DependencyProperty.Register("ALARM3_CallOverlay_PAROVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_PAROVL2Property); }
            set { this.SetValue(ALARM3_CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_PAROVL3Property =
            DependencyProperty.Register("ALARM3_CallOverlay_PAROVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_PAROVL3Property); }
            set { this.SetValue(ALARM3_CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_PRTProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_PRT", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_PRT
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_PRTProperty); }
            set { this.SetValue(ALARM3_CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVL5Property); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("ALARM3_CallOverlay_CMPOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_CMPOVL6Property); }
            set { this.SetValue(ALARM3_CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_PAROVL4Property =
            DependencyProperty.Register("ALARM3_CallOverlay_PAROVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_PAROVL4Property); }
            set { this.SetValue(ALARM3_CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// ALARM3_CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_CallOverlay_DSCRPProperty =
            DependencyProperty.Register("ALARM3_CallOverlay_DSCRP", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(ALARM3_CallOverlay_DSCRPProperty); }
            set { this.SetValue(ALARM3_CallOverlay_DSCRPProperty, value); }
        }

        /// <summary>
        /// ALARM3_ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ALARM3_ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ALARM3_ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM3_ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM3_ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ALARM3_ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ALARM3_ACK_SYMBOL_UNACK_1Property, value); }
        }

        /// <summary>
        /// ALARM2_ALARMBORDER_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_ALARMBORDER_ALARM_CONProperty =
            DependencyProperty.Register("ALARM2_ALARMBORDER_ALARM_CON", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_ALARMBORDER_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM2_ALARMBORDER_ALARM_CON
        {
            get { return (int)this.GetValue(ALARM2_ALARMBORDER_ALARM_CONProperty); }
            set { this.SetValue(ALARM2_ALARMBORDER_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_OverlayName", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_OverlayNameProperty); }
            set { this.SetValue(ALARM2_CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_TagnameProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_Tagname", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_Tagname
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_TagnameProperty); }
            set { this.SetValue(ALARM2_CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_LOCProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_LOC", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM2_CallOverlay_LOC
        {
            get { return (int)this.GetValue(ALARM2_CallOverlay_LOCProperty); }
            set { this.SetValue(ALARM2_CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVLProperty); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVL2Property); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVL3Property); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVL4Property); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVL5Property); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("ALARM2_CallOverlay_BLKOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_BLKOVL6Property); }
            set { this.SetValue(ALARM2_CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVLProperty); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVL2Property); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVL3Property); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVL4Property); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_PAROVLProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_PAROVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_PAROVLProperty); }
            set { this.SetValue(ALARM2_CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_PAROVL2Property =
            DependencyProperty.Register("ALARM2_CallOverlay_PAROVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_PAROVL2Property); }
            set { this.SetValue(ALARM2_CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_PAROVL3Property =
            DependencyProperty.Register("ALARM2_CallOverlay_PAROVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_PAROVL3Property); }
            set { this.SetValue(ALARM2_CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_PRTProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_PRT", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_PRT
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_PRTProperty); }
            set { this.SetValue(ALARM2_CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVL5Property); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("ALARM2_CallOverlay_CMPOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_CMPOVL6Property); }
            set { this.SetValue(ALARM2_CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_PAROVL4Property =
            DependencyProperty.Register("ALARM2_CallOverlay_PAROVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_PAROVL4Property); }
            set { this.SetValue(ALARM2_CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// ALARM2_CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_CallOverlay_DSCRPProperty =
            DependencyProperty.Register("ALARM2_CallOverlay_DSCRP", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(ALARM2_CallOverlay_DSCRPProperty); }
            set { this.SetValue(ALARM2_CallOverlay_DSCRPProperty, value); }
        }

        /// <summary>
        /// ALARM2_ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ALARM2_ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ALARM2_ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM2_ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM2_ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ALARM2_ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ALARM2_ACK_SYMBOL_UNACK_1Property, value); }
        }

        /// <summary>
        /// ALARM1_ALARMBORDER_ALARM_CON Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_ALARMBORDER_ALARM_CONProperty =
            DependencyProperty.Register("ALARM1_ALARMBORDER_ALARM_CON", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_ALARMBORDER_ALARM_CON.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM1_ALARMBORDER_ALARM_CON
        {
            get { return (int)this.GetValue(ALARM1_ALARMBORDER_ALARM_CONProperty); }
            set { this.SetValue(ALARM1_ALARMBORDER_ALARM_CONProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_OverlayNameProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_OverlayName", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_OverlayName
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_OverlayNameProperty); }
            set { this.SetValue(ALARM1_CallOverlay_OverlayNameProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_Tagname Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_TagnameProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_Tagname", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_Tagname
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_TagnameProperty); }
            set { this.SetValue(ALARM1_CallOverlay_TagnameProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_LOC Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_LOCProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_LOC", typeof(int), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int ALARM1_CallOverlay_LOC
        {
            get { return (int)this.GetValue(ALARM1_CallOverlay_LOCProperty); }
            set { this.SetValue(ALARM1_CallOverlay_LOCProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVLProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVLProperty); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVLProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVL2Property =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL2
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVL2Property); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVL2Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVL3Property =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL3
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVL3Property); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVL3Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVL4Property =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL4
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVL4Property); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVL4Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVL5Property =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL5
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVL5Property); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVL5Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_BLKOVL6Property =
            DependencyProperty.Register("ALARM1_CallOverlay_BLKOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_BLKOVL6
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_BLKOVL6Property); }
            set { this.SetValue(ALARM1_CallOverlay_BLKOVL6Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVLProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVLProperty); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVLProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVL2Property =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL2
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVL2Property); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVL2Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVL3Property =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL3
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVL3Property); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVL3Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVL4Property =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL4
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVL4Property); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVL4Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_PAROVLProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_PAROVL", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_PAROVL
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_PAROVLProperty); }
            set { this.SetValue(ALARM1_CallOverlay_PAROVLProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_PAROVL2Property =
            DependencyProperty.Register("ALARM1_CallOverlay_PAROVL2", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_PAROVL2
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_PAROVL2Property); }
            set { this.SetValue(ALARM1_CallOverlay_PAROVL2Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_PAROVL3Property =
            DependencyProperty.Register("ALARM1_CallOverlay_PAROVL3", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_PAROVL3
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_PAROVL3Property); }
            set { this.SetValue(ALARM1_CallOverlay_PAROVL3Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_PRT Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_PRTProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_PRT", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_PRT
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_PRTProperty); }
            set { this.SetValue(ALARM1_CallOverlay_PRTProperty, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVL5Property =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL5", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL5
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVL5Property); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVL5Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_CMPOVL6Property =
            DependencyProperty.Register("ALARM1_CallOverlay_CMPOVL6", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_CMPOVL6
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_CMPOVL6Property); }
            set { this.SetValue(ALARM1_CallOverlay_CMPOVL6Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_PAROVL4Property =
            DependencyProperty.Register("ALARM1_CallOverlay_PAROVL4", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_PAROVL4
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_PAROVL4Property); }
            set { this.SetValue(ALARM1_CallOverlay_PAROVL4Property, value); }
        }

        /// <summary>
        /// ALARM1_CallOverlay_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_CallOverlay_DSCRPProperty =
            DependencyProperty.Register("ALARM1_CallOverlay_DSCRP", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_CallOverlay_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_CallOverlay_DSCRP
        {
            get { return (string)this.GetValue(ALARM1_CallOverlay_DSCRPProperty); }
            set { this.SetValue(ALARM1_CallOverlay_DSCRPProperty, value); }
        }

        /// <summary>
        /// ALARM1_ACK_SYMBOL_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ALARM1_ACK_SYMBOL_UNACK_1Property =
            DependencyProperty.Register("ALARM1_ACK_SYMBOL_UNACK_1", typeof(string), typeof(SYM_CAB_02));

        /// <summary>
        /// Gets or sets the ALARM1_ACK_SYMBOL_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM1_ACK_SYMBOL_UNACK_1
        {
            get { return (string)this.GetValue(ALARM1_ACK_SYMBOL_UNACK_1Property); }
            set { this.SetValue(ALARM1_ACK_SYMBOL_UNACK_1Property, value); }
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
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.BLK_ALM_1)) yield return new Param("$BLK_ALM_1", this.BLK_ALM_1);
if (!string.IsNullOrWhiteSpace(this.BLK_ALM_2)) yield return new Param("$BLK_ALM_2", this.BLK_ALM_2);
if (!string.IsNullOrWhiteSpace(this.BLK_ALM_3)) yield return new Param("$BLK_ALM_3", this.BLK_ALM_3);
if (!string.IsNullOrWhiteSpace(this.BLK_ALM_4)) yield return new Param("$BLK_ALM_4", this.BLK_ALM_4);

            }
        }

		
    }
}
