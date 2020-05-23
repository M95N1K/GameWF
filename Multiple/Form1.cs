using System;
using System.Windows.Forms;

//Задание 1
//  а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//  б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
//      Игрок должен получить это число за минимальное количество ходов.
//  в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
//Выполнил Виль В.В.

namespace Multiple
{
    public partial class MainForm : Form
    {
        MessageForm messageForm;
        public MainForm()
        {
            InitializeComponent();
            messageForm = new MessageForm();
            GameCore = new GameClass();
            GameCore.OnStart += GameCore_OnStart;
            GameCore.OnLoose += GameCore_OnLoose;
            GameCore.OnWin += GameCore_OnWin;
            GameCore.OnError += GameCore_OnError;
            GameCore.OnChenge += GameCore_OnChenge;
        }

        private void GameCore_OnChenge(object sender)
        {
            LabelCurrent.Text = string.Format("Текущее значение: {0}", GameCore.Current);
            LabelStep.Text = string.Format("Текущее количество действий: {0}", GameCore.Steps);
        }

        private void GameCore_OnError(string message)
        {
            MessageBox.Show(message);
        }

        private void GameCore_OnWin(object sender)
        {
            MessageBox.Show("Вы достикли цели!!!\nУРА!!! ПОБЕДА!!!");
        }

        private void GameCore_OnLoose(object sender)
        {
            MessageBox.Show("Количество шагов привысило максимальное значение!!!\nВы проиграли!!!");
        }

        private void GameCore_OnStart(object sender)
        {
            ButtonDouble.Enabled = ButtonPlus.Enabled = ButtonReset.Enabled = ButtonUndo.Enabled = true;
            ButtonStart.Enabled = false;
            messageForm.Targ = GameCore.Target;
            messageForm.Show();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GameCore.Start();
            LabelTarget.Text = string.Format("Целевое значение: {0}", GameCore.Target);
            LabelCurrent.Text = string.Format("Текущее значение: {0}", GameCore.Current);
            LabelStep.Text = string.Format("Текущее количество действий: {0}", GameCore.Steps);
            LabelMaxSteps.Text = string.Format("Максимальное количество действий: {0}", GameCore.MaxSteps);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            GameCore.PlusOne();
        }

        private void ButtonDouble_Click(object sender, EventArgs e)
        {
            GameCore.MultipднByTwo();
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            GameCore.Undo();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            GameCore.Reset();
        }
    }
}
