/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 7/09/2017
 * Hora: 7:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Linq;

namespace ElevenSQLite.ElevenCore
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario : Persistent
	{
		public Usuario()
		{
		}
		public string NombreUsuario { set; get;}
		public string Clave { set; get;}
		
		public void Save()
		{
			using( ElevenContext db = new  ElevenContext())
			{
				db.Usuario.Add(this);
				db.SaveChanges();
			}
		}
		public void Update(){}
		public static Usuario Login(string userName, string password)
		{
			using(var db = new ElevenContext())
			{ 
				return db.Usuario.Where(u => u.NombreUsuario.Equals(userName) && u.Clave.Equals(password) ).FirstOrDefault();
			}
		}
		public static Usuario Get(long id)
 		{
 			
 			using(var db = new ElevenContext())
			{ 
 				return db.Usuario.Where(u => u.ID == id).FirstOrDefault();
			}
 		}
		public static Usuario FindByUsername(string userName)
 		{
 			
 			using(var db = new ElevenContext())
			{ 
 				return db.Usuario.Where(u => u.NombreUsuario.Equals(userName)).FirstOrDefault();
			}
 		}
		public static BindingList<Usuario> GetAll () 
		{
			BindingList<Usuario> lista = new BindingList<Usuario>();
			using(var db = new ElevenContext())
			{  
				foreach( var tmp in db.Usuario)
				{
					lista.Add(tmp);
				}
				db.Dispose();
			}
			return lista;
		}
	}
}
