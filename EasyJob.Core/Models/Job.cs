using System;

namespace EasyJob.Core.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PostedOn { get; set; }
    }
}
