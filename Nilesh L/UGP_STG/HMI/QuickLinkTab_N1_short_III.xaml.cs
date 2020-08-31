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
    public class QuickLinkTab_N1_short_III : RSIControlModel
    {
        static QuickLinkTab_N1_short_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(QuickLinkTab_N1_short_III), new FrameworkPropertyMetadata(typeof(QuickLinkTab_N1_short_III)));
        }

		public QuickLinkTab_N1_short_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(QuickLinkTab_N1_short_III));

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
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(QuickLinkTab_N1_short_III));

        /// <summary>
        /// Gets or sets the Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Indicates the tab is selected.")]
        public bool Selected
        {
            get { return (bool)this.GetValue(SelectedProperty); }
            set { this.SetValue(SelectedProperty, value); }
        }

        /// <summary>
        /// TabName Property
        /// </summary>
        public static readonly DependencyProperty TabNameProperty =
            DependencyProperty.Register("TabName", typeof(string), typeof(QuickLinkTab_N1_short_III));

        /// <summary>
        /// Gets or sets the TabName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Returns the name on the tab.")]
        public string TabName
        {
            get { return (string)this.GetValue(TabNameProperty); }
            set { this.SetValue(TabNameProperty, value); }
        }

        /// <summary>
        /// TabVisible Property
        /// </summary>
        public static readonly DependencyProperty TabVisibleProperty =
            DependencyProperty.Register("TabVisible", typeof(bool), typeof(QuickLinkTab_N1_short_III));

        /// <summary>
        /// Gets or sets the TabVisible.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool TabVisible
        {
            get { return (bool)this.GetValue(TabVisibleProperty); }
            set { this.SetValue(TabVisibleProperty, value); }
        }

        /// <summary>
        /// NameStore Property
        /// </summary>
        public static readonly DependencyProperty NameStoreProperty =
            DependencyProperty.Register("NameStore", typeof(string), typeof(QuickLinkTab_N1_short_III));

        /// <summary>
        /// Gets or sets the NameStore.  
        /// </summary>
		[Category("RSI")]
        [Description(@"'Main Menu'")]
        public string NameStore
        {
            get { return (string)this.GetValue(NameStoreProperty); }
            set { this.SetValue(NameStoreProperty, value); }
        }

        /// <summary>
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(QuickLinkTab_N1_short_III));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"When Alarm ==0, tab is dark red/red
When Alarm ==1, tab is dark grey/grey")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.TabName)) yield return new Param("$TabName", this.TabName);
if (!string.IsNullOrWhiteSpace(this.NameStore)) yield return new Param("$NameStore", this.NameStore);

            }
        }

		
    }
}
