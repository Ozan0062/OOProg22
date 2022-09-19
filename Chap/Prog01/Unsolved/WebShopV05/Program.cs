
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;
double tax = 1.10;
double CreditFee = 1.02;

int shippingCost = 49;
int noOfBooksInOrder = 8; 
int noOfDVDsInOrder = 3;
int noOfGamesInOrder = 2;

double priceBook = netPriceBook * noOfBooksInOrder;
double priceDVD = netPriceDVD * noOfDVDsInOrder;
double priceGames = netPriceGame * noOfGamesInOrder;

double price = priceBook + priceDVD + priceGames;
double PriceWithTax = price * tax;
double PriceWithShipping = PriceWithTax + shippingCost;
double PriceWithFee = PriceWithShipping * CreditFee;

double totalPrice = PriceWithFee;
// This variable should contain the total price for the order



Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");





