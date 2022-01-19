using MVC_CRUD.Areas.Customer.Data;
using System;
using System.Collections.Generic;
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
        public ActionResult Index(DTOLoginRequest dTOLoginRequest)
        {
            DTOLoginResponse response = new DTOLoginResponse
            {
                Data = dTOLoginRequest
            };
            if (ModelState.IsValid)
            {
                var tempdetails = dTOLoginRequest;

                response.Code = HttpStatusCode.OK;
                response.MSG = "Success";

                ViewBag.ResponseMSG_ClassDetails = response;
                ViewBag.ResponseMSG = "Success";
                return View();
            }
            response.Code = HttpStatusCode.BadRequest;
            response.MSG = "Error";

            ViewBag.ResponseMSG_ClassDetails = response;
            ViewBag.ResponseMSG = "Error";
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(DTOCustomerDetailsRegRequest dTOCustomerDetailsRegRequest)
        {
            if (ModelState.IsValid)
            {
                var tempdetails = dTOCustomerDetailsRegRequest;
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
    }
}
