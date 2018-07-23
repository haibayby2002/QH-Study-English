using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1._0
{
    class CauHoiTuLuan
    {
        private string cauHoi, dapAn, cauTraLoi, dapAnChuanHoa;
        public string CauHoi { get => cauHoi; set => cauHoi = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string CauTraLoi { get => cauTraLoi; set => cauTraLoi = value; }

        public CauHoiTuLuan()
        {
            cauHoi = dapAn = cauTraLoi = "";
        }

        public CauHoiTuLuan(string cauHoi, string dapAn)
        {
            this.cauHoi = cauHoi;
            this.dapAn = dapAn;
            this.dapAnChuanHoa = ChuanHoa(dapAn);
        }

        public CauHoiTuLuan(TuVung tv)
        {
            this.cauHoi = tv.NghiaTu;
            this.dapAn = tv.TenTu;
            this.dapAnChuanHoa = ChuanHoa(dapAn);
        }

        public bool KiemTraDung()
        {
            if (dapAnChuanHoa == ChuanHoa(cauTraLoi)) 
            {
                return true;
            }
            return false;
        }

        public string ChuanHoa(string s)
        {
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z')))
                {
                    s = s.Remove(i, 1);
                }
            }
            return s.ToLower();
        }

    }
}
