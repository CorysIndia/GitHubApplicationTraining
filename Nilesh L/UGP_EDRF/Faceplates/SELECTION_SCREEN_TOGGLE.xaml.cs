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
	[Export("SELECTION_SCREEN_TOGGLE")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SELECTION_SCREEN_TOGGLE
    {
        public SELECTION_SCREEN_TOGGLE()
        {
           this.InitializeComponent();
        }

		
        /// <summary>
        /// GraphicTagName Property
        /// </summary>
        public static readonly DependencyProperty GraphicTagNameProperty =
            DependencyProperty.Register("GraphicTagName", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

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
        /// Command Property
        /// </summary>
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

        /// <summary>
        /// Gets or sets the Command.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Command
        {
            get { return (string)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        /// <summary>
        /// CMD Property
        /// </summary>
        public static readonly DependencyProperty CMDProperty =
            DependencyProperty.Register("CMD", typeof(bool), typeof(SELECTION_SCREEN_TOGGLE));

        /// <summary>
        /// Gets or sets the CMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool CMD
        {
            get { return (bool)this.GetValue(CMDProperty); }
            set { this.SetValue(CMDProperty, value); }
        }

        /// <summary>
        /// Feedback Property
        /// </summary>
        public static readonly DependencyProperty FeedbackProperty =
            DependencyProperty.Register("Feedback", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

        /// <summary>
        /// Gets or sets the Feedback.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Feedback
        {
            get { return (string)this.GetValue(FeedbackProperty); }
            set { this.SetValue(FeedbackProperty, value); }
        }

        /// <summary>
        /// FBK Property
        /// </summary>
        public static readonly DependencyProperty FBKProperty =
            DependencyProperty.Register("FBK", typeof(bool), typeof(SELECTION_SCREEN_TOGGLE));

        /// <summary>
        /// Gets or sets the FBK.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool FBK
        {
            get { return (bool)this.GetValue(FBKProperty); }
            set { this.SetValue(FBKProperty, value); }
        }

        /// <summary>
        /// QuickLinkButton1_NameStore Property
        /// </summary>
        public static readonly DependencyProperty QuickLinkButton1_NameStoreProperty =
            DependencyProperty.Register("QuickLinkButton1_NameStore", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

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
            DependencyProperty.Register("QuickLinkButton2_NameStore", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

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
            DependencyProperty.Register("QuickLinkButton3_NameStore", typeof(string), typeof(SELECTION_SCREEN_TOGGLE));

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
