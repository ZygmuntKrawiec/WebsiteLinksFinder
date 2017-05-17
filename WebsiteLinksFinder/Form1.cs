using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteLinksFinder
{
    public partial class Form1 : Form
    {
        WebsiteContentReader websiteContentreader;
        WebsiteLinksFinder websiteLinksFinder;
        public Form1()
        {
            InitializeComponent();
            websiteContentreader = new WebsiteContentReader();
            websiteLinksFinder = new WebsiteLinksFinder();
        }

        /// <summary>
        /// Initialise proces of finding web links.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Find_Click(object sender, EventArgs e)
        {
            // Clear all existing list view items;
            lv_Links.Items.Clear();

            // If a content from a given web address from textblock, is read correctly...
            if (websiteContentreader.ReadWebsiteContent(txt_Url.Text))
            {
                // Find all links from read content.
                var webLinks = websiteLinksFinder.FindAllWebsiteLinks(websiteContentreader.WebsiteContent);

                // Order number to display in the list view.
                int i = 0;

                // Display all found links in list view.
                foreach (string link in webLinks)
                {
                    // Create a new list view item and add the order number.
                    ListViewItem lvi = new ListViewItem((++i).ToString());

                    // Add a link to List view item.
                    lvi.SubItems.Add(link);

                    // Add the list view item to list view.
                    lv_Links.Items.Add(lvi);
                }
            }
            // If the conntent was not read correctly and the exception occured...            
            else
            {
                // Create a new list view item 
                var lvi = new ListViewItem("1");

                // Add a message about an exception to the second cell of the list view item.
                lvi.SubItems.Add("An error occured, check your internet connection or correctness of the web address.");

                // Add the list view item to the list view.
                lv_Links.Items.Add(lvi);
            }
        }
    }
}
