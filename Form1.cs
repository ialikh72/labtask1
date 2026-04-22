using System;
using System.Speech.Synthesis;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labtask1
{
    public partial class Form1 : Form
    {
        class pic
        {
            public string name;
            public int age;
            public string gender;
            public string address;
            public string introduce()
            {
                return "My name is " + name + ". I am " + age + " years old. I am a " + gender + ". I live at " + address + ".";
            }
        }
        pic person1;


        // Add this field declaration inside the Form1 class, but outside any methods
        private System.Windows.Forms.TextBox textBox1;
        private SpeechSynthesizer speaker;

        public Form1()
        {
            InitializeComponent();
            speaker = new SpeechSynthesizer(); // Use the field instead of a local variable
            person1 = new pic();
            string name = "John Doe";
            int age = 30;
            string gender = "Male";
            string address = "123 Main St, Anytown, USA";
            person1.name = name;
            person1.age = age;
            person1.gender = gender;
            person1.address = address;

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string intro = person1.introduce();
            MessageBox.Show(intro);
            speaker.Speak(intro); // 🔊 voice
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            person1.name = "Jane Smith";
            person1.age = 30;
            person1.gender = "Female";
            person1.address = "456 Elm St, Othertown, USA";

            string intro = person1.introduce();
            MessageBox.Show(intro);
            speaker.Speak(intro); // 🔊 speaks
        }
    }
}
