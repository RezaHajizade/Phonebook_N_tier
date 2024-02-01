using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GetContactListService
    {
        DataBaseContext _context = new DataBaseContext();

        /// <summary>
        /// دریافت لیست مخاطبان
        /// </summary>
        /// <returns></returns>
        public List<ContactDto> GetContactList()
        {
            var contactList = _context.Contacts.Select(p => new ContactDto
            {
                Id = p.Id,
                FullName = $"{p.FirstName} {p.LastName}",
                PhoneNumber = p.PhoneNumber,
            }).ToList();

            return contactList;
        }

     
       

      

      

      
    }
}

