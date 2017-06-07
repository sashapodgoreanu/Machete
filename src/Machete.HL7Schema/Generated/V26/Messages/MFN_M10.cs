// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M10 (Message) - 
    /// </summary>
    public interface MFN_M10 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// MFI
        /// </summary>
        Segment<MFI> MFI { get; }

        /// <summary>
        /// MF_TEST_BATTERIES
        /// </summary>
        LayoutList<MFN_M10_MF_TEST_BATTERIES> MfTestBatteries { get; }
    }
}