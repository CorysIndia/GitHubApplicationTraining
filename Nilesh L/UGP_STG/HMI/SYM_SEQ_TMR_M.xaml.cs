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
    public class SYM_SEQ_TMR_M : RSIControlModel
    {
        static SYM_SEQ_TMR_M()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SEQ_TMR_M), new FrameworkPropertyMetadata(typeof(SYM_SEQ_TMR_M)));
        }

		public SYM_SEQ_TMR_M()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SEQ_TMR_M));

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
            DependencyProperty.Register("CMP", typeof(string), typeof(SYM_SEQ_TMR_M));

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
            DependencyProperty.Register("BLK", typeof(string), typeof(SYM_SEQ_TMR_M));

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
            DependencyProperty.Register("PAR", typeof(string), typeof(SYM_SEQ_TMR_M));

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
        /// Minutes Property
        /// </summary>
        public static readonly DependencyProperty MinutesProperty =
            DependencyProperty.Register("Minutes", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Minutes.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Minutes
        {
            get { return (int)this.GetValue(MinutesProperty); }
            set { this.SetValue(MinutesProperty, value); }
        }

        /// <summary>
        /// Seconds Property
        /// </summary>
        public static readonly DependencyProperty SecondsProperty =
            DependencyProperty.Register("Seconds", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Seconds.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Seconds
        {
            get { return (int)this.GetValue(SecondsProperty); }
            set { this.SetValue(SecondsProperty, value); }
        }

        /// <summary>
        /// INPUT Property
        /// </summary>
        public static readonly DependencyProperty INPUTProperty =
            DependencyProperty.Register("INPUT", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the INPUT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int INPUT
        {
            get { return (int)this.GetValue(INPUTProperty); }
            set { this.SetValue(INPUTProperty, value); }
        }

        /// <summary>
        /// Hours Property
        /// </summary>
        public static readonly DependencyProperty HoursProperty =
            DependencyProperty.Register("Hours", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Hours.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int Hours
        {
            get { return (int)this.GetValue(HoursProperty); }
            set { this.SetValue(HoursProperty, value); }
        }

        /// <summary>
        /// H_LIMIT Property
        /// </summary>
        public static readonly DependencyProperty H_LIMITProperty =
            DependencyProperty.Register("H_LIMIT", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the H_LIMIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int H_LIMIT
        {
            get { return (int)this.GetValue(H_LIMITProperty); }
            set { this.SetValue(H_LIMITProperty, value); }
        }

        /// <summary>
        /// L_LIMIT Property
        /// </summary>
        public static readonly DependencyProperty L_LIMITProperty =
            DependencyProperty.Register("L_LIMIT", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the L_LIMIT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int L_LIMIT
        {
            get { return (int)this.GetValue(L_LIMITProperty); }
            set { this.SetValue(L_LIMITProperty, value); }
        }

        /// <summary>
        /// TEMP Property
        /// </summary>
        public static readonly DependencyProperty TEMPProperty =
            DependencyProperty.Register("TEMP", typeof(int), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the TEMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int TEMP
        {
            get { return (int)this.GetValue(TEMPProperty); }
            set { this.SetValue(TEMPProperty, value); }
        }

        /// <summary>
        /// User_Input Property
        /// </summary>
        public static readonly DependencyProperty User_InputProperty =
            DependencyProperty.Register("User_Input", typeof(string), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the User_Input.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string User_Input
        {
            get { return (string)this.GetValue(User_InputProperty); }
            set { this.SetValue(User_InputProperty, value); }
        }

        /// <summary>
        /// Limit Property
        /// </summary>
        public static readonly DependencyProperty LimitProperty =
            DependencyProperty.Register("Limit", typeof(string), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Limit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Limit
        {
            get { return (string)this.GetValue(LimitProperty); }
            set { this.SetValue(LimitProperty, value); }
        }

        /// <summary>
        /// Display Property
        /// </summary>
        public static readonly DependencyProperty DisplayProperty =
            DependencyProperty.Register("Display", typeof(string), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Display.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Display
        {
            get { return (string)this.GetValue(DisplayProperty); }
            set { this.SetValue(DisplayProperty, value); }
        }

        /// <summary>
        /// Count_Mode Property
        /// </summary>
        public static readonly DependencyProperty Count_ModeProperty =
            DependencyProperty.Register("Count_Mode", typeof(string), typeof(SYM_SEQ_TMR_M));

        /// <summary>
        /// Gets or sets the Count_Mode.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Count_Mode
        {
            get { return (string)this.GetValue(Count_ModeProperty); }
            set { this.SetValue(Count_ModeProperty, value); }
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

            }
        }

		
    }
}
