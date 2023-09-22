using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWS
{
    /// <summary>
    /// Summary description for CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal AreaCuadrado(decimal lado)
        {
            Calcular c = new Calcular();
            return c.areaCuadrado(lado);
        }
        [WebMethod]
        public decimal AreaTriangulo (decimal baseT, decimal altura)
        {
            Calcular c = new Calcular();
            return c.areaTriangulo(baseT, altura);
        }
        [WebMethod]
        public double AreaCirculo(double radio)
        {
            Calcular c = new Calcular();
            return c.areaCirculo(radio);
        }
    }
}
