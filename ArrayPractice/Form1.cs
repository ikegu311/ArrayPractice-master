﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);

        int va = rand.Next(-10, 11);
        int vb = rand.Next(-10, 11);

        int vc = rand.Next(-30, 31);
        int vd = rand.Next(-30, 31);

        int score = 100;

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score--;
            scoreLabel.Text = $"Score {score:000}";

            label1.Left += vx;
            label1.Top += vy;

            label2.Left += va;
            label2.Top += vb;

            label3.Left += vc;
            label3.Top += vd;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }


            if (label2.Left < 0)
            {
                va = Math.Abs(va);
            }
            if (label2.Top < 0)
            {
                vb = Math.Abs(vb);
            }
            if (label2.Right > ClientSize.Width)
            {
                va = -Math.Abs(va);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vb = -Math.Abs(vb);
            }

            if (label3.Left < 0)
            {
                vc = Math.Abs(vc);
            }
            if (label3.Top < 0)
            {
                vd = Math.Abs(vd);
            }
            if (label3.Right > ClientSize.Width)
            {
                vc = -Math.Abs(vc);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vd = -Math.Abs(vd);
            }

            Point fpos = PointToClient(MousePosition);

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}