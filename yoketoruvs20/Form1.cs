using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "🔶";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {
            None = -1,  //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear       //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0; i< ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = templabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if(currentState == State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            //　TODO: mpがプレイヤーの中心になるように設定
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height;

          for(int i=EnemyIndex; i<ChrMax;i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if(chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Left > 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top > 0)
                {
                    vy[i] = Math.Abs(vx[i]);
                }
            }


        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyRightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameoverLabel.Visible = false;
                    titleButton.Visible = false;
                    clearLabel.Visible = false;
                   
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyRightLabel.Visible = false;
                    hiLabel.Visible = false;
                    

                    for(int i=EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        //vx[i].rand.Next(-SpeedMax);
                        //vy[i].rand.Next(-SpeedMax);

                    }
                    break;

                case State.Gameover:
                    gameoverLabel.Visible = true;
                    titleLabel.Visible = false;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleLabel.Visible = false;
                    hiLabel.Visible = true;
                    titleButton.Visible = true;
                    break;
            }

        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
