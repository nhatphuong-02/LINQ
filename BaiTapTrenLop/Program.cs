using Tuan6;
using System.Linq;

Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");

List<SinhVien> list = new List<SinhVien>();
Random random = new Random();
for(int i=0; i<20; i++)
{
    SinhVien sv = new SinhVien();
    sv.Ten = "SinhVien" + i;
    sv.Tuoi = random.Next(18, 25);
    sv.Khoa = "CNS";
    sv.Dtb = random.NextDouble() * 10;
    sv.NamHoc = random.Next(1, 5);
    list.Add(sv);
}

//Cau 1
var maxTuoi = list.Max(x => x.Tuoi);
Console.WriteLine("Tuoi lon nhat la: " + maxTuoi);
var minTuoi = list.Min(x => x.Tuoi);
Console.WriteLine("Tuoi nho nhat la: " + minTuoi);

//Cau 2
if(list.Any(x => x.Khoa == "CNS"))
    Console.WriteLine("Co sinh vien khoa CNS");
else
    Console.WriteLine("Khong co sinh vien khoa CNS");

//Cau 3
var cau3 = list.OrderByDescending(x => x.Dtb).Take(10).ToList();
Console.WriteLine("\nDanh sach 10 sinh vien diem cao nhat khoa la:");
cau3.ForEach(x=> Console.WriteLine($"Ten: {x.Ten}; Nam hoc: {x.NamHoc}; Diem: {x.Dtb:F2}"));

//Cau 4
var cau4 = list.Where(x => x.NamHoc != 4).ToList();
Console.WriteLine("\nDanh sach sinh vien nam 1->3:");
cau4.ForEach(x => Console.WriteLine($"Ten: {x.Ten}; Nam hoc: {x.NamHoc}"));