// Как посмотреть содержимое папки?

//смотрим файлы в папке и дату создания
// string adress = "E:/GeekBreans/C#/4seminar/task2";
// DirectoryInfo di = new DirectoryInfo(adress);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi =di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

//смотрим все папки и файлы в них

void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = "E:/GeekBreans/C#/4seminar/task2";
CatalogInfo(path);