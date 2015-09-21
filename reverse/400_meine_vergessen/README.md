Name:
	
	meine_vergessen

Score:

	400

Subject:

	Reverse

Description:
	
	EN: What say foxes?
	RU: Что говорят лисы?
	https://drive.google.com/folderview?id=0BzfPP2u0U3CsfkJPLTZyN2dGYkkzVlFsMzZmSUV1Uy00Nk52dE9PR0w4ZHhWbEhLNzdiM00&usp=sharing

	Hint 1. Strings could not help you.

Answer:

	foxes5ayHumansMu5tD1e

Author:

	[keva] sea-kg
	
Solve by author:

* look `strings meine_vergessen.exe | more` "System.Runtime.CompilerServices" - csharp
* or `file meine_vergessen.exe` 

	meine_vergessen.exe: PE32 executable (console) Intel 80386 Mono/.Net assembly, for MS Windows`
* Mono/.Net Decompile sources (for example use: http://www.telerik.com/products/decompiler.aspx)
* Code:

	static MyPassword()
	{
		MyPassword.chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
	}
	private int getChar(string s)
	{
		for (int i = 0; i < MyPassword.chars.Length; i++)
		{
			if (MyPassword.chars[i] == s[0])
			{
				return i;
			}
		}
		return 0;
	}
	private string getPassword()
	{
		char[] chrArray = new char[] {
			MyPassword.chars[38], // m
			MyPassword.chars[24], // Y
			MyPassword.chars[this.getChar("6")],
			MyPassword.chars[this.getChar("8")],
			MyPassword.chars[this.getChar("c")],
			MyPassword.chars[this.getChar("R")],
			MyPassword.chars[this.getChar("e")],
			MyPassword.chars[this.getChar("7")],
			MyPassword.chars[this.getChar("P")],
			MyPassword.chars[this.getChar("2")]
		};
		return new string(chrArray);
	}

* Got password: mY68cRe7P2
* Set password and get flag: flagisfoxes5ayHumansMu5tD1e
* Answer: foxes5ayHumansMu5tD1e
