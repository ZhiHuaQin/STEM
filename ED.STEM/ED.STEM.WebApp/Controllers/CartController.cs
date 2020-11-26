﻿using ED.STEM.Domain.Abstract;
using ED.STEM.Domain.Concrete;
using ED.STEM.Domain.Entities;
using ED.STEM.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ED.STEM.WebApp.Controllers
{
    public class CartController : Controller
    {
        public ISTEMProgramsRepository ProgramsRepository { get; set; }
          = new EFSTEMProgramRepository();
        public RedirectToRouteResult AddToCart(Cart cart, int STEMProgramId, string returnUrl)
        {
            STEMProgram product = ProgramsRepository
            .STEMPrograms
            .FirstOrDefault(p => p.STEMProgramId == STEMProgramId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int STEMProgramId, string returnUrl)
        {
            STEMProgram product = ProgramsRepository
           .STEMPrograms
           .FirstOrDefault(p => p.STEMProgramId == STEMProgramId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}