using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarGamee
{
    public partial class Form1 : Form
    {
        // ROAD
        private System.Windows.Forms.Timer timerRoad = null!;
        private Image roadImage = null!;
        private int roadWidth;
        private int roadHeight;
        private float roadY;

        public Form1()
        {
            InitializeComponent();
            InitilizeGame();
        }

        private void InitilizeGame()
        {
            InitilizeWindow();
            RegisterEvets();
            InitializeRoad();
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

        private void InitializeRoad()
        {
            string projectPath = Directory.GetParent(
                Application.StartupPath
            )!.Parent!.Parent!.Parent!.FullName;

            string roadPath = Path.Combine(
                projectPath,
                "Resources",
                "road.png"
            );

            roadImage = Image.FromFile(roadPath);

            roadWidth = ClientSize.Width;
            roadHeight = ClientSize.Height;

            timerRoad = new System.Windows.Forms.Timer();
            timerRoad.Interval = 30;
            timerRoad.Tick += TimerRoad_Tick;
            timerRoad.Start();
        }

        private void RegisterEvets()
        {
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            KeyUp += Form1_KeyUp;
            KeyDown += Form1_KeyDown;
        }

        private void TimerRoad_Tick(object? sender, EventArgs e)
        {
            roadY += 5;

            if (roadY >= roadHeight)
                roadY -= roadHeight;

            if (roadY < 0)
                roadY += roadHeight;

            Invalidate();
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
            DrawRoad(e.Graphics);
        }

        private void DrawRoad(Graphics g)
        {
            g.DrawImage(
                roadImage,
                0,
                roadY,
                roadWidth,
                roadHeight
            );

            g.DrawImage(
                roadImage,
                0,
                roadY - roadHeight,
                roadWidth,
                roadHeight
            );
        }
    }
}