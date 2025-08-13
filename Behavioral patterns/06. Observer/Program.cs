namespace Observer;

class Program
{
    static void Main()
    {
        var agency = new NewsAgency();

        var newspaper = new Newspaper();
        var tvChannel = new TVChannel();

        agency.Attach(newspaper);
        agency.Attach(tvChannel);

        agency.News = "Паттерн Наблюдатель реализован!";

        // Можно отписать наблюдателя
        agency.Detach(tvChannel);

        agency.News = "Вторая новость для подписчиков.";
    }
}
