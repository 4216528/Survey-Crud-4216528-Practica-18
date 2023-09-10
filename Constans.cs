using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Survey_Crud_4216528

{

    public class Constans

    {

        public const string DatabaseFilename = "TodoSQLite.db3";

        //define las configuraciones o banderas que se usaran en este caso tenemos tres, las cuales se aplicaran al abrir la base de datos//

        public const SQLite.SQLiteOpenFlags Flags =

            //con esto la base de datos se abrira para lectura y escitura//

            SQLite.SQLiteOpenFlags.ReadWrite |

            //con esto se creara la base si esta no esta creada//

            SQLite.SQLiteOpenFlags.Create |

            //con esto se dara uso al cache compartido de la base//
            SQLite.SQLiteOpenFlags.SharedCache;

        //usamos DatabasePath la cual es una propiedad estatica, se hace uso de la clase Path.Combine la cual reune el directorio de los datos//

        //(FileSystem.AppDataDirectory, DatabaseFilename); esto realiza la ruta completa donde se accedera o almacenara en la base de datos//

        public static string DatabasePath =>

            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    }

}
