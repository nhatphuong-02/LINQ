using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan6
{
    public class SinhVien
    {
        private String ten;
        private int tuoi;
        private String khoa;
        private double dtb;
        private int namHoc;

        public String Ten { get; set; }
        public int Tuoi { get; set; }
        public String Khoa { get; set; }
        public double Dtb { get; set; }
        public int NamHoc {  get; set; }

        public SinhVien() { }
        public SinhVien(string ten, int tuoi, string khoa, double dtb, int namHoc)
        {
            Ten = ten;
            Tuoi = tuoi;
            Khoa = khoa;
            Dtb = dtb;
            NamHoc = namHoc;
        }

        public void Display() 
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Tuoi: " + Tuoi);
            Console.WriteLine("Khoa: " + Khoa);
            Console.WriteLine("Diem trung binh: "+Dtb);
            Console.WriteLine("Nam hoc: " + NamHoc);
        }
    }
}
