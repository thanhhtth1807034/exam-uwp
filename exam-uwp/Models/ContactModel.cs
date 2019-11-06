using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using exam_uwp.Entities;
using exam_uwp.Utils;
using SQLitePCL;

namespace exam_uwp.Models
{
    class ContactModel
    {
        public bool Insert(Contact contact)
        {
            try
            {
                using (var statement = SQLiteHelper.GetInstances().Connection.Prepare("INSERT INTO Contact (Name, PhoneNumber) VALUES (?, ?)"))
                {
                    statement.Bind(1, contact.Name);
                    statement.Bind(2, contact.PhoneNumber);
                    statement.Step();
                    return true;
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            return false;
        }

        public Contact SelectItem(string name)
        {
            var getItem = new Contact();
            using (var stt = SQLiteHelper.GetInstances().Connection.Prepare("SELECT * FROM Note WHERE Name = ?"))
            {
                stt.Bind(1, name);
                if (stt.Step() == SQLiteResult.ROW)
                {
                    getItem.Name = (string)stt[1];
                    getItem.PhoneNumber = (string)stt[2];
                }
                return getItem;
            }
        }
    }
}
