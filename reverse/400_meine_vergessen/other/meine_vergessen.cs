using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Windows.Forms;

public class MyPassword : Form
{
		
	// ----------------------------------------------------------------
	// GUI
	// ----------------------------------------------------------------

	private Label m_labelPassword;
	private TextBox m_textPassword;
	private Button m_buttonOK;
	private Label m_labelNewPassword;
	private TextBox m_textNewPassword;

    public MyPassword()
	{
		this.Text = "Meine Vergessen";
		this.Size = new Size(400, 155);
		this.MinimumSize = new Size(400, 155);
		this.MaximumSize = new Size(400, 155);

		// label
		m_labelPassword = new Label();
		m_labelPassword.Parent = this;
		m_labelPassword.Name = "labelPassword";
		m_labelPassword.Text = "Vergessen:";
		m_labelPassword.Location = new Point(10, 12);
		m_labelPassword.Size = new Size (110, 25);

		// password
		m_textPassword = new TextBox();
		m_textPassword.Parent = this;
		m_textPassword.ReadOnly = false;
		m_textPassword.Name = "textBoxKey";
		m_textPassword.Text = "Ihr Passwort";
		m_textPassword.Location = new Point(120, 10);
		m_textPassword.Size = new Size (250, 50);
		m_textPassword.TextChanged += new EventHandler(buttonGenerate_Click);
		this.Controls.Add(m_textPassword);

		// button
		m_buttonOK = new Button();
		m_buttonOK.Parent = this;
		m_buttonOK.Name = "buttonOK";
		m_buttonOK.Text = "OK";
		m_buttonOK.Location = new Point(120, 47);
		m_buttonOK.Size = new Size (150, 27);
 		m_buttonOK.Click += new EventHandler(buttonGenerate_Click);
 		this.Controls.Add(m_buttonOK);

		// label
		m_labelNewPassword = new Label();
		m_labelNewPassword.Parent = this;
		m_labelNewPassword.Name = "labelInstallationCode";
		m_labelNewPassword.Text = "Neue Vergessen:";
		m_labelNewPassword.Location = new Point(10, 92);
		m_labelNewPassword.Size = new Size (110, 25);
		
		// new password
		m_textNewPassword = new TextBox();
		m_textNewPassword.Parent = this;
		m_textNewPassword.ReadOnly = true;
		m_textNewPassword.Name = "textBoxNewPassword";
		m_textNewPassword.Text = generateRandomPassword();
		// m_textNewPassword.Text = getNewPassword();
		m_textNewPassword.Location = new Point(120, 92);
		m_textNewPassword.Size = new Size (250, 25);
		CenterToScreen();
	}

	// ----------------------------------------------------------------

	private void buttonGenerate_Click(object sender, EventArgs e)
	{
		if (m_textPassword.Text == getPassword())
			m_textNewPassword.Text = getNewPassword();
		else
			m_textNewPassword.Text = generateRandomPassword();
	}

	// ----------------------------------------------------------------

	static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

	// ----------------------------------------------------------------

	static public void Main()
	{
		Application.Run(new MyPassword());
	}

	// ----------------------------------------------------------------
	
	private int getChar(string s) {
		for (int i = 0; i < chars.Length; i++) {
			if (chars[i] == s[0])
				return i;
		}
		return 0;
	}

	private string getPassword() {
		var stringChars = new char[10];
		// mY68cRe7P2
		stringChars[0] = chars[38]; // m
		stringChars[1] = chars[24]; // Y
		stringChars[2] = chars[getChar("6")];
		stringChars[3] = chars[getChar("8")];
		stringChars[4] = chars[getChar("c")];
		stringChars[5] = chars[getChar("R")];
		stringChars[6] = chars[getChar("e")];
		stringChars[7] = chars[getChar("7")];
		stringChars[8] = chars[getChar("P")];
		stringChars[9] = chars[getChar("2")];
		return new string(stringChars);
	}

	// ----------------------------------------------------------------

	private void generateCode(string s) {
		Console.WriteLine("\t\tvar s = new char[{0}];", s.Length);
		Random random = new Random((int)DateTime.Now.Ticks);
		int n = random.Next(chars.Length);
		Console.WriteLine("\t\tint n = {0};", n);
		for (int i = 0; i < s.Length; i++) {
			int nChar = getChar(s[i].ToString());
			int nMethod = random.Next(3);
			if (nMethod == 0) {
				if (nChar > n) {
					Console.WriteLine("\t\tn = n + {0};", nChar - n);
				} else if (n > nChar) {
					Console.WriteLine("\t\tn = n - {0};", n - nChar);
				};
			} else {
				int n1 = 1;
				int n2 = 1;
				int n3 = 0;
				int n4 = 0;
				while (n3 < (chars.Length + nChar)) {
					n1 = random.Next(10) + 4;
					n2 = random.Next(10) + 2;
					n3 = n2*(n + n1);
					n4 = 1;
					while ((n3 % n4) != nChar) {
						if (n4 > 1000) {
							break;
						}
						n4++;
					}
					if (n3 % n4 == nChar) {
						break;
					}
					n3 = 1;
				}
				Console.WriteLine("\t\tn = ({0}*(n + {1})) % {2};", n2, n1, n4);
			}
			n = nChar;
			Console.WriteLine("\t\ts[{0}] = chars[n];", i);
			
		}
		Console.WriteLine("\t\treturn \"flagis\" + new string(s);");
	}

	// ----------------------------------------------------------------

	private string getNewPassword() {
		// generateCode("foxes5ayHumansMu5tD1e");
		var s = new char[21];
		int n = 14;
		n = (3*(n + 11)) % 44;
		s[0] = chars[n];
		n = n + 9;
		s[1] = chars[n];
		n = (9*(n + 13)) % 107;
		s[2] = chars[n];
		n = n - 19;
		s[3] = chars[n];
		n = (3*(n + 10)) % 76;
		s[4] = chars[n];
		n = (7*(n + 8)) % 307;
		s[5] = chars[n];
		n = n - 31;
		s[6] = chars[n];
		n = (10*(n + 9)) % 60;
		s[7] = chars[n];
		n = (5*(n + 8)) % 283;
		s[8] = chars[n];
		n = (10*(n + 5)) % 74;
		s[9] = chars[n];
		n = n - 8;
		s[10] = chars[n];
		n = n - 12;
		s[11] = chars[n];
		n = (10*(n + 8)) % 43;
		s[12] = chars[n];
		n = (2*(n + 11)) % 56;
		s[13] = chars[n];
		n = n - 32;
		s[14] = chars[n];
		n = (11*(n + 6)) % 76;
		s[15] = chars[n];
		n = (11*(n + 4)) % 493;
		s[16] = chars[n];
		n = (4*(n + 7)) % 211;
		s[17] = chars[n];
		n = (6*(n + 10)) % 109;
		s[18] = chars[n];
		n = n + 50;
		s[19] = chars[n];
		n = n - 23;
		s[20] = chars[n];
		return "flagis" + new string(s);
	}

	// ----------------------------------------------------------------

	private string generateRandomPassword() {
		var stringChars = new char[27];
		Random random = new Random((int)DateTime.Now.Ticks);
		for (int i = 0; i < stringChars.Length; i++) {
			stringChars[i] = chars[random.Next(chars.Length)];
		}
		return new string(stringChars);
	}
}
