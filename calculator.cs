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

void verifyInput(){}
void multiply(){}
void division(){}
void addition(){}
void subtraction(){}
void exit(){}
