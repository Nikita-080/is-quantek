#include <windows.h>
#include <stdio.h>
#include <iostream>
#include <fstream>

int main()
{
   setlocale(LC_ALL, "Russian");

   std::string path;
   std::cout<<"Введите путь сохранения файла: ";
   std::cin>>path;

   std::string macadress="745694376";

   //get system info

   //get system info

   std::ofstream out;
   out.open(path+"\\"+macadress+".txt");
   if (out.is_open())
   {
      out << "test";
   }
   out.close();

   std::cout<<"Данные сохранены\n";
   system("pause");
}
