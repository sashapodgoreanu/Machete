// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M11_MF_TEST_CALCULATED (GroupMap) - 
    /// </summary>
    public class MFN_M11_MF_TEST_CALCULATEDMap :
        HL7V26LayoutMap<MFN_M11_MF_TEST_CALCULATED>
    {
        public MFN_M11_MF_TEST_CALCULATEDMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.OM1, 1, x => x.Required = true);
            Layout(x => x.MfTestCalcDetail, 2);
        }
    }
}