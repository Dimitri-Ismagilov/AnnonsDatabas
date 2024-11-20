using AnnonsDatabas.Repository.Entities;
using AnnonsDatabas.Views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonsDatabas.Repository.Repos
{
    public class AdvertisementRepo
    {
        public DataContext _advertisements = new();

        public AdvertisementRepo()
        {
            _advertisements = new DataContext();
        }



        public List<Advertisement> GetAdvertisements()
        {
            List<Advertisement> advertisements = _advertisements.GetAdvertisements();

            //advertisements = _advertisements.GetAdvertisements();

            return advertisements;
        }

        //DataContext advertisements = new DataContext();
        //DataContext categories = new DataContext();
        //public List<Advertisement> SearchAdvertisement(string searchValueTitle)
        //{
        //    List<Advertisement> advertisementsList = advertisements.GetAdvertisements();
        //    var searchAdvertisements = advertisementsList
        //        .Where(ad => ad.AdvertisementTitle.Contains(searchValueTitle.ToLower(), StringComparison.OrdinalIgnoreCase))
        //        .ToList();
        //    return searchAdvertisements;
        //}
        //public List<Category> SearchCategory(string searchValueCategory)
        //{
        //    List<Category> categoriesList = categories.GetCategories();
        //    var searchCategories = categoriesList
        //        .Where(ad => ad.CategoryName.Contains(searchValueCategory, StringComparison.OrdinalIgnoreCase))
        //        .ToList();
        //    return searchCategories;
        //}
        //public void PrintSearchResult(string searchValueTitle, string searchValueCategory, AdvertisementDatabase advertisementDatabase)
        //{
        //    List<Advertisement> searchAdvertisements = SearchAdvertisement(searchValueTitle);
        //    List<Category> searchCategories = !string.IsNullOrEmpty(searchValueCategory) ? SearchCategory(searchValueCategory) : new List<Category>();

        //    if (!string.IsNullOrEmpty(searchValueCategory))
        //    {
        //        var filteredCategoryIDs = searchCategories.Select(c => c.CategoryID).ToList();

        //        // Filtrera annonser baserat på CategoryID
        //        searchAdvertisements = searchAdvertisements
        //            .Where(ad => filteredCategoryIDs.Contains(ad.CategoryID))
        //            .ToList();
        //    }
        //    if (!string.IsNullOrEmpty(searchValueTitle))
        //    {
        //        searchAdvertisements = searchAdvertisements
        //            .Where(ad => ad.AdvertisementTitle.Contains(searchValueTitle, StringComparison.OrdinalIgnoreCase))
        //            .ToList();
        //    }
        //}
    }
}
