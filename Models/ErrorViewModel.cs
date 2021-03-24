using System;

namespace pipelines_dotnet_core.Models
{
    public class ErrorViewModel
    {
        //requestid
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
