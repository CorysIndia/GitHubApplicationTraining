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
    public class SYM_LEVELBAR_01 : RSIControlModel
    {
        static SYM_LEVELBAR_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_LEVELBAR_01), new FrameworkPropertyMetadata(typeof(SYM_LEVELBAR_01)));
        }

		public SYM_LEVELBAR_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_LEVELBAR_01));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_LEVELBAR_01));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_LEVELBAR_01));

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
        /// HSCALE Property
        /// </summary>
        public static readonly DependencyProperty HSCALEProperty =
            DependencyProperty.Register("HSCALE", typeof(double), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the HSCALE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double HSCALE
        {
            get { return (double)this.GetValue(HSCALEProperty); }
            set { this.SetValue(HSCALEProperty, value); }
        }

        /// <summary>
        /// LSCALE Property
        /// </summary>
        public static readonly DependencyProperty LSCALEProperty =
            DependencyProperty.Register("LSCALE", typeof(double), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the LSCALE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double LSCALE
        {
            get { return (double)this.GetValue(LSCALEProperty); }
            set { this.SetValue(LSCALEProperty, value); }
        }

        /// <summary>
        /// AVALUE Property
        /// </summary>
        public static readonly DependencyProperty AVALUEProperty =
            DependencyProperty.Register("AVALUE", typeof(double), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the AVALUE.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double AVALUE
        {
            get { return (double)this.GetValue(AVALUEProperty); }
            set { this.SetValue(AVALUEProperty, value); }
        }

        /// <summary>
        /// LOOP_ID Property
        /// </summary>
        public static readonly DependencyProperty LOOP_IDProperty =
            DependencyProperty.Register("LOOP_ID", typeof(string), typeof(SYM_LEVELBAR_01));

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
            DependencyProperty.Register("TAGNAME", typeof(string), typeof(SYM_LEVELBAR_01));

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

        //START

        /// <summary>
        /// TransmitterName Property
        /// </summary>
        public static readonly DependencyProperty TransmitterNameProperty =
            DependencyProperty.Register("TransmitterName", typeof(string), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the TransmitterName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string TransmitterName
        {
            get { return (string)this.GetValue(TransmitterNameProperty); }
            set { this.SetValue(TransmitterNameProperty, value); }
        }

        //START
        /// <summary>
        /// IAS_AIN_Name Property
        /// </summary>
        public static readonly DependencyProperty IAS_AIN_NameProperty =
            DependencyProperty.Register("IAS_AIN_Name", typeof(string), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the IAS_AIN_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string IAS_AIN_Name
        {
            get { return (string)this.GetValue(IAS_AIN_NameProperty); }
            set { this.SetValue(IAS_AIN_NameProperty, value); }
        }


        /// <summary>
        /// FillLevelType Property
        /// </summary>
        public static readonly DependencyProperty FillLevelTypeProperty =
            DependencyProperty.Register("FillLevelType", typeof(string), typeof(SYM_LEVELBAR_01));

        /// <summary>
        /// Gets or sets the FillLevelType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string FillLevelType
        {
            get { return (string)this.GetValue(FillLevelTypeProperty); }
            set { this.SetValue(FillLevelTypeProperty, value); }
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
if (!string.IsNullOrWhiteSpace(this.LOOP_ID)) yield return new Param("$LOOP_ID", this.LOOP_ID);
if (!string.IsNullOrWhiteSpace(this.TAGNAME)) yield return new Param("$TAGNAME", this.TAGNAME);
if (!string.IsNullOrWhiteSpace(this.TransmitterName)) yield return new Param("$TransmitterName", this.TransmitterName);
if (!string.IsNullOrWhiteSpace(this.IAS_AIN_Name)) yield return new Param("$IAS_AIN_Name", this.IAS_AIN_Name);

            }
        }

		
    }
}
