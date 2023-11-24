using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightParty.Classes
{
    public class Playlist
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario {  get; set; }
        public int IdArtista { get; set; }
        public int IdMusica { get; set; }
    }
}
