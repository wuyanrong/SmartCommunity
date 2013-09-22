using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Models;
using SC.Common.DataAccess;
using Evt.Framework.Common;
using System.Data;


namespace SC.Services
{
    public class MerchantService : BaseService<MerchantService>
    {

        public void Add(AccountDataModel model)
        {
            string sql = "insert into cccx";
            //DbUtil.DataManager.Current.IData.
        }

        /// <summary>
        /// 获取特定小区，特定类别的所有商家
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="communityId"></param>
        /// <returns></returns>
        public List<MerchantDataModel> GetList(int categoryId, int communityId)
        {
            return null;
        }


        public MerchantDataModel GetDetail(int merchantId)
        {
            var dt = DbUtil.DataManager.Current.Retrieve(new MerchantDataModel() { Id = merchantId });
            MerchantDataModel model =new  MerchantDataModel();
            if (dt.Rows.Count > 0)
            {
                model.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            }
            return model;
        }

        /// <summary>
        /// 根据用户Id,获取收藏的商家
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<MerchantDataModel> GetFavoriteMerchant(int accountId)
        {
            string sql = @"
SELECT
	m.ID,
	m.AccountId,
	Name,
	City,
	CommunityIds,
	ServiceCategoryName,
	Address,
	MobPhone,
	TelPhone,
	ServiceRadius,
	IsDoorService,
	ServiceDes
FROM
	Merchant AS m
INNER JOIN Favorite AS f ON m.ID = f.MerchantId
WHERE
	M.AccountId = @accountId
";
            ParameterCollection pc = new ParameterCollection();
            pc.Add("accountId", accountId);
            var dt = DbUtil.DataManager.Current.IData.ExecuteDataTable(sql, pc);
            List<MerchantDataModel> list = new List<MerchantDataModel>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    MerchantDataModel model = new MerchantDataModel()
                    {
                        Id = int.Parse(item["ID"].ToString()),
                        Name = item["Name"].ToString(),
                        Telphone = item["TelPhone"].ToString()
                    };
                    list.Add(model);
                }
            }
            return list;
        }

        public void Update(MerchantDataModel model)
        {
            int result = DbUtil.DataManager.Current.Update(model);
        }
    }
}
