using JimmyLinq;

var done = false;
while(!done)
{
    Console.WriteLine("\nPress G to group comics by price, R to get reviews, any other key to quit\n");
    var key = Console.ReadKey().KeyChar;

    switch(key)
    {
        case 'G':
        case 'g':
            done = GroupComicsByPrice();
            break;
        case 'R':
        case 'r':
            done = GetReviews();
            break;
        default:
            done = true;
            break;
    }
}

bool GroupComicsByPrice()
{
    var groups = ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);
    foreach (var group in groups)
    {
        Console.WriteLine($"\n{group.Key} Comics:");
        foreach (var comic in group)
            Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issue]:c}");
    }
    return false;
}

bool GetReviews()
{
    var reviews = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);
    foreach (var review in reviews)
        Console.WriteLine(review);
    return false;
}