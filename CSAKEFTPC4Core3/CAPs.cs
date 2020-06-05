using CSARMetaPlan.Class;
using CSEFTPC4Core3Objects.Ac4yObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAKEFTPC4Core3
{
    class CAPs
    {/*
        public void InsertKepernyo(Kepernyo kepernyo)
        {

            using (var context = new Context())
            {
                context.Database.EnsureCreated();

                context.Keprnyos.Add(kepernyo);
                context.SaveChanges();
            }

        } // Insert
        
        public void InsertProgramKod(Programkod programkod)
        {

            using (var context = new Context())
            {
                context.Database.EnsureCreated();

                context.Programkods.Add(programkod);
                context.SaveChanges();
            }

        } // Insert*/

        public void InsertAc4yPersistentChild(Ac4yPersistentChild ac4yPersistentChild)
        {

            using (var context = new Context())
            {
                context.Database.EnsureCreated();

                context.Ac4yPersistentChilds.Add(ac4yPersistentChild);
                context.SaveChanges();
            }

        } // Insert
        /*
        public void InsertRAMetaObjektum(RAMetaObjektum raMetaObjektum)
        {

            using (var context = new Context())
            {
                context.Database.EnsureCreated();

                context.RAMetaObjektums.Add(raMetaObjektum);
                context.SaveChanges();
            }

        } // Insert*/
    }
}

