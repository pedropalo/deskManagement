using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using deskManagement.models;

namespace deskManagement
{
    public partial class formInitial : Form
    {
        //Global
        private string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        public formInitial()
        {
            InitializeComponent();
        }

        //Metodos compartilhados
        public void filePath()
        {
            _filePath = Directory.GetParent(_filePath).FullName;
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
        }

        public void abrirMenu(Form menu)
        {
            panelContent.Controls.Clear();

            if (menu != null)
            {
                menu.TopLevel = false;
                menu.TopLevel = false;
                panelContent.Controls.Add(menu);
                menu.Show();
            }
        }

        public void alteraCor(Label sender, bool reset)
        {
            if (sender != null)
            {
                if (reset)
                {
                    sender.ForeColor = Color.Black;
                }
                else
                {
                    sender.ForeColor = Color.Red;
                }
            }
        }

        //Demais metodos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formInitial_Load(object sender, EventArgs e)
        {
            panelLateral.Height = this.Height;
        }

        private void lblTeste_Click(object sender, EventArgs e)
        {
            abrirMenu(new contents.formConfig());
        }

        private void lblTeste_MouseEnter(object sender, EventArgs e)
        {
            alteraCor(lblTeste, false);
        }

        private void lblTeste_MouseLeave(object sender, EventArgs e)
        {
            alteraCor(lblTeste, true);
        }

        public void teste()
        {
            filePath();
            _filePath += @"\deskManagement\jsonTasks\sample.json";

            string json = System.IO.File.ReadAllText(_filePath);

            var newJson = JsonConvert.DeserializeObject<Account>(json);
        }

        private void lblJson_Click(object sender, EventArgs e)
        {
            teste();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            abrirMenu(new contents.formUser());
        }

        private void lblUsuario_MouseEnter(object sender, EventArgs e)
        {
            alteraCor(lblUsuario, false);
        }

        private void lblUsuario_MouseLeave(object sender, EventArgs e)
        {
            alteraCor(lblUsuario, true);
        }
    }
}
