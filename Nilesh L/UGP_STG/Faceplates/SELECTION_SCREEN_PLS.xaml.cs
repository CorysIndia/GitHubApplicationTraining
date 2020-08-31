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
	[Export("SELECTION_SCREEN_PLS")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SELECTION_SCREEN_PLS
    {
        public SELECTION_SCREEN_PLS()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SELECTION_SCREEN_PLS));

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
        /// Command_Left Property
        /// </summary>
        public static readonly DependencyProperty Command_LeftProperty =
            DependencyProperty.Register("Command_Left", typeof(string), typeof(SELECTION_SCREEN_PLS));

        /// <summary>
        /// Gets or sets the Command_Left.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Command_Left
        {
            get { return (string)this.GetValue(Command_LeftProperty); }
            set { this.SetValue(Command_LeftProperty, value); }
        }

        /// <summary>
        /// Command_Right Property
        /// </summary>
        public static readonly DependencyProperty Command_RightProperty =
            DependencyProperty.Register("Command_Right", typeof(string), typeof(SELECTION_SCREEN_PLS));

        /// <summary>
        /// Gets or sets the Command_Right.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Command_Right
        {
            get { return (string)this.GetValue(Command_RightProperty); }
            set { this.SetValue(Command_RightProperty, value); }
        }

        /// <summary>
        /// QuickLinkButton1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty QuickLinkButton1_NameStoreProperty =
            DependencyProperty.Register("QuickLinkButton1_NameStore", typeof(string), typeof(SELECTION_SCREEN_PLS));

        /// <summary>
        /// Gets or sets the QuickLinkButton1_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string QuickLinkButton1_NameStore
        {
            get { return (string)this.GetValue(QuickLinkButton1_NameStoreProperty); }
            set { this.SetValue(QuickLinkButton1_NameStoreProperty, value); }
        }

        /// <summary>
        /// QuickLinkButton2_NameStore Property
        /// </summary>
        public static readonly DependencyProperty QuickLinkButton2_NameStoreProperty =
            DependencyProperty.Register("QuickLinkButton2_NameStore", typeof(string), typeof(SELECTION_SCREEN_PLS));

        /// <summary>
        /// Gets or sets the QuickLinkButton2_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string QuickLinkButton2_NameStore
        {
            get { return (string)this.GetValue(QuickLinkButton2_NameStoreProperty); }
            set { this.SetValue(QuickLinkButton2_NameStoreProperty, value); }
        }

        /// <summary>
        /// QuickLinkButton3_NameStore Property
        /// </summary>
        public static readonly DependencyProperty QuickLinkButton3_NameStoreProperty =
            DependencyProperty.Register("QuickLinkButton3_NameStore", typeof(string), typeof(SELECTION_SCREEN_PLS));

        /// <summary>
        /// Gets or sets the QuickLinkButton3_NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"The temporary variable to store the Intouch window name.")]
        public string QuickLinkButton3_NameStore
        {
            get { return (string)this.GetValue(QuickLinkButton3_NameStoreProperty); }
            set { this.SetValue(QuickLinkButton3_NameStoreProperty, value); }
        }


		
    }
}
