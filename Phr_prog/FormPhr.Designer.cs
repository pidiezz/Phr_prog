namespace Phr_prog
{
    partial class FormPhr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPhorm = new System.Windows.Forms.ComboBox();
            this.labelPhorm = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phorm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDose = new System.Windows.Forms.Label();
            this.textBoxProz = new System.Windows.Forms.TextBox();
            this.labelProz = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPhorm
            // 
            this.comboBoxPhorm.FormattingEnabled = true;
            this.comboBoxPhorm.Items.AddRange(new object[] {
            "таблетки",
            "капсулы",
            "ампулы",
            "сироп",
            "крем"});
            this.comboBoxPhorm.Location = new System.Drawing.Point(45, 206);
            this.comboBoxPhorm.Name = "comboBoxPhorm";
            this.comboBoxPhorm.Size = new System.Drawing.Size(343, 24);
            this.comboBoxPhorm.TabIndex = 48;
            // 
            // labelPhorm
            // 
            this.labelPhorm.AutoSize = true;
            this.labelPhorm.Location = new System.Drawing.Point(42, 186);
            this.labelPhorm.Name = "labelPhorm";
            this.labelPhorm.Size = new System.Drawing.Size(112, 17);
            this.labelPhorm.TabIndex = 47;
            this.labelPhorm.Text = "Форма выпуска";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1080, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 59);
            this.buttonExit.TabIndex = 46;
            this.buttonExit.Text = "Выход из системы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(947, 457);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(247, 59);
            this.buttonDel.TabIndex = 44;
            this.buttonDel.Text = "Удалить ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(507, 457);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(254, 59);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(85, 457);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(247, 59);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Создать ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(42, 252);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(0, 17);
            this.labelPhone.TabIndex = 41;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 114);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 17);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Название";
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(45, 272);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(343, 22);
            this.textBoxDosage.TabIndex = 39;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(45, 134);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(343, 22);
            this.textBoxName.TabIndex = 38;
            // 
            // listViewDrugs
            // 
            this.listViewDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Name,
            this.Phorm,
            this.Dosage,
            this.Proz,
            this.Time});
            this.listViewDrugs.FullRowSelect = true;
            this.listViewDrugs.GridLines = true;
            this.listViewDrugs.HideSelection = false;
            this.listViewDrugs.Location = new System.Drawing.Point(418, 22);
            this.listViewDrugs.MultiSelect = false;
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(642, 419);
            this.listViewDrugs.TabIndex = 37;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            this.listViewDrugs.SelectedIndexChanged += new System.EventHandler(this.listViewDrugs_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // Name
            // 
            this.Name.Text = "FormPhr";
            this.Name.Width = 90;
            // 
            // Phorm
            // 
            this.Phorm.Text = "Форма выпуска";
            this.Phorm.Width = 140;
            // 
            // Dosage
            // 
            this.Dosage.Text = "Дозировка";
            this.Dosage.Width = 90;
            // 
            // Proz
            // 
            this.Proz.Text = "Производитель";
            this.Proz.Width = 120;
            // 
            // Time
            // 
            this.Time.Text = "Срок годности";
            this.Time.Width = 140;
            // 
            // labelDose
            // 
            this.labelDose.AutoSize = true;
            this.labelDose.Location = new System.Drawing.Point(42, 252);
            this.labelDose.Name = "labelDose";
            this.labelDose.Size = new System.Drawing.Size(80, 17);
            this.labelDose.TabIndex = 49;
            this.labelDose.Text = "Дозировка";
            // 
            // textBoxProz
            // 
            this.textBoxProz.Location = new System.Drawing.Point(45, 337);
            this.textBoxProz.Name = "textBoxProz";
            this.textBoxProz.Size = new System.Drawing.Size(343, 22);
            this.textBoxProz.TabIndex = 50;
            // 
            // labelProz
            // 
            this.labelProz.AutoSize = true;
            this.labelProz.Location = new System.Drawing.Point(42, 317);
            this.labelProz.Name = "labelProz";
            this.labelProz.Size = new System.Drawing.Size(110, 17);
            this.labelProz.TabIndex = 51;
            this.labelProz.Text = "Производитель";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(45, 402);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(343, 22);
            this.textBoxTime.TabIndex = 52;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(42, 382);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(103, 17);
            this.labelTime.TabIndex = 53;
            this.labelTime.Text = "Срок годности";
            // 
            // FormPhr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 535);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelProz);
            this.Controls.Add(this.textBoxProz);
            this.Controls.Add(this.labelDose);
            this.Controls.Add(this.comboBoxPhorm);
            this.Controls.Add(this.labelPhorm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewDrugs);
            this.Name.Text = "FormPhr";
            this.Text = "Каталог";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPhorm;
        private System.Windows.Forms.Label labelPhorm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Phorm;
        private System.Windows.Forms.ColumnHeader Dosage;
        private System.Windows.Forms.ColumnHeader Proz;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label labelDose;
        private System.Windows.Forms.TextBox textBoxProz;
        private System.Windows.Forms.Label labelProz;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
    }
}