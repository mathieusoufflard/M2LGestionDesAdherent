using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.couche_métier
{
    class User
    {
        private static int Id { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        private string PWD { get; set; }
        private string Login { get; set; }
        private int IdClub { get; set; }
        private int IdAccesRight { get; set; }

        public User(int id, string name, string lastname, string pwd, string login, int idclub, int idaccsright)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            PWD = pwd;
            Login = login;
            IdClub = idclub;
            IdAccesRight = idaccsright;
        }


    }
}
