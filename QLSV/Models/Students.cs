﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class StudentViewModel
    {
        public int HocSinhID { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public DateTime NgaySinh { get; set; }
        public float Luong { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }
    }

}
