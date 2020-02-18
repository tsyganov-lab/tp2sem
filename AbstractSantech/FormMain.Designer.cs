namespace AbstractSantech
{
    partial class FormMain
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
            this.справочникиtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSpravochniki = new System.Windows.Forms.MenuStrip();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издлияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCr = new System.Windows.Forms.Button();
            this.buttonTk = new System.Windows.Forms.Button();
            this.buttonRd = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.menuStripSpravochniki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // справочникиtoolStripMenuItem1
            // 
            this.справочникиtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.издлияToolStripMenuItem});
            this.справочникиtoolStripMenuItem1.Name = "справочникиtoolStripMenuItem1";
            this.справочникиtoolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.справочникиtoolStripMenuItem1.Text = "Справочники";
            // 
            // menuStripSpravochniki
            // 
            this.menuStripSpravochniki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиtoolStripMenuItem1});
            this.menuStripSpravochniki.Location = new System.Drawing.Point(0, 0);
            this.menuStripSpravochniki.Name = "menuStripSpravochniki";
            this.menuStripSpravochniki.Size = new System.Drawing.Size(871, 24);
            this.menuStripSpravochniki.TabIndex = 0;
            this.menuStripSpravochniki.Text = "menuStripSpravochniki";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
            // 
            // издлияToolStripMenuItem
            // 
            this.издлияToolStripMenuItem.Name = "издлияToolStripMenuItem";
            this.издлияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издлияToolStripMenuItem.Text = "Изделия";
            this.издлияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 45);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(655, 252);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCr
            // 
            this.buttonCr.Location = new System.Drawing.Point(678, 63);
            this.buttonCr.Name = "buttonCr";
            this.buttonCr.Size = new System.Drawing.Size(181, 23);
            this.buttonCr.TabIndex = 2;
            this.buttonCr.Text = "Создать заказ";
            this.buttonCr.UseVisualStyleBackColor = true;
            this.buttonCr.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTk
            // 
            this.buttonTk.Location = new System.Drawing.Point(678, 109);
            this.buttonTk.Name = "buttonTk";
            this.buttonTk.Size = new System.Drawing.Size(181, 23);
            this.buttonTk.TabIndex = 3;
            this.buttonTk.Text = "Отдать на выполнение";
            this.buttonTk.UseVisualStyleBackColor = true;
            this.buttonTk.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonRd
            // 
            this.buttonRd.Location = new System.Drawing.Point(678, 155);
            this.buttonRd.Name = "buttonRd";
            this.buttonRd.Size = new System.Drawing.Size(181, 23);
            this.buttonRd.TabIndex = 4;
            this.buttonRd.Text = "Заказ готов";
            this.buttonRd.UseVisualStyleBackColor = true;
            this.buttonRd.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(678, 203);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(181, 23);
            this.buttonPay.TabIndex = 5;
            this.buttonPay.Text = "Заказ оплачен";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPayOrder_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(678, 253);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(181, 23);
            this.buttonRef.TabIndex = 6;
            this.buttonRef.Text = "Обновить список";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 313);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonRd);
            this.Controls.Add(this.buttonTk);
            this.Controls.Add(this.buttonCr);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStripSpravochniki);
            this.MainMenuStrip = this.menuStripSpravochniki;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStripSpravochniki.ResumeLayout(false);
            this.menuStripSpravochniki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.menuStripSpravochniki.SuspendLayout();
            this.SuspendLayout();
            // 
            // справочникиtoolStripMenuItem1
            // 
            this.справочникиtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.издлияToolStripMenuItem});
            this.справочникиtoolStripMenuItem1.Name = "справочникиtoolStripMenuItem1";
            this.справочникиtoolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.справочникиtoolStripMenuItem1.Text = "Справочники";
            // 
            // menuStripSpravochniki
            // 
            this.menuStripSpravochniki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиtoolStripMenuItem1});
            this.menuStripSpravochniki.Location = new System.Drawing.Point(0, 0);
            this.menuStripSpravochniki.Name = "menuStripSpravochniki";
            this.menuStripSpravochniki.Size = new System.Drawing.Size(800, 24);
            this.menuStripSpravochniki.TabIndex = 0;
            this.menuStripSpravochniki.Text = "menuStripSpravochniki";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // издлияToolStripMenuItem
            // 
            this.издлияToolStripMenuItem.Name = "издлияToolStripMenuItem";
            this.издлияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издлияToolStripMenuItem.Text = "Издлия";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripSpravochniki);
            this.MainMenuStrip = this.menuStripSpravochniki;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStripSpravochniki.ResumeLayout(false);
            this.menuStripSpravochniki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.menuStripSpravochniki.SuspendLayout();
            this.SuspendLayout();
            // 
            // справочникиtoolStripMenuItem1
            // 
            this.справочникиtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.издлияToolStripMenuItem});
            this.справочникиtoolStripMenuItem1.Name = "справочникиtoolStripMenuItem1";
            this.справочникиtoolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.справочникиtoolStripMenuItem1.Text = "Справочники";
            // 
            // menuStripSpravochniki
            // 
            this.menuStripSpravochniki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиtoolStripMenuItem1});
            this.menuStripSpravochniki.Location = new System.Drawing.Point(0, 0);
            this.menuStripSpravochniki.Name = "menuStripSpravochniki";
            this.menuStripSpravochniki.Size = new System.Drawing.Size(800, 24);
            this.menuStripSpravochniki.TabIndex = 0;
            this.menuStripSpravochniki.Text = "menuStrip1";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // издлияToolStripMenuItem
            // 
            this.издлияToolStripMenuItem.Name = "издлияToolStripMenuItem";
            this.издлияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издлияToolStripMenuItem.Text = "Издлия";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripSpravochniki);
            this.MainMenuStrip = this.menuStripSpravochniki;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStripSpravochniki.ResumeLayout(false);
            this.menuStripSpravochniki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // справочникиtoolStripMenuItem1
            // 
            this.справочникиtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.издлияToolStripMenuItem});
            this.справочникиtoolStripMenuItem1.Name = "справочникиtoolStripMenuItem1";
            this.справочникиtoolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.справочникиtoolStripMenuItem1.Text = "Справочники";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиtoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // издлияToolStripMenuItem
            // 
            this.издлияToolStripMenuItem.Name = "издлияToolStripMenuItem";
            this.издлияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издлияToolStripMenuItem.Text = "Издлия";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.издлияToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // издлияToolStripMenuItem
            // 
            this.издлияToolStripMenuItem.Name = "издлияToolStripMenuItem";
            this.издлияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.издлияToolStripMenuItem.Text = "Издлия";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 390);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "Абстрактный ремонт сантехники";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "Абстрактный ремонт сантехники";
            this.ResumeLayout(false);

        }

        #endregion
    }
}