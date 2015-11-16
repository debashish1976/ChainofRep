using System;
using System.Windows.Forms;
using System.IO;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        listBox1.DataSource = Chain.lst;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (fDialog.ShowDialog() == DialogResult.OK)
        {
            tSRC.Text = fDialog.SelectedPath;
            btnScan.Enabled = true;
        }
    }





    private void button2_Click(object sender, EventArgs e)
    {
        Worm worm = new Worm();
        TorjanHorse Th = new TorjanHorse();
        Spyware spy = new Spyware();
        worm.NextEngine(Th);
        Th.NextEngine(spy);
        string[] files = Directory.GetFiles(tSRC.Text, "*.txt");
        foreach (string file in files)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                Input p = new Input(file, sr.ReadLine());
                if (p != null)
                    worm.Process(p);
            }

        }
        listBox1.DataSource = null;
        listBox1.DataSource = Chain.lst;
        //Chain.lst.Clear();

    }


}
