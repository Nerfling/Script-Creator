namespace Script_Creator
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.TXT_AGENDA = new System.Windows.Forms.TextBox();
            this.TXT_NAAM = new System.Windows.Forms.TextBox();
            this.COMBO_RIGHTS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_TOEVOEGEN = new System.Windows.Forms.Button();
            this.BTN_GENERATE = new System.Windows.Forms.Button();
            this.RTB_TEMPLATE = new System.Windows.Forms.RichTextBox();
            this.RTB_SCRIPT = new System.Windows.Forms.RichTextBox();
            this.BTN_SAVE_SCRIPT = new System.Windows.Forms.Button();
            this.BTN_NEW_SCRIPT = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_CLIPBOARD = new System.Windows.Forms.Button();
            this.CHECK_NOTICE_CLIPBOARD = new System.Windows.Forms.CheckBox();
            this.BTN_IMPORT = new System.Windows.Forms.Button();
            this.BTN_IMPORT_AGENDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_AGENDA
            // 
            this.TXT_AGENDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TXT_AGENDA.Location = new System.Drawing.Point(110, 6);
            this.TXT_AGENDA.Name = "TXT_AGENDA";
            this.TXT_AGENDA.Size = new System.Drawing.Size(376, 20);
            this.TXT_AGENDA.TabIndex = 0;
            // 
            // TXT_NAAM
            // 
            this.TXT_NAAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXT_NAAM.Location = new System.Drawing.Point(110, 32);
            this.TXT_NAAM.Name = "TXT_NAAM";
            this.TXT_NAAM.Size = new System.Drawing.Size(376, 20);
            this.TXT_NAAM.TabIndex = 1;
            // 
            // COMBO_RIGHTS
            // 
            this.COMBO_RIGHTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.COMBO_RIGHTS.FormattingEnabled = true;
            this.COMBO_RIGHTS.Items.AddRange(new object[] {
            "None",
            "Owner",
            "PublishingEditor",
            "Editor",
            "PublishingAuthor",
            "Author",
            "NonEditingAuthor",
            "Reviewer",
            "Contributor"});
            this.COMBO_RIGHTS.Location = new System.Drawing.Point(110, 56);
            this.COMBO_RIGHTS.Name = "COMBO_RIGHTS";
            this.COMBO_RIGHTS.Size = new System.Drawing.Size(511, 21);
            this.COMBO_RIGHTS.TabIndex = 4;
            this.COMBO_RIGHTS.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agenda Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gebruiker Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rechten:";
            // 
            // BTN_TOEVOEGEN
            // 
            this.BTN_TOEVOEGEN.Location = new System.Drawing.Point(15, 83);
            this.BTN_TOEVOEGEN.Name = "BTN_TOEVOEGEN";
            this.BTN_TOEVOEGEN.Size = new System.Drawing.Size(606, 23);
            this.BTN_TOEVOEGEN.TabIndex = 9;
            this.BTN_TOEVOEGEN.Text = "Toepassen...";
            this.BTN_TOEVOEGEN.UseVisualStyleBackColor = true;
            this.BTN_TOEVOEGEN.Click += new System.EventHandler(this.BTN_TOEVOEGEN_Click);
            // 
            // BTN_GENERATE
            // 
            this.BTN_GENERATE.Location = new System.Drawing.Point(15, 473);
            this.BTN_GENERATE.Name = "BTN_GENERATE";
            this.BTN_GENERATE.Size = new System.Drawing.Size(606, 23);
            this.BTN_GENERATE.TabIndex = 10;
            this.BTN_GENERATE.Text = "Toevoegen aan script...";
            this.BTN_GENERATE.UseVisualStyleBackColor = true;
            this.BTN_GENERATE.Click += new System.EventHandler(this.BTN_GENERATE_Click);
            // 
            // RTB_TEMPLATE
            // 
            this.RTB_TEMPLATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RTB_TEMPLATE.DetectUrls = false;
            this.RTB_TEMPLATE.ForeColor = System.Drawing.Color.White;
            this.RTB_TEMPLATE.Location = new System.Drawing.Point(15, 168);
            this.RTB_TEMPLATE.Name = "RTB_TEMPLATE";
            this.RTB_TEMPLATE.Size = new System.Drawing.Size(606, 299);
            this.RTB_TEMPLATE.TabIndex = 11;
            this.RTB_TEMPLATE.Text = "";
            // 
            // RTB_SCRIPT
            // 
            this.RTB_SCRIPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RTB_SCRIPT.DetectUrls = false;
            this.RTB_SCRIPT.ForeColor = System.Drawing.Color.White;
            this.RTB_SCRIPT.Location = new System.Drawing.Point(627, 141);
            this.RTB_SCRIPT.Name = "RTB_SCRIPT";
            this.RTB_SCRIPT.Size = new System.Drawing.Size(606, 326);
            this.RTB_SCRIPT.TabIndex = 12;
            this.RTB_SCRIPT.Text = "";
            // 
            // BTN_SAVE_SCRIPT
            // 
            this.BTN_SAVE_SCRIPT.Location = new System.Drawing.Point(627, 473);
            this.BTN_SAVE_SCRIPT.Name = "BTN_SAVE_SCRIPT";
            this.BTN_SAVE_SCRIPT.Size = new System.Drawing.Size(305, 23);
            this.BTN_SAVE_SCRIPT.TabIndex = 13;
            this.BTN_SAVE_SCRIPT.Text = "Script opslagen...";
            this.BTN_SAVE_SCRIPT.UseVisualStyleBackColor = true;
            this.BTN_SAVE_SCRIPT.Click += new System.EventHandler(this.BTN_SAVE_SCRIPT_Click);
            // 
            // BTN_NEW_SCRIPT
            // 
            this.BTN_NEW_SCRIPT.Location = new System.Drawing.Point(627, 112);
            this.BTN_NEW_SCRIPT.Name = "BTN_NEW_SCRIPT";
            this.BTN_NEW_SCRIPT.Size = new System.Drawing.Size(606, 23);
            this.BTN_NEW_SCRIPT.TabIndex = 14;
            this.BTN_NEW_SCRIPT.Text = "Nieuw Script...";
            this.BTN_NEW_SCRIPT.UseVisualStyleBackColor = true;
            this.BTN_NEW_SCRIPT.Click += new System.EventHandler(this.BTN_NEW_SCRIPT_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.Location = new System.Drawing.Point(15, 112);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(606, 23);
            this.BTN_NEW.TabIndex = 15;
            this.BTN_NEW.Text = "Nieuw...";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // BTN_CLIPBOARD
            // 
            this.BTN_CLIPBOARD.Location = new System.Drawing.Point(938, 473);
            this.BTN_CLIPBOARD.Name = "BTN_CLIPBOARD";
            this.BTN_CLIPBOARD.Size = new System.Drawing.Size(295, 23);
            this.BTN_CLIPBOARD.TabIndex = 16;
            this.BTN_CLIPBOARD.Text = "Kopiëer naar klembord...";
            this.BTN_CLIPBOARD.UseVisualStyleBackColor = true;
            this.BTN_CLIPBOARD.Click += new System.EventHandler(this.BTN_CLIPBOARD_Click);
            // 
            // CHECK_NOTICE_CLIPBOARD
            // 
            this.CHECK_NOTICE_CLIPBOARD.AutoSize = true;
            this.CHECK_NOTICE_CLIPBOARD.Location = new System.Drawing.Point(627, 89);
            this.CHECK_NOTICE_CLIPBOARD.Name = "CHECK_NOTICE_CLIPBOARD";
            this.CHECK_NOTICE_CLIPBOARD.Size = new System.Drawing.Size(379, 17);
            this.CHECK_NOTICE_CLIPBOARD.TabIndex = 17;
            this.CHECK_NOTICE_CLIPBOARD.Text = "Geef een melding weer wanneer het script naar het klembord is gekopiëerd";
            this.CHECK_NOTICE_CLIPBOARD.UseVisualStyleBackColor = true;
            // 
            // BTN_IMPORT
            // 
            this.BTN_IMPORT.Location = new System.Drawing.Point(492, 30);
            this.BTN_IMPORT.Name = "BTN_IMPORT";
            this.BTN_IMPORT.Size = new System.Drawing.Size(129, 23);
            this.BTN_IMPORT.TabIndex = 18;
            this.BTN_IMPORT.Text = "Importeer gebruikers...";
            this.BTN_IMPORT.UseVisualStyleBackColor = true;
            this.BTN_IMPORT.Click += new System.EventHandler(this.BTN_IMPORT_Click);
            // 
            // BTN_IMPORT_AGENDA
            // 
            this.BTN_IMPORT_AGENDA.Location = new System.Drawing.Point(492, 6);
            this.BTN_IMPORT_AGENDA.Name = "BTN_IMPORT_AGENDA";
            this.BTN_IMPORT_AGENDA.Size = new System.Drawing.Size(129, 23);
            this.BTN_IMPORT_AGENDA.TabIndex = 19;
            this.BTN_IMPORT_AGENDA.Text = "Importeer agenda\'s...";
            this.BTN_IMPORT_AGENDA.UseVisualStyleBackColor = true;
            this.BTN_IMPORT_AGENDA.Click += new System.EventHandler(this.BTN_IMPORT_AGENDA_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 501);
            this.Controls.Add(this.BTN_IMPORT_AGENDA);
            this.Controls.Add(this.BTN_IMPORT);
            this.Controls.Add(this.CHECK_NOTICE_CLIPBOARD);
            this.Controls.Add(this.BTN_CLIPBOARD);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.BTN_NEW_SCRIPT);
            this.Controls.Add(this.BTN_SAVE_SCRIPT);
            this.Controls.Add(this.RTB_SCRIPT);
            this.Controls.Add(this.RTB_TEMPLATE);
            this.Controls.Add(this.BTN_GENERATE);
            this.Controls.Add(this.BTN_TOEVOEGEN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COMBO_RIGHTS);
            this.Controls.Add(this.TXT_NAAM);
            this.Controls.Add(this.TXT_AGENDA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_MAIN";
            this.Text = "Script Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_AGENDA;
        private System.Windows.Forms.TextBox TXT_NAAM;
        private System.Windows.Forms.ComboBox COMBO_RIGHTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_TOEVOEGEN;
        private System.Windows.Forms.Button BTN_GENERATE;
        private System.Windows.Forms.RichTextBox RTB_TEMPLATE;
        private System.Windows.Forms.RichTextBox RTB_SCRIPT;
        private System.Windows.Forms.Button BTN_SAVE_SCRIPT;
        private System.Windows.Forms.Button BTN_NEW_SCRIPT;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_CLIPBOARD;
        private System.Windows.Forms.CheckBox CHECK_NOTICE_CLIPBOARD;
        private System.Windows.Forms.Button BTN_IMPORT;
        private System.Windows.Forms.Button BTN_IMPORT_AGENDA;
    }
}

