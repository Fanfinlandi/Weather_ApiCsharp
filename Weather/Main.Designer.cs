namespace Weather
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            City = new TextBox();
            search = new Button();
            Info = new Label();
            SuspendLayout();
            // 
            // City
            // 
            City.Location = new Point(12, 133);
            City.Name = "City";
            City.PlaceholderText = "Wpisz Miasto";
            City.Size = new Size(132, 23);
            City.TabIndex = 0;
            // 
            // search
            // 
            search.Location = new Point(119, 312);
            search.Name = "search";
            search.Size = new Size(99, 33);
            search.TabIndex = 1;
            search.Text = "Szukaj";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(150, 136);
            Info.Name = "Info";
            Info.Size = new Size(38, 15);
            Info.TabIndex = 2;
            Info.Text = "label1";
            Info.Click += Info_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(Info);
            Controls.Add(search);
            Controls.Add(City);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Jaka dziś Pogoda?";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox City;
        private Button search;
        private Label Info;
    }
}
