// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAS_O17_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface RAS_O17_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// RXO
        /// </summary>
        Segment<RXO> RXO { get; }

        /// <summary>
        /// ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        Layout<RAS_O17_ORDER_DETAIL_SUPPLEMENT> OrderDetailSupplement { get; }
    }
}