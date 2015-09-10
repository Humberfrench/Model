using System.Web.Script.Serialization;

namespace Models
{
    public static class Extends
    {
        //public new override static string ToString(this object oDado)
        //{
        //    var oObject = oDado.GetType().GetField("Nome");

        //    return oObject.ToString();
        //}

        public static string ToJSON(this object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }
    }
}