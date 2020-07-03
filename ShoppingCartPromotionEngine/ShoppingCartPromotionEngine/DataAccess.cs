using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using ShoppingCartPromotionEngine.Model;
using System.Data.SqlClient;
using ShoppingCartPromotionEngine.App_Data;
using AutoMapper;
using AutoMapper.Configuration.Conventions;

namespace ShoppingCartPromotionEngine
{
    class DataAccess
    {
        SqlCommand sqlCmdObj;        
        
        //private static readonly string connectionString = ConfigurationManager.AppSettings["defaultConnectionString"].ToString();

        //public GetCartDetails(int Cart)
        public List<PromotionDTO> GetActivePromotions()
        {
            List<PromotionDTO> promotionListObj = new List<PromotionDTO>();
            PromotionDTO promotionObj;
            ShoppingCartDBEntities dbEntitiesObj = new ShoppingCartDBEntities();
            var listObj = dbEntitiesObj.Promotions.ToList();
            foreach(var item in listObj)
            {
                promotionObj = new PromotionDTO();
                promotionObj.PromotionId = item.Promotion_Id;
                promotionObj.PromotionCode = item.Promotion_Code;
                promotionObj.CodeStatus = item.Code_Status;
                promotionListObj.Add(promotionObj);
            }

            return promotionListObj;            
        }

    }
}
