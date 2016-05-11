namespace REGEX_Forms
{
    partial class Form1
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
            System.Windows.Forms.Label label3;
            this.TextStrTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RegexStrTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextStrTextBox
            // 
            this.TextStrTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextStrTextBox.Location = new System.Drawing.Point(74, 96);
            this.TextStrTextBox.Name = "TextStrTextBox";
            this.TextStrTextBox.Size = new System.Drawing.Size(100, 20);
            this.TextStrTextBox.TabIndex = 0;
            this.TextStrTextBox.Text = "abacus";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(12, 254);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 35);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Search string";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReturnLabel.Location = new System.Drawing.Point(74, 213);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(149, 18);
            this.ReturnLabel.TabIndex = 2;
            this.ReturnLabel.Text = "Result string will display here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regex Query test ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text String:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(71, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(108, 254);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 35);
            this.optionsButton.TabIndex = 6;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(200, 254);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 35);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Query string:";
            // 
            // RegexStrTextBox
            // 
            this.RegexStrTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegexStrTextBox.Location = new System.Drawing.Point(74, 152);
            this.RegexStrTextBox.Name = "RegexStrTextBox";
            this.RegexStrTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegexStrTextBox.TabIndex = 10;
            this.RegexStrTextBox.Text = "[a-b]{3}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 301);
            this.Controls.Add(this.RegexStrTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.TextStrTextBox);
            this.Name = "Form1";
            this.Text = "REGEX Practice form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextStrTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label ReturnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegexStrTextBox;
    }
}

