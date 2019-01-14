namespace AppSimple.DAL
{
	using AppSimple.BO;
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class AppSimpleContext : DbContext
	{
		// Your context has been configured to use a 'AppSimpleContext' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'AppSimple.AppSimpleContext' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'AppSimpleContext' 
		// connection string in the application configuration file.
		public AppSimpleContext()
			: base("name=DefaultConnection")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
		public virtual DbSet<Person> People { get; set; }
		public virtual DbSet<ClassRoom> ClassRooms { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Professor> Professors { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}