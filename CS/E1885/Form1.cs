using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraGrid.Views.Layout;

namespace E1885 {
    public partial class Form1 : XtraForm {
        private Random rnd = new Random();
        private Dictionary<string, Timer> cache = new Dictionary<string, Timer>();
        private Font regular;
        private Font modified;

        public Form1() {
            InitializeComponent();
            CreateData();
            regular = layoutView1.Appearance.FieldValue.Font;
            modified = new Font(layoutView1.Appearance.FieldValue.Font, FontStyle.Bold);
            timer1.Start();
        }

        private void CreateData() {
            for (int i = 0; i < 10; i++)
                dataTable1.Rows.Add(rnd.Next(100).ToString(), rnd.Next(100).ToString());
        }

        private void OnBindingSourceListChanged(object sender, ListChangedEventArgs e) {
            if (e.ListChangedType == ListChangedType.ItemChanged) {
                string key = string.Format("{0}|{1}", e.NewIndex, e.PropertyDescriptor.Name);
                Timer timer;
                if (cache.ContainsKey(key)) {
                    timer = cache[key];
                    timer.Stop();
                    timer.Start();
                } else {
                    timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tag = key;
                    timer.Tick += new EventHandler(OnCacheExpired);
                    timer.Start();
                    cache.Add(key, timer);
                }
            }
        }

        private void OnTimerClick(object sender, EventArgs e) {
            dataTable1.Rows[rnd.Next(dataTable1.Rows.Count)][rnd.Next(2)] = rnd.Next(100).ToString();
        }

        private void OnCacheExpired(object sender, EventArgs e) {
            Timer timer = (Timer)sender;
            string key = (string)timer.Tag;
            cache.Remove(key);
            timer.Dispose();
            string[] positionData = key.Split('|');
            int rowHandle = layoutView1.GetRowHandle(int.Parse(positionData[0]));
            layoutView1.RefreshRow(rowHandle);
        }

        private void OnLayoutViewCustomFieldValueStyle(object sender, LayoutViewFieldValueStyleEventArgs e) {
            LayoutView view = (LayoutView)sender;
            int sourceIndex = view.GetDataSourceRowIndex(e.RowHandle);
            string key = string.Format("{0}|{1}", sourceIndex, e.Column.FieldName);
            e.Appearance.Font = cache.ContainsKey(key) ? modified : regular;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            modified.Dispose();
            modified = null;
        }
    }
}