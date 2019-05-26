namespace FirstWinApp
{
    partial class ManyExampleForm
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
            this.richTextBoxShowDisplay = new System.Windows.Forms.RichTextBox();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowDisplay = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxShowDisplay
            // 
            this.richTextBoxShowDisplay.Location = new System.Drawing.Point(34, 128);
            this.richTextBoxShowDisplay.Name = "richTextBoxShowDisplay";
            this.richTextBoxShowDisplay.Size = new System.Drawing.Size(330, 298);
            this.richTextBoxShowDisplay.TabIndex = 0;
            this.richTextBoxShowDisplay.Text = "";
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Location = new System.Drawing.Point(34, 29);
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(330, 29);
            this.textBoxInputData.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(462, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 48);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowDisplay
            // 
            this.buttonShowDisplay.Location = new System.Drawing.Point(462, 88);
            this.buttonShowDisplay.Name = "buttonShowDisplay";
            this.buttonShowDisplay.Size = new System.Drawing.Size(139, 48);
            this.buttonShowDisplay.TabIndex = 2;
            this.buttonShowDisplay.Text = "Show Display";
            this.buttonShowDisplay.UseVisualStyleBackColor = true;
            this.buttonShowDisplay.Click += new System.EventHandler(this.buttonShowDisplay_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(34, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(330, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // ManyExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 465);
            this.Controls.Add(this.buttonShowDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxInputData);
            this.Controls.Add(this.richTextBoxShowDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManyExampleForm";
            this.Text = "Many Example Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxShowDisplay;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowDisplay;
        private System.Windows.Forms.TextBox textBoxName;
    }
}