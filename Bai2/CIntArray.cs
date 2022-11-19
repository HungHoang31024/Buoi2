using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class CIntArray
    {
        // Fields
        int[] m_Value;
        int m_Length;

        // Constructors
        // Hàm tạo không đối số
        public CIntArray()
        { }

        // Hàm tạo với một mảng các số nguyên khác
        public CIntArray(params int[] arr)
        {
            m_Length = arr.Length;
            m_Value = new int[m_Length];
            for(int i = 0; i < m_Length; i++)
            {
                m_Value[i] = arr[i];
            }
        }

        // Hàm tạo có một giá trị số nguyên n lần và được lặp lại count lần
        public CIntArray(int n, int count)
        {
            m_Length = count;
            m_Value = new int[m_Length];
            for(int i = 0; i < m_Length; i++)
            {
                m_Value[i] = n;
            }
        }

        // Hàm tạo với một mảng các số nguyên arr, với vị trí bắt đầu là startIndex 
        // (bắt đầu từ 0) và có chiều dài là length
        public CIntArray(int[] arr, int startIndex, int length)
        {
            if (arr.Length < startIndex + length)
                length = arr.Length - startIndex;
            if(length > 0)
            {
                m_Value = new int[length];
                for(int i = 0; i < length; i++)
                {
                    m_Value[i] = arr[startIndex + i];
                    m_Length = length;
                }
            }
        }

        // Property
        public int Length { get; set; }

        // Methods
        // In mảng
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < m_Length; i++)
                str += m_Value[i] + " ";
            return str;
        }

        public void Print()
        {

        }
        
        // Xóa bỏ phần tử tại index
        public int[] Remove(int index)
        {
            if(index >= 0 && index < m_Length)
            {
                m_Length--;
                for(int i = index; i < m_Length; i++)
                {
                    m_Value[i] = m_Value[i + 1];
                }
            }
            return m_Value;
        }

        // Xóa bỏ count phần tử bắt đầu từ startIndex
        public int[] Remove(int startIndex, int count)
        {
            if (startIndex + count > m_Length)
                count = m_Length - startIndex;
            for(int i = 0; i < )
        }
        
        // Thay thế tất cả các phần tử có giá trị oldValue trong mảng này thành newValue
        public int[] Replace(int oldValue, int newValue)
        {
            for (int i = 0; i < m_Length; i++)
                if (m_Value[i] == oldValue)
                    m_Value[i] = newValue;
            return m_Value;
        }

        // Chèn một phần tử có giá trị là newValue vào trước vị trí index của mảng
        public int[] Insert(int index, int newValue)
        {
            int[] tmp = new int[m_Length];
            for (int i = 0; i < index; i++)
                tmp[i] = m_Value[i];

            tmp[index] = newValue;

            for (int i = index; i < m_Length; i++)
                tmp[i + 1] = m_Value[i];
            return tmp;
        }
        
        // Thêm một phần tử có giá trị là newValue vào cuối mảng
        public int[] Add(int newValue)
        {
            return Insert(m_Length, newValue);
        }
        /*
        // Tìm phần tử lớn nhất
        public int Max()
        { }

        // Tìm danh sách vị trí của các phần tử lớn nhất
        public int[] MaxPosition()
        { }

        // Tìm phần tử nhỏ nhất
        public int Min()
        { }

        // Tìm danh sách vị trí của các phần tử nhỏ nhất
        public int[] MinPosition()
        { }

        // Tìm vị trí của phần tử có giá trị n bằng phương pháp 
        // tìm kiếm nhị phân (ĐK: mảng đã được sắp xếp)
        public int BinarySearch(int n)
        { }

        // Sắp xếp các phần tử bằng phương pháp BubbleSort.
        // Nếu asc = true thì sắp xếp tăng dần, ngược lại thì giảm dần
        public int[] BubbleSort(bool asc)
        { }

        // Sắp xếp các phần tử giảm dần bằng phương pháp QuickSort
        public void QuickSortGiam(int[] a, int l, int r)
        { }

        // Sắp xếp các phần tử tăng dần bằng phương pháp QuickSort
        public void QuickSortTang(int[] a, int l, int r)
        { }

        // Sắp xếp các phần tử bằng phương pháp QuickSort.
        // Nếu asc = true thì sắp xếp tăng dần, ngược lại thì giảm dần
        public int[] QuickSort(bool asc)
        { }

        // Kiểm tra mảng có đối xứng không
        public bool IsSymmetry()
        { }
        */
    }
}
