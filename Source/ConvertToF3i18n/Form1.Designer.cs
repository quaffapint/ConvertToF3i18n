namespace ConvertToF3i18n {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btConvert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtStrings = new System.Windows.Forms.RichTextBox();
			this.txtScript = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btReplace = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btConvert
			// 
			this.btConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btConvert.Location = new System.Drawing.Point(485, 279);
			this.btConvert.Margin = new System.Windows.Forms.Padding(2);
			this.btConvert.Name = "btConvert";
			this.btConvert.Size = new System.Drawing.Size(75, 23);
			this.btConvert.TabIndex = 1;
			this.btConvert.Text = "Convert";
			this.btConvert.UseVisualStyleBackColor = true;
			this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 39);
			this.label1.TabIndex = 2;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// txtStrings
			// 
			this.txtStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStrings.Location = new System.Drawing.Point(26, 71);
			this.txtStrings.Margin = new System.Windows.Forms.Padding(2);
			this.txtStrings.Name = "txtStrings";
			this.txtStrings.Size = new System.Drawing.Size(626, 203);
			this.txtStrings.TabIndex = 3;
			this.txtStrings.Text = "";
			// 
			// txtScript
			// 
			this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtScript.Location = new System.Drawing.Point(31, 337);
			this.txtScript.Margin = new System.Windows.Forms.Padding(2);
			this.txtScript.Name = "txtScript";
			this.txtScript.Size = new System.Drawing.Size(626, 238);
			this.txtScript.TabIndex = 6;
			this.txtScript.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 309);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(415, 26);
			this.label2.TabIndex = 5;
			this.label2.Text = "Paste in your template file to replace each translated text with the {{ @variable" +
    "name }}.\r\nThis will use the conversions from the textbox above.";
			// 
			// btReplace
			// 
			this.btReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btReplace.Location = new System.Drawing.Point(577, 579);
			this.btReplace.Margin = new System.Windows.Forms.Padding(2);
			this.btReplace.Name = "btReplace";
			this.btReplace.Size = new System.Drawing.Size(75, 23);
			this.btReplace.TabIndex = 4;
			this.btReplace.Text = "Replace";
			this.btReplace.UseVisualStyleBackColor = true;
			this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
			// 
			// btAdd
			// 
			this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAdd.Location = new System.Drawing.Point(577, 279);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 7;
			this.btAdd.Text = "Add to File";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 609);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.txtScript);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btReplace);
			this.Controls.Add(this.txtStrings);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btConvert);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Convert to F3 i18n";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btConvert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox txtStrings;
		private System.Windows.Forms.RichTextBox txtScript;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btReplace;
		private System.Windows.Forms.Button btAdd;
	}
}

