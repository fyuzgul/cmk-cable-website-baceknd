﻿using CmkCable.Business.Abstract;
using CmkCable.DataAccess.Abstract;
using CmkCable.DataAccess.Concrete;
using CmkCable.Entities;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmkCable.Business.Concrete
{
    public class NavbarItemManager : INavbarItemService
    {
        private INavbarItemRepository _itemRepository;
        public NavbarItemManager() { _itemRepository = new NavbarItemRepository(); }
        public NavbarItem CreateNavbarItem(NavbarItem navbarItem)
        {
            return _itemRepository.CreateNavbarItem(navbarItem);
        }

        public void DeleteNavbarItem(string id)
        {
            _itemRepository.DeleteNavbarItem(id);
        }

        public List<NavbarItem> GetAllNavbarItems()
        {
            return _itemRepository.GetAllNavbarItems();
        }

        public NavbarItem GetNavbarItem(int id)
        {
            return _itemRepository.GetNavbarItem(id);
        }

        public NavbarItem UpdateNavbarItem(NavbarItem navbarItem)
        {
            return _itemRepository.UpdateNavbarItem(navbarItem);
        }

        public List<NavbarItemDto> GetNavbarItemsByLanguage(int languageId)
        {
            return _itemRepository.GetNavbarItemsByLanguage(languageId);
        }
    }
}
