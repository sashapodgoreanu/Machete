// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RQP_I04_PROVIDER (Group) - 
    /// </summary>
    public interface RQP_I04_PROVIDER :
        HL7V26Layout
    {
        /// <summary>
        /// PRD
        /// </summary>
        Segment<PRD> PRD { get; }

        /// <summary>
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }
    }
}