using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemendid_vormis_TARpv23
{
    public partial class matching_game : Form
    {
        Random random = new Random();

        Label firstClicked = null;

        Label secondClicked = null;

        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };
        private int timeLeft = 10;
        private int moveCount = 0;
        public matching_game(int w, int h)
        {
            InitializeComponent();
            this.Width = w;
            this.Height = h;
            AssignIconsToSquares();
            timeLabel.Text = $"Time left: {timeLeft}";
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }
            }
        }

        private void matching_game_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                moveCount++;
                UpdateMoveCounterLabel();

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;


            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();

        }

        private void UpdateMoveCounterLabel()
        {
            moveCounterLabel.Text = $"Moves: {moveCount}";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Уменьшаем время на 1 секунду
                timeLeft--;

                // Обновляем текст метки с оставшимся временем
                timeLabel.Text = $"Осталось времени: {timeLeft} сек";
            }
            else
            {
                // Время истекло, останавливаем таймер
                timer2.Stop();

                // Показываем сообщение о проигрыше
                MessageBox.Show("Время истекло! Вы проиграли.", "Конец игры");

                // Закрываем игру
                Close();
            }
        }
    }
}
