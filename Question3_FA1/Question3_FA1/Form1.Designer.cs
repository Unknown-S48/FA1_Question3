namespace Question3_FA1
{
    partial class frmFPL
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
            btnAdd = new Button();
            btnRemove = new Button();
            lblFeedback = new Label();
            txtInput = new TextBox();
            grpMain = new GroupBox();
            lstLanguages = new ListBox();
            grpMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(171, 231);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 33);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(30, 267);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 15);
            lblFeedback.TabIndex = 3;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(30, 202);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(492, 23);
            txtInput.TabIndex = 4;
            txtInput.Tag = "";
            // 
            // grpMain
            // 
            grpMain.Controls.Add(lstLanguages);
            grpMain.Controls.Add(btnAdd);
            grpMain.Controls.Add(txtInput);
            grpMain.Controls.Add(btnRemove);
            grpMain.Controls.Add(lblFeedback);
            grpMain.Location = new Point(83, 25);
            grpMain.Name = "grpMain";
            grpMain.Size = new Size(551, 301);
            grpMain.TabIndex = 6;
            grpMain.TabStop = false;
            grpMain.Text = "My Favourite Programming Languages";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(30, 42);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(492, 154);
            lstLanguages.TabIndex = 5;
            // 
            // frmFPL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 387);
            Controls.Add(grpMain);
            Name = "frmFPL";
            Text = "Favourite Programming Languages";
            grpMain.ResumeLayout(false);
            grpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnRemove;
        private Label lblFeedback;
        private TextBox txtInput;
        private GroupBox grpMain;
        private ListBox lstLanguages;
    }
}
