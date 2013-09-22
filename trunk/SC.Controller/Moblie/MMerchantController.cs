using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SC.Common.Util;
using SC.Services;

namespace SC.Controllers.Moblie
{
    public class MMerchantController : Controller
    {
        private static ViewResultUitl viewResult = new ViewResultUitl("Mobile","Merchant");
        /// <summary>
        /// 返回小区，对应的服务种类的所有商家
        /// </summary>
        /// <param name="communityId"></param>
        /// <returns></returns>
        public ActionResult List(string communityId, string serviceCategoryId)
        {
            return null;
        }

        public ActionResult Detail(string Id)
        {
            return null;
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
