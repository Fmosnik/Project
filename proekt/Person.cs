using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    public class Person
    {
        public int nomer;
        public String FIO;
        public String Sex;
        private DateTime bd;
        public int growth;
        public int weight;
        public String nevrolog;
        public String lor;
        public String okylist;
        public String xiryrg;
        public String derma;
        public String pcix;
        public String stomac;
        public String terapevt;
        
        public Person(){}

        public Person(int nom, string name, string sex, DateTime born, int grow, int weig, string nevr, string LOR, string okyl,
        string xir, string derm, string pci, string stom, string ter)
        {
            nomer = nom; FIO = name; Sex = sex;
            bd = born; growth = grow; weight = weig;
            nevrolog = nevr; lor = LOR; okylist = okyl;
            xiryrg = xir; derma = derm;
            pcix = pci; stomac = stom; terapevt = ter;
        }

        public Person(Person p)
        {
            nomer = p.nomer; FIO = p.FIO; Sex = p.Sex;
            bd = p.bd; growth = p.growth; weight = p.weight;
            nevrolog = p.nevrolog; lor = p.lor; okylist = p.okylist;
            xiryrg = p.xiryrg; derma = p.derma;
            pcix = p.pcix; stomac = p.stomac; terapevt = p.terapevt;
        }
        public String to_ListItem()
        { return this.FIO + " " + bd.ToString("dd/MM/yyyy"); }
        public int getNomer()
        {
            return nomer;
        }
        public void setNomer(int nomer)
        {
            this.nomer = nomer;
        }
        public string getFIO()
        {
            return FIO;
        }
        public void setFIO(string FIO)
        {
            this.FIO = FIO;
        }

        public string getSex()
        {
            return Sex;
        }
        public void setSex(string sex)
        {
            this.Sex = sex;
        }
        public DateTime getBd()
        {
            return bd;
        }
        public void setBd(DateTime bd)
        {
            this.bd = bd;
        }
        public int getGrougth()
        {
            return growth;
        }
        public void setGrougth(int grougth)
        {
            this.growth = grougth;
        }
        public int getWeigth()
        {
            return weight;
        }
        public void setWeigth(int weigth)
        {
            this.weight = weight;
        }
        public string getNevrolog()
        {
            return nevrolog;
        }

        public void setNevrolog(string nevrolog)
        {
            this.nevrolog = nevrolog;
        }
        public string getLor()
        {
            return lor;
        }
        public void setLor(string lor)
        {
            this.lor = lor;
        }
        public string getOkylist()
        {
            return okylist;
        }
        public void setOkylist(string okylist)
        {
            this.okylist = okylist;
        }
        public string getXiryrg()
        {
            return xiryrg;
        }
        public void setXiryrg(string xiryrg)
        {
            this.xiryrg = xiryrg;
        }
        public string getDerma()
        {
            return derma;
        }
        public void setDerma(string derma)
        {
            this.derma = derma;
        }

        public string getPcix()
        {
            return pcix;
        }
        public void setPcix(string pcix)
        {
            this.pcix = pcix;
        }
        public string getStomac()
        {
            return stomac;
        }
        public void setstomac(string stomac)
        {
            this.stomac = stomac;
        }
        public string getTerapevt()
        {
            return terapevt;
        }
        public void setTerapevt(string terapevt)
        {
            this.terapevt = terapevt;
        }
    }

    
}
