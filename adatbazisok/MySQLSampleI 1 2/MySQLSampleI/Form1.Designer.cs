namespace MySQLSampleI
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
            this.btnExit = new System.Windows.Forms.Button();
            this.tabSQL = new System.Windows.Forms.TabControl();
            this.tabSQLConnection = new System.Windows.Forms.TabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.tabSQLView = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKonyvNev = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.tabSQL.SuspendLayout();
            this.tabSQLConnection.SuspendLayout();
            this.tabSQLView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(387, 384);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tabSQL
            // 
            this.tabSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSQL.Controls.Add(this.tabSQLConnection);
            this.tabSQL.Controls.Add(this.tabSQLView);
            this.tabSQL.Location = new System.Drawing.Point(16, 15);
            this.tabSQL.Margin = new System.Windows.Forms.Padding(4);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.SelectedIndex = 0;
            this.tabSQL.Size = new System.Drawing.Size(855, 362);
            this.tabSQL.TabIndex = 1;
            // 
            // tabSQLConnection
            // 
            this.tabSQLConnection.Controls.Add(this.btnTest);
            this.tabSQLConnection.Controls.Add(this.label5);
            this.tabSQLConnection.Controls.Add(this.label4);
            this.tabSQLConnection.Controls.Add(this.label3);
            this.tabSQLConnection.Controls.Add(this.label2);
            this.tabSQLConnection.Controls.Add(this.label1);
            this.tabSQLConnection.Controls.Add(this.txtDatabase);
            this.tabSQLConnection.Controls.Add(this.txtPass);
            this.tabSQLConnection.Controls.Add(this.txtUser);
            this.tabSQLConnection.Controls.Add(this.txtPort);
            this.tabSQLConnection.Controls.Add(this.txtHost);
            this.tabSQLConnection.Location = new System.Drawing.Point(4, 25);
            this.tabSQLConnection.Margin = new System.Windows.Forms.Padding(4);
            this.tabSQLConnection.Name = "tabSQLConnection";
            this.tabSQLConnection.Padding = new System.Windows.Forms.Padding(4);
            this.tabSQLConnection.Size = new System.Drawing.Size(847, 333);
            this.tabSQLConnection.TabIndex = 0;
            this.tabSQLConnection.Text = "SQL csatlakozás";
            this.tabSQLConnection.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(237, 220);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adatbázis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Felhasználó neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gép neve:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(193, 159);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(209, 22);
            this.txtDatabase.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(193, 124);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(209, 22);
            this.txtPass.TabIndex = 0;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(193, 90);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(193, 55);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(209, 22);
            this.txtPort.TabIndex = 0;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(193, 21);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(209, 22);
            this.txtHost.TabIndex = 0;
            // 
            // tabSQLView
            // 
            this.tabSQLView.Controls.Add(this.btnList);
            this.tabSQLView.Controls.Add(this.dataGridView1);
            this.tabSQLView.Controls.Add(this.btnInsert);
            this.tabSQLView.Controls.Add(this.label6);
            this.tabSQLView.Controls.Add(this.txtKonyvNev);
            this.tabSQLView.Location = new System.Drawing.Point(4, 25);
            this.tabSQLView.Margin = new System.Windows.Forms.Padding(4);
            this.tabSQLView.Name = "tabSQLView";
            this.tabSQLView.Padding = new System.Windows.Forms.Padding(4);
            this.tabSQLView.Size = new System.Drawing.Size(847, 333);
            this.tabSQLView.TabIndex = 1;
            this.tabSQLView.Text = "SQL View";
            this.tabSQLView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(828, 230);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(505, 28);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 28);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Beszúrás";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Felhasználó név";
            // 
            // txtKonyvNev
            // 
            this.txtKonyvNev.Location = new System.Drawing.Point(172, 31);
            this.txtKonyvNev.Margin = new System.Windows.Forms.Padding(4);
            this.txtKonyvNev.Name = "txtKonyvNev";
            this.txtKonyvNev.Size = new System.Drawing.Size(299, 22);
            this.txtKonyvNev.TabIndex = 0;
            this.txtKonyvNev.TextChanged += new System.EventHandler(this.txtUserNewName_TextChanged);
            // 
            // btnList
            // 
            this.btnList.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnList.Location = new System.Drawing.Point(706, 31);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Kilistázás";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 427);
            this.Controls.Add(this.tabSQL);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MySQL próba alkalmazás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSQL.ResumeLayout(false);
            this.tabSQLConnection.ResumeLayout(false);
            this.tabSQLConnection.PerformLayout();
            this.tabSQLView.ResumeLayout(false);
            this.tabSQLView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabSQL;
        private System.Windows.Forms.TabPage tabSQLConnection;
        private System.Windows.Forms.TabPage tabSQLView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKonyvNev;
        private System.Windows.Forms.Button btnList;
    }
}

