using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Library : Book
    {
        IList<Book> m_Books = new List<Book>();
        // Đưa sách vào kệ sách
        public void Add(Book newBook)
        {
            m_Books.Add(newBook);
        }
        // Thanh lý một quyển sách theo mã sách
        public Book Remove(string code)
        {
            int i = 0;
            while (i < m_Books.Count && m_Books[i].Code != code)
                i++;
            if(i < m_Books.Count)
            {
                Book tmp = new Book(m_Books[i]);
                m_Books.Remove(tmp);
                return tmp;
            }
            else
            {
                Console.WriteLine("Khong Tim Thay Quen Sach Co Ma So {0}", Code);
                return null;
            }
        }
        // Tìm sách theo tiêu đề
        public Book Find(string title)
        { }
        // Xuất danh mục sách
        public override string ToString()
        { }
    }
}
