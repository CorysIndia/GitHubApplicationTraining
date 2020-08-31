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
	[Export("QUIT")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class QUIT
    {
        public QUIT()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(QUIT));

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
        /// PbMom_03_M1_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_WinNameProperty =
            DependencyProperty.Register("PbMom_03_M1_WinName", typeof(string), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_03_M1_WinName
        {
            get { return (string)this.GetValue(PbMom_03_M1_WinNameProperty); }
            set { this.SetValue(PbMom_03_M1_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_NameStoreProperty =
            DependencyProperty.Register("PbMom_03_M1_NameStore", typeof(string), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_03_M1_NameStore
        {
            get { return (string)this.GetValue(PbMom_03_M1_NameStoreProperty); }
            set { this.SetValue(PbMom_03_M1_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M1_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M1_DisableProperty =
            DependencyProperty.Register("PbMom_03_M1_Disable", typeof(bool), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M1_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool PbMom_03_M1_Disable
        {
            get { return (bool)this.GetValue(PbMom_03_M1_DisableProperty); }
            set { this.SetValue(PbMom_03_M1_DisableProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_WinNameProperty =
            DependencyProperty.Register("PbMom_03_M2_WinName", typeof(string), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_03_M2_WinName
        {
            get { return (string)this.GetValue(PbMom_03_M2_WinNameProperty); }
            set { this.SetValue(PbMom_03_M2_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_NameStoreProperty =
            DependencyProperty.Register("PbMom_03_M2_NameStore", typeof(string), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_03_M2_NameStore
        {
            get { return (string)this.GetValue(PbMom_03_M2_NameStoreProperty); }
            set { this.SetValue(PbMom_03_M2_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_03_M2_Disable Property
        /// </summary>
        public static readonly DependencyProperty PbMom_03_M2_DisableProperty =
            DependencyProperty.Register("PbMom_03_M2_Disable", typeof(bool), typeof(QUIT));

        /// <summary>
        /// Gets or sets the PbMom_03_M2_Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert a tagname or a value of 'true' when this button does not need to open the window specified in NameStore.")]
        public bool PbMom_03_M2_Disable
        {
            get { return (bool)this.GetValue(PbMom_03_M2_DisableProperty); }
            set { this.SetValue(PbMom_03_M2_DisableProperty, value); }
        }


		
    }
}
