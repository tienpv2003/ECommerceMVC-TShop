﻿using ECommerceMVC.Helpers;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace ECommerceMVC.ViewComponents
{
    public class CartViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>
                (MySetting.CART_KEY) ?? new List<CartItem>();
            return View("CartPanel",new CartModel
            {
                quantity = cart.Sum(p => p.SoLuong),
                Total = cart.Sum (p => p.ThanhTien)
            });
        }
    }
}
