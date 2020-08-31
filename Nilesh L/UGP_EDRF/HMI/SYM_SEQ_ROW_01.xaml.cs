using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_EDRF.HMI
{
    public class SYM_SEQ_ROW_01 : RSIControlModel
    {
        static SYM_SEQ_ROW_01()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SYM_SEQ_ROW_01), new FrameworkPropertyMetadata(typeof(SYM_SEQ_ROW_01)));
        }

        public SYM_SEQ_ROW_01()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(SYM_SEQ_ROW_01));

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
        /// STEP_NO Property
        /// </summary>
        public static readonly DependencyProperty STEP_NOProperty =
            DependencyProperty.Register("STEP_NO", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the STEP_NO.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STEP_NO
        {
            get { return (string)this.GetValue(STEP_NOProperty); }
            set { this.SetValue(STEP_NOProperty, value); }
        }

        /// <summary>
        /// STEP_ACT Property
        /// </summary>
        public static readonly DependencyProperty STEP_ACTProperty =
            DependencyProperty.Register("STEP_ACT", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the STEP_ACT.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STEP_ACT
        {
            get { return (string)this.GetValue(STEP_ACTProperty); }
            set { this.SetValue(STEP_ACTProperty, value); }
        }

        /// <summary>
        /// MISMATCH01 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH01Property =
            DependencyProperty.Register("MISMATCH01", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH01
        {
            get { return (bool)this.GetValue(MISMATCH01Property); }
            set { this.SetValue(MISMATCH01Property, value); }
        }

        /// <summary>
        /// MISMATCH02 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH02Property =
            DependencyProperty.Register("MISMATCH02", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH02
        {
            get { return (bool)this.GetValue(MISMATCH02Property); }
            set { this.SetValue(MISMATCH02Property, value); }
        }

        /// <summary>
        /// MISMATCH03 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH03Property =
            DependencyProperty.Register("MISMATCH03", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH03
        {
            get { return (bool)this.GetValue(MISMATCH03Property); }
            set { this.SetValue(MISMATCH03Property, value); }
        }

        /// <summary>
        /// MISMATCH04 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH04Property =
            DependencyProperty.Register("MISMATCH04", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH04
        {
            get { return (bool)this.GetValue(MISMATCH04Property); }
            set { this.SetValue(MISMATCH04Property, value); }
        }

        /// <summary>
        /// MISMATCH05 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH05Property =
            DependencyProperty.Register("MISMATCH05", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH05
        {
            get { return (bool)this.GetValue(MISMATCH05Property); }
            set { this.SetValue(MISMATCH05Property, value); }
        }

        /// <summary>
        /// MISMATCH06 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH06Property =
            DependencyProperty.Register("MISMATCH06", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH06
        {
            get { return (bool)this.GetValue(MISMATCH06Property); }
            set { this.SetValue(MISMATCH06Property, value); }
        }

        /// <summary>
        /// MISMATCH07 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH07Property =
            DependencyProperty.Register("MISMATCH07", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH07.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH07
        {
            get { return (bool)this.GetValue(MISMATCH07Property); }
            set { this.SetValue(MISMATCH07Property, value); }
        }

        /// <summary>
        /// MISMATCH08 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH08Property =
            DependencyProperty.Register("MISMATCH08", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH08.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH08
        {
            get { return (bool)this.GetValue(MISMATCH08Property); }
            set { this.SetValue(MISMATCH08Property, value); }
        }

        /// <summary>
        /// MISMATCH09 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH09Property =
            DependencyProperty.Register("MISMATCH09", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH09.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH09
        {
            get { return (bool)this.GetValue(MISMATCH09Property); }
            set { this.SetValue(MISMATCH09Property, value); }
        }

        /// <summary>
        /// MISMATCH10 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH10Property =
            DependencyProperty.Register("MISMATCH10", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH10.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH10
        {
            get { return (bool)this.GetValue(MISMATCH10Property); }
            set { this.SetValue(MISMATCH10Property, value); }
        }

        /// <summary>
        /// MISMATCH11 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH11Property =
            DependencyProperty.Register("MISMATCH11", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH11.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH11
        {
            get { return (bool)this.GetValue(MISMATCH11Property); }
            set { this.SetValue(MISMATCH11Property, value); }
        }

        /// <summary>
        /// MISMATCH12 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH12Property =
            DependencyProperty.Register("MISMATCH12", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH12.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH12
        {
            get { return (bool)this.GetValue(MISMATCH12Property); }
            set { this.SetValue(MISMATCH12Property, value); }
        }

        /// <summary>
        /// MISMATCH13 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH13Property =
            DependencyProperty.Register("MISMATCH13", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH13.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH13
        {
            get { return (bool)this.GetValue(MISMATCH13Property); }
            set { this.SetValue(MISMATCH13Property, value); }
        }

        /// <summary>
        /// MISMATCH14 Property
        /// </summary>
        public static readonly DependencyProperty MISMATCH14Property =
            DependencyProperty.Register("MISMATCH14", typeof(bool), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the MISMATCH14.  
        /// </summary>
		[Category("RSI")]
        [Description(@"IADAS.CMP.BLK.PAR")]
        public bool MISMATCH14
        {
            get { return (bool)this.GetValue(MISMATCH14Property); }
            set { this.SetValue(MISMATCH14Property, value); }
        }

        /// <summary>
        /// STEP_BYPASS Property
        /// </summary>
        public static readonly DependencyProperty STEP_BYPASSProperty =
            DependencyProperty.Register("STEP_BYPASS", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the STEP_BYPASS.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string STEP_BYPASS
        {
            get { return (string)this.GetValue(STEP_BYPASSProperty); }
            set { this.SetValue(STEP_BYPASSProperty, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT0 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT0Property =
            DependencyProperty.Register("ZTEXT0", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT0
        {
            get { return (string)this.GetValue(ZTEXT0Property); }
            set { this.SetValue(ZTEXT0Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT00 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT00Property =
            DependencyProperty.Register("ZTEXT00", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT00.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT00
        {
            get { return (string)this.GetValue(ZTEXT00Property); }
            set { this.SetValue(ZTEXT00Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT01 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT01Property =
            DependencyProperty.Register("ZTEXT01", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT01
        {
            get { return (string)this.GetValue(ZTEXT01Property); }
            set { this.SetValue(ZTEXT01Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT02 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT02Property =
            DependencyProperty.Register("ZTEXT02", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT02
        {
            get { return (string)this.GetValue(ZTEXT02Property); }
            set { this.SetValue(ZTEXT02Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT03 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT03Property =
            DependencyProperty.Register("ZTEXT03", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT03
        {
            get { return (string)this.GetValue(ZTEXT03Property); }
            set { this.SetValue(ZTEXT03Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT04 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT04Property =
            DependencyProperty.Register("ZTEXT04", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT04
        {
            get { return (string)this.GetValue(ZTEXT04Property); }
            set { this.SetValue(ZTEXT04Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT05 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT05Property =
            DependencyProperty.Register("ZTEXT05", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT05
        {
            get { return (string)this.GetValue(ZTEXT05Property); }
            set { this.SetValue(ZTEXT05Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT06 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT06Property =
            DependencyProperty.Register("ZTEXT06", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT06
        {
            get { return (string)this.GetValue(ZTEXT06Property); }
            set { this.SetValue(ZTEXT06Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT07 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT07Property =
            DependencyProperty.Register("ZTEXT07", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT07.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT07
        {
            get { return (string)this.GetValue(ZTEXT07Property); }
            set { this.SetValue(ZTEXT07Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT08 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT08Property =
            DependencyProperty.Register("ZTEXT08", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT08.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT08
        {
            get { return (string)this.GetValue(ZTEXT08Property); }
            set { this.SetValue(ZTEXT08Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT09 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT09Property =
            DependencyProperty.Register("ZTEXT09", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT09.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT09
        {
            get { return (string)this.GetValue(ZTEXT09Property); }
            set { this.SetValue(ZTEXT09Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT10 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT10Property =
            DependencyProperty.Register("ZTEXT10", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT10.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT10
        {
            get { return (string)this.GetValue(ZTEXT10Property); }
            set { this.SetValue(ZTEXT10Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT11 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT11Property =
            DependencyProperty.Register("ZTEXT11", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT11.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT11
        {
            get { return (string)this.GetValue(ZTEXT11Property); }
            set { this.SetValue(ZTEXT11Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT12 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT12Property =
            DependencyProperty.Register("ZTEXT12", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT12.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT12
        {
            get { return (string)this.GetValue(ZTEXT12Property); }
            set { this.SetValue(ZTEXT12Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT13 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT13Property =
            DependencyProperty.Register("ZTEXT13", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT13.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT13
        {
            get { return (string)this.GetValue(ZTEXT13Property); }
            set { this.SetValue(ZTEXT13Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZTEXT14 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT14Property =
            DependencyProperty.Register("ZTEXT14", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT14.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT14
        {
            get { return (string)this.GetValue(ZTEXT14Property); }
            set { this.SetValue(ZTEXT14Property, value); }
        }

        /// <summary>
        /// ZTEXT15 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT15Property =
            DependencyProperty.Register("ZTEXT15", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT15.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT15
        {
            get { return (string)this.GetValue(ZTEXT15Property); }
            set { this.SetValue(ZTEXT15Property, value); }
        }


        /// <summary>
        /// ZTEXT16 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT16Property =
            DependencyProperty.Register("ZTEXT16", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT16.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT16
        {
            get { return (string)this.GetValue(ZTEXT16Property); }
            set { this.SetValue(ZTEXT16Property, value); }
        }


        /// <summary>
        /// ZTEXT17 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT17Property =
            DependencyProperty.Register("ZTEXT17", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT17.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT17
        {
            get { return (string)this.GetValue(ZTEXT17Property); }
            set { this.SetValue(ZTEXT17Property, value); }
        }


        /// <summary>
        /// ZTEXT18 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT18Property =
            DependencyProperty.Register("ZTEXT18", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT18.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT18
        {
            get { return (string)this.GetValue(ZTEXT18Property); }
            set { this.SetValue(ZTEXT18Property, value); }
        }



        /// <summary>
        /// ZTEXT19 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT19Property =
            DependencyProperty.Register("ZTEXT19", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT19.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT19
        {
            get { return (string)this.GetValue(ZTEXT19Property); }
            set { this.SetValue(ZTEXT19Property, value); }
        }



        /// <summary>
        /// ZTEXT20 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT20Property =
            DependencyProperty.Register("ZTEXT20", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT20.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT20
        {
            get { return (string)this.GetValue(ZTEXT20Property); }
            set { this.SetValue(ZTEXT20Property, value); }
        }


        /// <summary>
        /// ZTEXT21 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT21Property =
            DependencyProperty.Register("ZTEXT21", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT21.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT21
        {
            get { return (string)this.GetValue(ZTEXT21Property); }
            set { this.SetValue(ZTEXT21Property, value); }
        }


        /// <summary>
        /// ZTEXT22 Property
        /// </summary>
        public static readonly DependencyProperty ZTEXT22Property =
            DependencyProperty.Register("ZTEXT22", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZTEXT22.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZTEXT22
        {
            get { return (string)this.GetValue(ZTEXT22Property); }
            set { this.SetValue(ZTEXT22Property, value); }
        }





        /// <summary>
        /// /UOS
        /// </summary>

        /// <summary>
        /// ZUO0 Property
        /// </summary>
        public static readonly DependencyProperty ZUO0Property =
            DependencyProperty.Register("ZUO0", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO0.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO0
        {
            get { return (string)this.GetValue(ZUO0Property); }
            set { this.SetValue(ZUO0Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO00 Property
        /// </summary>
        public static readonly DependencyProperty ZUO00Property =
            DependencyProperty.Register("ZUO00", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO00.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO00
        {
            get { return (string)this.GetValue(ZUO00Property); }
            set { this.SetValue(ZUO00Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO01 Property
        /// </summary>
        public static readonly DependencyProperty ZUO01Property =
            DependencyProperty.Register("ZUO01", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO01.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO01
        {
            get { return (string)this.GetValue(ZUO01Property); }
            set { this.SetValue(ZUO01Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO02 Property
        /// </summary>
        public static readonly DependencyProperty ZUO02Property =
            DependencyProperty.Register("ZUO02", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO02.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO02
        {
            get { return (string)this.GetValue(ZUO02Property); }
            set { this.SetValue(ZUO02Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO03 Property
        /// </summary>
        public static readonly DependencyProperty ZUO03Property =
            DependencyProperty.Register("ZUO03", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO03.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO03
        {
            get { return (string)this.GetValue(ZUO03Property); }
            set { this.SetValue(ZUO03Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO04 Property
        /// </summary>
        public static readonly DependencyProperty ZUO04Property =
            DependencyProperty.Register("ZUO04", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO04.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO04
        {
            get { return (string)this.GetValue(ZUO04Property); }
            set { this.SetValue(ZUO04Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO05 Property
        /// </summary>
        public static readonly DependencyProperty ZUO05Property =
            DependencyProperty.Register("ZUO05", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO05.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO05
        {
            get { return (string)this.GetValue(ZUO05Property); }
            set { this.SetValue(ZUO05Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO06 Property
        /// </summary>
        public static readonly DependencyProperty ZUO06Property =
            DependencyProperty.Register("ZUO06", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO06.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO06
        {
            get { return (string)this.GetValue(ZUO06Property); }
            set { this.SetValue(ZUO06Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO07 Property
        /// </summary>
        public static readonly DependencyProperty ZUO07Property =
            DependencyProperty.Register("ZUO07", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO07.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO07
        {
            get { return (string)this.GetValue(ZUO07Property); }
            set { this.SetValue(ZUO07Property, value); }
        }


        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO08 Property
        /// </summary>
        public static readonly DependencyProperty ZUO08Property =
            DependencyProperty.Register("ZUO08", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO08.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO08
        {
            get { return (string)this.GetValue(ZUO08Property); }
            set { this.SetValue(ZUO08Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO09 Property
        /// </summary>
        public static readonly DependencyProperty ZUO09Property =
            DependencyProperty.Register("ZUO09", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO09.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO09
        {
            get { return (string)this.GetValue(ZUO09Property); }
            set { this.SetValue(ZUO09Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO10 Property
        /// </summary>
        public static readonly DependencyProperty ZUO10Property =
            DependencyProperty.Register("ZUO10", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO10.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO10
        {
            get { return (string)this.GetValue(ZUO10Property); }
            set { this.SetValue(ZUO10Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO11 Property
        /// </summary>
        public static readonly DependencyProperty ZUO11Property =
            DependencyProperty.Register("ZUO11", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO11.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO11
        {
            get { return (string)this.GetValue(ZUO11Property); }
            set { this.SetValue(ZUO11Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO12 Property
        /// </summary>
        public static readonly DependencyProperty ZUO12Property =
            DependencyProperty.Register("ZUO12", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO12.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO12
        {
            get { return (string)this.GetValue(ZUO12Property); }
            set { this.SetValue(ZUO12Property, value); }
        }




        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO13 Property
        /// </summary>
        public static readonly DependencyProperty ZUO13Property =
            DependencyProperty.Register("ZUO13", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO13.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO13
        {
            get { return (string)this.GetValue(ZUO13Property); }
            set { this.SetValue(ZUO13Property, value); }
        }



        /// <summary>
        /// // ADDED FOR 22 TEXT AND UOS
        /// </summary>

        /// <summary>
        /// ZUO14 Property
        /// </summary>
        public static readonly DependencyProperty ZUO14Property =
            DependencyProperty.Register("ZUO14", typeof(string), typeof(SYM_SEQ_ROW_01));

        /// <summary>
        /// Gets or sets the ZUO14.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZUO14
        {
            get { return (string)this.GetValue(ZUO14Property); }
            set { this.SetValue(ZUO14Property, value); }
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

               
                if (!string.IsNullOrWhiteSpace(this.ZUO0)) yield return new Param("$ZUO0", this.ZUO0);
                if (!string.IsNullOrWhiteSpace(this.ZUO00)) yield return new Param("$ZUO00", this.ZUO00);
                if (!string.IsNullOrWhiteSpace(this.ZUO01)) yield return new Param("$ZUO01", this.ZUO01);
                if (!string.IsNullOrWhiteSpace(this.ZUO02)) yield return new Param("$ZUO02", this.ZUO02);
                if (!string.IsNullOrWhiteSpace(this.ZUO03)) yield return new Param("$ZUO03", this.ZUO03);
                if (!string.IsNullOrWhiteSpace(this.ZUO04)) yield return new Param("$ZUO04", this.ZUO04);
                if (!string.IsNullOrWhiteSpace(this.ZUO05)) yield return new Param("$ZUO05", this.ZUO05);
                if (!string.IsNullOrWhiteSpace(this.ZUO06)) yield return new Param("$ZUO06", this.ZUO06);
                if (!string.IsNullOrWhiteSpace(this.ZUO07)) yield return new Param("$ZUO07", this.ZUO07);
                if (!string.IsNullOrWhiteSpace(this.ZUO08)) yield return new Param("$ZUO08", this.ZUO08);
                if (!string.IsNullOrWhiteSpace(this.ZUO09)) yield return new Param("$ZUO09", this.ZUO09);
                if (!string.IsNullOrWhiteSpace(this.ZUO10)) yield return new Param("$ZUO10", this.ZUO10);
                if (!string.IsNullOrWhiteSpace(this.ZUO11)) yield return new Param("$ZUO11", this.ZUO11);
                if (!string.IsNullOrWhiteSpace(this.ZUO12)) yield return new Param("$ZUO12", this.ZUO12);
                if (!string.IsNullOrWhiteSpace(this.ZUO13)) yield return new Param("$ZUO13", this.ZUO13);
                if (!string.IsNullOrWhiteSpace(this.ZUO14)) yield return new Param("$ZUO14", this.ZUO14);

                if (!string.IsNullOrWhiteSpace(this.STEP_NO)) yield return new Param("$STEP_NO", this.STEP_NO);
                if (!string.IsNullOrWhiteSpace(this.STEP_BYPASS)) yield return new Param("$STEP_BYPASS", this.STEP_BYPASS);
                if (!string.IsNullOrWhiteSpace(this.STEP_ACT)) yield return new Param("$STEP_ACT", this.STEP_ACT);

                if (!string.IsNullOrWhiteSpace(this.ZTEXT01)) yield return new Param("$ZTEXT01", this.ZTEXT01);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT02)) yield return new Param("$ZTEXT02", this.ZTEXT02);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT03)) yield return new Param("$ZTEXT03", this.ZTEXT03);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT04)) yield return new Param("$ZTEXT04", this.ZTEXT04);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT05)) yield return new Param("$ZTEXT05", this.ZTEXT05);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT06)) yield return new Param("$ZTEXT06", this.ZTEXT06);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT07)) yield return new Param("$ZTEXT07", this.ZTEXT07);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT08)) yield return new Param("$ZTEXT08", this.ZTEXT08);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT09)) yield return new Param("$ZTEXT09", this.ZTEXT09);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT10)) yield return new Param("$ZTEXT10", this.ZTEXT10);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT11)) yield return new Param("$ZTEXT11", this.ZTEXT11);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT12)) yield return new Param("$ZTEXT12", this.ZTEXT12);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT13)) yield return new Param("$ZTEXT13", this.ZTEXT13);
                if (!string.IsNullOrWhiteSpace(this.ZTEXT14)) yield return new Param("$ZTEXT14", this.ZTEXT14);
                

            }
        }


    }
}
