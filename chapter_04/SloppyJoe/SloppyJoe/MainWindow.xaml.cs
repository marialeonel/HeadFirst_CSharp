using System.Windows;
using System.Windows.Controls;

namespace SloppyJoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            var menuItems = CreateMenuItems();
            var items = GetItemTextBlocks();
            var prices = GetPriceTextBlocks();

            FillMenu(menuItems, items, prices);
            CreateSpecialItem();
            CreateGuacamoleOption();
        }

        private MenuItem[] CreateMenuItems()
        {
            MenuItem[] menuItems = new MenuItem[5];

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();

                if (i >= 3)
                {
                    menuItems[i].Breads = [
                        "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
                    ];
                }

                menuItems[i].Generate();
            }

            return menuItems;
        }

        private List<TextBlock> GetItemTextBlocks()
        {
            return GridMenuItem.Children
                .OfType<TextBlock>()
                .Where(tb => tb.Name.StartsWith("item") && !tb.Name.EndsWith("6"))
                .OrderBy(tb => tb.Name)
                .ToList();
        }

        private List<TextBlock> GetPriceTextBlocks()
        {
            return GridMenuItem.Children
                .OfType<TextBlock>()
                .Where(tb => tb.Name.StartsWith("price") && !tb.Name.EndsWith("6"))
                .OrderBy(tb => tb.Name)
                .ToList();
        }

        private void FillMenu(MenuItem[] menuItems, List<TextBlock> items, List<TextBlock> prices)
        {
            int firstFiveMenuItemsCount =  5;
            for (int i = 0; i < firstFiveMenuItemsCount; i++) 
            {
                items[i].Text = menuItems[i].Description;
                prices[i].Text = menuItems[i].Price.ToString();
            }
        }

        private void CreateSpecialItem()
        {
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = ["Organic ham", "Mushroom patty", "Mortadella"],
                Breads = ["a gluten free roll", "a wrap", "pita"],
                Condiments = ["dijon mustard", "miso dressing", "au jus"]
            };

            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;
        }

        private void CreateGuacamoleOption()
        {
            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();

            string guacamolePrice = guacamoleMenuItem.Price;
            guacamole.Text = $"Add guacamole for {guacamolePrice}";
        }
    }
}