using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    internal class Paging
    {
        private static int maxItem = 6;
        private static int page = 1; // 处于第一页
        private static int total = 0;
        private static List<List<string>> data = new List<List<string>>();
  

        static public ListView ToOrganization(ListView listView, Button PageUp, Button PageDown, Form form)
        {
            // 初始化
            page = 1;
            total = 0;
            data.Clear();
            RemoveClickEvent(PageUp);
            RemoveClickEvent(PageDown);

/*            Console.WriteLine("page " + page);
            Console.WriteLine("total " + total);
            Console.WriteLine("listview count" + listView.Items.Count);
            Console.WriteLine("data count " + data.Count);*/

            if (listView.Items.Count <= maxItem)
            {
                PageUp.Enabled = false;
                PageDown.Enabled = false;
                AddLabel.ToOrganization(listView, (Org)form);
                return listView;
            }

            SetData(listView, "Organization", form);

/*            Console.WriteLine("data count after" + data.Count);*/

            PageUp.Enabled = false;
            PageDown.Enabled = true;
            PageUp.Click += (e, a) => Up(listView, PageUp, PageDown, "Organization", form);
            PageDown.Click += (e, a) => Down(listView, PageUp, PageDown, "Organization", form);

            PageDown.Focus();
            return listView;
        }

        static public ListView ToStudent(ListView listView, Button PageUp, Button PageDown, Form form)
        {
            // 初始化
            page = 1;
            total = 0;
            data.Clear();
            RemoveClickEvent(PageUp);
            RemoveClickEvent(PageDown);

            if (listView.Items.Count <= maxItem)
            {
                PageUp.Enabled = false;
                PageDown.Enabled = false;
                AddLabel.ToStudent(listView, (Student)form);
                return listView;
            }

            SetData(listView, "Student", form);

            PageUp.Enabled = false;
            PageDown.Enabled = true;
            PageUp.Click += (e, a) => Up(listView, PageUp, PageDown, "Student", form);
            PageDown.Click += (e, a) => Down(listView, PageUp, PageDown, "Student", form);

            PageDown.Focus();
            return listView;
        }

        static public ListView ToSchool(ListView listView, Button PageUp, Button PageDown, Form form)
        {
            // 初始化
            page = 1;
            total = 0;
            data.Clear();
            RemoveClickEvent(PageUp);
            RemoveClickEvent(PageDown);

            if (listView.Items.Count <= maxItem)
            {
                PageUp.Enabled = false;
                PageDown.Enabled = false;
                AddLabel.ToSchool(listView, (Admin)form);
                return listView;
            }

            SetData(listView, "School", form);

            PageUp.Enabled = false;
            PageDown.Enabled = true;
            PageUp.Click += (e, a) => Up(listView, PageUp, PageDown, "School", form);
            PageDown.Click += (e, a) => Down(listView, PageUp, PageDown, "School", form);

            PageDown.Focus();
            return listView;
        }

        static public ListView ToPlace(ListView listView, Button PageUp, Button PageDown, Form form)
        {
            // 初始化
            page = 1;
            total = 0;
            data.Clear();
            RemoveClickEvent(PageUp);
            RemoveClickEvent(PageDown);

            if (listView.Items.Count <= maxItem)
            {
                PageUp.Enabled = false;
                PageDown.Enabled = false;
                AddLabel.ToPlace(listView, (Admin)form);
                return listView;
            }

            SetData(listView, "Place", form);

            PageUp.Enabled = false;
            PageDown.Enabled = true;
            PageUp.Click += (e, a) => Up(listView, PageUp, PageDown, "Place", form);
            PageDown.Click += (e, a) => Down(listView, PageUp, PageDown, "Place", form);

            PageDown.Focus();
            return listView;
        }

        public static void SetData(ListView listView, string ob, Form form)
        {
            // 转存数据
            foreach (ListViewItem listViewItem in listView.Items)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < listView.Columns.Count - 1; i++)
                {
                    list.Add(listViewItem.SubItems[i].Text);
                }
                data.Add(list);
            }

            listView.Items.Clear();
            AddLabel.RemoveLabel(listView);

            for (; total < maxItem; total++)
            {
                ListViewItem viewItem = new ListViewItem(data[total][0]);
                for (int i = 1; i < listView.Columns.Count - 1; i++)
                    viewItem.SubItems.Add(data[total][i]);
                listView.Items.Add(viewItem);
            }

            if (ob.Equals("Organization")) AddLabel.ToOrganization(listView, (Org)form);
            else if (ob.Equals("Student")) AddLabel.ToStudent(listView, (Student)form);
            else if (ob.Equals("Place")) AddLabel.ToPlace(listView, (Admin)form);
            else if (ob.Equals("School")) AddLabel.ToSchool(listView, (Admin)form);
        }

        public static void Up(ListView listView, Button PageUp, Button PageDown, string ob, Form form) 
        {
            page--;
            total = (page - 1) * maxItem;
            if (page <= 1) PageUp.Enabled = false;
            if (page >= 1) PageDown.Enabled = true;

            listView.Items.Clear();
            AddLabel.RemoveLabel(listView);

            for (; total < page*maxItem && total < data.Count; total++)
            {
                ListViewItem viewItem = new ListViewItem(data[total][0]);
                for (int i = 1; i < listView.Columns.Count - 1; i++)
                    viewItem.SubItems.Add(data[total][i]);
                listView.Items.Add(viewItem);
            }

            if (ob.Equals("Organization")) AddLabel.ToOrganization(listView, (Org)form);
            else if (ob.Equals("Student")) AddLabel.ToStudent(listView, (Student)form);
            else if (ob.Equals("Place")) AddLabel.ToPlace(listView, (Admin)form);
            else if (ob.Equals("School")) AddLabel.ToSchool(listView, (Admin)form);

            if (PageUp.Enabled == true) PageUp.Focus();
            else PageDown.Focus();

/*            Console.WriteLine("page " + page);
            Console.WriteLine("total" + total);*/
        }

        public static void Down(ListView listView, Button PageUp, Button PageDown, string ob, Form form)
        {
            page++;
            total = (page - 1) * maxItem;
            if (page > 1) PageUp.Enabled = true;
            if (page * maxItem >= data.Count) PageDown.Enabled = false;

            listView.Items.Clear();
            AddLabel.RemoveLabel(listView);
            for (; total < page*maxItem && total < data.Count; total++)
            {
                ListViewItem viewItem = new ListViewItem(data[total][0]);
                for (int i = 1; i < listView.Columns.Count - 1; i++)
                    viewItem.SubItems.Add(data[total][i]);
                listView.Items.Add(viewItem);
            }

            if (ob.Equals("Organization")) AddLabel.ToOrganization(listView, (Org)form);
            else if (ob.Equals("Student")) AddLabel.ToStudent(listView, (Student)form);
            else if (ob.Equals("Place")) AddLabel.ToPlace(listView, (Admin)form);
            else if (ob.Equals("School")) AddLabel.ToSchool(listView, (Admin)form);

            if (PageDown.Enabled == true) PageDown.Focus();
            else PageUp.Focus();

/*            Console.WriteLine("page " + page);
            Console.WriteLine("total " + total);*/
        }

        // 去除事件
        public static void RemoveClickEvent(Button button)
        {
            FieldInfo fieldInfo = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);

            object obj = fieldInfo.GetValue(button);

            PropertyInfo propertyInfo = button.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)propertyInfo.GetValue(button, null);
            list.RemoveHandler(obj, list[obj]);
        }
    }
}
