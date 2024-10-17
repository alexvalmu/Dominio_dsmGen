
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm;
using Dominio_dsmGen.Infraestructure.Repository.Dominio_dsm;
using Dominio_dsmGen.Infraestructure.CP;
using Dominio_dsmGen.ApplicationCore.Exceptions;

using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;
using Dominio_dsmGen.Infraestructure.Repository;
using Dominio_dsmGen.Infraestructure.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception)
        {
                throw;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        try
        {
                // Initialising  CENs
                UsuarioRepository usuariorepository = new UsuarioRepository ();
                UsuarioCEN usuariocen = new UsuarioCEN (usuariorepository);
                PedidoRepository pedidorepository = new PedidoRepository ();
                PedidoCEN pedidocen = new PedidoCEN (pedidorepository);
                LineaPedidoRepository lineapedidorepository = new LineaPedidoRepository ();
                LineaPedidoCEN lineapedidocen = new LineaPedidoCEN (lineapedidorepository);
                Usuario_adminRepository usuario_adminrepository = new Usuario_adminRepository ();
                Usuario_adminCEN usuario_admincen = new Usuario_adminCEN (usuario_adminrepository);
                ArticuloRepository articulorepository = new ArticuloRepository ();
                ArticuloCEN articulocen = new ArticuloCEN (articulorepository);
                FotoRepository fotorepository = new FotoRepository ();
                FotoCEN fotocen = new FotoCEN (fotorepository);
                MarcaRepository marcarepository = new MarcaRepository ();
                MarcaCEN marcacen = new MarcaCEN (marcarepository);
                DireccionRepository direccionrepository = new DireccionRepository ();
                DireccionCEN direccioncen = new DireccionCEN (direccionrepository);



                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/


                usuariocen.Nuevo ("avm157@alu.ua.es", "Alex", new DateTime (2004, 12, 12), "1234");
                Console.WriteLine ("Usuario creado correctamente");


                if (usuariocen.Login ("avm157@alu.ua.es", "1234") != null) {
                        Console.WriteLine ("Login correcto");
                }
                else{
                        Console.WriteLine ("ERROR en el Login");
                };

                marcacen.Nuevo("Nike");

                decimal precio = 100.00m;
                int articulo1 = articulocen.Nuevo("Camiseta", precio.ToString(), "camiseta manga corta", Talla_artEnum.Talla_35, "lavarla con agua fria", true, "cones verdadera","Nike",50);
                Console.WriteLine("Articulo creado correctamente");

                Console.WriteLine("Cantidad en stock" + articulocen.DamxeALL);

                articulocen.Dec_stock(articulo1,10);
                Console.WriteLine("se han decrementado la cantidad de articulos correctamente");



                /*PROTECTED REGION END*/
            }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw;
        }
}
}
}
