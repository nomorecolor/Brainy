using Brainy.Contracts.Enums;

namespace Brainy.UI.State
{
	public class StateData
	{
		private ICollection<Category> _categories;
		public ICollection<Category> Categories { get => _categories; set { _categories = value; NotifyStateChanged(); } }

		private int _round;
		public int Round { get => _round; set { _round = value; NotifyStateChanged(); } }

		public void RemoveCategory(Category category)
		{
			Categories.Remove(category);

			NotifyStateChanged();
		}

		public void Reset()
		{
			Categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToHashSet();
			Round = 0;
		}

		public Action? OnStateChanged { get; set; }
		private void NotifyStateChanged() => OnStateChanged?.Invoke();
	}
}
