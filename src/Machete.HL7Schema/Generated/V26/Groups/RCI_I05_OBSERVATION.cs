// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RCI_I05_OBSERVATION (Group) - 
    /// </summary>
    public interface RCI_I05_OBSERVATION :
        HL7V26Layout
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// RESULTS
        /// </summary>
        LayoutList<RCI_I05_RESULTS> Results { get; }
    }
}