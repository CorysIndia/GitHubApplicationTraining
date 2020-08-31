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
    public class ButtonBackPanel_HT_III : RSIControlModel
    {
        static ButtonBackPanel_HT_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonBackPanel_HT_III), new FrameworkPropertyMetadata(typeof(ButtonBackPanel_HT_III)));
        }

		public ButtonBackPanel_HT_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(ButtonBackPanel_HT_III));

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
        /// DIGBLKName Property
        /// </summary>
        public static readonly DependencyProperty DIGBLKNameProperty =
            DependencyProperty.Register("DIGBLKName", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGBLKName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGBLKName
        {
            get { return (string)this.GetValue(DIGBLKNameProperty); }
            set { this.SetValue(DIGBLKNameProperty, value); }
        }



        /// <summary>
        /// DIGBLKText Property
        /// </summary>
        public static readonly DependencyProperty DIGBLKTextProperty =
            DependencyProperty.Register("DIGBLKText", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGBLKText.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGBLKText
        {
            get { return (string)this.GetValue(DIGBLKTextProperty); }
            set { this.SetValue(DIGBLKTextProperty, value); }
        }




        /// <summary>
        /// DIGINPUT_01 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_01Property =
            DependencyProperty.Register("DIGINPUT_01", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_01
        {
            get { return (bool)this.GetValue(DIGINPUT_01Property); }
            set { this.SetValue(DIGINPUT_01Property, value); }
        }


        /// <summary>
        /// DIGINPUT_02 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_02Property =
            DependencyProperty.Register("DIGINPUT_02", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_02
        {
            get { return (bool)this.GetValue(DIGINPUT_02Property); }
            set { this.SetValue(DIGINPUT_02Property, value); }
        }

        /// <summary>
        /// DIGINPUT_03 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_03Property =
            DependencyProperty.Register("DIGINPUT_03", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_03
        {
            get { return (bool)this.GetValue(DIGINPUT_03Property); }
            set { this.SetValue(DIGINPUT_03Property, value); }
        }





        /// <summary>
        /// DIGINPUT_01_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_01_TEXT01Property =
            DependencyProperty.Register("DIGINPUT_01_TEXT01", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_01_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_01_TEXT01
        {
            get { return (string)this.GetValue(DIGINPUT_01_TEXT01Property); }
            set { this.SetValue(DIGINPUT_01_TEXT01Property, value); }
        }


        /// <summary>
        /// DIGINPUT_01_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_01_TEXT02Property =
            DependencyProperty.Register("DIGINPUT_01_TEXT02", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_01_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_01_TEXT02
        {
            get { return (string)this.GetValue(DIGINPUT_01_TEXT02Property); }
            set { this.SetValue(DIGINPUT_01_TEXT02Property, value); }
        }



        /// <summary>
        /// DIGINPUT_02_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_02_TEXT01Property =
            DependencyProperty.Register("DIGINPUT_02_TEXT01", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_02_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_02_TEXT01
        {
            get { return (string)this.GetValue(DIGINPUT_02_TEXT01Property); }
            set { this.SetValue(DIGINPUT_02_TEXT01Property, value); }
        }


        /// <summary>
        /// DIGINPUT_02_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_02_TEXT02Property =
            DependencyProperty.Register("DIGINPUT_02_TEXT02", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_02_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_02_TEXT02
        {
            get { return (string)this.GetValue(DIGINPUT_02_TEXT02Property); }
            set { this.SetValue(DIGINPUT_02_TEXT02Property, value); }
        }


        /// <summary>
        /// DIGINPUT_03_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_03_TEXT01Property =
            DependencyProperty.Register("DIGINPUT_03_TEXT01", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_03_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_03_TEXT01
        {
            get { return (string)this.GetValue(DIGINPUT_03_TEXT01Property); }
            set { this.SetValue(DIGINPUT_03_TEXT01Property, value); }
        }


        /// <summary>
        /// DIGINPUT_03_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_03_TEXT02Property =
            DependencyProperty.Register("DIGINPUT_03_TEXT02", typeof(string), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_03_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string DIGINPUT_03_TEXT02
        {
            get { return (string)this.GetValue(DIGINPUT_03_TEXT02Property); }
            set { this.SetValue(DIGINPUT_03_TEXT02Property, value); }
        }





        /// <summary>
        /// DIGINPUT_01_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_01_TEXTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_01_TEXTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_01_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_01_TEXTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_01_TEXTVisibleProperty); }
            set { this.SetValue(DIGINPUT_01_TEXTVisibleProperty, value); }
        }



        /// <summary>
        /// DIGINPUT_02_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_02_TEXTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_02_TEXTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_02_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_02_TEXTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_02_TEXTVisibleProperty); }
            set { this.SetValue(DIGINPUT_02_TEXTVisibleProperty, value); }
        }




        /// <summary>
        /// DIGINPUT_03_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_03_TEXTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_03_TEXTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_03_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_03_TEXTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_03_TEXTVisibleProperty); }
            set { this.SetValue(DIGINPUT_03_TEXTVisibleProperty, value); }
        }




        /// <summary>
        /// DIGINPUT_01_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_01_NOTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_01_NOTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_01_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_01_NOTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_01_NOTVisibleProperty); }
            set { this.SetValue(DIGINPUT_01_NOTVisibleProperty, value); }
        }



        /// <summary>
        /// DIGINPUT_02_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_02_NOTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_02_NOTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_02_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_02_NOTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_02_NOTVisibleProperty); }
            set { this.SetValue(DIGINPUT_02_NOTVisibleProperty, value); }
        }




        /// <summary>
        /// DIGINPUT_03_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty DIGINPUT_03_NOTVisibleProperty =
            DependencyProperty.Register("DIGINPUT_03_NOTVisible", typeof(bool), typeof(ButtonBackPanel_HT_III));

        /// <summary>
        /// Gets or sets the DIGINPUT_03_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool DIGINPUT_03_NOTVisible
        {
            get { return (bool)this.GetValue(DIGINPUT_03_NOTVisibleProperty); }
            set { this.SetValue(DIGINPUT_03_NOTVisibleProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.DIGBLKName)) yield return new Param("$DIGBLKName", this.DIGBLKName);
                if (!string.IsNullOrWhiteSpace(this.DIGBLKText)) yield return new Param("$DIGBLKText", this.DIGBLKText);



            }
        }







    }
}
