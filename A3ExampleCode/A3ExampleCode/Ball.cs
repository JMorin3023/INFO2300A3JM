using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ExampleCode
{
    class Ball
    {
        private string ballName;

        public string BallName
        {
            get { return ballName; }
            set { ballName = value; }
        }

        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private int circumference;

        public int Circumference
        {
            get { return circumference; }
            set { circumference = value; }
        }
    }
}
