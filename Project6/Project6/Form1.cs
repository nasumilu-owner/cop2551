using Project6.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class form : Form
    {

        private readonly WorldSeriesService service;
        private readonly FileDataProvider teamsDataProvider;
        private readonly FileDataProvider winnersDataProvider;

        public form()
        {
            InitializeComponent();
            // Team data provider
            this.teamsDataProvider = new FileDataProvider("Teams.txt");
            // winners data provider
            this.winnersDataProvider = new FileDataProvider("WoldSeries.txt");
            // serivce which provides a predicate for counting world series wins.
            this.service = new WorldSeriesService(this.teamsDataProvider, this.winnersDataProvider);
            //Add event handler for file name changes to each of the data providers
            this.teamsDataProvider.FileNameChanged += this.TeamsFilename_Changed;
            this.winnersDataProvider.FileNameChanged += this.WinnersFilename_Changed;
        }

        /// <summary>
        /// Caches the current selected team index, sets selected item to null,  loads the winner's data, and 
        /// then sets the selected winner.
        /// 
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public void WinnersFilename_Changed(object send, EventArgs e)
        {
            int index = this.teamListBox.SelectedIndex;
            this.teamListBox.SelectedIndex = -1;
            this.winnerField.Text = String.Empty;
            this.teamListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Sets the team list box data soruce to the teams data provider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamsFilename_Changed(object sender, EventArgs e)
        {
            try
            {
                this.teamListBox.DataSource = this.service.Teams;
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(String.Format(Resources.FILE_NOT_FOUND_TPL, "Teams"),
                    Resources.FILE_NOT_FOUND_TITLE,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.OpenDataProviderMenuItem_Click(this.openTeamsMenuItem, e);
                }
            }
        }

        /// <summary>
        /// EventHanlder when the a team is selected in the ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectedTeam = (String)this.teamListBox.SelectedItem;
                if (null != selectedTeam)
                {
                    this.winnerField.Text = String.Format(Resources.WINNER_TPL, selectedTeam, this.service.NumWins(selectedTeam));
                } 
                else
                {
                    this.winnerField.Text = String.Empty;
                }
            } catch(Exception)
            {
                
                DialogResult result = MessageBox.Show(String.Format(Resources.FILE_NOT_FOUND_TPL, "World Series winner(s)"),
                    Resources.FILE_NOT_FOUND_TITLE,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    this.OpenDataProviderMenuItem_Click(this.winnersDataProvider, e);
                }
            }
        }

        /// <summary>
        /// Exits event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Open event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDataProviderMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(item.Text == Resources.TEAMS_OPEN_MENU_ITEM)
            {
                this.teamsDataProvider.SetPath();
            } 
            else if (item.Text == Resources.WINNERS_OPEN_MENU_ITEM)
            {
                int index = this.teamListBox.SelectedIndex;
                this.winnersDataProvider.SetPath();
                this.teamListBox.SelectedIndex = index;
            }
        }
    }
}
