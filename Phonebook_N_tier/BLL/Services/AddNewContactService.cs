using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AddNewContactService
    {
        DataBaseContext _context=new DataBaseContext();
        public ResultDto AddNewContact(AddNewContactDto addNewContactDto)
        {

            if (string.IsNullOrEmpty(addNewContactDto.FirstName))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "نام اجباری می باشد. لطفا نام خود را وارد کنید",
                };
            }
            if (string.IsNullOrEmpty(addNewContactDto.LastName))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "نام خانوادگی اجباری می باشد. لطفا نام خانوادگی خود را وارد کنید",
                };
            }
            if (string.IsNullOrEmpty(addNewContactDto.PhoneNumber))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره موبایل اجباری می باشد. لطفا شماره موبایل خود را وارد کنید",
                };
            }

            Contact contact = new Contact()
            {
                Description = addNewContactDto.Description,
                FirstName = addNewContactDto.FirstName,
                LastName = addNewContactDto.LastName,
                Company = addNewContactDto.Company,
                CreateAt = DateTime.Now,
                PhoneNumber = addNewContactDto.PhoneNumber,
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = $" مخاطب {contact.FirstName} {contact.LastName} با موفقیت در دیتابیس ذخیره شد",
            };

        }

    }
}
