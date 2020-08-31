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
	[Export("FIC_0022")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class FIC_0022
    {
        public FIC_0022()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(FIC_0022));

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
        /// ContFpSrg_011_ASC_IN_CNTL1_ModeInt Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_ASC_IN_CNTL1_ModeIntProperty =
            DependencyProperty.Register("ContFpSrg_011_ASC_IN_CNTL1_ModeInt", typeof(int), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_ASC_IN_CNTL1_ModeInt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname of integer to change the text description.")]
        public int ContFpSrg_011_ASC_IN_CNTL1_ModeInt
        {
            get { return (int)this.GetValue(ContFpSrg_011_ASC_IN_CNTL1_ModeIntProperty); }
            set { this.SetValue(ContFpSrg_011_ASC_IN_CNTL1_ModeIntProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_DisableProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_Disable", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ContFpSrg_011_Button_RL_Disable
        {
            get { return (bool)this.GetValue(ContFpSrg_011_Button_RL_DisableProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_DCS_ValueProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_DCS_Value", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_MD_DCS_Value
        {
            get { return (double)this.GetValue(ContFpSrg_011_MD_DCS_ValueProperty); }
            set { this.SetValue(ContFpSrg_011_MD_DCS_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_OP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_OP_ValueProperty =
            DependencyProperty.Register("ContFpSrg_011_OP_Value", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_OP_Value
        {
            get { return (double)this.GetValue(ContFpSrg_011_OP_ValueProperty); }
            set { this.SetValue(ContFpSrg_011_OP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_EnterableProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Enterable", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_MD_HMI_Enterable
        {
            get { return (double)this.GetValue(ContFpSrg_011_MD_HMI_EnterableProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_Enterable_MaxProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Enterable_Max", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double ContFpSrg_011_MD_HMI_Enterable_Max
        {
            get { return (double)this.GetValue(ContFpSrg_011_MD_HMI_Enterable_MaxProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_Enterable_MinProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Enterable_Min", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double ContFpSrg_011_MD_HMI_Enterable_Min
        {
            get { return (double)this.GetValue(ContFpSrg_011_MD_HMI_Enterable_MinProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_ValueProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Value", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_MD_HMI_Value
        {
            get { return (double)this.GetValue(ContFpSrg_011_MD_HMI_ValueProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_SP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_SP_ValueProperty =
            DependencyProperty.Register("ContFpSrg_011_SP_Value", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_SP_Value
        {
            get { return (double)this.GetValue(ContFpSrg_011_SP_ValueProperty); }
            set { this.SetValue(ContFpSrg_011_SP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_PV_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_PV_ValueProperty =
            DependencyProperty.Register("ContFpSrg_011_PV_Value", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_PV_Value
        {
            get { return (double)this.GetValue(ContFpSrg_011_PV_ValueProperty); }
            set { this.SetValue(ContFpSrg_011_PV_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_OPProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_OP", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_OP
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_OPProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_PVProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_PV", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_PV
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_PVProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_PVMaxProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_PVMax", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_PVMax
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_PVMaxProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_PVMinProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_PVMin", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_PVMin
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_PVMinProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_SPProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_SP", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_SP
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_SPProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_MD_VISProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_MD_VIS", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(ContFpSrg_011_TargetBar_MD_VISProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_SP_Value_FailProperty =
            DependencyProperty.Register("ContFpSrg_011_SP_Value_Fail", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_SP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSrg_011_SP_Value_FailProperty); }
            set { this.SetValue(ContFpSrg_011_SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_Enter_DisableProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Enter_Disable", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable")]
        public bool ContFpSrg_011_MD_HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(ContFpSrg_011_MD_HMI_Enter_DisableProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_DownFeedbackProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_DownFeedback", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpSrg_011_Button_RL_DownFeedback
        {
            get { return (bool)this.GetValue(ContFpSrg_011_Button_RL_DownFeedbackProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_DownPushedProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_DownPushed", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool ContFpSrg_011_Button_RL_DownPushed
        {
            get { return (bool)this.GetValue(ContFpSrg_011_Button_RL_DownPushedProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_DownPushedProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_UpFeedbackProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_UpFeedback", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpSrg_011_Button_RL_UpFeedback
        {
            get { return (bool)this.GetValue(ContFpSrg_011_Button_RL_UpFeedbackProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_UpPushedProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_UpPushed", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool ContFpSrg_011_Button_RL_UpPushed
        {
            get { return (bool)this.GetValue(ContFpSrg_011_Button_RL_UpPushedProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_UpPushedProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_OPMinProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_OPMin", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double ContFpSrg_011_TargetBar_OPMin
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_OPMinProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_OPMaxProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_OPMax", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double ContFpSrg_011_TargetBar_OPMax
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_OPMaxProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_MDProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_MD", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSrg_011_TargetBar_MD
        {
            get { return (double)this.GetValue(ContFpSrg_011_TargetBar_MDProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_TargetBar_SP_VISProperty =
            DependencyProperty.Register("ContFpSrg_011_TargetBar_SP_VIS", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(ContFpSrg_011_TargetBar_SP_VISProperty); }
            set { this.SetValue(ContFpSrg_011_TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_eTAG Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_eTAGProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_eTAG", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double ContFpSrg_011_Button_RL_eTAG
        {
            get { return (double)this.GetValue(ContFpSrg_011_Button_RL_eTAGProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_eTAGProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_Button_RL_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_Button_RL_kAddValueProperty =
            DependencyProperty.Register("ContFpSrg_011_Button_RL_kAddValue", typeof(double), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_Button_RL_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double ContFpSrg_011_Button_RL_kAddValue
        {
            get { return (double)this.GetValue(ContFpSrg_011_Button_RL_kAddValueProperty); }
            set { this.SetValue(ContFpSrg_011_Button_RL_kAddValueProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_DCS_Value_FailProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_DCS_Value_Fail", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_MD_DCS_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSrg_011_MD_DCS_Value_FailProperty); }
            set { this.SetValue(ContFpSrg_011_MD_DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_DEV Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_DEVProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_DEV", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_MD_DEV
        {
            get { return (bool)this.GetValue(ContFpSrg_011_MD_DEVProperty); }
            set { this.SetValue(ContFpSrg_011_MD_DEVProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_Value_FailProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Value_Fail", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_MD_HMI_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSrg_011_MD_HMI_Value_FailProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_MD_HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_MD_HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("ContFpSrg_011_MD_HMI_Enterable_Keypad", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_MD_HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool ContFpSrg_011_MD_HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(ContFpSrg_011_MD_HMI_Enterable_KeypadProperty); }
            set { this.SetValue(ContFpSrg_011_MD_HMI_Enterable_KeypadProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_PV_Value_FailProperty =
            DependencyProperty.Register("ContFpSrg_011_PV_Value_Fail", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_PV_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSrg_011_PV_Value_FailProperty); }
            set { this.SetValue(ContFpSrg_011_PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_OP_Value_FailProperty =
            DependencyProperty.Register("ContFpSrg_011_OP_Value_Fail", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSrg_011_OP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSrg_011_OP_Value_FailProperty); }
            set { this.SetValue(ContFpSrg_011_OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_ASC_IN_CNTL1_Int02Txt Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_ASC_IN_CNTL1_Int02TxtProperty =
            DependencyProperty.Register("ContFpSrg_011_ASC_IN_CNTL1_Int02Txt", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_ASC_IN_CNTL1_Int02Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 2.")]
        public string ContFpSrg_011_ASC_IN_CNTL1_Int02Txt
        {
            get { return (string)this.GetValue(ContFpSrg_011_ASC_IN_CNTL1_Int02TxtProperty); }
            set { this.SetValue(ContFpSrg_011_ASC_IN_CNTL1_Int02TxtProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_ASC_IN_CNTL1_Int03Txt Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_ASC_IN_CNTL1_Int03TxtProperty =
            DependencyProperty.Register("ContFpSrg_011_ASC_IN_CNTL1_Int03Txt", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_ASC_IN_CNTL1_Int03Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 3.")]
        public string ContFpSrg_011_ASC_IN_CNTL1_Int03Txt
        {
            get { return (string)this.GetValue(ContFpSrg_011_ASC_IN_CNTL1_Int03TxtProperty); }
            set { this.SetValue(ContFpSrg_011_ASC_IN_CNTL1_Int03TxtProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_ASC_IN_CNTL1_Int00Txt Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_ASC_IN_CNTL1_Int00TxtProperty =
            DependencyProperty.Register("ContFpSrg_011_ASC_IN_CNTL1_Int00Txt", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_ASC_IN_CNTL1_Int00Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 0.")]
        public string ContFpSrg_011_ASC_IN_CNTL1_Int00Txt
        {
            get { return (string)this.GetValue(ContFpSrg_011_ASC_IN_CNTL1_Int00TxtProperty); }
            set { this.SetValue(ContFpSrg_011_ASC_IN_CNTL1_Int00TxtProperty, value); }
        }

        /// <summary>
        /// ContFpSrg_011_ASC_IN_CNTL1_Int01Txt Property
        /// </summary>
        public static readonly DependencyProperty ContFpSrg_011_ASC_IN_CNTL1_Int01TxtProperty =
            DependencyProperty.Register("ContFpSrg_011_ASC_IN_CNTL1_Int01Txt", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the ContFpSrg_011_ASC_IN_CNTL1_Int01Txt.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Text to display when ModeInt equals 1.")]
        public string ContFpSrg_011_ASC_IN_CNTL1_Int01Txt
        {
            get { return (string)this.GetValue(ContFpSrg_011_ASC_IN_CNTL1_Int01TxtProperty); }
            set { this.SetValue(ContFpSrg_011_ASC_IN_CNTL1_Int01TxtProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_gTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_gTagNameProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_gTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_gTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use gTag.Name")]
        public string PbIndFbConf2L_011_gTagName
        {
            get { return (string)this.GetValue(PbIndFbConf2L_011_gTagNameProperty); }
            set { this.SetValue(PbIndFbConf2L_011_gTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_fTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_fTagNameProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_fTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_fTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use fTag.Name")]
        public string PbIndFbConf2L_011_fTagName
        {
            get { return (string)this.GetValue(PbIndFbConf2L_011_fTagNameProperty); }
            set { this.SetValue(PbIndFbConf2L_011_fTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_Feedback Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_FeedbackProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_Feedback", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here.
Button lights up when Feedback is True, goes to grey when Feedback is False.")]
        public bool PbIndFbConf2L_011_Feedback
        {
            get { return (bool)this.GetValue(PbIndFbConf2L_011_FeedbackProperty); }
            set { this.SetValue(PbIndFbConf2L_011_FeedbackProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_Colour Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_ColourProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_Colour", typeof(int), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int PbIndFbConf2L_011_Colour
        {
            get { return (int)this.GetValue(PbIndFbConf2L_011_ColourProperty); }
            set { this.SetValue(PbIndFbConf2L_011_ColourProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_ConfirmationMessageProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_ConfirmationMessage", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_ConfirmationMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the confirmation message
")]
        public string PbIndFbConf2L_011_ConfirmationMessage
        {
            get { return (string)this.GetValue(PbIndFbConf2L_011_ConfirmationMessageProperty); }
            set { this.SetValue(PbIndFbConf2L_011_ConfirmationMessageProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_DisableProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_Disable", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool PbIndFbConf2L_011_Disable
        {
            get { return (bool)this.GetValue(PbIndFbConf2L_011_DisableProperty); }
            set { this.SetValue(PbIndFbConf2L_011_DisableProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_011_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_011_NameStoreProperty =
            DependencyProperty.Register("PbIndFbConf2L_011_NameStore", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_011_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PbIndFbConf2L_011_NameStore
        {
            get { return (string)this.GetValue(PbIndFbConf2L_011_NameStoreProperty); }
            set { this.SetValue(PbIndFbConf2L_011_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_gTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_gTagNameProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_gTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_gTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use gTag.Name")]
        public string PbIndFbConf2L_012_gTagName
        {
            get { return (string)this.GetValue(PbIndFbConf2L_012_gTagNameProperty); }
            set { this.SetValue(PbIndFbConf2L_012_gTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_fTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_fTagNameProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_fTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_fTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use fTag.Name")]
        public string PbIndFbConf2L_012_fTagName
        {
            get { return (string)this.GetValue(PbIndFbConf2L_012_fTagNameProperty); }
            set { this.SetValue(PbIndFbConf2L_012_fTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_Feedback Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_FeedbackProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_Feedback", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here.
Button lights up when Feedback is True, goes to grey when Feedback is False.")]
        public bool PbIndFbConf2L_012_Feedback
        {
            get { return (bool)this.GetValue(PbIndFbConf2L_012_FeedbackProperty); }
            set { this.SetValue(PbIndFbConf2L_012_FeedbackProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_Colour Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_ColourProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_Colour", typeof(int), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int PbIndFbConf2L_012_Colour
        {
            get { return (int)this.GetValue(PbIndFbConf2L_012_ColourProperty); }
            set { this.SetValue(PbIndFbConf2L_012_ColourProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_ConfirmationMessageProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_ConfirmationMessage", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_ConfirmationMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the confirmation message
")]
        public string PbIndFbConf2L_012_ConfirmationMessage
        {
            get { return (string)this.GetValue(PbIndFbConf2L_012_ConfirmationMessageProperty); }
            set { this.SetValue(PbIndFbConf2L_012_ConfirmationMessageProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_DisableProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_Disable", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool PbIndFbConf2L_012_Disable
        {
            get { return (bool)this.GetValue(PbIndFbConf2L_012_DisableProperty); }
            set { this.SetValue(PbIndFbConf2L_012_DisableProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf2L_012_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf2L_012_NameStoreProperty =
            DependencyProperty.Register("PbIndFbConf2L_012_NameStore", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf2L_012_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PbIndFbConf2L_012_NameStore
        {
            get { return (string)this.GetValue(PbIndFbConf2L_012_NameStoreProperty); }
            set { this.SetValue(PbIndFbConf2L_012_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_fTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_fTagNameProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_fTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_fTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use fTag.Name")]
        public string PbIndFbConf_01_M1_fTagName
        {
            get { return (string)this.GetValue(PbIndFbConf_01_M1_fTagNameProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_fTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_Feedback Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_FeedbackProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_Feedback", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here.
Button lights up when Feedback is True, goes to grey when Feedback is False.")]
        public bool PbIndFbConf_01_M1_Feedback
        {
            get { return (bool)this.GetValue(PbIndFbConf_01_M1_FeedbackProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_FeedbackProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_ConfirmationMessage Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_ConfirmationMessageProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_ConfirmationMessage", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_ConfirmationMessage.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the confirmation message
")]
        public string PbIndFbConf_01_M1_ConfirmationMessage
        {
            get { return (string)this.GetValue(PbIndFbConf_01_M1_ConfirmationMessageProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_ConfirmationMessageProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_gTagName Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_gTagNameProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_gTagName", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_gTagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Please use gTag.Name")]
        public string PbIndFbConf_01_M1_gTagName
        {
            get { return (string)this.GetValue(PbIndFbConf_01_M1_gTagNameProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_gTagNameProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_DisableProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_Disable", typeof(bool), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool PbIndFbConf_01_M1_Disable
        {
            get { return (bool)this.GetValue(PbIndFbConf_01_M1_DisableProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_DisableProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_Colour Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_ColourProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_Colour", typeof(int), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_Colour.  
        /// </summary>
		[Category("RSI")]
        [Description(@"1 - Red
2 - Green
3 - Blue
4 - Yellow
5 - Orange
6 - Cyan
7 - Magenta
8 - Gray")]
        public int PbIndFbConf_01_M1_Colour
        {
            get { return (int)this.GetValue(PbIndFbConf_01_M1_ColourProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_ColourProperty, value); }
        }

        /// <summary>
        /// PbIndFbConf_01_M1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbIndFbConf_01_M1_NameStoreProperty =
            DependencyProperty.Register("PbIndFbConf_01_M1_NameStore", typeof(string), typeof(FIC_0022));

        /// <summary>
        /// Gets or sets the PbIndFbConf_01_M1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string PbIndFbConf_01_M1_NameStore
        {
            get { return (string)this.GetValue(PbIndFbConf_01_M1_NameStoreProperty); }
            set { this.SetValue(PbIndFbConf_01_M1_NameStoreProperty, value); }
        }


		
    }
}
