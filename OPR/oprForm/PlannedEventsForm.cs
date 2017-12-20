using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.Sql;
using Data;

namespace oprForm
{
	public partial class PlannedEventsForm : Form
	{
		DBManager db = new DBManager();
		String user = "Vasya";
		private int valueCol = 2;
		private int descCol = 1;

		public PlannedEventsForm()
		{
			InitializeComponent();
		}

		private void PlannedEventsForm_Load(object sender, EventArgs e)
		{
			db.Connect();
			var obj = db.GetRows("event_template", "*", "");
			var events = new List<Event>();
			foreach(var row in obj)
			{
				events.Add(EventMapper.Map(row));
			}
				

			eventsLB.Items.AddRange(events.ToArray());
			db.Disconnect();
		}

		private void LoadDataGrid()
		{
			//eventListGrid.Columns.
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Event ev = eventsLB.SelectedItem as Event;

			db.Connect();
			int templateId = ev.id;
			string evName = DBUtil.AddQuotes(evNameTB.Text);
			string evDesc = DBUtil.AddQuotes(descTB.Text);

			string[] evFields = new string[] { "name", "description", "template_id" };
			string[] evValues = new string[] {  evName, evDesc, templateId.ToString()};

			int evId = db.InsertToBD("event", evFields, evValues);

			foreach (DataGridViewRow row in eventListGrid.Rows)
			{
				Resource res = row.Cells[0].Value as Resource;
				if (res != null)
				{
					string desc = "";
					string value = "";
					if (row.Cells[descCol].Value != null)
						desc = DBUtil.AddQuotes(row.Cells[descCol].Value.ToString());
					if (row.Cells[valueCol].Value != null)
						value = row.Cells[valueCol].Value.ToString();

					string[] fields = { "event_id", "resource_id", "value", "description" };
					string[] values = { evId.ToString(), res.id.ToString(), value, desc };

					db.InsertToBD("event_resource", fields, values);
				}
			}
			db.Disconnect();
		}

		private void eventsLB_SelectedIndexChanged(object sender, EventArgs e)
		{
			// TODO Confirmation if data entered
			db.Connect();
			Event ev = eventsLB.SelectedItem as Event;
			var resourcesForEvent = db.GetRows("template_resource", "template_id, resource_id",
				"template_id=" + ev.id);
			var resources = new List<Resource>();
			foreach(var resForEvent in resourcesForEvent)
			{
				var res = db.GetRows("resource", "*", "resource_id=" + resForEvent[1]);
				resources.Add(ResourceMapper.Map(res[0]));
			}

			eventListGrid.Rows.Clear();
			foreach(var r in resources)
			{
				eventListGrid.Rows.Add(r, r.description);
			}

			db.Disconnect();
		}

		private void commitValue(object sender, DataGridViewCellEventArgs e)
		{
			// TODO add on button
			// Add new resources
			Resource res = eventListGrid.Rows[e.RowIndex].Cells[0].Value as Resource;
			if(e.RowIndex == valueCol)
				res.value = Int32.Parse(eventListGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			if(e.RowIndex == descCol)
				res.description = eventListGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
		}

	}

	//class EventMapper : Mapper<Event>
	//{
	//	public Event Map(IDataReader reader)
	//	{
	//		var e = new Event();
	//		e.id = reader.GetInt32(0);
	//		e.name = reader.GetString(1);
	//		e.description = reader.GetString(2);
	//		e.actionCol = reader.GetString(3);

	//		return e;
	//	}
	//}
	class EventMapper 
	{
		public static Event Map(List<Object> row)
		{
			var e = new Event();
			e.id = Int32.Parse(row[0].ToString());
			e.name = row[1].ToString();
			e.description = row[2].ToString();

			return e;
		}
	}

	class ResourceMapper 
	{
		public static Resource Map(List<Object> row)
		{
			var r = new Resource();
			r.id = Int32.Parse(row[0].ToString());
			r.name = row[1].ToString();
			r.description = row[2].ToString();

			return r;
		}
	}

	class Event
	{
		public int id;
		public string name;
		public string description;

		public override string ToString()
		{
			return id + " " + name + " " + description;
		}
	}
	class Resource
	{
		public int id;
		public string name;
		public string description;
		public int value;

		public override string ToString()
		{
			return name;
		}
	}
}						  
