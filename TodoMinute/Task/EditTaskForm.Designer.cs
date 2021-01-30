
namespace TodoMinute.Task
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descRTB = new System.Windows.Forms.RichTextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "titre";
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTB.Location = new System.Drawing.Point(58, 17);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(257, 26);
            this.titleTB.TabIndex = 1;
            this.titleTB.Text = "Tâche sans titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "description";
            // 
            // descRTB
            // 
            this.descRTB.AcceptsTab = true;
            this.descRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descRTB.Font = new System.Drawing.Font("Miriam CLM", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.descRTB.Location = new System.Drawing.Point(58, 82);
            this.descRTB.Name = "descRTB";
            this.descRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.descRTB.Size = new System.Drawing.Size(257, 96);
            this.descRTB.TabIndex = 3;
            this.descRTB.Text = "";
            this.descRTB.WordWrap = false;
            // 
            // saveBTN
            // 
            this.saveBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(17, 200);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(298, 40);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Confirmer";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 258);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.descRTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTaskForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Éditeur de tâches";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.EditTaskForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descRTB;
        private System.Windows.Forms.Button saveBTN;
    }
}