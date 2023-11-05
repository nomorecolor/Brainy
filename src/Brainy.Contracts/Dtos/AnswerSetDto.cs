namespace Brainy.Contracts.Dtos
{
    public class AnswerSetDto
    {
        public string Description { get; set; } = string.Empty;
        public ICollection<AnswerDto> Answers { get; set; } = new List<AnswerDto>();
    }
}
