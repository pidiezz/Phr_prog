namespace Phr_prog
{
    partial class FormClient
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phorm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(847, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 59);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.Text = "Выход из системы";
            this.buttonExit.UseVisualStyleBackColor = true;
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
            this.listViewDrugs.Location = new System.Drawing.Point(179, 12);
            this.listViewDrugs.MultiSelect = false;
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(642, 567);
            this.listViewDrugs.TabIndex = 47;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // Name
            // 
            this.Name.Text = "Название";
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listViewDrugs);
       
            this.Text = "FormClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Phorm;
        private System.Windows.Forms.ColumnHeader Dosage;
        private System.Windows.Forms.ColumnHeader Proz;
        private System.Windows.Forms.ColumnHeader Time;
    }
}