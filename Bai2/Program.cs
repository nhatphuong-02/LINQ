Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai2 = numbers.Where(x => x>5).ToList();

Console.Write("Cac so lon hon 5: ");
bai2.ForEach(x => Console.Write(x + " "));

