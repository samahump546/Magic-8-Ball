
namespace Magic_8_Ball
{
    partial class magicBall
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 34);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(200, 39);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Think of a Question";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(514, 365);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(201, 76);
            this.outputLabel.TabIndex = 2;
            // 
            // clickButton
            // 
            this.clickButton.BackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatAppearance.BorderSize = 0;
            this.clickButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickButton.Location = new System.Drawing.Point(103, 76);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(400, 362);
            this.clickButton.TabIndex = 3;
            this.clickButton.UseVisualStyleBackColor = false;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // magicBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Magic_8_Ball.Properties.Resources.clickBall;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "magicBall";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clickButton;
    }
}

