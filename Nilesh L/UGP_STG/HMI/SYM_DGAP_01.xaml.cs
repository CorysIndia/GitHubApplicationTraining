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
    public class SYM_DGAP_01 : RSIControlModel
    {
        static SYM_DGAP_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_DGAP_01), new FrameworkPropertyMetadata(typeof(SYM_DGAP_01)));
        }

		public SYM_DGAP_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_DGAP_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_DGAP_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_DGAP_01));

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
            DependencyProperty.Register("LOC", typeof(string), typeof(SYM_DGAP_01));

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
        /// _EI1 Property
        /// </summary>
        public static readonly DependencyProperty _EI1Property =
            DependencyProperty.Register("_EI1", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the _EI1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string _EI1
        {
            get { return (string)this.GetValue(_EI1Property); }
            set { this.SetValue(_EI1Property, value); }
        }

        /// <summary>
        /// _ALMSTA Property
        /// </summary>
        public static readonly DependencyProperty _ALMSTAProperty =
            DependencyProperty.Register("_ALMSTA", typeof(int), typeof(SYM_DGAP_01));

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
            DependencyProperty.Register("PRT", typeof(int), typeof(SYM_DGAP_01));

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
        /// _MEAS Property
        /// </summary>
        public static readonly DependencyProperty _MEASProperty =
            DependencyProperty.Register("_MEAS", typeof(double), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the _MEAS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double _MEAS
        {
            get { return (double)this.GetValue(_MEASProperty); }
            set { this.SetValue(_MEASProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_DGAP_01));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_DGAP_01));

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
        /// ACK_UNACK_1 Property
        /// </summary>
        public static readonly DependencyProperty ACK_UNACK_1Property =
            DependencyProperty.Register("ACK_UNACK_1", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the ACK_UNACK_1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ACK_UNACK_1
        {
            get { return (string)this.GetValue(ACK_UNACK_1Property); }
            set { this.SetValue(ACK_UNACK_1Property, value); }
        }

        /// <summary>
        /// Border_AlarmState__CONN1 Property
        /// </summary>
        public static readonly DependencyProperty Border_AlarmState__CONN1Property =
            DependencyProperty.Register("Border_AlarmState__CONN1", typeof(int), typeof(SYM_DGAP_01));

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
        /// CallOverlay_DGAP_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_OverlayNameProperty =
            DependencyProperty.Register("CallOverlay_DGAP_OverlayName", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_OverlayName
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_OverlayNameProperty); }
            set { this.SetValue(CallOverlay_DGAP_OverlayNameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_Tagname Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_TagnameProperty =
            DependencyProperty.Register("CallOverlay_DGAP_Tagname", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_Tagname
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_TagnameProperty); }
            set { this.SetValue(CallOverlay_DGAP_TagnameProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_LOC Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_LOCProperty =
            DependencyProperty.Register("CallOverlay_DGAP_LOC", typeof(int), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_LOC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int CallOverlay_DGAP_LOC
        {
            get { return (int)this.GetValue(CallOverlay_DGAP_LOCProperty); }
            set { this.SetValue(CallOverlay_DGAP_LOCProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVLProperty =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVLProperty); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVL2Property =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL2", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVL2Property); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVL3Property =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL3", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVL3Property); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVL4Property =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL4", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVL4Property); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVL5Property =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL5", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVL5Property); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_BLKOVL6Property =
            DependencyProperty.Register("CallOverlay_DGAP_BLKOVL6", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_BLKOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_BLKOVL6Property); }
            set { this.SetValue(CallOverlay_DGAP_BLKOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVLProperty =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_CMPOVL
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVLProperty); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVL2Property =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL2", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_CMPOVL2
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVL2Property); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVL3Property =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL3", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_CMPOVL3
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVL3Property); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVL4Property =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL4", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_CMPOVL4
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVL4Property); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_PAROVLProperty =
            DependencyProperty.Register("CallOverlay_DGAP_PAROVL", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_PAROVL
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_PAROVLProperty); }
            set { this.SetValue(CallOverlay_DGAP_PAROVLProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_PAROVL2Property =
            DependencyProperty.Register("CallOverlay_DGAP_PAROVL2", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_PAROVL2
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_PAROVL2Property); }
            set { this.SetValue(CallOverlay_DGAP_PAROVL2Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_PAROVL3Property =
            DependencyProperty.Register("CallOverlay_DGAP_PAROVL3", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_PAROVL3
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_PAROVL3Property); }
            set { this.SetValue(CallOverlay_DGAP_PAROVL3Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_PRT Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_PRTProperty =
            DependencyProperty.Register("CallOverlay_DGAP_PRT", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_PRT
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_PRTProperty); }
            set { this.SetValue(CallOverlay_DGAP_PRTProperty, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_PAROVL4Property =
            DependencyProperty.Register("CallOverlay_DGAP_PAROVL4", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CallOverlay_DGAP_PAROVL4
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_PAROVL4Property); }
            set { this.SetValue(CallOverlay_DGAP_PAROVL4Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVL5Property =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL5", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 5")]
        public string CallOverlay_DGAP_CMPOVL5
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVL5Property); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVL5Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_CMPOVL6 Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_CMPOVL6Property =
            DependencyProperty.Register("CallOverlay_DGAP_CMPOVL6", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_CMPOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 6")]
        public string CallOverlay_DGAP_CMPOVL6
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_CMPOVL6Property); }
            set { this.SetValue(CallOverlay_DGAP_CMPOVL6Property, value); }
        }

        /// <summary>
        /// CallOverlay_DGAP_DSCRP Property
        /// </summary>
        public static readonly DependencyProperty CallOverlay_DGAP_DSCRPProperty =
            DependencyProperty.Register("CallOverlay_DGAP_DSCRP", typeof(string), typeof(SYM_DGAP_01));

        /// <summary>
        /// Gets or sets the CallOverlay_DGAP_DSCRP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Description")]
        public string CallOverlay_DGAP_DSCRP
        {
            get { return (string)this.GetValue(CallOverlay_DGAP_DSCRPProperty); }
            set { this.SetValue(CallOverlay_DGAP_DSCRPProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this._EI1)) yield return new Param("$_EI1", this._EI1);
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);

            }
        }

		
    }
}
