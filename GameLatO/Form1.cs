using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameLatO
{
    public partial class Form1 : Form
    {
        double time;
        DateTime start;
        DateTime endTime;
        TimeSpan remainingTime;
        int remainPairs;

        public Form1()
        {
            InitializeComponent();

            var levels = new[]
            {
                new { Text = "Easy ( 2 minutes )", Value = 2.0},
                new { Text = "Medium ( 1,5 minutes )", Value = 1.5},
                new { Text = "Hard ( 1 minutes )", Value = 1.0}
            };

            cbLevels.DisplayMember = "Text";
            cbLevels.ValueMember = "Value";
            cbLevels.DataSource = levels;
            time = (double)cbLevels.SelectedValue;

            lbNotification.Text = "";
            panelCountdown.Location = new Point(
                (Width - panelCountdown.Width) / 2,
                panelCountdown.Location.Y
            );
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Enabled = true;
            lbNotification.Text = "";

            int row = (int)numUpDownRow.Value;
            int column = (int)numcUpDownColumn.Value;

            if (row * column % 2 != 0)
            {
                timerCountdown.Enabled = false;
                string str = "The total number of cells ( Col x Row ) must be an EVEN NUMBER !!";
                MessageBox.Show(str, "Notification");
                return;
            }

            // reset thời gian đếm ngược
            start = DateTime.UtcNow;
            endTime = start.AddMinutes(time);
            remainingTime = endTime - DateTime.UtcNow;
            lbTimeRemaining.Text = remainingTime.ToString(@"mm\:ss");
            timerCountdown.Enabled = true;

            // Số cặp còn lại sau khi mở
            remainPairs = (row * column) / 2;

            int btnSize = CalculateButtonSize(row, column);
            // List chứa các button
            List<CustomButton> listButtons = GenerateButtons(row, column, btnSize);
            PutButtonsToGrid(row, column, btnSize, listButtons);

            // Căn chỉnh thời gian chính giữa
            panelCountdown.Location = new Point(
                (Width - panelCountdown.Width) / 2,
                panelCountdown.Location.Y
            );
        }

        CustomButton btnOpenedFirst = null;
        CustomButton btnOpenedSecond = null;

        private void BtnCell_Click(object sender, EventArgs e)
        {
            CustomButton btn = (CustomButton)sender;
            btn.BackgroundImage = (Image)btn.Tag;

            if (btnOpenedFirst == null)
            {
                btnOpenedFirst = btn;
            }
            else
            {
                // Kiểm tra có click vào cùng 1 button không?
                if (btnOpenedFirst.Name != btn.Name)
                {
                    btnOpenedSecond = btn;
                    timerForCells.Enabled = true;
                }
            }
        }

        private void timerForCells_Tick(object sender, EventArgs e)
        {
            if (btnOpenedFirst.CoupleIndex != btnOpenedSecond.CoupleIndex)
            {
                btnOpenedFirst.BackgroundImage = null;
                btnOpenedSecond.BackgroundImage = null;
            }
            else
            {
                //panel1.Controls.Remove(btnOpenedFirst);
                //panel1.Controls.Remove(btnOpenedSecond);
                btnOpenedFirst.Enabled = false;
                btnOpenedSecond.Enabled = false;
                remainPairs--;
            }

            btnOpenedFirst = null;
            timerForCells.Enabled = false;
        }

        public int random(int val)
        {
            return (new Random()).Next(val);
        }

        private int CalculateButtonSize(int row, int column)
        {
            int btnSizeByRow = (int)Math.Floor((double)(panel3.Height - (row - 1) * 5) / row);
            int btnSizeByColumn = (int)Math.Floor((double)(panel3.Width - (column - 1) * 5) / column);
            return Math.Min(btnSizeByRow, btnSizeByColumn);
        }

        private List<CustomButton> GenerateButtons(int row, int column, int btnSize)
        {
            // List chứa các button
            List<CustomButton> listButtons = new List<CustomButton>();

            // Thêm 1 cặp button giống nhau vào listButtons
            for (int i = 0; i < (row * column / 2); i++)
            {
                CustomButton btn1 = new CustomButton();
                btn1.Name = (i * 2 - 1).ToString();
                btn1.Size = new Size(btnSize, btnSize);
                btn1.Tag = imageList1.Images[i % 16];
                btn1.BackgroundImageLayout = ImageLayout.Stretch;
                btn1.CoupleIndex = i;
                btn1.Click += BtnCell_Click;
                listButtons.Add(btn1);

                CustomButton btn2 = new CustomButton();
                btn2.Name = (i * 2).ToString();
                btn2.Size = new Size(btnSize, btnSize);
                btn2.Tag = imageList1.Images[i % 16];
                btn2.BackgroundImageLayout = ImageLayout.Stretch;
                btn2.CoupleIndex = i;
                btn2.Click += BtnCell_Click;
                listButtons.Add(btn2);
            }

            return listButtons;
        }

        private void PutButtonsToGrid(int row, int column, int btnSize, List<CustomButton> listButtons)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int index = random(listButtons.Count);
                    listButtons[index].Location = new Point((btnSize + 5) * j, (btnSize + 5) * i);
                    panel1.Controls.Add(listButtons[index]);
                    listButtons.RemoveAt(index);
                }
            }

            // Căn chỉnh các ô nằm chính giữa
            int sizeTemp = listButtons.Count * (btnSize + 5);
            panel1.Size = new Size(sizeTemp, sizeTemp);
            panel1.Location = new Point(
                (panel3.Width - panel1.Width) / 2,
                (panel3.Height - panel1.Height) / 2
            );
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian còn lại (được hiển thị)
            remainingTime = endTime - DateTime.UtcNow;
            lbTimeRemaining.Text = remainingTime.ToString(@"mm\:ss");

            // Số cặp còn lại = 0
            if (remainPairs == 0)
            {
                timerCountdown.Enabled = false;
                //MessageBox.Show("You Win!!");
                lbNotification.Text = "You Win!!";
            }
            else if (remainingTime < TimeSpan.Zero)
            {
                timerCountdown.Enabled = false;
                panel1.Enabled = false;
                //MessageBox.Show("Game Over!!");
                lbNotification.Text = "Game Over!!";
            }
        }

        private void cbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = (double)cbLevels.SelectedValue;
            timerCountdown.Enabled = false;
            lbTimeRemaining.Text = "00:00";
            panel1.Controls.Clear();
        }
    }
}