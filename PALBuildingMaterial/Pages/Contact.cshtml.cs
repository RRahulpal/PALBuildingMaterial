using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PALBuildingMaterial.Models;
using System.Net;

namespace PALBuildingMaterial.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public Enquiry Enquiry { get; set; } = new();

    public bool Success { get; set; }

    public void OnGet(string? product)
    {
        if (!string.IsNullOrWhiteSpace(product))
        {
            Enquiry.Product = product;
        }
    }

    public IActionResult OnPost()
    {
        string adminWhatsAppNumber = "918104881897"; // change this to your number

        string message =
            $"New Quote Enquiry%0A%0A" +
            $"Name: {WebUtility.UrlEncode(Enquiry.Name)}%0A" +
            $"Phone: {WebUtility.UrlEncode(Enquiry.Phone)}%0A" +
            $"Email: {WebUtility.UrlEncode(Enquiry.Email)}%0A" +
            $"Product: {WebUtility.UrlEncode(Enquiry.Product)}%0A" +
            $"Message: {WebUtility.UrlEncode(Enquiry.Message)}%0A%0A" +
            $"From: PAL Building Material Website";

        string whatsappUrl = $"https://wa.me/{adminWhatsAppNumber}?text={message}";

        return Redirect(whatsappUrl);
    }
}