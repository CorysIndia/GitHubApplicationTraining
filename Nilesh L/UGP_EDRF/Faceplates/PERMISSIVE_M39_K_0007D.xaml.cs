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
	[Export("PERMISSIVE_M39_K_0007D")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PERMISSIVE_M39_K_0007D
    {
        public PERMISSIVE_M39_K_0007D()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

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
        /// fIND_D_01_S1_M_III1_Value Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III1_ValueProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III1_Value", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III1_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool fIND_D_01_S1_M_III1_Value
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III1_ValueProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III1_ValueProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III1_TagName Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III1_TagNameProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III1_TagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III1_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III1_TagName
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III1_TagNameProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III1_TagNameProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III1_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III1_TagDescrpProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III1_TagDescrp", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III1_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III1_TagDescrp
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III1_TagDescrpProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III1_TagDescrpProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III1_Blink Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III1_BlinkProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III1_Blink", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III1_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool fIND_D_01_S1_M_III1_Blink
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III1_BlinkProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III1_BlinkProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III1_Disable Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III1_DisableProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III1_Disable", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool fIND_D_01_S1_M_III1_Disable
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III1_DisableProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III1_DisableProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III2_Value Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III2_ValueProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III2_Value", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III2_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool fIND_D_01_S1_M_III2_Value
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III2_ValueProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III2_ValueProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III2_TagName Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III2_TagNameProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III2_TagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III2_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III2_TagName
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III2_TagNameProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III2_TagNameProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III2_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III2_TagDescrpProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III2_TagDescrp", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III2_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III2_TagDescrp
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III2_TagDescrpProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III2_TagDescrpProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III2_Blink Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III2_BlinkProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III2_Blink", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III2_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool fIND_D_01_S1_M_III2_Blink
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III2_BlinkProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III2_BlinkProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III2_Disable Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III2_DisableProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III2_Disable", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III2_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool fIND_D_01_S1_M_III2_Disable
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III2_DisableProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III2_DisableProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III3_Value Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III3_ValueProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III3_Value", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III3_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool fIND_D_01_S1_M_III3_Value
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III3_ValueProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III3_ValueProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III3_TagName Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III3_TagNameProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III3_TagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III3_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III3_TagName
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III3_TagNameProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III3_TagNameProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III3_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III3_TagDescrpProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III3_TagDescrp", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III3_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III3_TagDescrp
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III3_TagDescrpProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III3_TagDescrpProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III3_Blink Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III3_BlinkProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III3_Blink", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III3_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool fIND_D_01_S1_M_III3_Blink
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III3_BlinkProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III3_BlinkProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III3_Disable Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III3_DisableProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III3_Disable", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III3_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool fIND_D_01_S1_M_III3_Disable
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III3_DisableProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III3_DisableProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III4_Value Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III4_ValueProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III4_Value", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III4_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool fIND_D_01_S1_M_III4_Value
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III4_ValueProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III4_ValueProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III4_TagName Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III4_TagNameProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III4_TagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III4_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III4_TagName
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III4_TagNameProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III4_TagNameProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III4_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III4_TagDescrpProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III4_TagDescrp", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III4_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III4_TagDescrp
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III4_TagDescrpProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III4_TagDescrpProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III4_Blink Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III4_BlinkProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III4_Blink", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III4_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool fIND_D_01_S1_M_III4_Blink
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III4_BlinkProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III4_BlinkProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III4_Disable Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III4_DisableProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III4_Disable", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III4_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool fIND_D_01_S1_M_III4_Disable
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III4_DisableProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III4_DisableProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III5_Value Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III5_ValueProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III5_Value", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III5_Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool fIND_D_01_S1_M_III5_Value
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III5_ValueProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III5_ValueProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III5_TagName Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III5_TagNameProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III5_TagName", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III5_TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III5_TagName
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III5_TagNameProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III5_TagNameProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III5_TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III5_TagDescrpProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III5_TagDescrp", typeof(string), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III5_TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string fIND_D_01_S1_M_III5_TagDescrp
        {
            get { return (string)this.GetValue(fIND_D_01_S1_M_III5_TagDescrpProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III5_TagDescrpProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III5_Blink Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III5_BlinkProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III5_Blink", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III5_Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool fIND_D_01_S1_M_III5_Blink
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III5_BlinkProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III5_BlinkProperty, value); }
        }

        /// <summary>
        /// fIND_D_01_S1_M_III5_Disable Property
        /// </summary>
        public static readonly DependencyProperty fIND_D_01_S1_M_III5_DisableProperty =
            DependencyProperty.Register("fIND_D_01_S1_M_III5_Disable", typeof(bool), typeof(PERMISSIVE_M39_K_0007D));

        /// <summary>
        /// Gets or sets the fIND_D_01_S1_M_III5_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here

True: disable Description/TagName update function in HMI
False:  disable Description/TagName update function in HMI")]
        public bool fIND_D_01_S1_M_III5_Disable
        {
            get { return (bool)this.GetValue(fIND_D_01_S1_M_III5_DisableProperty); }
            set { this.SetValue(fIND_D_01_S1_M_III5_DisableProperty, value); }
        }


		
    }
}
