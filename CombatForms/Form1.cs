using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZUtilities;
using ZUtilities.FSM;
using ZUtilities.FSM.Combat;

namespace CombatForms
{
    public partial class Form1 : Form
    {
        CombatMachine Game = new CombatMachine();
        PlayerChooseState PlayerChoose;
        EnemyChooseState EnemyChoose;
        FieldFlipState FieldFlip;
        InitState Init;

        Player player = new Player("Player1", 1);
        Player enemy = new Player("Enemy", 2);

        public Form1()
        {
            InitializeComponent();
            Init = new InitState(Field1, Field2, Field3, Field4, Hand1, Hand2, Hand3, Hand4, NextButton, player, enemy);
            PlayerChoose = new PlayerChooseState(Field1, Field2, Field3, Field4, Hand1, Hand2, Hand3, Hand4, NextButton, Game.Field, player, enemy);
            EnemyChoose = new EnemyChooseState(Field3, Field4, player, enemy, Game.Field);
            FieldFlip = new FieldFlipState(Field3, Field4, player, enemy, PlayerHealth, PlayerSpeed, EnemyHealth, EnemySpeed, NextButton, Game.Field);
            Game.AddState(Init);
            Game.AddState(PlayerChoose);
            Game.AddState(EnemyChoose);
            Game.AddState(FieldFlip);
            Game.CurrentState.StateInit();
            LogBox.Text += "=Game Start=\nClick 'Next' to play.";
            CurrentState.Text = "Current State:\n" + Game.CurrentState.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Game.CurrentState.NextHit();
            Game.NextState();
            Game.CurrentState.StateInit();
            PhaseCounter.Text = "Phase: " + Game.Phase;
            CurrentState.Text = "Current State:\n" + Game.CurrentState.ToString();
            LogBox.Text += Game.CurrentState.Desc;
            LogBox.SelectionStart = LogBox.Text.Length;
            LogBox.ScrollToCaret();
        }

        private void Hand1_Click(object sender, EventArgs e)
        {
            Game.CurrentState.Hand1Hit();
        }

        private void Hand2_Click(object sender, EventArgs e)
        {
            Game.CurrentState.Hand2Hit();
        }

        private void Hand3_Click(object sender, EventArgs e)
        {
            Game.CurrentState.Hand3Hit();
        }

        private void Hand4_Click(object sender, EventArgs e)
        {
            Game.CurrentState.Hand4Hit();
        }
    }
}
