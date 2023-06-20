from wmi import WMI
from json import dump,load
from os.path import exists
import GPUtil

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

def FixPath(s):
    if s[-1]=='"' and len(s)>1:
        s=s[1:-1]
    if s[-1]=="/" or s[-1]=="\\":
        s=s[:-1]
    return s

while True:
    print("Нажмите Enter для начала сканирования...")
    input()
    
    #get system info #begin

    try:
        computer = WMI()
        print("=====CPU=====")
        proccreator="unknow"
        procmodel="unknow"
        procfreq=0
        processors=computer.Win32_Processor()
        if len(processors)>0:
            proccreator=Fix(processors[0].Manufacturer,"string")
            procmodel=Fix(processors[0].Name,"string")
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
        gpus=computer.Win32_VideoController()
        isInternalGPU=False
        gpuname="unknow"
        gpumemory=0
        gpucreator="unknow"
        for gpu in gpus:
            gputype=Fix(gpu.AdapterDACType,"string")
            if gputype!="unknow" and "Internal" in gputype:
                isInternalGPU=True
                break

        gpus=GPUtil.getGPUs()
        for gpu in gpus:
            gpuname=Fix(gpu.name,"string")
            gpumemory=Fix(gpu.memoryTotal,"degree",1024)
            gpucreator=Fix(gpu.name,"shared_string").split()[0]
            print("Производитель            -",gpucreator)
            print("Модель                   -",gpuname)
            print("Память                   -",gpumemory)
            break
        print("Встроенная видеокарта    -","да" if isInternalGPU else "нет")
    except Exception as error:
        print("Ошибка во время получения данных. Подробнее...")
        print(error)
        continue

    #get system info #end

    #preparing data

    data={"proccreator":proccreator,
          "procmodel":procmodel,
          "procfreq":str(procfreq),
          "disks":disklist,
          "ramsize":str(ramsize),
          "rammode":rammode,
          "isInternalGPU":str(int(isInternalGPU)),
          "gpucreator":gpucreator,
          "gpuname":gpuname,
          "gpumemory":str(gpumemory)}
    
    #saving
    
    command=""
    while command not in ["y","n"]:
        command=input("Выполнить сохранение данных? [y/n] ")
    if command=="y":
        path=""
        ID=""
        while not exists(path):
            path=input("Введите папку для сохранения: ")
            path=FixPath(path)
        while not ID.isdigit():
            ID=input("Введите номер устройства: ")
        data["ID"]=int(ID)

        try:
            if exists(path+"\\metadata.json"):
                with open(path+"\\metadata.json") as file:
                    metadata=load(file)
                    metadata.append(ID)
                    metadata=list(set(metadata))
                with open(path+"\\metadata.json", "w") as file:
                    dump(metadata,file)
            else:
                with open(path+"\\metadata.json", "w") as file:
                    dump([ID],file)
                
            with open(path+"\\"+ID+".json", "w") as file:
                dump(data,file)
            print("Данные сохранены")
        except Exception as error:
            print("Ошибка во время сохранения. Подробнее...")
            print(error)
        
            
    
        
    
