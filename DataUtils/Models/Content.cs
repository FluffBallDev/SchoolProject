using System;
using System.Text.Json.Nodes;

namespace DataUtils.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Tags { get; set; }
        public string? Text { get; set; }
        public bool IsFeatured { get; set; }
        public string? Category { get; set; }
        public string? CreatedBy { get; set; }
        public bool AllowComment { get; set; }
        public string? Styling { get; set; }
        public bool RequiresAccount { get; set; }
        public string? CustomMeta { get; set; }
    }
}