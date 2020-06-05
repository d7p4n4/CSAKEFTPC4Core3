using CSARMetaPlan.Class;
using CSEFTPC4Core3Objects.Ac4yObjects;
using System;

namespace CSAKEFTPC4Core3
{
    class Program
    {
        static void Main(string[] args)
        {/*
            new CAPs().InsertKepernyo(new Kepernyo()
            {
                Leiras = "teszt leiras képernyő"
            });
            
            new CAPs().InsertProgramKod(new Programkod()
            {
                Leiras = "teszt leirás"
            });*/


            new CAPs().InsertAc4yPersistentChild(new Ac4yPersistentChild()
            {
                name = "teszt name"
            });
            /*
            new CAPs().InsertRAMetaObjektum(new RAMetaObjektum()
            {
                 Leiras = "teszt leirás"
            });*/
        }
    }
}
