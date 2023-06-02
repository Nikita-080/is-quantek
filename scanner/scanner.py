import wmi 

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
    computer = wmi.WMI()
    print("=====CPU=====")
    proc=computer.Win32_Processor()[0]
    procname=proc.Name.split()
    proccreator=procname[0]
    procmodel=procname[1]+' '+procname[2]
    procfreq=str(int(float(proc.MaxClockSpeed)/1000))
    print("Производитель процессора -",proccreator)
    print("Модель процессора        -",procmodel)
    print("Частота процессора       -",procfreq)

    print("=====DISK====")
    disksize=Round2(psutil.disk_usage("C:/").total/pow(2,30)) #WARNING (TODO some disks)
    print("Объем диска              -",disksize)

    print("=====RAM=====")
    ram=str(round(psutil.virtual_memory().total/pow(2,30)))
    print("Оперативная память       -",ram)

    print("=====GPU=====")
    gpu=computer.Win32_VideoController()[0]
    gpuname=gpu.Name
    gpumemory=gpu.AdapterRAM
    print("Видекарта                -",gpuname)
    print("Видеопамять              -",gpumemory)

    #get system info #end

    if path!="n":
        with open(path+"\\"+macadress+".txt") as f:
            f.write(data)
            print("Данные сохранены")
            break
    break
