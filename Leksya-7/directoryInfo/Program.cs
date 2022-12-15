
string path = "/Users/jacintoluisfrancisco/Downloads/4 КУРС/IT COURSE/MEUS PROJECTOS/LEKSYA/LEKSYA-1/Leksya-7/directoryInfo";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
