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
    public class PUSH_BUTTON : RSIControlModel
    {
        static PUSH_BUTTON()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PUSH_BUTTON), new FrameworkPropertyMetadata(typeof(PUSH_BUTTON)));
        }

        public PUSH_BUTTON()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(PUSH_BUTTON));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(PUSH_BUTTON));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(PUSH_BUTTON));

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
        /// PAR Property
        /// </summary>
        public static readonly DependencyProperty PARProperty =
            DependencyProperty.Register("PAR", typeof(string), typeof(PUSH_BUTTON));

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
        /// HEADTEXT01 Property
        /// </summary>
        public static readonly DependencyProperty HEADTEXT01Property =
            DependencyProperty.Register("HEADTEXT01", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the HEADTEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HEADTEXT01
        {
            get { return (string)this.GetValue(HEADTEXT01Property); }
            set { this.SetValue(HEADTEXT01Property, value); }
        }

        /// <summary>
        /// HEADTEXT02 Property
        /// </summary>
        public static readonly DependencyProperty HEADTEXT02Property =
            DependencyProperty.Register("HEADTEXT02", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the HEADTEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string HEADTEXT02
        {
            get { return (string)this.GetValue(HEADTEXT02Property); }
            set { this.SetValue(HEADTEXT02Property, value); }
        }




        /// <summary>
        /// ALARM_CONN Property
        /// </summary>
        public static readonly DependencyProperty ALARM_CONNProperty =
            DependencyProperty.Register("ALARM_CONN", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the ALARM_CONN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ALARM_CONN
        {
            get { return (string)this.GetValue(ALARM_CONNProperty); }
            set { this.SetValue(ALARM_CONNProperty, value); }
        }

        /// <summary>
        /// ALARM Property
        /// </summary>
        public static readonly DependencyProperty ALARMProperty =
            DependencyProperty.Register("ALARM", typeof(bool), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the ALARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ALARM
        {
            get { return (bool)this.GetValue(ALARMProperty); }
            set { this.SetValue(ALARMProperty, value); }
        }

        /// <summary>
        /// MSG Property
        /// </summary>
        public static readonly DependencyProperty MSGProperty =
            DependencyProperty.Register("MSG", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the MSG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string MSG
        {
            get { return (string)this.GetValue(MSGProperty); }
            set { this.SetValue(MSGProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_OverlayName Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_OverlayNameProperty =
            DependencyProperty.Register("FP_CallOverlay1_OverlayName", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_OverlayName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Name of Overlay to open")]
        public string FP_CallOverlay1_OverlayName
        {
            get { return (string)this.GetValue(FP_CallOverlay1_OverlayNameProperty); }
            set { this.SetValue(FP_CallOverlay1_OverlayNameProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PRT Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PRTProperty =
            DependencyProperty.Register("FP_CallOverlay1_PRT", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Access Protection Level")]
        public string FP_CallOverlay1_PRT
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PRTProperty); }
            set { this.SetValue(FP_CallOverlay1_PRTProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL2", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 2")]
        public string FP_CallOverlay1_BLKOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 1 ")]
        public string FP_CallOverlay1_BLKOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_BLKOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL3", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 3")]
        public string FP_CallOverlay1_BLKOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL4", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 4")]
        public string FP_CallOverlay1_BLKOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL5", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 5")]
        public string FP_CallOverlay1_BLKOVL5
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL5Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL5Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_BLKOVL6 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_BLKOVL6Property =
            DependencyProperty.Register("FP_CallOverlay1_BLKOVL6", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_BLKOVL6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Block Alias 6")]
        public string FP_CallOverlay1_BLKOVL6
        {
            get { return (string)this.GetValue(FP_CallOverlay1_BLKOVL6Property); }
            set { this.SetValue(FP_CallOverlay1_BLKOVL6Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 1")]
        public string FP_CallOverlay1_CMPOVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVLProperty); }
            set { this.SetValue(FP_CallOverlay1_CMPOVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL2", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 2")]
        public string FP_CallOverlay1_CMPOVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL2Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL3", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 3")]
        public string FP_CallOverlay1_CMPOVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL3Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL4", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_CMPOVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Compound Alias 4")]
        public string FP_CallOverlay1_CMPOVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_CMPOVL4Property); }
            set { this.SetValue(FP_CallOverlay1_CMPOVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_CMPOVL5 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_CMPOVL5Property =
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL5", typeof(string), typeof(PUSH_BUTTON));

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
            DependencyProperty.Register("FP_CallOverlay1_CMPOVL6", typeof(string), typeof(PUSH_BUTTON));

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
            DependencyProperty.Register("FP_CallOverlay1_DSCRP", typeof(string), typeof(PUSH_BUTTON));

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
        /// FP_CallOverlay1_LOC Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_LOCProperty =
            DependencyProperty.Register("FP_CallOverlay1_LOC", typeof(int), typeof(PUSH_BUTTON));

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
        /// FP_CallOverlay1_PAROVL Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVLProperty =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 1")]
        public string FP_CallOverlay1_PAROVL
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVLProperty); }
            set { this.SetValue(FP_CallOverlay1_PAROVLProperty, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL2 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL2Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL2", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 2")]
        public string FP_CallOverlay1_PAROVL2
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL2Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL2Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL3 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL3Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL3", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 3")]
        public string FP_CallOverlay1_PAROVL3
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL3Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL3Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_PAROVL4 Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_PAROVL4Property =
            DependencyProperty.Register("FP_CallOverlay1_PAROVL4", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_PAROVL4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Overlay Custom Parameter Alias 4")]
        public string FP_CallOverlay1_PAROVL4
        {
            get { return (string)this.GetValue(FP_CallOverlay1_PAROVL4Property); }
            set { this.SetValue(FP_CallOverlay1_PAROVL4Property, value); }
        }

        /// <summary>
        /// FP_CallOverlay1_Tagname Property
        /// </summary>
        public static readonly DependencyProperty FP_CallOverlay1_TagnameProperty =
            DependencyProperty.Register("FP_CallOverlay1_Tagname", typeof(string), typeof(PUSH_BUTTON));

        /// <summary>
        /// Gets or sets the FP_CallOverlay1_Tagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Tagname of Symbol (Compound.Block) used to show context menu")]
        public string FP_CallOverlay1_Tagname
        {
            get { return (string)this.GetValue(FP_CallOverlay1_TagnameProperty); }
            set { this.SetValue(FP_CallOverlay1_TagnameProperty, value); }
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
                if (!string.IsNullOrWhiteSpace(this.PAR)) yield return new Param("$PAR", this.PAR);
                if (!string.IsNullOrWhiteSpace(this.ALARM_CONN)) yield return new Param("$ALARM_CONN", this.ALARM_CONN);
                if (!string.IsNullOrWhiteSpace(this.MSG)) yield return new Param("$MSG", this.MSG);
                if (!string.IsNullOrWhiteSpace(this.HEADTEXT01)) yield return new Param("$HEADTEXT01", this.HEADTEXT01);
                if (!string.IsNullOrWhiteSpace(this.HEADTEXT02)) yield return new Param("$HEADTEXT02", this.HEADTEXT02);

            }
        }


    }
}
