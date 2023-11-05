using Brainy.UI.Enums;

namespace Brainy.UI.State
{
	public class StateData
	{
		private ICollection<Categories> _categories;
		public ICollection<Categories> Categories { get => _categories; set { _categories = value; NotifyStateChanged(); } }

		private int _round;
		public int Round { get => _round; set { _round = value; NotifyStateChanged(); } }

		public void RemoveCategory(Categories category)
		{
			Categories.Remove(category);

			NotifyStateChanged();
		}

		public void Reset()
		{
			Categories = Enum.GetValues(typeof(Categories)).Cast<Categories>().ToHashSet();
			Round = 0;
		}

		public Action? OnStateChanged { get; set; }
		private void NotifyStateChanged() => OnStateChanged?.Invoke();
	}
}
