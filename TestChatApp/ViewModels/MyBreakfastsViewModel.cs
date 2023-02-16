using CommunityToolkit.Mvvm.ComponentModel;
using TestChatApp.Models;

namespace TestChatApp.ViewModels
{
    public partial class MyBreakfastsViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Breakfast> breakfasts;

        public MyBreakfastsViewModel()
        {
            LoadBreakfasts();
        }

        private void LoadBreakfasts()
        {
            Breakfasts = new List<Breakfast>()
            {
                new Breakfast("Vegan Sunshine",
                    "Vegan everything! Join us for a healthy breakfast full of vegan goodies",
                    DateTime.Now.AddDays(1),
                    DateTime.Now.AddDays(1).AddHours(-3),
                    new Uri("https://cdn77-s3.lazycatkitchen.com/wp-content/uploads/2019/04/vegan-breakfast-bowl-portion-1000x1500.jpg"),
                    new List<string>() { "Olive oil", "Cherry Tomatoes","Potatoes", "Salt and pepper"},
                    new List<string>(){ "Pudding" }),

                new Breakfast("Fluffy Pancakes",
                    "The fluffiest pancakes you will ever try",
                    DateTime.Now.AddDays(1),
                    DateTime.Now.AddDays(1).AddHours(-3),
                    new Uri("https://realfood.tesco.com/media/images/1400x919-Pink-ombre-pancakes-283d8170-a45b-4bc5-a3e9-ef09ad841530-0-1400x919.jpg"),
                    new List<string>(){ "Espresso" },
                    new List<string>() { "Pancakes", "Maple Syrup","Seasonal fruits"}
                    ),
            };
        }
    }
}

