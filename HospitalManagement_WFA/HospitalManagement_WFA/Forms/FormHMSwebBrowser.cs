using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement_WFA
{
    public partial class FormHMSwebBrowser : Form
    {
        WebBrowser web = new WebBrowser();
        public FormHMSwebBrowser()
        {
            InitializeComponent();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
                
            }
            else if (web.CanGoForward)
            {
                web.GoBack();
            }
            else
            {
                MessageBox.Show("Can't Go");
            }
        }

        private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
                
            }
            else if (web.CanGoForward)
            {
                web.GoForward();
            }
            else
            {
                MessageBox.Show("Can't Go");
            }
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = toolStripTextBox1.Text;
            webBrowser1.Navigate(url);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.bd/");
            tabControl1.SelectTab(tabPage1);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabPage1.Text = webBrowser1.DocumentTitle;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            web.Refresh();
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void apolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string website = "www.apollodhaka.com";
            linktoNewWebSiteInNewTab(website);
        }

        private void linktoNewWebSiteInNewTab(string website)
        {
            TabPage tp = new TabPage();
            tp.Text = website;
            
            web.ScriptErrorsSuppressed = true;

            tabControl1.TabPages.Add(tp);
            tabControl1.SelectTab(tp);
            tabControl1.SelectedTab.Controls.Add(web);
            web.Parent = tp;
            web.Dock = DockStyle.Fill;
            web.Navigate(website);
            
           
        }

        private void enamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string website = "www.emcbd.com";
            linktoNewWebSiteInNewTab(website);
        }

        private void labaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string website = "www.labaidgroup.com";
            linktoNewWebSiteInNewTab(website);
            
        }

        private void ibnSinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string website = "www.ibnsinatrust.com";
            linktoNewWebSiteInNewTab(website);
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string website = "www.imc.ac.bd/web";
            linktoNewWebSiteInNewTab(website);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            web.Stop();
            
        }
        
    }
}
