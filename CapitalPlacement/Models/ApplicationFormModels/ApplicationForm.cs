﻿namespace CapitalPlacement.Models.ApplicationFormModels
{
    public class ApplicationForm : BaseModel
    {
        public string ProgramId { get; set; }
        public string CoverImageUrl { get; set; }
        public ApplicationFormPersonalInfo PersonalInfo { get; set; } = new();
        public ApplicationFormProfile Profile { get; set; } = new();
    }
}