#include <windows.h>
#include <stdio.h>
#include <iostream>
#include <fstream>
#include "sysinfoapi.h"
#include "Intrin.h"

std::string GetStringByIndex(std::string s, int index)
{
    int i=0;
    int count=0;
    while (count!=index)
    {
        if (s[i]==' ') count++;
        i++;
    }

    std::string result="";
    while (i!=s.length() && s[i]!=' ')
    {
        result+=s[i];
        i++;
    }
    return result;
}

struct cpuid_regs
{
    DWORD   Eax;
    DWORD   Ebx;
    DWORD   Ecx;
    DWORD   Edx;
};

std::string SplitIntoChars(DWORD Value)
{
    std::string Str;
    char const * pCursor = (char const *)&Value;
    for (int i = 0; i < sizeof (Value); ++i) {
        Str += pCursor[i];
    }
    return Str;
}

std::string GetCpuVendorSubstring(DWORD Eax)
{
    cpuid_regs Regs;
    __cpuid((int *)&Regs, Eax);
    std::string Str;
    Str += SplitIntoChars(Regs.Eax);
    Str += SplitIntoChars(Regs.Ebx);
    Str += SplitIntoChars(Regs.Ecx);
    Str += SplitIntoChars(Regs.Edx);
    return Str;
}

std::string GetCpuVendorString()
{
    std::string VendorString;
    cpuid_regs Regs;
    __cpuid((int *)&Regs, 0x80000000);
    if (Regs.Eax >= 0x80000004)
    {
        VendorString =
            GetCpuVendorSubstring(0x80000002) +
            GetCpuVendorSubstring(0x80000003) +
            GetCpuVendorSubstring(0x80000004)
            ;
    }
    return VendorString;
}
int main()
{
   setlocale(LC_ALL, "Russian");
   std::string path;
   std::cout<<"Введите путь сохранения файла: ";
   //std::cin>>path;

   //data variables
   std::string macadress="745694376";
   std::string procauthor;
   std::string procmodel;

   //geting system info //begin

   std::string proc=GetCpuVendorString();
   procauthor=GetStringByIndex(proc,0);
   procmodel=GetStringByIndex(proc,1)+' '+GetStringByIndex(proc,2);
   std::cout<<"Производитель процессора - "<<procauthor<<std::endl;
   std::cout<<"Модель процессора        - "<<procmodel<<std::endl;



   /*
   unsigned long long int a;
   GetPhysicallyInstalledSystemMemory(&a);
   std::cout<< "Total memory: "+std::to_string(a/1000000000)+" Gb";
   */

   //geting system info //end

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
