using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Viscometer
{
    public static class Tester
    {
        public static bool IsAuthorization { get; private set; } = false;
        public static short Id { get; private set; } = 0;
        public static string Name { get; private set; } = string.Empty;
        public static short? IdSub { get; private set; } = null;
        public static string NameSub { get; private set; } = string.Empty;
        public static string Rights { get; private set; } = "MyOrders";

        public static bool Authorization(string NameUser, string Password)
        {
            DataTable dt = DataBase.GetData("SELECT [idTester],[nameTester],[Password],[idSubdiv],[idRights] FROM [dbo].[Testers] WHERE [nameTester]='" + NameUser.Trim() + "'");
            if (dt.Rows.Count < 1) return false;

            if (dt.Rows[0].Field<string>("Password") == Password)
            {
                IsAuthorization = true;
                Id = dt.Rows[0].Field<short>("idTester");
                Name = dt.Rows[0].Field<string>("nameTester");
                IdSub = dt.Rows[0].Field<short?>("idSubdiv");

                if (IdSub != null)
                {
                    NameSub = DataBase.GetData("SELECT [nameSubdiv] FROM [Subdivisions] WHERE [idSubdiv]='" + IdSub + "'").Rows[0].Field<string>("nameSubdiv");
                }

                short idRights = dt.Rows[0].Field<short>("idRights");
                Rights = DataBase.GetData("SELECT [nameRights] FROM [Rights] WHERE [idRights]='" + idRights.ToString() + "'").Rows[0].Field<string>("nameRights");
                return true;
            }

            return false;
        }
    }
}
