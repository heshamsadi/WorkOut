using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WorkOut
{

    public partial class Form1 : Form
    {

        #region Attributes Declaration
        string[,] M;
        List<string>[] workoutList;
        //replacing M[days,strings] with WorkoutList[]
        List<Split> splitList = new List<Split>();
        #endregion

        #region Form Methods
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DaysNumberAddSplitCB.DataSource = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            DaysNumberAddSplitCB.SelectedItem = null;
        }
        #endregion

        #region Menu Buttons
        private void TrackButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(TrackPanel);
        }
        private void WorkoutButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(WorkoutPanel);
        }
        private void SplitsButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(SplitsPanel);
        }
        #endregion

        #region Add Split Buttons
        private void AddSplitButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(AddSplitPanel, SplitsPanel);
        }

        //changes the number of days in the "Day" ComboBox to match the "Days Number" ComboBox
        public void DaysNumberAddSplitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            M = new string[Convert.ToInt32(DaysNumberAddSplitCB.SelectedItem), 20];
            workoutList = new List<string>[DaysNumberAddSplitCB.SelectedIndex+1];
            for(int i = 0; i<workoutList.Length; i++)
            {
                workoutList[i] = new List<string>();
            }

            DayAddSplitCB.SelectedItem = null;
            DayAddSplitCB.Items.Clear();
            for (int i = 1; i <= Convert.ToInt32(DaysNumberAddSplitCB.SelectedItem); i++)
            {
                DayAddSplitCB.Items.Add(i);
            }

        }
        //clears the listbox in addsplit panel and updates it when ever the selected item in DayAddSplitCB (or DaysNumberAddSplit) is changed
        private void DayAddSplitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAddSplit.Items.Clear();
            listBoxUpdate();
        }

        // fills the matrice M that holds [daysRows,workoutsColumns] with the workout matching its position then clears the textbox
        private void SaveWorkoutAddSplitBTN_Click(object sender, EventArgs e)
        {
            if (WorkoutNameAddSplitTB.Text != "" && SplitNameAddSplitTB.Text != "" && DaysNumberAddSplitCB.SelectedItem != null && DayAddSplitCB.SelectedItem != null && M != null)
            {
                //Filling the workoutList with workout names
                workoutList[DayAddSplitCB.SelectedIndex].Add(WorkoutNameAddSplitTB.Text);


                for (int i = 0; i < M.GetLength(1); i++)
                {
                    if (M[Convert.ToInt32(DayAddSplitCB.SelectedItem) - 1, i] == null)
                    {
                        M[Convert.ToInt32(DayAddSplitCB.SelectedItem) - 1, i] = WorkoutNameAddSplitTB.Text;
                        listBoxAddSplit.Items.Add(WorkoutNameAddSplitTB.Text);
                        break;
                    }
                }
                WorkoutNameAddSplitTB.Clear();
            }
            else
            {
                MessageBox.Show("All Fields Should Be Filled !!");
            }

        }

        //if file isn't empty recover previously saved splits on the splits.bin file and save them to splitList
        //add new split to splitList
        //loop through the list to remove unwanted empty elements
        //serialize splitList to splits.bin
        private void SaveAddSplitBTN_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("splits.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (new FileInfo("splits.bin").Length > 0)
            {
                splitList = (List<Split>)bf.Deserialize(fs);
                splitList.Add(new Split(SplitNameAddSplitTB.Text, DaysNumberAddSplitCB.SelectedIndex + 1, M));
                for (int i = 0; i < splitList.Count(); i++)
                {
                    if (splitList[i].splitName.Equals("") || splitList[i].splitName == null)
                    {
                        splitList.Remove(splitList[i]);
                        break;
                    }
                }
            }
            fs.Close();
            fs = new FileStream("splits.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(fs, splitList);
            fs.Close();

        }
        // TESTING ONLY!!
        private void CancelAddSplitBTN_Click_1(object sender, EventArgs e)
        {

            string line = "";
            for(int i = 0; i < workoutList.Length; i++)
            {
                for(int j = 0; j < workoutList[i].Count(); j++)
                {
                    line += workoutList[i][j]+",";
                }
                line += "\n";
            }
            MessageBox.Show(line);
        }
        //Clears all the textBoxs and ComboBoxs in AddSplit Panel then Focuses on the splitNameTB
        private void ClearAddSplitBTN_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in AddSplitPanel.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
            foreach (ComboBox item in AddSplitPanel.Controls.OfType<ComboBox>())
            {
                item.SelectedItem = null;
                SplitNameAddSplitTB.Focus();
            }
        }

        #endregion
        #region Edit Split Buttons
        //clears split ListBox and loads splitList from splits.bin then fills the listBox with split names
        private void EditSplitButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(EditSplitPanel, SplitsPanel);
            SplitsESLB.Items.Clear();
            SplitNameESTB.Text = "";
            DaysNumberESCB.Items.Clear();
            WorkoutNameESTB.Clear();
            WorkoutESLB.Items.Clear();
            DayESCB.Items.Clear();
            loadSplitList();
            foreach(Split item in splitList)
            {
                SplitsESLB.Items.Add(item.splitName);
            }
        }
        //checks if an item is selected,fills textBoxs,initiats Days number and selects the number,clears selected Day,fills the day select CB
        private void SplitsESLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SplitsESLB.SelectedItem == null)
                return;
            DayESCB.Items.Clear();
            SplitNameESTB.Text = splitList[SplitsESLB.SelectedIndex].splitName;
            DaysNumberESCB.DataSource = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            DaysNumberESCB.SelectedItem = splitList[SplitsESLB.SelectedIndex].dayWorkouts.GetLength(0);
           
            DayESCB.SelectedItem = null;
            for (int i = 1; i <= Convert.ToInt32(DaysNumberESCB.SelectedItem); i++)
            {
                DayESCB.Items.Add(i);
            }


        }
        #endregion
        #region Remove Split Butons
        //Clears the list view then loads splitList from splits.bin then fills the Remove Splits with split name and day count from the list
        private void RemoveSplitButton_Click(object sender, EventArgs e)
        {
            hideOtherPanels(RemoveSplitPanel, SplitsPanel);
            SplitsRemoveSplitLV.Items.Clear();
            DaysRemoveSplitLV.Items.Clear();
            loadSplitList();
            foreach (Split item in splitList)
            {
                SplitsRemoveSplitLV.Items.Add(new ListViewItem(new string[] { item.splitName, item.daysNumber.ToString() }));
            }
        }
        //if Split.count... to avoid empty selections
        //clears the daysRemoveSplitLV then fills it with days and workouts from the item.dayWorkouts Matrice
        private void SplitsRemoveSplitLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SplitsRemoveSplitLV.SelectedItems.Count == 0)
                return;
            DaysRemoveSplitLV.Items.Clear();
            for (int i = 0; i < splitList[SplitsRemoveSplitLV.SelectedIndices[0]].dayWorkouts.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < splitList[SplitsRemoveSplitLV.SelectedIndices[0]].dayWorkouts.GetLength(1); j++)
                {
                    if (splitList[SplitsRemoveSplitLV.SelectedIndices[0]].dayWorkouts[i, j] != null)
                    {
                        line += splitList[SplitsRemoveSplitLV.SelectedIndices[0]].dayWorkouts[i, j] + ", ";
                    }

                }
                DaysRemoveSplitLV.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), line }));
            }
        }
        //remove the selcted index from listView in SplitList, clear list view, refill list view with splitList,save to split.bin
        private void DeleteSplitRemoveSplitBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Deletion", "Delete Split", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (SplitsRemoveSplitLV.SelectedItems.Count == 0)
                    return;
                splitList.Remove(splitList[SplitsRemoveSplitLV.SelectedIndices[0]]);
                SplitsRemoveSplitLV.Items.Clear();
                foreach (Split item in splitList)
                {
                    SplitsRemoveSplitLV.Items.Add(new ListViewItem(new string[] { item.splitName, item.daysNumber.ToString() }));
                }
                saveSplitList();
            }

        }
        #endregion

        #region Helpers
        // hides other panels than the one clicked on using the panel it self
        public void hideOtherPanels(Panel childPanel)
        {
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                if (panel.Name.Equals(childPanel.Name))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }
        // hides other panels than the one clicked on using the panel itself and the including panel
        public void hideOtherPanels(Panel childPanel, Panel parentPanel)
        {
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                if (panel.Name.Equals(parentPanel.Name))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
            foreach (Panel panel in parentPanel.Controls.OfType<Panel>())
            {
                if (panel.Name.Equals(childPanel.Name))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }
        //updates the listbox in addsplit panel
        public void listBoxUpdate()
        {
            for (int i = 0; i < M.GetLength(1); i++)
            {
                try
                {
                    if (M[Convert.ToInt32(DayAddSplitCB.SelectedItem) - 1, i] == null)
                    {
                        break;
                    }
                    else
                    {
                        listBoxAddSplit.Items.Add(M[Convert.ToInt32(DayAddSplitCB.SelectedItem) - 1, i]);
                    }
                }
                catch
                {

                }
            }
        }
        public void loadSplitList()
        {
            FileStream fs = new FileStream("splits.bin", FileMode.OpenOrCreate, FileAccess.Read);
            if (new FileInfo("splits.bin").Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();
                splitList = (List<Split>)bf.Deserialize(fs);
            }
            fs.Close();
        }
        public void saveSplitList()
        {
            FileStream fs = new FileStream("splits.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, splitList);
            fs.Close();
        }




        #endregion


        #region unwanted Methods
        private void CancelAddSplitBTN_Click(object sender, EventArgs e)
        {

        }
        private void EditSplitPanel_Paint(object sender, PaintEventArgs e)
        {

        }




        #endregion

        
    }
}
