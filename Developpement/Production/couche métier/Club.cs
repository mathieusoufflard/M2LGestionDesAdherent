using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.couche_métier
{
    class Club
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Club(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
