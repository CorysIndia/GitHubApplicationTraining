using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using System.ComponentModel.Composition;

namespace UGP_EDRF.HMI
{
	[Export("TRIPS_M39_K_0001")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TRIPS_M39_K_0001
    {
        public TRIPS_M39_K_0001()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the GraphicTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string GraphicTagName
        {
            get { return (string)this.GetValue(GraphicTagNameProperty); }
            set { this.SetValue(GraphicTagNameProperty, value); }
        }


		        /// <summary>
        /// Type1_AlarmIndicator_Big_Red1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red1_AlarmProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red1_Alarm", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Type1_AlarmIndicator_Big_Red1_Alarm
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red1_AlarmProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red1_AlarmProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red1_Blink Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red1_BlinkProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red1_Blink", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red1_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Type1_AlarmIndicator_Big_Red1_Blink
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red1_BlinkProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red1_BlinkProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red2_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red2_AlarmProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red2_Alarm", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red2_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Type1_AlarmIndicator_Big_Red2_Alarm
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red2_AlarmProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red2_AlarmProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red2_Blink Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red2_BlinkProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red2_Blink", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red2_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Type1_AlarmIndicator_Big_Red2_Blink
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red2_BlinkProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red2_BlinkProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red3_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red3_AlarmProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red3_Alarm", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red3_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Type1_AlarmIndicator_Big_Red3_Alarm
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red3_AlarmProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red3_AlarmProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red3_Blink Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red3_BlinkProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red3_Blink", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red3_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Type1_AlarmIndicator_Big_Red3_Blink
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red3_BlinkProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red3_BlinkProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red4_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red4_AlarmProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red4_Alarm", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red4_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool Type1_AlarmIndicator_Big_Red4_Alarm
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red4_AlarmProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red4_AlarmProperty, value); }
        }

        /// <summary>
        /// Type1_AlarmIndicator_Big_Red4_Blink Property
        /// </summary>
        public static readonly DependencyProperty Type1_AlarmIndicator_Big_Red4_BlinkProperty =
            DependencyProperty.Register("Type1_AlarmIndicator_Big_Red4_Blink", typeof(bool), typeof(TRIPS_M39_K_0001));

        /// <summary>
        /// Gets or sets the Type1_AlarmIndicator_Big_Red4_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Type1_AlarmIndicator_Big_Red4_Blink
        {
            get { return (bool)this.GetValue(Type1_AlarmIndicator_Big_Red4_BlinkProperty); }
            set { this.SetValue(Type1_AlarmIndicator_Big_Red4_BlinkProperty, value); }
        }


		
    }
}
