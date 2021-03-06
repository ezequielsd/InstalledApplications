﻿namespace InstalledApplications
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnListarProgramasLocal = new System.Windows.Forms.Button();
            this.btnLanguagePTbr = new System.Windows.Forms.Button();
            this.btnLanguageEN = new System.Windows.Forms.Button();
            this.listViewProgramas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkSelecionarTudo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnListarProgramasLocal
            // 
            resources.ApplyResources(this.btnListarProgramasLocal, "btnListarProgramasLocal");
            this.btnListarProgramasLocal.Name = "btnListarProgramasLocal";
            this.btnListarProgramasLocal.UseVisualStyleBackColor = true;
            this.btnListarProgramasLocal.Click += new System.EventHandler(this.btnListarProgramasLocal_Click);
            // 
            // btnLanguagePTbr
            // 
            this.btnLanguagePTbr.Image = global::InstalledApplications.Properties.Resources.if_38_Ensign_Flag_Nation_brazil_2634471__1_;
            resources.ApplyResources(this.btnLanguagePTbr, "btnLanguagePTbr");
            this.btnLanguagePTbr.Name = "btnLanguagePTbr";
            this.btnLanguagePTbr.UseVisualStyleBackColor = true;
            this.btnLanguagePTbr.Click += new System.EventHandler(this.btnLanguagePTbr_Click);
            // 
            // btnLanguageEN
            // 
            this.btnLanguageEN.Image = global::InstalledApplications.Properties.Resources.if_273_Ensign_Flag_Nation_kingdom_2634450__1_;
            resources.ApplyResources(this.btnLanguageEN, "btnLanguageEN");
            this.btnLanguageEN.Name = "btnLanguageEN";
            this.btnLanguageEN.UseVisualStyleBackColor = true;
            this.btnLanguageEN.Click += new System.EventHandler(this.btnLanguageEN_Click);
            // 
            // listViewProgramas
            // 
            this.listViewProgramas.CheckBoxes = true;
            resources.ApplyResources(this.listViewProgramas, "listViewProgramas");
            this.listViewProgramas.Name = "listViewProgramas";
            this.listViewProgramas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cmbProfile
            // 
            this.cmbProfile.FormattingEnabled = true;
            resources.ApplyResources(this.cmbProfile, "cmbProfile");
            this.cmbProfile.Name = "cmbProfile";
            // 
            // btnCarregar
            // 
            resources.ApplyResources(this.btnCarregar, "btnCarregar");
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkSelecionarTudo
            // 
            resources.ApplyResources(this.chkSelecionarTudo, "chkSelecionarTudo");
            this.chkSelecionarTudo.Name = "chkSelecionarTudo";
            this.chkSelecionarTudo.UseVisualStyleBackColor = true;
            this.chkSelecionarTudo.CheckedChanged += new System.EventHandler(this.chkSelecionarTudo_CheckedChanged);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSelecionarTudo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.cmbProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProgramas);
            this.Controls.Add(this.btnLanguagePTbr);
            this.Controls.Add(this.btnLanguageEN);
            this.Controls.Add(this.btnListarProgramasLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListarProgramasLocal;
        private System.Windows.Forms.Button btnLanguageEN;
        private System.Windows.Forms.Button btnLanguagePTbr;
        private System.Windows.Forms.ListView listViewProgramas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkSelecionarTudo;
    }
}

