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
	[Export("FP_SPARE_VLV")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FP_SPARE_VLV
    {
        public FP_SPARE_VLV()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FP_SPARE_VLV));

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
        /// PICK Property
        /// </summary>
        public static readonly DependencyProperty PICKProperty =
            DependencyProperty.Register("PICK", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the PICK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PICK
        {
            get { return (string)this.GetValue(PICKProperty); }
            set { this.SetValue(PICKProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the SELECTED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SELECTED
        {
            get { return (int)this.GetValue(SELECTEDProperty); }
            set { this.SetValue(SELECTEDProperty, value); }
        }

        /// <summary>
        /// DS Property
        /// </summary>
        public static readonly DependencyProperty DSProperty =
            DependencyProperty.Register("DS", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the DS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DS
        {
            get { return (bool)this.GetValue(DSProperty); }
            set { this.SetValue(DSProperty, value); }
        }

        /// <summary>
        /// CMPOVL Property
        /// </summary>
        public static readonly DependencyProperty CMPOVLProperty =
            DependencyProperty.Register("CMPOVL", typeof(string), typeof(FP_SPARE_VLV));

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
        /// BLKOVL Property
        /// </summary>
        public static readonly DependencyProperty BLKOVLProperty =
            DependencyProperty.Register("BLKOVL", typeof(string), typeof(FP_SPARE_VLV));

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
        /// PRT Property
        /// </summary>
        public static readonly DependencyProperty PRTProperty =
            DependencyProperty.Register("PRT", typeof(string), typeof(FP_SPARE_VLV));

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
        /// BLKOVL2 Property
        /// </summary>
        public static readonly DependencyProperty BLKOVL2Property =
            DependencyProperty.Register("BLKOVL2", typeof(string), typeof(FP_SPARE_VLV));

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
        /// VALVEA Property
        /// </summary>
        public static readonly DependencyProperty VALVEAProperty =
            DependencyProperty.Register("VALVEA", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the VALVEA.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VALVEA
        {
            get { return (string)this.GetValue(VALVEAProperty); }
            set { this.SetValue(VALVEAProperty, value); }
        }

        /// <summary>
        /// VALVEB Property
        /// </summary>
        public static readonly DependencyProperty VALVEBProperty =
            DependencyProperty.Register("VALVEB", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the VALVEB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string VALVEB
        {
            get { return (string)this.GetValue(VALVEBProperty); }
            set { this.SetValue(VALVEBProperty, value); }
        }

        /// <summary>
        /// MA_A Property
        /// </summary>
        public static readonly DependencyProperty MA_AProperty =
            DependencyProperty.Register("MA_A", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the MA_A.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MA_A
        {
            get { return (bool)this.GetValue(MA_AProperty); }
            set { this.SetValue(MA_AProperty, value); }
        }

        /// <summary>
        /// MA_B Property
        /// </summary>
        public static readonly DependencyProperty MA_BProperty =
            DependencyProperty.Register("MA_B", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the MA_B.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool MA_B
        {
            get { return (bool)this.GetValue(MA_BProperty); }
            set { this.SetValue(MA_BProperty, value); }
        }

        /// <summary>
        /// OUT_A Property
        /// </summary>
        public static readonly DependencyProperty OUT_AProperty =
            DependencyProperty.Register("OUT_A", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the OUT_A.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OUT_A
        {
            get { return (double)this.GetValue(OUT_AProperty); }
            set { this.SetValue(OUT_AProperty, value); }
        }

        /// <summary>
        /// OUT_B Property
        /// </summary>
        public static readonly DependencyProperty OUT_BProperty =
            DependencyProperty.Register("OUT_B", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the OUT_B.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OUT_B
        {
            get { return (double)this.GetValue(OUT_BProperty); }
            set { this.SetValue(OUT_BProperty, value); }
        }

        /// <summary>
        /// Button_Close1_CON1 Property
        /// </summary>
        public static readonly DependencyProperty Button_Close1_CON1Property =
            DependencyProperty.Register("Button_Close1_CON1", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Button_Close1_CON1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool Button_Close1_CON1
        {
            get { return (bool)this.GetValue(Button_Close1_CON1Property); }
            set { this.SetValue(Button_Close1_CON1Property, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_Enterable Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_EnterableProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_Enterable", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Group1_Type2_BaseplatePIDDisplay_III1_Enterable
        {
            get { return (double)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_EnterableProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_EnterableProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_Value Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_ValueProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_Value", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Group1_Type2_BaseplatePIDDisplay_III1_Value
        {
            get { return (double)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_ValueProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_ValueProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_Disable Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_DisableProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_Disable", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"False=Enable value enterable ")]
        public bool Group1_Type2_BaseplatePIDDisplay_III1_Disable
        {
            get { return (bool)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_DisableProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_DisableProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_Units Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_UnitsProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_Units", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.ENGUNITS' field to display the units of the Value tag. ")]
        public string Group1_Type2_BaseplatePIDDisplay_III1_Units
        {
            get { return (string)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_UnitsProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_UnitsProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_TagName Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_TagNameProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_TagName", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Group1_Type2_BaseplatePIDDisplay_III1_TagName
        {
            get { return (string)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_TagNameProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_TagNameProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_TagDescrpProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_TagDescrp", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Group1_Type2_BaseplatePIDDisplay_III1_TagDescrp
        {
            get { return (string)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_TagDescrpProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_TagDescrpProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_AlarmProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_Alarm", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Group1_Type2_BaseplatePIDDisplay_III1_Alarm
        {
            get { return (bool)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_AlarmProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_AlarmProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_EnterType Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_EnterTypeProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_EnterType", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool Group1_Type2_BaseplatePIDDisplay_III1_EnterType
        {
            get { return (bool)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_EnterTypeProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_EnterTypeProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_DisableTag Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_DisableTagProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_DisableTag", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable Tag name and Tag Discription function                         False = enable Tag name and Tag Discription function")]
        public bool Group1_Type2_BaseplatePIDDisplay_III1_DisableTag
        {
            get { return (bool)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_DisableTagProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_DisableTagProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_MIN Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_MINProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_MIN", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Group1_Type2_BaseplatePIDDisplay_III1_MIN
        {
            get { return (double)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_MINProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_MINProperty, value); }
        }

        /// <summary>
        /// Group1_Type2_BaseplatePIDDisplay_III1_MAX Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type2_BaseplatePIDDisplay_III1_MAXProperty =
            DependencyProperty.Register("Group1_Type2_BaseplatePIDDisplay_III1_MAX", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type2_BaseplatePIDDisplay_III1_MAX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Group1_Type2_BaseplatePIDDisplay_III1_MAX
        {
            get { return (double)this.GetValue(Group1_Type2_BaseplatePIDDisplay_III1_MAXProperty); }
            set { this.SetValue(Group1_Type2_BaseplatePIDDisplay_III1_MAXProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III3_Colour Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III3_ColourProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III3_Colour", typeof(int), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III3_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Group1_Type1_Display_3Letter_III3_Colour
        {
            get { return (int)this.GetValue(Group1_Type1_Display_3Letter_III3_ColourProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III3_ColourProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III3_Value Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III3_ValueProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III3_Value", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Group1_Type1_Display_3Letter_III3_Value
        {
            get { return (bool)this.GetValue(Group1_Type1_Display_3Letter_III3_ValueProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III3_ValueProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III3_Fail Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III3_FailProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III3_Fail", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III3_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Group1_Type1_Display_3Letter_III3_Fail
        {
            get { return (bool)this.GetValue(Group1_Type1_Display_3Letter_III3_FailProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III3_FailProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III4_Colour Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III4_ColourProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III4_Colour", typeof(int), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III4_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Group1_Type1_Display_3Letter_III4_Colour
        {
            get { return (int)this.GetValue(Group1_Type1_Display_3Letter_III4_ColourProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III4_ColourProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III4_Value Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III4_ValueProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III4_Value", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III4_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Group1_Type1_Display_3Letter_III4_Value
        {
            get { return (bool)this.GetValue(Group1_Type1_Display_3Letter_III4_ValueProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III4_ValueProperty, value); }
        }

        /// <summary>
        /// Group1_Type1_Display_3Letter_III4_Fail Property
        /// </summary>
        public static readonly DependencyProperty Group1_Type1_Display_3Letter_III4_FailProperty =
            DependencyProperty.Register("Group1_Type1_Display_3Letter_III4_Fail", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group1_Type1_Display_3Letter_III4_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Group1_Type1_Display_3Letter_III4_Fail
        {
            get { return (bool)this.GetValue(Group1_Type1_Display_3Letter_III4_FailProperty); }
            set { this.SetValue(Group1_Type1_Display_3Letter_III4_FailProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_Enterable Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_EnterableProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_Enterable", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Group2_EmbeddedSymbol1_Enterable
        {
            get { return (double)this.GetValue(Group2_EmbeddedSymbol1_EnterableProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_EnterableProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_Value Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_ValueProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_Value", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Group2_EmbeddedSymbol1_Value
        {
            get { return (double)this.GetValue(Group2_EmbeddedSymbol1_ValueProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_ValueProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_Disable Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_DisableProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_Disable", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"False=Enable value enterable ")]
        public bool Group2_EmbeddedSymbol1_Disable
        {
            get { return (bool)this.GetValue(Group2_EmbeddedSymbol1_DisableProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_DisableProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_Units Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_UnitsProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_Units", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.ENGUNITS' field to display the units of the Value tag. ")]
        public string Group2_EmbeddedSymbol1_Units
        {
            get { return (string)this.GetValue(Group2_EmbeddedSymbol1_UnitsProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_UnitsProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_TagName Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_TagNameProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_TagName", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Group2_EmbeddedSymbol1_TagName
        {
            get { return (string)this.GetValue(Group2_EmbeddedSymbol1_TagNameProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_TagNameProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_TagDescrpProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_TagDescrp", typeof(string), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Group2_EmbeddedSymbol1_TagDescrp
        {
            get { return (string)this.GetValue(Group2_EmbeddedSymbol1_TagDescrpProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_TagDescrpProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_Alarm Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_AlarmProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_Alarm", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Group2_EmbeddedSymbol1_Alarm
        {
            get { return (bool)this.GetValue(Group2_EmbeddedSymbol1_AlarmProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_AlarmProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_EnterType Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_EnterTypeProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_EnterType", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool Group2_EmbeddedSymbol1_EnterType
        {
            get { return (bool)this.GetValue(Group2_EmbeddedSymbol1_EnterTypeProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_EnterTypeProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_DisableTag Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_DisableTagProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_DisableTag", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable Tag name and Tag Discription function                         False = enable Tag name and Tag Discription function")]
        public bool Group2_EmbeddedSymbol1_DisableTag
        {
            get { return (bool)this.GetValue(Group2_EmbeddedSymbol1_DisableTagProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_DisableTagProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_MIN Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_MINProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_MIN", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Group2_EmbeddedSymbol1_MIN
        {
            get { return (double)this.GetValue(Group2_EmbeddedSymbol1_MINProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_MINProperty, value); }
        }

        /// <summary>
        /// Group2_EmbeddedSymbol1_MAX Property
        /// </summary>
        public static readonly DependencyProperty Group2_EmbeddedSymbol1_MAXProperty =
            DependencyProperty.Register("Group2_EmbeddedSymbol1_MAX", typeof(double), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_EmbeddedSymbol1_MAX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double Group2_EmbeddedSymbol1_MAX
        {
            get { return (double)this.GetValue(Group2_EmbeddedSymbol1_MAXProperty); }
            set { this.SetValue(Group2_EmbeddedSymbol1_MAXProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III3_Colour Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III3_ColourProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III3_Colour", typeof(int), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III3_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Group2_Type1_Display_3Letter_III3_Colour
        {
            get { return (int)this.GetValue(Group2_Type1_Display_3Letter_III3_ColourProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III3_ColourProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III3_Value Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III3_ValueProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III3_Value", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Group2_Type1_Display_3Letter_III3_Value
        {
            get { return (bool)this.GetValue(Group2_Type1_Display_3Letter_III3_ValueProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III3_ValueProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III3_Fail Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III3_FailProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III3_Fail", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III3_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Group2_Type1_Display_3Letter_III3_Fail
        {
            get { return (bool)this.GetValue(Group2_Type1_Display_3Letter_III3_FailProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III3_FailProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III4_Colour Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III4_ColourProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III4_Colour", typeof(int), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III4_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int Group2_Type1_Display_3Letter_III4_Colour
        {
            get { return (int)this.GetValue(Group2_Type1_Display_3Letter_III4_ColourProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III4_ColourProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III4_Value Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III4_ValueProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III4_Value", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III4_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool Group2_Type1_Display_3Letter_III4_Value
        {
            get { return (bool)this.GetValue(Group2_Type1_Display_3Letter_III4_ValueProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III4_ValueProperty, value); }
        }

        /// <summary>
        /// Group2_Type1_Display_3Letter_III4_Fail Property
        /// </summary>
        public static readonly DependencyProperty Group2_Type1_Display_3Letter_III4_FailProperty =
            DependencyProperty.Register("Group2_Type1_Display_3Letter_III4_Fail", typeof(bool), typeof(FP_SPARE_VLV));

        /// <summary>
        /// Gets or sets the Group2_Type1_Display_3Letter_III4_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool Group2_Type1_Display_3Letter_III4_Fail
        {
            get { return (bool)this.GetValue(Group2_Type1_Display_3Letter_III4_FailProperty); }
            set { this.SetValue(Group2_Type1_Display_3Letter_III4_FailProperty, value); }
        }


		
    }
}
