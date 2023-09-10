using SQLite;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Survey_Crud_4216528.Models

{

    public class TodoItem

    {

        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }

        public string FavoriteTeam { get; set; }

        public DateTime Birthdate { get; set; }

        public bool Done { get; set; }

    }

}
