﻿namespace FidsCodingAssignment.DTO.FlightInformation
{
    public class FligtInformationDTO
    {
        public string aircraftregnumber { get; set; }
        public int parentflightid { get; set; }
        public DateTime? remote_airport_sch_dtm { get; set; }
        public DateTime? remote_airport_act_dtm { get; set; }
        public string airportcode { get; set; }
        public DateTime? eventtime { get; set; }
        public string airlinecode { get; set; }
        public string parrentsuffix { get; set; }
        public string suffix { get; set; }
        public string viaairportcodes { get; set; }
        public DateTime? sched_time { get; set; }
        public string arrdep { get; set; }
        public string bagbelt { get; set; }
        public string city_name { get; set; }
        public string flighttype { get; set; }
        public DateTime? remote_airport_est_dtm { get; set; }
        public string @event { get; set; }
        public string aircrafttype { get; set; }
        public string tail { get; set; }
        public int flightnumber { get; set; }
        public long flightid { get; set; }
        public string terminalcode { get; set; }
        public string airline_name { get; set; }
        public DateTime? actual_time { get; set; }
        public string flightstatuscode { get; set; }
        public string parentairlinecode { get; set; }
        public int parentfltnumber { get; set; }
        public string gatecode { get; set; }
        public string remarks { get; set; }
        public DateTime? estimated_time { get; set; }
        public DateTime? dep_boardingstart_dtm { get; set; }
    }
}
