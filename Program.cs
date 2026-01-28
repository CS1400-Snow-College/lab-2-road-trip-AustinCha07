// Road Trip Summary 

Console.WriteLine("We are going to map out a road trip for Fall Break.");
Console.WriteLine("I'm going to ask you some specific questions about the trip, and then I'll calculate a trip summary from that information.");
Console.WriteLine();

// user input
Console.Write("Where will you be driving? ");
string destination = Console.ReadLine();

Console.Write("Who will be driving? ");
string driver = Console.ReadLine();

Console.Write("How many miles to get to " + destination + "? ");
int miles = Convert.ToInt32(Console.ReadLine());

Console.Write("What average speed (MPH) will " + driver + " be travelling? ");
int speed = Convert.ToInt32(Console.ReadLine());

Console.Write("How many MPG does your car get? ");
double mpg = Convert.ToDouble(Console.ReadLine());

Console.Write("How many gallons of gas does your car hold? ");
int tankSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Excluding the driver, how many riders in the car? ");
int riders = Convert.ToInt32(Console.ReadLine());
int totalPeople = riders + 1;

Console.Write("What unit of currency ($, £, ¥, €) do you use? ");
char currency = Convert.ToChar(Console.ReadLine());

Console.Write("What is the fuel price per gallon (" + currency + ")? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// calculations
double roundTripMiles = miles * 2;
double drivingTime = miles / (double)speed;
int hours = (int)drivingTime;
int minutes = (int)((drivingTime - hours) * 60);

double fuelNeeded = roundTripMiles / mpg;
double rangePerTank = mpg * tankSize;
int fuelStops = (int)(fuelNeeded / tankSize) + 1;

double fuelCost = fuelNeeded * gasPrice;
double costPerPerson = fuelCost / totalPeople;
double costPerMile = fuelCost / roundTripMiles;
double costPerHour = fuelCost / drivingTime;


double avgSongLength = 3.5;
int songsNeeded = (int)((drivingTime * 60) / avgSongLength);

// rounding
fuelNeeded = Math.Round(fuelNeeded, 2);
rangePerTank = Math.Round(rangePerTank, 2);
fuelCost = Math.Round(fuelCost, 2);
costPerPerson = Math.Round(costPerPerson, 2);
costPerMile = Math.Round(costPerMile, 2);
costPerHour = Math.Round(costPerHour, 2);

// output 
Console.WriteLine("Driver:".PadRight(25) + driver);
Console.WriteLine("Currency:".PadRight(25) + currency);
Console.WriteLine();

Console.WriteLine("Distance (miles):".PadRight(25) + miles);
Console.WriteLine("Average Speed (mph):".PadRight(25) + speed);
Console.WriteLine("Time Driving:".PadRight(25) + hours + "H " + minutes + "M");
Console.WriteLine();

Console.WriteLine("Vehicle Miles per Gallon:".PadRight(25) + mpg);
Console.WriteLine("Fuel Needed (round trip):".PadRight(25) + fuelNeeded + " gallons");
Console.WriteLine("Range per tank:".PadRight(25) + rangePerTank);
Console.WriteLine("Estimated Fuel Stops:".PadRight(25) + fuelStops);
Console.WriteLine();

Console.WriteLine("Gas Price per gallon:".PadRight(25) + currency + gasPrice);
Console.WriteLine("Fuel Cost:".PadRight(25) + currency + fuelCost);
Console.WriteLine("Riders (split):".PadRight(25) + totalPeople);
Console.WriteLine("Cost per person:".PadRight(25) + currency + costPerPerson + " (+ Snacks)");
Console.WriteLine("Cost per mile:".PadRight(25) + currency + costPerMile);
Console.WriteLine("Cost per driving hour:".PadRight(25) + currency + costPerHour);
Console.WriteLine();

Console.WriteLine("Average song length (min):".PadRight(25) + avgSongLength);
Console.WriteLine("Number of songs needed:".PadRight(25) + songsNeeded);
