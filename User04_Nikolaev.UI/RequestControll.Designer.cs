namespace User04_Nikolaev.UI
{
    partial class RequestControll
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.textBoxRecent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMaster = new System.Windows.Forms.GroupBox();
            this.textBoxZapchasti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.labelCompletedDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMaster.SuspendLayout();
            this.groupBoxOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxRecent);
            this.groupBoxClient.Controls.Add(this.label5);
            this.groupBoxClient.Controls.Add(this.textBoxModel);
            this.groupBoxClient.Controls.Add(this.label4);
            this.groupBoxClient.Controls.Add(this.comboBoxEquipmentType);
            this.groupBoxClient.Controls.Add(this.label3);
            this.groupBoxClient.Controls.Add(this.labelCreatedAt);
            this.groupBoxClient.Controls.Add(this.label2);
            this.groupBoxClient.Controls.Add(this.labelIdNumber);
            this.groupBoxClient.Controls.Add(this.label1);
            this.groupBoxClient.Location = new System.Drawing.Point(24, 18);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(774, 501);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Данные по заявке";
            // 
            // textBoxRecent
            // 
            this.textBoxRecent.Location = new System.Drawing.Point(315, 253);
            this.textBoxRecent.Multiline = true;
            this.textBoxRecent.Name = "textBoxRecent";
            this.textBoxRecent.Size = new System.Drawing.Size(402, 221);
            this.textBoxRecent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Описаниеи проблемы:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(315, 203);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(402, 26);
            this.textBoxModel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Модель оборудования:";
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(314, 147);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(403, 28);
            this.comboBoxEquipmentType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип оборудования: ";
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreatedAt.Location = new System.Drawing.Point(309, 89);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(181, 33);
            this.labelCreatedAt.TabIndex = 3;
            this.labelCreatedAt.Text = "Дата создания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата создания:";
            // 
            // labelIdNumber
            // 
            this.labelIdNumber.AutoSize = true;
            this.labelIdNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdNumber.Location = new System.Drawing.Point(308, 45);
            this.labelIdNumber.Name = "labelIdNumber";
            this.labelIdNumber.Size = new System.Drawing.Size(28, 32);
            this.labelIdNumber.TabIndex = 1;
            this.labelIdNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPhone);
            this.groupBox2.Controls.Add(this.labelFIO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(24, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные клиента";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(247, 98);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(215, 33);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(247, 45);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(185, 33);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "ФИО клиента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Номер телефона:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(56, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "ФИО клиента:";
            // 
            // groupBoxMaster
            // 
            this.groupBoxMaster.Controls.Add(this.textBoxZapchasti);
            this.groupBoxMaster.Controls.Add(this.label11);
            this.groupBoxMaster.Location = new System.Drawing.Point(24, 731);
            this.groupBoxMaster.Name = "groupBoxMaster";
            this.groupBoxMaster.Size = new System.Drawing.Size(774, 141);
            this.groupBoxMaster.TabIndex = 14;
            this.groupBoxMaster.TabStop = false;
            this.groupBoxMaster.Text = "Данные для мастера";
            // 
            // textBoxZapchasti
            // 
            this.textBoxZapchasti.Location = new System.Drawing.Point(315, 25);
            this.textBoxZapchasti.Multiline = true;
            this.textBoxZapchasti.Name = "textBoxZapchasti";
            this.textBoxZapchasti.Size = new System.Drawing.Size(402, 91);
            this.textBoxZapchasti.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(164, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 33);
            this.label11.TabIndex = 10;
            this.label11.Text = "Запчасти: ";
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Controls.Add(this.labelCompletedDate);
            this.groupBoxOperator.Controls.Add(this.label10);
            this.groupBoxOperator.Controls.Add(this.comboBoxMaster);
            this.groupBoxOperator.Controls.Add(this.label9);
            this.groupBoxOperator.Controls.Add(this.comboBoxStatus);
            this.groupBoxOperator.Controls.Add(this.label8);
            this.groupBoxOperator.Location = new System.Drawing.Point(24, 887);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Size = new System.Drawing.Size(774, 285);
            this.groupBoxOperator.TabIndex = 15;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "Данные для оператора";
            // 
            // labelCompletedDate
            // 
            this.labelCompletedDate.AutoSize = true;
            this.labelCompletedDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompletedDate.Location = new System.Drawing.Point(296, 203);
            this.labelCompletedDate.Name = "labelCompletedDate";
            this.labelCompletedDate.Size = new System.Drawing.Size(157, 33);
            this.labelCompletedDate.TabIndex = 10;
            this.labelCompletedDate.Text = "Отсутствует";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(55, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 33);
            this.label10.TabIndex = 14;
            this.label10.Text = "Дата заверешения:";
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(314, 97);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(403, 28);
            this.comboBoxMaster.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(180, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Мастер:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(314, 40);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(403, 28);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(188, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 11;
            this.label8.Text = "Статус:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(277, 1192);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(281, 46);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // RequestControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOperator);
            this.Controls.Add(this.groupBoxMaster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxClient);
            this.Name = "RequestControll";
            this.Size = new System.Drawing.Size(832, 1252);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxMaster.ResumeLayout(false);
            this.groupBoxMaster.PerformLayout();
            this.groupBoxOperator.ResumeLayout(false);
            this.groupBoxOperator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label labelIdNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEquipmentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRecent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxMaster;
        private System.Windows.Forms.TextBox textBoxZapchasti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.Label labelCompletedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSave;
    }
}
