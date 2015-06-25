﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;
using Unilever.DTO.Entity;
using Unilever.DAO;

namespace Unilever
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : DXRibbonWindow
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StaffDAO sd = new StaffDAO();

            if(sd.Login(txtUsername.Text, txtPassword.Password) == true)
            {
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
    }
}