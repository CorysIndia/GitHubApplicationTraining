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
    public class Button_Context_NFP : RSIControlModel
    {
        static Button_Context_NFP()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Button_Context_NFP), new FrameworkPropertyMetadata(typeof(Button_Context_NFP)));
        }

		public Button_Context_NFP()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Button_Context_NFP));

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
        /// Command_Bit Property
        /// </summary>
        public static readonly DependencyProperty Command_BitProperty =
            DependencyProperty.Register("Command_Bit", typeof(bool), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the Command_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Command_Bit
        {
            get { return (bool)this.GetValue(Command_BitProperty); }
            set { this.SetValue(Command_BitProperty, value); }
        }

        /// <summary>
        /// FeedBack_Bit Property
        /// </summary>
        public static readonly DependencyProperty FeedBack_BitProperty =
            DependencyProperty.Register("FeedBack_Bit", typeof(bool), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the FeedBack_Bit.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FeedBack_Bit
        {
            get { return (bool)this.GetValue(FeedBack_BitProperty); }
            set { this.SetValue(FeedBack_BitProperty, value); }
        }

        /// <summary>
        /// PulseTime_SEC Property
        /// </summary>
        public static readonly DependencyProperty PulseTime_SECProperty =
            DependencyProperty.Register("PulseTime_SEC", typeof(int), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the PulseTime_SEC.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PulseTime_SEC
        {
            get { return (int)this.GetValue(PulseTime_SECProperty); }
            set { this.SetValue(PulseTime_SECProperty, value); }
        }

        /// <summary>
        /// Command_Sent Property
        /// </summary>
        public static readonly DependencyProperty Command_SentProperty =
            DependencyProperty.Register("Command_Sent", typeof(bool), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the Command_Sent.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Command_Sent
        {
            get { return (bool)this.GetValue(Command_SentProperty); }
            set { this.SetValue(Command_SentProperty, value); }
        }

        /// <summary>
        /// PulseTime_Cnt Property
        /// </summary>
        public static readonly DependencyProperty PulseTime_CntProperty =
            DependencyProperty.Register("PulseTime_Cnt", typeof(int), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the PulseTime_Cnt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int PulseTime_Cnt
        {
            get { return (int)this.GetValue(PulseTime_CntProperty); }
            set { this.SetValue(PulseTime_CntProperty, value); }
        }

        /// <summary>
        /// PulseDirection Property
        /// </summary>
        public static readonly DependencyProperty PulseDirectionProperty =
            DependencyProperty.Register("PulseDirection", typeof(bool), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the PulseDirection.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PulseDirection
        {
            get { return (bool)this.GetValue(PulseDirectionProperty); }
            set { this.SetValue(PulseDirectionProperty, value); }
        }

        /// <summary>
        /// ON_Message Property
        /// </summary>
        public static readonly DependencyProperty ON_MessageProperty =
            DependencyProperty.Register("ON_Message", typeof(string), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the ON_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ON_Message
        {
            get { return (string)this.GetValue(ON_MessageProperty); }
            set { this.SetValue(ON_MessageProperty, value); }
        }

        /// <summary>
        /// OFF_Message Property
        /// </summary>
        public static readonly DependencyProperty OFF_MessageProperty =
            DependencyProperty.Register("OFF_Message", typeof(string), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the OFF_Message.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OFF_Message
        {
            get { return (string)this.GetValue(OFF_MessageProperty); }
            set { this.SetValue(OFF_MessageProperty, value); }
        }

        /// <summary>
        /// Command_Type Property
        /// </summary>
        public static readonly DependencyProperty Command_TypeProperty =
            DependencyProperty.Register("Command_Type", typeof(string), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the Command_Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Command_Type
        {
            get { return (string)this.GetValue(Command_TypeProperty); }
            set { this.SetValue(Command_TypeProperty, value); }
        }

        /// <summary>
        /// Pulse_Type Property
        /// </summary>
        public static readonly DependencyProperty Pulse_TypeProperty =
            DependencyProperty.Register("Pulse_Type", typeof(string), typeof(Button_Context_NFP));

        /// <summary>
        /// Gets or sets the Pulse_Type.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Pulse_Type
        {
            get { return (string)this.GetValue(Pulse_TypeProperty); }
            set { this.SetValue(Pulse_TypeProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.ON_Message)) yield return new Param("$ON_Message", this.ON_Message);
if (!string.IsNullOrWhiteSpace(this.OFF_Message)) yield return new Param("$OFF_Message", this.OFF_Message);

            }
        }

		
    }
}
