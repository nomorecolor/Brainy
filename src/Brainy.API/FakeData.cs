using Brainy.Contracts.Dtos;
using Brainy.Contracts.Enums;

namespace Brainy.API
{
	public static class FakeData
	{
		public static AnswerSetDto GetAnswerSet(Category category)
		{
			switch (category)
			{
				case Category.Person:
					return new AnswerSetDto
					{
						Description = "Parts of the Digestive System.",
						Answers = new List<AnswerDto>
						{
							new AnswerDto
							{
								Word = "Mouth",
								Category = Category.Person
							},
							new AnswerDto
							{
								Word = "Esophagus",
								Category = Category.Person
							},
							new AnswerDto
							{
								Word = "Stomach",
								Category = Category.Person
							},
							new AnswerDto
							{
								Word = "Small Intestine",
								Category = Category.Person
							},
							new AnswerDto
							{
								Word = "Large Intestine",
								Category = Category.Person
							}
						}
					};
				case Category.Thing:
					return new AnswerSetDto
					{
						Description = "Brand of Cars.",
						Answers = new List<AnswerDto>()
						{
							new AnswerDto
							{
								Word = "Ford",
								Category = Category.Thing
							},
							new AnswerDto
							{
								Word = "Chevrolet",
								Category = Category.Thing
							},
							new AnswerDto
							{
								Word = "Toyota",
								Category = Category.Thing
							},
							new AnswerDto
							{
								Word = "Honda",
								Category = Category.Thing
							},
							new AnswerDto
							{
								Word = "Nissan",
								Category = Category.Thing
							}
						}
					};
				case Category.Animal:
					return new AnswerSetDto
					{
						Description = "Animals with 4 feet.",
						Answers = new List<AnswerDto>
						{
							new AnswerDto
							{
								Word = "Dog",
								Category = Category.Animal
							},
							new AnswerDto
							{
								Word = "Cat",
								Category = Category.Animal
							},
							new AnswerDto
							{
								Word = "Horse",
								Category = Category.Animal
							},
							new AnswerDto
							{
								Word = "Cow",
								Category = Category.Animal
							},
							new AnswerDto
							{
								Word = "Pig",
								Category = Category.Animal
							}
						}
					};
				case Category.Place:
					return new AnswerSetDto
					{
						Description = "Countries in South East Asia.",
						Answers = new List<AnswerDto>
						{
							new AnswerDto
							{
								Word = "Philippines",
								Category = Category.Place
							},
							new AnswerDto
							{
								Word = "Thailand",
								Category = Category.Place
							},
							new AnswerDto
							{
								Word = "Vietnam",
								Category = Category.Place
							},
							new AnswerDto
							{
								Word = "Malaysia",
								Category = Category.Place
							},
							new AnswerDto
							{
								Word = "Singapore",
								Category = Category.Place
							}
						}
					};
				case Category.Food:
					return new AnswerSetDto
					{
						Description = "Fruits that are red.",
						Answers = new List<AnswerDto>()
						{
							new AnswerDto
							{
								Word = "Apple",
								Category = Category.Food
							},
							new AnswerDto
							{
								Word = "Strawberry",
								Category = Category.Food
							},
							new AnswerDto
							{
								Word = "Cherry",
								Category = Category.Food
							},
							new AnswerDto
							{
								Word = "Watermelon",
								Category = Category.Food
							},
							new AnswerDto
							{
								Word = "Tomato",
								Category = Category.Food
							}
						}
					};
			}

			throw new Exception("Invalid category");
		}
	}
}
