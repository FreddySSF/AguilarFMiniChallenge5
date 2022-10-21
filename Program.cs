// Fernando Aguilar
// 10-20-22
// Mini Challenge #5 Madlib Endpoint
// Creating a mad lib console project. The user will input twelve different inputs when prompted.
// Then the program will output a short story based off of the inputs given by the user. Include data validation.
// Peer Reviewed By: Jessie Lamzon

Console.Clear();

bool notNum;
bool playAgain = true;
int noNum = 0;
string endGame = "YES";
while(playAgain)
{
    Console.WriteLine(" Hello there! Let's write a short story together! ");

    Console.WriteLine(" I will need your help filling in the holes in this story. ");

Console.WriteLine(" Choose your name. Type end to close program.");

string name1 = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(name1, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter your name. ");
    name1 = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(name1, out noNum);

}

if(name1 == "end".ToUpper())
{
    playAgain = false;
    Console.WriteLine(" Have a good day! ");
    break;
}
else
{

Console.WriteLine(" Choose a method of transportation. ");
string methodOfTrans = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(methodOfTrans, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter a method of transportation. ");
    methodOfTrans = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(methodOfTrans, out noNum);

}

Console.WriteLine(" Enter your best friends name. ");
string bestFriendo = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(bestFriendo, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter your best friends name. ");
    bestFriendo = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(bestFriendo, out noNum);

}

Console.WriteLine(" What is your favorite place to shop? ");
string myShop = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(myShop, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter a store you like to shop at. ");
    myShop = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(myShop, out noNum);

}

Console.WriteLine(" Who is your favorite musician/musical artist? ");
string myMusic = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(myMusic, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter the name of your favorite musician/musical artist. ");
    myMusic = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(myMusic, out noNum);

}

Console.WriteLine(" Who is your favorite actor or actress? ");
string coolActor = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(coolActor, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter an actor or actresses name. ");
    coolActor = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(coolActor, out noNum);

}

Console.WriteLine(" Choose a large object that is falling from the sky. ");
string skyFall = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(skyFall, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter an object that will fall from the sky. ");
    skyFall = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(skyFall, out noNum);

}

Console.WriteLine(" Choose your favorite color. ");
string favColor = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(favColor, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter your favorite color. ");
    favColor = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(favColor, out noNum);

}

Console.WriteLine(" Choose an adjective. ");
string myAdj = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(myAdj, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter an adjective. ");
    myAdj = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(myAdj, out noNum);

}

Console.WriteLine(" Choose a planet. ");
string myPlanet = Console.ReadLine().ToUpper();
notNum = Int32.TryParse(myPlanet, out noNum);

while(notNum == true)
{
    Console.WriteLine(" Invalid input. Enter the name of a planet. ");
    myPlanet = Console.ReadLine().ToUpper();
    notNum = Int32.TryParse(myPlanet, out noNum);

}

    Console.WriteLine( $" ON A WARM SUMMER NIGHT, {name1} TOOK A NICE RIDE AROUND TOWN IN THEIR {methodOfTrans}. ");
    Console.WriteLine( $" {name1} HAD TO PICK UP THEIR FRIEND, {bestFriendo} FROM {myShop}. ");
    Console.WriteLine( $" AS {bestFriendo} HOPPED IN THE {methodOfTrans}, THEY HANDED {name1} A COPY OF {myMusic}'S NEW ALBUM!");
    Console.WriteLine( $" THE BOTH OF THEM LISTENED TO THE ALBUM ON THE WAY TO {coolActor}'S HOUSE PARTY.");
    Console.WriteLine( $" ON THE WAY THERE, THEY WITNESSED A HUGE {skyFall} FALLING FROM THE SKY! BEING AS CURIOUS AS THEY WERE, THEY HEAD IN THE DIRECTION OF THE FALLING {skyFall}. ");
    Console.WriteLine( $" AS THEY APPROACHED THE CRASH SITE, THE LARGE CRATER MADE BY THE FALLING {skyFall} WAS GLOWING {favColor}. ");
    Console.WriteLine( $" INSIDE THIS GLOWING CRATER WAS THE {skyFall}, BUT SOMETHING SEEMED OFF.. IT HISSES AND POPS OPEN! A {myAdj} ALIEN CLIMBS OUT AND LOOKS AROUND DAZED. THEIR EYES MEET WITH {name1}'S. ");
    Console.WriteLine( $" THE ALIEN HOLDS ITS NECK, AND BEGINS TO SPEAK IN ENGLISH SAYING HOW IT CAME FROM {myPlanet}. IT WAS HERE TO PARTY AS A MATTER OF FACT! ");
    Console.WriteLine( $" THE {myAdj} ALIEN, {bestFriendo} AND {name1} ALL HEAD TO {coolActor}'S HOUSE PARTY TOGETHER! THEY PARTY HARD AND HAD A GREAT TIME! ");
    Console.WriteLine( $" THE ALIEN MOVES IN WITH {name1}, AND GETS A JOB. A NEW FRIENDSHIP FORGED IN PARTYING! THE END. ");

}

Console.WriteLine(" Would you like to try the madlib again? yes or no? ");
endGame = Console.ReadLine().ToUpper();
if(endGame == "YES".ToUpper())
{
    playAgain = true;
}
else
{
    Console.WriteLine(" Thank you for playing! Have a great day! ");
    break;
}
}