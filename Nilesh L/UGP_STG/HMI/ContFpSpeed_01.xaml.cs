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
    public class ContFpSpeed_01 : RSIControlModel
    {
        static ContFpSpeed_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContFpSpeed_01), new FrameworkPropertyMetadata(typeof(ContFpSpeed_01)));
        }

		public ContFpSpeed_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ContFpSpeed_01));

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
        /// TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPMinProperty =
            DependencyProperty.Register("TargetBar_OPMin", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double TargetBar_OPMin
        {
            get { return (double)this.GetValue(TargetBar_OPMinProperty); }
            set { this.SetValue(TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPMaxProperty =
            DependencyProperty.Register("TargetBar_OPMax", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double TargetBar_OPMax
        {
            get { return (double)this.GetValue(TargetBar_OPMaxProperty); }
            set { this.SetValue(TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVProperty =
            DependencyProperty.Register("TargetBar_PV", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PV
        {
            get { return (double)this.GetValue(TargetBar_PVProperty); }
            set { this.SetValue(TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_OPProperty =
            DependencyProperty.Register("TargetBar_OP", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_OP
        {
            get { return (double)this.GetValue(TargetBar_OPProperty); }
            set { this.SetValue(TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_SPProperty =
            DependencyProperty.Register("TargetBar_SP", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_SP
        {
            get { return (double)this.GetValue(TargetBar_SPProperty); }
            set { this.SetValue(TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_MDProperty =
            DependencyProperty.Register("TargetBar_MD", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_MD
        {
            get { return (double)this.GetValue(TargetBar_MDProperty); }
            set { this.SetValue(TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_MD_VISProperty =
            DependencyProperty.Register("TargetBar_MD_VIS", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(TargetBar_MD_VISProperty); }
            set { this.SetValue(TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVMaxProperty =
            DependencyProperty.Register("TargetBar_PVMax", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PVMax
        {
            get { return (double)this.GetValue(TargetBar_PVMaxProperty); }
            set { this.SetValue(TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_PVMinProperty =
            DependencyProperty.Register("TargetBar_PVMin", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double TargetBar_PVMin
        {
            get { return (double)this.GetValue(TargetBar_PVMinProperty); }
            set { this.SetValue(TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty TargetBar_SP_VISProperty =
            DependencyProperty.Register("TargetBar_SP_VIS", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(TargetBar_SP_VISProperty); }
            set { this.SetValue(TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// Button_RL_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_UpPushedProperty =
            DependencyProperty.Register("Button_RL_UpPushed", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool Button_RL_UpPushed
        {
            get { return (bool)this.GetValue(Button_RL_UpPushedProperty); }
            set { this.SetValue(Button_RL_UpPushedProperty, value); }
        }

        /// <summary>
        /// Button_RL_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_DownPushedProperty =
            DependencyProperty.Register("Button_RL_DownPushed", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool Button_RL_DownPushed
        {
            get { return (bool)this.GetValue(Button_RL_DownPushedProperty); }
            set { this.SetValue(Button_RL_DownPushedProperty, value); }
        }

        /// <summary>
        /// Button_RL_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_UpFeedbackProperty =
            DependencyProperty.Register("Button_RL_UpFeedback", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool Button_RL_UpFeedback
        {
            get { return (bool)this.GetValue(Button_RL_UpFeedbackProperty); }
            set { this.SetValue(Button_RL_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// Button_RL_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_DownFeedbackProperty =
            DependencyProperty.Register("Button_RL_DownFeedback", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool Button_RL_DownFeedback
        {
            get { return (bool)this.GetValue(Button_RL_DownFeedbackProperty); }
            set { this.SetValue(Button_RL_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// Button_RL_eTAG Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_eTAGProperty =
            DependencyProperty.Register("Button_RL_eTAG", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double Button_RL_eTAG
        {
            get { return (double)this.GetValue(Button_RL_eTAGProperty); }
            set { this.SetValue(Button_RL_eTAGProperty, value); }
        }

        /// <summary>
        /// Button_RL_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_kAddValueProperty =
            DependencyProperty.Register("Button_RL_kAddValue", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double Button_RL_kAddValue
        {
            get { return (double)this.GetValue(Button_RL_kAddValueProperty); }
            set { this.SetValue(Button_RL_kAddValueProperty, value); }
        }

        /// <summary>
        /// Button_RL_Disable Property
        /// </summary>
        public static readonly DependencyProperty Button_RL_DisableProperty =
            DependencyProperty.Register("Button_RL_Disable", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the Button_RL_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool Button_RL_Disable
        {
            get { return (bool)this.GetValue(Button_RL_DisableProperty); }
            set { this.SetValue(Button_RL_DisableProperty, value); }
        }

        /// <summary>
        /// SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty SP_Value_FailProperty =
            DependencyProperty.Register("SP_Value_Fail", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool SP_Value_Fail
        {
            get { return (bool)this.GetValue(SP_Value_FailProperty); }
            set { this.SetValue(SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// SP_Value Property
        /// </summary>
        public static readonly DependencyProperty SP_ValueProperty =
            DependencyProperty.Register("SP_Value", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double SP_Value
        {
            get { return (double)this.GetValue(SP_ValueProperty); }
            set { this.SetValue(SP_ValueProperty, value); }
        }

        /// <summary>
        /// PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty PV_Value_FailProperty =
            DependencyProperty.Register("PV_Value_Fail", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PV_Value_Fail
        {
            get { return (bool)this.GetValue(PV_Value_FailProperty); }
            set { this.SetValue(PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// PV_Value Property
        /// </summary>
        public static readonly DependencyProperty PV_ValueProperty =
            DependencyProperty.Register("PV_Value", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PV_Value
        {
            get { return (double)this.GetValue(PV_ValueProperty); }
            set { this.SetValue(PV_ValueProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_DCS_Value_FailProperty =
            DependencyProperty.Register("PID_DCS_TGT_DCS_Value_Fail", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PID_DCS_TGT_DCS_Value_Fail
        {
            get { return (bool)this.GetValue(PID_DCS_TGT_DCS_Value_FailProperty); }
            set { this.SetValue(PID_DCS_TGT_DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_ValueProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Value", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PID_DCS_TGT_HMI_Value
        {
            get { return (double)this.GetValue(PID_DCS_TGT_HMI_ValueProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_ValueProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_DEV Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_DEVProperty =
            DependencyProperty.Register("PID_DCS_TGT_DEV", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PID_DCS_TGT_DEV
        {
            get { return (bool)this.GetValue(PID_DCS_TGT_DEVProperty); }
            set { this.SetValue(PID_DCS_TGT_DEVProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_DCS_ValueProperty =
            DependencyProperty.Register("PID_DCS_TGT_DCS_Value", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PID_DCS_TGT_DCS_Value
        {
            get { return (double)this.GetValue(PID_DCS_TGT_DCS_ValueProperty); }
            set { this.SetValue(PID_DCS_TGT_DCS_ValueProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_Value_FailProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Value_Fail", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool PID_DCS_TGT_HMI_Value_Fail
        {
            get { return (bool)this.GetValue(PID_DCS_TGT_HMI_Value_FailProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_Enter_DisableProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Enter_Disable", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable")]
        public bool PID_DCS_TGT_HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(PID_DCS_TGT_HMI_Enter_DisableProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_EnterableProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Enterable", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double PID_DCS_TGT_HMI_Enterable
        {
            get { return (double)this.GetValue(PID_DCS_TGT_HMI_EnterableProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_Enterable_MaxProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Enterable_Max", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double PID_DCS_TGT_HMI_Enterable_Max
        {
            get { return (double)this.GetValue(PID_DCS_TGT_HMI_Enterable_MaxProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_Enterable_MinProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Enterable_Min", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double PID_DCS_TGT_HMI_Enterable_Min
        {
            get { return (double)this.GetValue(PID_DCS_TGT_HMI_Enterable_MinProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// PID_DCS_TGT_HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty PID_DCS_TGT_HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("PID_DCS_TGT_HMI_Enterable_Keypad", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the PID_DCS_TGT_HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool PID_DCS_TGT_HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(PID_DCS_TGT_HMI_Enterable_KeypadProperty); }
            set { this.SetValue(PID_DCS_TGT_HMI_Enterable_KeypadProperty, value); }
        }

        /// <summary>
        /// OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty OP_Value_FailProperty =
            DependencyProperty.Register("OP_Value_Fail", typeof(bool), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OP_Value_Fail
        {
            get { return (bool)this.GetValue(OP_Value_FailProperty); }
            set { this.SetValue(OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// OP_Value Property
        /// </summary>
        public static readonly DependencyProperty OP_ValueProperty =
            DependencyProperty.Register("OP_Value", typeof(double), typeof(ContFpSpeed_01));

        /// <summary>
        /// Gets or sets the OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double OP_Value
        {
            get { return (double)this.GetValue(OP_ValueProperty); }
            set { this.SetValue(OP_ValueProperty, value); }
        }


		
		
    }
}
