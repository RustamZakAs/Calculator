namespace Calculator
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMIView = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonDev = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonPlas = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonRavno = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIView,
            this.TSMIEdit,
            this.TSMIHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(269, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // TSMIView
            // 
            this.TSMIView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.toolStripMenuItem2,
            this.TSMIHistory,
            this.toolStripMenuItem3,
            this.TSMIBasic});
            this.TSMIView.Name = "TSMIView";
            this.TSMIView.Size = new System.Drawing.Size(44, 19);
            this.TSMIView.Text = "View";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "-----------------------";
            // 
            // TSMIHistory
            // 
            this.TSMIHistory.Name = "TSMIHistory";
            this.TSMIHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.TSMIHistory.Size = new System.Drawing.Size(189, 22);
            this.TSMIHistory.Text = "History";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem3.Text = "-----------------------";
            // 
            // TSMIBasic
            // 
            this.TSMIBasic.Name = "TSMIBasic";
            this.TSMIBasic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.TSMIBasic.Size = new System.Drawing.Size(189, 22);
            this.TSMIBasic.Text = "Basic";
            // 
            // TSMIEdit
            // 
            this.TSMIEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.TSMIEdit.Name = "TSMIEdit";
            this.TSMIEdit.Size = new System.Drawing.Size(39, 19);
            this.TSMIEdit.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // TSMIHelp
            // 
            this.TSMIHelp.Name = "TSMIHelp";
            this.TSMIHelp.Size = new System.Drawing.Size(44, 19);
            this.TSMIHelp.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 272);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 272);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(8, 312);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(100, 36);
            this.buttonZero.TabIndex = 5;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 272);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 36);
            this.button4.TabIndex = 6;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 312);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = ",";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(112, 232);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(60, 232);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 36);
            this.button7.TabIndex = 9;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 232);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 36);
            this.button8.TabIndex = 8;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(112, 193);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 36);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(60, 193);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 36);
            this.button10.TabIndex = 12;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(8, 193);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 36);
            this.button11.TabIndex = 11;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonDev
            // 
            this.buttonDev.AutoEllipsis = true;
            this.buttonDev.CausesValidation = false;
            this.buttonDev.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(164, 193);
            this.buttonDev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(48, 36);
            this.buttonDev.TabIndex = 17;
            this.buttonDev.Text = "/";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.AutoEllipsis = true;
            this.buttonMultiply.CausesValidation = false;
            this.buttonMultiply.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(164, 232);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(48, 36);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonPlas
            // 
            this.buttonPlas.AutoEllipsis = true;
            this.buttonPlas.CausesValidation = false;
            this.buttonPlas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.buttonPlas.Location = new System.Drawing.Point(164, 312);
            this.buttonPlas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlas.Name = "buttonPlas";
            this.buttonPlas.Size = new System.Drawing.Size(48, 36);
            this.buttonPlas.TabIndex = 15;
            this.buttonPlas.Text = "+";
            this.buttonPlas.UseVisualStyleBackColor = true;
            this.buttonPlas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonMinus
            // 
            this.buttonMinus.AutoEllipsis = true;
            this.buttonMinus.CausesValidation = false;
            this.buttonMinus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(164, 272);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(48, 36);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // buttonRavno
            // 
            this.buttonRavno.AutoEllipsis = true;
            this.buttonRavno.CausesValidation = false;
            this.buttonRavno.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.buttonRavno.Location = new System.Drawing.Point(217, 272);
            this.buttonRavno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRavno.Name = "buttonRavno";
            this.buttonRavno.Size = new System.Drawing.Size(48, 76);
            this.buttonRavno.TabIndex = 18;
            this.buttonRavno.Text = "=";
            this.buttonRavno.UseVisualStyleBackColor = true;
            this.buttonRavno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // listBoxMain
            // 
            this.listBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 26;
            this.listBoxMain.Location = new System.Drawing.Point(8, 41);
            this.listBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxMain.Size = new System.Drawing.Size(257, 82);
            this.listBoxMain.TabIndex = 19;
            this.listBoxMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // textBoxMain
            // 
            this.textBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBoxMain.Location = new System.Drawing.Point(8, 121);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(257, 32);
            this.textBoxMain.TabIndex = 20;
            this.textBoxMain.Text = "0";
            this.textBoxMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSymbol.Location = new System.Drawing.Point(13, 46);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(28, 16);
            this.labelSymbol.TabIndex = 21;
            this.labelSymbol.Text = "     ";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(269, 351);
            this.Controls.Add(this.labelSymbol);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.buttonRavno);
            this.Controls.Add(this.buttonDev);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlas);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMIView;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMIHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TSMIBasic;
        private System.Windows.Forms.ToolStripMenuItem TSMIEdit;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonPlas;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonRavno;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Label labelSymbol;
    }
}

