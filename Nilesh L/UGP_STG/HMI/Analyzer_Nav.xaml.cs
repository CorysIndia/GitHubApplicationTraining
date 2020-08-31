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
    public class Analyzer_Nav : RSIControlModel
    {
        static Analyzer_Nav()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Analyzer_Nav), new FrameworkPropertyMetadata(typeof(Analyzer_Nav)));
        }

		public Analyzer_Nav()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Analyzer_Nav));

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
        /// Display_Name Property
        /// </summary>
        public static readonly DependencyProperty Display_NameProperty =
            DependencyProperty.Register("Display_Name", typeof(string), typeof(Analyzer_Nav));

        /// <summary>
        /// Gets or sets the Display_Name.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Display_Name
        {
            get { return (string)this.GetValue(Display_NameProperty); }
            set { this.SetValue(Display_NameProperty, value); }
        }

        /// <summary>
        /// TagName Property
        /// </summary>
        public new static readonly DependencyProperty TagNameProperty =
            DependencyProperty.Register("TagName", typeof(string), typeof(Analyzer_Nav));

        /// <summary>
        /// Gets or sets the TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public new string TagName
        {
            get { return (string)this.GetValue(TagNameProperty); }
            set { this.SetValue(TagNameProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Display_Name)) yield return new Param("$Display_Name", this.Display_Name);
if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);

            }
        }

		
    }
}
