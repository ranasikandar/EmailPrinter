using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using System.IO;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;

namespace EmailPrinter
{
    public partial class Main : MetroForm
    {
        private static DataSet ds = new DataSet();
        private static DataView dv = new DataView();
        private DataTable dtSettings;

        private DataTable dtEmails;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            metroProgressBar1.Visible = false;

            this.Focus();
            Library.Global.WriteLog("Software Started");
            assignSettingsToCtrls(getSettings());

            setTimer();

            dtEmailsColumnAdd();

            //GetUnreadMails();

            //checkLogin();

            timer1.Enabled = true;
        }

        //private void checkLogin()
        //{
        //    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

        //    using (var client = new ImapClient())
        //    {
        //        try
        //        {
        //            bool _ssl;
        //            if (dtSettings.Rows[0]["SSL"].ToString() == "1")
        //            {
        //                _ssl = true;
        //            }
        //            else
        //            {
        //                _ssl = false;
        //            }

        //            client.Connect(Library.Global.Decrypt(dtSettings.Rows[0]["IMAPServer"].ToString()), Convert.ToInt32(dtSettings.Rows[0]["ServerPort"]), _ssl);

        //            // Note: since we don't have an OAuth2 token, disable
        //            // the XOAUTH2 authentication mechanism.
        //            //client.AuthenticationMechanisms.Remove("XOAUTH2");

