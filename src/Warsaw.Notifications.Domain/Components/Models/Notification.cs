using System;
using System.Collections.Generic;

namespace Warsaw.Notifications.Domain.Components.Models
{
    public class Notification
    {
        public string Category { get; set; }
        public string City { get; set; }
        public string Subcategory { get; set; }
        public string District { get; set; }
        public object AparmentNumber { get; set; }
        public string NotificationType { get; set; }
        public DateTime CreateDate { get; set; }
        public string Source { get; set; }
        public string Street { get; set; }
        public string DeviceType { get; set; }
        public IEnumerable<Status> Statuses { get; set; } = new List<Status>();
        public string NotificationNumber { get; set; }
        public string Event { get; set; }
    }
}