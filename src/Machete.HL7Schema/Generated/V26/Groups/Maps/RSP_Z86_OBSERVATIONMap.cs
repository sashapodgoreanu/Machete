// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z86_OBSERVATION (GroupMap) - 
    /// </summary>
    public class RSP_Z86_OBSERVATIONMap :
        HL7V26LayoutMap<RSP_Z86_OBSERVATION>
    {
        public RSP_Z86_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0);
            Segment(x => x.NTE, 1);
        }
    }
}