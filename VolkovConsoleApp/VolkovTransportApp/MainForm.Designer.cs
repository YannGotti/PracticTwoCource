namespace VolkovTransportApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectVehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.editVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.deleteVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sortAZButton = new System.Windows.Forms.ToolStripButton();
            this.sortZAButton = new System.Windows.Forms.ToolStripButton();
            this.selectVehicleButton = new System.Windows.Forms.ToolStripButton();
            this.reportButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.vehicleCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleslistBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.vehileMenuItem,
            this.actionsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.toolStripSeparator1,
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Image = global::VolkovTransportApp.Properties.Resources.открыть;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileMenuItem.Text = "Открыть";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Image = global::VolkovTransportApp.Properties.Resources.сохранить;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenuItem.Text = "Сохранить";
            this.saveFileMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeMenuItem.Text = "Закрыть";
            this.closeMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // vehileMenuItem
            // 
            this.vehileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleMenuItem,
            this.editVehicleMenuItem,
            this.deleteVehicleMenuItem});
            this.vehileMenuItem.Name = "vehileMenuItem";
            this.vehileMenuItem.Size = new System.Drawing.Size(150, 20);
            this.vehileMenuItem.Text = "Транспортное средство";
            // 
            // addVehicleMenuItem
            // 
            this.addVehicleMenuItem.Image = global::VolkovTransportApp.Properties.Resources.добавить;
            this.addVehicleMenuItem.Name = "addVehicleMenuItem";
            this.addVehicleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVehicleMenuItem.Text = "Добавить";
            this.addVehicleMenuItem.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // editVehicleMenuItem
            // 
            this.editVehicleMenuItem.Image = global::VolkovTransportApp.Properties.Resources.изменить;
            this.editVehicleMenuItem.Name = "editVehicleMenuItem";
            this.editVehicleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editVehicleMenuItem.Text = "Изменить";
            this.editVehicleMenuItem.Click += new System.EventHandler(this.EditVehicle_Click);
            // 
            // deleteVehicleMenuItem
            // 
            this.deleteVehicleMenuItem.Image = global::VolkovTransportApp.Properties.Resources.удалить;
            this.deleteVehicleMenuItem.Name = "deleteVehicleMenuItem";
            this.deleteVehicleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteVehicleMenuItem.Text = "Удалить";
            this.deleteVehicleMenuItem.Click += new System.EventHandler(this.DeleteVehicle_Click);
            // 
            // actionsMenuItem
            // 
            this.actionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortAZMenuItem,
            this.sortZAMenuItem,
            this.selectVehicleMenuItem,
            this.reportMenuItem});
            this.actionsMenuItem.Name = "actionsMenuItem";
            this.actionsMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actionsMenuItem.Text = "Действия";
            // 
            // sortAZMenuItem
            // 
            this.sortAZMenuItem.Image = global::VolkovTransportApp.Properties.Resources.сортировать_по_возрастанию;
            this.sortAZMenuItem.Name = "sortAZMenuItem";
            this.sortAZMenuItem.Size = new System.Drawing.Size(268, 22);
            this.sortAZMenuItem.Text = "Сортировка по возрастанию";
            this.sortAZMenuItem.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAMenuItem
            // 
            this.sortZAMenuItem.Image = global::VolkovTransportApp.Properties.Resources.сортировать_по_убыванию;
            this.sortZAMenuItem.Name = "sortZAMenuItem";
            this.sortZAMenuItem.Size = new System.Drawing.Size(268, 22);
            this.sortZAMenuItem.Text = "Сортировка по убыванию";
            this.sortZAMenuItem.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // selectVehicleMenuItem
            // 
            this.selectVehicleMenuItem.Image = global::VolkovTransportApp.Properties.Resources.отбор_транспортных_средств;
            this.selectVehicleMenuItem.Name = "selectVehicleMenuItem";
            this.selectVehicleMenuItem.Size = new System.Drawing.Size(268, 22);
            this.selectVehicleMenuItem.Text = "Отбор транспортных средств";
            this.selectVehicleMenuItem.Click += new System.EventHandler(this.SelectVehicle_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.Image = global::VolkovTransportApp.Properties.Resources.отчёт;
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(268, 22);
            this.reportMenuItem.Text = "Отчет по транспортным средствам";
            this.reportMenuItem.Click += new System.EventHandler(this.Report_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton,
            this.toolStripSeparator2,
            this.addVehicleButton,
            this.editVehicleButton,
            this.deleteVehicleButton,
            this.toolStripSeparator3,
            this.sortAZButton,
            this.sortZAButton,
            this.selectVehicleButton,
            this.reportButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(508, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = global::VolkovTransportApp.Properties.Resources.открыть;
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(23, 22);
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = global::VolkovTransportApp.Properties.Resources.сохранить;
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(23, 22);
            this.saveFileButton.Text = "Сохранить файл";
            this.saveFileButton.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addVehicleButton.Image = global::VolkovTransportApp.Properties.Resources.добавить;
            this.addVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.addVehicleButton.Text = "Добавить транспортное средство";
            this.addVehicleButton.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // editVehicleButton
            // 
            this.editVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editVehicleButton.Image = global::VolkovTransportApp.Properties.Resources.изменить;
            this.editVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editVehicleButton.Name = "editVehicleButton";
            this.editVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.editVehicleButton.Text = "Изменить транспортное средство";
            this.editVehicleButton.Click += new System.EventHandler(this.EditVehicle_Click);
            // 
            // deleteVehicleButton
            // 
            this.deleteVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteVehicleButton.Image = global::VolkovTransportApp.Properties.Resources.удалить;
            this.deleteVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteVehicleButton.Name = "deleteVehicleButton";
            this.deleteVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.deleteVehicleButton.Text = "Удалить транспортное средство";
            this.deleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // sortAZButton
            // 
            this.sortAZButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortAZButton.Image = global::VolkovTransportApp.Properties.Resources.сортировать_по_возрастанию;
            this.sortAZButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortAZButton.Name = "sortAZButton";
            this.sortAZButton.Size = new System.Drawing.Size(23, 22);
            this.sortAZButton.Text = "Сортировка транспортных средств по возрастанию";
            this.sortAZButton.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAButton
            // 
            this.sortZAButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortZAButton.Image = global::VolkovTransportApp.Properties.Resources.сортировать_по_убыванию;
            this.sortZAButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortZAButton.Name = "sortZAButton";
            this.sortZAButton.Size = new System.Drawing.Size(23, 22);
            this.sortZAButton.Text = "Сортировка транспортных средств по убыванию";
            this.sortZAButton.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // selectVehicleButton
            // 
            this.selectVehicleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectVehicleButton.Image = global::VolkovTransportApp.Properties.Resources.отбор_транспортных_средств;
            this.selectVehicleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectVehicleButton.Name = "selectVehicleButton";
            this.selectVehicleButton.Size = new System.Drawing.Size(23, 22);
            this.selectVehicleButton.Text = "Отбор транспортных средств";
            this.selectVehicleButton.Click += new System.EventHandler(this.SelectVehicle_Click);
            // 
            // reportButton
            // 
            this.reportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportButton.Image = global::VolkovTransportApp.Properties.Resources.отчёт;
            this.reportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(23, 22);
            this.reportButton.Text = "Отчет по транспортным средствам";
            this.reportButton.Click += new System.EventHandler(this.Report_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(508, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // vehicleCountStatusLabel
            // 
            this.vehicleCountStatusLabel.Name = "vehicleCountStatusLabel";
            this.vehicleCountStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.vehicleslistBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 270);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Транстпортные средства";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(169, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Положение транспортных средств";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vehicleslistBox1
            // 
            this.vehicleslistBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleslistBox1.FormattingEnabled = true;
            this.vehicleslistBox1.Location = new System.Drawing.Point(3, 23);
            this.vehicleslistBox1.Name = "vehicleslistBox1";
            this.vehicleslistBox1.Size = new System.Drawing.Size(160, 244);
            this.vehicleslistBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Транспортные средства";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectVehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addVehicleButton;
        private System.Windows.Forms.ToolStripButton editVehicleButton;
        private System.Windows.Forms.ToolStripButton deleteVehicleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton sortAZButton;
        private System.Windows.Forms.ToolStripButton sortZAButton;
        private System.Windows.Forms.ToolStripButton selectVehicleButton;
        private System.Windows.Forms.ToolStripButton reportButton;
        private System.Windows.Forms.ToolStripStatusLabel vehicleCountStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox vehicleslistBox1;
    }
}

