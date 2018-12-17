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
            this.uxTextbox1 = new System.Windows.Forms.TextBox();
            this.uxLoadCharacter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uxTextbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxTextbox1
            // 
            this.uxTextbox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextbox1.Location = new System.Drawing.Point(12, 12);
            this.uxTextbox1.Name = "uxTextbox1";
            this.uxTextbox1.ReadOnly = true;
            this.uxTextbox1.Size = new System.Drawing.Size(646, 24);
            this.uxTextbox1.TabIndex = 0;
            this.uxTextbox1.Text = "Please load in your character\'s text file to use their stats for your rolls";
            this.uxTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLoadCharacter
            // 
            this.uxLoadCharacter.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoadCharacter.Location = new System.Drawing.Point(12, 80);
            this.uxLoadCharacter.Name = "uxLoadCharacter";
            this.uxLoadCharacter.Size = new System.Drawing.Size(317, 76);
            this.uxLoadCharacter.TabIndex = 1;
            this.uxLoadCharacter.Text = "Load Character Txt File";
            this.uxLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create New Character Profile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uxTextbox2
            // 
            this.uxTextbox2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextbox2.Location = new System.Drawing.Point(12, 42);
            this.uxTextbox2.Name = "uxTextbox2";
            this.uxTextbox2.ReadOnly = true;
            this.uxTextbox2.Size = new System.Drawing.Size(646, 24);
            this.uxTextbox2.TabIndex = 3;
            this.uxTextbox2.Text = "Create a new profile if you do not have a txt file for your desired character.";
            this.uxTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLoadCharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 169);
            this.Controls.Add(this.uxTextbox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxLoadCharacter);
            this.Controls.Add(this.uxTextbox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uxLoadCharacterScreen";
            this.Text = "Load Your Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextbox1;
        private System.Windows.Forms.Button uxLoadCharacter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uxTextbox2;
    }
}

