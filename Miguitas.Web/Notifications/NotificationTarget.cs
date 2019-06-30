namespace Miguitas.Web.Notifications
{
    using System.Collections.Generic;

    public class NotificationTarget
    {
        public string type { get; set; }

        public List<string> devices { get; set; }
    }
}
