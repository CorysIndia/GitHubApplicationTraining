using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using System.ComponentModel.Composition;

namespace UGP_STG.HMI
{
	[Export("SUC_VLV_K0007B")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SUC_VLV_K0007B
    {
        public SUC_VLV_K0007B()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Enterable", typeof(double), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Value", typeof(double), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_DisableTag", typeof(bool), typeof(SUC_VLV_K0007B));

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
        /// Type2_BaseplatePIDDisplay_III1_Units Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_UnitsProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Units", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III1_Units
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_UnitsProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_UnitsProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_TagName Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_TagNameProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_TagName", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III1_TagName
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_TagNameProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_TagNameProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_TagDescrpProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_TagDescrp", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III1_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III1_TagDescrp
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III1_TagDescrpProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III1_TagDescrpProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_AlarmProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Alarm", typeof(bool), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_Disable", typeof(bool), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_EnterType", typeof(bool), typeof(SUC_VLV_K0007B));

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
        /// Type2_BaseplatePIDDisplay_III1_MIN Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III1_MINProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_MIN", typeof(double), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III1_MAX", typeof(double), typeof(SUC_VLV_K0007B));

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
        /// Type2_BaseplatePIDDisplay_III2_Value Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_ValueProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_Value", typeof(double), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Type2_BaseplatePIDDisplay_III2_Value
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III2_ValueProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_ValueProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_Enterable Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_EnterableProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_Enterable", typeof(double), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Type2_BaseplatePIDDisplay_III2_Enterable
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III2_EnterableProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_EnterableProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_DisableTag Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_DisableTagProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_DisableTag", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable Tag name and Tag Discription function                         False = enable Tag name and Tag Discription function")]
        public bool Type2_BaseplatePIDDisplay_III2_DisableTag
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III2_DisableTagProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_DisableTagProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_TagDescrpProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_TagDescrp", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III2_TagDescrp
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III2_TagDescrpProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_TagDescrpProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_TagName Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_TagNameProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_TagName", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III2_TagName
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III2_TagNameProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_TagNameProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_Units Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_UnitsProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_Units", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Type2_BaseplatePIDDisplay_III2_Units
        {
            get { return (string)this.GetValue(Type2_BaseplatePIDDisplay_III2_UnitsProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_UnitsProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_AlarmProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_Alarm", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Type2_BaseplatePIDDisplay_III2_Alarm
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III2_AlarmProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_AlarmProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_Disable Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_DisableProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_Disable", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"False=Enable value enterable ")]
        public bool Type2_BaseplatePIDDisplay_III2_Disable
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III2_DisableProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_DisableProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_EnterType Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_EnterTypeProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_EnterType", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool Type2_BaseplatePIDDisplay_III2_EnterType
        {
            get { return (bool)this.GetValue(Type2_BaseplatePIDDisplay_III2_EnterTypeProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_EnterTypeProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_MIN Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_MINProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_MIN", typeof(double), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Type2_BaseplatePIDDisplay_III2_MIN
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III2_MINProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_MINProperty, value); }
        }

        /// <summary>
        /// Type2_BaseplatePIDDisplay_III2_MAX Property
        /// </summary>
        public static readonly DependencyProperty Type2_BaseplatePIDDisplay_III2_MAXProperty =
            DependencyProperty.Register("Type2_BaseplatePIDDisplay_III2_MAX", typeof(double), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type2_BaseplatePIDDisplay_III2_MAX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Type2_BaseplatePIDDisplay_III2_MAX
        {
            get { return (double)this.GetValue(Type2_BaseplatePIDDisplay_III2_MAXProperty); }
            set { this.SetValue(Type2_BaseplatePIDDisplay_III2_MAXProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_Feedback Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_FeedbackProperty =
            DependencyProperty.Register("COSwitchConf_011_Feedback", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the feedback tagname f-tag here.
For example: fPROCENB")]
        public bool COSwitchConf_011_Feedback
        {
            get { return (bool)this.GetValue(COSwitchConf_011_FeedbackProperty); }
            set { this.SetValue(COSwitchConf_011_FeedbackProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_ConfirmIndirect Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_ConfirmIndirectProperty =
            DependencyProperty.Register("COSwitchConf_011_ConfirmIndirect", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_ConfirmIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag indirect .name here
For example: gPROCENB.name")]
        public string COSwitchConf_011_ConfirmIndirect
        {
            get { return (string)this.GetValue(COSwitchConf_011_ConfirmIndirectProperty); }
            set { this.SetValue(COSwitchConf_011_ConfirmIndirectProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_Disabled Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_DisabledProperty =
            DependencyProperty.Register("COSwitchConf_011_Disabled", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_Disabled.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fPROCENB_DISHMI

True: disable button
False: enable button")]
        public bool COSwitchConf_011_Disabled
        {
            get { return (bool)this.GetValue(COSwitchConf_011_DisabledProperty); }
            set { this.SetValue(COSwitchConf_011_DisabledProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_LeftMessage Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_LeftMessageProperty =
            DependencyProperty.Register("COSwitchConf_011_LeftMessage", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_LeftMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"left message")]
        public string COSwitchConf_011_LeftMessage
        {
            get { return (string)this.GetValue(COSwitchConf_011_LeftMessageProperty); }
            set { this.SetValue(COSwitchConf_011_LeftMessageProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_FeedbackIndirect Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_FeedbackIndirectProperty =
            DependencyProperty.Register("COSwitchConf_011_FeedbackIndirect", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_FeedbackIndirect.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag indirect .name here
For example: fPROCENB.name")]
        public string COSwitchConf_011_FeedbackIndirect
        {
            get { return (string)this.GetValue(COSwitchConf_011_FeedbackIndirectProperty); }
            set { this.SetValue(COSwitchConf_011_FeedbackIndirectProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_RightMessage Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_RightMessageProperty =
            DependencyProperty.Register("COSwitchConf_011_RightMessage", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_RightMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"right message for confirmation")]
        public string COSwitchConf_011_RightMessage
        {
            get { return (string)this.GetValue(COSwitchConf_011_RightMessageProperty); }
            set { this.SetValue(COSwitchConf_011_RightMessageProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_NameStore Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_NameStoreProperty =
            DependencyProperty.Register("COSwitchConf_011_NameStore", typeof(string), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string COSwitchConf_011_NameStore
        {
            get { return (string)this.GetValue(COSwitchConf_011_NameStoreProperty); }
            set { this.SetValue(COSwitchConf_011_NameStoreProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_LeftIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_LeftIndicator_ColourProperty =
            DependencyProperty.Register("COSwitchConf_011_LeftIndicator_Colour", typeof(int), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_LeftIndicator_Colour.  
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
        public int COSwitchConf_011_LeftIndicator_Colour
        {
            get { return (int)this.GetValue(COSwitchConf_011_LeftIndicator_ColourProperty); }
            set { this.SetValue(COSwitchConf_011_LeftIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_RightIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_RightIndicator_ColourProperty =
            DependencyProperty.Register("COSwitchConf_011_RightIndicator_Colour", typeof(int), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the COSwitchConf_011_RightIndicator_Colour.  
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
        public int COSwitchConf_011_RightIndicator_Colour
        {
            get { return (int)this.GetValue(COSwitchConf_011_RightIndicator_ColourProperty); }
            set { this.SetValue(COSwitchConf_011_RightIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III1_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Colour", typeof(int), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Value", typeof(bool), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Fail", typeof(bool), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Colour", typeof(int), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Value", typeof(bool), typeof(SUC_VLV_K0007B));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Fail", typeof(bool), typeof(SUC_VLV_K0007B));

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
        /// Type1_Display_3Letter_III3_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III3_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III3_Colour", typeof(int), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III3_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Type1_Display_3Letter_III3_Colour
        {
            get { return (int)this.GetValue(Type1_Display_3Letter_III3_ColourProperty); }
            set { this.SetValue(Type1_Display_3Letter_III3_ColourProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III3_Value Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III3_ValueProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III3_Value", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Type1_Display_3Letter_III3_Value
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III3_ValueProperty); }
            set { this.SetValue(Type1_Display_3Letter_III3_ValueProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III3_Fail Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III3_FailProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III3_Fail", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III3_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Type1_Display_3Letter_III3_Fail
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III3_FailProperty); }
            set { this.SetValue(Type1_Display_3Letter_III3_FailProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III4_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III4_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III4_Colour", typeof(int), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III4_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Type1_Display_3Letter_III4_Colour
        {
            get { return (int)this.GetValue(Type1_Display_3Letter_III4_ColourProperty); }
            set { this.SetValue(Type1_Display_3Letter_III4_ColourProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III4_Value Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III4_ValueProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III4_Value", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III4_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Type1_Display_3Letter_III4_Value
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III4_ValueProperty); }
            set { this.SetValue(Type1_Display_3Letter_III4_ValueProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III4_Fail Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III4_FailProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III4_Fail", typeof(bool), typeof(SUC_VLV_K0007B));

        /// <summary>
        /// Gets or sets the Type1_Display_3Letter_III4_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Type1_Display_3Letter_III4_Fail
        {
            get { return (bool)this.GetValue(Type1_Display_3Letter_III4_FailProperty); }
            set { this.SetValue(Type1_Display_3Letter_III4_FailProperty, value); }
        }


		
    }
}
