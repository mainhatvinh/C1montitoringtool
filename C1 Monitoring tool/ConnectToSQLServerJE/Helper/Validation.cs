/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 6/11/2013
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Validation.
	/// </summary>
	public class Validation
	{
		public Validation()
		{
		}
		
		public static void txtDouble(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '.')
			{
				if(((TextBox)sender).Text.Contains(".") == true)
					e.Handled = true;
			}
			else if (e.KeyChar == ',')
			{
				e.Handled = false;
			}
			else if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		
		public static void txtIntegerOnly(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ',')
			{
				e.Handled = false;
			}
			else if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
				
		public static void txtNameEY(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
			{
				if (e.KeyChar == '.')
					e.Handled = false;
				else
					e.Handled = true;
			}
		}
		
		public static void txtNoSpace(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ' ')
				e.Handled = true;
			else
				e.Handled = false;
		}
		
		public static bool isInteger(string s)
		{
			s = FormatConverter.skipComma(s);
			
			if (s == "")
				return true;
			else 
			{
				int i = 0;
				return int.TryParse(s,out i);
			}
		}
		
		public static bool IsDouble(string s)
		{
			s = FormatConverter.skipComma(s);
			
			if (s == "")
				return true;
			else 
			{
				double i = 0;
				return double.TryParse(s,out i);
			}
		}
		
		public static bool isNameEY(string s)
		{
			if (s == "")
				return true;
			else 
			{
				for(int i =0;i<s.Length;i++)
				{
					if (char.IsLetter(s[i]) == false && s[i] != '.')
						return false;
				}
				return true;				
			}	
		}
		
		public static bool isNoSpace(string s)
		{
			if (s == "")
				return true;
			else if(s.Contains(" ") == true)
				return false;
			else
				return true;
		}
		
		public static bool isMemberIDFormat(string s)
		{
			if (s == "")
				return true;
			else if(s.Substring(0,2) == "VN" && s.Length == 11)
				return true;
			else 
				return false;
		}
		
		public static bool isClientCodeFormat(string s)
		{
			if (s == "")
				return true;
			else if ((isInteger(s) == true)  &&((s.Length == 8) || (s.Length == 4)))
				return true;
			else 
				return false;
		}
		
		public static bool isYear(string s)
		{
			if (s == "")
				return true;
			else if(isInteger(s) == true && s.Length == 4)
			{
				if (int.Parse(s) > 1990 && int.Parse(s) < 2050)
					return true;
				else
					return false;
			}
			else 
				return false;
		}
		
		public static bool isYear1(string s)
		{
			if (s == "")
				return true;
			else if(isInteger(s) == true && s.Length == 4)
			{
				if (int.Parse(s) >= 2015)
					return true;
				else
					return false;
			}
			else 
				return false;
		}
	}
}
