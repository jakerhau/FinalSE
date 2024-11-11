using Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Admin
{
    public partial class DetailsForm : Form
    {
        private string idValue;
        public DetailsForm(string id)
        {
            InitializeComponent();
            idValue = id;
        }
        private void DetailsForm_Load(object sender, EventArgs e)
        {
            var userCollection = MongoHelper.GetUserCollection();
            User user = userCollection.Find(x => x.Id == ObjectId.Parse(idValue)).FirstOrDefault();
            if (user != null)
            {
                label9.Text = user.Id.ToString();
                label10.Text = user.Username;
                label11.Text = user.DayOfBirth.ToString("dd/MM/yyyy");
                label12.Text = user.Email;
                if (user.Permit == "ReadOnly")
                {
                    checkBox2.Checked = true;
                }
                else if (user.Permit == "Edit")
                {
                    checkBox1.Checked = true;
                }
                label13.Text = user.Department;
                label14.Text = "Khong co cung cap";
                label15.Text = "Khong co cung cap";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                var userCollection = MongoHelper.GetUserCollection();
                userCollection.UpdateOne(x => x.Id == ObjectId.Parse(idValue), Builders<User>.Update.Set(x => x.Permit, "ReadOnly"));
            } else checkBox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var userCollection = MongoHelper.GetUserCollection();
                userCollection.UpdateOne(x => x.Id == ObjectId.Parse(idValue), Builders<User>.Update.Set(x => x.Permit, "Edit"));
            } else checkBox();
        }
        private void checkBox()
        {
            var userCollection = MongoHelper.GetUserCollection();
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                userCollection.UpdateOne(x => x.Id == ObjectId.Parse(idValue), Builders<User>.Update.Set(x => x.Permit, ""));
            }
        }
    }
}

