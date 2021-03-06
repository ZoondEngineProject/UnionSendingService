﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UnionSendingService
{
    public partial class Form1 : Form
    {
        private Thread NetworkSendThread = null;
        private Thread NetworkReceiveThread;

        public Form1()
        {
            InitializeComponent();

            //Misc initialized components

            //Preloaders
            ReceivePreloader.Visible = false;
            SendPreloader.Visible = false;

            //TextBoxes
            SendingTextBox.Enabled = false;
            ReceiveTextBox.Enabled = false;

            //Status Infromation
            this.AcceptStatusInformation();

            //Buttons
            SendAcceptBtn.Enabled = false;
            DisableConnBtn.Enabled = false;

            this.JournalingInformation(0, "USS: Приложение инициализировано", 3);
            this.JournalingInformation(1, "USS: Приложение инициализировано", 3);

            //Threads initializing
            this.InitThreads();

        }

        private void AcceptStatusInformation()
        {
            /* !
             * SENDING LABELS INITITALIZED
             * !
             */

            //Connection Status
            ValueConnectionStatusLabel.ForeColor = Color.Red;
            ValueConnectionStatusLabel.Text = "Отсутствует";

            //File Name
            ValueSendFileNameLabel.ForeColor = Color.Red;
            ValueSendFileNameLabel.Text = "Файл не выбран";

            //Sending Result
            ValueSendingResultLabel.ForeColor = Color.Red;
            ValueSendingResultLabel.Text = "Не отправлено";

            //Sending Status
            ValueSendingStatusLabel.ForeColor = Color.Red;
            ValueSendingStatusLabel.Text = "Файл не выбран";

            //File Size
            ValueSizeFileLabel.ForeColor = Color.Red;
            ValueSizeFileLabel.Text = "Файл не выбран";

            /* !
             * STOP SENDING LABELS INITITALIZED
             * !
             */

            /* !
             * RECEIVING LABELS INITITALIZED
             * !
             */
            ValueReceiveConnectionStatusLabel.ForeColor = Color.Red;
            ValueReceiveConnectionStatusLabel.Text = "Не активно";

            ValueReceiveSizeFileLabel.ForeColor = Color.Red;
            ValueReceiveSizeFileLabel.Text = "0 МБ";

            ValueReceiveStatusLabel.ForeColor = Color.Red;
            ValueReceiveStatusLabel.Text = "0 МБ";

            ValueReceiveResultLabel.ForeColor = Color.Red;
            ValueReceiveResultLabel.Text = "Ожидает получения";


            /* !
             * STOP RECEIVING LABELS INITITALIZED
             * !
             */
        }

        private void SendAcceptBtn_Click(object sender, EventArgs e)
        {
            this.BootLoaders(true);
            SendingIPAddrBox.Enabled = false;
            SendAcceptBtn.Enabled = false;
            SendSwitchBtn.Enabled = false;

            if (ApplicationServiceProvider.Antivirus.IsValidIP(SendingIPAddrBox.Text))
            {
                SendingAbortBtn.Visible = true;

                this.InitThreads(SendingIPAddrBox.Text);
                this.NetworkSendThread.Start();
            }
            else
            {
                this.BootLoaders(false);
                SendingIPAddrBox.Enabled = true;

                SendingIPAddrBox.ForeColor = Color.Red;
                SendingIPAddrBox.Text = "Введите корректный IP";

                SendSwitchBtn.Enabled = true;
                SendAcceptBtn.Enabled = true;
            }
        }

        private void BootLoaders(bool on)
        {
            if(on)
            {
                ReceivePreloader.Visible = true;
                SendPreloader.Visible = true;
            }
            else
            {
                ReceivePreloader.Visible = false;
                SendPreloader.Visible = false;
            }
        }

        private void SendSwitchBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog()
            {
                Title = "Выберите файл для отправки",
                Filter = "Файлы типа: (*.txt;*.docx;*.jpg;*.jpeg;*.png;*.mp3;*.avi;*.mkv;*.rar;*.7z;*.iso)|*.txt;*.docx;*.jpg;*.jpeg;*.png;*.mp3;*.avi;*.mkv;*.rar;*.7z;*.iso",
                Multiselect = false,
                RestoreDirectory = true
            };

            
            if (OFD.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    ApplicationServiceProvider.Folders.Boot(0, OFD.SafeFileName, OFD.FileName);

                    //File Name
                    ValueSendFileNameLabel.ForeColor = Color.Green;
                    ValueSendFileNameLabel.Text = ApplicationServiceProvider.Folders.GetFileName();

                    //File Size
                    ValueSizeFileLabel.ForeColor = Color.Green;
                    ValueSizeFileLabel.Text = ApplicationServiceProvider.Folders.GetFileSize();

                    //Sending Status
                    ValueSendingStatusLabel.ForeColor = Color.Red;
                    ValueSendingStatusLabel.Text = "0 МБ";

                    //Enable Accept Button
                    SendAcceptBtn.Enabled = true;

                    //Debug 
                    //MessageBox.Show(ApplicationServiceProvider.Folders.GetFileStream().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + "\n" + ex.Message);
                }
            }
        }

        public void JournalingInformation(int how, string text, int code)
        {
            if(how == 0)
            {
                this.JournalingSendBox(text, code);
            }
            else if(how == 1)
            {
                this.JournalingReceiveBox(text, code);
            }
            else
            {
                MessageBox.Show("Неверный параметр журналирования !", "Внутренняя ошибка");
            }
        }

        private void JournalingSendBox(string text, int code)
        {
            this.AcceptJournalingCode(code);

            SendingTextBox.AppendText(text);
        }

        private void JournalingReceiveBox(string text, int code)
        {
            this.AcceptJournalingCode(code);

            ReceiveTextBox.AppendText(text);
        }

        private void AcceptJournalingCode(int code)
        {
            switch(code)
            {
                //Error
                case 0:
                    {
                        SendingTextBox.ForeColor = Color.Red;
                        ReceiveTextBox.ForeColor = Color.Red;

                        break;
                    }

                //Warning
                case 1:
                    {
                        SendingTextBox.ForeColor = Color.Purple;
                        ReceiveTextBox.ForeColor = Color.Purple;

                        break;
                    }
                
                //Information
                case 2:
                    {
                        SendingTextBox.ForeColor = Color.Gray;
                        ReceiveTextBox.ForeColor = Color.Gray;

                        break;
                    }

                //Success
                case 3:
                    {
                        SendingTextBox.ForeColor = Color.Green;
                        ReceiveTextBox.ForeColor = Color.Green;

                        break;
                    }
            }
        }

        public void AcceptConnectionStatus(bool on, string result = null)
        {
            if(on)
            {
                //Connection Status
                ValueConnectionStatusLabel.ForeColor = Color.Green;
                ValueConnectionStatusLabel.Text = "Активно";

                if (result != null)
                {
                    //Sending Result
                    ValueSendingResultLabel.ForeColor = Color.Green;
                    ValueSendingResultLabel.Text = result;
                }
                else
                {
                    ValueSendingResultLabel.ForeColor = Color.DarkGray;
                    ValueSendingResultLabel.Text = "Отправляется...";
                }
            }
            else
            {
                //Connection Status
                ValueConnectionStatusLabel.ForeColor = Color.Red;
                ValueConnectionStatusLabel.Text = "Отсутствует";

                //Sending Result
                ValueSendingResultLabel.ForeColor = Color.Red;
                ValueSendingResultLabel.Text = "Не отправлено";
            }
        }

        private void EnableConnBtn_Click(object sender, EventArgs e)
        {
            this.BootLoaders(true);

            SendSwitchBtn.Enabled = false;

            EnableConnBtn.Enabled = false;
            DisableConnBtn.Enabled = true;

            if(this.NetworkReceiveThread != null)
            {
                this.InitThreads();
            }

            this.NetworkReceiveThread.Start();
            this.WaitOrConnect(0);
        }

        public void WaitOrConnect(int connected)
        {
            if (connected == 0)
            {
                ValueReceiveConnectionStatusLabel.ForeColor = Color.Purple;
                ValueReceiveConnectionStatusLabel.Text = "Ожидается...";
            }
            else if(connected == 1)
            {
                ValueReceiveConnectionStatusLabel.ForeColor = Color.Green;
                ValueReceiveConnectionStatusLabel.Text = "Подключено";
            }
            else
            {
                ValueReceiveConnectionStatusLabel.ForeColor = Color.Red;
                ValueReceiveConnectionStatusLabel.Text = "Не активно";
            }

        }

        private void InitThreads(string ip = null)
        {
            this.NetworkReceiveThread = new Thread(() =>
            {
                ApplicationServiceProvider.Receive.Receive();
            });

            this.NetworkSendThread = new Thread(() =>
            {
                ApplicationServiceProvider.Sending.Send(ip);
            });
        }

        private void DisableConnBtn_Click(object sender, EventArgs e)
        {
            this.BootLoaders(false);

            SendSwitchBtn.Enabled = true;

            EnableConnBtn.Enabled = true;
            DisableConnBtn.Enabled = false;

            //Abort
            ApplicationServiceProvider.Receive.Abort();
            this.NetworkReceiveThread.Abort();

            this.WaitOrConnect(2);

        }

        private void SendingAbortBtn_Click(object sender, EventArgs e)
        {
            this.AbortSendingConnection();
        }

        private void AbortSendingConnection()
        {
            this.BootLoaders(false);

            SendSwitchBtn.Enabled = true;

            //Abort
            this.NetworkSendThread.Abort();
            SendingAbortBtn.Visible = false;
            SendingIPAddrBox.Enabled = true;
            SendAcceptBtn.Enabled = true;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if(this.NetworkReceiveThread.ThreadState == ThreadState.Running)
            {
                this.BootLoaders(false);

                SendSwitchBtn.Enabled = true;

                EnableConnBtn.Enabled = true;
                DisableConnBtn.Enabled = false;

                //Abort
                ApplicationServiceProvider.Receive.Abort();
                this.NetworkReceiveThread.Abort();

                this.WaitOrConnect(2);
            }

            if(this.NetworkSendThread.ThreadState == ThreadState.Running)
            {
                this.AbortSendingConnection();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about_form = new Form2();
            about_form.Show();
        }
    }
}
