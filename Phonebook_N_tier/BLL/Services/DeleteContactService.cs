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
    public class DeleteContactService
    {
        DataBaseContext _context = new DataBaseContext();
        public ResultDto DeleteContact(int Id)
        {
            var contact = _context.Contacts.Find(Id);
            if (contact != null)
            {
                _context.Remove(contact);
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "مخاطب با موفقیت حذف شد",
                };

            }
            return new ResultDto
            {
                IsSuccess = false,
                Message = "حذف انجام نشد"
            };
        }
    }
}
