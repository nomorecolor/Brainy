using Brainy.Contracts.Enums;

namespace Brainy.Contracts.Dtos
{
	public class AnswerDto
	{
		public string Word { get; set; } = string.Empty;
		public bool IsCorrect { get; set; }
		public Category Category { get; set; }
	}
}