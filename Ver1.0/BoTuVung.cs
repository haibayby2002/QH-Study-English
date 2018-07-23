using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1._0
{
    class BoTuVung
    {
        private string tenBoTuVung, moTa;
        private List<TuVung> listTuVung = new List<TuVung>();

        public BoTuVung()
        {
            tenBoTuVung = moTa = "";
            listTuVung = null;
        }

        public BoTuVung(string tenBoTuVung, string moTa)
        {
            this.tenBoTuVung = tenBoTuVung;
            this.moTa = moTa;
        }

        public BoTuVung(string tenBoTuVung, string moTa, List<TuVung> listTuVung)
        {
            this.tenBoTuVung = tenBoTuVung;
            this.moTa = moTa;
            this.listTuVung = listTuVung;
        }

        public string TenBoTuVung { get => tenBoTuVung; set => tenBoTuVung = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        internal List<TuVung> ListTuVung { get => listTuVung; set => listTuVung = value; }

        //Trả ra vị trí cần tìm nếu tìm thấy, trả ra -1 nếu không tìm thấy
        public int TimViTriTu(string tuCanTim)      
        {
            int n = listTuVung.Count;

            for (int i = 0; i < n; i++) 
            {
                if(listTuVung[i].TenTu == tuCanTim)
                {
                    return i;
                }
            }

            return -1;
        }

        //Thêm, xóa, sửa
        //Thêm: trả ra bool nếu thêm thành công, trả ra false nếu thất bại
        public bool ThemTu(string tuCanThem, string nghiaTuThem)
        {
            int n = TimViTriTu(tuCanThem);
            if(n == -1)
            {
                return false;
            }

            TuVung tv = new TuVung(tuCanThem, nghiaTuThem);
            listTuVung.Insert(0, tv);
            return true;
        }

        public bool ThemTu(TuVung tv)
        {
            int n = TimViTriTu(tv.TenTu);
            if (n == -1)
            {
                return false;
            }
            listTuVung.Insert(0, tv);
            return true;    //Thêm thành công
        }

        //Xóa từ: trả ra true nếu xóa thành công, trả ra false nếu xóa thất bại
        public bool XoaTu(string tuCanXoa)
        {
            int n = TimViTriTu(tuCanXoa);
            if(n == -1)     //Xóa thất bại
            {
                return false;
            }
            listTuVung.RemoveAt(n);
            return true;    //Xóa thành công
        }

        //Sửa từ: trả ra true nếu sửa thành công, trả ra false nếu sửa thất bại
        public bool SuaTu(string tuCanSua, string nghiaTuMoi)
        {
            int n = TimViTriTu(tuCanSua);
            if(n == -1)     //Sửa thất bại
            {
                return false;
            }
            listTuVung[n].NghiaTu = nghiaTuMoi;
            return true;    //Sửa thành công
        }
    }
}
