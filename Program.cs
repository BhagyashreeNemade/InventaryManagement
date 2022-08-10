namespace StockAccountManagement
{
    class Program
    {
     
        static string stockfilepath = @"C:\Users\admin1\source\repos\StockAccountManagement\StockAccountManagement\Stocklist.json";
        static void Main(string[] args)
        {
            StockMain stocklist = new StockMain();
            stocklist.DisplayStockData(stockfilepath);
                      
        }
    }
}