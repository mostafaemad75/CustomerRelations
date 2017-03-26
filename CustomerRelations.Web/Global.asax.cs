using CustomerRelations.Data;
using CustomerRelations.Model;
using CustomerRelations.Web.App_Start;
using CustomerRelations.Web.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomerRelations.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            System.Data.Entity.Database.SetInitializer(new CustomerRelationsSeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            // Autofac and Automapper configurations
            Bootstrapper.Run();
            
        }

        void Session_Start(object sender, EventArgs e)
        {
            var resourceList = new List<StringResource>();
            var connectionString = ConfigurationManager.ConnectionStrings["CustomerRelationsEntities"].ConnectionString.ToString();
            var connection = new SqlConnection(connectionString);
            var sqlQuery = "SELECT * FROM StringResource";
            var sqlCommand = new SqlCommand(sqlQuery, connection);
            connection.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    resourceList.Add(new StringResource()
                    {
                        cultureCode = reader["cultureCode"].ToString(),
                        resourceKey = reader["resourceKey"].ToString(),
                        resourceValue = reader["resourceValue"].ToString()
                    });
                }
            }
            connection.Close();
            Session["ResourceList"] = resourceList;
        }
    }
}
