using System.Collections.Generic;
using CompanyC7.Core;

namespace CompanyC7.Data
{
    // Vì sao tạo Interface mà k tạo class trực tiếp?
    // Vì Interface tạo đối tượng nhanh hơn class
    // Để che dấu dữ liệu
    public interface  ICompanyData
    {
        IEnumerable<Company> GetCompaniesByName(string name);
        Company GetById(int companyId);

        Company Update(Company newCompany);
        //IEnumerable<Company> GetAll();
        //Company Delete(int companyId);
        //int Commit();
        //Company Add(Company newCompany);
    }

}
