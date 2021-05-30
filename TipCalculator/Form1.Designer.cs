
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
            this.lblTipPercentage = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtTipPercentage = new System.Windows.Forms.TextBox();
            this.lblTipPerPerson = new System.Windows.Forms.Label();
            this.lblTipPerPersonResult = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblEmptyFieldAlert = new System.Windows.Forms.Label();
            this.lblTotalPerPerson = new System.Windows.Forms.Label();
            this.lblTotalPerPersonResult = new System.Windows.Forms.Label();
            this.btnNumberOfPeopleIncrease = new System.Windows.Forms.Button();
            this.btnNumberOfPeopleDecrease = new System.Windows.Forms.Button();
            this.btnTipIncrease = new System.Windows.Forms.Button();
            this.btnTipDecrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipPercentage
            // 
            this.lblTipPercentage.AutoSize = true;
            this.lblTipPercentage.Location = new System.Drawing.Point(18, 72);
            this.lblTipPercentage.Name = "lblTipPercentage";
            this.lblTipPercentage.Size = new System.Drawing.Size(33, 13);
            this.lblTipPercentage.TabIndex = 2;
            this.lblTipPercentage.Text = "Tip %";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAmount.Location = new System.Drawing.Point(21, 41);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(122, 20);
            this.txtBillAmount.TabIndex = 3;
            this.txtBillAmount.Text = "0";
            this.txtBillAmount.TextChanged += new System.EventHandler(this.BillAmounttxtTextChanged);
            this.txtBillAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillAmounttxtKeyPress);
            // 
            // txtTipPercentage
            // 
            this.txtTipPercentage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipPercentage.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTipPercentage.Location = new System.Drawing.Point(42, 88);
            this.txtTipPercentage.Name = "txtTipPercentage";
            this.txtTipPercentage.Size = new System.Drawing.Size(83, 20);
            this.txtTipPercentage.TabIndex = 4;
            this.txtTipPercentage.Text = "0";
            this.txtTipPercentage.TextChanged += new System.EventHandler(this.TipPercentagetxtTextChanged);
            this.txtTipPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipPercentagetxtKeyPress);
            // 
            // lblTipPerPerson
            // 
            this.lblTipPerPerson.AutoSize = true;
            this.lblTipPerPerson.Location = new System.Drawing.Point(209, 48);
            this.lblTipPerPerson.Name = "lblTipPerPerson";
            this.lblTipPerPerson.Size = new System.Drawing.Size(77, 13);
            this.lblTipPerPerson.TabIndex = 5;
            this.lblTipPerPerson.Text = "Tip Per Person";
            // 
            // lblTipPerPersonResult
            // 
            this.lblTipPerPersonResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipPerPersonResult.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.lblTipPerPersonResult.Location = new System.Drawing.Point(292, 48);
            this.lblTipPerPersonResult.Name = "lblTipPerPersonResult";
            this.lblTipPerPersonResult.Size = new System.Drawing.Size(250, 20);
            this.lblTipPerPersonResult.TabIndex = 6;
            this.lblTipPerPersonResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(42, 133);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(83, 20);
            this.txtNumberOfPeople.TabIndex = 9;
            this.txtNumberOfPeople.Text = "1";
            this.txtNumberOfPeople.TextChanged += new System.EventHandler(this.NumberOfPeopletxtTextChanged);
            this.txtNumberOfPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPeopletxtKeyPress);
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(18, 117);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(91, 13);
            this.lblNumberOfPeople.TabIndex = 12;
            this.lblNumberOfPeople.Text = "Number of people";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Location = new System.Drawing.Point(18, 25);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(20, 13);
            this.lblBillAmount.TabIndex = 13;
            this.lblBillAmount.Text = "Bill";
            // 
            // lblEmptyFieldAlert
            // 
            this.lblEmptyFieldAlert.AutoSize = true;
            this.lblEmptyFieldAlert.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldAlert.Location = new System.Drawing.Point(241, 163);
            this.lblEmptyFieldAlert.Name = "lblEmptyFieldAlert";
            this.lblEmptyFieldAlert.Size = new System.Drawing.Size(0, 13);
            this.lblEmptyFieldAlert.TabIndex = 14;
            // 
            // lblTotalPerPerson
            // 
            this.lblTotalPerPerson.AutoSize = true;
            this.lblTotalPerPerson.Location = new System.Drawing.Point(209, 99);
            this.lblTotalPerPerson.Name = "lblTotalPerPerson";
            this.lblTotalPerPerson.Size = new System.Drawing.Size(86, 13);
            this.lblTotalPerPerson.TabIndex = 15;
            this.lblTotalPerPerson.Text = "Total Per Person";
            // 
            // lblTotalPerPersonResult
            // 
            this.lblTotalPerPersonResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPerPersonResult.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalPerPersonResult.Location = new System.Drawing.Point(301, 91);
            this.lblTotalPerPersonResult.Name = "lblTotalPerPersonResult";
            this.lblTotalPerPersonResult.Size = new System.Drawing.Size(241, 21);
            this.lblTotalPerPersonResult.TabIndex = 16;
            this.lblTotalPerPersonResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNumberOfPeopleIncrease
            // 
            this.btnNumberOfPeopleIncrease.Location = new System.Drawing.Point(116, 131);
            this.btnNumberOfPeopleIncrease.Name = "btnNumberOfPeopleIncrease";
            this.btnNumberOfPeopleIncrease.Size = new System.Drawing.Size(27, 23);
            this.btnNumberOfPeopleIncrease.TabIndex = 17;
            this.btnNumberOfPeopleIncrease.Text = "+";
            this.btnNumberOfPeopleIncrease.UseVisualStyleBackColor = true;
            this.btnNumberOfPeopleIncrease.Click += new System.EventHandler(this.NumberOfPeopleIncreasebtnClick);
            // 
            // btnNumberOfPeopleDecrease
            // 
            this.btnNumberOfPeopleDecrease.Location = new System.Drawing.Point(21, 131);
            this.btnNumberOfPeopleDecrease.Name = "btnNumberOfPeopleDecrease";
            this.btnNumberOfPeopleDecrease.Size = new System.Drawing.Size(23, 23);
            this.btnNumberOfPeopleDecrease.TabIndex = 18;
            this.btnNumberOfPeopleDecrease.Text = "-";
            this.btnNumberOfPeopleDecrease.UseVisualStyleBackColor = true;
            this.btnNumberOfPeopleDecrease.Click += new System.EventHandler(this.NumberOfPeopleDecreasebtnClick);
            // 
            // btnTipIncrease
            // 
            this.btnTipIncrease.Location = new System.Drawing.Point(121, 86);
            this.btnTipIncrease.Name = "btnTipIncrease";
            this.btnTipIncrease.Size = new System.Drawing.Size(22, 23);
            this.btnTipIncrease.TabIndex = 19;
            this.btnTipIncrease.Text = "+";
            this.btnTipIncrease.UseVisualStyleBackColor = true;
            this.btnTipIncrease.Click += new System.EventHandler(this.TipIncreasebtnClick);
            // 
            // btnTipDecrease
            // 
            this.btnTipDecrease.Location = new System.Drawing.Point(21, 86);
            this.btnTipDecrease.Name = "btnTipDecrease";
            this.btnTipDecrease.Size = new System.Drawing.Size(22, 23);
            this.btnTipDecrease.TabIndex = 20;
            this.btnTipDecrease.Text = "-";
            this.btnTipDecrease.UseVisualStyleBackColor = true;
            this.btnTipDecrease.Click += new System.EventHandler(this.TipDecreasebtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(554, 212);
            this.Controls.Add(this.btnTipDecrease);
            this.Controls.Add(this.btnTipIncrease);
            this.Controls.Add(this.btnNumberOfPeopleDecrease);
            this.Controls.Add(this.btnNumberOfPeopleIncrease);
            this.Controls.Add(this.lblTotalPerPersonResult);
            this.Controls.Add(this.lblTotalPerPerson);
            this.Controls.Add(this.lblEmptyFieldAlert);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.lblTipPerPersonResult);
            this.Controls.Add(this.lblTipPerPerson);
            this.Controls.Add(this.txtTipPercentage);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.lblTipPercentage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipPercentage;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtTipPercentage;
        private System.Windows.Forms.Label lblTipPerPerson;
        private System.Windows.Forms.Label lblTipPerPersonResult;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblEmptyFieldAlert;
        private System.Windows.Forms.Label lblTotalPerPerson;
        private System.Windows.Forms.Label lblTotalPerPersonResult;
        private System.Windows.Forms.Button btnNumberOfPeopleIncrease;
        private System.Windows.Forms.Button btnNumberOfPeopleDecrease;
        private System.Windows.Forms.Button btnTipIncrease;
        private System.Windows.Forms.Button btnTipDecrease;
    }
}

