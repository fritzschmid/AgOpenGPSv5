using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace AgOpenGPS
{
    public class CPunktFS
    {
        public double Nr = 0;
        public double FeldEast = 0;
        public double FeldNorth = 0;
        public double UTMEast = 0;
        public double UTMNorth = 0;
        public string Name = "";
        public double Latidude = 0;
        public double Longitude = 0;
        public double Altitude = 0;
        public byte Art = 0;

        public List<CPunktFS> punktArr = new List<CPunktFS>();

        private readonly FormGPS mf;

        public CPunktFS(FormGPS _f)
        {
            mf = _f;

        }

        public CPunktFS()
        {
        }

    }
}
