partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnStartBuilding;
    private System.Windows.Forms.Button btnNextStep;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.RadioButton radioPassenger;
    private System.Windows.Forms.RadioButton radioCargo;
    private System.Windows.Forms.TextBox txtOutput;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnStartBuilding = new System.Windows.Forms.Button();
        this.btnNextStep = new System.Windows.Forms.Button();
        this.btnReset = new System.Windows.Forms.Button();
        this.radioPassenger = new System.Windows.Forms.RadioButton();
        this.radioCargo = new System.Windows.Forms.RadioButton();
        this.txtOutput = new System.Windows.Forms.TextBox();

        // Кнопка початку побудови
        this.btnStartBuilding.Location = new System.Drawing.Point(30, 30);
        this.btnStartBuilding.Name = "btnStartBuilding";
        this.btnStartBuilding.Size = new System.Drawing.Size(150, 30);
        this.btnStartBuilding.Text = "Почати будівництво";
        this.btnStartBuilding.Click += new System.EventHandler(this.btnStartBuilding_Click);

        // Кнопка наступного кроку
        this.btnNextStep.Location = new System.Drawing.Point(30, 70);
        this.btnNextStep.Name = "btnNextStep";
        this.btnNextStep.Size = new System.Drawing.Size(150, 30);
        this.btnNextStep.Text = "Наступний крок";
        this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);

        // Кнопка скидання
        this.btnReset.Location = new System.Drawing.Point(30, 110);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(150, 30);
        this.btnReset.Text = "Скинути";
        this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

        // Вибір пасажирського літака
        this.radioPassenger.Location = new System.Drawing.Point(200, 30);
        this.radioPassenger.Name = "radioPassenger";
        this.radioPassenger.Size = new System.Drawing.Size(150, 20);
        this.radioPassenger.Text = "Пасажирський літак";

        // Вибір вантажного літака
        this.radioCargo.Location = new System.Drawing.Point(200, 60);
        this.radioCargo.Name = "radioCargo";
        this.radioCargo.Size = new System.Drawing.Size(150, 20);
        this.radioCargo.Text = "Вантажний літак";

        // Поле для виводу
        this.txtOutput.Location = new System.Drawing.Point(30, 150);
        this.txtOutput.Multiline = true;
        this.txtOutput.Size = new System.Drawing.Size(300, 200);
        this.txtOutput.ReadOnly = true;

        // Головна форма
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Controls.Add(this.btnStartBuilding);
        this.Controls.Add(this.btnNextStep);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.radioPassenger);
        this.Controls.Add(this.radioCargo);
        this.Controls.Add(this.txtOutput);
        this.Name = "MainForm";
        this.Text = "Airplane Builder";

        
        
    }

}
