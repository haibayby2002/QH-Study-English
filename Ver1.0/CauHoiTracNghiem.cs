using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1._0
{
    class CauHoiTracNghiem
    {
        private string cauHoi, dapAn;
        private string[] cauTraLoi = new string[4];
        int luaChon, luaChonCuaBan;

        public string CauHoi { get => cauHoi; set => cauHoi = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string[] CauTraLoi { get => cauTraLoi; set => cauTraLoi = value; }
        public int LuaChon { get => luaChon; set => luaChon = value; }
        public int LuaChonCuaBan { get => luaChonCuaBan; set => luaChonCuaBan = value; }

        public CauHoiTracNghiem()
        {
            cauHoi = dapAn = "";
            luaChon = 0;
            for (int i = 0; i < 4; i++)
            {
                cauTraLoi[i] = "";
            }
        }

        public CauHoiTracNghiem(string cauHoi, string dapAn)
        {
            this.cauHoi = cauHoi;
            this.dapAn = dapAn;
        }

        public CauHoiTracNghiem(TuVung tv)
        {
            this.cauHoi = tv.NghiaTu;
            this.dapAn = tv.TenTu;
        }

        public CauHoiTracNghiem(string cauHoi, string dapAn, string cauA, string cauB, string cauC, string cauD)
        {
            this.cauHoi = cauHoi;
            this.dapAn = dapAn;

            this.cauTraLoi[0] = cauA;
            this.cauTraLoi[1] = cauB;
            this.cauTraLoi[2] = cauC;
            this.cauTraLoi[3] = cauD;

            Random rand = new Random();
            luaChon = rand.Next(0, 4);
            this.cauTraLoi[luaChon] = dapAn;
        }

        public bool KiemTraDung()
        {
            if(luaChon == luaChonCuaBan)
            {
                return true;
            }
            return false;
        }
    }
}
