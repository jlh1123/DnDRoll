namespace DnDRollS
{
    partial class uxLoadCharacterScreen
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
            this.uxLoadCharacter = new System.Windows.Forms.Button();
            this.uxCreateNewCharacter = new System.Windows.Forms.Button();
            this.uxTextbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxLoadCharacter
            // 
            this.uxLoadCharacter.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoadCharacter.Location = new System.Drawing.Point(12, 53);
            this.uxLoadCharacter.Name = "uxLoadCharacter";
            this.uxLoadCharacter.Size = new System.Drawing.Size(317, 76);
            this.uxLoadCharacter.TabIndex = 1;
            this.uxLoadCharacter.Text = "Load Character Txt File";
            this.uxLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // uxCreateNewCharacter
            // 
            this.uxCreateNewCharacter.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateNewCharacter.Location = new System.Drawing.Point(335, 53);
            this.uxCreateNewCharacter.Name = "uxCreateNewCharacter";
            this.uxCreateNewCharacter.Size = new System.Drawing.Size(323, 76);
            this.uxCreateNewCharacter.TabIndex = 2;
            this.uxCreateNewCharacter.Text = "Create New Character Profile";
            this.uxCreateNewCharacter.UseVisualStyleBackColor = true;
            this.uxCreateNewCharacter.Click += new System.EventHandler(this.uxCreateNewCharacter_Click);
            // 
            // uxTextbox1
            // 
            this.uxTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxTextbox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextbox1.Location = new System.Drawing.Point(-4, 21);
            this.uxTextbox1.Name = "uxTextbox1";
            this.uxTextbox1.Size = new System.Drawing.Size(646, 17);
            this.uxTextbox1.TabIndex = 0;
            this.uxTextbox1.Text = "Please load your character\'s txt file or create a new character profile.\r\n";
            this.uxTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLoadCharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 144);
            this.Controls.Add(this.uxCreateNewCharacter);
            this.Controls.Add(this.uxLoadCharacter);
            this.Controls.Add(this.uxTextbox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uxLoadCharacterScreen";
            this.Text = "Load Your Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxLoadCharacter;
        private System.Windows.Forms.Button uxCreateNewCharacter;
        private System.Windows.Forms.TextBox uxTextbox1;
    }
}

