using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();

            juego.Inicio();

            Console.Read();

        }


        public class Juego
        {
            public void Inicio()
            {
                short op, opp, idGenero, idDistribuidora, idDesarrolladora;
                string nombre, Pais;
                byte rating, popularidad;
                bool multi;

                Console.Write("\n");
                Console.Write("Ingrese que desea hacer: \n" +
                "1- Consultar\n" +
                "2- Insertar\n" +
                "3- Modificar\n" +
                "4- Eliminar\n" +
                "\n" +
                "");

                op = Convert.ToInt16(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Write("\n");
                        Console.Write("Ingrese que desea consultar: \n" +
                        "1- Videojuego\n" +
                        "2- Genero\n" +
                        "3- Desarrolladora\n" +
                        "4- Distribuidora\n" +
                        "\n" +
                        "");

                        opp = Convert.ToInt16(Console.ReadLine());

                        switch (opp)
                        {
                            case 1:
                                obtenerVideojuego();
                                break;
                            case 2:
                                LeerGenero();
                                break;
                            case 3:
                                LeerDes_Dis(false);
                                break;
                            case 4:
                                LeerDes_Dis(true);
                                break;
                        }

                        break;

                    case 2:

                        Console.Write("\n");
                        Console.Write("Ingrese que desea insertar: \n" +
                        "1- Videojuego\n" +
                        "2- Genero\n" +
                        "3- Desarrolladora\n" +
                        "4- Distribuidora\n" +
                        "\n" +
                        "");

                        opp = Convert.ToInt16(Console.ReadLine());

                        Console.Write("\n");

                        switch (opp)
                        {
                            case 1:
                                Console.Write("\n");
                                Console.Write("Ingrese Nombre: ");
                                nombre = Console.ReadLine();
                                Console.Write("Ingrese Id del Genero: \n");
                                LeerGenero();
                                Console.Write("----------------------------------------\n");
                                idGenero = Convert.ToByte(Console.ReadLine());
                                Console.Write("Ingrese Id del Desarrollador: \n");
                                LeerDes_Dis(false);
                                Console.Write("----------------------------------------\n");
                                idDesarrolladora = Convert.ToByte(Console.ReadLine());
                                Console.Write("Ingrese Id del Distribuidor: \n");
                                LeerDes_Dis(true);
                                Console.Write("----------------------------------------\n");
                                idDistribuidora = Convert.ToByte(Console.ReadLine());
                                Console.Write("Ingrese Rating: \n" +
                                    "1- 5 Estrellas\n" +
                                    "2- 4 Estrellas\n" +
                                    "3- 3 Estrellas\n" +
                                    "4- 2 Estrellas\n" +
                                    "5- 1 Estrella\n");
                                Console.Write("----------------------------------------\n");
                                rating = Convert.ToByte(Console.ReadLine());
                                Console.Write("Es Multijugador?: \n" +
                                    "1- Si\n" +
                                    "2- No\n");
                                if (Console.ReadLine().Equals("1"))
                                {
                                    multi = true;
                                }
                                else
                                {
                                    multi = false;
                                }
                                

                                InsertaVideojuego(nombre, idGenero, idDesarrolladora, idDistribuidora, rating, multi);

                                Console.Write("\n");
                                Console.WriteLine("=====================================");
                                Console.WriteLine("Nombre: " + nombre);

                                Console.WriteLine("Genero: " + nombreById(1, idGenero));
                                Console.WriteLine("Desarrollador: " + nombreById(2, idDesarrolladora));
                                Console.WriteLine("Distribuidor: " + nombreById(3, idDistribuidora));

                                Console.WriteLine("Rating: " + obtenerRating(rating));

                                if (multi == true)
                                {
                                    Console.WriteLine("Tiene Multijugador");
                                }
                                else
                                {
                                    Console.WriteLine("No tiene Multijugador");
                                }

                                Console.Write("\n");
                                Console.WriteLine("El Videojuego se insertó con éxito!");
                                Console.WriteLine("====================================");


                                break;
                            case 2:
                                Console.Write("\n");
                                Console.Write("Ingrese Nombre: ");
                                nombre = Console.ReadLine();
                                Console.Write("Ingrese Popularidad: \n" +
                                    "1-Alta\n" +
                                    "2-Media\n" +
                                    "3-Baja\n");
                                popularidad = Convert.ToByte(Console.ReadLine());

                                InsertaGenero(nombre, popularidad);

                                Console.Write("\n");
                                Console.WriteLine("----------------");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Popularidad: " + popularidad);
                                Console.Write("\n");
                                Console.WriteLine("El Género se insertó con éxito!");
                                Console.WriteLine("----------------");

                                break;
                            case 3:
                                Console.Write("\n");
                                Console.Write("Ingrese Nombre: ");
                                nombre = Console.ReadLine();
                                Console.Write("Ingrese Popularidad: \n" +
                                    "1-Alta\n" +
                                    "2-Media\n" +
                                    "3-Baja\n");
                                popularidad = Convert.ToByte(Console.ReadLine());
                                Console.Write("Ingrese Pais: ");
                                Pais = Console.ReadLine();

                                InsertaDes_Dis(true, nombre, popularidad, Pais);

                                Console.Write("\n");
                                Console.WriteLine("----------------");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Popularidad: " + popularidad);
                                Console.WriteLine("Pais: " + Pais);
                                Console.Write("\n");
                                Console.WriteLine("La Desarrolladora se insertó con éxito!");
                                Console.WriteLine("----------------");

                                break;
                            case 4:
                                Console.Write("\n");
                                Console.Write("Ingrese Nombre: ");
                                nombre = Console.ReadLine();
                                Console.Write("Ingrese Popularidad: \n" +
                                    "1-Alta\n" +
                                    "2-Media\n" +
                                    "3-Baja\n");
                                popularidad = Convert.ToByte(Console.ReadLine());
                                Console.Write("Ingrese Pais: ");
                                Pais = Console.ReadLine();

                                InsertaDes_Dis(false, nombre, popularidad, Pais);

                                Console.Write("\n");
                                Console.WriteLine("----------------");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Popularidad: " + popularidad);
                                Console.WriteLine("Pais: " + Pais);
                                Console.Write("\n");
                                Console.WriteLine("La Distribuidora se insertó con éxito!");
                                Console.WriteLine("----------------");

                                break;
                        }

                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.Read();
                        break;

                    default:
                        Console.Write("No digito una opcion valida");
                        break;
                }

            }

            #region METODOS

            public string nombreById(byte op, int id)
            {
                string nombre = "";

                using (PracticasEntities db = new PracticasEntities())
                {

                    switch (op)
                    {
                        case 1:
                            var tblGenero = db.Genero;

                            foreach (var i in tblGenero)
                            {
                                if (i.IdGenero == id)
                                {
                                    nombre = i.Nombre;

                                    break;
                                }
                            }
                            break;

                        case 2:
                            var tblDes = db.Desarrolladora;

                            foreach (var i in tblDes)
                            {
                                if (i.IdDesarrollador == id)
                                {
                                    nombre = i.Nombre;

                                    break;
                                }
                            }
                            break;

                        case 3:

                            var tblDis = db.Distribuidora;

                            foreach (var i in tblDis)
                            {
                                if (i.IdDistribuidor == id)
                                {
                                    nombre = i.Nombre;

                                    break;
                                }
                            }
                            break;
                    }
                }

                return nombre;
            }

            public string obtenerRating(int? num) 
            {
                string estrellas = "";
                switch (num)
                {
                    case 1:
                        estrellas = "5 Estrellas";
                        break;

                    case 2:
                        estrellas = "4 Estrellas";
                        break;

                    case 3:
                        estrellas = "3 Estrellas";
                        break;

                    case 4:
                        estrellas = "2 Estrellas";
                        break;

                    case 5:
                        estrellas = "1 Estrella";
                        break;
                }

                return estrellas;
            }

            public void obtenerVideojuego() 
            {
                using (PracticasEntities db = new PracticasEntities())
                {

                    /*------------LISTAR INFORMACION DESDE LA BASE DE DATOS--------------*/

                    //Creo objeto dinamico de tabla Genero
                    var tblVideojuego = db.Videojuego;

                    //Itero la informacin de la tabla Genero para obtener los nombres
                    foreach (var i in tblVideojuego)
                    {
                        Console.WriteLine("======================================");
                        Console.WriteLine("Id: " + i.IdVideojuego);
                        Console.WriteLine("Nombre: " + i.Nombre);
                        Console.WriteLine("Genero: " + nombreById(1, i.IdGenero));
                        Console.WriteLine("Desarrollador: " + nombreById(2, i.IdDesarrollador));
                        Console.WriteLine("Distribuidor: " + nombreById(3, i.IdDistribuidor));

                        Console.WriteLine("Rating: " + obtenerRating(i.Rating));

                        if (i.Mulitjugador == true)
                        {
                            Console.WriteLine("Tiene Multijugador");
                        }
                        else
                        {
                            Console.WriteLine("No tiene Multijugador");
                        }
                        Console.WriteLine("======================================");
                    }
                }
            }

            public void LeerGenero()
            {
                //Se crea la instacia de la concexion por medio de Entity Framework
                using (PracticasEntities db = new PracticasEntities())
                {

                    /*------------LISTAR INFORMACION DESDE LA BASE DE DATOS--------------*/

                    //Creo objeto dinamico de tabla Genero
                    var tblGenero = db.Genero;

                    //Itero la informacin de la tabla Genero para obtener los nombres
                    foreach (var i in tblGenero)
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("Id: " + i.IdGenero);
                        Console.WriteLine("Nombre: " + i.Nombre);
                        Console.WriteLine("Popularidad: " + i.Popularidad);
                        Console.WriteLine("----------------");
                    }
                }
            }

            public void LeerDes_Dis(bool op)
            {
                if (op == true)
                {
                    //Se crea la instacia de la concexion por medio de Entity Framework
                    using (PracticasEntities db = new PracticasEntities())
                    {

                        /*------------LISTAR INFORMACION DESDE LA BASE DE DATOS--------------*/

                        //Creo objeto dinamico de tabla Genero
                        var tblDistribuidora = db.Distribuidora;

                        //Itero la informacin de la tabla Genero para obtener los nombres
                        foreach (var i in tblDistribuidora)
                        {
                            Console.WriteLine("----------------");
                            Console.WriteLine("Id: " + i.IdDistribuidor);
                            Console.WriteLine("Nombre: " + i.Nombre);
                            Console.WriteLine("Popularidad: " + i.Popularidad);
                            Console.WriteLine("Popularidad: " + i.Pais);
                            Console.WriteLine("----------------");
                        }
                    }
                }
                else
                {
                    using (PracticasEntities db = new PracticasEntities())
                    {
                        var tblDesarrolladora = db.Desarrolladora;

                        foreach (var i in tblDesarrolladora)
                        {
                            Console.WriteLine("----------------");
                            Console.WriteLine("Id: " + i.IdDesarrollador);
                            Console.WriteLine("Nombre: " + i.Nombre);
                            Console.WriteLine("Popularidad: " + i.Popularidad);
                            Console.WriteLine("Popularidad: " + i.Pais);
                            Console.WriteLine("----------------");
                        }
                    }
                }

            }

            public void InsertaVideojuego(string Nombre, short idGenero, short idDesarrolladora, short idDistribuidora, byte rating, bool multijugador)
            {
                //Se crea la instacia de la concexion por medio de Entity Framework
                using (PracticasEntities db = new PracticasEntities())
                {

                    /*------------INSERTAR INFORMACION A LA BASE DE DATOS--------------*/

                    //Instancio la tabla genero para el insert
                    Videojuego insertVideojuego = new Videojuego();

                    //Preparo los datos a insertar a la tabla
                    insertVideojuego.Nombre = Nombre;
                    insertVideojuego.IdGenero = idGenero;
                    insertVideojuego.IdDistribuidor = idDistribuidora;
                    insertVideojuego.IdDesarrollador = idDesarrolladora;
                    insertVideojuego.Rating = rating;
                    insertVideojuego.Mulitjugador = multijugador;

                    //Hago el insert a la tabla
                    db.Videojuego.Add(insertVideojuego);
                    //Ejecuto
                    db.SaveChanges();
                }
            }

            public void InsertaGenero(string Nombre, byte Popularidad)
            {
                //Se crea la instacia de la concexion por medio de Entity Framework
                using (PracticasEntities db = new PracticasEntities())
                {

                    /*------------INSERTAR INFORMACION A LA BASE DE DATOS--------------*/

                    //Instancio la tabla genero para el insert
                    Genero insertGenero = new Genero();

                    //Preparo los datos a insertar a la tabla
                    insertGenero.Nombre = Nombre;
                    insertGenero.Popularidad = Popularidad;

                    //Hago el insert a la tabla
                    db.Genero.Add(insertGenero);
                    //Ejecuto
                    db.SaveChanges();
                }
            }

            public void InsertaDes_Dis(bool op, string Nombre, byte Popularidad, string Pais)
            {

                if (op == true)
                {
                    //Se crea la instacia de la concexion por medio de Entity Framework
                    using (PracticasEntities db = new PracticasEntities())
                    {

                        /*------------INSERTAR INFORMACION A LA BASE DE DATOS--------------*/

                        //Instancio la tabla genero para el insert
                        Desarrolladora insertDes = new Desarrolladora();

                        //Preparo los datos a insertar a la tabla
                        insertDes.Nombre = Nombre;
                        insertDes.Popularidad = Popularidad;
                        insertDes.Pais = Pais;

                        //Hago el insert a la tabla
                        db.Desarrolladora.Add(insertDes);
                        //Ejecuto
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (PracticasEntities db = new PracticasEntities())
                    {

                        /*------------INSERTAR INFORMACION A LA BASE DE DATOS--------------*/

                        Distribuidora insertDis = new Distribuidora();

                        insertDis.Nombre = Nombre;
                        insertDis.Popularidad = Popularidad;
                        insertDis.Pais = Pais;

                        db.Distribuidora.Add(insertDis);

                        db.SaveChanges();
                    }
                }
            }

            #endregion
        }
    }
}
