using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBrokerService.Messages
{
    public class CreateReportMessageCommand
    {
        public ReportDto Report { get; set; }
    }

    public class ReportDto
    {
        public string Location { get; set; }
        public int ContactCount { get; set; }
        public int PhoneCount { get; set; }
        public byte State { get; set; }
    }
}
