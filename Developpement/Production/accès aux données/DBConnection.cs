using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.accès_aux_données
{
    class DBConnection
    {
        private string connectionString;
        //Constructor
        public DBConnection()
        {
            Initialize();
        }

        /// <summary>
        /// Initialise les champs et cree un objet connection.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "m2lgestiondesadherents";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" +
           "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

        /// <summary>
        /// La méthode Read retourne un utilisateur en fonction de l'id dans la table.
        /// </summary>
        /// <param name="id">id du fournisseur recherché</param>
        /// <returns></returns>
        public Fournisseur Read(int id)
        {
            Fournisseur leFournisseur = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select_fournisseur", connection);
                // Indique que l'appel SQL sera effectué sur une Procédure Stockée.
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Ajout du paramètre ID afin de ne cibler que ce fournisseur.
                cmd.Parameters.AddWithValue("?in_id", id);
                cmd.Parameters.AddWithValue("?in_page", null);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    // Si le SELECT a retourné une ligne, alors
                    // cela indique que le fournisseur existe.
                    if (dataReader.HasRows)
                    {
                        // Récupération de la ligne retournée par la base.
                        dataReader.Read();

                        // Création d'un objet Fournisseur.
                        leFournisseur = new Fournisseur(
                                id,
                                dataReader.GetString("Nom"),
                                dataReader.GetString("Ville"),
                                dataReader.GetDouble("Tarif")
                            );
                    }
                }
            }

            // Si le fournisseur à l'ID donnée n'existe pas, alors cette exception sera soulevée.
            // Sinon nous retournons le fournisseur récupéré.
            if (leFournisseur == null)
            {
                throw new Exception("Le fournisseur n'existe pas.");
            }
            else
            {
                return leFournisseur;
            }
        }

        /// <summary>
        /// La méthode Reads retourne tous les fournisseurs de la table.
        /// </summary>
        /// <returns>la liste de tous les fournisseurs</returns>
        public List<Fournisseur> Reads(int page)
        {
            List<Fournisseur> LesFournisseur = new List<Fournisseur>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select_fournisseur", connection);
                // Indique que l'appel SQL sera effectué sur une Procédure Stockée.
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Ajout du paramètre ID à NULL afin de récupérer des pages.
                cmd.Parameters.AddWithValue("?in_id", null);
                cmd.Parameters.AddWithValue("?in_page", page);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    // Si la page a été récupérée.
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            LesFournisseur.Add(new Fournisseur(
                                dataReader.GetInt32("id"),
                                dataReader.GetString("Nom"),
                                dataReader.GetString("Ville"),
                                dataReader.GetDouble("Tarif")
                            ));
                        }
                    }

                    dataReader.Close();
                }
            }

            return LesFournisseur;
        }

        /// <summary>
        /// La méthode Insert permet d'insérer une ligne dans la table
        //Fournisseur
        /// </summary>
        public int Insert(string nom, string ville, int tarif)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand("insert_fournisseur", connection);
                // Indique que l'appel SQL sera effectué sur une Procédure Stockée.
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Ajout des paramètres, entrants et celui sortant.
                cmd.Parameters.AddWithValue("?in_nom", nom);
                cmd.Parameters.AddWithValue("?in_ville", ville);
                cmd.Parameters.AddWithValue("?in_tarif", tarif);
                cmd.Parameters.Add(new MySqlParameter("?out_id", MySqlDbType.Int32)).Direction = ParameterDirection.Output;

                // Execute l'INSERT puis retourne l'ID créé.
                if (1 == cmd.ExecuteNonQuery())
                {
                    // Récupération du paramètre OUT.
                    return (int)cmd.Parameters["?out_id"].Value;
                }
                else
                {
                    return 0;
                }
            }
        }

        //Update statement
        public bool Update(Fournisseur f, string nom, string ville, double tarif)
        {
            if (f != null)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("update_fournisseur", connection);
                    // Indique que l'appel SQL sera effectué sur une Procédure Stockée.
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("?in_id", f.getId());
                    cmd.Parameters.AddWithValue("?in_nom", nom);
                    cmd.Parameters.AddWithValue("?in_ville", ville);
                    if (-1 < tarif)
                    {
                        cmd.Parameters.AddWithValue("?in_tarif", tarif);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("?in_tarif", null);
                    }

                    // Execute l'UPDATE et retourne un boolean indiquant si la modification a été appliquée.
                    return (0 < cmd.ExecuteNonQuery());
                }
            }

            return false;
        }

        // Supprime un fournisseur.
        // Cette méthode est idempotente (le résultat ne varie pas suite à une multitude d'appel),
        // elle ne retournera pas d'état.
        //
        // Notez : un fournisseur inexistant ne sera pas supprimé, la base de données SQL fera comme si.
        public void Delete(Fournisseur f)
        {
            if (f != null)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand("delete_fournisseur", connection);
                    // Indique que l'appel SQL sera effectué sur une Procédure Stockée.
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Passage du paramètre ID.
                    cmd.Parameters.AddWithValue("?in_id", f.getId());
                    cmd.ExecuteNonQuery();  // retourne 1 si la ligne a été supprimée, sinon c'est que le fournisseur
                                            // n'existait pas. (cela ne pose aucun souci)
                }
            }
        }
    }
}
