from winreg import * #for processor
import platform
import psutil        #processor freq, disk

def Round2(x):
    i=1
    while i<x:
        i*=2
    return i


while True:
    print("Введите папку для сохранения (или n):")
    path=input()
    if path[-1]=='"':
        path=path[1:-1]
    if path[-1]=="/" or path[-1]=="\\":
        path=path[:-1]

    #variables
    


    #get system info #begin
        
    aReg = ConnectRegistry(None, HKEY_LOCAL_MACHINE)
    aKey = OpenKey(aReg, r"HARDWARE\DESCRIPTION\System\CentralProcessor\0")
    proc = QueryValueEx(aKey, 'ProcessorNameString')[0].split()
    proccreator=proc[0]
    procmodel=proc[1]+' '+proc[2]
    procfreq=str(int(float(psutil.cpu_freq().max)/1000))
    print("Производитель процессора -",proccreator)
    print("Модель процессора        -",procmodel)
    print("Частота процессора       -",procfreq)

    disksize=Round2(psutil.disk_usage("C:/").total/pow(2,30)) #WARNING (TODO some disks)
    print("Объем диска              -",disksize)
    

    #get system info #end

    if path!="n":
        with open(path+"\\"+macadress+".txt") as f:
            f.write(data)
            print("Данные сохранены")
            break
        
