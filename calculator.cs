bool isingui = true;
process(isingui);
void process( bool isingui)
{
		bool running = isingui;
		Console.Clear();
		string input = "reset";
		input = null;
		do
		{
				try
				{
						Console.Clear();
						Console.WriteLine("You Are Using Calculator");
						Console.WriteLine("(Type the number to select or type the operation)");
						Console.WriteLine("1. Multiplication");
						Console.WriteLine("2. Division");
						Console.WriteLine("3. Addition");
						Console.WriteLine("4. Subtraction");
						Console.WriteLine("5. Exit");
						Console.Write(">> ");
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
		}while (running);
}
void verifyInput(string input)
{
		bool muinput = true;
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
void multiply()
{
		string userInput;
		decimal start = 1m;
		Console.Clear();
		Console.WriteLine("You chose multiplication");
		Console.WriteLine("Enter how many numbers to multiply");
		Console.WriteLine("(Example: 3, the program will ask for 3 numbers) ");
		Console.Write(">> ");
		userInput = Console.ReadLine();
		try
		{
				if (userInput != null || userInput == "1")
				{
						try
						{
								int verifyinputs = Convert.ToInt32(userInput);
								Console.Clear();
								Console.WriteLine("Enter " + userInput + " numbers");
								int j = Convert.ToInt32(userInput);
								decimal[] storeinput = new decimal[j];
								for (int i = 0; i < j; i++)
								{
										Console.Write(">> ");
										storeinput[i] = Convert.ToDecimal(Console.ReadLine());
								}
								Console.Clear();
								foreach (decimal newnum in storeinput)
								{
										start *= newnum;
								}
								Console.WriteLine("\aThe Results are: " + start);
								userInput = null;
								start = 0 ;
								storeinput = null;
								Console.Read();
						}
						catch
						{
								Console.Clear();
								Console.WriteLine("User Input might be Incorrect");
								Console.Read();
								userInput = null;
						}
				}
		}catch (Exception e)
		{
				Console.WriteLine("An Error Occurred!!");
				Console.WriteLine("A Wrong Input May Have Caused This!   :(");
				Console.WriteLine("Details: " + e.Message);
				Console.Read();
		}
}
void division()
{
		string userInput;
		decimal start = 1m;
		Console.Clear();
		Console.WriteLine("You chose Division");
		Console.WriteLine("Enter how many numbers to be divided");
		Console.WriteLine("(Example: 3, the program will ask for 3 numbers) ");
		Console.Write(">> ");
		userInput = Console.ReadLine();
		try
		{
				if (userInput != null || userInput == "1")
				{
						try
						{
								int verifyinputs = Convert.ToInt32(userInput);
								Console.Clear();
								Console.WriteLine("Enter " + userInput + " numbers");
								int j = Convert.ToInt32(userInput);
								decimal[] storeinput = new decimal[j];
								for (int i = 0; i < j; i++)
								{
										Console.Write(">> ");
										storeinput[i] = Convert.ToDecimal(Console.ReadLine());
								}
								Console.Clear();
								start = storeinput[0] *storeinput[0];
										foreach (decimal newnum in storeinput)
								{
										start /= newnum;
								}
								Console.WriteLine("\aThe Results are: " + start);
								userInput = null;
								start = 0;
								storeinput = null;
								Console.Read();
						}
						catch
						{
								Console.Clear();
								Console.WriteLine("User Input might be Incorrect");
								Console.Read();
								userInput = null;
						}
				}
		}
		catch (Exception e)
		{
				Console.WriteLine("An Error Occurred!!");
				Console.WriteLine("A Wrong Input May Have Caused This!   :(");
				Console.WriteLine("Details: " + e.Message);
				Console.Read();
		}

}
void addition()
{
		string userInput;
		decimal start = 0m;
		Console.Clear();
		Console.WriteLine("You chose Addition");
		Console.WriteLine("Enter how many numbers to be added");
		Console.WriteLine("(Example: 3, the program will ask for 3 numbers) ");
		Console.Write(">> ");
		userInput = Console.ReadLine();
		try
		{
				if (userInput != null || userInput == "1")
				{
						try
						{
								int verifyinputs = Convert.ToInt32(userInput);
								Console.Clear();
								Console.WriteLine("Enter " + userInput + " numbers");
								int j = Convert.ToInt32(userInput);
								decimal[] storeinput = new decimal[j];
								for (int i = 0; i < j; i++)
								{
										Console.Write(">> ");
										storeinput[i] = Convert.ToDecimal(Console.ReadLine());
								}
								Console.Clear();
								foreach (decimal newnum in storeinput)
								{
										start += newnum;
								}
								Console.WriteLine("\aThe Results are: " + start);
								userInput = null;
								start = 0;
								storeinput = null;
								Console.Read();
						}
						catch
						{
								Console.Clear();
								Console.WriteLine("User Input might be Incorrect");
								Console.Read();
								userInput = null;
						}
				}
		}
		catch (Exception e)
		{
				Console.WriteLine("An Error Occurred!!");
				Console.WriteLine("A Wrong Input May Have Caused This!   :(");
				Console.WriteLine("Details: " + e.Message);
				Console.Read();
		}
}
void subtraction()
{
		string userInput;
		decimal start = 0m;
		Console.Clear();
		Console.WriteLine("You chose subtraction");
		Console.WriteLine("Enter how many numbers to be subtracted");
		Console.WriteLine("(Example: 3, the program will ask for 3 numbers) ");
		Console.Write(">> ");
		userInput = Console.ReadLine();
		try
		{
				if (userInput != null || userInput == "1")
				{
						try
						{
								int verifyinputs = Convert.ToInt32(userInput);
								Console.Clear();
								Console.WriteLine("Enter " + userInput + " numbers");
								int j = Convert.ToInt32(userInput);
								decimal[] storeinput = new decimal[j];
								for (int i = 0; i < j; i++)
								{
										Console.Write(">> ");
										storeinput[i] = Convert.ToDecimal(Console.ReadLine());
								}
								Console.Clear();
								if (storeinput[0] > 0)
								{
										start = storeinput[0] * 2;
										foreach (decimal newnum in storeinput)
										{
												start -= newnum;
										}
										Console.WriteLine("\aThe Results are: " + start);
										Console.Read();
										userInput = null;
										start = 0;
										storeinput = null;
								}
								else if (storeinput[0] < 0) {
										start = storeinput[0]*2;
										foreach (decimal newnum in storeinput)
										{
												start = start - newnum;
										}
										Console.WriteLine("The Results are: " + start);
										Console.Read();
										userInput = null;
										start = 0;
										storeinput = null;
								}
						}
						catch
						{
								Console.Clear();
								Console.WriteLine("User Input might be Incorrect");
								Console.Read();
								userInput = null;
						}
				}
		}
		catch (Exception e)
		{
				Console.WriteLine("An Error Occurred!!");
				Console.WriteLine("A Wrong Input May Have Caused This!   :(");
				Console.WriteLine("Details: " + e.Message);
				Console.Read();
		}
}
void exit()
{
		bool exits = false;
		Console.Clear();
		Console.WriteLine("\aYou chose exit \n Thank You For Using The Program!");
		Console.Read();
		Environment.Exit(0);
}
