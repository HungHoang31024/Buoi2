using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Book
    {
        // Fields
        string m_Code; // Mã sách
        string m_Title; // Tiêu đề sách
        int m_Page; // Số trang

        // Constructors
        public Book()
        { }
        public Book(string code)
        {
            m_Code = code;
        }
        public Book(string title, string code)
        {
            m_Code = code;
            m_Title = title;
        }
        public Book(string title, string code, int page)
        {
            m_Code = code;
            m_Title = title;
            m_Page = page;
        }
        public Book(Book b)
        { }
        // Properties
        public string Code { get => m_Code; set => m_Code = value; }
        public string Title { get; set; }
        public int Page { get; set; }
        // Methods
        public override string ToString()
        {
            return string.Format("Ma sach: {0}, Tua sach: {1}, So trang: {2}",m_Code,m_Page,m_Title);
        }
    }
}
