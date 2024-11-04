namespace Executor
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnMinimise = new CodeeloUI.Controls.CodeeloButton();
            pnlStatus = new Panel();
            btnClose = new CodeeloUI.Controls.CodeeloButton();
            scriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            pictureBox1 = new PictureBox();
            brnKillRoblox = new CodeeloUI.Controls.CodeeloButton();
            Inject = new CodeeloUI.Controls.CodeeloButton();
            btnClear = new CodeeloUI.Controls.CodeeloButton();
            Execute = new CodeeloUI.Controls.CodeeloButton();
            btnPaste = new CodeeloUI.Controls.CodeeloButton();
            lbScripts = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scriptTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnMinimise);
            panel1.Controls.Add(pnlStatus);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 34);
            panel1.TabIndex = 3;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnMinimise
            // 
            btnMinimise.AccessibleRole = null;
            btnMinimise.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMinimise.BackColor = Color.Transparent;
            btnMinimise.BorderColor_1 = Color.Transparent;
            btnMinimise.BorderColor_2 = Color.Transparent;
            btnMinimise.BorderRadius = 10;
            btnMinimise.BorderSize = 3;
            btnMinimise.CausesValidation = false;
            btnMinimise.ColorFill_1 = Color.FromArgb(50, 50, 50);
            btnMinimise.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnMinimise.DialogResult = false;
            btnMinimise.DrawTextShadow = true;
            btnMinimise.FlatAppearance.BorderSize = 0;
            btnMinimise.FlatStyle = FlatStyle.Flat;
            btnMinimise.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimise.ForeColor = Color.WhiteSmoke;
            btnMinimise.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnMinimise.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnMinimise.Location = new Point(723, 5);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.OnClick_BorderColor_1 = Color.Transparent;
            btnMinimise.OnClick_BorderColor_2 = Color.Transparent;
            btnMinimise.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnMinimise.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnMinimise.OnOver_BorderColor_1 = Color.Transparent;
            btnMinimise.OnOver_BorderColor_2 = Color.Transparent;
            btnMinimise.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnMinimise.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnMinimise.Size = new Size(37, 26);
            btnMinimise.TabIndex = 12;
            btnMinimise.TabStop = false;
            btnMinimise.Text = "-";
            btnMinimise.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnMinimise.UseMnemonic = false;
            btnMinimise.UseVisualStyleBackColor = false;
            btnMinimise.Click += btnMinimise_Click_1;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.Brown;
            pnlStatus.Location = new Point(12, 14);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(73, 10);
            pnlStatus.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.AccessibleRole = null;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderColor_1 = Color.Transparent;
            btnClose.BorderColor_2 = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.BorderSize = 3;
            btnClose.CausesValidation = false;
            btnClose.ColorFill_1 = Color.FromArgb(50, 50, 50);
            btnClose.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnClose.DialogResult = false;
            btnClose.DrawTextShadow = true;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClose.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClose.Location = new Point(763, 5);
            btnClose.Name = "btnClose";
            btnClose.OnClick_BorderColor_1 = Color.Transparent;
            btnClose.OnClick_BorderColor_2 = Color.Transparent;
            btnClose.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnClose.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnClose.OnOver_BorderColor_1 = Color.Transparent;
            btnClose.OnOver_BorderColor_2 = Color.Transparent;
            btnClose.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnClose.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnClose.Size = new Size(34, 26);
            btnClose.TabIndex = 11;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnClose.UseMnemonic = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // scriptTextBox
            // 
            scriptTextBox.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            scriptTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            scriptTextBox.AutoScrollMinSize = new Size(187, 21);
            scriptTextBox.BackBrush = null;
            scriptTextBox.BackColor = Color.FromArgb(50, 50, 50);
            scriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            scriptTextBox.CharHeight = 21;
            scriptTextBox.CharWidth = 11;
            scriptTextBox.CommentPrefix = "--";
            scriptTextBox.DefaultMarkerSize = 8;
            scriptTextBox.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            scriptTextBox.FoldingIndicatorColor = Color.LimeGreen;
            scriptTextBox.Font = new Font("Courier New", 14.25F);
            scriptTextBox.ForeColor = SystemColors.Control;
            scriptTextBox.Hotkeys = resources.GetString("scriptTextBox.Hotkeys");
            scriptTextBox.IndentBackColor = Color.FromArgb(40, 40, 40);
            scriptTextBox.IsReplaceMode = false;
            scriptTextBox.Language = FastColoredTextBoxNS.Language.JSON;
            scriptTextBox.LeftBracket = '[';
            scriptTextBox.LeftBracket2 = '{';
            scriptTextBox.LineNumberColor = Color.White;
            scriptTextBox.Location = new Point(12, 38);
            scriptTextBox.Name = "scriptTextBox";
            scriptTextBox.Paddings = new Padding(0);
            scriptTextBox.RightBracket = ']';
            scriptTextBox.RightBracket2 = '}';
            scriptTextBox.SelectionColor = Color.FromArgb(60, 255, 255, 255);
            scriptTextBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("scriptTextBox.ServiceColors");
            scriptTextBox.Size = new Size(649, 343);
            scriptTextBox.TabIndex = 5;
            scriptTextBox.Text = "print(1231231)";
            scriptTextBox.Zoom = 100;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(667, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // brnKillRoblox
            // 
            brnKillRoblox.AccessibleRole = null;
            brnKillRoblox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            brnKillRoblox.BackColor = Color.Transparent;
            brnKillRoblox.BorderColor_1 = Color.Transparent;
            brnKillRoblox.BorderColor_2 = Color.Transparent;
            brnKillRoblox.BorderRadius = 10;
            brnKillRoblox.BorderSize = 3;
            brnKillRoblox.CausesValidation = false;
            brnKillRoblox.ColorFill_1 = Color.FromArgb(50, 50, 50);
            brnKillRoblox.ColorFill_2 = Color.FromArgb(159, 185, 189);
            brnKillRoblox.DialogResult = false;
            brnKillRoblox.DrawTextShadow = true;
            brnKillRoblox.FlatAppearance.BorderSize = 0;
            brnKillRoblox.FlatStyle = FlatStyle.Flat;
            brnKillRoblox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brnKillRoblox.ForeColor = Color.WhiteSmoke;
            brnKillRoblox.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            brnKillRoblox.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            brnKillRoblox.Location = new Point(548, 388);
            brnKillRoblox.Name = "brnKillRoblox";
            brnKillRoblox.OnClick_BorderColor_1 = Color.Transparent;
            brnKillRoblox.OnClick_BorderColor_2 = Color.Transparent;
            brnKillRoblox.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            brnKillRoblox.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            brnKillRoblox.OnOver_BorderColor_1 = Color.Transparent;
            brnKillRoblox.OnOver_BorderColor_2 = Color.Transparent;
            brnKillRoblox.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            brnKillRoblox.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            brnKillRoblox.Size = new Size(113, 36);
            brnKillRoblox.TabIndex = 7;
            brnKillRoblox.TabStop = false;
            brnKillRoblox.Text = "Kill Roblox";
            brnKillRoblox.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            brnKillRoblox.UseMnemonic = false;
            brnKillRoblox.UseVisualStyleBackColor = false;
            brnKillRoblox.Click += brnKillRoblox_Click;
            // 
            // Inject
            // 
            Inject.AccessibleRole = null;
            Inject.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Inject.BackColor = Color.Transparent;
            Inject.BorderColor_1 = Color.Transparent;
            Inject.BorderColor_2 = Color.Transparent;
            Inject.BorderRadius = 10;
            Inject.BorderSize = 3;
            Inject.CausesValidation = false;
            Inject.ColorFill_1 = Color.FromArgb(50, 50, 50);
            Inject.ColorFill_2 = Color.FromArgb(159, 185, 189);
            Inject.DialogResult = false;
            Inject.DrawTextShadow = true;
            Inject.FlatAppearance.BorderSize = 0;
            Inject.FlatStyle = FlatStyle.Flat;
            Inject.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Inject.ForeColor = Color.WhiteSmoke;
            Inject.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            Inject.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            Inject.Location = new Point(667, 386);
            Inject.Name = "Inject";
            Inject.OnClick_BorderColor_1 = Color.Transparent;
            Inject.OnClick_BorderColor_2 = Color.Transparent;
            Inject.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            Inject.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            Inject.OnOver_BorderColor_1 = Color.Transparent;
            Inject.OnOver_BorderColor_2 = Color.Transparent;
            Inject.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            Inject.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            Inject.Size = new Size(130, 37);
            Inject.TabIndex = 8;
            Inject.TabStop = false;
            Inject.Text = "Inject";
            Inject.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            Inject.UseMnemonic = false;
            Inject.UseVisualStyleBackColor = false;
            Inject.Click += Inject_Click_1;
            // 
            // btnClear
            // 
            btnClear.AccessibleRole = null;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.BackColor = Color.Transparent;
            btnClear.BorderColor_1 = Color.Transparent;
            btnClear.BorderColor_2 = Color.Transparent;
            btnClear.BorderRadius = 10;
            btnClear.BorderSize = 3;
            btnClear.CausesValidation = false;
            btnClear.ColorFill_1 = Color.FromArgb(50, 50, 50);
            btnClear.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnClear.DialogResult = false;
            btnClear.DrawTextShadow = true;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClear.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClear.Location = new Point(121, 386);
            btnClear.Name = "btnClear";
            btnClear.OnClick_BorderColor_1 = Color.Transparent;
            btnClear.OnClick_BorderColor_2 = Color.Transparent;
            btnClear.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnClear.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnClear.OnOver_BorderColor_1 = Color.Transparent;
            btnClear.OnOver_BorderColor_2 = Color.Transparent;
            btnClear.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnClear.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnClear.Size = new Size(103, 37);
            btnClear.TabIndex = 9;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnClear.UseMnemonic = false;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // Execute
            // 
            Execute.AccessibleRole = null;
            Execute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Execute.BackColor = Color.Transparent;
            Execute.BorderColor_1 = Color.Transparent;
            Execute.BorderColor_2 = Color.Transparent;
            Execute.BorderRadius = 10;
            Execute.BorderSize = 3;
            Execute.CausesValidation = false;
            Execute.ColorFill_1 = Color.FromArgb(50, 50, 50);
            Execute.ColorFill_2 = Color.FromArgb(159, 185, 189);
            Execute.DialogResult = false;
            Execute.DrawTextShadow = true;
            Execute.FlatAppearance.BorderSize = 0;
            Execute.FlatStyle = FlatStyle.Flat;
            Execute.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Execute.ForeColor = Color.WhiteSmoke;
            Execute.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            Execute.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            Execute.Location = new Point(12, 387);
            Execute.Name = "Execute";
            Execute.OnClick_BorderColor_1 = Color.Transparent;
            Execute.OnClick_BorderColor_2 = Color.Transparent;
            Execute.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            Execute.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            Execute.OnOver_BorderColor_1 = Color.Transparent;
            Execute.OnOver_BorderColor_2 = Color.Transparent;
            Execute.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            Execute.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            Execute.Size = new Size(103, 37);
            Execute.TabIndex = 10;
            Execute.TabStop = false;
            Execute.Text = "Execute";
            Execute.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            Execute.UseMnemonic = false;
            Execute.UseVisualStyleBackColor = false;
            Execute.Click += Execute_Click_1;
            // 
            // btnPaste
            // 
            btnPaste.AccessibleRole = null;
            btnPaste.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaste.BackColor = Color.Transparent;
            btnPaste.BorderColor_1 = Color.Transparent;
            btnPaste.BorderColor_2 = Color.Transparent;
            btnPaste.BorderRadius = 10;
            btnPaste.BorderSize = 3;
            btnPaste.CausesValidation = false;
            btnPaste.ColorFill_1 = Color.FromArgb(50, 50, 50);
            btnPaste.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnPaste.DialogResult = false;
            btnPaste.DrawTextShadow = true;
            btnPaste.FlatAppearance.BorderSize = 0;
            btnPaste.FlatStyle = FlatStyle.Flat;
            btnPaste.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaste.ForeColor = Color.WhiteSmoke;
            btnPaste.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnPaste.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnPaste.Location = new Point(230, 386);
            btnPaste.Name = "btnPaste";
            btnPaste.OnClick_BorderColor_1 = Color.Transparent;
            btnPaste.OnClick_BorderColor_2 = Color.Transparent;
            btnPaste.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnPaste.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnPaste.OnOver_BorderColor_1 = Color.Transparent;
            btnPaste.OnOver_BorderColor_2 = Color.Transparent;
            btnPaste.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnPaste.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnPaste.Size = new Size(103, 37);
            btnPaste.TabIndex = 11;
            btnPaste.TabStop = false;
            btnPaste.Text = "Paste";
            btnPaste.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnPaste.UseMnemonic = false;
            btnPaste.UseVisualStyleBackColor = false;
            btnPaste.Click += btnPaste_Click;
            // 
            // lbScripts
            // 
            lbScripts.BackColor = Color.FromArgb(50, 50, 50);
            lbScripts.BorderStyle = BorderStyle.None;
            lbScripts.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbScripts.ForeColor = SystemColors.Window;
            lbScripts.FormattingEnabled = true;
            lbScripts.Location = new Point(667, 173);
            lbScripts.Name = "lbScripts";
            lbScripts.Size = new Size(130, 208);
            lbScripts.TabIndex = 12;
            lbScripts.MouseDoubleClick += lbScripts_MouseDoubleClick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 435);
            Controls.Add(lbScripts);
            Controls.Add(btnPaste);
            Controls.Add(Execute);
            Controls.Add(btnClear);
            Controls.Add(Inject);
            Controls.Add(brnKillRoblox);
            Controls.Add(pictureBox1);
            Controls.Add(scriptTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scriptTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel pnlStatus;
        private FastColoredTextBoxNS.FastColoredTextBox scriptTextBox;
        private PictureBox pictureBox1;
        private CodeeloUI.Controls.CodeeloButton brnKillRoblox;
        private CodeeloUI.Controls.CodeeloButton Inject;
        private CodeeloUI.Controls.CodeeloButton btnClear;
        private CodeeloUI.Controls.CodeeloButton Execute;
        private CodeeloUI.Controls.CodeeloButton btnClose;
        private CodeeloUI.Controls.CodeeloButton btnMinimise;
        private CodeeloUI.Controls.CodeeloButton btnPaste;
        private ListBox lbScripts;
        private System.Windows.Forms.Timer timer1;
    }
}
