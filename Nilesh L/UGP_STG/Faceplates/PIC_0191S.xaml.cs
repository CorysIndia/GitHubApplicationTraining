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
	[Export("PIC_0191S")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PIC_0191S
    {
        public PIC_0191S()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PIC_0191S));

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
        /// ContFpSpeedNoDCS1_OP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_OP_ValueProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_OP_Value", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_OP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_OP_Value
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_OP_ValueProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_OP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_PV_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_PV_ValueProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_PV_Value", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_PV_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_PV_Value
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_PV_ValueProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_PV_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_PV_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_PV_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_PV_Value_Fail", typeof(bool), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_PV_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeedNoDCS1_PV_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeedNoDCS1_PV_Value_FailProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_PV_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_SP_Value Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_SP_ValueProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_SP_Value", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_SP_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_SP_Value
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_SP_ValueProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_SP_ValueProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_MD_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_MD_VISProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_MD_VIS", typeof(bool), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_MD_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeedNoDCS1_TargetBar_MD_VIS
        {
            get { return (bool)this.GetValue(ContFpSpeedNoDCS1_TargetBar_MD_VISProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_MD_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_OP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_OPProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OP", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_OP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_OP
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_OPProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_OPProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_PV Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_PVProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PV", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_PV.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_PV
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_PVProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_PVProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_PVMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_PVMaxProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PVMax", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_PVMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_PVMax
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_PVMaxProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_PVMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_SP Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_SPProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_SP", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_SP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_SP
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_SPProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_SPProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_OPMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_OPMinProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OPMin", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_OPMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Minimum Value for OP")]
        public double ContFpSpeedNoDCS1_TargetBar_OPMin
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_OPMinProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_OPMinProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_OPMax Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_OPMaxProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OPMax", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_OPMax.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Maximum Value for OP")]
        public double ContFpSpeedNoDCS1_TargetBar_OPMax
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_OPMaxProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_OPMaxProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_MD Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_MDProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_MD", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_MD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_MD
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_MDProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_MDProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_PVMin Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_PVMinProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PVMin", typeof(double), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_PVMin.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double ContFpSpeedNoDCS1_TargetBar_PVMin
        {
            get { return (double)this.GetValue(ContFpSpeedNoDCS1_TargetBar_PVMinProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_PVMinProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_TargetBar_SP_VIS Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_TargetBar_SP_VISProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_SP_VIS", typeof(bool), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_TargetBar_SP_VIS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeedNoDCS1_TargetBar_SP_VIS
        {
            get { return (bool)this.GetValue(ContFpSpeedNoDCS1_TargetBar_SP_VISProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_TargetBar_SP_VISProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_SP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_SP_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_SP_Value_Fail", typeof(bool), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_SP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeedNoDCS1_SP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeedNoDCS1_SP_Value_FailProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_SP_Value_FailProperty, value); }
        }

        /// <summary>
        /// ContFpSpeedNoDCS1_OP_Value_Fail Property
        /// </summary>
        public static readonly DependencyProperty ContFpSpeedNoDCS1_OP_Value_FailProperty =
            DependencyProperty.Register("ContFpSpeedNoDCS1_OP_Value_Fail", typeof(bool), typeof(PIC_0191S));

        /// <summary>
        /// Gets or sets the ContFpSpeedNoDCS1_OP_Value_Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool ContFpSpeedNoDCS1_OP_Value_Fail
        {
            get { return (bool)this.GetValue(ContFpSpeedNoDCS1_OP_Value_FailProperty); }
            set { this.SetValue(ContFpSpeedNoDCS1_OP_Value_FailProperty, value); }
        }

        /// <summary>
        /// COSwitchConf_011_Feedback Property
        /// </summary>
        public static readonly DependencyProperty COSwitchConf_011_FeedbackProperty =
            DependencyProperty.Register("COSwitchConf_011_Feedback", typeof(bool), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_ConfirmIndirect", typeof(string), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_Disabled", typeof(bool), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_LeftMessage", typeof(string), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_FeedbackIndirect", typeof(string), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_RightMessage", typeof(string), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_NameStore", typeof(string), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_LeftIndicator_Colour", typeof(int), typeof(PIC_0191S));

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
            DependencyProperty.Register("COSwitchConf_011_RightIndicator_Colour", typeof(int), typeof(PIC_0191S));

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
