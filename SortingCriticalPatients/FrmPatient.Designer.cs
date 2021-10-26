
namespace SortingCriticalPatients
{
    partial class FrmPatient
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCritical = new System.Windows.Forms.Button();
            this.bLessThan = new System.Windows.Forms.Button();
            this.textBoxLessThan = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.lLessThan = new System.Windows.Forms.Label();
            this.pLessThan = new System.Windows.Forms.Panel();
            this.pResult = new System.Windows.Forms.Panel();
            this.pFindByName = new System.Windows.Forms.Panel();
            this.bFindByName = new System.Windows.Forms.Button();
            this.lFindByName2 = new System.Windows.Forms.Label();
            this.textBoxFindByName = new System.Windows.Forms.TextBox();
            this.pFindBySurname = new System.Windows.Forms.Panel();
            this.bFindBySurname = new System.Windows.Forms.Button();
            this.lFindBySurname2 = new System.Windows.Forms.Label();
            this.textBoxFindBySurname = new System.Windows.Forms.TextBox();
            this.groupBoxLessThan = new System.Windows.Forms.GroupBox();
            this.groupBoxFindByName = new System.Windows.Forms.GroupBox();
            this.groupBoxFindBySurname = new System.Windows.Forms.GroupBox();
            this.lVResult = new System.Windows.Forms.ListView();
            this.pLessThan.SuspendLayout();
            this.pResult.SuspendLayout();
            this.pFindByName.SuspendLayout();
            this.pFindBySurname.SuspendLayout();
            this.groupBoxLessThan.SuspendLayout();
            this.groupBoxFindByName.SuspendLayout();
            this.groupBoxFindBySurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCritical
            // 
            this.bCritical.Location = new System.Drawing.Point(388, 290);
            this.bCritical.Name = "bCritical";
            this.bCritical.Size = new System.Drawing.Size(180, 30);
            this.bCritical.TabIndex = 2;
            this.bCritical.Text = "Поиск критических пациентов";
            this.bCritical.UseVisualStyleBackColor = true;
            this.bCritical.Click += new System.EventHandler(this.bCritical_Click);
            // 
            // bLessThan
            // 
            this.bLessThan.Location = new System.Drawing.Point(36, 104);
            this.bLessThan.Name = "bLessThan";
            this.bLessThan.Size = new System.Drawing.Size(209, 23);
            this.bLessThan.TabIndex = 3;
            this.bLessThan.Text = "Поиск";
            this.bLessThan.UseVisualStyleBackColor = true;
            this.bLessThan.Click += new System.EventHandler(this.bLessThan_Click);
            // 
            // textBoxLessThan
            // 
            this.textBoxLessThan.Location = new System.Drawing.Point(60, 69);
            this.textBoxLessThan.Name = "textBoxLessThan";
            this.textBoxLessThan.Size = new System.Drawing.Size(150, 20);
            this.textBoxLessThan.TabIndex = 4;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(450, 28);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(59, 13);
            this.lResult.TabIndex = 6;
            this.lResult.Text = "Результат";
            // 
            // lLessThan
            // 
            this.lLessThan.AutoSize = true;
            this.lLessThan.Location = new System.Drawing.Point(23, 44);
            this.lLessThan.Name = "lLessThan";
            this.lLessThan.Size = new System.Drawing.Size(245, 13);
            this.lLessThan.TabIndex = 7;
            this.lLessThan.Text = "Введите возрост пациента и нажмите \"Поиск\"";
            // 
            // pLessThan
            // 
            this.pLessThan.Controls.Add(this.bLessThan);
            this.pLessThan.Controls.Add(this.lLessThan);
            this.pLessThan.Controls.Add(this.textBoxLessThan);
            this.pLessThan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLessThan.Location = new System.Drawing.Point(3, 16);
            this.pLessThan.Name = "pLessThan";
            this.pLessThan.Size = new System.Drawing.Size(279, 146);
            this.pLessThan.TabIndex = 8;
            // 
            // pResult
            // 
            this.pResult.Controls.Add(this.lVResult);
            this.pResult.Controls.Add(this.lResult);
            this.pResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pResult.Location = new System.Drawing.Point(0, 336);
            this.pResult.Name = "pResult";
            this.pResult.Size = new System.Drawing.Size(965, 382);
            this.pResult.TabIndex = 9;
            // 
            // pFindByName
            // 
            this.pFindByName.Controls.Add(this.bFindByName);
            this.pFindByName.Controls.Add(this.lFindByName2);
            this.pFindByName.Controls.Add(this.textBoxFindByName);
            this.pFindByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFindByName.Location = new System.Drawing.Point(3, 16);
            this.pFindByName.Name = "pFindByName";
            this.pFindByName.Size = new System.Drawing.Size(279, 146);
            this.pFindByName.TabIndex = 10;
            // 
            // bFindByName
            // 
            this.bFindByName.Location = new System.Drawing.Point(36, 104);
            this.bFindByName.Name = "bFindByName";
            this.bFindByName.Size = new System.Drawing.Size(209, 23);
            this.bFindByName.TabIndex = 3;
            this.bFindByName.Text = "Поиск";
            this.bFindByName.UseVisualStyleBackColor = true;
            this.bFindByName.Click += new System.EventHandler(this.bFindByName_Click);
            // 
            // lFindByName2
            // 
            this.lFindByName2.AutoSize = true;
            this.lFindByName2.Location = new System.Drawing.Point(23, 44);
            this.lFindByName2.Name = "lFindByName2";
            this.lFindByName2.Size = new System.Drawing.Size(224, 13);
            this.lFindByName2.TabIndex = 7;
            this.lFindByName2.Text = "Введите имя пациента и нажмите \"Поиск\"";
            // 
            // textBoxFindByName
            // 
            this.textBoxFindByName.Location = new System.Drawing.Point(60, 69);
            this.textBoxFindByName.Name = "textBoxFindByName";
            this.textBoxFindByName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFindByName.TabIndex = 4;
            // 
            // pFindBySurname
            // 
            this.pFindBySurname.Controls.Add(this.bFindBySurname);
            this.pFindBySurname.Controls.Add(this.lFindBySurname2);
            this.pFindBySurname.Controls.Add(this.textBoxFindBySurname);
            this.pFindBySurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFindBySurname.Location = new System.Drawing.Point(3, 16);
            this.pFindBySurname.Name = "pFindBySurname";
            this.pFindBySurname.Size = new System.Drawing.Size(279, 146);
            this.pFindBySurname.TabIndex = 11;
            // 
            // bFindBySurname
            // 
            this.bFindBySurname.Location = new System.Drawing.Point(36, 104);
            this.bFindBySurname.Name = "bFindBySurname";
            this.bFindBySurname.Size = new System.Drawing.Size(209, 23);
            this.bFindBySurname.TabIndex = 3;
            this.bFindBySurname.Text = "Поиск";
            this.bFindBySurname.UseVisualStyleBackColor = true;
            this.bFindBySurname.Click += new System.EventHandler(this.bFindBySurname_Click);
            // 
            // lFindBySurname2
            // 
            this.lFindBySurname2.AutoSize = true;
            this.lFindBySurname2.Location = new System.Drawing.Point(18, 44);
            this.lFindBySurname2.Name = "lFindBySurname2";
            this.lFindBySurname2.Size = new System.Drawing.Size(252, 13);
            this.lFindBySurname2.TabIndex = 7;
            this.lFindBySurname2.Text = "Введите фамилию пациента и нажмите \"Поиск\"";
            // 
            // textBoxFindBySurname
            // 
            this.textBoxFindBySurname.Location = new System.Drawing.Point(60, 69);
            this.textBoxFindBySurname.Name = "textBoxFindBySurname";
            this.textBoxFindBySurname.Size = new System.Drawing.Size(150, 20);
            this.textBoxFindBySurname.TabIndex = 4;
            // 
            // groupBoxLessThan
            // 
            this.groupBoxLessThan.Controls.Add(this.pLessThan);
            this.groupBoxLessThan.Location = new System.Drawing.Point(29, 86);
            this.groupBoxLessThan.Name = "groupBoxLessThan";
            this.groupBoxLessThan.Size = new System.Drawing.Size(285, 165);
            this.groupBoxLessThan.TabIndex = 12;
            this.groupBoxLessThan.TabStop = false;
            this.groupBoxLessThan.Text = "Поиск с возрастом ниже введенного";
            // 
            // groupBoxFindByName
            // 
            this.groupBoxFindByName.Controls.Add(this.pFindByName);
            this.groupBoxFindByName.Location = new System.Drawing.Point(340, 86);
            this.groupBoxFindByName.Name = "groupBoxFindByName";
            this.groupBoxFindByName.Size = new System.Drawing.Size(285, 165);
            this.groupBoxFindByName.TabIndex = 13;
            this.groupBoxFindByName.TabStop = false;
            this.groupBoxFindByName.Text = "Поиск по имяни";
            // 
            // groupBoxFindBySurname
            // 
            this.groupBoxFindBySurname.Controls.Add(this.pFindBySurname);
            this.groupBoxFindBySurname.Location = new System.Drawing.Point(652, 86);
            this.groupBoxFindBySurname.Name = "groupBoxFindBySurname";
            this.groupBoxFindBySurname.Size = new System.Drawing.Size(285, 165);
            this.groupBoxFindBySurname.TabIndex = 14;
            this.groupBoxFindBySurname.TabStop = false;
            this.groupBoxFindBySurname.Text = "Поиск по фамилии";
            // 
            // lVResult
            // 
            this.lVResult.HideSelection = false;
            this.lVResult.Location = new System.Drawing.Point(196, 54);
            this.lVResult.Name = "lVResult";
            this.lVResult.Size = new System.Drawing.Size(602, 256);
            this.lVResult.TabIndex = 20;
            this.lVResult.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 718);
            this.Controls.Add(this.groupBoxFindBySurname);
            this.Controls.Add(this.groupBoxFindByName);
            this.Controls.Add(this.groupBoxLessThan);
            this.Controls.Add(this.pResult);
            this.Controls.Add(this.bCritical);
            this.Name = "FrmPatient";
            this.Text = "Patient";
            this.pLessThan.ResumeLayout(false);
            this.pLessThan.PerformLayout();
            this.pResult.ResumeLayout(false);
            this.pResult.PerformLayout();
            this.pFindByName.ResumeLayout(false);
            this.pFindByName.PerformLayout();
            this.pFindBySurname.ResumeLayout(false);
            this.pFindBySurname.PerformLayout();
            this.groupBoxLessThan.ResumeLayout(false);
            this.groupBoxFindByName.ResumeLayout(false);
            this.groupBoxFindBySurname.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCritical;
        private System.Windows.Forms.Button bLessThan;
        private System.Windows.Forms.TextBox textBoxLessThan;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lLessThan;
        private System.Windows.Forms.Panel pLessThan;
        private System.Windows.Forms.Panel pResult;
        private System.Windows.Forms.Panel pFindByName;
        private System.Windows.Forms.Button bFindByName;
        private System.Windows.Forms.Label lFindByName2;
        private System.Windows.Forms.TextBox textBoxFindByName;
        private System.Windows.Forms.Panel pFindBySurname;
        private System.Windows.Forms.Button bFindBySurname;
        private System.Windows.Forms.Label lFindBySurname2;
        private System.Windows.Forms.TextBox textBoxFindBySurname;
        private System.Windows.Forms.GroupBox groupBoxLessThan;
        private System.Windows.Forms.GroupBox groupBoxFindByName;
        private System.Windows.Forms.GroupBox groupBoxFindBySurname;
        private System.Windows.Forms.ListView lVResult;
    }
}

