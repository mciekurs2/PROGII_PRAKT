using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Doughnut_Factory
{
    public partial class DougnutMachine : Component
    {
        public DougnutMachine()
        {
            InitializeComponent();
        }

        public DougnutMachine(IContainer container)
        {
            container.Add(this);

            InitializeComponent();


        }


        public enum DougnutType
        {
            Glazed,
            Sugar,
            Chocolate,
            ChocoladeCake,
            Custard,
            Grape,
            Lemon,
            PlainCake,
            SugarCage
        }

        private DougnutType mFlavor;
        public DougnutType Flavor
        {
            get
            {
                return mFlavor;
            }

            set
            {
                mFlavor = value;
            }

        }

        public class Dougnut
        {
            private DougnutType mFlavor;
            private float mPrice = .50F;
            private readonly System.DateTime mTimeofCreation;

            public DougnutType Flavor
            {
                get
                {
                    return mFlavor;
                }

                set
                {
                    mFlavor = value;
                }

            }

            public float Price
            {
                get
                {
                    return mPrice;
                }

                set
                {
                    mPrice = value;
                }

            }

            public System.DateTime timeofCreation
            {
                get
                {
                    return mTimeofCreation;
                }
            }

            public Dougnut(DougnutType Flavor)
            {
                mTimeofCreation = System.DateTime.Now;
                mFlavor = Flavor;
            }

        }

        private System.Collections.ArrayList mDoughnuts = new System.Collections.ArrayList();
        public Dougnut this[int Index]
        {
            get
            {
                return (Dougnut)mDoughnuts[Index];
            }
            set
            {
                mDoughnuts[Index] = value;
            }
        }

        //izveido pashu delegatu
        public delegate void DoughnutCompliteDelegate();
        public event DoughnutCompliteDelegate DoughnuntComplite;

        private void timerName_Tick(object sender, EventArgs e)
        {
            Dougnut mDoughnut = new Dougnut(this.Flavor);
            mDoughnuts.Add(mDoughnut);
            DoughnuntComplite();
        }

        public bool Enable
        {
            set
            {
                timerName.Enabled = value;
            }
        }

        public int Inderval
        {
            set
            {
                timerName.Interval = value;
            }
        }

    }
}
