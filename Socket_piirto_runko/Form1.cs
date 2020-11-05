using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_piirto_runko
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream ns;
        public Form1()
        {
            InitializeComponent();
            connect();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            /* jos hiiren vasen nappi on pohjassa
             * textboxiin kirjoitetaan hiiren sijainti
             * lähetään koordinaatit sentPosition metodin kautta toiselle sovellukselle
             * 
             * Lopuksi piirretään tämän ohjelman paneeliin.
             */
           
        }
        private void connect()
        {
            //luodaan yhteys palvelimelle (127.0.0.1:5000)
            //muodostetaan stream
           
        }
        private void disconnect()
        {
            //yhteyden sulkeminen
        }
        private void sentPosition(string position)
        {
            // muunnetaan position string tavutaulukoksi
            //lähetetään tavut streamilla toiselle sovellukselle
        }
    }
}
