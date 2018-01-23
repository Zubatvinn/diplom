using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
	public class Event
	{
		public int id;
		public string name;
		public string description;
        public string lawyerVer;
        public string dmVer;

		public override string ToString()
		{
			return name;
		}
	}
	public class EventMapper 
	{
		public static Event Map(List<Object> row)
		{
			var e = new Event();
			e.id = Int32.Parse(row[0].ToString());
			e.name = row[1].ToString();
			e.description = row[2].ToString();
            e.lawyerVer = row[3] != null? row[4].ToString(): null;
            e.dmVer = row[4] != null? row[5].ToString(): null;

			return e;
		}
	}

	public class EventTemplateMapper 
	{
		public static Event Map(List<Object> row)
		{
			var e = new Event();
			e.id = Int32.Parse(row[0].ToString());
			e.name = row[1].ToString();
			e.description = row[2].ToString();

			return e;
		}
	}}
