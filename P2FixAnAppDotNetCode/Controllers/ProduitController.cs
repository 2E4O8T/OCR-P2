using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;
        private readonly ILangageService _langageService;

        public ProduitController(IProduitService produitService, ILangageService langageService)
        {
            _produitService = produitService;
            _langageService = langageService;
        }

        public IActionResult Index()
        {
        //BeFr - Utiliser une List au lieu d'un Array
        //Remplace : Produit[] produits = _produitService.GetTousLesProduits();
        //Par : List<Produit> produits = _produitService.GetTousLesProduits();
            List< Produit > produits = _produitService.GetTousLesProduits();
            return View(produits);
        }
    }
}