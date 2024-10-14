using System;
using System.Diagnostics;
using Project_Lottery.BusinessLogic;
using Timer = System.Windows.Forms.Timer;

namespace Project_Lottery
{
    public partial class MainForm : Form
    {
        private int preparationTime = 30; 
        private int dayDuration = 60; 
        private bool isDayRunning = false;
        private Timer preparationTimer; 
        private Timer dayTimer; 
        private GameManager gameManager;
        private List<string> eventLog = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Player player = new Player();
            gameManager = new GameManager(player);
            StartPreparationPhase();
        }

        private void StartPreparationPhase()
        {
            lblPreparationTime.Visible = true;
            btnEndDayEarly.Visible = false;
            lblDayTime.Visible = false;
            preparationTimer = new Timer();
            preparationTimer.Interval = 1000;
            preparationTimer.Tick += PreparationTimer_Tick;
            preparationTimer.Start();
            lblPreparationTime.Text = $"Preparation Time: {preparationTime}s";
            AddEventToLog("Preparation phase started.");
        }

        private void PreparationTimer_Tick(object sender, EventArgs e)
        {
            preparationTime--;
            lblPreparationTime.Text = $"Preparation Time: {preparationTime}s";
            AddEventToLog($"Preparation Time: {preparationTime}s");

            if (preparationTime <= 0)
            {
                preparationTimer.Stop();
                StartDay();
            }
        }

        private void StartDay()
        {
            isDayRunning = true;
            lblDayTime.Visible = true;
            lblPreparationTime.Visible = false;
            btnEndDayEarly.Visible = true;
            dayTimer = new Timer();
            dayTimer.Interval = 1000;
            dayTimer.Tick += DayTimer_Tick;
            dayTimer.Start();
            lblDayTime.Text = $"Time remaining: {dayDuration}s";
            AddEventToLog("Sales day started.");
        }

        private void DayTimer_Tick(object sender, EventArgs e)
        {
            dayDuration--;
            lblDayTime.Text = $"Time remaining: {dayDuration}s";

            gameManager.SimulateTicketSales();

            if (dayDuration <= 0)
            {
                EndDay();
            }
        }

        private void btnEndDayEarly_Click(object sender, EventArgs e)
        {
            EndDay();
        }

        private void EndDay()
        {
            isDayRunning = false;
            dayTimer.Stop();
            lblDayTime.Text = $"Time remaining: 0s";
            AddEventToLog("Sales day ended.");
            ShowDaySummary();
        }

        private void ShowDaySummary()
        {
            DaySummaryForm summaryForm = new DaySummaryForm();
            summaryForm.ShowSummary(gameManager.GetDaySummary());
            summaryForm.ShowDialog();

            ResetDay();
        }

        private void ResetDay()
        {
            preparationTime = 30;
            dayDuration = 60;
            AddEventToLog("New day!");
            StartPreparationPhase();
        }

        private void btnBuyTickets_Click(object sender, EventArgs e)
        {

        }

        private void btnSetPrices_Click(object sender, EventArgs e)
        {

        }

        private void AddEventToLog(string eventMessage)
        {
            if (eventLog.Count >= 3)
            {
                eventLog.RemoveAt(0);
            }

            eventLog.Add(eventMessage);
            lstEvents.Items.Clear();
            foreach (string log in eventLog)
            {
                lstEvents.Items.Add(log);
            }
        }
    }
}
