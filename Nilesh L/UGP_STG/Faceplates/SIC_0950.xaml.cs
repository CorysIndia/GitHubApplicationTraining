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
	[Export("SIC_0950")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SIC_0950
    {
        public SIC_0950()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SIC_0950));

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
        /// ContFpVPID_011_MD_DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_DCS_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_DCS_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_MD_DCS_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_MD_DCS_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_MD_DCS_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_EnterableProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Enterable", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_MD_HMI_Enterable
        {
            get { return (double)this.GetValue(ContFpVPID_011_MD_HMI_EnterableProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_Enterable_MaxProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Enterable_Max", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double ContFpVPID_011_MD_HMI_Enterable_Max
        {
            get { return (double)this.GetValue(ContFpVPID_011_MD_HMI_Enterable_MaxProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_Enterable_MinProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Enterable_Min", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double ContFpVPID_011_MD_HMI_Enterable_Min
        {
            get { return (double)this.GetValue(ContFpVPID_011_MD_HMI_Enterable_MinProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_MD_HMI_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_MD_HMI_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_OP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_OP_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_OP_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_OP_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_OP_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_OP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_PV_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_PV_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_PV_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_PV_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_PV_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_PV_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_SP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_SP_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_SP_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_SP_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_SP_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_SP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_MD_VISProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_MD_VIS", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TargetBar_MD_VISProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_OPProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_OP", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_OP
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_OPProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_PVMaxProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_PVMax", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_PVMax
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_PVMaxProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_PVProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_PV", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_PV
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_PVProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_SPProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_SP", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_SP
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_SPProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_DCS_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_DCS_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_DCS_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_DCS_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TGT_DCS_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_TGT_DCS_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_DCS_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Enterable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_EnterableProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Enterable", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TGT_HMI_Enterable
        {
            get { return (double)this.GetValue(ContFpVPID_011_TGT_HMI_EnterableProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_EnterableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Enterable_Max Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_Enterable_MaxProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Enterable_Max", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Enterable_Max.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Max. Value")]
        public double ContFpVPID_011_TGT_HMI_Enterable_Max
        {
            get { return (double)this.GetValue(ContFpVPID_011_TGT_HMI_Enterable_MaxProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_Enterable_MaxProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Enterable_Min Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_Enterable_MinProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Enterable_Min", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Enterable_Min.  
        /// </summary>
		[Category("RSI")]
        [Description(@"HMI Enterable Min. Value")]
        public double ContFpVPID_011_TGT_HMI_Enterable_Min
        {
            get { return (double)this.GetValue(ContFpVPID_011_TGT_HMI_Enterable_MinProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_Enterable_MinProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_ValueProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Value", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TGT_HMI_Value
        {
            get { return (double)this.GetValue(ContFpVPID_011_TGT_HMI_ValueProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_Enter_DisableProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Enter_Disable", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable")]
        public bool ContFpVPID_011_TGT_HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TGT_HMI_Enter_DisableProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Enter_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_Enter_DisableProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Enter_Disable", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Enter_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable")]
        public bool ContFpVPID_011_MD_HMI_Enter_Disable
        {
            get { return (bool)this.GetValue(ContFpVPID_011_MD_HMI_Enter_DisableProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_Enter_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_DisableProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_Disable", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ContFpVPID_011_Button_RL_SP_Disable
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_SP_DisableProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_UpFeedbackProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_UpFeedback", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpVPID_011_Button_RL_SP_UpFeedback
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_SP_UpFeedbackProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_UpPushedProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_UpPushed", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool ContFpVPID_011_Button_RL_SP_UpPushed
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_SP_UpPushedProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_UpPushedProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_DownFeedbackProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_DownFeedback", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpVPID_011_Button_RL_SP_DownFeedback
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_SP_DownFeedbackProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_DownPushedProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_DownPushed", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool ContFpVPID_011_Button_RL_SP_DownPushed
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_SP_DownPushedProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_DownPushedProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_kAddValueProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_kAddValue", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double ContFpVPID_011_Button_RL_SP_kAddValue
        {
            get { return (double)this.GetValue(ContFpVPID_011_Button_RL_SP_kAddValueProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_kAddValueProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_SP_eTAG Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_SP_eTAGProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_SP_eTAG", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_SP_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double ContFpVPID_011_Button_RL_SP_eTAG
        {
            get { return (double)this.GetValue(ContFpVPID_011_Button_RL_SP_eTAGProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_SP_eTAGProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_Disable Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_DisableProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_Disable", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool ContFpVPID_011_Button_RL_MD_Disable
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_MD_DisableProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_DisableProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_OPMinProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_OPMin", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double ContFpVPID_011_TargetBar_OPMin
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_OPMinProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_OPMaxProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_OPMax", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double ContFpVPID_011_TargetBar_OPMax
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_OPMaxProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_MDProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_MD", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_MD
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_MDProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_PVMinProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_PVMin", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpVPID_011_TargetBar_PVMin
        {
            get { return (double)this.GetValue(ContFpVPID_011_TargetBar_PVMinProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TargetBar_SP_VISProperty =
            DependencyProperty.Register("ContFpVPID_011_TargetBar_SP_VIS", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TargetBar_SP_VISProperty); }
            set { this.SetValue(ContFpVPID_011_TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_DCS_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_DCS_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_TGT_DCS_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TGT_DCS_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_DEV Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_DEVProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_DEV", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_TGT_DEV
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TGT_DEVProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_DEVProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_TGT_HMI_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TGT_HMI_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_TGT_HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_TGT_HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("ContFpVPID_011_TGT_HMI_Enterable_Keypad", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_TGT_HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool ContFpVPID_011_TGT_HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(ContFpVPID_011_TGT_HMI_Enterable_KeypadProperty); }
            set { this.SetValue(ContFpVPID_011_TGT_HMI_Enterable_KeypadProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_DCS_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_DCS_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_DCS_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_DCS_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_MD_DCS_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_MD_DCS_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_MD_DCS_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_DEV Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_DEVProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_DEV", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_DEV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_MD_DEV
        {
            get { return (bool)this.GetValue(ContFpVPID_011_MD_DEVProperty); }
            set { this.SetValue(ContFpVPID_011_MD_DEVProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_MD_HMI_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_MD_HMI_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_MD_HMI_Enterable_Keypad Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_MD_HMI_Enterable_KeypadProperty =
            DependencyProperty.Register("ContFpVPID_011_MD_HMI_Enterable_Keypad", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_MD_HMI_Enterable_Keypad.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Enter from Keypad
False = Enter from Keyborad")]
        public bool ContFpVPID_011_MD_HMI_Enterable_Keypad
        {
            get { return (bool)this.GetValue(ContFpVPID_011_MD_HMI_Enterable_KeypadProperty); }
            set { this.SetValue(ContFpVPID_011_MD_HMI_Enterable_KeypadProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_PV_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_PV_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_PV_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_PV_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_OP_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_OP_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_OP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_OP_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_SP_Value_FailProperty =
            DependencyProperty.Register("ContFpVPID_011_SP_Value_Fail", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpVPID_011_SP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpVPID_011_SP_Value_FailProperty); }
            set { this.SetValue(ContFpVPID_011_SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_UpPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_UpPushedProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_UpPushed", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_UpPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to raise the value")]
        public bool ContFpVPID_011_Button_RL_MD_UpPushed
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_MD_UpPushedProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_UpPushedProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_DownPushed Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_DownPushedProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_DownPushed", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_DownPushed.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the g-tag here to lower the value")]
        public bool ContFpVPID_011_Button_RL_MD_DownPushed
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_MD_DownPushedProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_DownPushedProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_UpFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_UpFeedbackProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_UpFeedback", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_UpFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpVPID_011_Button_RL_MD_UpFeedback
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_MD_UpFeedbackProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_UpFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_DownFeedback Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_DownFeedbackProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_DownFeedback", typeof(bool), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_DownFeedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the f-tag here. The up arrow will be green when UpFeedback = True.")]
        public bool ContFpVPID_011_Button_RL_MD_DownFeedback
        {
            get { return (bool)this.GetValue(ContFpVPID_011_Button_RL_MD_DownFeedbackProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_DownFeedbackProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_eTAG Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_eTAGProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_eTAG", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_eTAG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"eTag, for Raise and Lower the Setpoint, MUST double check the MaxRange and MinRange of this eTag.")]
        public double ContFpVPID_011_Button_RL_MD_eTAG
        {
            get { return (double)this.GetValue(ContFpVPID_011_Button_RL_MD_eTAGProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_eTAGProperty, value); }
        }

        /// <summary>
        /// ContFpVPID_011_Button_RL_MD_kAddValue Property
        /// </summary>
        public static readonly DependencyProperty ContFpVPID_011_Button_RL_MD_kAddValueProperty =
            DependencyProperty.Register("ContFpVPID_011_Button_RL_MD_kAddValue", typeof(double), typeof(SIC_0950));

        /// <summary>
        /// Gets or sets the ContFpVPID_011_Button_RL_MD_kAddValue.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Constant value, define increace or decreace value for one click on the Raise/Lower Button. if not used set to '0'. Normally, this would be the RampRate.")]
        public double ContFpVPID_011_Button_RL_MD_kAddValue
        {
            get { return (double)this.GetValue(ContFpVPID_011_Button_RL_MD_kAddValueProperty); }
            set { this.SetValue(ContFpVPID_011_Button_RL_MD_kAddValueProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_Feedback Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_FeedbackProperty =
            DependencyProperty.Register("COSwitchConf_011_Feedback", typeof(bool), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_ConfirmIndirect", typeof(string), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_Disabled", typeof(bool), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_LeftMessage", typeof(string), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_FeedbackIndirect", typeof(string), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_RightMessage", typeof(string), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_NameStore", typeof(string), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_LeftIndicator_Colour", typeof(int), typeof(SIC_0950));

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
            DependencyProperty.Register("COSwitchConf_011_RightIndicator_Colour", typeof(int), typeof(SIC_0950));

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
