string path = "C:/Users/User/Desktop/GB/Znakomstvo-s-yazikami-programmirivaniya/Seminars/Seminar-3/Task_02 (Teacher)";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}