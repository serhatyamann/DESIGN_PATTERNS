using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_Pattern
{
    public partial class FormSingleton : Form
    {
        public FormSingleton()
        {
            InitializeComponent();
        }

        private void FormSingleton_Load(object sender, EventArgs e)
        {
            //You can not create an instance by using new keyword because we made our constructor private.

            SingletonExample singleton = SingletonExample.GetInstance();
            SingletonExample singleton1 = SingletonExample.GetInstance();

            MessageBox.Show($"{singleton.GetHashCode()} - {singleton1.GetHashCode()}");

            #region Output
            //Output
            //30015890 - 30015890 
            #endregion

            //Which means we used the same "SingletonExample" instance because we already created an instance named "singleton" before. 
        }
    }
}
