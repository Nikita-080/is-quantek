from wmi import WMI
from json import dump

D30=pow(2,30)

def Round2(x):
    i=1
    while i<x:
        i*=2
    return i

def Fix(x,kind,devision=1):
    if kind=="int":
        return -1 if x==None else int(x)//devision
    elif kind=="float":
        return -1 if x==None else float(x)/devision
    elif kind=="degree":
        return -1 if x==None else Round2(abs(int(x))//devision)
    elif kind=="string":
        return "unknow" if x==None else x
    elif kind=="shared_string":
        return "unknow unknow" if x==None else x
    
while True:
    print("Нажмите Enter для начала сканирования...")
    input()
    
    #get system info #begin

    try:
        computer = WMI()
        print("=====CPU=====")
        proccreator="unknow"
        procmodel="unknow"
        procfreq=-1
        processors=computer.Win32_Processor()
        if len(processors)>0:
            procname=processors[0].Name
            if procname!=None:
                procname=procname.split()+["unknow","unknow"]
                proccreator=procname[0]
                procmodel=procname[1]+' '+procname[2]
            procfreq=Fix(processors[0].MaxClockSpeed,"float",1000)
        print("Производитель процессора -",proccreator)
        print("Модель процессора        -",procmodel)
        print("Частота процессора       -",procfreq)

        print("=====DISK====")
        disklist=[]
        disks=computer.Win32_DiskDrive()
        for disk in disks:
            diskitem={}
            diskitem["model"]=Fix(disk.Model,"string")
            diskitem["size"]=Fix(disk.Size,"degree",D30)
            diskitem["type"]=Fix(disk.MediaType,"string")
            if ' ' in diskitem["model"]:
                diskitem["creator"]=diskitem["model"].split()[0]
            else:
                diskitem["creator"]="unknow"
            disklist.append(diskitem)
            print("---DISK--")
            print("Производитель            -",diskitem["creator"])
            print("Модель                   -",diskitem["model"])
            print("Размер                   -",diskitem["size"])
            print("Тип                      -",diskitem["type"])

        print("=====RAM=====")
        rams=computer.Win32_PhysicalMemory()
        ramsize=0
        rammode=[]
        for ram in rams:
            size=Fix(ram.Capacity,"int",D30)
            if size==-1:
                rammode.append("x")
            else:
                ramsize+=size
                rammode.append(str(size))
        rammode=" ".join(rammode)
        print("Объем                    -",ramsize)
        print("Конфигурация             -",rammode)

        print("=====GPU=====")
        gpulist=[]
        gpus=computer.Win32_VideoController()
        for gpu in gpus:
            print(gpu)
            gpuitem={}
            gpuitem["name"]=Fix(gpu.Name,"string")
            gpuitem["memory"]=Fix(gpu.AdapterRam,"degree",D30)
            gpuitem["creator"]=Fix(gpu.Name,"shared_string").split()[0]
            gpulist.append(gpuitem)
            print("---GPU---")
            print("Производитель            -",gpuitem["creator"])
            print("Модель                   -",gpuitem["name"])
            print("Память                   -",gpuitem["memory"])
    except Exception as error:
        print("Ошибка во время получения данных. Подробнее...")
        print(error)
        continue

    #get system info #end

    #preparing data

    data={"procname":proccreator,
          "procmodel":procmodel,
          "procfreq":procfreq,
          "disks":disklist,
          "ramsize":ramsize,
          "rammode":rammode,
          "gpus":gpulist}
    
    #saving
    
    print("Выполнить сохранение данных? [y/n]")
    command=""
    while command not in ["y","n"]:
        command=input()
    if command=="y":
        path=input("Введите папку для сохранения: ")
        ID=input("Введите номер устройства: ")
        if path[-1]=='"':
            path=path[1:-1]
        if path[-1]=="/" or path[-1]=="\\":
            path=path[:-1]
        try:
            with open(path+"\\"+ID+".json", "w") as file:
                dump(data,file)
            print("Данные сохранены")
        except Exception as error:
            print("Ошибка во время сохранения. Подробнее...")
            print(error)
        
            
    
        
    
