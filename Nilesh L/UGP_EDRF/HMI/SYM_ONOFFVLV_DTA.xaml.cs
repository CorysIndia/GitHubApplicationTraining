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
    public class SYM_ONOFFVLV_DTA : RSIControlModel
    {
        static SYM_ONOFFVLV_DTA()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_ONOFFVLV_DTA), new FrameworkPropertyMetadata(typeof(SYM_ONOFFVLV_DTA)));
        }

		public SYM_ONOFFVLV_DTA()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// BLK_ALM Property
        /// </summary>
        public static readonly DependencyProperty BLK_ALMProperty =
            DependencyProperty.Register("BLK_ALM", typeof(string), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the BLK_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_ALM
        {
            get { return (string)this.GetValue(BLK_ALMProperty); }
            set { this.SetValue(BLK_ALMProperty, value); }
        }

        /// <summary>
        /// TAGNAME Property
        /// </summary>
        public static readonly DependencyProperty TAGNAMEProperty =
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// _CONN1 Property
        /// </summary>
        public static readonly DependencyProperty _CONN1Property =
            DependencyProperty.Register("_CONN1", typeof(int), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the _CONN1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _CONN1
        {
            get { return (int)this.GetValue(_CONN1Property); }
            set { this.SetValue(_CONN1Property, value); }
        }

        /// <summary>
        /// _CONN2 Property
        /// </summary>
        public static readonly DependencyProperty _CONN2Property =
            DependencyProperty.Register("_CONN2", typeof(int), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the _CONN2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int _CONN2
        {
            get { return (int)this.GetValue(_CONN2Property); }
            set { this.SetValue(_CONN2Property, value); }
        }

        /// <summary>
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// SCRIPT Property
        /// </summary>
        public static readonly DependencyProperty SCRIPTProperty =
            DependencyProperty.Register("SCRIPT", typeof(string), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the SCRIPT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string SCRIPT
        {
            get { return (string)this.GetValue(SCRIPTProperty); }
            set { this.SetValue(SCRIPTProperty, value); }
        }

        /// <summary>
        /// OVL Property
        /// </summary>
        public static readonly DependencyProperty OVLProperty =
            DependencyProperty.Register("OVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// _CONN3 Property
        /// </summary>
        public static readonly DependencyProperty _CONN3Property =
            DependencyProperty.Register("_CONN3", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the _CONN3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CONN3
        {
            get { return (bool)this.GetValue(_CONN3Property); }
            set { this.SetValue(_CONN3Property, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("CMPOVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("CMPOVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("CMPOVL4", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL4", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL5", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("BLKOVL6", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("PAROVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("PAROVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("PAROVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// TAG_VIS Property
        /// </summary>
        public static readonly DependencyProperty TAG_VISProperty =
            DependencyProperty.Register("TAG_VIS", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the TAG_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TAG_VIS
        {
            get { return (bool)this.GetValue(TAG_VISProperty); }
            set { this.SetValue(TAG_VISProperty, value); }
        }

        /// <summary>
        /// _CONN4 Property
        /// </summary>
        public static readonly DependencyProperty _CONN4Property =
            DependencyProperty.Register("_CONN4", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the _CONN4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CONN4
        {
            get { return (bool)this.GetValue(_CONN4Property); }
            set { this.SetValue(_CONN4Property, value); }
        }

        /// <summary>
        /// ACKSYMBOL Property
        /// </summary>
        public static readonly DependencyProperty ACKSYMBOLProperty =
            DependencyProperty.Register("ACKSYMBOL", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the ACKSYMBOL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ACKSYMBOL
        {
            get { return (bool)this.GetValue(ACKSYMBOLProperty); }
            set { this.SetValue(ACKSYMBOLProperty, value); }
        }

        /// <summary>
        /// ACK_COMMAND Property
        /// </summary>
        public static readonly DependencyProperty ACK_COMMANDProperty =
            DependencyProperty.Register("ACK_COMMAND", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the ACK_COMMAND.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ACK_COMMAND
        {
            get { return (bool)this.GetValue(ACK_COMMANDProperty); }
            set { this.SetValue(ACK_COMMANDProperty, value); }
        }

        /// <summary>
        /// PRT2 Property
        /// </summary>
        public static readonly DependencyProperty PRT2Property =
            DependencyProperty.Register("PRT2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the PRT2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PRT2
        {
            get { return (string)this.GetValue(PRT2Property); }
            set { this.SetValue(PRT2Property, value); }
        }

        /// <summary>
        /// DISABL Property
        /// </summary>
        public static readonly DependencyProperty DISABLProperty =
            DependencyProperty.Register("DISABL", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the DISABL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DISABL
        {
            get { return (bool)this.GetValue(DISABLProperty); }
            set { this.SetValue(DISABLProperty, value); }
        }

        /// <summary>
        /// _CONN5 Property
        /// </summary>
        public static readonly DependencyProperty _CONN5Property =
            DependencyProperty.Register("_CONN5", typeof(bool), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the _CONN5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool _CONN5
        {
            get { return (bool)this.GetValue(_CONN5Property); }
            set { this.SetValue(_CONN5Property, value); }
        }

        /// <summary>
        /// CMP_ALM Property
        /// </summary>
        public static readonly DependencyProperty CMP_ALMProperty =
            DependencyProperty.Register("CMP_ALM", typeof(string), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the CMP_ALM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP_ALM
        {
            get { return (string)this.GetValue(CMP_ALMProperty); }
            set { this.SetValue(CMP_ALMProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// Orientation Property
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// FAIL Property
        /// </summary>
        public static readonly DependencyProperty FAILProperty =
            DependencyProperty.Register("FAIL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

        /// <summary>
        /// Gets or sets the FAIL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FAIL
        {
            get { return (string)this.GetValue(FAILProperty); }
            set { this.SetValue(FAILProperty, value); }
        }

        /// <summary>
        /// ACK_SYMBOL1_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_SYMBOL1_UNACK_1Property =
            DependencyProperty.Register("ACK_SYMBOL1_UNACK_1", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// FP_CallOverlay1_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay1_OverlayName", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_Tagname", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_LOC", typeof(int), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL4", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL5", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL6", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL4", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL2", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL3", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_PRT", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
            DependencyProperty.Register("FP_CallOverlay1_PAROVL4", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// FP_CallOverlay1_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL5", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// FP_CallOverlay1_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL6", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
        /// FP_CallOverlay1_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_DSCRPProperty =
            DependencyProperty.Register("FP_CallOverlay1_DSCRP", typeof(string), typeof(SYM_ONOFFVLV_DTA));

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
if (!string.IsNullOrWhiteSpace(this.BLK_ALM)) yield return new Param("$BLK_ALM", this.BLK_ALM);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.PRT)) yield return new Param("$PRT", this.PRT);
if (!string.IsNullOrWhiteSpace(this.LOC)) yield return new Param("$LOC", this.LOC);
if (!string.IsNullOrWhiteSpace(this.SCRIPT)) yield return new Param("$SCRIPT", this.SCRIPT);
if (!string.IsNullOrWhiteSpace(this.OVL)) yield return new Param("$OVL", this.OVL);
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
if (!string.IsNullOrWhiteSpace(this.PRT2)) yield return new Param("$PRT2", this.PRT2);
if (!string.IsNullOrWhiteSpace(this.CMP_ALM)) yield return new Param("$CMP_ALM", this.CMP_ALM);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);

            }
        }

		
    }
}
