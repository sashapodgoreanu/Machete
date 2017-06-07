// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGV_O15_COMPONENTS (Group) - 
    /// </summary>
    public interface RGV_O15_COMPONENTS :
        HL7V26Layout
    {
        /// <summary>
        /// RXC
        /// </summary>
        Segment<RXC> RXC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}