using BLL.Dto;
using DAL.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SearchContactService
    {
        DataBaseContext _context = new DataBaseContext();

        public List<ContactDto> SearchContact(string SearchKey)
        {
            var ContactQuery = _context.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContactQuery = ContactQuery.Where(
                p =>
                p.FirstName.Contains(SearchKey)
                ||
                p.LastName.Contains(SearchKey)
                ||
                p.Company.Contains(SearchKey)
                ||
                p.PhoneNumber.Contains(SearchKey));
            }

            var data = ContactQuery.Select(p => new ContactDto
            {
                Id = p.Id,
                FullName = $"{p.FirstName} {p.LastName}",
                PhoneNumber = p.PhoneNumber,
            }).ToList();
            return data;

        }
    }
}
