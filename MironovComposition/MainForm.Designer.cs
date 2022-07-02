namespace MironovComposition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.анимацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateObject = new System.Windows.Forms.ToolStripMenuItem();
            this.addCube = new System.Windows.Forms.ToolStripMenuItem();
            this.addTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addCubeButton = new System.Windows.Forms.ToolStripButton();
            this.addTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ObjectsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deleteObject = new System.Windows.Forms.ToolStripButton();
            this.XLabel = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.YLabel = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.RotateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.rTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.gTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.submitButton = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadParamsAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.loadObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.saveObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas1 = new MironovComposition.Canvas();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анимацияToolStripMenuItem,
            this.фигурыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // анимацияToolStripMenuItem
            // 
            this.анимацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.остановитьToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.loadParamsAnimation});
            this.анимацияToolStripMenuItem.Name = "анимацияToolStripMenuItem";
            this.анимацияToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.анимацияToolStripMenuItem.Text = "Анимация";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.StartAnimation);
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.остановитьToolStripMenuItem.Text = "Остановить";
            this.остановитьToolStripMenuItem.Click += new System.EventHandler(this.StopAnimation);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateObject,
            this.loadObjects,
            this.saveObjects});
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // CreateObject
            // 
            this.CreateObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCube,
            this.addTriangle});
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(180, 22);
            this.CreateObject.Text = "Создать";
            // 
            // addCube
            // 
            this.addCube.Name = "addCube";
            this.addCube.Size = new System.Drawing.Size(144, 22);
            this.addCube.Text = "Квадрат";
            this.addCube.Click += new System.EventHandler(this.addCube_Click);
            // 
            // addTriangle
            // 
            this.addTriangle.Name = "addTriangle";
            this.addTriangle.Size = new System.Drawing.Size(144, 22);
            this.addTriangle.Text = "Треугольник";
            this.addTriangle.Click += new System.EventHandler(this.addTriangle_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Запустить";
            this.toolStripButton2.Click += new System.EventHandler(this.StartAnimation);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Остановить";
            this.toolStripButton3.Click += new System.EventHandler(this.StopAnimation);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addCubeButton
            // 
            this.addCubeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCubeButton.Image = ((System.Drawing.Image)(resources.GetObject("addCubeButton.Image")));
            this.addCubeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCubeButton.Name = "addCubeButton";
            this.addCubeButton.Size = new System.Drawing.Size(23, 22);
            this.addCubeButton.Text = "Добавить куб";
            this.addCubeButton.Click += new System.EventHandler(this.addCube_Click);
            // 
            // addTriangleButton
            // 
            this.addTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("addTriangleButton.Image")));
            this.addTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTriangleButton.Name = "addTriangleButton";
            this.addTriangleButton.Size = new System.Drawing.Size(23, 22);
            this.addTriangleButton.Text = "Добавить треугольник";
            this.addTriangleButton.Click += new System.EventHandler(this.addTriangle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 25);
            this.toolStripLabel1.Text = "Фигура:";
            // 
            // ObjectsComboBox
            // 
            this.ObjectsComboBox.Name = "ObjectsComboBox";
            this.ObjectsComboBox.Size = new System.Drawing.Size(121, 25);
            this.ObjectsComboBox.Text = "Куб";
            this.ObjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.ObjectsComboBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.addCubeButton,
            this.addTriangleButton,
            this.toolStripSeparator3,
            this.deleteObject,
            this.toolStripLabel1,
            this.ObjectsComboBox,
            this.XLabel,
            this.TextBoxX,
            this.YLabel,
            this.TextBoxY,
            this.toolStripLabel2,
            this.SizeTextBox,
            this.toolStripLabel3,
            this.RotateTextBox,
            this.toolStripLabel4,
            this.rTextBox,
            this.gTextBox,
            this.bTextBox,
            this.submitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1106, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deleteObject
            // 
            this.deleteObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteObject.Image = ((System.Drawing.Image)(resources.GetObject("deleteObject.Image")));
            this.deleteObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(23, 22);
            this.deleteObject.Text = "toolStripButton7";
            this.deleteObject.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // XLabel
            // 
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 22);
            this.XLabel.Text = "X:";
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(50, 25);
            // 
            // YLabel
            // 
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 22);
            this.YLabel.Text = "Y:";
            // 
            // TextBoxY
            // 
            this.TextBoxY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(50, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 25);
            this.toolStripLabel2.Text = "Масштаб:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(50, 25);
            this.SizeTextBox.Text = "100";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(58, 25);
            this.toolStripLabel3.Text = "Поворот:";
            // 
            // RotateTextBox
            // 
            this.RotateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RotateTextBox.Name = "RotateTextBox";
            this.RotateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RotateTextBox.Size = new System.Drawing.Size(50, 25);
            this.RotateTextBox.Text = "0";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(36, 25);
            this.toolStripLabel4.Text = "Цвет:";
            // 
            // rTextBox
            // 
            this.rTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(45, 25);
            this.rTextBox.Text = "145";
            // 
            // gTextBox
            // 
            this.gTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(45, 25);
            this.gTextBox.Text = "145";
            // 
            // bTextBox
            // 
            this.bTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(45, 25);
            this.bTextBox.Text = "145";
            // 
            // submitButton
            // 
            this.submitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.submitButton.Image = ((System.Drawing.Image)(resources.GetObject("submitButton.Image")));
            this.submitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(23, 22);
            this.submitButton.Text = "Применить";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 522);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1106, 19);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость анимации: ";
            // 
            // loadParamsAnimation
            // 
            this.loadParamsAnimation.Name = "loadParamsAnimation";
            this.loadParamsAnimation.Size = new System.Drawing.Size(193, 22);
            this.loadParamsAnimation.Text = "Загрузить параметры";
            // 
            // loadObjects
            // 
            this.loadObjects.Name = "loadObjects";
            this.loadObjects.Size = new System.Drawing.Size(180, 22);
            this.loadObjects.Text = "Загрузить";
            this.loadObjects.Click += new System.EventHandler(this.loadObjects_Click);
            // 
            // saveObjects
            // 
            this.saveObjects.Name = "saveObjects";
            this.saveObjects.Size = new System.Drawing.Size(180, 22);
            this.saveObjects.Text = "Сохранить";
            this.saveObjects.Click += new System.EventHandler(this.saveObjects_Click);
            // 
            // canvas1
            // 
            this.canvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas1.Location = new System.Drawing.Point(0, 49);
            this.canvas1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(1106, 473);
            this.canvas1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 541);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Миронов 2 задание практики";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem анимацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateObject;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addCubeButton;
        private System.Windows.Forms.ToolStripButton addTriangleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ObjectsComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox SizeTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox RotateTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox rTextBox;
        private System.Windows.Forms.ToolStripTextBox gTextBox;
        private System.Windows.Forms.ToolStripTextBox bTextBox;
        private Canvas canvas1;
        private System.Windows.Forms.ToolStripButton submitButton;
        private System.Windows.Forms.ToolStripLabel XLabel;
        private System.Windows.Forms.ToolStripTextBox TextBoxY;
        private System.Windows.Forms.ToolStripLabel YLabel;
        private System.Windows.Forms.ToolStripTextBox TextBoxX;
        private System.Windows.Forms.ToolStripMenuItem addCube;
        private System.Windows.Forms.ToolStripMenuItem addTriangle;
        private System.Windows.Forms.ToolStripButton deleteObject;
        private System.Windows.Forms.ToolStripMenuItem loadParamsAnimation;
        private System.Windows.Forms.ToolStripMenuItem loadObjects;
        private System.Windows.Forms.ToolStripMenuItem saveObjects;
    }
}

