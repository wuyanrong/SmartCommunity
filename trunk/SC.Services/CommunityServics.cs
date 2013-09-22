using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Models;
using Evt.Framework.Common;
using SC.Common.DataAccess;
using System.Data;

namespace SC.Services
{
    public class CommunityServics : BaseService<CommunityServics>
    {
        public CommunityViewModel GetDetail(string communityId)
        {
            int id = 0;
            int.TryParse(communityId, out id);
            string condition = id != 0 ? " WHERE ID=@ID " : " WHERE Name=@Name ";
            string sql = @"SELECT ID,  Name,ServiceCategoryIds FROM dbo.Community " + condition;
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ID", communityId);
            pc.Add("Name", communityId);
            var dt = DbUtil.DataManager.Current.IData.ExecuteDataTable(sql, pc);
            CommunityViewModel model = new CommunityViewModel();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    model.CommunityId = int.Parse(item["ID"].ToString());
                    model.CommunityName = item["Name"].ToString();
                    model.ServiceCategory = CategoryService.Instance.GetCommunityCategory(item["ServiceCategoryIds"].ToString().Split(','));
                }
            }
            return model;
        }



    }
}
