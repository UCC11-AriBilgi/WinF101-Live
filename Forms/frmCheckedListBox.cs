﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonMesaj_Click(object sender, EventArgs e)
        {
            MesajVer();
        }

        private void MesajVer()
        {
            var secilenDiller= new List<string>(); // string tipinde bir liste yapısı tanımlama.

            foreach(var dil in chlbDiller.CheckedItems) // sadece seçili olanları dikkate alacağım.
            { 
                secilenDiller.Add(dil.ToString()); // add ile listeye eklendi
            }

            lbelMessage.Text = $"Bildiğiniz diller : {string.Join(", ", secilenDiller)}";

            lbelMessage.Visible = true;

        }

        private void CheckAyarla(bool checkState)
        {
            // checkState prm ile true/false
            for (int i = 0; i < chlbDiller.Items.Count; i++)
            {
                chlbDiller.SetItemChecked(i, checkState);
            }
        }

        private void frmCheckedListBox_Load(object sender, EventArgs e)
        {
            lbelMessage.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(false);
        }
    }
}
