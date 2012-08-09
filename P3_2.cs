﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVETool
{
    public partial class P3_2 : UserControl
    {
        public P3_2(List<String> RawMaterial, int index, Double Amount)
        {
            InitializeComponent();
            FinalLabel.Text = RawMaterial[0];
            Resource1Label.Text = RawMaterial[1];
            Resource1_P1_1Label.Text = RawMaterial[2];
            Resource1_P1_1_RMLabel.Text = RawMaterial[3];
            Resource1_P1_2Label.Text = RawMaterial[4];
            Resource1_P1_2_RMLabel.Text = RawMaterial[5];
            Resource2Label.Text = RawMaterial[6];
            Resource2_P1_1Label.Text = RawMaterial[7];
            Resource2_P1_1_RMLabel.Text = RawMaterial[8];
            Resource2_P1_2Label.Text = RawMaterial[9];
            Resource2_P1_2_RMLabel.Text = RawMaterial[10];

            if (index == 0)
            {
                if (Amount % 3 == 0)
                {
                    double P2, P1, RM;
                    FinalAmount.Text = Convert.ToString(Amount) + "u";
                    P2 = (Amount / 3) * 10;
                    P1 = (P2 / 5) * 40;
                    RM = (P1 / 20) * 3000;
                    P2Amount.Text = Convert.ToString(P2) + "u";
                    P1Amount.Text = Convert.ToString(P1) + "u";
                    P1_1Amount.Text = P1Amount.Text;
                    RMAmount.Text = Convert.ToString(RM) + "u";
                    RM_1Amount.Text = RMAmount.Text;
                }
                else
                {
                    Popup error = new Popup("Invalid Entry", "The entered value must be a number divisible by 3");
                    error.Show();
                }
            }
            else if (index == 1)
            {
                double P3, P2, P1, RM;
                P3 = Math.Truncate(Amount / 6);
                P2 = (P3 / 3) * 10;
                P1 = (P2 / 5) * 40;
                RM = (P1 / 20) * 3000;
                FinalAmount.Text = Convert.ToString(P3) + "u";
                P2Amount.Text = Convert.ToString(Math.Round(P2,2)) + "u";
                P1Amount.Text = Convert.ToString(Math.Round(P1,2)) + "u";
                P1_1Amount.Text = P1Amount.Text;
                RMAmount.Text = Convert.ToString(Math.Round(RM,2)) + "u";
                RM_1Amount.Text = RMAmount.Text;
            }
        }
    }
}
