from json import dump,load
from random import randint,choice
from os.path import exists

num=30

for i in range(num):
    comp={}

    comp["proccreator"]=choice(["AMD","Intel"])
    if comp["proccreator"]=="AMD":
        comp["procmodel"]="Ryzen "+str(randint(3,9))
    else:
        x=randint(1,3)
        if x==1:
            comp["procmodel"]="Core i"+str(randint(3,9))
        elif x==2:
            comp["procmodel"]="Pentium G"+str(randint(1000,9999))
        else:
            comp["procmodel"]="Celeron G"+str(randint(1000,9999))
    comp["procfreq"]=str(randint(1,4))+"."+str(randint(0,9))
    
    x=randint(1,5)
    y=randint(1,x)
    comp["ramsize"]=str(pow(2,x))
    comp["rammode"]=" ".join([str(pow(2,y))]*(pow(2,x)//pow(2,y)))
    
    comp["isInternalGPU"]=str(randint(0,1))
    
    comp["gpucreator"]=choice(["NVIDIA","MSI","GIGABYTE","unknow"])
    if comp["gpucreator"]=="unknow":
        comp["gpuname"]="unknow"
        comp["gpumemory"]="0"
    else:
        comp["gpuname"]="GeForce "+choice(["GTX ","RTX "])+str(10*randint(1,3))+str(10*randint(1,9))+choice([""," Ti"])
        comp["gpumemory"]=str(pow(2,randint(0,4)))

    comp["disks"]=[]
    for j in range(randint(1,3)):
        disk={}

        disk["creator"]=choice(["Seagate","Toshiba","Western Digital"])
        if disk["creator"]=="Seagate":
            disk["model"]=choice(["BarraCuda","SkyHawk","IronWolf"])
        elif disk["creator"]=="Toshiba":
            disk["model"]=choice(["DT01","MG09","P300"])
        else:
            disk["model"]=choice(["Surveillance","Blue","Purple","IntelliPower"])
        disk["size"]=pow(2,randint(9,11))
        disk["type"]=choice(["HDD","SSD"])

        comp["disks"].append(disk)

    ID=str(100000+i)
    comp["ID"]=100000+i
    
    path="C:/Users/Никита/Desktop/comps"
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
        dump(comp,file)

    print(str(i)+"/",end="")

print()
print("Ready")
    
        
            
    
        
    
