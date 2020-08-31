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
	[Export("IIC_1070")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class IIC_1070
    {
        public IIC_1070()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_OP_Value", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_PV_Value", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_PV_Value_Fail", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_SP_Value", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_MD_VIS", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OP", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PV", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PVMax", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_SP", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OPMin", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_OPMax", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_MD", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_PVMin", typeof(double), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_TargetBar_SP_VIS", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_SP_Value_Fail", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("ContFpSpeedNoDCS1_OP_Value_Fail", typeof(bool), typeof(IIC_1070));

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
        /// Type1_Display_3Letter_III1_Colour Property
        /// </summary>
        public static readonly DependencyProperty Type1_Display_3Letter_III1_ColourProperty =
            DependencyProperty.Register("Type1_Display_3Letter_III1_Colour", typeof(int), typeof(IIC_1070));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Value", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("Type1_Display_3Letter_III1_Fail", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Colour", typeof(int), typeof(IIC_1070));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Value", typeof(bool), typeof(IIC_1070));

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
            DependencyProperty.Register("Type1_Display_3Letter_III2_Fail", typeof(bool), typeof(IIC_1070));

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
