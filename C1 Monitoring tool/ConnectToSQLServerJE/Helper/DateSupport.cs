/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/20/2013
 * Time: 9:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of DateSupport.
	/// </summary>
	public class DateSupport
	{
		public DateSupport()
		{
		}
		
		public static int GetCurrentFiscalYear()
		{
			if (System.DateTime.Today > new DateTime(System.DateTime.Today.Year, 6, 30))
				return System.DateTime.Today.Year + 1;
			else
				return System.DateTime.Today.Year;
		}
		
		public static DateTime[] GetLastDayinYear(int yearF)
		{
			DateTime[] Months = new DateTime[12];
			int[] M_FY = new int[12]{7,8,9,10,11,12,1,2,3,4,5,6};
			for (int u =1; u<=12; u++)
				{
					int year = (u>=7 ? yearF-1:yearF);
					DateTime lastday = new DateTime(year, u, 15);
					DateTime date = lastday;
					while (GetMonth(lastday) == u)
						lastday = lastday.AddDays(1);
					lastday = lastday.AddDays(-1);
					
					Months[Array.IndexOf(M_FY,u)] = lastday;
					
					
				}
//			for (int u =1; u<=12; u++)
//				MessageBox.Show(Months[u-1].ToShortDateString());
			return Months;	
		}
		
		public static int GetFiscalYear(DateTime date)
		{
			DateTime date1 = date;
			while (date1.DayOfWeek != DayOfWeek.Friday)
				date1 = date1.AddDays(1);
			
			if (date1.Month > 7)
				return (date1.Year+1);
			else if(date1.Month == 7 && date1.Day <=4)
				return (date1.Year);
			else return (date1.Year);
		}
			
	
		
		public static int GetMonth(DateTime date)
		{
			DateTime date1 = date;
			
			while (date1.DayOfWeek != DayOfWeek.Friday)
			{
				
				date1 = date1.AddDays(1);
			}
			
			int month =0;
			if (date1.Day<=4)
			{
				if (date1.Month == 1)
					month = 12;
				else
					month = (date1.Month -1);
			}
			else
				month =  date1.Month;
			
			return month;
		}
		
		public static int DoM(int month, int year)
		{
			DateTime date;
			DateTime date1;
			if (month != 1)
				date = new DateTime(year,month-1,26);
			else
				date = new DateTime(year-1,12,26);
				
			while (month != DateSupport.GetMonth(date))
			{
					date = date.AddDays(1);
			}
			date1 = date;
			int num =0;
			while (month == DateSupport.GetMonth(date1))
			{
				num = num + 7;
				date1 = date1.AddDays(7);
			}
			return num;
		}
		
		public static int Do6M(int month, int year)
		{
			DateTime date;
			DateTime date1;
			DateTime date2;
			if (month != 1)
				date = new DateTime(year,month-1,26);
			else
				date = new DateTime(year-1,12,26);
			int endmonth = (month+6)%12;
			int endyear = ((month+6) > 12 )? year+1:year;
			
			
			if (endmonth != 0)
			{
				date2 = new DateTime(endyear,endmonth+1,05);
			}
			else
			{
				endmonth = 12;
				date2 = new DateTime(endyear+1,1,05);
			}
			
			//MessageBox.Show(date.ToShortDateString() + " - " + date2.ToShortDateString());
			while (month != DateSupport.GetMonth(date))
			{
					date = date.AddDays(1);
			}
			date1 = date;
			
			while (endmonth != DateSupport.GetMonth(date2))
			{
					date2 = date2.AddDays(-1);
			}
			int num =0;
		//	MessageBox.Show(date.ToShortDateString() + " - " + date2.ToShortDateString());
			
			while (date1<date2)
			{
				num = num + 7;
				date1 = date1.AddDays(7);
			}
			//MessageBox.Show(num.ToString());
			return num;
		}
		
		public static DateTime[] ListDoM(int month, int year)
		{
			int days = DoM(month,year);
			DateTime[] arrDate = new DateTime[days];
			DateTime date;
			DateTime date1;
			if (month != 1)
				date = new DateTime(year,month-1,26);
			else
				date = new DateTime(year-1,12,26);
			date1 = date;
			while (month != DateSupport.GetMonth(date))
			{
					date = date.AddDays(1);
			}
			date1 = date;
			int i =0;
			while (month == DateSupport.GetMonth(date1))
			{
				arrDate[i] = date1;
				i = i + 1;
				date1 = date1.AddDays(1);
			}
			
			return arrDate;
		}
		
		public static DateTime[] ListDo6M(int month, int year)
		{
			int days = Do6M(month,year);
			DateTime[] arrDate = new DateTime[days];
			DateTime date;
			DateTime date1;DateTime date2;
			if (month != 1)
				date = new DateTime(year,month-1,26);
			else
				date = new DateTime(year-1,12,26);
			date1 = date;
			
			int endmonth = (month+6)%12;
			int endyear = ((month+6) > 12 )? year+1:year;
			
			if (endmonth != 0)
			{
				date2 = new DateTime(endyear,endmonth+1,05);
			}
			else
			{
				endmonth = 12;
				date2 = new DateTime(endyear+1,1,05);
			}
			
			
			
			while (month != DateSupport.GetMonth(date))
			{
					date = date.AddDays(1);
			}
			date1 = date;
			
			while (endmonth != DateSupport.GetMonth(date2))
			{
					date2 = date2.AddDays(-1);
			}
			//MessageBox.Show(date.ToShortDateString() + " - " + date2.ToShortDateString());
			int i =0;
			while (date1<=date2)
			{
				arrDate[i] = date1;
				i = i + 1;
				date1 = date1.AddDays(1);
			}
		
			return arrDate;
		}
	}
}
