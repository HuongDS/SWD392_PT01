namespace EVCare.API.Dtos
{
    public class BookingRequestDto
    {
        public DateTime ScheduledTime { get; set; }
        public string Description { get; set; }
        public string SkillRequired { get; set; } = string.Empty;
    }
}
