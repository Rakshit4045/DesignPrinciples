﻿using OCP.Enums;

namespace OCP.Models
{
    public class LeaveRequest
    {
        public Guid RequestId { get; set; }
        public Guid EmployeeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int DaysRequested { get; set; }
        public LeaveStatus Status { get; set; }
        public Guid? ApprovedById { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime? ApprovedOn { get; set; }

        public LeaveRequest(Guid employeeId, LeaveType type, int days)
        {
            RequestId = Guid.NewGuid();
            EmployeeId = employeeId;
            LeaveType = type;
            DaysRequested = days;
            Status = LeaveStatus.Pending;
            RequestedOn = DateTime.Now;
        }
    }
}
