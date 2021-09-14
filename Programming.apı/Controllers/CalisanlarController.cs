
using Programming.DAL;
using System.Collections.Generic;
using System.Web.Http;

namespace Programming.apı.Controllers
{
    public class CalisanlarController : ApiController
    {
        CalisanlarDAL calisanlarDAL = new CalisanlarDAL();

        public IEnumerable<calisanlar> Get()
        {
            return calisanlarDAL.GetAllCalisanlar();
        }

        public calisanlar Post(calisanlar calisan)
        {
           return  calisanlarDAL.CreateCalisanlar(calisan);
        }

        public calisanlar Put(int id, calisanlar calisan)
        {
            return calisanlarDAL.UpdateCalisanlar(id, calisan);
        }

        public void Delete(int id)
        {
            calisanlarDAL.DeleteCalisan(id);
        }
    }
}