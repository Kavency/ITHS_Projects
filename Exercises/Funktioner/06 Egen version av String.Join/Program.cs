
Console.WriteLine(MyJoin("->", "Sverige", "Norge", "Danmark", "Finland", "Island"));

string MyJoin(string separator, params string[] strings)
{
	string newString = string.Empty;
	bool isFirstEntry = true;

	foreach (var item in strings)
	{
		if (isFirstEntry)
		{
			newString += item;
			isFirstEntry = false;
		}
		else
			newString += separator + item;
	}

	return newString;
}