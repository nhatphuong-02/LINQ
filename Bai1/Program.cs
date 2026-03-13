Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai1 = numbers.Where(x => x%2 == 0).ToList();

Console.Write("Danh sach so chan: ");
bai1.ForEach(x => Console.Write(x + " "));

