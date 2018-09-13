namespace InstalledApplications
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLanguagePTbr = new System.Windows.Forms.Button();
            this.btnLanguageEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLanguagePTbr
            // 
            resources.ApplyResources(this.btnLanguagePTbr, "btnLanguagePTbr");
            this.btnLanguagePTbr.Image = global::InstalledApplications.Properties.Resources.if_38_Ensign_Flag_Nation_brazil_2634471__1_;
            this.btnLanguagePTbr.Name = "btnLanguagePTbr";
            this.btnLanguagePTbr.UseVisualStyleBackColor = true;
            this.btnLanguagePTbr.Click += new System.EventHandler(this.btnLanguagePTbr_Click);
            // 
            // btnLanguageEN
            // 
            resources.ApplyResources(this.btnLanguageEN, "btnLanguageEN");
            this.btnLanguageEN.Image = global::InstalledApplications.Properties.Resources.if_273_Ensign_Flag_Nation_kingdom_2634450__1_;
            this.btnLanguageEN.Name = "btnLanguageEN";
            this.btnLanguageEN.UseVisualStyleBackColor = true;
            this.btnLanguageEN.Click += new System.EventHandler(this.btnLanguageEN_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLanguagePTbr);
            this.Controls.Add(this.btnLanguageEN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLanguageEN;
        private System.Windows.Forms.Button btnLanguagePTbr;
    }
}

