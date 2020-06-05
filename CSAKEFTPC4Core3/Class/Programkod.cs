using Ac4y.Annotation;

using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class Programkod : RAMetaObjektum
    {
        public int Id { get; set; }

        [Ac4yMultiline]
        public string Forrasszoveg { get; set; }

    } // Programkod

} // CSARMetaPlan.Class