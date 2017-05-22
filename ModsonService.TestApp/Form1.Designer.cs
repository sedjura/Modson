namespace ModsonService.TestApp
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
            this._loadDataBT = new DevExpress.XtraEditors.SimpleButton();
            this._serverTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._portTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this._userTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this._passwordTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this._dbNameTE = new DevExpress.XtraEditors.TextEdit();
            this._tableGC = new DevExpress.XtraGrid.GridControl();
            this._tableGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this._tableTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this._serverTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._portTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._userTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._passwordTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _loadDataBT
            // 
            this._loadDataBT.Location = new System.Drawing.Point(12, 387);
            this._loadDataBT.Name = "_loadDataBT";
            this._loadDataBT.Size = new System.Drawing.Size(145, 23);
            this._loadDataBT.TabIndex = 0;
            this._loadDataBT.Text = "Загрузить данные";
            this._loadDataBT.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // _serverTE
            // 
            this._serverTE.EditValue = "127.0.0.1";
            this._serverTE.Location = new System.Drawing.Point(97, 5);
            this._serverTE.Name = "_serverTE";
            this._serverTE.Size = new System.Drawing.Size(100, 20);
            this._serverTE.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Сервер";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(229, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Порт";
            // 
            // _portTE
            // 
            this._portTE.EditValue = "5432";
            this._portTE.Location = new System.Drawing.Point(286, 5);
            this._portTE.Name = "_portTE";
            this._portTE.Size = new System.Drawing.Size(100, 20);
            this._portTE.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Пользователь";
            // 
            // _userTE
            // 
            this._userTE.EditValue = "sedjura";
            this._userTE.Location = new System.Drawing.Point(97, 31);
            this._userTE.Name = "_userTE";
            this._userTE.Size = new System.Drawing.Size(100, 20);
            this._userTE.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(229, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Пароль";
            // 
            // _passwordTE
            // 
            this._passwordTE.EditValue = "crocodile";
            this._passwordTE.Location = new System.Drawing.Point(286, 31);
            this._passwordTE.Name = "_passwordTE";
            this._passwordTE.Properties.PasswordChar = '*';
            this._passwordTE.Size = new System.Drawing.Size(100, 20);
            this._passwordTE.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "База данных";
            // 
            // _dbNameTE
            // 
            this._dbNameTE.EditValue = "Modson";
            this._dbNameTE.Location = new System.Drawing.Point(97, 61);
            this._dbNameTE.Name = "_dbNameTE";
            this._dbNameTE.Size = new System.Drawing.Size(100, 20);
            this._dbNameTE.TabIndex = 9;
            // 
            // _tableGC
            // 
            this._tableGC.Location = new System.Drawing.Point(8, 96);
            this._tableGC.MainView = this._tableGV;
            this._tableGC.Name = "_tableGC";
            this._tableGC.Size = new System.Drawing.Size(894, 285);
            this._tableGC.TabIndex = 11;
            this._tableGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._tableGV});
            // 
            // _tableGV
            // 
            this._tableGV.GridControl = this._tableGC;
            this._tableGV.Name = "_tableGV";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(229, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Таблица";
            // 
            // _tableTE
            // 
            this._tableTE.EditValue = "users";
            this._tableTE.Location = new System.Drawing.Point(286, 61);
            this._tableTE.Name = "_tableTE";
            this._tableTE.Size = new System.Drawing.Size(100, 20);
            this._tableTE.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 422);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this._tableTE);
            this.Controls.Add(this._tableGC);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this._dbNameTE);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this._passwordTE);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this._userTE);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this._portTE);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this._serverTE);
            this.Controls.Add(this._loadDataBT);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._serverTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._portTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._userTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._passwordTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tableTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton _loadDataBT;
        private DevExpress.XtraEditors.TextEdit _serverTE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit _portTE;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit _userTE;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit _passwordTE;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit _dbNameTE;
        private DevExpress.XtraGrid.GridControl _tableGC;
        private DevExpress.XtraGrid.Views.Grid.GridView _tableGV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit _tableTE;
    }
}

