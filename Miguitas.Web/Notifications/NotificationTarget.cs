namespace Miguitas.Web.Notifications
{
    using System.Collections.Generic;

    public class NotificationTarget
    {
        public string Type { get; set; }

        public List<string> Devices { get; set; }
    }
}
