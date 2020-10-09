﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.Data;
using Microsoft.AspNetCore.Http;

namespace ShoppingCart.Controllers
{
    public class PurchasesController : Controller
    {
        public IActionResult DisplayPurchases()
        {
            List<Purchases> purchases = FinalList(); // data of past purchases will be added into a list here
            ViewData["purchases"] = purchases;
            return View();
        }
        public List<Purchases> FinalList() // Combines the purchases and activation list
        {
            List<Purchases> purchases = PurchasesData.GetPurchases(HttpContext.Session.GetString("userid"));
            List<ActivationCode> codes = PurchasesData.GetActivationCodes(HttpContext.Session.GetString("userid"));

            foreach (Purchases purchase in purchases)
            {
                foreach (ActivationCode code in codes)
                {
                    if (code.OrderId == purchase.OrderId && code.ProductId == purchase.ProductId)
                    {
                        purchase.ActivationCode.Add((string)code.Code);
                    }
                }
            }
            return purchases;
        }
    }
}
