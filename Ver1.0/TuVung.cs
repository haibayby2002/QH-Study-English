using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1._0
{
    class TuVung
    {
        protected string tenTu, nghiaTu;
        protected int soLanLuyenTap, soLanTraLoiSai;

        public TuVung()
        {
            tenTu = nghiaTu = "";
            soLanLuyenTap = soLanTraLoiSai = 0;
        }

        public TuVung(string tenTu, string nghiaTu)
        {
            this.tenTu = tenTu;
            this.nghiaTu = nghiaTu;
            this.soLanLuyenTap = this.soLanTraLoiSai = 0;
        }

        public TuVung(string tenTu, string nghiaTu, int soLanLuyenTap, int soLanTraLoiSai)
        {
            this.tenTu = tenTu;
            this.nghiaTu = nghiaTu;
            this.soLanLuyenTap = soLanLuyenTap;
            this.soLanTraLoiSai = soLanTraLoiSai;
        }


        public int SoLanLuyenTap { get => soLanLuyenTap; set => soLanLuyenTap = value; }
        public int SoLanTraLoiSai { get => soLanTraLoiSai; set => soLanTraLoiSai = value; }
        public string TenTu { get => tenTu; set => tenTu = value; }
        public string NghiaTu { get => nghiaTu; set => nghiaTu = value; }

        //Tỉ lệ sai là 1006 nếu chưa luyện tập, ngược lại trả ra soLanTraLoiSai / soLanLuyenTap
        public double TinhTiLeSai()
        {
            if(soLanLuyenTap == 0)
            {
                return 1006;
            }
            return soLanTraLoiSai / soLanLuyenTap;
        }
    }
}
