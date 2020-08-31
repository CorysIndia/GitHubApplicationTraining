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
    public class SYM_OUT_01 : RSIControlModel
    {
        static SYM_OUT_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_OUT_01), new FrameworkPropertyMetadata(typeof(SYM_OUT_01)));
        }

		public SYM_OUT_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_OUT_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_OUT_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_OUT_01));

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
        /// LOC Property
        /// </summary>
        public static readonly DependencyProperty LOCProperty =
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_OUT_01));

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
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_OUT_01));

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
            DependencyProperty.Register("PRT", typeof(int), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PRT
        {
            get { return (int)this.GetValue(PRTProperty); }
            set { this.SetValue(PRTProperty, value); }
        }

        /// <summary>
        /// _EO1 Property
        /// </summary>
        public static readonly DependencyProperty _EO1Property =
            DependencyProperty.Register("_EO1", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the _EO1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _EO1
        {
            get { return (string)this.GetValue(_EO1Property); }
            set { this.SetValue(_EO1Property, value); }
        }

        /// <summary>
        /// _OUT Property
        /// </summary>
        public static readonly DependencyProperty _OUTProperty =
            DependencyProperty.Register("_OUT", typeof(double), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the _OUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _OUT
        {
            get { return (double)this.GetValue(_OUTProperty); }
            set { this.SetValue(_OUTProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_OUT_01));

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
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_OUT_01));

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
        /// Type Property
        /// </summary>
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(SYM_OUT_01));

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
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_OUT_01));

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

        /// <summary>
        /// Border_AlarmState__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty Border_AlarmState__CONN1Property =
            DependencyProperty.Register("Border_AlarmState__CONN1", typeof(int), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the Border_AlarmState__CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Border_AlarmState__CONN1
        {
            get { return (int)this.GetValue(Border_AlarmState__CONN1Property); }
            set { this.SetValue(Border_AlarmState__CONN1Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_OverlayName", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_Tagname", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_LOC", typeof(int), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay_ROUT_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay_ROUT_LOCProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL5", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_BLKOVL6", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_PAROVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_PAROVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_PAROVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_PRT", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_PRTProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_PAROVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_ROUT_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL5", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay_ROUT_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_ROUT_CMPOVL6", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay_ROUT_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay_ROUT_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_ROUT_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_ROUT_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay_ROUT_DSCRP", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_ROUT_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay_ROUT_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay_ROUT_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay_ROUT_DSCRPProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_OverlayName", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_Tagname", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_TagnameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_LOC", typeof(int), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int FP_CallOverlay_AOUT_LOC
        {
            get { return (int)this.GetValue(FP_CallOverlay_AOUT_LOCProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_LOCProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL5", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_BLKOVL6", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_PAROVL", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_PAROVL2", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_PAROVL3", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_PRT", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_PRTProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_PAROVL4", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FP_CallOverlay_AOUT_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL5", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string FP_CallOverlay_AOUT_CMPOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVL5Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay_AOUT_CMPOVL6", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string FP_CallOverlay_AOUT_CMPOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_CMPOVL6Property); }
            set { this.SetValue(FP_CallOverlay_AOUT_CMPOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay_AOUT_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay_AOUT_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay_AOUT_DSCRP", typeof(string), typeof(SYM_OUT_01));

        /// <summary>
        /// Gets or sets the FP_CallOverlay_AOUT_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string FP_CallOverlay_AOUT_DSCRP
        {
            get { return (string)this.GetValue(FP_CallOverlay_AOUT_DSCRPProperty); }
            set { this.SetValue(FP_CallOverlay_AOUT_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this._EO1)) yield return new Param("$_EO1", this._EO1);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);

            }
        }

		
    }
}
