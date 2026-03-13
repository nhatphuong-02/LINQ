using SinhVien;

Console.WriteLine("Quach Nhat Phuong\nMa sinh vien: 2415053122336\n");
List<Student> students = new List<Student>() {  new Student { Id = 1, Name = "An", Score = 8 },
                                                new Student { Id = 2, Name = "Binh", Score = 6 },
                                                new Student { Id = 3, Name = "Chi", Score = 9 },
                                                new Student { Id = 4, Name = "Dung", Score = 7 } };
var bai9 = students.Select(student => student.Name).ToList();

Console.Write("Cac sinh vien gom: ");
bai9.ForEach(x => Console.Write(x + ", "));
