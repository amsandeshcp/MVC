using MVC_CRUD.Areas.Customer.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Areas.Customer.Controllers
{
    public class LoginController : Controller
    {
        // GET: Customer/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClsAccountDTO dTOLoginRequest)
        {
            DTOLoginResponse response = new DTOLoginResponse
            {
                Data = dTOLoginRequest
            };
            if (ModelState.IsValid)
            {
                DTOLoginRequest tempdetails = dTOLoginRequest.LoginRequest;

                response.Code = HttpStatusCode.OK;
                response.MSG = "Success";

                ViewBag.ResponseMSG_ClassDetails = response;
                ViewData["ResponseMSG_ClassDetails_ViewData"] = response;
                ViewBag.ResponseMSG = "Success";
                return View();
            }
            response.Code = HttpStatusCode.BadRequest;
            response.MSG = "Error";

            ViewBag.ResponseMSG_ClassDetails = response;
            ViewData["ResponseMSG_ClassDetails_ViewData"] = response;

            ViewBag.ResponseMSG = "Error";
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(ClsAccountDTO dTOCustomerDetailsRegRequest)
        {
            if (ModelState.IsValid)
            {
                var tempdetails = dTOCustomerDetailsRegRequest.SignUpRequest;
            }
            return View(dTOCustomerDetailsRegRequest);
        }
        // GET: Customer/Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //[HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassward(ClsAccountForgetPasswordRequest clsAccountForgetPasswordRequest)
        {
            //JsonResult result = new JsonResult();
            //var data = clsAccountForgetPasswordRequest.Email_Mobile;
            //result = this.Json(JsonConvert.SerializeObject(data), JsonRequestBehavior.AllowGet);
            //return result;

            var MsgStory = "Success";
            return Json(new { status = MsgStory, MSG = "Success from Controller MSG" }, JsonRequestBehavior.AllowGet);
        }

        #region TestCode
        //public ActionResult GetData(int customerID, string fname = "")
        //{
        //    // Initialization.  
        //    JsonResult result = new JsonResult();
        //    DataTable data = new DataTable();

        //    // Load Data.  

        //    // Filter data with input query parameters.  

        //    // Prepare Ajax JSON Data Result.  
        //    result = this.Json(JsonConvert.SerializeObject(data), JsonRequestBehavior.AllowGet);

        //    // Return info.  
        //    return result;
        //}
        #endregion

    }
}
