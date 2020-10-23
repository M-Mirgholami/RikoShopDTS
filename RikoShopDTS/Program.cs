using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;

namespace RikoShopDTS
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            try
            {
                //dapper test
                var db = new SqlConnection(secrets.ConnectionString);
                db.Open();
                var ddd = db.Query<object>("select * from users");


                //woocommerce api test
                RestAPI rest = new RestAPI(secrets.SiteAddress, secrets.ConsumerKey, secrets.ConsumerPass);
                WCObject wc = new WCObject(rest);

                //Get all products
                var products = await wc.Product.GetAll();

                return 0;
            }
            catch (Exception ex)
            {
                var msg = ex.Message.UnicodeToString();
                return 0;
            }
        }
    }
}