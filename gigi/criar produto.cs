﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gigi
{
    public partial class criar_produto : Form
    {
        public criar_produto()
        {
            InitializeComponent();
        }
        public string Nome_do_Produto { get { return this.texboxNome.Text; } }
        public string Nome_do_Fabricante { get { return this.texboxFabricante.Text; } }
        public float precoCompra { get { return (float)this.inputPrecoCompra.Value; } }
        public float precoVenda { get { return (float)this.inputPrecoCompra.Value; } }

        private void buttonOk(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
