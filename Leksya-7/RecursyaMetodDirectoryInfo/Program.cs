﻿


void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + "  ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"/Users/jacintoluisfrancisco/Downloads/4 КУРС/IT COURSE/MEUS PROJECTOS/LEKSYA/LEKSYA-1/Leksya-1/example001_helloconsole";
CatalogInfo(path);