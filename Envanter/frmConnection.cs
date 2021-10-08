using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Envanter
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraForm
    {

        public frmConnection()
        {
            InitializeComponent();
        }

        private void chkYeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            txtDatabase.Enabled = !txtDatabase.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
            cboSunucu.Enabled = !cboSunucu.Enabled;
            txtUserID.Enabled = !txtUserID.Enabled;
            btnKaydet.Enabled = !btnKaydet.Enabled;
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            string[] connection = setting.GetConnectionString("cn").Split(';');
            lblConString.Text = connection[0] + ";" + connection[1] + ";" + connection[2];
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboSunucu.Text, txtDatabase.Text, txtUserID.Text, txtPassword.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    XtraMessageBox.Show("Veritabanı bağlantısı başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboSunucu.Text, txtDatabase.Text, txtUserID.Text, txtPassword.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                    XtraMessageBox.Show("Bağlantı bilgileriniz başarılı bir şekilde kaydedildi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string[] connection = setting.GetConnectionString("cn").Split(';');
                    lblConString.Text = connection[0] + ";" + connection[1] + ";" + connection[2];
                }
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}