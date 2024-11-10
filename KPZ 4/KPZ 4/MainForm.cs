using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private IAirplaneBuilder builder;
    private AirplaneDirector director;

    public MainForm()
    {
        InitializeComponent();
    }

    // Почати створення літака
    private void btnStartBuilding_Click(object sender, EventArgs e)
    {
        if (radioPassenger.Checked)
        {
            builder = new PassengerAirplaneBuilder();
        }
        else if (radioCargo.Checked)
        {
            builder = new CargoAirplaneBuilder();
        }
        else
        {
            MessageBox.Show("Виберіть тип літака.");
            return;
        }

        director = new AirplaneDirector(builder);
        txtOutput.Clear();
        txtOutput.Text = "Початок побудови літака...\r\n";
        btnNextStep.Enabled = true;  // Дозволяємо натискати "Наступний крок"
    }

    // Виконати наступний крок побудови
    private void btnNextStep_Click(object sender, EventArgs e)
    {
        if (builder == null || director == null)
        {
            MessageBox.Show("Спочатку оберіть тип літака та почніть будівництво.");
            return;
        }

        if (director.PerformNextStep())
        {
            txtOutput.AppendText("Крок виконано.\r\n");
            txtOutput.AppendText(director.GetCurrentState() + "\r\n");
        }
        else
        {
            txtOutput.AppendText("Побудова завершена!\r\n");
            txtOutput.AppendText(director.GetAirplane().ToString());
            btnNextStep.Enabled = false;  // Вимикаємо кнопку після завершення
        }
    }

    // Скидання для нового побудови
    private void btnReset_Click(object sender, EventArgs e)
    {
        builder = null;
        director = null;
        txtOutput.Clear();
        btnNextStep.Enabled = false;  // Вимикаємо кнопку "Наступний крок" до нового старту
    }
}
