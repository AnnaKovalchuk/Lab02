
namespace Lab01
{
    partial class FormLab
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRender = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonColour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelThickness = new System.Windows.Forms.Label();
            this.labelFigure = new System.Windows.Forms.Label();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonRender);
            this.panelMenu.Controls.Add(this.listBox1);
            this.panelMenu.Controls.Add(this.buttonColour);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.trackBarRadius);
            this.panelMenu.Controls.Add(this.trackBarThickness);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.labelThickness);
            this.panelMenu.Controls.Add(this.labelFigure);
            this.panelMenu.Controls.Add(this.comboBoxFigure);
            this.panelMenu.Controls.Add(this.buttonDelete);
            this.panelMenu.Controls.Add(this.buttonAdd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1004, 140);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(474, 56);
            this.buttonRender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(125, 28);
            this.buttonRender.TabIndex = 9;
            this.buttonRender.Text = "Нарисовать";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(607, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 68);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonColour
            // 
            this.buttonColour.BackColor = System.Drawing.Color.Black;
            this.buttonColour.Location = new System.Drawing.Point(16, 36);
            this.buttonColour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonColour.Name = "buttonColour";
            this.buttonColour.Size = new System.Drawing.Size(79, 69);
            this.buttonColour.TabIndex = 7;
            this.buttonColour.UseVisualStyleBackColor = false;
            this.buttonColour.Click += new System.EventHandler(this.buttonColour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "(колёсико)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Перекрасить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "(ctrl + колёсико)";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(828, 37);
            this.trackBarRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarRadius.Maximum = 1000;
            this.trackBarRadius.Minimum = 50;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(139, 56);
            this.trackBarRadius.TabIndex = 5;
            this.trackBarRadius.Value = 50;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBarRadius_Scroll);
            this.trackBarRadius.ValueChanged += new System.EventHandler(this.trackBarRadius_ValueChanged);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(116, 37);
            this.trackBarThickness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarThickness.Maximum = 20;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(205, 56);
            this.trackBarThickness.TabIndex = 4;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll);
            this.trackBarThickness.ValueChanged += new System.EventHandler(this.trackBarThickness_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор радиуса";
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(153, 17);
            this.labelThickness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(115, 17);
            this.labelThickness.TabIndex = 2;
            this.labelThickness.Text = "Выбор толшины";
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(323, 22);
            this.labelFigure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(108, 17);
            this.labelFigure.TabIndex = 2;
            this.labelFigure.Text = "Выбор фигуры:";
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Треугольник"});
            this.comboBoxFigure.Location = new System.Drawing.Point(439, 17);
            this.comboBoxFigure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFigure.TabIndex = 1;
            this.comboBoxFigure.Text = "Круг";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(715, 16);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(607, 16);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.BackColor = System.Drawing.Color.White;
            this.pictureBoxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDraw.Location = new System.Drawing.Point(0, 140);
            this.pictureBoxDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(1004, 414);
            this.pictureBoxDraw.TabIndex = 1;
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // FormLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 554);
            this.Controls.Add(this.pictureBoxDraw);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLab";
            this.Text = "Lab 02 Kovalchuk";
            this.Load += new System.EventHandler(this.FormLab_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRender;
    }
}

