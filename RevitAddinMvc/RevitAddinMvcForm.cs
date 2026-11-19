using System;
using System.Drawing;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAddinMvc
{
    public partial class RevitAddinMvcForm : Form
    {
        private ExternalCommandData _commandData;
        private RevitAddinModel _model;
        private View _activeView;

        public RevitAddinMvcForm(ExternalCommandData commandData)
        {
            InitializeComponent();
            _commandData = commandData;
            _model = new RevitAddinModel(_commandData.Application.ActiveDocument);
            _activeView = _model.GetActiveView();

            this.Text = "Revit Addin MVC - Claude Integration";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Width = 400;
            this.Height = 300;

            LoadData();
        }

        private void LoadData()
        {
            var walls = _model.GetAllWalls();
            lblWallCount.Text = $"Total Walls: {walls.Length}";
            int levelCount = _model.GetLevelCount();
            lblLevelCount.Text = $"Total Levels: {levelCount}";
            lblActiveView.Text = $"Active View: {_activeView.Name}";

            foreach (var wall in walls)
            {
                cboWalls.Items.Add(wall.Name);
            }

            if (walls.Length > 0)
                cboWalls.SelectedIndex = 0;
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboWalls.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a wall first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Document doc = _commandData.Application.ActiveDocument;
                XYZ location = new XYZ(0, 0, 0);
                string noteText = $"Note from Claude MVC Addin - Wall: {cboWalls.SelectedItem}";

                Note note = _model.CreateNote(location, noteText, _activeView);

                if (note != null)
                {
                    MessageBox.Show($"Note created successfully at location ({location.X}, {location.Y}, {location.Z})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboWalls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWalls.SelectedIndex >= 0)
            {
                lblSelectedWall.Text = $"Selected: {cboWalls.SelectedItem}";
            }
        }
    }
}