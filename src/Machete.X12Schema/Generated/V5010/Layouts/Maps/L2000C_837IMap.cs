﻿namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_837IMap :
        X12LayoutMap<L2000C_837I, X12Entity>
    {
        public L2000C_837IMap()
        {
            Id = "2000C";
            Name = "Patient Heirarchical Level";
            
            Segment(x => x.PatientHeirarchicalLevel, 0);
            Segment(x => x.PatientInformation, 1, x => x.IsRequired());
            Layout(x => x.Patient, 2);
            Layout(x => x.ClaimInformation, 3);
        }
    }
}