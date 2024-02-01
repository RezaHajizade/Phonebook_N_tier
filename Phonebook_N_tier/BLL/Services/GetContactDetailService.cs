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
    public class GetContactDetailService
    {
        DataBaseContext _context=new DataBaseContext();
        public ResultDto<ContactDetailDto> GetContactDetail(int Id)
        {
            var contact = _context.Contacts.Find(Id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>
                {
                    IsSuccess = false,
                    Message = "مخاطب مورد نظر پیدا نشد",
                };
            }
            else
            {

                return new ResultDto<ContactDetailDto>
                {
                    Data = new ContactDetailDto
                    {
                        Company = contact.Company,
                        CreateAt = DateTime.Now,
                        FirstName = contact.FirstName,
                        Description = contact.Description,
                        PhoneNumber = contact.PhoneNumber,
                        LastName = contact.LastName,
                    },
                    IsSuccess = true,

                };
            }

        }
    }
}
