using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SC.Common.Util;
using SC.Models;
using SC.Services;
using System.Web.Mvc;

namespace SC.Controllers
{
    public class MAccountController : Controller
    {
        private static ViewResultUitl viewResult = new ViewResultUitl("Mobile", "Account");

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            ViewBag.Account = new AccountDataModel();
            ViewBag.Merchant = new MerchantDataModel();
            return viewResult.View(this, "Main");
        }

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            ViewBag.Account = new AccountDataModel();
            return viewResult.View(this, "Login");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult DoLogin(AccountDataModel model)
        {
            var modelResult = AccountService.Instance.Login(model);
            ViewBag.Account = new AccountDataModel();
            if (modelResult != null)
            {
                ViewBag.Account = modelResult;
                SessionUtil.AccountId = int.Parse(modelResult.Id.ToString());
                return viewResult.View(this, "Detail");
            }
            ViewBag.Account = modelResult;
            return viewResult.View(this, "Login");
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult LoginOut(string id)
        {
            System.Web.HttpContext.Current.Session[id] = string.Empty;
            return viewResult.View(this, "Main");
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            ViewBag.Account = new AccountDataModel();
            return viewResult.View(this, "Main");
        }

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult DoAdd(AccountDataModel model)
        {
            model.Mobphone = "13008862853";
            model.Createtime = DateTime.Now;
            AccountService.Instance.Create(model);
            return viewResult.View(this, "Main");
        }

        /// <summary>
        /// 添加我的商家
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public ActionResult AddFavoriteMerchant(string name, string phone, string comment) //Entity
        {
            return null;

        }



        /// <summary>
        /// 用户中心
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            int accountId = SessionUtil.AccountId;
            AccountDataModel model = new AccountDataModel();
            model = AccountService.Instance.GetModel(accountId);
            ViewBag.Account = model;
            return viewResult.View(this, "Detail");
        }
    }
}