        //            client.Authenticate(Library.Global.Decrypt(dtSettings.Rows[0]["UserName"].ToString()), Library.Global.Decrypt(dtSettings.Rows[0]["Password"].ToString()));
        //        }
        //        catch (Exception ex)
        //        {
        //            WriteLog("Login faild "+ex.Message);
        //            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error Login to email server", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        //}
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            GetUnreadMails();
        }
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            this.dgvEmails.DataSource = dtEmails;
            this.dgvEmails.Refresh();
        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressBar1.Visible = false;

            printHtml(dtEmails);

            this.timer1.Enabled = true;

            this.lblLastCheckTime.Text = "Last time E-Mails Retrieve" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        private void setTimer()
        {
            this.timer1.Interval = Convert.ToInt32(dtSettings.Rows[0]["Interval"]); 

            //this.timer1.Interval = (int)TimeSpan.FromMinutes(Convert.ToInt32(dtSettings.Rows[0]["Interval"])).TotalMilliseconds;
            this.timer1.Enabled = true;
        }

        public void GetUnreadMails()
        {
            Int32 countUnreadEmails = 0;
            int progress = 0;

            using (var client = new ImapClient(new ProtocolLogger(Console.OpenStandardOutput())))
            {
                try
                {
                    MailKit.Security.SecureSocketOptions secureSocketOptions = new MailKit.Security.SecureSocketOptions();


                    if (dtSettings.Rows[0]["SSL"].ToString()=="1")
                    {
                        secureSocketOptions = MailKit.Security.SecureSocketOptions.Auto;
                    }
                    else
                    {
                        secureSocketOptions = MailKit.Security.SecureSocketOptions.None;
                    }

                    client.Connect(Library.Global.Decrypt(dtSettings.Rows[0]["IMAPServer"].ToString()), Convert.ToInt32(dtSettings.Rows[0]["ServerPort"]), secureSocketOptions);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                //client.AuthenticationMechanisms.Remove("XOAUTH2");

                    client.Authenticate(Library.Global.Decrypt(dtSettings.Rows[0]["UserName"].ToString()), Library.Global.Decrypt(dtSettings.Rows[0]["Password"].ToString()));

                    backgroundWorker1.ReportProgress(1);

                //////////////////////////////EXAMPLE A
                //// The Inbox folder is always available on all IMAP servers...
                //var inbox = client.Inbox;
                //inbox.Open(FolderAccess.ReadOnly);
                //var results = inbox.Search(SearchOptions.All, SearchQuery.Not(SearchQuery.Seen));//SERVER DOESNT SUPPORT SEARCH
                
                //foreach (var uniqueId in results.UniqueIds)
                //{
                //    var message = inbox.GetMessage(uniqueId);

                //    messages.Add(message.HtmlBody);

                //    // Mark message as read
                //    //inbox.AddFlags(uniqueId, MessageFlags.Seen, true);
                //}
                ////////////////////EXAMPLE B
                    // The Inbox folder is always available on all IMAP servers...
                    //var inbox = client.Inbox;
                    //inbox.Open(FolderAccess.ReadOnly);

                    ////var info = inbox.Fetch(1, 100, MessageSummaryItems.Flags);

                    //Console.WriteLine("Total messages: {0}", inbox.Count);
                    //Console.WriteLine("Recent messages: {0}", inbox.Recent);

                    //int i = inbox.Count;
                    //for (; i <= inbox.Count; i--)
                    //{
                    //    var message = inbox.GetMessage(i-1);
                    //    Console.WriteLine("Subject: {0}", message.Subject);
                    //}
                    ////////////////////EXAMPLE B END
                    
                    ////////////////////EXAMPLE C
                    // The Inbox folder is always available on all IMAP servers...
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);
                    var info = inbox.Fetch(0,-1,MessageSummaryItems.Flags);

                    backgroundWorker1.ReportProgress(2);

                    ////COUNT UNREAD MAILS
                    foreach (var varinfo in info)
                    {
                        //if (varinfo.Flags.ToString()!="Seen")//rana had to 
                        //if (!varinfo.Flags.Value.HasFlag(MessageFlags.Seen))
                        if (varinfo.UserFlags != null)
                        {
                            if (varinfo.UserFlags.FirstOrDefault() != null)
                            {
                                if (!varinfo.UserFlags.FirstOrDefault().ToString().Contains("Seen".ToUpper()))
                                {
                                    countUnreadEmails++;
                                }
                            }
                            else
                            {
                                countUnreadEmails++;
                            }
                        }
                    }
                    ////COUNT UNREAD MAILS

                    //Console.WriteLine("Total messages: {0}", inbox.Count);
                    //Console.WriteLine("Recent messages: {0}", inbox.Recent);

                    int i = inbox.Count-1;

                    for (; i >0; i--)
                    {
                        //if (info[i].Flags!=null && info[i].Flags.ToString() != "Seen")//rana had to
                        //if (!info[i].Flags.Value.HasFlag(MessageFlags.Seen))
                        if (info[i].UserFlags != null)
                        {
                            if (info[i].UserFlags.FirstOrDefault() != null)
                            {
                                if (!info[i].UserFlags.FirstOrDefault().ToString().Contains("Seen".ToUpper()))
                                {
                                    var message = inbox.GetMessage(i);

                                    addRowToDtEmail(message, i);

                                    //PRINT HTML //cant be called win active ctrl from thread
                                    //printHtml(message.HtmlBody);

                                    // Mark message as read
                                    //inbox.AddFlags(i, MessageFlags.Seen, true);//rana had to
                                    //inbox.SetFlags(i, MessageFlags.Seen, true);
                                    info[i].UserFlags.Add("\\SEEN");
                                    inbox.SetFlags(i, MessageFlags.Seen, true);

                                    progress++;
                                }
                            }
                            else
                            {
                                var message = inbox.GetMessage(i);

                                addRowToDtEmail(message, i);

                                //PRINT HTML //cant be called win active ctrl from thread
                                //printHtml(message.HtmlBody);

                                // Mark message as read
                                //inbox.AddFlags(i, MessageFlags.Seen, true);//rana had to
                                //inbox.SetFlags(i, MessageFlags.Seen, true);
                                info[i].UserFlags.Add("\\SEEN");
                                inbox.SetFlags(i, MessageFlags.Seen, true);

                                progress++;
                            }
                        }

                        if (progress * 100 > 0 && countUnreadEmails>0)
                        {
                            backgroundWorker1.ReportProgress((progress * 100) / countUnreadEmails);
                        }
                        else
                        {
                            backgroundWorker1.ReportProgress(25);
                        }
                        
                    }
                    ////////////////////EXAMPLE C END


                client.Disconnect(true);


                }
                catch (Exception ex)
                {
                    Library.Global.WriteLog("Failed to check email " + ex.Message);
                    throw ex;
                }
            }

            //dgvEmails.DataSource = dtEmails;
        }
        private void addRowToDtEmail(MimeKit.MimeMessage message,Int32 msgIndex)
        {
            DataRow row = dtEmails.NewRow();
            row["index"] = msgIndex;
            row["emailId"] = message.MessageId;
            row["Subject"] = message.Subject;
            row["MessageDetails"] = message.TextBody;
            row["htmlBody"] = message.HtmlBody;
            row["From"] = message.From;
            row["EmailDate"] = new Library.Global().UTCtoLocalTime(message.Date.UtcDateTime).ToString("dd.MM.yyyy HH:mm:ss");
            row["Printed"] = 0;

            if (dtEmails==null||dtEmails.Rows.Count<0)
            {
                dtEmails.Rows.InsertAt(row, 0);
            }
            else
            {
                dtEmails.Rows.InsertAt(row, dtEmails.Rows.Count);
            }
        }
        private void dtEmailsColumnAdd()
        {
            dtEmails = new DataTable();

            dtEmails.Columns.Add("index");
            dtEmails.Columns.Add("emailId");
            dtEmails.Columns.Add("Subject");
            dtEmails.Columns.Add("MessageDetails");
            dtEmails.Columns.Add("htmlBody");
            dtEmails.Columns.Add("From");
            dtEmails.Columns.Add("EmailDate");
            dtEmails.Columns.Add("Printed");
            //dtEmails.Columns.Add("TotalHours", typeof(Int32));
            //dtEmails.Columns.Add("TotalPayment", typeof(double));
        }
        private void dtEmailsColumnRemove()
        {
            if (dtEmails != null && dtEmails.Columns.Count > 0)
            {
                dtEmails.Columns.Remove("index");
                dtEmails.Columns.Remove("emailId");
                dtEmails.Columns.Remove("Subject");
                dtEmails.Columns.Remove("MessageDetails");
                dtEmails.Columns.Remove("htmlBody");
                dtEmails.Columns.Remove("From");
                dtEmails.Columns.Remove("EmailDate");
                dtEmails.Columns.Remove("Printed");
            }
            dtEmails = new DataTable();
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;

            this.Focus();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Library.Global.WriteLog("Software Closed");
            Application.Exit();
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool validateSettingsCtrls()
        {
            if (txtImapServer.Text.Length > 3)
            {
                if (txtPort.Text.Length > 0)
                {
                    if (txtUserName.Text.Length > 0)
                    {
                        if (txtPassword.Text.Length > 0)
                        {
                            if (txtTimeOut.Text.Length > 0)
                            {
                                if (txtInterval.Text.Length > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    txtInterval.Focus();
                                    MetroFramework.MetroMessageBox.Show(this, "Enter Email retrieve Interval", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                txtTimeOut.Focus();
                                MetroFramework.MetroMessageBox.Show(this, "Enter the time limit for the email server", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            txtPassword.Focus();
                            MetroFramework.MetroMessageBox.Show(this, "Enter the email server password", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        txtUserName.Focus();
                        MetroFramework.MetroMessageBox.Show(this, "Enter the user name of the email server", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txtPort.Focus();
                    MetroFramework.MetroMessageBox.Show(this, "Enter the email server port", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtImapServer.Focus();
                MetroFramework.MetroMessageBox.Show(this, "Enter the email server", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        private Objects.ServerSettings assignSettingsToObj()
        {
            Objects.ServerSettings obj = new Objects.ServerSettings();

            obj.Server = Library.Global.Encrypt(this.txtImapServer.Text);
            obj.ServerPort = Convert.ToInt32(this.txtPort.Text);
            obj.UserName = Library.Global.Encrypt(this.txtUserName.Text);
            obj.Password = Library.Global.Encrypt(this.txtPassword.Text);
            obj.TimeOut = Convert.ToInt32(this.txtTimeOut.Text);
            obj.Ssl = this.cbxSSL.Checked;
            obj.Interval = (int)TimeSpan.FromMinutes(Convert.ToInt32(this.txtInterval.Text)).TotalMilliseconds;
            obj.key = this.txtLicence.Text;

            return obj;
        }
        private void assignSettingsToCtrls(DataTable dt)
        {
            this.txtImapServer.Text = Library.Global.Decrypt(dt.Rows[0]["IMAPServer"].ToString());
            this.txtPort.Text = dt.Rows[0]["ServerPort"].ToString();
            this.txtUserName.Text = Library.Global.Decrypt(dt.Rows[0]["UserName"].ToString());
            this.txtPassword.Text = Library.Global.Decrypt(dt.Rows[0]["Password"].ToString());
            this.txtTimeOut.Text = dt.Rows[0]["TimeOut"].ToString();

            if (dt.Rows[0]["SSL"].ToString()=="1")
            {
                this.cbxSSL.Checked = true;
            }
            else
            {
                this.cbxSSL.Checked = false;
            }

            this.txtInterval.Text = Convert.ToString((int)TimeSpan.FromMilliseconds(Convert.ToInt32(dt.Rows[0]["Interval"].ToString())).TotalMinutes);
            this.txtLicence.Text = dt.Rows[0]["key"].ToString();

            dtSettings = dt;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateSettingsCtrls())
                {
                    //rana chceck licencce
                    if (!Library.Global.SoftwareEndOfLife())
                    {
                        Update(assignSettingsToObj(), "1");

                        assignSettingsToCtrls(getSettings());

                        MetroFramework.MetroMessageBox.Show(this, "Email server settings were saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Fatal error, please update libraries that we used", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Library.Global.WriteLog("Email settings cannot be saved: " + ex.Message);
                throw ex;
            }
        }
        public static void Update(Objects.ServerSettings obj, string srNo)
        {

            DataRow dr = Select(srNo);

            dr["SrNo"] = srNo;
            dr["IMAPServer"] = obj.Server;
            dr["ServerPort"] = obj.ServerPort;
            dr["UserName"] = obj.UserName;
            dr["Password"] = obj.Password;
            dr["TimeOut"] = obj.TimeOut;

            if (obj.Ssl)
            {
                dr["SSL"] = "1";
            }
            else
            {
                dr["SSL"] = "0";
            }


            dr["Interval"] = obj.Interval;
            dr["key"] = obj.key;

            save();

        }
        public static void save()
        {
            try
            {
                ds.WriteXml(@Application.StartupPath + "\\DATA\\Settings.xml", XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                Library.Global.WriteLog("Settings cannot be saved: " + ex.Message);
                throw ex;
            }
        }
        public static DataTable getSettings()
        {
            try
            {
                ds.Clear();
                ds.ReadXml(Application.StartupPath + "\\DATA\\Settings.xml", XmlReadMode.ReadSchema);
                dv = ds.Tables[0].DefaultView;
                return dv.ToTable();
            }
            catch (Exception ex)
            {
                Library.Global.WriteLog("Settings file cannot be read " + ex.Message);
                throw ex;
            }
        }
        //Search any data in dataview with specific primary key
        public static DataRow Select(string SrNo)
        {

            dv.RowFilter = "SrNo='" + SrNo + "'";

            dv.Sort = "SrNo";

            DataRow dr = null;

            if (dv.Count > 0)
            {
                dr = dv[0].Row;

            }

            dv.RowFilter = "";

            return dr;

        }
        //private static void WriteLog(string str, string filename = "Log.txt")
        //{
        //    File.AppendAllText(filename, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " - " + str + Environment.NewLine);
        //}

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlAbout.SelectedIndex == 0)
            {
                assignSettingsToCtrls(getSettings());
                setTimer();
            } 
            if (tabCtrlAbout.SelectedIndex == 1)
            {
                assignSettingsToCtrls(getSettings());
            }
        }

        private void dgvEmails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmails != null && this.dgvEmails.Rows.Count > 0)
            {
                int selectedColumn = dgvEmails.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = dgvEmails.Columns[selectedColumn];

                if (selectcolumn.HeaderText == "Print")
                {
                    int selectedrow = dgvEmails.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = dgvEmails.Rows[selectedrow];

                    webBrowser = new WebBrowser();
                    webBrowser.DocumentText = selectRow.Cells["htmlBody"].Value.ToString();
                    webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //rana check licence
            if (!Library.Global.SoftwareEndOfLife())
            {
                this.lblLastCheckTime.Text = "Checking for new emails...";
                timer1.Enabled = false;
                this.metroProgressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(this, "Fatal error, please update libraries that we used", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        WebBrowser webBrowser;
        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                webBrowser.Print();
                //webBrowser.DocumentCompleted -= webBrowser_DocumentCompleted;
            }
            catch (Exception ex)
            {
                Library.Global.WriteLog("Last print function failed: " + ex.Message);
            }
        }

        private void printHtml(DataTable dt)
        {
            metroProgressBar1.Visible = true;
            int progress = 0;
            int countUnPrintedEmails = 0;

            foreach (DataRow row1 in dt.Rows)
            {
                if (row1["Printed"].ToString() == "0")
                {
                    countUnPrintedEmails++;
                }   
            }

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    if (row["Printed"].ToString()=="0"&&row["Subject"].ToString().Contains(this.txtLicence.Text))
                    {
                        webBrowser = new WebBrowser();
                        metroProgressBar1.Value = 1;
                        webBrowser.DocumentText = row["htmlBody"].ToString();
                        webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
                        
                        row["Printed"] = 1;
                        progress++;

                        metroProgressBar1.Value = (progress * 100) / countUnPrintedEmails;

                        //while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                        //{
                        //    Task.Delay(100);
                        //}

                        while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                        {
                            Application.DoEvents();
                        }

                    }
                    
                }
                catch (Exception ex)
                {
                    Library.Global.WriteLog("Failed to print email from: '" + row["From"] + "' " + ex.Message);
                    throw ex;
                }
            }
            metroProgressBar1.Visible = false;
        }

        private void btnRunnow_Click(object sender, EventArgs e)
        {
            this.timer1_Tick(sender, e);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, " email printing will be stoped for new emails if it was closed. Do you wish to close this program?", "Exit Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                //Application.Exit();
            }
            else
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }



        //private async Task waitforprint(WebBrowser wb)
        //{
        //    wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
        //}
    }
}
