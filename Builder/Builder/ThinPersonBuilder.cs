using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Builder
{
    #region Ver 2
    //public class ThinPersonBuilder
    //{
    //    private Graphics graphics;
    //    private Pen pen;

    //    public ThinPersonBuilder(Graphics g, Pen p)
    //    {
    //        graphics = g;
    //        pen = p;
    //    }

    //    public void Build()
    //    {
    //        graphics.DrawEllipse(pen, 50, 20, 30, 30);      //Head
    //        graphics.DrawRectangle(pen, 60, 50, 10, 50);    //Body
    //        graphics.DrawLine(pen, 60, 50, 40, 100);        //Left hand
    //        graphics.DrawLine(pen, 70, 50, 90, 100);        //Right hand
    //        graphics.DrawLine(pen, 60, 100, 45, 150);       //Left leg
    //        graphics.DrawLine(pen, 70, 100, 85, 150);       //Right leg
    //    }
    //}
    #endregion

    #region Ver 3
    //public class ThinPersonBuilder : PersonBuilder
    //{
    //    public ThinPersonBuilder(Graphics g, Pen p) : base(g, p) { }

    //    public override void BuildHead()
    //    {
    //        Graphics.DrawEllipse(Pen, 50, 20, 30, 30);
    //    }

    //    public override void BuildBody()
    //    {
    //        Graphics.DrawRectangle(Pen, 60, 50, 10, 50);
    //    }

    //    public override void BuildLeftArm()
    //    {
    //        Graphics.DrawLine(Pen, 60, 50, 40, 100);
    //    }

    //    public override void BuildRightArm()
    //    {
    //        Graphics.DrawLine(Pen, 70, 50, 90, 100);
    //    }

    //    public override void BuildLeftLeg()
    //    {
    //        Graphics.DrawLine(Pen, 60, 100, 45, 150);
    //    }

    //    public override void BuildRightLeg()
    //    {
    //        Graphics.DrawLine(Pen, 70, 100, 85, 150);
    //    }
    //}
    #endregion
}
