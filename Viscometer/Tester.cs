using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static Viscometer.Tester;

namespace Viscometer
{
    public static class Tester
    {
        public static bool IsAuthorization { get; private set; } = false;
        public static short Id { get; private set; }
        public static string Name { get; private set; } = string.Empty;
        public static short IdSub { get; private set; }
        public static string NameSub { get; private set; } = string.Empty;
        public static Rights Right { get; private set; } = Rights.MyOrders;

        public static bool Authorization(string NameUser, string Password)
        {
            DataTable dt = DataBase.GetData("SELECT [idTester],[nameTester],[Password],[idSubdiv],[idRights] FROM [dbo].[Testers] WHERE [nameTester]='" + NameUser.Trim() + "'");
            if (dt.Rows.Count < 1) return false;

            if (dt.Rows[0].Field<string>("Password") == Password)
            {
                IsAuthorization = true;
                Id = dt.Rows[0].Field<short>("idTester");
                Name = dt.Rows[0].Field<string>("nameTester") ?? string.Empty;
                IdSub = dt.Rows[0].Field<short>("idSubdiv");
                NameSub = DataBase.GetData("SELECT [nameSubdiv] FROM [Subdivisions] WHERE [idSubdiv]='" + IdSub + "'").Rows[0].Field<string>("nameSubdiv") ?? string.Empty;
                Right = (Rights)dt.Rows[0].Field<short>("idRights");
                return true;
            }

            return false;
        }

        public enum Rights
        {
            AllSub = 1,
            MySub = 2,
            MyOrders = 3
        }
    }
}
