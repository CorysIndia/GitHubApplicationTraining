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
	[Export("PIC_0125")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PIC_0125
    {
        public PIC_0125()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PIC_0125));

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
        /// ContFpNoDCSTGT1_SP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_SP_ValueProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_SP_Value", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_SP_Value
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_SP_ValueProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_SP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_Enterable_MinProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Enterable_Min", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_MD_Enterable_Min
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_MD_Enterable_MinProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_Enterable_MaxProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Enterable_Max", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_MD_Enterable_Max
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_MD_Enterable_MaxProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_MD_VISProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_MD_VIS", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_TargetBar_MD_VISProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_PV_Value_FailProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_PV_Value_Fail", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_PV_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_PV_Value_FailProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_PVProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_PV", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_PV
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_PVProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_OPProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_OP", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_OP
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_OPProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_SPProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_SP", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_SP
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_SPProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_MDProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_MD", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_MD
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_MDProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_PVMaxProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_PVMax", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_PVMax
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_PVMaxProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_PV_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_PV_ValueProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_PV_Value", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_PV_Value
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_PV_ValueProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_PV_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_ValueProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Value", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_MD_Value
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_MD_ValueProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Enterable Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_EnterableProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Enterable", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_MD_Enterable
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_MD_EnterableProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_EnterableProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_OP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_OP_ValueProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_OP_Value", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_OP_Value
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_OP_ValueProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_OP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_DisableProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_Disable", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ContFpNoDCSTGT1_Button_RL_Disable
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_Button_RL_DisableProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_OPMinProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_OPMin", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double ContFpNoDCSTGT1_TargetBar_OPMin
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_OPMinProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_OPMaxProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_OPMax", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double ContFpNoDCSTGT1_TargetBar_OPMax
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_OPMaxProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_PVMinProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_PVMin", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpNoDCSTGT1_TargetBar_PVMin
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_TargetBar_PVMinProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_TargetBar_SP_VISProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_TargetBar_SP_VIS", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_TargetBar_SP_VISProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_UpPushedProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_UpPushed", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool ContFpNoDCSTGT1_Button_RL_UpPushed
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_Button_RL_UpPushedProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_UpPushedProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_DownPushedProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_DownPushed", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool ContFpNoDCSTGT1_Button_RL_DownPushed
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_Button_RL_DownPushedProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_DownPushedProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_UpFeedbackProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_UpFeedback", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpNoDCSTGT1_Button_RL_UpFeedback
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_Button_RL_UpFeedbackProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_DownFeedbackProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_DownFeedback", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpNoDCSTGT1_Button_RL_DownFeedback
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_Button_RL_DownFeedbackProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_eTAG Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_eTAGProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_eTAG", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double ContFpNoDCSTGT1_Button_RL_eTAG
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_Button_RL_eTAGProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_eTAGProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_Button_RL_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_Button_RL_kAddValueProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_Button_RL_kAddValue", typeof(double), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_Button_RL_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double ContFpNoDCSTGT1_Button_RL_kAddValue
        {
            get { return (double)this.GetValue(ContFpNoDCSTGT1_Button_RL_kAddValueProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_Button_RL_kAddValueProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_SP_Value_FailProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_SP_Value_Fail", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_SP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_SP_Value_FailProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Alarm Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_AlarmProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Alarm", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool ContFpNoDCSTGT1_MD_Alarm
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_MD_AlarmProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_AlarmProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_DisableProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_Disable", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_MD_Disable
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_MD_DisableProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_MD_EnterType Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_MD_EnterTypeProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_MD_EnterType", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_MD_EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool ContFpNoDCSTGT1_MD_EnterType
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_MD_EnterTypeProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_MD_EnterTypeProperty, value); }
        }

        /// <summary>
        /// ContFpNoDCSTGT1_OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpNoDCSTGT1_OP_Value_FailProperty =
            DependencyProperty.Register("ContFpNoDCSTGT1_OP_Value_Fail", typeof(bool), typeof(PIC_0125));

        /// <summary>
        /// Gets or sets the ContFpNoDCSTGT1_OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpNoDCSTGT1_OP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpNoDCSTGT1_OP_Value_FailProperty); }
            set { this.SetValue(ContFpNoDCSTGT1_OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_Feedback Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_FeedbackProperty =
            DependencyProperty.Register("COSwitchConf_011_Feedback", typeof(bool), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_ConfirmIndirect", typeof(string), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_Disabled", typeof(bool), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_LeftMessage", typeof(string), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_FeedbackIndirect", typeof(string), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_RightMessage", typeof(string), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_NameStore", typeof(string), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_LeftIndicator_Colour", typeof(int), typeof(PIC_0125));

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
            DependencyProperty.Register("COSwitchConf_011_RightIndicator_Colour", typeof(int), typeof(PIC_0125));

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


		
    }
}
