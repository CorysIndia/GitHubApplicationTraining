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
    public class COSwitchConf_02 : RSIControlModel
    {
        static COSwitchConf_02()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(COSwitchConf_02), new FrameworkPropertyMetadata(typeof(COSwitchConf_02)));
        }

		public COSwitchConf_02()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(COSwitchConf_02));

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
        /// KnobPosition Property
        /// </summary>
        public static readonly DependencyProperty KnobPositionProperty =
            DependencyProperty.Register("KnobPosition", typeof(int), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the KnobPosition.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Internal tracking of the Knob Position:
KnobPosition = 1(EOST)
KnobPosition = 2(Off)
KnobPosition = 3(OSTM)
")]
        public int KnobPosition
        {
            get { return (int)this.GetValue(KnobPositionProperty); }
            set { this.SetValue(KnobPositionProperty, value); }
        }

        /// <summary>
        /// NameStoreOff Property
        /// </summary>
        public static readonly DependencyProperty NameStoreOffProperty =
            DependencyProperty.Register("NameStoreOff", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the NameStoreOff.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.
")]
        public string NameStoreOff
        {
            get { return (string)this.GetValue(NameStoreOffProperty); }
            set { this.SetValue(NameStoreOffProperty, value); }
        }

        /// <summary>
        /// WinName Property
        /// </summary>
        public static readonly DependencyProperty WinNameProperty =
            DependencyProperty.Register("WinName", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This is the window name, that will be passed to WinOpen in order to open a desire window.
")]
        public string WinName
        {
            get { return (string)this.GetValue(WinNameProperty); }
            set { this.SetValue(WinNameProperty, value); }
        }

        /// <summary>
        /// fRight Property
        /// </summary>
        public static readonly DependencyProperty fRightProperty =
            DependencyProperty.Register("fRight", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the fRight.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool fRight
        {
            get { return (bool)this.GetValue(fRightProperty); }
            set { this.SetValue(fRightProperty, value); }
        }

        /// <summary>
        /// fLeft Property
        /// </summary>
        public static readonly DependencyProperty fLeftProperty =
            DependencyProperty.Register("fLeft", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the fLeft.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool fLeft
        {
            get { return (bool)this.GetValue(fLeftProperty); }
            set { this.SetValue(fLeftProperty, value); }
        }

        /// <summary>
        /// DisableOFF Property
        /// </summary>
        public static readonly DependencyProperty DisableOFFProperty =
            DependencyProperty.Register("DisableOFF", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the DisableOFF.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tagname here to disable OFF switch. 
When True, switch to the OFF is disable.
When False, switch to the OFF is enable.")]
        public bool DisableOFF
        {
            get { return (bool)this.GetValue(DisableOFFProperty); }
            set { this.SetValue(DisableOFFProperty, value); }
        }

        /// <summary>
        /// DisableRIGHT Property
        /// </summary>
        public static readonly DependencyProperty DisableRIGHTProperty =
            DependencyProperty.Register("DisableRIGHT", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the DisableRIGHT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tagname here to disable right switch. 
When True, switch to the right is disable.
When False, switch to the right is enable.")]
        public bool DisableRIGHT
        {
            get { return (bool)this.GetValue(DisableRIGHTProperty); }
            set { this.SetValue(DisableRIGHTProperty, value); }
        }

        /// <summary>
        /// DisableLEFT Property
        /// </summary>
        public static readonly DependencyProperty DisableLEFTProperty =
            DependencyProperty.Register("DisableLEFT", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the DisableLEFT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tagname here to disable left switch. 
When True, switch to the left is disable.
When False, switch to the left is enable.")]
        public bool DisableLEFT
        {
            get { return (bool)this.GetValue(DisableLEFTProperty); }
            set { this.SetValue(DisableLEFTProperty, value); }
        }

        /// <summary>
        /// gLeftTagName Property
        /// </summary>
        public static readonly DependencyProperty gLeftTagNameProperty =
            DependencyProperty.Register("gLeftTagName", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the gLeftTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string gLeftTagName
        {
            get { return (string)this.GetValue(gLeftTagNameProperty); }
            set { this.SetValue(gLeftTagNameProperty, value); }
        }

        /// <summary>
        /// gRightTagName Property
        /// </summary>
        public static readonly DependencyProperty gRightTagNameProperty =
            DependencyProperty.Register("gRightTagName", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the gRightTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string gRightTagName
        {
            get { return (string)this.GetValue(gRightTagNameProperty); }
            set { this.SetValue(gRightTagNameProperty, value); }
        }

        /// <summary>
        /// LeftMessage Property
        /// </summary>
        public static readonly DependencyProperty LeftMessageProperty =
            DependencyProperty.Register("LeftMessage", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the LeftMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string LeftMessage
        {
            get { return (string)this.GetValue(LeftMessageProperty); }
            set { this.SetValue(LeftMessageProperty, value); }
        }

        /// <summary>
        /// RightMessage Property
        /// </summary>
        public static readonly DependencyProperty RightMessageProperty =
            DependencyProperty.Register("RightMessage", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the RightMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string RightMessage
        {
            get { return (string)this.GetValue(RightMessageProperty); }
            set { this.SetValue(RightMessageProperty, value); }
        }

        /// <summary>
        /// CentreMessage Property
        /// </summary>
        public static readonly DependencyProperty CentreMessageProperty =
            DependencyProperty.Register("CentreMessage", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the CentreMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CentreMessage
        {
            get { return (string)this.GetValue(CentreMessageProperty); }
            set { this.SetValue(CentreMessageProperty, value); }
        }

        /// <summary>
        /// NameStoreLeft Property
        /// </summary>
        public static readonly DependencyProperty NameStoreLeftProperty =
            DependencyProperty.Register("NameStoreLeft", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the NameStoreLeft.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NameStoreLeft
        {
            get { return (string)this.GetValue(NameStoreLeftProperty); }
            set { this.SetValue(NameStoreLeftProperty, value); }
        }

        /// <summary>
        /// NameStoreRight Property
        /// </summary>
        public static readonly DependencyProperty NameStoreRightProperty =
            DependencyProperty.Register("NameStoreRight", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the NameStoreRight.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string NameStoreRight
        {
            get { return (string)this.GetValue(NameStoreRightProperty); }
            set { this.SetValue(NameStoreRightProperty, value); }
        }

        /// <summary>
        /// LeftName Property
        /// </summary>
        public static readonly DependencyProperty LeftNameProperty =
            DependencyProperty.Register("LeftName", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the LeftName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Left Switch Name")]
        public string LeftName
        {
            get { return (string)this.GetValue(LeftNameProperty); }
            set { this.SetValue(LeftNameProperty, value); }
        }

        /// <summary>
        /// RightName Property
        /// </summary>
        public static readonly DependencyProperty RightNameProperty =
            DependencyProperty.Register("RightName", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the RightName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Right Switch Name")]
        public string RightName
        {
            get { return (string)this.GetValue(RightNameProperty); }
            set { this.SetValue(RightNameProperty, value); }
        }

        /// <summary>
        /// fLeftTagname Property
        /// </summary>
        public static readonly DependencyProperty fLeftTagnameProperty =
            DependencyProperty.Register("fLeftTagname", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the fLeftTagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string fLeftTagname
        {
            get { return (string)this.GetValue(fLeftTagnameProperty); }
            set { this.SetValue(fLeftTagnameProperty, value); }
        }

        /// <summary>
        /// fRightTagname Property
        /// </summary>
        public static readonly DependencyProperty fRightTagnameProperty =
            DependencyProperty.Register("fRightTagname", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the fRightTagname.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string fRightTagname
        {
            get { return (string)this.GetValue(fRightTagnameProperty); }
            set { this.SetValue(fRightTagnameProperty, value); }
        }

        /// <summary>
        /// CenterIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty CenterIndicator_ColourProperty =
            DependencyProperty.Register("CenterIndicator_Colour", typeof(int), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the CenterIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int CenterIndicator_Colour
        {
            get { return (int)this.GetValue(CenterIndicator_ColourProperty); }
            set { this.SetValue(CenterIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// CenterIndicator_Fail Property
        /// </summary>
        public static readonly DependencyProperty CenterIndicator_FailProperty =
            DependencyProperty.Register("CenterIndicator_Fail", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the CenterIndicator_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool CenterIndicator_Fail
        {
            get { return (bool)this.GetValue(CenterIndicator_FailProperty); }
            set { this.SetValue(CenterIndicator_FailProperty, value); }
        }

        /// <summary>
        /// CenterIndicator_Value Property
        /// </summary>
        public static readonly DependencyProperty CenterIndicator_ValueProperty =
            DependencyProperty.Register("CenterIndicator_Value", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the CenterIndicator_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool CenterIndicator_Value
        {
            get { return (bool)this.GetValue(CenterIndicator_ValueProperty); }
            set { this.SetValue(CenterIndicator_ValueProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_ColourProperty =
            DependencyProperty.Register("LeftIndicator_Colour", typeof(int), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the LeftIndicator_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int LeftIndicator_Colour
        {
            get { return (int)this.GetValue(LeftIndicator_ColourProperty); }
            set { this.SetValue(LeftIndicator_ColourProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Fail Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_FailProperty =
            DependencyProperty.Register("LeftIndicator_Fail", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the LeftIndicator_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool LeftIndicator_Fail
        {
            get { return (bool)this.GetValue(LeftIndicator_FailProperty); }
            set { this.SetValue(LeftIndicator_FailProperty, value); }
        }

        /// <summary>
        /// LeftIndicator_Value Property
        /// </summary>
        public static readonly DependencyProperty LeftIndicator_ValueProperty =
            DependencyProperty.Register("LeftIndicator_Value", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the LeftIndicator_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool LeftIndicator_Value
        {
            get { return (bool)this.GetValue(LeftIndicator_ValueProperty); }
            set { this.SetValue(LeftIndicator_ValueProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Fail Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_FailProperty =
            DependencyProperty.Register("RightIndicator_Fail", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the RightIndicator_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Normal
False - Fail

When fail, symbol is cross out.")]
        public bool RightIndicator_Fail
        {
            get { return (bool)this.GetValue(RightIndicator_FailProperty); }
            set { this.SetValue(RightIndicator_FailProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Value Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_ValueProperty =
            DependencyProperty.Register("RightIndicator_Value", typeof(bool), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the RightIndicator_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True - Symbol turn on
False - Symbol turn off")]
        public bool RightIndicator_Value
        {
            get { return (bool)this.GetValue(RightIndicator_ValueProperty); }
            set { this.SetValue(RightIndicator_ValueProperty, value); }
        }

        /// <summary>
        /// RightIndicator_Colour Property
        /// </summary>
        public static readonly DependencyProperty RightIndicator_ColourProperty =
            DependencyProperty.Register("RightIndicator_Colour", typeof(int), typeof(COSwitchConf_02));


        /////////////////////////////////////////////////////VAIBHAV ADDED//////////////////////////////
        /// <summary>
        /// ZTopHeadLine01 Property
        /// </summary>
        public static readonly DependencyProperty ZTopHeadLine01Property =
            DependencyProperty.Register("ZTopHeadLine01", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZTopHeadLine01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTopHeadLine01
        {
            get { return (string)this.GetValue(ZTopHeadLine01Property); }
            set { this.SetValue(ZTopHeadLine01Property, value); }
        }


        /// <summary>
        /// ZTopHeadLine02 Property
        /// </summary>
        public static readonly DependencyProperty ZTopHeadLine02Property =
            DependencyProperty.Register("ZTopHeadLine02", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZTopHeadLine02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTopHeadLine02
        {
            get { return (string)this.GetValue(ZTopHeadLine02Property); }
            set { this.SetValue(ZTopHeadLine02Property, value); }
        }


        /// <summary>
        /// ZLeftTextCIN Property
        /// </summary>
        public static readonly DependencyProperty ZLeftTextCINProperty =
            DependencyProperty.Register("ZLeftTextCIN", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZLeftTextCIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZLeftTextCIN
        {
            get { return (string)this.GetValue(ZLeftTextCINProperty); }
            set { this.SetValue(ZLeftTextCINProperty, value); }
        }


        /// <summary>
        /// ZRightTextCIN Property
        /// </summary>
        public static readonly DependencyProperty ZRightTextCINProperty =
            DependencyProperty.Register("ZRightTextCIN", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZRightTextCIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZRightTextCIN
        {
            get { return (string)this.GetValue(ZRightTextCINProperty); }
            set { this.SetValue(ZRightTextCINProperty, value); }
        }


        /// <summary>
        /// ZMiddleTextCIN Property
        /// </summary>
        public static readonly DependencyProperty ZMiddleTextCINProperty =
            DependencyProperty.Register("ZMiddleTextCIN", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZMiddleTextCIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZMiddleTextCIN
        {
            get { return (string)this.GetValue(ZMiddleTextCINProperty); }
            set { this.SetValue(ZMiddleTextCINProperty, value); }
        }


        /// <summary>
        /// ZLSFeedbackUO Property
        /// </summary>
        public static readonly DependencyProperty ZLSFeedbackUOProperty =
            DependencyProperty.Register("ZLSFeedbackUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZLSFeedbackUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZLSFeedbackUO
        {
            get { return (string)this.GetValue(ZLSFeedbackUOProperty); }
            set { this.SetValue(ZLSFeedbackUOProperty, value); }
        }


        /// <summary>
        /// ZPDFeedbackUO Property
        /// </summary>
        public static readonly DependencyProperty ZPDFeedbackUOProperty =
            DependencyProperty.Register("ZPDFeedbackUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZPDFeedbackUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZPDFeedbackUO
        {
            get { return (string)this.GetValue(ZPDFeedbackUOProperty); }
            set { this.SetValue(ZPDFeedbackUOProperty, value); }
        }



        /// <summary>
        /// ZLSCammandUO Property
        /// </summary>
        public static readonly DependencyProperty ZLSCammandUOProperty =
            DependencyProperty.Register("ZLSCammandUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZLSCammandUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZLSCammandUO
        {
            get { return (string)this.GetValue(ZLSCammandUOProperty); }
            set { this.SetValue(ZLSCammandUOProperty, value); }
        }




        /// <summary>
        /// ZPDCammandUO Property
        /// </summary>
        public static readonly DependencyProperty ZPDCammandUOProperty =
            DependencyProperty.Register("ZPDCammandUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZPDCammandUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZPDCammandUO
        {
            get { return (string)this.GetValue(ZPDCammandUOProperty); }
            set { this.SetValue(ZPDCammandUOProperty, value); }
        }

        /// <summary>
        /// ZSACammandUO Property
        /// </summary>
        public static readonly DependencyProperty ZSACammandUOProperty =
            DependencyProperty.Register("ZSACammandUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZSACammandUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZSACammandUO
        {
            get { return (string)this.GetValue(ZSACammandUOProperty); }
            set { this.SetValue(ZSACammandUOProperty, value); }
        }


        /// <summary>
        /// ZSAFeedbackUO Property
        /// </summary>
        public static readonly DependencyProperty ZSAFeedbackUOProperty =
            DependencyProperty.Register("ZSAFeedbackUO", typeof(string), typeof(COSwitchConf_02));

        /// <summary>
        /// Gets or sets the ZSAFeedbackUO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZSAFeedbackUO
        {
            get { return (string)this.GetValue(ZSAFeedbackUOProperty); }
            set { this.SetValue(ZSAFeedbackUOProperty, value); }
        }
        //////////////////////////////////////VAIBHAV ADDED//////////////////////////////



        /// <summary>
        /// Gets or sets the RightIndicator_Colour.  
        /// </summary>
        [Category("RSI")]
        [Description(@"1 - Red when Value is True
2 - Green when Value is True
3 - Cyan when Value is True")]
        public int RightIndicator_Colour
        {
            get { return (int)this.GetValue(RightIndicator_ColourProperty); }
            set { this.SetValue(RightIndicator_ColourProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.NameStoreOff)) yield return new Param("$NameStoreOff", this.NameStoreOff);
if (!string.IsNullOrWhiteSpace(this.WinName)) yield return new Param("$WinName", this.WinName);
if (!string.IsNullOrWhiteSpace(this.gLeftTagName)) yield return new Param("$gLeftTagName", this.gLeftTagName);
if (!string.IsNullOrWhiteSpace(this.gRightTagName)) yield return new Param("$gRightTagName", this.gRightTagName);
if (!string.IsNullOrWhiteSpace(this.LeftMessage)) yield return new Param("$LeftMessage", this.LeftMessage);
if (!string.IsNullOrWhiteSpace(this.RightMessage)) yield return new Param("$RightMessage", this.RightMessage);
if (!string.IsNullOrWhiteSpace(this.CentreMessage)) yield return new Param("$CentreMessage", this.CentreMessage);
if (!string.IsNullOrWhiteSpace(this.NameStoreLeft)) yield return new Param("$NameStoreLeft", this.NameStoreLeft);
if (!string.IsNullOrWhiteSpace(this.NameStoreRight)) yield return new Param("$NameStoreRight", this.NameStoreRight);
if (!string.IsNullOrWhiteSpace(this.LeftName)) yield return new Param("$LeftName", this.LeftName);
if (!string.IsNullOrWhiteSpace(this.RightName)) yield return new Param("$RightName", this.RightName);
if (!string.IsNullOrWhiteSpace(this.fLeftTagname)) yield return new Param("$fLeftTagname", this.fLeftTagname);
if (!string.IsNullOrWhiteSpace(this.fRightTagname)) yield return new Param("$fRightTagname", this.fRightTagname);



                if (!string.IsNullOrWhiteSpace(this.ZTopHeadLine01)) yield return new Param("$ZTopHeadLine01", this.ZTopHeadLine01);
                if (!string.IsNullOrWhiteSpace(this.ZTopHeadLine02)) yield return new Param("$ZTopHeadLine02", this.ZTopHeadLine02);
                if (!string.IsNullOrWhiteSpace(this.ZLeftTextCIN)) yield return new Param("$ZLeftTextCIN", this.ZLeftTextCIN);
                if (!string.IsNullOrWhiteSpace(this.ZRightTextCIN)) yield return new Param("$ZRightTextCIN", this.ZRightTextCIN);
                if (!string.IsNullOrWhiteSpace(this.ZMiddleTextCIN)) yield return new Param("$ZMiddleTextCIN", this.ZMiddleTextCIN);
                if (!string.IsNullOrWhiteSpace(this.ZLSFeedbackUO)) yield return new Param("$ZLSFeedbackUO", this.ZLSFeedbackUO);
                if (!string.IsNullOrWhiteSpace(this.ZPDFeedbackUO)) yield return new Param("$ZPDFeedbackUO", this.ZPDFeedbackUO);
                if (!string.IsNullOrWhiteSpace(this.ZLSCammandUO)) yield return new Param("$ZLSCammandUO", this.ZLSCammandUO);
                if (!string.IsNullOrWhiteSpace(this.ZPDCammandUO)) yield return new Param("$ZPDCammandUO", this.ZPDCammandUO);
                if (!string.IsNullOrWhiteSpace(this.ZSACammandUO)) yield return new Param("$ZSACammandUO", this.ZSACammandUO);
                if (!string.IsNullOrWhiteSpace(this.ZSAFeedbackUO)) yield return new Param("$ZSAFeedbackUO", this.ZSAFeedbackUO);







            }
        }

		
    }
}
