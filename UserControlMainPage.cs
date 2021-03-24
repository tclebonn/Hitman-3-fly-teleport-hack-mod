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
            //from 1.1
            float currentYPosition3 = mem.ReadFloat(enums.hitmanProcessName + enums.yPlayerOffset3);
            float currentrealXPosition = mem.ReadFloat(enums.hitmanProcessName + enums.realplayerX);
            float currentrealZPosition = mem.ReadFloat(enums.hitmanProcessName + enums.realplayerZ);
            float currentrealYPosition = mem.ReadFloat(enums.hitmanProcessName + enums.realplayerY);

            float newYposition3;
            float newrealXposition;
            float newrealZposition;
            float newrealYposition;

            //
            float newXposition;
            float newZposition;
            float newYposition;


            switch (keyId)
            {
                case 7:
                    newXposition = currentXPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", newXposition.ToString());

                    //from 1.1
                    newrealXposition = currentrealXPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerX, "float", newrealXposition.ToString());
                    break;
                case 4:
                    newXposition = currentXPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", newXposition.ToString());
                    //from 1.1
                    newrealXposition = currentrealXPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerX, "float", newrealXposition.ToString());
                    break;

                case 8:
                    newZposition = currentZPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", newZposition.ToString());
                    //from 1.1
                    newrealZposition = currentrealZPosition + xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerZ, "float", newrealZposition.ToString());
                    break;
                case 5:
                    newZposition = currentZPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", newZposition.ToString());
                    //from 1.1
                    newrealZposition = currentrealZPosition - xMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerZ, "float", newrealZposition.ToString());
                    break;

                case 9:
                    newYposition = currentYPosition + yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", newYposition.ToString());
                    //from 1.1
                    newYposition3 = currentYPosition3 + yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset2, "float", newYposition.ToString());
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset3, "float", newYposition3.ToString());

                    newrealYposition = currentrealYPosition + yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerY, "float", newrealYposition.ToString());

                    break;
                case 6:
                    newYposition = currentYPosition - yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", newYposition.ToString());
                    //from 1.1
                    newYposition3 = currentYPosition3 - yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset2, "float", newYposition.ToString());
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset3, "float", newYposition3.ToString());

                    newrealYposition = currentrealYPosition - yMultiplier;
                    mem.WriteMemory(enums.hitmanProcessName + enums.realplayerY, "float", newrealYposition.ToString());
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

                mem.WriteMemory("hitman3.exe+C140EA", "bytes", "90 90 90 90 90");
                mem.WriteMemory("hitman3.exe+C140FA", "bytes", "90 90 90 90 90");
            }
            else
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74A2", "bytes", "0F 11 86 10 02 00 00");

                mem.WriteMemory("hitman3.exe+C140EA", "bytes", "F3 0F 11 43 60");
                mem.WriteMemory("hitman3.exe+C140FA", "bytes", "F3 0F 11 4B 64");
            }

        }

        private void CheckBoxYAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxYAxis.Checked)
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "90 90 90 90 90 90 90 90");

                //from 1.1
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+5220", "bytes", "90 90 90 90 90 90");
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB13", "bytes", "90 90 90 90 90");//fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB43", "bytes", "90 90 90 90 90");//fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+55FB", "bytes", "90 90 90 90 90 90");
                //y2
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+5207", "bytes", "90 90 90 90 90 90");
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AAD3", "bytes", "90 90 90 90 90");//fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB0A", "bytes", "90 90 90 90 90");//fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+55CE", "bytes", "90 90 90 90 90 90 90");

                //real player offset ?
                mem.WriteMemory("hitman3.exe+C140F5", "bytes", "90 90 90 90 90");
               // mem.WriteMemory("hitman3.exe+C13FE5", "bytes", "90 90 90 90 90");



            }
            else
            {
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "F2 0F 11 8E 20 02 00 00");
                //from 1.1
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+5220", "bytes", "41 0F 11 44 24 20");
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB13", "bytes", "F2 0F 11 59 28"); //fpuguard
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB43", "bytes", "F2 0F 11 41 28"); //fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+55FB", "bytes", "F2 41 0F 11 4F 68");

                //y2
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+5207", "bytes", "41 0F 11 4C 24 10");
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AAD3", "bytes", "F2 0F 11 59 10"); //fpuguard
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+AB0A", "bytes", "F2 0F 11 49 10"); //fpu
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+55CE", "bytes", "F2 41 0F 11 44 24 10");
                //real player offset ?
                mem.WriteMemory("hitman3.exe+C140F5", "bytes", "F3 0F 11 43 68");
                //mem.WriteMemory("hitman3.exe+C13FE5", "bytes", "F3 0F 11 43 68");

            }

        }
    }
}
