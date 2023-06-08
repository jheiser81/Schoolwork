
float x = 1 / 2f; //f is a suffix that tells the program the number is a float, not an integer
Console.WriteLine(x); //if both numbers are integers, the result will always be an integer

double y = 1;
double z = 2;
Console.WriteLine(y / z);

int a = 2 + 3 * 5 + 1; //multiplication has higher precedence than addition
Console.WriteLine(a);

int b = 2 * (1 + ((2 + 2) * (1 + 1))); //parentheses can be used to change the order of operations
//the innermost parentheses are evaluated first, then the next set, and so on
//the result would be 2 + 2 = 4, then 1 + 1 = 2, then 4 * 2 = 8, then 1 + 8 = 9, then 2 * 9 = 18

string pw = "abc123";
bool isPwCorrect = pw == "abc123"; //== is the equality/comparison operator

