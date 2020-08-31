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
    public class SILICA_SELECT : RSIControlModel
    {
        static SILICA_SELECT()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SILICA_SELECT), new FrameworkPropertyMetadata(typeof(SILICA_SELECT)));
        }

		public SILICA_SELECT()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SILICA_SELECT));

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
        /// CMP Property
        /// </summary>
        public static readonly DependencyProperty CMPProperty =
            DependencyProperty.Register("CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string CMP
        {
            get { return (string)this.GetValue(CMPProperty); }
            set { this.SetValue(CMPProperty, value); }
        }

        /// <summary>
        /// BLK Property
        /// </summary>
        public static readonly DependencyProperty BLKProperty =
            DependencyProperty.Register("BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK
        {
            get { return (string)this.GetValue(BLKProperty); }
            set { this.SetValue(BLKProperty, value); }
        }

        /// <summary>
        /// SELECTED Property
        /// </summary>
        public static readonly DependencyProperty SELECTEDProperty =
            DependencyProperty.Register("SELECTED", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the SELECTED.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SELECTED
        {
            get { return (int)this.GetValue(SELECTEDProperty); }
            set { this.SetValue(SELECTEDProperty, value); }
        }

        /// <summary>
        /// BLK_3 Property
        /// </summary>
        public static readonly DependencyProperty BLK_3Property =
            DependencyProperty.Register("BLK_3", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the BLK_3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_3
        {
            get { return (string)this.GetValue(BLK_3Property); }
            set { this.SetValue(BLK_3Property, value); }
        }

        /// <summary>
        /// BLK_4 Property
        /// </summary>
        public static readonly DependencyProperty BLK_4Property =
            DependencyProperty.Register("BLK_4", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the BLK_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string BLK_4
        {
            get { return (string)this.GetValue(BLK_4Property); }
            set { this.SetValue(BLK_4Property, value); }
        }

        /// <summary>
        /// CASE_3 Property
        /// </summary>
        public static readonly DependencyProperty CASE_3Property =
            DependencyProperty.Register("CASE_3", typeof(bool), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the CASE_3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CASE_3
        {
            get { return (bool)this.GetValue(CASE_3Property); }
            set { this.SetValue(CASE_3Property, value); }
        }

        /// <summary>
        /// CASE_4 Property
        /// </summary>
        public static readonly DependencyProperty CASE_4Property =
            DependencyProperty.Register("CASE_4", typeof(bool), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the CASE_4.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CASE_4
        {
            get { return (bool)this.GetValue(CASE_4Property); }
            set { this.SetValue(CASE_4Property, value); }
        }

        /// <summary>
        /// SELECTED_FB Property
        /// </summary>
        public static readonly DependencyProperty SELECTED_FBProperty =
            DependencyProperty.Register("SELECTED_FB", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the SELECTED_FB.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int SELECTED_FB
        {
            get { return (int)this.GetValue(SELECTED_FBProperty); }
            set { this.SetValue(SELECTED_FBProperty, value); }
        }

        /// <summary>
        /// A Property
        /// </summary>
        public static readonly DependencyProperty AProperty =
            DependencyProperty.Register("A", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the A.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int A
        {
            get { return (int)this.GetValue(AProperty); }
            set { this.SetValue(AProperty, value); }
        }

        /// <summary>
        /// B Property
        /// </summary>
        public static readonly DependencyProperty BProperty =
            DependencyProperty.Register("B", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the B.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int B
        {
            get { return (int)this.GetValue(BProperty); }
            set { this.SetValue(BProperty, value); }
        }

        /// <summary>
        /// C Property
        /// </summary>
        public static readonly DependencyProperty CProperty =
            DependencyProperty.Register("C", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the C.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int C
        {
            get { return (int)this.GetValue(CProperty); }
            set { this.SetValue(CProperty, value); }
        }

        /// <summary>
        /// D Property
        /// </summary>
        public static readonly DependencyProperty DProperty =
            DependencyProperty.Register("D", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the D.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int D
        {
            get { return (int)this.GetValue(DProperty); }
            set { this.SetValue(DProperty, value); }
        }

        /// <summary>
        /// E Property
        /// </summary>
        public static readonly DependencyProperty EProperty =
            DependencyProperty.Register("E", typeof(int), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the E.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int E
        {
            get { return (int)this.GetValue(EProperty); }
            set { this.SetValue(EProperty, value); }
        }

        /// <summary>
        /// TRIG Property
        /// </summary>
        public static readonly DependencyProperty TRIGProperty =
            DependencyProperty.Register("TRIG", typeof(bool), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the TRIG.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TRIG
        {
            get { return (bool)this.GetValue(TRIGProperty); }
            set { this.SetValue(TRIGProperty, value); }
        }

        /// <summary>
        /// Select_E_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_E_BLKProperty =
            DependencyProperty.Register("Select_E_BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_E_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_E_BLK
        {
            get { return (string)this.GetValue(Select_E_BLKProperty); }
            set { this.SetValue(Select_E_BLKProperty, value); }
        }

        /// <summary>
        /// Select_E_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_E_CMPProperty =
            DependencyProperty.Register("Select_E_CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_E_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_E_CMP
        {
            get { return (string)this.GetValue(Select_E_CMPProperty); }
            set { this.SetValue(Select_E_CMPProperty, value); }
        }

        /// <summary>
        /// Select_E_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_E_PARProperty =
            DependencyProperty.Register("Select_E_PAR", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_E_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_E_PAR
        {
            get { return (string)this.GetValue(Select_E_PARProperty); }
            set { this.SetValue(Select_E_PARProperty, value); }
        }

        /// <summary>
        /// Select_E_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_E_PRTProperty =
            DependencyProperty.Register("Select_E_PRT", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_E_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_E_PRT
        {
            get { return (string)this.GetValue(Select_E_PRTProperty); }
            set { this.SetValue(Select_E_PRTProperty, value); }
        }

        /// <summary>
        /// Select_D_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_D_BLKProperty =
            DependencyProperty.Register("Select_D_BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_D_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_D_BLK
        {
            get { return (string)this.GetValue(Select_D_BLKProperty); }
            set { this.SetValue(Select_D_BLKProperty, value); }
        }

        /// <summary>
        /// Select_D_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_D_CMPProperty =
            DependencyProperty.Register("Select_D_CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_D_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_D_CMP
        {
            get { return (string)this.GetValue(Select_D_CMPProperty); }
            set { this.SetValue(Select_D_CMPProperty, value); }
        }

        /// <summary>
        /// Select_D_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_D_PARProperty =
            DependencyProperty.Register("Select_D_PAR", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_D_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_D_PAR
        {
            get { return (string)this.GetValue(Select_D_PARProperty); }
            set { this.SetValue(Select_D_PARProperty, value); }
        }

        /// <summary>
        /// Select_D_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_D_PRTProperty =
            DependencyProperty.Register("Select_D_PRT", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_D_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_D_PRT
        {
            get { return (string)this.GetValue(Select_D_PRTProperty); }
            set { this.SetValue(Select_D_PRTProperty, value); }
        }

        /// <summary>
        /// Select_C_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_C_BLKProperty =
            DependencyProperty.Register("Select_C_BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_C_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_C_BLK
        {
            get { return (string)this.GetValue(Select_C_BLKProperty); }
            set { this.SetValue(Select_C_BLKProperty, value); }
        }

        /// <summary>
        /// Select_C_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_C_CMPProperty =
            DependencyProperty.Register("Select_C_CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_C_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_C_CMP
        {
            get { return (string)this.GetValue(Select_C_CMPProperty); }
            set { this.SetValue(Select_C_CMPProperty, value); }
        }

        /// <summary>
        /// Select_C_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_C_PARProperty =
            DependencyProperty.Register("Select_C_PAR", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_C_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_C_PAR
        {
            get { return (string)this.GetValue(Select_C_PARProperty); }
            set { this.SetValue(Select_C_PARProperty, value); }
        }

        /// <summary>
        /// Select_C_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_C_PRTProperty =
            DependencyProperty.Register("Select_C_PRT", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_C_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_C_PRT
        {
            get { return (string)this.GetValue(Select_C_PRTProperty); }
            set { this.SetValue(Select_C_PRTProperty, value); }
        }

        /// <summary>
        /// Select_B_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_B_BLKProperty =
            DependencyProperty.Register("Select_B_BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_B_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_B_BLK
        {
            get { return (string)this.GetValue(Select_B_BLKProperty); }
            set { this.SetValue(Select_B_BLKProperty, value); }
        }

        /// <summary>
        /// Select_B_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_B_CMPProperty =
            DependencyProperty.Register("Select_B_CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_B_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_B_CMP
        {
            get { return (string)this.GetValue(Select_B_CMPProperty); }
            set { this.SetValue(Select_B_CMPProperty, value); }
        }

        /// <summary>
        /// Select_B_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_B_PARProperty =
            DependencyProperty.Register("Select_B_PAR", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_B_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_B_PAR
        {
            get { return (string)this.GetValue(Select_B_PARProperty); }
            set { this.SetValue(Select_B_PARProperty, value); }
        }

        /// <summary>
        /// Select_B_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_B_PRTProperty =
            DependencyProperty.Register("Select_B_PRT", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_B_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_B_PRT
        {
            get { return (string)this.GetValue(Select_B_PRTProperty); }
            set { this.SetValue(Select_B_PRTProperty, value); }
        }

        /// <summary>
        /// Select_A_BLK Property
        /// </summary>
        public static readonly DependencyProperty Select_A_BLKProperty =
            DependencyProperty.Register("Select_A_BLK", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_A_BLK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_BLK
        {
            get { return (string)this.GetValue(Select_A_BLKProperty); }
            set { this.SetValue(Select_A_BLKProperty, value); }
        }

        /// <summary>
        /// Select_A_CMP Property
        /// </summary>
        public static readonly DependencyProperty Select_A_CMPProperty =
            DependencyProperty.Register("Select_A_CMP", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_A_CMP.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_CMP
        {
            get { return (string)this.GetValue(Select_A_CMPProperty); }
            set { this.SetValue(Select_A_CMPProperty, value); }
        }

        /// <summary>
        /// Select_A_PAR Property
        /// </summary>
        public static readonly DependencyProperty Select_A_PARProperty =
            DependencyProperty.Register("Select_A_PAR", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_A_PAR.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_PAR
        {
            get { return (string)this.GetValue(Select_A_PARProperty); }
            set { this.SetValue(Select_A_PARProperty, value); }
        }

        /// <summary>
        /// Select_A_PRT Property
        /// </summary>
        public static readonly DependencyProperty Select_A_PRTProperty =
            DependencyProperty.Register("Select_A_PRT", typeof(string), typeof(SILICA_SELECT));

        /// <summary>
        /// Gets or sets the Select_A_PRT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Select_A_PRT
        {
            get { return (string)this.GetValue(Select_A_PRTProperty); }
            set { this.SetValue(Select_A_PRTProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.CMP)) yield return new Param("$CMP", this.CMP);
if (!string.IsNullOrWhiteSpace(this.BLK)) yield return new Param("$BLK", this.BLK);
if (!string.IsNullOrWhiteSpace(this.BLK_3)) yield return new Param("$BLK_3", this.BLK_3);
if (!string.IsNullOrWhiteSpace(this.BLK_4)) yield return new Param("$BLK_4", this.BLK_4);

            }
        }

		
    }
}
