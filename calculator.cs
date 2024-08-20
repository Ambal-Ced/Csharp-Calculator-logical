bool isingui = true;
process(isingui);

void process( bool isingui)
{
		Console.Clear();
		string input = "reset";
		input = null;
		do
		{
				try
				{
						Console.WriteLine("You Are Using Calculator");
						Console.WriteLine("(Type the number to select or type the operation)");
						Console.WriteLine("1. Multiplication");
						Console.WriteLine("2. Division");
						Console.WriteLine("3. Addition");
						Console.WriteLine("4. Subtraction");
						Console.WriteLine("5. Exit");
						Console.Write(">>");
						input = Console.ReadLine();
						try
						{
								if (input != null) {
										verifyInput(input);
										isingui = false;

								}
						}
						catch 
						{
								input = null;
						}


				}
				catch (Exception e) 
				{ 
						Console.WriteLine(" An Error Occured on Process");
				}
		}while (isingui);
}

void verifyInput(string input)
{
		string uinput = input;
		char[] input3letter;
		input3letter = uinput.ToCharArray();
		try
		{


				if (input.Length > 1)
				{
						string newinput;
						newinput = null;
						try
						{

								foreach (char letter in input3letter)
								{
										newinput = newinput + letter;
										if (newinput.Length == 3)
										{
												break;
										}
								}
								newinput = newinput.ToLower();
								if (newinput == "mul")
								{
										multiply();
								}
								else if (newinput == "div")
								{
										division();
								}
								else if (newinput == "add")
								{
										addition();
								}
								else if (newinput == "sub")
								{
										subtraction();
								}
								else if (newinput == "exi")
								{
										exit();
								}
						}
						catch (Exception e)
						{
								Console.WriteLine("An Error or Wrong input");
								Console.Read();
								Console.Clear();
								process(isingui = true);
						}
				}
				else if (input.Length == 1)
				{
						try
						{
								string newinput;
								newinput = null;
								newinput = uinput;
								if (newinput == "1" || newinput == "*")
								{
										multiply();
								}
								else if (newinput == "2" || newinput == "/")
								{
										division();
								}
								else if (newinput == "3" || newinput == "+")
								{
										addition();
								}
								else if (newinput == "4" || newinput == "-")
								{
										subtraction();
								}
								else if (newinput == "5")
								{
										exit();
								}
						}
						catch (Exception e)
						{
								Console.WriteLine("An Error or Wrong input");
								Console.Read();
								Console.Clear();
								process(isingui = true);

						}
				}
		} catch (Exception e) { 
				Console.WriteLine("An Error Occured"); 
				process(isingui = true);
		}
}

void multiply(){}
void division(){}
void addition(){}
void subtraction(){}
void exit(){}
