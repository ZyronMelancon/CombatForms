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
        
        PlayerChooseState StateThing = new PlayerChooseState();
        Player player = new Player("Player1");
        Player enemy = new Player("Enemy");

        public Form1()
        {
            InitializeComponent();
            InitState Init = new InitState(Field1, Field2, Field3, Field4, Hand1, Hand2, Hand3, Hand4, NextButton, player, enemy);
            Game.AddState(Init);
            Game.AddState(StateThing);
            Hand1.Click += changestate;
            
        }
        void changestate(object o, EventArgs e)
        {

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Game.NextState();
            Game.CurrentState.StateInit();
            PhaseCounter.Text = "Phase: " + Game.Phase;
            CurrentState.Text = "Current State:\n" + Game.CurrentState.ToString();
        }
    }
}
