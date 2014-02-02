using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConvertToF3i18n {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btConvert_Click(object sender, EventArgs e) {
			if (txtStrings.Text.Trim() == "") return;

			var strings = txtStrings.Text.Trim();
			txtStrings.Text = "";
			string[] lines = strings.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
			var list = new List<string>(lines);
			var sortedByLength = from s in list
						 orderby s.Length descending 
						 select s;

			var count = 0; // Used in case of dupe
			foreach (var line in sortedByLength) {
				if (line.Trim() == "") continue;
				if (line.StartsWith(";")) {
					txtStrings.Text += line + "\r\n";
					continue;
				}
				var clean = MakeVariableName(line);
				if (txtStrings.Text.Contains("\n" + clean + "=")) clean = clean + count;
				txtStrings.Text += clean + @"=" + line.Replace('=',':') + "\r\n";
				count++;
			}

		}

		private static string MakeVariableName(string line) {
			var clean = Regex.Replace(line, @"[^\w]", "_"); 
			clean = clean.ToLower();
			if (!Char.IsLetter(clean.FirstOrDefault())) clean = "v_" + clean;
			return clean;
		}

		private void btReplace_Click(object sender, EventArgs e) {
			if (txtScript.Text.Trim() == "") return;
			if (txtStrings.Text.Trim() == "") return;
			var strings = txtStrings.Text.Trim();

			string[] stringlines = strings.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
			var replaceArray = new ArrayList();
			foreach (var line in stringlines) {		
				string[] lineSplitter = line.Split('=');
				if (lineSplitter.Length <= 1) continue;

				if (!txtScript.Text.Contains(lineSplitter[1])) continue;

				var variable = "{{ @" + lineSplitter[0] + " }}";
				replaceArray.Add(variable);
				
				txtScript.Text = txtScript.Text.Replace(lineSplitter[1], variable);
			}

			foreach (var replace in replaceArray) {
				HighlightText((string)replace, Color.Yellow);
			}
		}

		private void HighlightText(string word, Color color) {
			int s_start = txtScript.SelectionStart, startIndex = 0, index;

			while ((index = txtScript.Text.IndexOf(word, startIndex, System.StringComparison.Ordinal)) != -1) {
				txtScript.Select(index, word.Length);
				txtScript.SelectionBackColor = color;

				startIndex = index + word.Length;
			}

			txtScript.SelectionStart = s_start;
			txtScript.SelectionLength = 0;
			txtScript.SelectionBackColor = Color.White;
		}


		private void btAdd_Click(object sender, EventArgs e) {
			// Create an instance of the open file dialog box.
			var openFileDialog1 = new OpenFileDialog();

			// Set filter options and filter index.
			openFileDialog1.Filter = "Ini Files (.ini)|*.ini|Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;

			var dialogResult = openFileDialog1.ShowDialog();
			if (dialogResult != DialogResult.OK) return;

			using (StreamWriter sw = File.AppendText(openFileDialog1.FileName)) {
				sw.WriteLine("\r\n" + txtStrings.Text.Trim());
			}

			var fileName = Path.GetFileName(openFileDialog1.FileName);

			MessageBox.Show("Added conversions to " + fileName + ".", "Success");

		}

		private void btClearStrings_Click(object sender, EventArgs e) {
			txtStrings.Text = "";
		}

		private void btClearScript_Click(object sender, EventArgs e) {
			txtScript.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e) {
			txtStrings.SelectionStart = txtStrings.Text.Length;
			ActiveControl = txtStrings;
		}

	}
}
