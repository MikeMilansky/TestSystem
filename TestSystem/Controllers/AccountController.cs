using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestSystem.Models;

namespace TaskManager.Controllers
{
    public partial class AccountController : Controller
    {

        public AccountController()
        {
        }

        public virtual ActionResult Login()
        {
            return View();            
        }

        [HttpPost]        
        public virtual ActionResult Login(LoginModel model)
        {
             if (ModelState.IsValid)
            {
                model.TryToLogin();
            }
             return RedirectToAction(MVC.Home.Actions.Index());


        }

        //public virtual ActionResult Registration()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public virtual ActionResult Registration(RegistrationModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (model.TryToRegister())
        //            {
        //                return RedirectToAction(MVC.Account.Success());
        //            }
        //            return RedirectToAction(MVC.Account.Failure());
        //        }
        //        return View(new RegistrationModel());
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error");
        //    }
            
        //}

        //public virtual ActionResult PasswordReset()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public virtual ActionResult PasswordReset(ResetPasswordModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (model.ResetPassword())
        //            {
        //                return View(MVC.Account.Views.ResetSuccess);
        //            }
        //            return View(MVC.Account.Views.ResetFailed);
        //        }
        //        return View(new ResetPasswordModel());
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error");
        //    }

        //}

        //public virtual ActionResult Success()
        //{
        //    return View();
        //}

        //public virtual ActionResult Failure()
        //{
        //    return View();
        //}

        //[Authorize]
        //public virtual ActionResult Logout()
        //{
        //    try
        //    {
        //        FormsAuthentication.SignOut();
        //        return RedirectToAction(MVC.Account.Login());
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error");
        //    }

        //}

        //[Authorize(Roles = "admin")]
        //public virtual ActionResult AdminTools()
        //{
        //    try
        //    {
        //        var model = AccountModel.GetAll();
        //        return View(model);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error(ex.Message);
        //        return View("Error");
        //    }

        //}

        //[Authorize(Roles = "admin")]
        //public virtual JsonResult AddRole(AccountModel model)
        //{
        //    bool success = model.AddRole();
        //    return Json(success, JsonRequestBehavior.AllowGet);
        //}

        //[Authorize(Roles = "admin")]
        //public virtual JsonResult RemoveRole(AccountModel model)
        //{
        //    bool success = model.RemoveRole();             
        //    return Json(success, JsonRequestBehavior.AllowGet);
        //}

        //[Authorize(Roles = "admin")]
        //public virtual JsonResult DeleteAccount(int userId)
        //{
        //    bool success = AccountModel.DeleteAccount(userId);
        //    return Json(success, JsonRequestBehavior.AllowGet);
        //}

        //[Authorize]
        //[ChildActionOnly]
        //public virtual ActionResult FLName(int userId)
        //{
        //    var model = Models.MemberShortModel.GetName(userId);
        //    return PartialView(model);
        //}

        //[Authorize]
        //public virtual ActionResult ChangePass(int userId)
        //{
        //    if (Request.IsAjaxRequest())
        //    {
        //        return PartialView(new ChangePassModel() { UserID = userId });
        //    }
        //    return View(new ChangePassModel() { UserID = userId });
        //}

        //[HttpPost]
        //[Authorize]
        //public virtual ActionResult ChangePass(ChangePassModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (model.ChangePass())
        //            {
        //                log.Info("Password changed for userID:" + model.UserID);
        //                return PartialView("SuccessChangePassword");
        //            }
        //            log.Info("Changing password was failed for userID:" + model.UserID);
        //            return PartialView(new ChangePassModel());
        //        }
        //        return PartialView(new ChangePassModel());
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error(ex.Message);
        //        return View("Error");
        //    }

        //}
    }
}
