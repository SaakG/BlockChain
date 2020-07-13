﻿using Nethereum.Web3;
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

namespace BlockChain_Project
{
    public partial class Decommision : Form
    {
        public Decommision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string combobox = comboBox1.Text;
            string eth_address1 = "0x9Aa8694635b49D405D1E1bf8A9C9a26fDc1a987d";

            var privatekey1 = "87eeb49d97be2d1d338b46f27be26252802cade88ebdba741bde895332766d36";
            var url = "http://127.0.0.1:7545";
            var account = new Nethereum.Web3.Accounts.Account(privatekey1);
            var web31 = new Web3(account, url);
            var iot = new Decommision();
            
            var balanceHandler2 = web31.Eth.GetContractQueryHandler<Decommision>();
            var balance2 = await balanceHandler2.QueryAsync<int>(contractaddress, iot);
            File.AppendAllText(@"C:\Users\C.z\source\repos\BlockChain Project\BlockChain Project\DeployedContract.txt", combobox);
            this.Hide();
            PatientMenu s = new PatientMenu();
            s.Show();
            MessageBox.Show("Device Decommision Successfuly");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
