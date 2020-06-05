using Ac4y.Annotation;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public partial class MegfeleltetesElem : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesElem.Forras")]
        public RAMetaObjektum Forras { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesElem.Cel")]
        public RAMetaObjektum Cel { get; set; }

    } // MegfeleltetesElem

} // CSARMetaPlan.Class