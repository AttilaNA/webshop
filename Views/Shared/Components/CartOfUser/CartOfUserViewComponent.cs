using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShop.Others.Services;

namespace WebShop.Views.Shared.Components.CartOfUser
{
    public class CartOfUserViewComponent : ViewComponent
    {
        private readonly ICartOfUserService _cartOfUserService;
        public CartOfUserViewComponent(ICartOfUserService cartOfUserService)
        {
            _cartOfUserService = cartOfUserService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = Request.Cookies["user"];

            // Implement different behavior if user does not have id set
            if (userId == null)
            {
                // Use an empty cart to handle the scenario in view
                var emptyCart = new Cart
                {
                    User = null
                };
                return View(emptyCart);
            }

            var userCart = _cartOfUserService.GetCartByUserId(int.Parse(userId));
            return View(userCart);
        }
    }
}