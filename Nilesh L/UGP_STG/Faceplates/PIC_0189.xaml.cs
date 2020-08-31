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
	[Export("PIC_0189")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PIC_0189
    {
        public PIC_0189()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PIC_0189));

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
        /// ContFpSpeed_011_TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_PVProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_PV", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_PV
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_PVProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_PVMaxProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_PVMax", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_PVMax
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_PVMaxProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_SPProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_SP", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_SP
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_SPProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_PVMinProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_PVMin", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_PVMin
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_PVMinProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_OPProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_OP", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_OP
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_OPProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PV_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PV_ValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_PV_Value", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_PV_Value
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PV_ValueProperty); }
            set { this.SetValue(ContFpSpeed_011_PV_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_SP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_SP_ValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_SP_Value", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_SP_Value
        {
            get { return (double)this.GetValue(ContFpSpeed_011_SP_ValueProperty); }
            set { this.SetValue(ContFpSpeed_011_SP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_ValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Value", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_PID_DCS_TGT_HMI_Value
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_ValueProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_EnterableProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_EnterableProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_DCS_ValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_DCS_Value", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_PID_DCS_TGT_DCS_Value
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_DCS_ValueProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_DCS_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_OP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_OP_ValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_OP_Value", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_OP_Value
        {
            get { return (double)this.GetValue(ContFpSpeed_011_OP_ValueProperty); }
            set { this.SetValue(ContFpSpeed_011_OP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_UpPushedProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_UpPushed", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool ContFpSpeed_011_Button_RL_UpPushed
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_Button_RL_UpPushedProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_UpPushedProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_UpFeedbackProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_UpFeedback", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpSpeed_011_Button_RL_UpFeedback
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_Button_RL_UpFeedbackProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_DownPushedProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_DownPushed", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool ContFpSpeed_011_Button_RL_DownPushed
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_Button_RL_DownPushedProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_DownPushedProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_DownFeedbackProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_DownFeedback", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpSpeed_011_Button_RL_DownFeedback
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_Button_RL_DownFeedbackProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PV_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeed_011_PV_Value_Fail", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_PV_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PV_Value_FailProperty); }
            set { this.SetValue(ContFpSpeed_011_PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_DCS_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_DCS_Value_Fail", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_PID_DCS_TGT_DCS_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_DCS_Value_FailProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_DEV Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_DEVProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_DEV", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_PID_DCS_TGT_DEV
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_DEVProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_DEVProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_DisableProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_Disable", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_DisableProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MaxProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Max", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Max
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MaxProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Keypad", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_KeypadProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_KeypadProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Value_Fail", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_PID_DCS_TGT_HMI_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Value_FailProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_DisableProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_Disable", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ContFpSpeed_011_Button_RL_Disable
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_Button_RL_DisableProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MinProperty =
            DependencyProperty.Register("ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Min", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_Min
        {
            get { return (double)this.GetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MinProperty); }
            set { this.SetValue(ContFpSpeed_011_PID_DCS_TGT_HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_MD_VISProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_MD_VIS", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_TargetBar_MD_VISProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_kAddValueProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_kAddValue", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double ContFpSpeed_011_Button_RL_kAddValue
        {
            get { return (double)this.GetValue(ContFpSpeed_011_Button_RL_kAddValueProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_kAddValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_OPMinProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_OPMin", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double ContFpSpeed_011_TargetBar_OPMin
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_OPMinProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_OPMaxProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_OPMax", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double ContFpSpeed_011_TargetBar_OPMax
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_OPMaxProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_MDProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_MD", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeed_011_TargetBar_MD
        {
            get { return (double)this.GetValue(ContFpSpeed_011_TargetBar_MDProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_TargetBar_SP_VISProperty =
            DependencyProperty.Register("ContFpSpeed_011_TargetBar_SP_VIS", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_TargetBar_SP_VISProperty); }
            set { this.SetValue(ContFpSpeed_011_TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_Button_RL_eTAG Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_Button_RL_eTAGProperty =
            DependencyProperty.Register("ContFpSpeed_011_Button_RL_eTAG", typeof(double), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_Button_RL_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double ContFpSpeed_011_Button_RL_eTAG
        {
            get { return (double)this.GetValue(ContFpSpeed_011_Button_RL_eTAGProperty); }
            set { this.SetValue(ContFpSpeed_011_Button_RL_eTAGProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_SP_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeed_011_SP_Value_Fail", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_SP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_SP_Value_FailProperty); }
            set { this.SetValue(ContFpSpeed_011_SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeed_011_OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeed_011_OP_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeed_011_OP_Value_Fail", typeof(bool), typeof(PIC_0189));

        /// <summary>
        /// Gets or sets the ContFpSpeed_011_OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeed_011_OP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeed_011_OP_Value_FailProperty); }
            set { this.SetValue(ContFpSpeed_011_OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// Type1_Display_3Letter_III1_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Colour", typeof(int), typeof(PIC_0189));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Value", typeof(bool), typeof(PIC_0189));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Fail", typeof(bool), typeof(PIC_0189));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Colour", typeof(int), typeof(PIC_0189));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Value", typeof(bool), typeof(PIC_0189));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Fail", typeof(bool), typeof(PIC_0189));

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


		
    }
}
