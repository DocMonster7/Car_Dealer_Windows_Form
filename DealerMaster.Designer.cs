
namespace Car_Dealer_Windows_Form
{
    partial class DealerMaster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCarInfo = new System.Windows.Forms.TabPage();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.displayCyclinders = new System.Windows.Forms.Label();
            this.displayDisplacement = new System.Windows.Forms.Label();
            this.displayHorsepower = new System.Windows.Forms.Label();
            this.displayWeightInPounds = new System.Windows.Forms.Label();
            this.displayAcceleration = new System.Windows.Forms.Label();
            this.displayYear = new System.Windows.Forms.Label();
            this.displayOrigin = new System.Windows.Forms.Label();
            this.displayMilesPerGallon = new System.Windows.Forms.Label();
            this.lbOrigin = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbAccerleration = new System.Windows.Forms.Label();
            this.lbWeightInPounds = new System.Windows.Forms.Label();
            this.lnHorsepower = new System.Windows.Forms.Label();
            this.lbDisplacement = new System.Windows.Forms.Label();
            this.lbCylinders = new System.Windows.Forms.Label();
            this.lbMilesPerGallon = new System.Windows.Forms.Label();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.lbCarModel = new System.Windows.Forms.Label();
            this.tpFeedback = new System.Windows.Forms.TabPage();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbContactNumber = new System.Windows.Forms.Label();
            this.lbCustometName = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbCarInfo.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.tpFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCarInfo);
            this.tabControl1.Controls.Add(this.tpFeedback);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCarInfo
            // 
            this.tbCarInfo.Controls.Add(this.displayPanel);
            this.tbCarInfo.Controls.Add(this.cbCarModel);
            this.tbCarInfo.Controls.Add(this.lbCarModel);
            this.tbCarInfo.Location = new System.Drawing.Point(4, 24);
            this.tbCarInfo.Name = "tbCarInfo";
            this.tbCarInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarInfo.Size = new System.Drawing.Size(778, 407);
            this.tbCarInfo.TabIndex = 0;
            this.tbCarInfo.Text = "Car Info";
            this.tbCarInfo.UseVisualStyleBackColor = true;
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.displayCyclinders);
            this.displayPanel.Controls.Add(this.displayDisplacement);
            this.displayPanel.Controls.Add(this.displayHorsepower);
            this.displayPanel.Controls.Add(this.displayWeightInPounds);
            this.displayPanel.Controls.Add(this.displayAcceleration);
            this.displayPanel.Controls.Add(this.displayYear);
            this.displayPanel.Controls.Add(this.displayOrigin);
            this.displayPanel.Controls.Add(this.displayMilesPerGallon);
            this.displayPanel.Controls.Add(this.lbOrigin);
            this.displayPanel.Controls.Add(this.lbYear);
            this.displayPanel.Controls.Add(this.lbAccerleration);
            this.displayPanel.Controls.Add(this.lbWeightInPounds);
            this.displayPanel.Controls.Add(this.lnHorsepower);
            this.displayPanel.Controls.Add(this.lbDisplacement);
            this.displayPanel.Controls.Add(this.lbCylinders);
            this.displayPanel.Controls.Add(this.lbMilesPerGallon);
            this.displayPanel.Location = new System.Drawing.Point(39, 103);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(692, 241);
            this.displayPanel.TabIndex = 2;
            this.displayPanel.Visible = false;
            // 
            // displayCyclinders
            // 
            this.displayCyclinders.AutoSize = true;
            this.displayCyclinders.Location = new System.Drawing.Point(153, 69);
            this.displayCyclinders.Name = "displayCyclinders";
            this.displayCyclinders.Size = new System.Drawing.Size(38, 15);
            this.displayCyclinders.TabIndex = 15;
            this.displayCyclinders.Text = "label8";
            // 
            // displayDisplacement
            // 
            this.displayDisplacement.AutoSize = true;
            this.displayDisplacement.Location = new System.Drawing.Point(153, 121);
            this.displayDisplacement.Name = "displayDisplacement";
            this.displayDisplacement.Size = new System.Drawing.Size(38, 15);
            this.displayDisplacement.TabIndex = 14;
            this.displayDisplacement.Text = "label7";
            // 
            // displayHorsepower
            // 
            this.displayHorsepower.AutoSize = true;
            this.displayHorsepower.Location = new System.Drawing.Point(153, 177);
            this.displayHorsepower.Name = "displayHorsepower";
            this.displayHorsepower.Size = new System.Drawing.Size(38, 15);
            this.displayHorsepower.TabIndex = 13;
            this.displayHorsepower.Text = "label6";
            // 
            // displayWeightInPounds
            // 
            this.displayWeightInPounds.AutoSize = true;
            this.displayWeightInPounds.Location = new System.Drawing.Point(545, 21);
            this.displayWeightInPounds.Name = "displayWeightInPounds";
            this.displayWeightInPounds.Size = new System.Drawing.Size(38, 15);
            this.displayWeightInPounds.TabIndex = 12;
            this.displayWeightInPounds.Text = "label5";
            // 
            // displayAcceleration
            // 
            this.displayAcceleration.AutoSize = true;
            this.displayAcceleration.Location = new System.Drawing.Point(545, 69);
            this.displayAcceleration.Name = "displayAcceleration";
            this.displayAcceleration.Size = new System.Drawing.Size(38, 15);
            this.displayAcceleration.TabIndex = 11;
            this.displayAcceleration.Text = "label4";
            // 
            // displayYear
            // 
            this.displayYear.AutoSize = true;
            this.displayYear.Location = new System.Drawing.Point(545, 124);
            this.displayYear.Name = "displayYear";
            this.displayYear.Size = new System.Drawing.Size(38, 15);
            this.displayYear.TabIndex = 10;
            this.displayYear.Text = "label3";
            // 
            // displayOrigin
            // 
            this.displayOrigin.AutoSize = true;
            this.displayOrigin.Location = new System.Drawing.Point(545, 177);
            this.displayOrigin.Name = "displayOrigin";
            this.displayOrigin.Size = new System.Drawing.Size(38, 15);
            this.displayOrigin.TabIndex = 9;
            this.displayOrigin.Text = "label2";
            // 
            // displayMilesPerGallon
            // 
            this.displayMilesPerGallon.AutoSize = true;
            this.displayMilesPerGallon.Location = new System.Drawing.Point(153, 21);
            this.displayMilesPerGallon.Name = "displayMilesPerGallon";
            this.displayMilesPerGallon.Size = new System.Drawing.Size(38, 15);
            this.displayMilesPerGallon.TabIndex = 8;
            this.displayMilesPerGallon.Text = "label1";
            // 
            // lbOrigin
            // 
            this.lbOrigin.AutoSize = true;
            this.lbOrigin.Location = new System.Drawing.Point(379, 177);
            this.lbOrigin.Name = "lbOrigin";
            this.lbOrigin.Size = new System.Drawing.Size(40, 15);
            this.lbOrigin.TabIndex = 7;
            this.lbOrigin.Text = "Origin";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(379, 124);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 15);
            this.lbYear.TabIndex = 6;
            this.lbYear.Text = "Year";
            // 
            // lbAccerleration
            // 
            this.lbAccerleration.AutoSize = true;
            this.lbAccerleration.Location = new System.Drawing.Point(379, 69);
            this.lbAccerleration.Name = "lbAccerleration";
            this.lbAccerleration.Size = new System.Drawing.Size(73, 15);
            this.lbAccerleration.TabIndex = 5;
            this.lbAccerleration.Text = "Acceleration";
            // 
            // lbWeightInPounds
            // 
            this.lbWeightInPounds.AutoSize = true;
            this.lbWeightInPounds.Location = new System.Drawing.Point(379, 21);
            this.lbWeightInPounds.Name = "lbWeightInPounds";
            this.lbWeightInPounds.Size = new System.Drawing.Size(101, 15);
            this.lbWeightInPounds.TabIndex = 4;
            this.lbWeightInPounds.Text = "Weight In pounds";
            // 
            // lnHorsepower
            // 
            this.lnHorsepower.AutoSize = true;
            this.lnHorsepower.Location = new System.Drawing.Point(22, 177);
            this.lnHorsepower.Name = "lnHorsepower";
            this.lnHorsepower.Size = new System.Drawing.Size(71, 15);
            this.lnHorsepower.TabIndex = 3;
            this.lnHorsepower.Text = "Horsepower";
            // 
            // lbDisplacement
            // 
            this.lbDisplacement.AutoSize = true;
            this.lbDisplacement.Location = new System.Drawing.Point(22, 124);
            this.lbDisplacement.Name = "lbDisplacement";
            this.lbDisplacement.Size = new System.Drawing.Size(79, 15);
            this.lbDisplacement.TabIndex = 2;
            this.lbDisplacement.Text = "Displacement";
            // 
            // lbCylinders
            // 
            this.lbCylinders.AutoSize = true;
            this.lbCylinders.Location = new System.Drawing.Point(22, 69);
            this.lbCylinders.Name = "lbCylinders";
            this.lbCylinders.Size = new System.Drawing.Size(56, 15);
            this.lbCylinders.TabIndex = 1;
            this.lbCylinders.Text = "Cylinders";
            // 
            // lbMilesPerGallon
            // 
            this.lbMilesPerGallon.AutoSize = true;
            this.lbMilesPerGallon.Location = new System.Drawing.Point(22, 21);
            this.lbMilesPerGallon.Name = "lbMilesPerGallon";
            this.lbMilesPerGallon.Size = new System.Drawing.Size(92, 15);
            this.lbMilesPerGallon.TabIndex = 0;
            this.lbMilesPerGallon.Text = "Miles Per Gallon";
            // 
            // cbCarModel
            // 
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Location = new System.Drawing.Point(271, 61);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(227, 23);
            this.cbCarModel.TabIndex = 1;
            this.cbCarModel.SelectedIndexChanged += new System.EventHandler(this.cbCarModel_SelectedIndexChanged);
            // 
            // lbCarModel
            // 
            this.lbCarModel.AutoSize = true;
            this.lbCarModel.Location = new System.Drawing.Point(143, 64);
            this.lbCarModel.Name = "lbCarModel";
            this.lbCarModel.Size = new System.Drawing.Size(96, 15);
            this.lbCarModel.TabIndex = 0;
            this.lbCarModel.Text = "Select Car Model";
            // 
            // tpFeedback
            // 
            this.tpFeedback.Controls.Add(this.tbComment);
            this.tpFeedback.Controls.Add(this.tbEmail);
            this.tpFeedback.Controls.Add(this.tbContactNumber);
            this.tpFeedback.Controls.Add(this.tbCustomerName);
            this.tpFeedback.Controls.Add(this.btSubmit);
            this.tpFeedback.Controls.Add(this.lbComment);
            this.tpFeedback.Controls.Add(this.lbEmail);
            this.tpFeedback.Controls.Add(this.lbContactNumber);
            this.tpFeedback.Controls.Add(this.lbCustometName);
            this.tpFeedback.Location = new System.Drawing.Point(4, 24);
            this.tpFeedback.Name = "tpFeedback";
            this.tpFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tpFeedback.Size = new System.Drawing.Size(778, 407);
            this.tpFeedback.TabIndex = 1;
            this.tpFeedback.Text = "Feedback";
            this.tpFeedback.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(135, 98);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbContactNumber
            // 
            this.lbContactNumber.AutoSize = true;
            this.lbContactNumber.Location = new System.Drawing.Point(135, 59);
            this.lbContactNumber.Name = "lbContactNumber";
            this.lbContactNumber.Size = new System.Drawing.Size(96, 15);
            this.lbContactNumber.TabIndex = 1;
            this.lbContactNumber.Text = "Contact Number";
            // 
            // lbCustometName
            // 
            this.lbCustometName.AutoSize = true;
            this.lbCustometName.Location = new System.Drawing.Point(135, 24);
            this.lbCustometName.Name = "lbCustometName";
            this.lbCustometName.Size = new System.Drawing.Size(39, 15);
            this.lbCustometName.TabIndex = 0;
            this.lbCustometName.Text = "Name";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(135, 137);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(61, 15);
            this.lbComment.TabIndex = 3;
            this.lbComment.Text = "Comment";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(329, 281);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(240, 15);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(190, 23);
            this.tbCustomerName.TabIndex = 5;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(240, 56);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(190, 23);
            this.tbContactNumber.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(240, 98);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(267, 23);
            this.tbEmail.TabIndex = 7;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(240, 137);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(267, 138);
            this.tbComment.TabIndex = 8;
            // 
            // DealerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DealerMaster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DealerMaster_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbCarInfo.ResumeLayout(false);
            this.tbCarInfo.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.tpFeedback.ResumeLayout(false);
            this.tpFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCarInfo;
        private System.Windows.Forms.TabPage tpFeedback;
        private System.Windows.Forms.ComboBox cbCarModel;
        private System.Windows.Forms.Label lbCarModel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbAccerleration;
        private System.Windows.Forms.Label lbWeightInPounds;
        private System.Windows.Forms.Label lnHorsepower;
        private System.Windows.Forms.Label lbDisplacement;
        private System.Windows.Forms.Label lbCylinders;
        private System.Windows.Forms.Label lbMilesPerGallon;
        private System.Windows.Forms.Label displayCyclinders;
        private System.Windows.Forms.Label displayDisplacement;
        private System.Windows.Forms.Label displayHorsepower;
        private System.Windows.Forms.Label displayWeightInPounds;
        private System.Windows.Forms.Label displayAcceleration;
        private System.Windows.Forms.Label displayYear;
        private System.Windows.Forms.Label displayOrigin;
        private System.Windows.Forms.Label displayMilesPerGallon;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbContactNumber;
        private System.Windows.Forms.Label lbCustometName;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbComment;
    }
}

