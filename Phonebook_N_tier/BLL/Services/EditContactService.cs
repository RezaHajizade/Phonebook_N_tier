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
    public class EditContactService
    {
        DataBaseContext _context=new DataBaseContext();
        public ResultDto EditContact(EditContactDto editContactDto)
        {
            var contact = _context.Contacts.Find(editContactDto.Id);
            if (contact == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد",
                };

            }
            contact.FirstName = editContactDto.FirstName;
            contact.LastName = editContactDto.LastName;
            contact.Company = editContactDto.Company;
            contact.PhoneNumber = editContactDto.PhoneNumber;
            contact.Description = editContactDto.Description;

            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "اطلاعات مخاطب با موفقیت ویرایش شد",
            };


        }
    }
}
