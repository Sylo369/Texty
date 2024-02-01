StreamWriter writer = new StreamWriter(@"../../../test.txt");
StreamReader reader = new StreamReader(@"../../../read.txt");
writer.Write("If you are reading this message from the text file, this means you have written it through the console succesfully.");
Console.WriteLine(reader.ReadLine()); 



writer.Close();
