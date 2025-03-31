using System.Diagnostics.Metrics;
using Project_JohnsonPraska.Screens.Vehicles;

namespace Project_JohnsonPraska
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void ResetSunroofButtons()
        {
            picSunroofOpen.Enabled = true;
            picSunroofOpen.BackColor = Control.DefaultBackColor;

            picSunroofClose.Enabled = true;
            picSunroofClose.BackColor = Control.DefaultBackColor;
        }

        private void ResetOverlays()
        {
            if (originalUnlockImage != null)
            {
                RemoveGrayOverlay(picUnlock, originalUnlockImage);
            }
            if (originalLockImage != null)
            {
                RemoveGrayOverlay(picLock, originalLockImage);
            }
            if (originalAlarmOffImage != null)
            {
                RemoveGrayOverlay(picAlarmOff, originalAlarmOffImage);
            }
            if (originalAlarmOnImage != null)
            {
                RemoveGrayOverlay(picAlarmOn, originalAlarmOnImage);
            }
            if (originalUpImage != null)
            {
                RemoveGrayOverlay(picWindowsUp, originalUpImage);
            }
            if (originalDownImage != null)
            {
                RemoveGrayOverlay(picWindowsDown, originalDownImage);
            }
            if (originalUpImage != null)
            {
                RemoveGrayOverlay(picWindowsUp, originalUpImage);
            }
            if (originalDownImage != null)
            {
                RemoveGrayOverlay(picWindowsDown, originalDownImage);
            }

            picUnlock.Enabled = true;
            picLock.Enabled = true;
            picAlarmOn.Enabled = true;
            picAlarmOff.Enabled = true;
            picWindowsUp.Enabled = true;
            picWindowsDown.Enabled = true;
            picSunroofOpen.Enabled = true;
            picSunroofClose.Enabled = true;

        }

        private void cmbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetOverlays();
            ResetSunroofButtons();

            if (cmbVehicles.SelectedIndex == 0)
            {
                picCar.Image = Project_JohnsonPraska.Properties.Resources.Equinox;
                lblVH1L.Text = "Temp";
                lblVH2L.Text = "Oil Life";
                lblVH3L.Text = "Gas";
                lblVH4L.Text = "Power";
                lblVH1.Text = "47 °F";
                lblVH2.Text = "29%";
                lblVH3.Text = "87 Miles";
                lblVH4.Text = "Off";
                lblVH1L.Visible = true;
                lblVH2L.Visible = true;
                lblVH3L.Visible = true;
                lblVH4L.Visible = true;
                lblVH5L.Visible = false;
                lblVH1.Visible = true;
                lblVH2.Visible = true;
                lblVH3.Visible = true;
                lblVH4.Visible = true;
                lblVH5.Visible = false;
                lblStartStop.Text = "Start";
            }
            else if (cmbVehicles.SelectedIndex == 1)
            {
                picCar.Image = Project_JohnsonPraska.Properties.Resources.Model_X;
                lblVH1L.Text = "Temp";
                lblVH2L.Text = "Battery";
                lblVH3L.Text = "Power";
                lblVH1.Text = "68 °F";
                lblVH2.Text = "82%";
                lblVH3.Text = "Off";
                lblVH1L.Visible = true;
                lblVH2L.Visible = true;
                lblVH3L.Visible = true;
                lblVH4L.Visible = false;
                lblVH5L.Visible = false;
                lblVH1.Visible = true;
                lblVH2.Visible = true;
                lblVH3.Visible = true;
                lblVH4.Visible = false;
                lblVH5.Visible = false;
                lblStartStop.Text = "Start";
            }
            else
            {
                picCar.Image = Project_JohnsonPraska.Properties.Resources.Prius;
                lblVH1L.Text = "Temp";
                lblVH2L.Text = "Gas";
                lblVH3L.Text = "Battery";
                lblVH4L.Text = "Oil Life";
                lblVH5L.Text = "Power";
                lblVH1.Text = "54 °F";
                lblVH2.Text = "187 Miles";
                lblVH3.Text = "67%";
                lblVH4.Text = "43%";
                lblVH5.Text = "Off";
                lblVH1L.Visible = true;
                lblVH2L.Visible = true;
                lblVH3L.Visible = true;
                lblVH4L.Visible = true;
                lblVH5L.Visible = true;
                lblVH1.Visible = true;
                lblVH2.Visible = true;
                lblVH3.Visible = true;
                lblVH4.Visible = true;
                lblVH5.Visible = true;
                lblStartStop.Text = "Start";
            }
        }

        private void lblMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void picMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void picMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void lblPowerVal_TextChanged(object sender, EventArgs e)
        {
            if (cmbVehicles.SelectedIndex == 0)
            {
                if (lblVH4.Text == "Off")
                {
                    lblStartStop.Text = "Start";
                }
                else if (lblVH4.Text == "On")
                {
                    lblStartStop.Text = "Stop";
                }
            }
            else if (cmbVehicles.SelectedIndex == 1)
            {
                if (lblVH5.Text == "Off")
                {
                    lblStartStop.Text = "Start";
                }
                else if (lblVH5.Text == "On")
                {
                    lblStartStop.Text = "Stop";
                }
            }
        }

        private void picStartStop_Click(object sender, EventArgs e)
        {
            if (lblStartStop.Text == "Start")
            {
                MessageBox.Show("Your car has started successfully!");
                if (cmbVehicles.SelectedIndex == 0)
                {
                    lblVH4.Text = "On";
                }
                else if (cmbVehicles.SelectedIndex == 1)
                {
                    lblVH3.Text = "On";
                }
                else
                {
                    lblVH5.Text = "On";
                }
                lblStartStop.Text = "Stop";
            }
            else if (lblStartStop.Text == "Stop")
            {
                MessageBox.Show("Your car has stopped successfully!");
                if (cmbVehicles.SelectedIndex == 0)
                {
                    lblVH4.Text = "Off";
                }
                else if (cmbVehicles.SelectedIndex == 1)
                {
                    lblVH3.Text = "Off";
                }
                else
                {
                    lblVH5.Text = "Off";
                }
                lblStartStop.Text = "Start";
            }
        }

        private void picUnlock_Click(object sender, EventArgs e)
        {
            if (originalUnlockImage == null)
            {
                originalUnlockImage = new Bitmap(picUnlock.Image);
            }

            picUnlock.Enabled = false;
            ApplyGrayOverlay(picUnlock);

            picLock.Enabled = true;
            if (originalLockImage == null)
            {
                originalLockImage = new Bitmap(picLock.Image);
            }
            RemoveGrayOverlay(picLock, originalLockImage);

            MessageBox.Show("Doors unlocked successfully!");
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            if (originalLockImage == null)
            {
                originalLockImage = new Bitmap(picLock.Image);
            }

            picLock.Enabled = false;
            ApplyGrayOverlay(picLock);

            picUnlock.Enabled = true;
            if (originalUnlockImage == null)
            {
                originalUnlockImage = new Bitmap(picUnlock.Image);
            }
            RemoveGrayOverlay(picUnlock, originalUnlockImage);

            MessageBox.Show("Doors locked successfully!");
        }

        private Bitmap originalUpImage;
        private Bitmap originalDownImage;
        private Bitmap originalAlarmOffImage;
        private Bitmap originalAlarmOnImage;
        private Bitmap originalLockImage;
        private Bitmap originalUnlockImage;

        private void ApplyGrayOverlay(PictureBox pic)
        {
            if (pic.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(pic.Image);
                Bitmap grayBitmap = new Bitmap(pic.Width, pic.Height);

                using (Graphics g = Graphics.FromImage(grayBitmap))
                {
                    g.DrawImage(originalBitmap, 0, 0, pic.Width, pic.Height);

                    using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Gray)))
                    {
                        g.FillRectangle(brush, 0, 0, pic.Width, pic.Height);
                    }
                }

                pic.Image = grayBitmap;
            }
        }

        private void RemoveGrayOverlay(PictureBox pic, Bitmap originalImage)
        {
            pic.Image = new Bitmap(originalImage);
        }

        private void picWindowsUp_Click(object sender, EventArgs e)
        {
            if (originalUpImage == null)
            {
                originalUpImage = new Bitmap(picWindowsUp.Image);
            }

            picWindowsUp.Enabled = false;
            ApplyGrayOverlay(picWindowsUp);

            picWindowsDown.Enabled = true;
            if (originalDownImage == null)
            {
                originalDownImage = new Bitmap(picWindowsDown.Image);
            }
            RemoveGrayOverlay(picWindowsDown, originalDownImage);

            MessageBox.Show("Windows rolled up successfully!");
        }

        private void picWindowsDown_Click(object sender, EventArgs e)
        {
            if (originalDownImage == null)
            {
                originalDownImage = new Bitmap(picWindowsDown.Image);
            }

            picWindowsDown.Enabled = false;
            ApplyGrayOverlay(picWindowsDown);

            picWindowsUp.Enabled = true;
            if (originalUpImage == null)
            {
                originalUpImage = new Bitmap(picWindowsUp.Image);
            }
            RemoveGrayOverlay(picWindowsUp, originalUpImage);

            MessageBox.Show("Windows rolled down successfully!");
        }

        private void picSunroofClose_Click(object sender, EventArgs e)
        {
            picSunroofClose.Enabled = false;
            picSunroofClose.BackColor = Color.Gray;

            picSunroofOpen.Enabled = true;
            picSunroofOpen.BackColor = Control.DefaultBackColor;

            MessageBox.Show("Sunroof closed successfully!");
        }

        private void picSunroofOpen_Click(object sender, EventArgs e)
        {
            picSunroofOpen.Enabled = false;
            picSunroofOpen.BackColor = Color.Gray;

            picSunroofClose.Enabled = true;
            picSunroofClose.BackColor = Control.DefaultBackColor;

            MessageBox.Show("Sunroof opened successfully!");
        }

        private void picAlarmOff_Click(object sender, EventArgs e)
        {
            if (originalAlarmOffImage == null)
            {
                originalAlarmOffImage = new Bitmap(picAlarmOff.Image);
            }

            picAlarmOff.Enabled = false;
            ApplyGrayOverlay(picAlarmOff);

            picAlarmOn.Enabled = true;
            if (originalAlarmOnImage == null)
            {
                originalAlarmOnImage = new Bitmap(picAlarmOn.Image);
            }
            RemoveGrayOverlay(picAlarmOn, originalAlarmOnImage);

            MessageBox.Show("Alarm turned off successfully!");
        }

        private void picAlarmOn_Click(object sender, EventArgs e)
        {
            if (originalAlarmOnImage == null)
            {
                originalAlarmOnImage = new Bitmap(picAlarmOn.Image);
            }

            picAlarmOn.Enabled = false;
            ApplyGrayOverlay(picAlarmOn);

            picAlarmOff.Enabled = true;
            if (originalAlarmOffImage == null)
            {
                originalAlarmOffImage = new Bitmap(picAlarmOff.Image);
            }
            RemoveGrayOverlay(picAlarmOff, originalAlarmOffImage);

            MessageBox.Show("Alarm turned on successfully!");
        }


        private void Main_Load(object sender, EventArgs e)
        {
            DataManager.VehiclesUpdated += UpdateComboBox;
            UpdateComboBox();
            cmbVehicles.SelectedIndex = 0;
            DataManager.AnomalyDetected += HandleAnomaly;
        }
        public void UpdateComboBox()
        {
            cmbVehicles.DataSource = null;
            cmbVehicles.DataSource = DataManager.Vehicles;
        }
        private async void HandleAnomaly(string message)
        {
            var messageBoxForm = new Form
            {
                FormBorderStyle = FormBorderStyle.Fixed3D,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = System.Drawing.Color.White,
                Size = new System.Drawing.Size(800, 450),
                TopMost = true
            };
            var label = new Label
            {
                Text = message,
                Font = new System.Drawing.Font("Cambria", 24, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Red,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            messageBoxForm.Controls.Add(label);
            messageBoxForm.Show();

            var colors = new[] { System.Drawing.Color.Red, System.Drawing.Color.Black };
            int colorIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                label.ForeColor = colors[colorIndex];
                colorIndex = (colorIndex + 1) % colors.Length;
                Console.Beep(1000, 500);
                await Task.Delay(1000);
            }


            messageBoxForm.Close();
            messageBoxForm.Dispose();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.AnomalyDetected -= HandleAnomaly;
            DataManager.VehiclesUpdated -= UpdateComboBox;
        }
    }
}
