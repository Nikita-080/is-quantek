from wmi import WMI
from json import dump

def Round2(x):
    i=1
    while i<x:
        i*=2
    return i

while True:
    print("Нажмите Enter для начала сканирования...")
    input()
    
    #get system info #begin

    try:
        computer = WMI()
        print("=====CPU=====")
        proc=computer.Win32_Processor()[0]
        procname=proc.Name.split()
        proccreator=procname[0]
        procmodel=procname[1]+' '+procname[2]
        procfreq=str(float(proc.MaxClockSpeed)/1000)
        print("Производитель процессора -",proccreator)
        print("Модель процессора        -",procmodel)
        print("Частота процессора       -",procfreq)

        print("=====DISK====")
        disklist=[]
        disks=computer.Win32_DiskDrive()
        for disk in disks:
            diskitem={}
            diskitem["model"]=disk.Model
            diskitem["size"]=str(Round2(int(disk.Size)/pow(2,30)))
            diskitem["type"]=disk.MediaType
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
            size=round(int(ram.Capacity)/pow(2,30))
            ramsize+=size
            rammode.append(str(size))
        rammode=" ".join(rammode)
        ramsize=str(ramsize)
        print("Объем                    -",ramsize)
        print("Конфигурация             -",rammode)

        print("=====GPU=====")
        gpulist=[]
        gpus=computer.Win32_VideoController()
        for gpu in gpus:
            gpuitem={}
            gpuitem["name"]=gpu.Name
            gpuitem["memory"]=str(round(abs(gpu.AdapterRam)/pow(2,30)))
            gpuitem["creator"]=gpu.Name.split()[0]
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
        
            
    
        
    
