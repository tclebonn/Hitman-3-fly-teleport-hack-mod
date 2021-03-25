using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace Hitman3Reworked
{
    public partial class UserControlTeleport : UserControl
    {
        public Mem mem = new Mem();
        readonly Enums enums = new Enums();
        readonly string fileNamePath = "./hitman3Location.txt";
        List<Location> savedLocations = new List<Location>();
        bool isCycleActive = false;
        public UserControlTeleport()
        {
            InitializeComponent();
        }

        private void UserControlTeleport_Load(object sender, EventArgs e)
        {
            ManageCoordFile();
            if(savedPositionsComboBox.Items.Count > 0 )
            {
                savedPositionsComboBox.SelectedIndex = 0;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void ManageCoordFile() // read location from file and store in Location class
        {
            var numOftries = 5;
            if (!File.Exists(fileNamePath))
            {
                var createFile = File.CreateText(fileNamePath);
                createFile.Close();
            }
            for (var i = 0; i < numOftries; i++)
            {
                try
                {
                    var lines = File.ReadLines(fileNamePath).ToList();
                    savedLocations = ManageLocationString(lines);
                    break;

                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private List<Location> ManageLocationString(List<string> locations) //put all saved locations name in comboBox
        {
            savedPositionsComboBox.Items.Clear();
            List<Location> savedLocations =  new List<Location>();
            foreach (var location in locations)
            {
                var splittedlocation = location.Split(";");
                savedPositionsComboBox.Items.Add(splittedlocation[0]);

                savedLocations.Add(new Location(splittedlocation));
            }

            return savedLocations;
        }

        private void button1_Click(object sender, EventArgs e) // save position button
        {
            if (savedPositionsComboBox.Text == "")
            {
                return;
            }
            if (!File.Exists(fileNamePath))
            {
                var createFile = File.CreateText(fileNamePath);
                createFile.Close();
            }
            List<string> location = new List<string>();
            location.Add(savedPositionsComboBox.Text);
            location.Add(GetPosition("y").ToString());
            location.Add(GetPosition("x").ToString());
            location.Add(GetPosition("z").ToString());
            var stringToWrite = string.Join(";", location);
            File.AppendAllText(fileNamePath, stringToWrite + "\n");

            ManageCoordFile(); // reload File
        }

        private float GetPosition(string position)
        {
            switch (position)
            {
                case "y":
                    return mem.ReadFloat(enums.hitmanProcessName + enums.yPlayerOffset);
                case "x":
                    return mem.ReadFloat(enums.hitmanProcessName + enums.xPlayerOffset);
                case "z":
                    return mem.ReadFloat(enums.hitmanProcessName + enums.zPlayerOffset);
            }

            return -999;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (!mem.OpenProcess(enums.hitmanProcessName))
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    backgroundWorker1.ReportProgress(0);
                }
                Thread.Sleep(1000);
            }
        }

        private void buttonTeleportToSavedPosition_Click(object sender, EventArgs e) // teleport to saved position
        {
            if (IsValidLocation())
            {
                TPToPosition(false);
            }
            return;
        }

        private void buttonTPToPosition_Click(object sender, EventArgs e)
        {
            if (IsValidLocation())
            {
                TPToPosition(true);
            }
            return;
        }

        private bool IsValidLocation()
        {
            return savedPositionsComboBox.Text != "";
        }

        public void TPToPosition(bool manualPosition)
        {
            byte[] comparer = new byte[] { 144, 144, 144, 144, 144, 144, 144 }; // check if the nop is already write in memory

            var isYcheckBoxActive = mem.ReadBytes("PhysX3CharacterKinematic_x64.dll+74AE", 7).SequenceEqual(comparer); // if false . after write i restore original situaation
            var isXcheckBoxActive = mem.ReadBytes("PhysX3CharacterKinematic_x64.dll+74A2", 7).SequenceEqual(comparer); // if false . after write i restore original situaation

            mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74A2", "bytes", "90 90 90 90 90 90 90");
            mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "90 90 90 90 90 90 90 90");

            if(manualPosition) // get coords from combo
            {
                mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", textboxmanualY.Text);
                mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", textboxmanualX.Text);
                mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", textboxmanualZ.Text);
            }
            else // get coords from class
            {
                var location = savedLocations.Where(loc => loc.LocationName == savedPositionsComboBox.Text).First();
                if (location != null)
                {
                    mem.WriteMemory(enums.hitmanProcessName + enums.yPlayerOffset, "float", location.YAxis.ToString());
                    mem.WriteMemory(enums.hitmanProcessName + enums.xPlayerOffset, "float", location.XAxis.ToString());
                    mem.WriteMemory(enums.hitmanProcessName + enums.zPlayerOffset, "float", location.ZAxis.ToString());
                }

                if(isCycleActive)
                {
                    Cyclelocations();
                }
            }
                

            if (!isYcheckBoxActive)
            {
                Thread.Sleep(500);
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74AE", "bytes", "F2 0F 11 8E 20 02 00 00");
            }
            if (!isXcheckBoxActive)
            {
                Thread.Sleep(500);
                mem.WriteMemory("PhysX3CharacterKinematic_x64.dll+74A2", "bytes", "0F 11 86 10 02 00 00");
            }

        }

        private void checkBoxCycle_CheckedChanged(object sender, EventArgs e)
        {
            isCycleActive = checkBoxCycle.Checked;
        }

        private void Cyclelocations()
        {
            var items = savedPositionsComboBox.Items;
            var currentItem = savedPositionsComboBox.SelectedIndex;
            if (items.Count > 1)
            {
                if (currentItem < items.Count-1)
                {
                    savedPositionsComboBox.SelectedIndex++;
                }   
                else if(currentItem == items.Count-1)
                {
                    savedPositionsComboBox.SelectedIndex = 0;
                }
            }
            
        }
    }
}
