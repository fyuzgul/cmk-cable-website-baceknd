﻿using CmkCable.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmkCable.DataAccess.Abstract
{
    public interface IContactInformationRepository
    {
        List<ContactInformation> GetAllContactInformations();
        ContactInformation GetContactInformation(int id);
        ContactInformation CreateContactInformation(ContactInformation contactInformation);    
        void DeleteContactInformation(int id);
        ContactInformation UpdateContactInformation(ContactInformation contactInformation);
    }
}
