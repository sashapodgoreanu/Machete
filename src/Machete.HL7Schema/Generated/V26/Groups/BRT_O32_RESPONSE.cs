// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BRT_O32_RESPONSE (Group) - 
    /// </summary>
    public interface BRT_O32_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<BRT_O32_ORDER> Order { get; }
    }
}