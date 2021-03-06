﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace KIP_Monitor
 {
    public partial class F_MainWindow : Form
    {
        public static byte[] BaseArray = new byte[53];

        public F_MainWindow()
        {
            InitializeComponent();
        }

        private void F_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timeForDateTime_Tick(object sender, EventArgs e)
        {      
            SSL_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            SSL_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void F_MainWindow_Load(object sender, EventArgs e)
        {
            SSL_Role.Text = F_Auth.Role;
            SSL_User.Text = F_Auth.CurrentUser;
                        
            for (int i = 0; i<BaseArray.Length; i++)
            {
                BaseArray[i] = 0;
            }

            if (SSL_Role.Text == "Инженер")
            {
                администрированиеToolStripMenuItem.Visible = true;         
            }
        }

        private void Timer_ForConnect_Tick(object sender, EventArgs e)
        {
            SiemensPlc319F3.ConnectTo();
            for (int i = 0; i < SiemensPlc319F3.ThirdLinePb11Errors.Length; i++)//для массива байтов ошибок ПЛК
            {
                if (SiemensPlc319F3.ThirdLinePb11Errors[i] != 0)// если байт не равн нолю (содержит ошибку)
                {
                    if (SiemensPlc319F3.ThirdLinePb11Errors[i] != BaseArray[i])//если байт не равен базовуму массиву (новая ошибка)
                    { 
                        BaseArray[i] = SiemensPlc319F3.ThirdLinePb11Errors[i];//отмечам что ошибка уже зафиксирована системой
                        BitArray Bits = new BitArray(new byte[] { SiemensPlc319F3.ThirdLinePb11Errors[i] });
                        for(int j =0; j<8; j++)
                        {
                           if (Bits[j] == true)
                           {
                                Sql.ConnectDb("SELECT Errors_Meta_Data.Error_Description, Error_Type.Error_Type, Error_Type.Error_Type_Description FROM Errors_Meta_Data, Error_Type WHERE Errors_Meta_Data.Error_Byte like '" + i + "' AND Errors_Meta_Data.Error_Bit like '" + j + "' AND Error_Type.ID_Error_Type = Errors_Meta_Data.ID_Error_Type");
                                for (int k = 0; k < Sql.DataSet.Tables[0].Rows.Count; k++)
                                {
                                    F_Error f = new F_Error();
                                    f.rtb_Incedents_Description.Text = Sql.DataSet.Tables[0].Rows[k]["Error_Description"].ToString()+" ("+ Sql.DataSet.Tables[0].Rows[k]["Error_Type"].ToString()+": "+ Sql.DataSet.Tables[0].Rows[k]["Error_Type_Description"].ToString();
                                    f.ShowDialog();                                                                    
                                }              
                           }
                        }                     
                    }
                }
                else // если байт равн нолю (не содержит ошибку)
                {
                    if (SiemensPlc319F3.ThirdLinePb11Errors[i] != BaseArray[i])//но в опорном массиве осталась ошибка (т.е. теперь она сброшена)
                    {
                        BaseArray[i] = SiemensPlc319F3.ThirdLinePb11Errors[i];  //отмечаем что ошибка отсутствует                     
                    }
                }
            }            
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_User_Managment f = new F_User_Managment();
            f.ShowDialog();
        }
    }
}
