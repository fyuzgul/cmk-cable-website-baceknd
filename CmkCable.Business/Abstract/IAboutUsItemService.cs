﻿using CmkCable.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmkCable.Business.Abstract
{
    public interface IAboutUsItemService
    {
        List<AboutUsItem> GetAllAboutUsItems();
        AboutUsItem CreateAboutUsItem(AboutUsItem aboutUsItem);
        AboutUsItem UpdateAboutUsItem(AboutUsItem aboutUsItem);
        void DeleteAboutUsItem(string id);
    }
}
