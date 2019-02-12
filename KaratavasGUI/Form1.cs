using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karatavas; // atsaucamies uz Namespace

namespace KaratavasGUI
{
    public partial class Form1 : Form
    {
        Karatavas.Karatavas k = new Karatavas.Karatavas(); // Namespace.Class vai arī varētu pārsaukt Namespae uz ko citu tad nevajadzēs pierakstīt abus
                                                           // un vajag lai tā Klase ir public
        public Form1()
        {
            InitializeComponent();

            k.SaktSpeli();

            //grafisko interefeisu, kas izsauc vajadzīgās funckcijas
        }
    }
}
