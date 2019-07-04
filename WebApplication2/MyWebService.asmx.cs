using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService: System.Web.Services.WebService
    {

        public MyWebService()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }
        [WebMethod]
        public string SaveData(string myjson) //save data to database
        {
            MyWebService service = new MyWebService();
            var mydata = JsonConvert.DeserializeObject<List<Product>>(myjson);// parse json string to object.
            
            return myjson;
        }
    }
}
