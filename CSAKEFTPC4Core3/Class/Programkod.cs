using Ac4y.Annotation;
using CSAKEFTPC4Core3.Class;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class Programkod : GrandPa
    {
        public int Id { get; set; }

        [Ac4yMultiline]
        public string Forrasszoveg { get; set; }

    } // Programkod

} // CSARMetaPlan.Class