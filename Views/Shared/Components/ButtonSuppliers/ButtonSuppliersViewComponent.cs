using Microsoft.AspNetCore.Mvc;
using WebShop.Others.Daos;

namespace WebShop.Views.Webshop.Components.ProductCard;

public class ButtonSuppliersViewComponent : ViewComponent
{
    private readonly ISupplierDao _supplierStorage;

    public ButtonSuppliersViewComponent(ISupplierDao supplierStorage)
    {
        _supplierStorage = supplierStorage;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var supplier = _supplierStorage.GetAll();
        return View(supplier.ToList());
    }
}