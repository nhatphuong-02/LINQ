Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai4 = numbers.OrderByDescending(x => x).ToList();

Console.Write("Danh sach giam dan: ");
bai4.ForEach(x => Console.Write(x + " "));


