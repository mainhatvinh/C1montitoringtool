/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 5/23/2013
 * Time: 3:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace C1Monitoring
{
	/// <summary>
	/// Description of DateTimeConvertor.
	/// </summary>
	public class FormatConverter
	{
		public FormatConverter()
		{
			
		}
		
		public static DateTime convertDateFromDBToCode(string date)
		{
			int month = int.Parse(date.Split('/')[0]);
			int day = int.Parse(date.Split('/')[1]);
			int year = int.Parse(date.Split('/')[2].Substring(0,4));
			
			DateTime _date = new DateTime(year,month,day);
			
			return _date;
		}
		
		public static int DMY(string choice, string date)
		{
			int day = int.Parse(date.Split(' ')[0]);
			int month = int.Parse(date.Split(' ')[1]);
			int year = int.Parse(date.Split(' ')[2]);
			if (choice == "D")
				return day;
			if (choice == "M")
				return month;
			if (choice == "Y")
				return year;			
			return 0;
		}
		
		public static DateTime convertStrToDate(string date)
		{
			string[] months = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
			
			int day = int.Parse(date.Split(' ')[0]);
			string month = date.Split(' ')[1];
			int year = int.Parse(date.Split(' ')[2]);
			int index =1;                    		                     
			                  
            for (int i =0; i<=11; i++)
            	if (month == months[i])
            	    index = i +1;
			DateTime temp =new DateTime(year,index,day);
            	    return temp;
		}
		
		public static string standardizeDate(string date)
		{
			if (date == "")
				return null;
			else
				return date;
		}
		
		public static double standardizeDouble(string num)
		{
			try
			{
				return double.Parse(num);
			}
			catch(Exception e)
			{
				return 0;
			}
		}
		
		public static int standardizeInt(string num)
		{
			try
			{
				return int.Parse(num);
			}
			catch(Exception e)
			{
				return 0;
			}
		}
		
		public static string addComma(bool IsDecima, string str)
		{
			double temp = standardizeDouble(str);
			if (IsDecima)
				return temp.ToString("#,##0.00");
			else
				return temp.ToString("#,##0");

		}

		public static string skipComma(string str)
		{
		    string[] ss = null;
		    string strnew = "";
		    if (str == "")
		    {
		        strnew = "0";
		    }
		    else
		    {
		        ss = str.Split(',');
		        for (int i = 0; i < ss.Length; i++)
		        {
		            strnew += ss[i];
		        }
		    }
		    return strnew;
		}
		
		public static string addPercent( string str)
		{
			double temp = standardizeDouble(str)*100;
			
			return temp.ToString()+"%";
			

		}

		public static string skipPercent(string str)
		{
		    string[] ss = null;
		    string strnew = "";
		    if (str == "")
		    {
		        strnew = "0";
		    }
		    else
		    {
		        ss = str.Split('%');
		        for (int i = 0; i < ss.Length; i++)
		        {
		            strnew += ss[i];
		        }
		    }
		    return strnew;
		}
	}
}
