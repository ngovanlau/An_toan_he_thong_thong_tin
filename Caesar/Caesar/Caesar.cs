using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    public class Caesar
    {
        //public static string nguon = "aáàạảãăắằặẳẵâấầậẩẫbcdđeéèẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉÈẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXY0123456789~`!@#$%^&*()-_.:';,/?<>[]{}=+ ";
        public static string nguon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Khai báo hằng chuỗi nguồn và gán bằng "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        public static char[] P = nguon.ToCharArray(); // Khai báo hằng mảng P và bằng các chữ cái trong hằng nguon
        public static string Mahoa(string s, int k) // Khai báo hàm Mahoa chuyền vào 2 tham số là chuỗi s và khóa k
        {
            int mahoa_local = 0; // khai báo biến mahoa_local và gán = 0
            char[] vanban = s.ToCharArray();  // khai báo mảng char vanban chứa các chữ cái của chuỗi s
            int l = vanban.Length; // Khai báo biến l chứa chiều dài của mảng vanban
            char[] tmp_text = new char[l]; // Khai báo mảng char tmp_text có l phần tử
            int[] tmp_local = new int[l]; // Khai báo mảng int tmp_local có l phần từ
            int j = 0; // khai báo biến j = 0
            while (j < l) // Trong khi j còn < l thì duyệt vòng lặp for từ i đến i = độ dài mảng P - 1 nếu trong khi lặp có chữ cái tại vị trí i của mảng P bằng chữ cái tại vị trí j của mảng vanban thì lưu i vào vị trí j của mảng tmp_local sau đó tính mahoa_local = tmp_local[j] + k nếu mohoa_local > hoặc = độ dài mảng P thì mahoa_local = mahoa_local - độ dài mảng P sau đó lưu chữ cái tại vị trí mahoa_local của mảng P vào vị trí j của mảng tmp_text sau dó tiếp tục lặp đến khi j = l
            {
                for (int i = 0; i < P.Length; i++)  // Trong khi j còn < dộ dài của hằng P thì tiệp tục lặp
                {
                    if (P[i] == vanban[j]) // Nếu chữ trong P[i] bằng chữ trong vanban[i] 
                    {
                        tmp_local[j] = i; // gán giá trị tại vị trí j của mảng tmp_local bằng i
                        mahoa_local = tmp_local[j] + k; // gán biến mahoa_local = giá trị phần tử thứ j của tmp_local + k
                        if (mahoa_local >= P.Length) // Nếu biến mahoa_local > hoặc = chiều dài của mảng P thì
                            mahoa_local = mahoa_local - P.Length; // gán mahoa_local = mahoa_local - chiều dài mảng P
                        tmp_text[j] = P[mahoa_local]; // Chữ cái vị trí j của mảng tmp_text = chữ cái tại vị trí mahoa_local của mảng P
                    }
                }
                j++; // Tăng j lên 1
            }
            return new string(tmp_text); // Trả về chuỗi string từ mảng tmp_text
        }

        public static string GiaiMa(string s, int k) // Trong khi j còn < l thì duyệt vòng lặp for từ i đến i = độ dài mảng P - 1 nếu trong khi lặp có chữ cái tại vị trí i của mảng P bằng chữ cái tại vị trí j của mảng vanban thì lưu i vào vị trí j của mảng tmp_local sau đó tính mahoa_local = tmp_local[j] - k nếu mohoa_local <  0 thì mahoa_local = mahoa_local + độ dài mảng P sau đó lưu chữ cái tại vị trí mahoa_local của mảng P vào vị trí j của mảng tmp_text
        {
            int mahoa_local = 0; // khai báo biến mahoa_local và gán = 0
            char[] vanban = s.ToCharArray(); // khai báo mảng char vanban chứa các chữ cái của chuỗi s
            int l = vanban.Length; // Khai báo biến l chứa chiều dài của mảng vanban
            char[] tmp_text = new char[l]; // Khai báo mảng char tmp_text có l phần tử
            int[] tmp_local = new int[l]; // Khai báo mảng int tmp_local có l phần từ
            int j = 0; // khai báo biến j = 0
            while (j < l) // Trong khi j còn < l thì tiệp tục lặp
            {
                for (int i = 0; i < P.Length; i++) // Trong khi j còn < dộ dài của hằng P thì tiệp tục lặp
                {
                    if (P[i] == vanban[j]) // Nếu chữ trong P[i] bằng chữ trong vanban[i] 
                    {
                        tmp_local[j] = i; // gán giá trị tại vị trí j của mảng tmp_local bằng i
                        mahoa_local = tmp_local[j] - k;  // gán biến mahoa_local = giá trị phần tử thứ j của tmp_local - k
                        if (mahoa_local < 0)  // Nếu biến mahoa_local < 0
                            mahoa_local = mahoa_local + P.Length; // gán mahoa_local = mahoa_local + chiều dài mảng P
                        tmp_text[j] = P[mahoa_local]; // Chữ cái vị trí j của mảng tmp_text = chữ cái tại vị trí mahoa_local của mảng P
                    }
                }
                j++; // Tăng j lên 
            }
            return new string(tmp_text); // Trả về chuỗi string từ mảng tmp_text
        }
    }
}
