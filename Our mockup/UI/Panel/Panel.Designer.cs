using Our_mockup.Api;

namespace Our_mockup.UI.Panel
{
    partial class Panel
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
            this.menuBar1 = new Our_mockup.UI.MenuBar.MenuBarr(command);
            this.toolBar1 = new Our_mockup.UI.ToolBar.ToolBarr(command);
            this.statusBar1 = new Our_mockup.UI.StatusBar.StatusBar();
            this.plagins1 = new Our_mockup.UI.Plagins.Plagins(command);
            this.pDraw1 = new Our_mockup.UI.pDraw(command);
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.AutoScroll = true;
            this.menuBar1.BackColor = System.Drawing.Color.White;
            this.menuBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(808, 24);
            this.menuBar1.TabIndex = 0;
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar1.Location = new System.Drawing.Point(0, 24);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(808, 24);
            this.toolBar1.TabIndex = 1;
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.Color.White;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 425);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(808, 27);
            this.statusBar1.TabIndex = 2;
            // 
            // plagins1
            // 
            this.plagins1.BackColor = System.Drawing.Color.White;
            this.plagins1.Dock = System.Windows.Forms.DockStyle.Left;
            this.plagins1.Location = new System.Drawing.Point(0, 48);
            this.plagins1.Name = "plagins1";
            this.plagins1.Size = new System.Drawing.Size(148, 377);
            this.plagins1.TabIndex = 3;
            // 
            // pDraw1
            // 
            this.pDraw1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDraw1.BackColor = System.Drawing.Color.White;
            this.pDraw1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDraw1.Location = new System.Drawing.Point(148, 48);
            this.pDraw1.Name = "pDraw1";
            this.pDraw1.Size = new System.Drawing.Size(657, 377);
            this.pDraw1.TabIndex = 4;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pDraw1);
            this.Controls.Add(this.plagins1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menuBar1);
            this.Name = "Panel";
            this.Size = new System.Drawing.Size(808, 452);
            this.ResumeLayout(false);

        }

        #endregion

        public MenuBar.MenuBarr menuBar1;
        public ToolBar.ToolBarr toolBar1;
        public StatusBar.StatusBar statusBar1;
        public Plagins.Plagins plagins1;
        public pDraw pDraw1;
    }
}
