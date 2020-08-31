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
    public class AclRead : RSIControlModel
    {
        static AclRead()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AclRead), new FrameworkPropertyMetadata(typeof(AclRead)));
        }

		public AclRead()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(AclRead));

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
        /// NoOfOpeators Property
        /// </summary>
        public static readonly DependencyProperty NoOfOpeatorsProperty =
            DependencyProperty.Register("NoOfOpeators", typeof(int), typeof(AclRead));

        /// <summary>
        /// Gets or sets the NoOfOpeators.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public int NoOfOpeators
        {
            get { return (int)this.GetValue(NoOfOpeatorsProperty); }
            set { this.SetValue(NoOfOpeatorsProperty, value); }
        }

        /// <summary>
        /// Op1 Property
        /// </summary>
        public static readonly DependencyProperty Op1Property =
            DependencyProperty.Register("Op1", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op1.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op1
        {
            get { return (string)this.GetValue(Op1Property); }
            set { this.SetValue(Op1Property, value); }
        }

        /// <summary>
        /// Op2 Property
        /// </summary>
        public static readonly DependencyProperty Op2Property =
            DependencyProperty.Register("Op2", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op2.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op2
        {
            get { return (string)this.GetValue(Op2Property); }
            set { this.SetValue(Op2Property, value); }
        }

        /// <summary>
        /// OpeEnv Property
        /// </summary>
        public static readonly DependencyProperty OpeEnvProperty =
            DependencyProperty.Register("OpeEnv", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the OpeEnv.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string OpeEnv
        {
            get { return (string)this.GetValue(OpeEnvProperty); }
            set { this.SetValue(OpeEnvProperty, value); }
        }

        /// <summary>
        /// Op3 Property
        /// </summary>
        public static readonly DependencyProperty Op3Property =
            DependencyProperty.Register("Op3", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op3.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op3
        {
            get { return (string)this.GetValue(Op3Property); }
            set { this.SetValue(Op3Property, value); }
        }

        /// <summary>
        /// Op5 Property
        /// </summary>
        public static readonly DependencyProperty Op5Property =
            DependencyProperty.Register("Op5", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op5.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op5
        {
            get { return (string)this.GetValue(Op5Property); }
            set { this.SetValue(Op5Property, value); }
        }

        /// <summary>
        /// Op6 Property
        /// </summary>
        public static readonly DependencyProperty Op6Property =
            DependencyProperty.Register("Op6", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op6.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op6
        {
            get { return (string)this.GetValue(Op6Property); }
            set { this.SetValue(Op6Property, value); }
        }

        /// <summary>
        /// Op7 Property
        /// </summary>
        public static readonly DependencyProperty Op7Property =
            DependencyProperty.Register("Op7", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op7.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op7
        {
            get { return (string)this.GetValue(Op7Property); }
            set { this.SetValue(Op7Property, value); }
        }

        /// <summary>
        /// Op0 Property
        /// </summary>
        public static readonly DependencyProperty Op0Property =
            DependencyProperty.Register("Op0", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op0
        {
            get { return (string)this.GetValue(Op0Property); }
            set { this.SetValue(Op0Property, value); }
        }

        /// <summary>
        /// Op8 Property
        /// </summary>
        public static readonly DependencyProperty Op8Property =
            DependencyProperty.Register("Op8", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op8.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op8
        {
            get { return (string)this.GetValue(Op8Property); }
            set { this.SetValue(Op8Property, value); }
        }

        /// <summary>
        /// Op9 Property
        /// </summary>
        public static readonly DependencyProperty Op9Property =
            DependencyProperty.Register("Op9", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op9.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op9
        {
            get { return (string)this.GetValue(Op9Property); }
            set { this.SetValue(Op9Property, value); }
        }

        /// <summary>
        /// Op10 Property
        /// </summary>
        public static readonly DependencyProperty Op10Property =
            DependencyProperty.Register("Op10", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op10.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op10
        {
            get { return (string)this.GetValue(Op10Property); }
            set { this.SetValue(Op10Property, value); }
        }

        /// <summary>
        /// Op11 Property
        /// </summary>
        public static readonly DependencyProperty Op11Property =
            DependencyProperty.Register("Op11", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op11.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op11
        {
            get { return (string)this.GetValue(Op11Property); }
            set { this.SetValue(Op11Property, value); }
        }

        /// <summary>
        /// Op12 Property
        /// </summary>
        public static readonly DependencyProperty Op12Property =
            DependencyProperty.Register("Op12", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op12.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op12
        {
            get { return (string)this.GetValue(Op12Property); }
            set { this.SetValue(Op12Property, value); }
        }

        /// <summary>
        /// Op13 Property
        /// </summary>
        public static readonly DependencyProperty Op13Property =
            DependencyProperty.Register("Op13", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op13.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op13
        {
            get { return (string)this.GetValue(Op13Property); }
            set { this.SetValue(Op13Property, value); }
        }

        /// <summary>
        /// Op14 Property
        /// </summary>
        public static readonly DependencyProperty Op14Property =
            DependencyProperty.Register("Op14", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op14.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op14
        {
            get { return (string)this.GetValue(Op14Property); }
            set { this.SetValue(Op14Property, value); }
        }

        /// <summary>
        /// Op15 Property
        /// </summary>
        public static readonly DependencyProperty Op15Property =
            DependencyProperty.Register("Op15", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op15.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op15
        {
            get { return (string)this.GetValue(Op15Property); }
            set { this.SetValue(Op15Property, value); }
        }

        /// <summary>
        /// Op16 Property
        /// </summary>
        public static readonly DependencyProperty Op16Property =
            DependencyProperty.Register("Op16", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op16.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op16
        {
            get { return (string)this.GetValue(Op16Property); }
            set { this.SetValue(Op16Property, value); }
        }

        /// <summary>
        /// Op17 Property
        /// </summary>
        public static readonly DependencyProperty Op17Property =
            DependencyProperty.Register("Op17", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op17.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op17
        {
            get { return (string)this.GetValue(Op17Property); }
            set { this.SetValue(Op17Property, value); }
        }

        /// <summary>
        /// Op18 Property
        /// </summary>
        public static readonly DependencyProperty Op18Property =
            DependencyProperty.Register("Op18", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op18.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op18
        {
            get { return (string)this.GetValue(Op18Property); }
            set { this.SetValue(Op18Property, value); }
        }

        /// <summary>
        /// Op19 Property
        /// </summary>
        public static readonly DependencyProperty Op19Property =
            DependencyProperty.Register("Op19", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op19.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op19
        {
            get { return (string)this.GetValue(Op19Property); }
            set { this.SetValue(Op19Property, value); }
        }

        /// <summary>
        /// Op20 Property
        /// </summary>
        public static readonly DependencyProperty Op20Property =
            DependencyProperty.Register("Op20", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op20.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op20
        {
            get { return (string)this.GetValue(Op20Property); }
            set { this.SetValue(Op20Property, value); }
        }

        /// <summary>
        /// Op31 Property
        /// </summary>
        public static readonly DependencyProperty Op31Property =
            DependencyProperty.Register("Op31", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op31.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op31
        {
            get { return (string)this.GetValue(Op31Property); }
            set { this.SetValue(Op31Property, value); }
        }

        /// <summary>
        /// Op32 Property
        /// </summary>
        public static readonly DependencyProperty Op32Property =
            DependencyProperty.Register("Op32", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op32.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op32
        {
            get { return (string)this.GetValue(Op32Property); }
            set { this.SetValue(Op32Property, value); }
        }

        /// <summary>
        /// Op33 Property
        /// </summary>
        public static readonly DependencyProperty Op33Property =
            DependencyProperty.Register("Op33", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op33.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op33
        {
            get { return (string)this.GetValue(Op33Property); }
            set { this.SetValue(Op33Property, value); }
        }

        /// <summary>
        /// Op34 Property
        /// </summary>
        public static readonly DependencyProperty Op34Property =
            DependencyProperty.Register("Op34", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op34.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op34
        {
            get { return (string)this.GetValue(Op34Property); }
            set { this.SetValue(Op34Property, value); }
        }

        /// <summary>
        /// Op35 Property
        /// </summary>
        public static readonly DependencyProperty Op35Property =
            DependencyProperty.Register("Op35", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op35.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op35
        {
            get { return (string)this.GetValue(Op35Property); }
            set { this.SetValue(Op35Property, value); }
        }

        /// <summary>
        /// Op36 Property
        /// </summary>
        public static readonly DependencyProperty Op36Property =
            DependencyProperty.Register("Op36", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op36.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op36
        {
            get { return (string)this.GetValue(Op36Property); }
            set { this.SetValue(Op36Property, value); }
        }

        /// <summary>
        /// Op37 Property
        /// </summary>
        public static readonly DependencyProperty Op37Property =
            DependencyProperty.Register("Op37", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op37.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op37
        {
            get { return (string)this.GetValue(Op37Property); }
            set { this.SetValue(Op37Property, value); }
        }

        /// <summary>
        /// Op38 Property
        /// </summary>
        public static readonly DependencyProperty Op38Property =
            DependencyProperty.Register("Op38", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op38.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op38
        {
            get { return (string)this.GetValue(Op38Property); }
            set { this.SetValue(Op38Property, value); }
        }

        /// <summary>
        /// Op39 Property
        /// </summary>
        public static readonly DependencyProperty Op39Property =
            DependencyProperty.Register("Op39", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op39.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op39
        {
            get { return (string)this.GetValue(Op39Property); }
            set { this.SetValue(Op39Property, value); }
        }

        /// <summary>
        /// Op40 Property
        /// </summary>
        public static readonly DependencyProperty Op40Property =
            DependencyProperty.Register("Op40", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op40.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op40
        {
            get { return (string)this.GetValue(Op40Property); }
            set { this.SetValue(Op40Property, value); }
        }

        /// <summary>
        /// Op41 Property
        /// </summary>
        public static readonly DependencyProperty Op41Property =
            DependencyProperty.Register("Op41", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op41.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op41
        {
            get { return (string)this.GetValue(Op41Property); }
            set { this.SetValue(Op41Property, value); }
        }

        /// <summary>
        /// Op42 Property
        /// </summary>
        public static readonly DependencyProperty Op42Property =
            DependencyProperty.Register("Op42", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op42.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op42
        {
            get { return (string)this.GetValue(Op42Property); }
            set { this.SetValue(Op42Property, value); }
        }

        /// <summary>
        /// Op43 Property
        /// </summary>
        public static readonly DependencyProperty Op43Property =
            DependencyProperty.Register("Op43", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op43.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op43
        {
            get { return (string)this.GetValue(Op43Property); }
            set { this.SetValue(Op43Property, value); }
        }

        /// <summary>
        /// Op44 Property
        /// </summary>
        public static readonly DependencyProperty Op44Property =
            DependencyProperty.Register("Op44", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op44.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op44
        {
            get { return (string)this.GetValue(Op44Property); }
            set { this.SetValue(Op44Property, value); }
        }

        /// <summary>
        /// Op45 Property
        /// </summary>
        public static readonly DependencyProperty Op45Property =
            DependencyProperty.Register("Op45", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op45.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op45
        {
            get { return (string)this.GetValue(Op45Property); }
            set { this.SetValue(Op45Property, value); }
        }

        /// <summary>
        /// Op46 Property
        /// </summary>
        public static readonly DependencyProperty Op46Property =
            DependencyProperty.Register("Op46", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op46.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op46
        {
            get { return (string)this.GetValue(Op46Property); }
            set { this.SetValue(Op46Property, value); }
        }

        /// <summary>
        /// Op47 Property
        /// </summary>
        public static readonly DependencyProperty Op47Property =
            DependencyProperty.Register("Op47", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op47.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op47
        {
            get { return (string)this.GetValue(Op47Property); }
            set { this.SetValue(Op47Property, value); }
        }

        /// <summary>
        /// Op48 Property
        /// </summary>
        public static readonly DependencyProperty Op48Property =
            DependencyProperty.Register("Op48", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op48.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op48
        {
            get { return (string)this.GetValue(Op48Property); }
            set { this.SetValue(Op48Property, value); }
        }

        /// <summary>
        /// Op49 Property
        /// </summary>
        public static readonly DependencyProperty Op49Property =
            DependencyProperty.Register("Op49", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op49.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op49
        {
            get { return (string)this.GetValue(Op49Property); }
            set { this.SetValue(Op49Property, value); }
        }

        /// <summary>
        /// Op50 Property
        /// </summary>
        public static readonly DependencyProperty Op50Property =
            DependencyProperty.Register("Op50", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op50.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op50
        {
            get { return (string)this.GetValue(Op50Property); }
            set { this.SetValue(Op50Property, value); }
        }

        /// <summary>
        /// Op51 Property
        /// </summary>
        public static readonly DependencyProperty Op51Property =
            DependencyProperty.Register("Op51", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op51.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op51
        {
            get { return (string)this.GetValue(Op51Property); }
            set { this.SetValue(Op51Property, value); }
        }

        /// <summary>
        /// Op52 Property
        /// </summary>
        public static readonly DependencyProperty Op52Property =
            DependencyProperty.Register("Op52", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op52.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op52
        {
            get { return (string)this.GetValue(Op52Property); }
            set { this.SetValue(Op52Property, value); }
        }

        /// <summary>
        /// Op53 Property
        /// </summary>
        public static readonly DependencyProperty Op53Property =
            DependencyProperty.Register("Op53", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op53.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op53
        {
            get { return (string)this.GetValue(Op53Property); }
            set { this.SetValue(Op53Property, value); }
        }

        /// <summary>
        /// Op54 Property
        /// </summary>
        public static readonly DependencyProperty Op54Property =
            DependencyProperty.Register("Op54", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op54.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op54
        {
            get { return (string)this.GetValue(Op54Property); }
            set { this.SetValue(Op54Property, value); }
        }

        /// <summary>
        /// Op55 Property
        /// </summary>
        public static readonly DependencyProperty Op55Property =
            DependencyProperty.Register("Op55", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op55.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op55
        {
            get { return (string)this.GetValue(Op55Property); }
            set { this.SetValue(Op55Property, value); }
        }

        /// <summary>
        /// Op56 Property
        /// </summary>
        public static readonly DependencyProperty Op56Property =
            DependencyProperty.Register("Op56", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op56.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op56
        {
            get { return (string)this.GetValue(Op56Property); }
            set { this.SetValue(Op56Property, value); }
        }

        /// <summary>
        /// Op57 Property
        /// </summary>
        public static readonly DependencyProperty Op57Property =
            DependencyProperty.Register("Op57", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op57.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op57
        {
            get { return (string)this.GetValue(Op57Property); }
            set { this.SetValue(Op57Property, value); }
        }

        /// <summary>
        /// Op58 Property
        /// </summary>
        public static readonly DependencyProperty Op58Property =
            DependencyProperty.Register("Op58", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op58.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op58
        {
            get { return (string)this.GetValue(Op58Property); }
            set { this.SetValue(Op58Property, value); }
        }

        /// <summary>
        /// Op59 Property
        /// </summary>
        public static readonly DependencyProperty Op59Property =
            DependencyProperty.Register("Op59", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op59.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op59
        {
            get { return (string)this.GetValue(Op59Property); }
            set { this.SetValue(Op59Property, value); }
        }

        /// <summary>
        /// Op60 Property
        /// </summary>
        public static readonly DependencyProperty Op60Property =
            DependencyProperty.Register("Op60", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op60.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op60
        {
            get { return (string)this.GetValue(Op60Property); }
            set { this.SetValue(Op60Property, value); }
        }

        /// <summary>
        /// Op61 Property
        /// </summary>
        public static readonly DependencyProperty Op61Property =
            DependencyProperty.Register("Op61", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op61.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op61
        {
            get { return (string)this.GetValue(Op61Property); }
            set { this.SetValue(Op61Property, value); }
        }

        /// <summary>
        /// Op62 Property
        /// </summary>
        public static readonly DependencyProperty Op62Property =
            DependencyProperty.Register("Op62", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op62.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op62
        {
            get { return (string)this.GetValue(Op62Property); }
            set { this.SetValue(Op62Property, value); }
        }

        /// <summary>
        /// Op63 Property
        /// </summary>
        public static readonly DependencyProperty Op63Property =
            DependencyProperty.Register("Op63", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op63.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op63
        {
            get { return (string)this.GetValue(Op63Property); }
            set { this.SetValue(Op63Property, value); }
        }

        /// <summary>
        /// Op64 Property
        /// </summary>
        public static readonly DependencyProperty Op64Property =
            DependencyProperty.Register("Op64", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op64.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op64
        {
            get { return (string)this.GetValue(Op64Property); }
            set { this.SetValue(Op64Property, value); }
        }

        /// <summary>
        /// Op65 Property
        /// </summary>
        public static readonly DependencyProperty Op65Property =
            DependencyProperty.Register("Op65", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op65.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op65
        {
            get { return (string)this.GetValue(Op65Property); }
            set { this.SetValue(Op65Property, value); }
        }

        /// <summary>
        /// op66 Property
        /// </summary>
        public static readonly DependencyProperty op66Property =
            DependencyProperty.Register("op66", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the op66.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string op66
        {
            get { return (string)this.GetValue(op66Property); }
            set { this.SetValue(op66Property, value); }
        }

        /// <summary>
        /// Op67 Property
        /// </summary>
        public static readonly DependencyProperty Op67Property =
            DependencyProperty.Register("Op67", typeof(string), typeof(AclRead));

        /// <summary>
        /// Gets or sets the Op67.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string Op67
        {
            get { return (string)this.GetValue(Op67Property); }
            set { this.SetValue(Op67Property, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Op1)) yield return new Param("$Op1", this.Op1);
if (!string.IsNullOrWhiteSpace(this.Op2)) yield return new Param("$Op2", this.Op2);
if (!string.IsNullOrWhiteSpace(this.OpeEnv)) yield return new Param("$OpeEnv", this.OpeEnv);
if (!string.IsNullOrWhiteSpace(this.Op3)) yield return new Param("$Op3", this.Op3);
if (!string.IsNullOrWhiteSpace(this.Op5)) yield return new Param("$Op5", this.Op5);
if (!string.IsNullOrWhiteSpace(this.Op6)) yield return new Param("$Op6", this.Op6);
if (!string.IsNullOrWhiteSpace(this.Op7)) yield return new Param("$Op7", this.Op7);
if (!string.IsNullOrWhiteSpace(this.Op0)) yield return new Param("$Op0", this.Op0);
if (!string.IsNullOrWhiteSpace(this.Op8)) yield return new Param("$Op8", this.Op8);
if (!string.IsNullOrWhiteSpace(this.Op9)) yield return new Param("$Op9", this.Op9);
if (!string.IsNullOrWhiteSpace(this.Op10)) yield return new Param("$Op10", this.Op10);
if (!string.IsNullOrWhiteSpace(this.Op11)) yield return new Param("$Op11", this.Op11);
if (!string.IsNullOrWhiteSpace(this.Op12)) yield return new Param("$Op12", this.Op12);
if (!string.IsNullOrWhiteSpace(this.Op13)) yield return new Param("$Op13", this.Op13);
if (!string.IsNullOrWhiteSpace(this.Op14)) yield return new Param("$Op14", this.Op14);
if (!string.IsNullOrWhiteSpace(this.Op15)) yield return new Param("$Op15", this.Op15);
if (!string.IsNullOrWhiteSpace(this.Op16)) yield return new Param("$Op16", this.Op16);
if (!string.IsNullOrWhiteSpace(this.Op17)) yield return new Param("$Op17", this.Op17);
if (!string.IsNullOrWhiteSpace(this.Op18)) yield return new Param("$Op18", this.Op18);
if (!string.IsNullOrWhiteSpace(this.Op19)) yield return new Param("$Op19", this.Op19);
if (!string.IsNullOrWhiteSpace(this.Op20)) yield return new Param("$Op20", this.Op20);
if (!string.IsNullOrWhiteSpace(this.Op31)) yield return new Param("$Op31", this.Op31);
if (!string.IsNullOrWhiteSpace(this.Op32)) yield return new Param("$Op32", this.Op32);
if (!string.IsNullOrWhiteSpace(this.Op33)) yield return new Param("$Op33", this.Op33);
if (!string.IsNullOrWhiteSpace(this.Op34)) yield return new Param("$Op34", this.Op34);
if (!string.IsNullOrWhiteSpace(this.Op35)) yield return new Param("$Op35", this.Op35);
if (!string.IsNullOrWhiteSpace(this.Op36)) yield return new Param("$Op36", this.Op36);
if (!string.IsNullOrWhiteSpace(this.Op37)) yield return new Param("$Op37", this.Op37);
if (!string.IsNullOrWhiteSpace(this.Op38)) yield return new Param("$Op38", this.Op38);
if (!string.IsNullOrWhiteSpace(this.Op39)) yield return new Param("$Op39", this.Op39);
if (!string.IsNullOrWhiteSpace(this.Op40)) yield return new Param("$Op40", this.Op40);
if (!string.IsNullOrWhiteSpace(this.Op41)) yield return new Param("$Op41", this.Op41);
if (!string.IsNullOrWhiteSpace(this.Op42)) yield return new Param("$Op42", this.Op42);
if (!string.IsNullOrWhiteSpace(this.Op43)) yield return new Param("$Op43", this.Op43);
if (!string.IsNullOrWhiteSpace(this.Op44)) yield return new Param("$Op44", this.Op44);
if (!string.IsNullOrWhiteSpace(this.Op45)) yield return new Param("$Op45", this.Op45);
if (!string.IsNullOrWhiteSpace(this.Op46)) yield return new Param("$Op46", this.Op46);
if (!string.IsNullOrWhiteSpace(this.Op47)) yield return new Param("$Op47", this.Op47);
if (!string.IsNullOrWhiteSpace(this.Op48)) yield return new Param("$Op48", this.Op48);
if (!string.IsNullOrWhiteSpace(this.Op49)) yield return new Param("$Op49", this.Op49);
if (!string.IsNullOrWhiteSpace(this.Op50)) yield return new Param("$Op50", this.Op50);
if (!string.IsNullOrWhiteSpace(this.Op51)) yield return new Param("$Op51", this.Op51);
if (!string.IsNullOrWhiteSpace(this.Op52)) yield return new Param("$Op52", this.Op52);
if (!string.IsNullOrWhiteSpace(this.Op53)) yield return new Param("$Op53", this.Op53);
if (!string.IsNullOrWhiteSpace(this.Op54)) yield return new Param("$Op54", this.Op54);
if (!string.IsNullOrWhiteSpace(this.Op55)) yield return new Param("$Op55", this.Op55);
if (!string.IsNullOrWhiteSpace(this.Op56)) yield return new Param("$Op56", this.Op56);
if (!string.IsNullOrWhiteSpace(this.Op57)) yield return new Param("$Op57", this.Op57);
if (!string.IsNullOrWhiteSpace(this.Op58)) yield return new Param("$Op58", this.Op58);
if (!string.IsNullOrWhiteSpace(this.Op59)) yield return new Param("$Op59", this.Op59);
if (!string.IsNullOrWhiteSpace(this.Op60)) yield return new Param("$Op60", this.Op60);
if (!string.IsNullOrWhiteSpace(this.Op61)) yield return new Param("$Op61", this.Op61);
if (!string.IsNullOrWhiteSpace(this.Op62)) yield return new Param("$Op62", this.Op62);
if (!string.IsNullOrWhiteSpace(this.Op63)) yield return new Param("$Op63", this.Op63);
if (!string.IsNullOrWhiteSpace(this.Op64)) yield return new Param("$Op64", this.Op64);
if (!string.IsNullOrWhiteSpace(this.Op65)) yield return new Param("$Op65", this.Op65);
if (!string.IsNullOrWhiteSpace(this.op66)) yield return new Param("$op66", this.op66);
if (!string.IsNullOrWhiteSpace(this.Op67)) yield return new Param("$Op67", this.Op67);

            }
        }

		
    }
}
