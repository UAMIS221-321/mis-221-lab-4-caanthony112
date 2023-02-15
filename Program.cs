// start main
int userChoice = GetUserChoice(); 
while(userChoice!=3) { 
    RouteEm(userChoice);
    userChoice = GetUserChoice(); 
}
// end main

static int GetUserChoice() { 
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
}
else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice=="1" || userChoice=="2" || userChoice=="3") {
        return true;
    }
    return false;
}

static void GetFull() {
    full();
    PauseAction();
}

static void GetPartial() {
    partial();
    PauseAction();
}

static void SayInvalid() {
    Console.WriteLine("Invalid");
    PauseAction();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2) {
        GetPartial();
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
}
static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void full() {
    Random rnd= new Random();
    int rows = rnd.Next(2,10);

    
    for(int i = 0; i <= rows; i++) {
        for(int j = 0; j <= i; j++) {
            Console.Write(0);
        }
        Console.WriteLine();
    }
}

static void partial() {
    Random rnd= new Random();
    
    for(int i = 3; i <= 9; i++) {
        for(int j = 0; j < i; j++) {
            if(rnd.Next(2) == 0) {
                Console.Write(" ");
            } else {
                Console.Write("0");
            }
        }
        Console.WriteLine();
    }
}
