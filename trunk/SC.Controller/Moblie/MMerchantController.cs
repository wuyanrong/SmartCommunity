using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SC.Common.Util;
using SC.Services;
using SC.Models;

namespace SC.Controllers.Moblie
{
    public class MMerchantController : Controller
    {
        private static ViewResultUitl viewResult = new ViewResultUitl("Mobile", "Merchant");
        /// <summary>
        /// 返回小区，对应的服务种类的所有商家
        /// </summary>
        /// <param name="communityId"></param>
        /// <returns></returns>
        public ActionResult List(string communityId, string serviceCategoryId)
        {
            return null;
        }

        public ActionResult Detail()
        {
            int Id = SessionUtil.AccountId;
            MerchantDataModel model = MerchantService.Instance.GetDetail(Id);
            return viewResult.View(this, "Detail", model);
        }

        public ActionResult Edit(string Id)
        {
            MerchantDataModel model = MerchantService.Instance.GetDetail(int.Parse(Id));
            return viewResult.View(this, "Edit", model);
        }

        public ActionResult DoEdit(MerchantDataModel model)
        {
            MerchantService.Instance.Update(model);
            MerchantDataModel modelResult = MerchantService.Instance.GetDetail((int)model.Id);
            return viewResult.View(this, "Detail", modelResult);
        }

        /// <summary>
        /// 我的商家
        /// </summary>
        /// <returns></returns>
        public ActionResult GetFavoriteMerchant()
        {
            int accountId = SessionUtil.AccountId;
            var model = MerchantService.Instance.GetFavoriteMerchant(accountId);
            return viewResult.View(this, "FavoriteList", model);
        }
    }
}
