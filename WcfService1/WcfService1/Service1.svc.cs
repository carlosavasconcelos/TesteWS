using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Lista> GetDados()
        {

            
            return new List<Lista>();
        
        }


       
        public bool SetDados(string latitude , string longitude , string status , string date )
        {
            try
            {
                using (var db = new db7e70c0cf078247eab177a5b0012f25efEntities())
                {
                    tbDados data = new tbDados();
                    data.latitude = latitude;
                    data.longitude = longitude;
                    data.status = status;
                    data.data = date;

                    db.tbDados.Add(data);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            // insert
           

           
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
