using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    Items = new ObservableCollection<Item>();
    for (int i = 0; i < 100; i++)
    {
      Items.Add(new Item
      {
        Name = $"item {i}",
        View = new Label
        {
          Text = "Content View Label"
        }
      });
    }
  }

  public ObservableCollection<Item> Items { get; set; }

  //[ObservableProperty]
  //private bool _collectionIsVisible = true;

  //[ObservableProperty]
  //private bool _otherIsVisible;

  //[RelayCommand]
  //void MakeVisible()
  //{
  //  CollectionIsVisible = !CollectionIsVisible;
  //  OtherIsVisible = !OtherIsVisible;
  //}
}

public class Item
{
  public string Name { get; set; }

  public IView View { get; set; }
}