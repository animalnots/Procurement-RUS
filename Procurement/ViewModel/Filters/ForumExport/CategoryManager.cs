﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{
    public static class CategoryManager
    {
        private static Dictionary<string, IEnumerable<IFilter>> categories;
        private static List<IFilter> availableFilters;
        private static readonly Dictionary<string, string> WrapperDictionary = new Dictionary<string, string> {
            {"Magic rarity","Магические предметы"}, {"Unique rarity","Уникальные предметы"}, {"Rare rarity","Редкие предметы"}, {"Normal rarity","Обычные предметы"}
        };

        static CategoryManager()
        {
            categories = new Dictionary<string, IEnumerable<IFilter>>();
            availableFilters = getAvailableFilters();

            initializeBaseCategories();
            initializeUserCategories();
        }

        public static List<AdvancedSearchCategory> GetAvailableCategories()
        {
            List<AdvancedSearchCategory> advancedSearchCategories = new List<AdvancedSearchCategory>();
            foreach (var category in categories)
            {
                advancedSearchCategories.Add(new AdvancedSearchCategory(category.Key.Contains("rarity")? WrapperDictionary[category.Key] : category.Key, string.Join(Environment.NewLine, category.Value.Select(filter => filter.Help))));
            }

            return advancedSearchCategories;
        }

        public static IEnumerable<IFilter> GetCategory(string category)
        {
            category = WrapperDictionary.Values.Any(p=>p.Contains(category)) ? WrapperDictionary.First(p => p.Value == category).Key : category;
            return categories[category];
        }

        private static void initializeUserCategories()
        {
            //For Testing and Illustration
            categories.Add("Заготовки", new List<IFilter>() { new NormalRarity(), new OrFilter(new FourLink(), new FiveLink()) });
        }

        public static List<IFilter> GetAvailableFilters()
        {
            availableFilters = availableFilters ?? getAvailableFilters();
            return availableFilters;
        }
        private static List<IFilter> getAvailableFilters()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                                                  .Where(t => !(t.IsAbstract || t.IsInterface) && typeof(IFilter).IsAssignableFrom(t) && t.Name != typeof(OrFilter).Name && t.Name != typeof(VaalFragmentFilter).Name && t.Name != typeof(VaalUberFragmentFilter).Name)
                                                  .Where(t => t.GetConstructor(new Type[] { }) != null)
                                                  .OrderBy(t => t.Name)
                                                  .Select(t => Activator.CreateInstance(t) as IFilter)
                                                  .OrderBy(i => i.Group)
                                                  .ThenBy(i => i.Keyword)
                                                  .ToList();
        }

        private static void initializeBaseCategories()
        {
            availableFilters.ForEach(f => categories.Add(f.Keyword, new List<IFilter>() { f }));
        }
    }
}
