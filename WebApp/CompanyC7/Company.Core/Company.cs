using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyC7.Core
{
    //Tạo Class CompanyType >> Ctrl. >> Move to namespace 
    //New project: class library Data >> đổi tên >> đổi class thành interface
    //Tạo public class InMemoryCompanyData : ICompanyData, tạo List, tạo constructor cuar InMemoryCompanyData
    //vào IEnumerable<Company> GetAll(); vào ICompanyData >> tạo phương thức GetAll();
    //vào Listt.cshtml thêm vào x2, thêm this.companyData = companyData;
    // sửa phương thức GetAll() bên ICompanyData
    //build thử
    public class Company
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Location { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}
