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
using MailKit.Net.Imap;

namespace EmailPrinter
{
    public partial class Splash : MetroForm
    {
        private static DataSet ds = new DataSet();
        private static DataView dv = new DataView();
        private DataTable dtSettings;

        private string theMessage;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            if (!Library.Global.SoftwareEndOfLife())
            {
                dtSettings = getSettings();

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(this, "Fatal error, please update libraries that we used", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void checkLogin()
        {
            using (var client = new ImapClient())
            {
                try
                {
                    MailKit.Security.SecureSocketOptions secureSocketOptions = new MailKit.Security.SecureSocketOptions();

                    if (dtSettings.Rows[0]["SSL"].ToString() == "1")
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
                }
                catch (Exception ex)
                {
                    Library.Global.WriteLog("Login failed: " + ex.Message);
                    theMessage = ex.Message;
                }
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
                Library.Global.WriteLog("Settings file cannot be read: " + ex.Message);
                //MetroFramework.MetroMessageBox.Show(Splash.ActiveForm,"unable to read settings file ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            theMessage = "";
            checkLogin();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            if (theMessage.Length>0)
            {
                MetroFramework.MetroMessageBox.Show(this, theMessage, "Cannot login to the email server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            Main frmmain = new Main();
            frmmain.Show();
        }
    }
}
