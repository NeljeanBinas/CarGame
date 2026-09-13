using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarGamee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitilizeGame();
        }

        private void InitilizeGame()
        {
            InitilizeWindow();
            RegisterEvets();
        }

        private void InitilizeWindow()
        {
            ClientSize = new Size(420, 640);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void RegisterEvets()
        {
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            KeyUp += Form1_KeyUp;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
        }
    }
}