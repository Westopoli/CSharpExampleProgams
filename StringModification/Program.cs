const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// initialize open and close variables 
// find open span and close span
// set quantity to value in between the two
// set output to input without the <div> and </div> 
// replace &trade with &reg

int spanLength = 6;
int openingPosition = input.IndexOf("<span>") + spanLength;
int closingPosition = input.IndexOf("</span>");

int difference = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, difference);

int divLength = 5;
openingPosition = input.IndexOf("<div>") + divLength;
closingPosition = input.IndexOf("</div>");
difference = closingPosition - openingPosition;

output = input.Substring(openingPosition, difference);
output = output.Replace("&trade", "&reg");

Console.WriteLine(quantity);
Console.WriteLine(output);