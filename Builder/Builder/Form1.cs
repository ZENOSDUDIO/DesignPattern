using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Ver 1
            var pen = new Pen(Color.Yellow);
            var thinPerson = pictureBox1.CreateGraphics();

            thinPerson.DrawEllipse(pen, 50, 20, 30, 30);      //Head
            thinPerson.DrawRectangle(pen, 60, 50, 10, 50);    //Body
            thinPerson.DrawLine(pen, 60, 50, 40, 100);        //Left hand
            thinPerson.DrawLine(pen, 70, 50, 90, 100);        //Right hand
            thinPerson.DrawLine(pen, 60, 100, 45, 150);       //Left leg
            thinPerson.DrawLine(pen, 70, 100, 85, 150);       //Right leg

            var fatPerson = pictureBox1.CreateGraphics();

            fatPerson.DrawEllipse(pen, 50, 20, 30, 30);         //Head
            fatPerson.DrawEllipse(pen, 45, 50, 40, 50);         //Body
            fatPerson.DrawLine(pen, 50, 50, 30, 100);           //Left hand
            fatPerson.DrawLine(pen, 80, 50, 100, 100);          //Right hand
            fatPerson.DrawLine(pen, 60, 100, 45, 150);          //Left leg
            fatPerson.DrawLine(pen, 70, 100, 85, 150);          //Right leg
            #endregion

            #region Ver 2
            //var pen = new Pen(Color.Yellow);
            //var thinPersonBuilder = new ThinPersonBuilder(pictureBox1.CreateGraphics(), pen);
            //thinPersonBuilder.Build();
            #endregion

            #region Ver 3
            //var pen = new Pen(Color.Yellow);
            //var thinPersonBuilder = new ThinPersonBuilder(pictureBox1.CreateGraphics(), pen);
            //var personDirector = new PersonDirector(thinPersonBuilder);
            //personDirector.CreatePerson();
            #endregion
        }
    }
}
