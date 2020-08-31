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
	[Export("SECURITY_NAMES")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SECURITY_NAMES
    {
        public SECURITY_NAMES()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SECURITY_NAMES));

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
        /// PbMom_021_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_021_NameStoreProperty =
            DependencyProperty.Register("PbMom_021_NameStore", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_021_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_021_NameStore
        {
            get { return (string)this.GetValue(PbMom_021_NameStoreProperty); }
            set { this.SetValue(PbMom_021_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_021_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_021_WinNameProperty =
            DependencyProperty.Register("PbMom_021_WinName", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_021_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_021_WinName
        {
            get { return (string)this.GetValue(PbMom_021_WinNameProperty); }
            set { this.SetValue(PbMom_021_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_022_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_022_NameStoreProperty =
            DependencyProperty.Register("PbMom_022_NameStore", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_022_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_022_NameStore
        {
            get { return (string)this.GetValue(PbMom_022_NameStoreProperty); }
            set { this.SetValue(PbMom_022_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_022_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_022_WinNameProperty =
            DependencyProperty.Register("PbMom_022_WinName", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_022_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_022_WinName
        {
            get { return (string)this.GetValue(PbMom_022_WinNameProperty); }
            set { this.SetValue(PbMom_022_WinNameProperty, value); }
        }

        /// <summary>
        /// PbMom_023_NameStore Property
        /// </summary>
        public static readonly DependencyProperty PbMom_023_NameStoreProperty =
            DependencyProperty.Register("PbMom_023_NameStore", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_023_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string PbMom_023_NameStore
        {
            get { return (string)this.GetValue(PbMom_023_NameStoreProperty); }
            set { this.SetValue(PbMom_023_NameStoreProperty, value); }
        }

        /// <summary>
        /// PbMom_023_WinName Property
        /// </summary>
        public static readonly DependencyProperty PbMom_023_WinNameProperty =
            DependencyProperty.Register("PbMom_023_WinName", typeof(string), typeof(SECURITY_NAMES));

        /// <summary>
        /// Gets or sets the PbMom_023_WinName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"This variable links the 'NameStore' variable to the intouch window it is opening.
Use 'Intouch:zsWinOpen' for a full screen window change.
Use 'Intouch:zsWinOpenPU' for a pop window.")]
        public string PbMom_023_WinName
        {
            get { return (string)this.GetValue(PbMom_023_WinNameProperty); }
            set { this.SetValue(PbMom_023_WinNameProperty, value); }
        }


		
    }
}
