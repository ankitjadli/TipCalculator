
namespace TipCalculator
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
            this.Tip_Percentage_Label = new System.Windows.Forms.Label();
            this.Bill_Amount_Textbox = new System.Windows.Forms.TextBox();
            this.Tip_Percentage_TextBox = new System.Windows.Forms.TextBox();
            this.Tip_Per_Person_Label = new System.Windows.Forms.Label();
            this.Tip_Per_Person_Result = new System.Windows.Forms.Label();
            this.Number_Of_People_TextBox = new System.Windows.Forms.TextBox();
            this.Number_Of_People_Label = new System.Windows.Forms.Label();
            this.Bill_Amount_Label = new System.Windows.Forms.Label();
            this.Empty_Field_Alert_Label = new System.Windows.Forms.Label();
            this.Total_Per_Person_Label = new System.Windows.Forms.Label();
            this.Total_Per_Person_Result = new System.Windows.Forms.Label();
            this.Number_Of_People_Increase_Button = new System.Windows.Forms.Button();
            this.Number_Of_People_Decrease_Button = new System.Windows.Forms.Button();
            this.Tip_Increase_Button = new System.Windows.Forms.Button();
            this.Tip_Decrease_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tip_Percentage_Label
            // 
            this.Tip_Percentage_Label.AutoSize = true;
            this.Tip_Percentage_Label.Location = new System.Drawing.Point(22, 72);
            this.Tip_Percentage_Label.Name = "Tip_Percentage_Label";
            this.Tip_Percentage_Label.Size = new System.Drawing.Size(33, 13);
            this.Tip_Percentage_Label.TabIndex = 2;
            this.Tip_Percentage_Label.Text = "Tip %";
            // 
            // Bill_Amount_Textbox
            // 
            this.Bill_Amount_Textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bill_Amount_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_Amount_Textbox.Location = new System.Drawing.Point(21, 41);
            this.Bill_Amount_Textbox.Name = "Bill_Amount_Textbox";
            this.Bill_Amount_Textbox.Size = new System.Drawing.Size(122, 20);
            this.Bill_Amount_Textbox.TabIndex = 3;
            this.Bill_Amount_Textbox.Text = "0";
            this.Bill_Amount_Textbox.TextChanged += new System.EventHandler(this.Bill_Amount_Textbox_TextChanged);
            this.Bill_Amount_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Amount_Textbox_KeyPress);
            // 
            // Tip_Percentage_TextBox
            // 
            this.Tip_Percentage_TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tip_Percentage_TextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Tip_Percentage_TextBox.Location = new System.Drawing.Point(42, 88);
            this.Tip_Percentage_TextBox.Name = "Tip_Percentage_TextBox";
            this.Tip_Percentage_TextBox.Size = new System.Drawing.Size(83, 20);
            this.Tip_Percentage_TextBox.TabIndex = 4;
            this.Tip_Percentage_TextBox.Text = "0";
            this.Tip_Percentage_TextBox.TextChanged += new System.EventHandler(this.Tip_Percentage_TextBox_TextChanged);
            this.Tip_Percentage_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tip_Percentage_TextBox_KeyPress);
            // 
            // Tip_Per_Person_Label
            // 
            this.Tip_Per_Person_Label.AutoSize = true;
            this.Tip_Per_Person_Label.Location = new System.Drawing.Point(209, 48);
            this.Tip_Per_Person_Label.Name = "Tip_Per_Person_Label";
            this.Tip_Per_Person_Label.Size = new System.Drawing.Size(77, 13);
            this.Tip_Per_Person_Label.TabIndex = 5;
            this.Tip_Per_Person_Label.Text = "Tip Per Person";
            // 
            // Tip_Per_Person_Result
            // 
            this.Tip_Per_Person_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tip_Per_Person_Result.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.Tip_Per_Person_Result.Location = new System.Drawing.Point(292, 48);
            this.Tip_Per_Person_Result.Name = "Tip_Per_Person_Result";
            this.Tip_Per_Person_Result.Size = new System.Drawing.Size(250, 20);
            this.Tip_Per_Person_Result.TabIndex = 6;
            this.Tip_Per_Person_Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Number_Of_People_TextBox
            // 
            this.Number_Of_People_TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Number_Of_People_TextBox.Location = new System.Drawing.Point(42, 133);
            this.Number_Of_People_TextBox.Name = "Number_Of_People_TextBox";
            this.Number_Of_People_TextBox.Size = new System.Drawing.Size(83, 20);
            this.Number_Of_People_TextBox.TabIndex = 9;
            this.Number_Of_People_TextBox.Text = "1";
            this.Number_Of_People_TextBox.TextChanged += new System.EventHandler(this.Number_Of_People_TextBox_TextChanged);
            this.Number_Of_People_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Of_People_TextBox_KeyPress);
            // 
            // Number_Of_People_Label
            // 
            this.Number_Of_People_Label.AutoSize = true;
            this.Number_Of_People_Label.Location = new System.Drawing.Point(22, 117);
            this.Number_Of_People_Label.Name = "Number_Of_People_Label";
            this.Number_Of_People_Label.Size = new System.Drawing.Size(91, 13);
            this.Number_Of_People_Label.TabIndex = 12;
            this.Number_Of_People_Label.Text = "Number of people";
            // 
            // Bill_Amount_Label
            // 
            this.Bill_Amount_Label.AutoSize = true;
            this.Bill_Amount_Label.Location = new System.Drawing.Point(24, 25);
            this.Bill_Amount_Label.Name = "Bill_Amount_Label";
            this.Bill_Amount_Label.Size = new System.Drawing.Size(20, 13);
            this.Bill_Amount_Label.TabIndex = 13;
            this.Bill_Amount_Label.Text = "Bill";
            // 
            // Empty_Field_Alert_Label
            // 
            this.Empty_Field_Alert_Label.AutoSize = true;
            this.Empty_Field_Alert_Label.ForeColor = System.Drawing.Color.Red;
            this.Empty_Field_Alert_Label.Location = new System.Drawing.Point(241, 163);
            this.Empty_Field_Alert_Label.Name = "Empty_Field_Alert_Label";
            this.Empty_Field_Alert_Label.Size = new System.Drawing.Size(0, 13);
            this.Empty_Field_Alert_Label.TabIndex = 14;
            // 
            // Total_Per_Person_Label
            // 
            this.Total_Per_Person_Label.AutoSize = true;
            this.Total_Per_Person_Label.Location = new System.Drawing.Point(209, 99);
            this.Total_Per_Person_Label.Name = "Total_Per_Person_Label";
            this.Total_Per_Person_Label.Size = new System.Drawing.Size(86, 13);
            this.Total_Per_Person_Label.TabIndex = 15;
            this.Total_Per_Person_Label.Text = "Total Per Person";
            // 
            // Total_Per_Person_Result
            // 
            this.Total_Per_Person_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Total_Per_Person_Result.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.Total_Per_Person_Result.Location = new System.Drawing.Point(301, 91);
            this.Total_Per_Person_Result.Name = "Total_Per_Person_Result";
            this.Total_Per_Person_Result.Size = new System.Drawing.Size(241, 21);
            this.Total_Per_Person_Result.TabIndex = 16;
            this.Total_Per_Person_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Number_Of_People_Increase_Button
            // 
            this.Number_Of_People_Increase_Button.Location = new System.Drawing.Point(116, 131);
            this.Number_Of_People_Increase_Button.Name = "Number_Of_People_Increase_Button";
            this.Number_Of_People_Increase_Button.Size = new System.Drawing.Size(27, 23);
            this.Number_Of_People_Increase_Button.TabIndex = 17;
            this.Number_Of_People_Increase_Button.Text = "+";
            this.Number_Of_People_Increase_Button.UseVisualStyleBackColor = true;
            this.Number_Of_People_Increase_Button.Click += new System.EventHandler(this.Number_Of_People_Increase_Button_Click);
            // 
            // Number_Of_People_Decrease_Button
            // 
            this.Number_Of_People_Decrease_Button.Location = new System.Drawing.Point(21, 131);
            this.Number_Of_People_Decrease_Button.Name = "Number_Of_People_Decrease_Button";
            this.Number_Of_People_Decrease_Button.Size = new System.Drawing.Size(23, 23);
            this.Number_Of_People_Decrease_Button.TabIndex = 18;
            this.Number_Of_People_Decrease_Button.Text = "-";
            this.Number_Of_People_Decrease_Button.UseVisualStyleBackColor = true;
            this.Number_Of_People_Decrease_Button.Click += new System.EventHandler(this.Number_Of_People_Decrease_Button_Click);
            // 
            // Tip_Increase_Button
            // 
            this.Tip_Increase_Button.Location = new System.Drawing.Point(121, 86);
            this.Tip_Increase_Button.Name = "Tip_Increase_Button";
            this.Tip_Increase_Button.Size = new System.Drawing.Size(22, 23);
            this.Tip_Increase_Button.TabIndex = 19;
            this.Tip_Increase_Button.Text = "+";
            this.Tip_Increase_Button.UseVisualStyleBackColor = true;
            this.Tip_Increase_Button.Click += new System.EventHandler(this.Tip_Increase_Button_Click);
            // 
            // Tip_Decrease_Button
            // 
            this.Tip_Decrease_Button.Location = new System.Drawing.Point(21, 86);
            this.Tip_Decrease_Button.Name = "Tip_Decrease_Button";
            this.Tip_Decrease_Button.Size = new System.Drawing.Size(22, 23);
            this.Tip_Decrease_Button.TabIndex = 20;
            this.Tip_Decrease_Button.Text = "-";
            this.Tip_Decrease_Button.UseVisualStyleBackColor = true;
            this.Tip_Decrease_Button.Click += new System.EventHandler(this.Tip_Decrease_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(554, 212);
            this.Controls.Add(this.Tip_Decrease_Button);
            this.Controls.Add(this.Tip_Increase_Button);
            this.Controls.Add(this.Number_Of_People_Decrease_Button);
            this.Controls.Add(this.Number_Of_People_Increase_Button);
            this.Controls.Add(this.Total_Per_Person_Result);
            this.Controls.Add(this.Total_Per_Person_Label);
            this.Controls.Add(this.Empty_Field_Alert_Label);
            this.Controls.Add(this.Bill_Amount_Label);
            this.Controls.Add(this.Number_Of_People_Label);
            this.Controls.Add(this.Number_Of_People_TextBox);
            this.Controls.Add(this.Tip_Per_Person_Result);
            this.Controls.Add(this.Tip_Per_Person_Label);
            this.Controls.Add(this.Tip_Percentage_TextBox);
            this.Controls.Add(this.Bill_Amount_Textbox);
            this.Controls.Add(this.Tip_Percentage_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tip_Percentage_Label;
        private System.Windows.Forms.TextBox Bill_Amount_Textbox;
        private System.Windows.Forms.TextBox Tip_Percentage_TextBox;
        private System.Windows.Forms.Label Tip_Per_Person_Label;
        private System.Windows.Forms.Label Tip_Per_Person_Result;
        private System.Windows.Forms.TextBox Number_Of_People_TextBox;
        private System.Windows.Forms.Label Number_Of_People_Label;
        private System.Windows.Forms.Label Bill_Amount_Label;
        private System.Windows.Forms.Label Empty_Field_Alert_Label;
        private System.Windows.Forms.Label Total_Per_Person_Label;
        private System.Windows.Forms.Label Total_Per_Person_Result;
        private System.Windows.Forms.Button Number_Of_People_Increase_Button;
        private System.Windows.Forms.Button Number_Of_People_Decrease_Button;
        private System.Windows.Forms.Button Tip_Increase_Button;
        private System.Windows.Forms.Button Tip_Decrease_Button;
    }
}

