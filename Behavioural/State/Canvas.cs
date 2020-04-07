using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Canvas
    {
        public ITool Tool { get; set; }

        public void MouseUp()
        {
            if (Tool == null)
            {
                throw new Exception("Tool not installed");
            }

            Tool.MouseUp();
        }

        public void MouseDown()
        {
            if (Tool == null)
            {
                throw new Exception("Tool not installed");
            }

            Tool.MouseDown();
        }
    }
}
