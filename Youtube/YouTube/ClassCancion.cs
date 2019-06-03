using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
namespace YouTube
{
    class ClassCancion
    {
        string nombreCancion;
        DateTime fechaDescarga;

        public string NombreCancion
        {
            get
            {
                return nombreCancion;
            }

            set
            {
                nombreCancion = value;
            }
        }

        public DateTime FechaDescarga
        {
            get
            {
                return fechaDescarga;
            }

            set
            {
                fechaDescarga = value;
            }
        }
    }
}
