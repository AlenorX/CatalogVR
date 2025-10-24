using CatalogVR.Properties;
using System.Diagnostics;

namespace CatalogVR
{
    public partial class Form1 : Form
    {
        Information.HalfLife halfLife = new Information.HalfLife();
        Information.AmongUs amongUs = new Information.AmongUs();
        Information.JobSimulator jobSimulator = new Information.JobSimulator();
        DesignProgram designProgram = new DesignProgram();
        public Form1()
        {
            InitializeComponent();
            DesignElements();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NameGame1.Text = halfLife.nameGame;
            Description1.Text = halfLife.descriptionGame;
            Image1.BackgroundImage = Resources.HalfLife;

            NameGame2.Text = amongUs.nameGame;
            Description2.Text = amongUs.descriptionGame;
            Image2.BackgroundImage = Resources.AmongUs;

            NameGame3.Text = jobSimulator.nameGame;
            Description3.Text = jobSimulator.descriptionGame;
            Image3.BackgroundImage = Resources.JobSimulator;
        }

        private void DesignElements()
        {
            designProgram.SetRoundedShape(PanelGame1, 40);
            designProgram.SetRoundedShape(PanelGame2, 40);
            designProgram.SetRoundedShape(PanelGame3, 40);
            designProgram.SetRoundedShape(Image1, 40);
            designProgram.SetRoundedShape(Image2, 40);
            designProgram.SetRoundedShape(Image3, 40);
            designProgram.SetRoundedShape(ButtonGame1, 40);
            designProgram.SetRoundedShape(ButtonGame2, 40);
            designProgram.SetRoundedShape(ButtonGame3, 40);
        }

        private void ButtonGame1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://store.steampowered.com/app/546560/HalfLife_Alyx",
                UseShellExecute = true
            });
        }

        private void ButtonGame2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://store.steampowered.com/app/1849900/Among_Us_3D_VR",
                UseShellExecute = true
            });
        }

        private void ButtonGame3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://store.steampowered.com/app/448280/Job_Simulator",
                UseShellExecute = true
            });
        }
    }
}
