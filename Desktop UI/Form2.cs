using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace transfer_data
{
    public partial class Form2 : Form
    {
        string ip ="";
        //covert_base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
         
        static MqttClient client;

        public Form2()
        {
            InitializeComponent();
           
            textBox3.Text = ip;
            client = new MqttClient(ip);
            client.Connect(Guid.NewGuid().ToString());


        }
        private void button1_Click(object sender, EventArgs e)
        {
            //browse
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.txt, *.json)|*txt;*.json";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                textBox1.Text = selectedFileName;
            }


        }

        private async void getData(string fileName)
        {

            using (StreamReader sr = new StreamReader(fileName))
            {

                while (!sr.EndOfStream)
                {

                    string s = sr.ReadLine();
                    textBox2.Text = s;
                    // Send message over MQTT
                    try
                    {
                        string message = Base64Encode(s);
                        client.MqttMsgPublished += client_MqttMsgPublished;
                        ushort msgId = client.Publish("test/", Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);

                    }
                    // Delay 1/30 second
                    await Task.Delay(1000/30);

                }
            }

        }
        private static void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ee)
            {
               // MessageBox.Show(ee.Message);
                //throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //send
            string file = textBox1.Text;
            getData(file);
        }

        private static void client_MqttMsgrecieved(object sender, MqttMsgPublishEventArgs e)
        {
            var msg = System.Text.Encoding.UTF8.GetString(e.Message);
            MessageBox.Show("message Recieved" + msg);
            client.MqttMsgPublished += client_MqttMsgPublished;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
