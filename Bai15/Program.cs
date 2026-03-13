Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");

List<int> num = new List<int> { 1,2,2,3,4,4,5 };
var bai15 = num.Distinct().ToList();

Console.Write("Danh sach gom: ");
bai15.ForEach(x=> Console.Write(x+" "));