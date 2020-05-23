using System;
using System.Drawing;
using System.Windows.Forms;

// Выполнил Виль В. В.
namespace GameWF
{
    public partial class GamePolygon : Form
    {
        bool leftmove = true;
        bool fire = false;

        public GamePolygon()
        {
            InitializeComponent();

            InitPlayerShip(Size.Width / 2, Size.Height - 90, 50, 25);
            InitEnemy1Ship(10, 20, 30, 55);
            InitEnemy2Ship(Size.Width, 95, 30, 55);
            InitCivilShip(Size.Width, 150, 30, 55);
            InitTorpeda();
        }
        #region Автоматически сгенерированные методы

        private void Civil1_OnResize()
        {
            civil.Top = civil1.Top;
            civil.Left = civil1.Left;
            civil.Height = civil1.Height;
            civil.Width = civil1.Width;
        }

        private void Civil1_OnHit()
        {
            enemyTimer.Enabled = false;
            enemy1.Visible = false;
            enemy2.Visible = false;
            civil.Visible = false;
            gameover.Visible = true;
            Text = "Pres ESC to Exit";
            MessageBox.Show("Вы убили гражданский корабль!!! \nДля выхода нажмите ESC");
        }

        private void Military2_OnHit()
        {
            //military2.SetRectangle(Size.Width, 95, 30, 55);
            military2.Left = Size.Width;
            score.Text = (int.Parse(score.Text) + 1).ToString();
        }

        private void Military1_OnHit()
        {
            //military1.SetRectangle(10, 20, 30, 55);
            military1.Left = 10;
            score.Text = (int.Parse(score.Text) + 2).ToString();
        }

        private void Military2_OnResize()
        {
            enemy2.Top = military2.Top;
            enemy2.Left = military2.Left;
            enemy2.Height = military2.Height;
            enemy2.Width = military2.Width;
        }

        private void Military1_OnResize()
        {
            enemy1.Top = military1.Top;
            enemy1.Left = military1.Left;
            enemy1.Height = military1.Height;
            enemy1.Width = military1.Width;
        }

        private void playerShip_OnResize()
        {
            shipPlayer.Top = playerShip.Top;
            shipPlayer.Left = playerShip.Left;
            shipPlayer.Height = playerShip.Height;
            shipPlayer.Width = playerShip.Width;
        }

        private void GamePolygon_Resize(object sender, EventArgs e)
        {
            playerShip.Top = Size.Height - 90;
        }

        private void GamePolygon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                playerShip.Left += playerShip.Width / 2;
            else if (e.KeyCode == Keys.Left)
                playerShip.Left -= playerShip.Width / 2;
            else if ((e.KeyCode == Keys.Space) && !fire && enemyTimer.Enabled)
                OnFire();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void Torpeda_OnHit()
        {
            fire = false;
            torpeda.Top = Size.Height;
            torp.Visible = false;
        }

        private void Torpeda_OnResize()
        {
            torp.Top = torpeda.Top;
            torp.Left = torpeda.Left;
            torp.Height = torpeda.Height;
            torp.Width = torpeda.Width;
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {

            M1Move(10);
            M2Move(5);
            CivilMove(7);
            TorpedaMove(10);

            military1.IsIntersection(torpeda);
            military2.IsIntersection(torpeda);
            civil1.IsIntersection(torpeda);
        }
        #endregion

        #region Методы написанные мной
        private void InitPlayerShip(int Left, int Top, int Height, int Width)
        {
            playerShip = new BatleShip();
            shipPlayer.Text = "";
            shipPlayer.BackColor = Color.White;
            playerShip.OnResize += playerShip_OnResize;
            playerShip.SetRectangle(Left, Top, Height, Width);
        }

        private void InitEnemy1Ship(int Left, int Top, int Height, int Width)
        {
            military1 = new BatleShip();
            military1.OnResize += Military1_OnResize;
            military1.OnHit += Military1_OnHit;
            military1.SetRectangle(Left, Top, Height, Width);
        }

        private void InitEnemy2Ship(int Left, int Top, int Height, int Width)
        {
            military2 = new BatleShip();
            military2.OnResize += Military2_OnResize;
            military2.OnHit += Military2_OnHit;
            military2.SetRectangle(Left, Top, Height, Width);
        }

        private void InitCivilShip(int Left, int Top, int Height, int Width)
        {
            civil1 = new BatleShip();
            civil1.OnHit += Civil1_OnHit;
            civil1.OnResize += Civil1_OnResize;
            civil1.SetRectangle(Left, Top, Height, Width);
        }

        private void InitTorpeda()
        {
            torpeda = new BatleShip();
            torp.Enabled = false;
            torpeda.OnResize += Torpeda_OnResize;
            torpeda.OnHit += Torpeda_OnHit;
        }

        private void M1Move(int step)
        {
            military1.Left += step;
            if (military1.Left >= Size.Width)
                military1.Left = 0 - military1.Width;
        }

        private void M2Move(int step)
        {
            military2.Left -= step;
            if (military2.Left <= -military2.Width)
                military2.Left = Size.Width;
        }

        private void CivilMove(int step)
        {
            if (leftmove)
                civil1.Left += step;
            else
                civil1.Left -= step;
            if (civil1.Left >= Size.Width - civil1.Width)
                leftmove = false;
            else if (civil1.Left <= 0)
                leftmove = true;
        }

        private void TorpedaMove(int step)
        {
            if (fire)
            {
                torpeda.Top -= step;
                if (torpeda.Top <= 0)
                    Torpeda_OnHit();
            }
        }

        private void OnFire()
        {
            torpeda.SetRectangle(playerShip.Left + playerShip.Width / 2 - 10, playerShip.Top, 20, 10);
            torp.Visible = true;
            fire = true;
        }
        #endregion
    }
}
