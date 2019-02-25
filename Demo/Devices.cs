using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace Demo
{
    public partial class Devices : Form
    {
        public Form MainForm;

        public Devices(Form form)
        {
            InitializeComponent();
            MainForm = form;
        }

        BluetoothClient Blueclient = new BluetoothClient();
        Dictionary<string, BluetoothAddress> deviceAddresses = new Dictionary<string, BluetoothAddress>();
        string txtPwd = "0000";

        public Devices()
        {
            InitializeComponent();
        }

        private void Devices_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MainForm != null)
                MainForm.Show();
        }

        private void return_main_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainForm != null)
                MainForm.Show();
        }

        private void discover_device_Click(object sender, EventArgs e)
        {
            this.device_msg.Text = "";
            this.device_msg.Visible = true;
            BluetoothRadio BuleRadio = BluetoothRadio.PrimaryRadio;
            BuleRadio.Mode = RadioMode.Connectable;
            BluetoothDeviceInfo[] Devices = Blueclient.DiscoverDevices();
            device_list.Items.Clear();
            deviceAddresses.Clear();
            foreach (BluetoothDeviceInfo device in Devices)
            {
                device_list.Items.Add(device.DeviceName);
                deviceAddresses[device.DeviceName] = device.DeviceAddress;
            }

            this.device_msg.Text = "搜索设备完成,搜索到" + device_list.Items.Count + "个蓝牙设备。";
        }

        private void pair_device_Click(object sender, EventArgs e)
        {
            try
            {
                BluetoothAddress DeviceAddress = deviceAddresses[device_list.SelectedItem.ToString()];
                Blueclient.SetPin(DeviceAddress, txtPwd.Trim());
                Blueclient.Connect(DeviceAddress, BluetoothService.Handsfree);
                MessageBox.Show("配对成功。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
