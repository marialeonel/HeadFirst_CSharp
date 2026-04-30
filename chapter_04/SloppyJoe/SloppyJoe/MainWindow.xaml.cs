using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            MenuItem[] menuItems = new MenuItem[5];
            String guacamolePrice;

            for(int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if(i >= 3)
                {
                    menuItems[i].Breads = [
                        "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
                    ];
                }

                menuItems[i].Generate();
            }

            var items = GridMenuItem.Children
                .OfType<TextBlock>()
                .Where(tb => tb.Name.StartsWith("item") && !tb.Name.EndsWith("6"))
                .OrderBy(tb => tb.Name)
                .ToList();

            var prices = GridMenuItem.Children
                .OfType<TextBlock>()
                .Where(tb => tb.Name.StartsWith("price") && !tb.Name.EndsWith("6"))
                .OrderBy(tb => tb.Name)
                .ToList();

            for (int i = 0; i < 5; i++)
            {
                items[i].Text = menuItems[i].Description;
                prices[i].Text = menuItems[i].Price.ToString();
            }

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = ["Organic ham", "Mushroom patty", "Mortadella"],
                Breads = ["a gluten free roll", "a wrap", "pita"],
                Condiments = ["dijon mustard", "miso dressing", "au jus"]
            };

            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;

            guacamole.Text = $"Add guacamole for {guacamolePrice}";
        }
    }
}