using Memory;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Hitman3Reworked
{
    public delegate void MyEventHandler(object source);
    public partial class UserControlMainPage : UserControl
    {
        public Mem mem = new Mem();
        readonly Enums enums = new Enums();
        bool processOpened = false;
        float xMultiplier;
        float yMultiplier;

        public UserControlMainPage()
        {
            InitializeComponent();
        }

        private void UserControlMainPage_Load(object sender, EventArgs e)
        {
            xMultiplier = float.Parse(TextBoxXMultiplier.Text, CultureInfo.InvariantCulture);
            yMultiplier = float.Parse(textBoxYMultiplier.Text, CultureInfo.InvariantCulture);
            backgroundWorker1.RunWorkerAsync();
        }

        public void KeysPressFunctions(Int32 keyId)
        {
            switch (keyId)
            {
                case 0:
                    {
                        if (CheckBoxXAxis.Checked && CheckBoxYAxis.Checked)
                        {
                            CheckBoxXAxis.Checked = false;
                            CheckBoxYAxis.Checked = false;
                        }
                        else
                        {
                            CheckBoxXAxis.Checked = true;
                            CheckBoxYAxis.Checked = true;
                        }
                        break;
                    }

                case 1:
                    {
                        if (CheckBoxXAxis.Checked)
                        {
                            CheckBoxXAxis.Checked = false;
                        }
                        else
                        {
                            CheckBoxXAxis.Checked = true;
                        }
                        break;
                    }

                case 2:
                    {
                        if (CheckBoxYAxis.Checked)
                        {
                            CheckBoxYAxis.Checked = false;
                        }
                        else
                        {
                            CheckBoxYAxis.Checked = true;
                        }
                        break;
                    }
            }
        }

        public void ManagePlayerMovements(int keyId)
        {
            float currentXPosition = mem.ReadFloat(enums.hitmanProcessName + enums.xPlayerOffset);
            float currentZPosition = mem.ReadFloat(enums.hitmanProcessName + enums.zPlayerOffset);
            float currentYPosition = mem.ReadFloat(enums.hitmanProcessName + enums.yPlayerOffset);

            float newXposition;
            float newZposition;
            float newYposition;


            switch (keyId)
            {
                case 7:
                    newXposition = currentXPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", newXposition.ToString());
                    break;
                case 4:
                    newXposition = currentXPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", newXposition.ToString());

                    break;

                case 8:
                    newZposition = currentZPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", newZposition.ToString());

                    break;
                case 5:
                    newZposition = currentZPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", newZposition.ToString());
                    
                    break;

                case 9:
                    newYposition = currentYPosition + yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", newYposition.ToString());
                    break;
                case 6:
                    newYposition = currentYPosition - yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", newYposition.ToString());
                    break;

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!mem.OpenProcess(enums.hitmanProcessName))
                {
                    System.Threading.Thread.Sleep(1000);
                    return;
                }
                else
                {
                    processOpened = true;
                    backgroundWorker1.ReportProgress(0);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void buttonXAxis_Click(object sender, EventArgs e)
        {
            xMultiplier = float.Parse(TextBoxXMultiplier.Text, CultureInfo.InvariantCulture);
            yMultiplier = float.Parse(textBoxYMultiplier.Text, CultureInfo.InvariantCulture);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void CheckBoxXAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxXAxis.Checked)
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74A2", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74A2", "bytes", "0F 11 86 10 02 00 00");
            }

        }

        private void CheckBoxYAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxYAxis.Checked)
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "90 90 90 90 90 90 90 90");

            }
            else
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "F2 0F 11 8E 20 02 00 00");
            }

        }
    }
}
