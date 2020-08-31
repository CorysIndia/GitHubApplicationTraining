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
    public class dIndDesLab_03 : RSIControlModel
    {
        static dIndDesLab_03()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(dIndDesLab_03), new FrameworkPropertyMetadata(typeof(dIndDesLab_03)));
        }

		public dIndDesLab_03()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(dIndDesLab_03));

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
        /// COLD Property
        /// </summary>
        public static readonly DependencyProperty COLDProperty =
            DependencyProperty.Register("COLD", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the COLD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the tagname here to display its true/false status")]
        public bool COLD
        {
            get { return (bool)this.GetValue(COLDProperty); }
            set { this.SetValue(COLDProperty, value); }
        }

        /// <summary>
        /// Blink Property
        /// </summary>
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the Blink.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True=Blinking ")]
        public bool Blink
        {
            get { return (bool)this.GetValue(BlinkProperty); }
            set { this.SetValue(BlinkProperty, value); }
        }

        /// <summary>
        /// TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty TagDescrpProperty =
            DependencyProperty.Register("TagDescrp", typeof(string), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string TagDescrp
        {
            get { return (string)this.GetValue(TagDescrpProperty); }
            set { this.SetValue(TagDescrpProperty, value); }
        }

        /// <summary>
        /// TagName Property
        /// </summary>
        public new static readonly DependencyProperty TagNameProperty =
            DependencyProperty.Register("TagName", typeof(string), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public new string TagName
        {
            get { return (string)this.GetValue(TagNameProperty); }
            set { this.SetValue(TagNameProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// WARM Property
        /// </summary>
        public static readonly DependencyProperty WARMProperty =
            DependencyProperty.Register("WARM", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the WARM.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool WARM
        {
            get { return (bool)this.GetValue(WARMProperty); }
            set { this.SetValue(WARMProperty, value); }
        }

        /// <summary>
        /// HOT Property
        /// </summary>
        public static readonly DependencyProperty HOTProperty =
            DependencyProperty.Register("HOT", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the HOT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool HOT
        {
            get { return (bool)this.GetValue(HOTProperty); }
            set { this.SetValue(HOTProperty, value); }
        }

        /// <summary>
        /// VHOT Property
        /// </summary>
        public static readonly DependencyProperty VHOTProperty =
            DependencyProperty.Register("VHOT", typeof(bool), typeof(dIndDesLab_03));

        /// <summary>
        /// Gets or sets the VHOT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public bool VHOT
        {
            get { return (bool)this.GetValue(VHOTProperty); }
            set { this.SetValue(VHOTProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.TagDescrp)) yield return new Param("$TagDescrp", this.TagDescrp);
if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);

            }
        }

		
    }
}
