namespace Yapılacaklar_Uygulaması__To_Do_List__APP_
{
    partial class EditTaskForm
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
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.chkEditIsDone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Location = new System.Drawing.Point(60, 60);
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(100, 20);
            this.txtEditDescription.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(191, 60);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Güncelle";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // chkEditIsDone
            // 
            this.chkEditIsDone.AutoSize = true;
            this.chkEditIsDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEditIsDone.Location = new System.Drawing.Point(186, 89);
            this.chkEditIsDone.Name = "chkEditIsDone";
            this.chkEditIsDone.Size = new System.Drawing.Size(83, 17);
            this.chkEditIsDone.TabIndex = 3;
            this.chkEditIsDone.Text = "Tamamlandı";
            this.chkEditIsDone.UseVisualStyleBackColor = true;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(312, 155);
            this.Controls.Add(this.chkEditIsDone);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtEditDescription);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.CheckBox chkEditIsDone;
    }
}