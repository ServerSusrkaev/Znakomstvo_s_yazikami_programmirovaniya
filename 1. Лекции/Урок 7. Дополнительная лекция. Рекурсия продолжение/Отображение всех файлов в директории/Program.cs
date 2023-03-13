void CatalogInfo (string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    { 
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"/Users/User/Desktop/GB/Znakomstvo-s-yazikami-programmirivaniya/Lectures/Lecture-1/Example_01";
CatalogInfo(path);
