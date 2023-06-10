using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformSystem
{
    internal class Computer
    {
        public int ID;
        public string procmodel;
        public string proccreator;
        public string procfreq;
        public List<Disk> disks;
        public string ramsize;
        public string rammode;
        public string isInternalGPU;
        public string gpucreator;
        public string gpumemory;
        public string gpuname;
    }
}
