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
    public class Button : RSIControlModel
    {
        static Button()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Button), new FrameworkPropertyMetadata(typeof(Button)));
        }

		public Button()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Button));

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
        /// BLKName Property
        /// </summary>
        public static readonly DependencyProperty BLKNameProperty =
            DependencyProperty.Register("BLKName", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the BLKName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKName
        {
            get { return (string)this.GetValue(BLKNameProperty); }
            set { this.SetValue(BLKNameProperty, value); }
        }



        /// <summary>
        /// BLKText Property
        /// </summary>
        public static readonly DependencyProperty BLKTextProperty =
            DependencyProperty.Register("BLKText", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the BLKText.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLKText
        {
            get { return (string)this.GetValue(BLKTextProperty); }
            set { this.SetValue(BLKTextProperty, value); }
        }


        /// <summary>
        /// INPUT_01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_01Property =
            DependencyProperty.Register("INPUT_01", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_01
        {
            get { return (bool)this.GetValue(INPUT_01Property); }
            set { this.SetValue(INPUT_01Property, value); }
        }


        /// <summary>
        /// INPUT_02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_02Property =
            DependencyProperty.Register("INPUT_02", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_02
        {
            get { return (bool)this.GetValue(INPUT_02Property); }
            set { this.SetValue(INPUT_02Property, value); }
        }

        /// <summary>
        /// INPUT_03 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_03Property =
            DependencyProperty.Register("INPUT_03", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_03
        {
            get { return (bool)this.GetValue(INPUT_03Property); }
            set { this.SetValue(INPUT_03Property, value); }
        }


        /// <summary>
        /// INPUT_04 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_04Property =
            DependencyProperty.Register("INPUT_04", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_04
        {
            get { return (bool)this.GetValue(INPUT_04Property); }
            set { this.SetValue(INPUT_04Property, value); }
        }

        /// <summary>
        /// INPUT_05 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_05Property =
            DependencyProperty.Register("INPUT_05", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_05
        {
            get { return (bool)this.GetValue(INPUT_05Property); }
            set { this.SetValue(INPUT_05Property, value); }
        }




        /// <summary>
        /// INPUT_06 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_06Property =
            DependencyProperty.Register("INPUT_06", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_06
        {
            get { return (bool)this.GetValue(INPUT_06Property); }
            set { this.SetValue(INPUT_06Property, value); }
        }


        /// <summary>
        /// INPUT_01_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_01_TEXT01Property =
            DependencyProperty.Register("INPUT_01_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_01_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_01_TEXT01
        {
            get { return (string)this.GetValue(INPUT_01_TEXT01Property); }
            set { this.SetValue(INPUT_01_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_01_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_01_TEXT02Property =
            DependencyProperty.Register("INPUT_01_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_01_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_01_TEXT02
        {
            get { return (string)this.GetValue(INPUT_01_TEXT02Property); }
            set { this.SetValue(INPUT_01_TEXT02Property, value); }
        }

        
        
        /// <summary>
        /// INPUT_02_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_02_TEXT01Property =
            DependencyProperty.Register("INPUT_02_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_02_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_02_TEXT01
        {
            get { return (string)this.GetValue(INPUT_02_TEXT01Property); }
            set { this.SetValue(INPUT_02_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_02_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_02_TEXT02Property =
            DependencyProperty.Register("INPUT_02_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_02_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_02_TEXT02
        {
            get { return (string)this.GetValue(INPUT_02_TEXT02Property); }
            set { this.SetValue(INPUT_02_TEXT02Property, value); }
        }


        /// <summary>
        /// INPUT_03_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_03_TEXT01Property =
            DependencyProperty.Register("INPUT_03_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_03_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_03_TEXT01
        {
            get { return (string)this.GetValue(INPUT_03_TEXT01Property); }
            set { this.SetValue(INPUT_03_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_03_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_03_TEXT02Property =
            DependencyProperty.Register("INPUT_03_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_03_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_03_TEXT02
        {
            get { return (string)this.GetValue(INPUT_03_TEXT02Property); }
            set { this.SetValue(INPUT_03_TEXT02Property, value); }
        }




        /// <summary>
        /// INPUT_04_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_04_TEXT01Property =
            DependencyProperty.Register("INPUT_04_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_04_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_04_TEXT01
        {
            get { return (string)this.GetValue(INPUT_04_TEXT01Property); }
            set { this.SetValue(INPUT_04_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_04_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_04_TEXT02Property =
            DependencyProperty.Register("INPUT_04_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_04_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_04_TEXT02
        {
            get { return (string)this.GetValue(INPUT_04_TEXT02Property); }
            set { this.SetValue(INPUT_04_TEXT02Property, value); }
        }


        

        /// <summary>
        /// INPUT_05_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_05_TEXT01Property =
            DependencyProperty.Register("INPUT_05_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_05_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_05_TEXT01
        {
            get { return (string)this.GetValue(INPUT_05_TEXT01Property); }
            set { this.SetValue(INPUT_05_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_05_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_05_TEXT02Property =
            DependencyProperty.Register("INPUT_05_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_05_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_05_TEXT02
        {
            get { return (string)this.GetValue(INPUT_05_TEXT02Property); }
            set { this.SetValue(INPUT_05_TEXT02Property, value); }
        }





        /// <summary>
        /// INPUT_06_TEXT01 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_06_TEXT01Property =
            DependencyProperty.Register("INPUT_06_TEXT01", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_06_TEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_06_TEXT01
        {
            get { return (string)this.GetValue(INPUT_06_TEXT01Property); }
            set { this.SetValue(INPUT_06_TEXT01Property, value); }
        }


        /// <summary>
        /// INPUT_06_TEXT02 Property
        /// </summary>
        public static readonly DependencyProperty INPUT_06_TEXT02Property =
            DependencyProperty.Register("INPUT_06_TEXT02", typeof(string), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_06_TEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string INPUT_06_TEXT02
        {
            get { return (string)this.GetValue(INPUT_06_TEXT02Property); }
            set { this.SetValue(INPUT_06_TEXT02Property, value); }
        }



        /// <summary>
        /// INPUT_01_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_01_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_01_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_01_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_01_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_01_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_01_TEXTVisibleProperty, value); }
        }



        /// <summary>
        /// INPUT_02_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_02_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_02_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_02_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_02_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_02_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_02_TEXTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_03_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_03_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_03_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_03_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_03_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_03_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_03_TEXTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_04_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_04_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_04_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_04_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_04_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_04_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_04_TEXTVisibleProperty, value); }
        }



        /// <summary>
        /// INPUT_05_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_05_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_05_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_05_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_05_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_05_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_05_TEXTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_06_TEXTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_06_TEXTVisibleProperty =
            DependencyProperty.Register("INPUT_06_TEXTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_06_TEXTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_06_TEXTVisible
        {
            get { return (bool)this.GetValue(INPUT_06_TEXTVisibleProperty); }
            set { this.SetValue(INPUT_06_TEXTVisibleProperty, value); }
        }


        /// <summary>
        /// ///////
        /// </summary>



        /// <summary>
        /// INPUT_01_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_01_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_01_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_01_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_01_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_01_NOTVisibleProperty); }
            set { this.SetValue(INPUT_01_NOTVisibleProperty, value); }
        }



        /// <summary>
        /// INPUT_02_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_02_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_02_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_02_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_02_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_02_NOTVisibleProperty); }
            set { this.SetValue(INPUT_02_NOTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_03_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_03_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_03_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_03_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_03_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_03_NOTVisibleProperty); }
            set { this.SetValue(INPUT_03_NOTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_04_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_04_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_04_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_04_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_04_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_04_NOTVisibleProperty); }
            set { this.SetValue(INPUT_04_NOTVisibleProperty, value); }
        }



        /// <summary>
        /// INPUT_05_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_05_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_05_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_05_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_05_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_05_NOTVisibleProperty); }
            set { this.SetValue(INPUT_05_NOTVisibleProperty, value); }
        }




        /// <summary>
        /// INPUT_06_NOTVisible Property
        /// </summary>
        public static readonly DependencyProperty INPUT_06_NOTVisibleProperty =
            DependencyProperty.Register("INPUT_06_NOTVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the INPUT_06_NOTVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool INPUT_06_NOTVisible
        {
            get { return (bool)this.GetValue(INPUT_06_NOTVisibleProperty); }
            set { this.SetValue(INPUT_06_NOTVisibleProperty, value); }
        }




        /// <summary>
        /// OUTPUTArrowVisible Property
        /// </summary>
        public static readonly DependencyProperty OUTPUTArrowVisibleProperty =
            DependencyProperty.Register("OUTPUTArrowVisible", typeof(bool), typeof(Button));

        /// <summary>
        /// Gets or sets the OUTPUTArrowVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool OUTPUTArrowVisible
        {
            get { return (bool)this.GetValue(OUTPUTArrowVisibleProperty); }
            set { this.SetValue(OUTPUTArrowVisibleProperty, value); }
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

                if (!string.IsNullOrWhiteSpace(this.BLKName)) yield return new Param("$BLKName", this.BLKName);
                if(!string.IsNullOrWhiteSpace(this.BLKText)) yield return new Param("$BLKText", this.BLKText);
                


            }
        }




    }
}
