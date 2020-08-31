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
	[Export("IGV_K0003A")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class IGV_K0003A
    {
        public IGV_K0003A()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(IGV_K0003A));

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
        /// Type2_BaseplatePIDDisplay_III1_Enterable Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_EnterableProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Enterable", typeof(double), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Type2_BaseplatePIDDisplay_III1_Enterable
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III1_EnterableProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_EnterableProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_Value Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_ValueProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Value", typeof(double), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Type2_BaseplatePIDDisplay_III1_Value
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III1_ValueProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_ValueProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_DisableTag Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_DisableTagProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_DisableTag", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable Tag name and Tag Discription function                         False = enable Tag name and Tag Discription function")]
        public bool Type2_BaseplatePIDDisplay_III1_DisableTag
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III1_DisableTagProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_DisableTagProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_AlarmProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Alarm", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Type2_BaseplatePIDDisplay_III1_Alarm
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III1_AlarmProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_AlarmProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_Disable Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_DisableProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Disable", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"False=Enable value enterable ")]
        public bool Type2_BaseplatePIDDisplay_III1_Disable
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III1_DisableProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_DisableProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_EnterType Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_EnterTypeProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_EnterType", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool Type2_BaseplatePIDDisplay_III1_EnterType
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III1_EnterTypeProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_EnterTypeProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_Units Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_UnitsProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Units", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.ENGUNITS' field to display the units of the Value tag. ")]
        public string Type2_BaseplatePIDDisplay_III1_Units
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_UnitsProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_UnitsProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_TagDescrpProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_TagDescrp", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.comment' field to display the units of the Value tag. ")]
        public string Type2_BaseplatePIDDisplay_III1_TagDescrp
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_TagDescrpProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_TagDescrpProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_TagName Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_TagNameProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_TagName", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.name' field to display the units of the Value tag. ")]
        public string Type2_BaseplatePIDDisplay_III1_TagName
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_TagNameProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_TagNameProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_MIN Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_MINProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_MIN", typeof(double), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Type2_BaseplatePIDDisplay_III1_MIN
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III1_MINProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_MINProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_MAX Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_MAXProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_MAX", typeof(double), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_MAX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Type2_BaseplatePIDDisplay_III1_MAX
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III1_MAXProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_MAXProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III1_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Colour", typeof(int), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III1_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Type1_Display_3Letter_III1_Colour
        {
            get { return (int)this.GetValue(Type1_Display_3Letter_III1_ColourProperty); }
            set { this.SetValue(Type1_Display_3Letter_III1_ColourProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III1_Value Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_ValueProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Value", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Type1_Display_3Letter_III1_Value
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III1_ValueProperty); }
            set { this.SetValue(Type1_Display_3Letter_III1_ValueProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III1_Fail Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_FailProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Fail", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III1_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Type1_Display_3Letter_III1_Fail
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III1_FailProperty); }
            set { this.SetValue(Type1_Display_3Letter_III1_FailProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III2_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III2_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III2_Colour", typeof(int), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III2_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Type1_Display_3Letter_III2_Colour
        {
            get { return (int)this.GetValue(Type1_Display_3Letter_III2_ColourProperty); }
            set { this.SetValue(Type1_Display_3Letter_III2_ColourProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III2_Value Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III2_ValueProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III2_Value", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III2_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Type1_Display_3Letter_III2_Value
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III2_ValueProperty); }
            set { this.SetValue(Type1_Display_3Letter_III2_ValueProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III2_Fail Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III2_FailProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III2_Fail", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III2_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Type1_Display_3Letter_III2_Fail
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III2_FailProperty); }
            set { this.SetValue(Type1_Display_3Letter_III2_FailProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_Feedback Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_FeedbackProperty =
            DependencyProperty.Register("EmbeddedSymbol1_Feedback", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the feedback tagname f-tag here.
For example: fPROCENB")]
        public bool EmbeddedSymbol1_Feedback
        {
            get { return (bool)this.GetValue(EmbeddedSymbol1_FeedbackProperty); }
            set { this.SetValue(EmbeddedSymbol1_FeedbackProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_ConfirmIndirect Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_ConfirmIndirectProperty =
            DependencyProperty.Register("EmbeddedSymbol1_ConfirmIndirect", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_ConfirmIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gPROCENB.name")]
        public string EmbeddedSymbol1_ConfirmIndirect
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_ConfirmIndirectProperty); }
            set { this.SetValue(EmbeddedSymbol1_ConfirmIndirectProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_Disabled Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_DisabledProperty =
            DependencyProperty.Register("EmbeddedSymbol1_Disabled", typeof(bool), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_Disabled.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fPROCENB_DISHMI

True: disable button
False: enable button")]
        public bool EmbeddedSymbol1_Disabled
        {
            get { return (bool)this.GetValue(EmbeddedSymbol1_DisabledProperty); }
            set { this.SetValue(EmbeddedSymbol1_DisabledProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_LeftMessage Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_LeftMessageProperty =
            DependencyProperty.Register("EmbeddedSymbol1_LeftMessage", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_LeftMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"left message")]
        public string EmbeddedSymbol1_LeftMessage
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_LeftMessageProperty); }
            set { this.SetValue(EmbeddedSymbol1_LeftMessageProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_FeedbackIndirect Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_FeedbackIndirectProperty =
            DependencyProperty.Register("EmbeddedSymbol1_FeedbackIndirect", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_FeedbackIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag indirect .name here
For example: fPROCENB.name")]
        public string EmbeddedSymbol1_FeedbackIndirect
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_FeedbackIndirectProperty); }
            set { this.SetValue(EmbeddedSymbol1_FeedbackIndirectProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_RightMessage Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_RightMessageProperty =
            DependencyProperty.Register("EmbeddedSymbol1_RightMessage", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_RightMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"right message for confirmation")]
        public string EmbeddedSymbol1_RightMessage
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_RightMessageProperty); }
            set { this.SetValue(EmbeddedSymbol1_RightMessageProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_NameStoreProperty =
            DependencyProperty.Register("EmbeddedSymbol1_NameStore", typeof(string), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string EmbeddedSymbol1_NameStore
        {
            get { return (string)this.GetValue(EmbeddedSymbol1_NameStoreProperty); }
            set { this.SetValue(EmbeddedSymbol1_NameStoreProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_LeftIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_LeftIndicator_ColourProperty =
            DependencyProperty.Register("EmbeddedSymbol1_LeftIndicator_Colour", typeof(int), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_LeftIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int EmbeddedSymbol1_LeftIndicator_Colour
        {
            get { return (int)this.GetValue(EmbeddedSymbol1_LeftIndicator_ColourProperty); }
            set { this.SetValue(EmbeddedSymbol1_LeftIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// EmbeddedSymbol1_RightIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty EmbeddedSymbol1_RightIndicator_ColourProperty =
            DependencyProperty.Register("EmbeddedSymbol1_RightIndicator_Colour", typeof(int), typeof(IGV_K0003A));

        /// <summary>
        /// Gets or sets the EmbeddedSymbol1_RightIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"when Value is True following color shall apply
1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int EmbeddedSymbol1_RightIndicator_Colour
        {
            get { return (int)this.GetValue(EmbeddedSymbol1_RightIndicator_ColourProperty); }
            set { this.SetValue(EmbeddedSymbol1_RightIndicator_ColourProperty, value); }
        }


		
    }
}
