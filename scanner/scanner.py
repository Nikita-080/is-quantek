from winreg import * #for processor
import platform

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
    print("Производитель процессора -",proccreator)
    print("Модель процессора        -",procmodel)
    

    #get system info #end

    if path!="n":
        with open(path+"\\"+macadress+".txt") as f:
            f.write(data)
            print("Данные сохранены")
            break
        
