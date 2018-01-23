﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Entity;

namespace oprForm
{
	public partial class LookEventsForm : Form
	{
		DBManager db = new DBManager();
		String user = "Vasya";
		private int valueCol = 2;
		private int descCol = 1;

		public LookEventsForm()
		{
			InitializeComponent();
		}

		private void LookEventsForm_Load(object sender, EventArgs e)
		{
			db.Connect();
			var obj = db.GetRows("event", "*", "");
			var events = new List<Event>();
			foreach(var row in obj)
			{
				events.Add(EventMapper.Map(row));
			}
				

			eventsLB.Items.AddRange(events.ToArray());
			db.Disconnect();
		}

		private void eventsLB_SelectedIndexChanged(object sender, EventArgs e)
		{
			db.Connect();
			Event ev = eventsLB.SelectedItem as Event;
			var resourcesForEvent = db.GetRows("event_resource", "event_id, resource_id, description, value",
				"event_id=" + ev.id);
			var resources = new List<Resource>();
			foreach(var resForEvent in resourcesForEvent)
			{
				var res = db.GetRows("resource", "*", "resource_id=" + resForEvent[1]);
				var resource = ResourceMapper.Map(res[0]);
				resource.description = resForEvent[2].ToString();
				resource.value = Int32.Parse(resForEvent[3].ToString());
				resources.Add(resource);
			}

			eventListGrid.Rows.Clear();
			foreach(var r in resources)
			{
				eventListGrid.Rows.Add(r, r.description, r.value);
			}

            eventDescLabel.Text = ev.description;
            dmApprLbl.Text = ukrBool(ev.dmVer);
            lawyerApprLbl.Text = ukrBool(ev.lawyerVer);

			db.Disconnect();
		}

        private string ukrBool(string str)
        {
            return str == "" ? "не переглянуто" : str.Equals("0") ? "нi" : "так";
        }

        private void eventDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eventListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            SetApproved(true);
        }

        private void SetApproved(bool approved)
        {
            db.Connect();
            Event ev = eventsLB.SelectedItem as Event;

            string[] cols = { "event_id", "dm_verification" };
            string[] values = { ev.id.ToString(), approved.ToString()};
            db.UpdateRecord("event", cols, values);
            db.Disconnect();
        }

        private void disaproveBtn_Click(object sender, EventArgs e)
        {
            SetApproved(false);
        }
    }
}
