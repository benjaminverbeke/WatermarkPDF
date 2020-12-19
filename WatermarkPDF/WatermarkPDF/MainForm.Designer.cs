namespace WatermarkPDF
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputPdfFolderBrowseButton = new System.Windows.Forms.Button();
            this.inputPdfFolderTextBox = new WatermarkPDF.CueTextBox();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.generateWatermarkedPdfButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.outputFolderBrowseButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new WatermarkPDF.CueTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.watermarkGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.watermarkTextLabel = new System.Windows.Forms.Label();
            this.watermarkTextBox = new WatermarkPDF.CueTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.watermarkDateLabel = new System.Windows.Forms.Label();
            this.addDatecheckBox = new System.Windows.Forms.CheckBox();
            this.dateToAddToWatermarkTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.watermarkColorLabel = new System.Windows.Forms.Label();
            this.watermarkColorTextBox = new WatermarkPDF.CueTextBox();
            this.watermarkColorPickerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.watermarkOpacityLabel = new System.Windows.Forms.Label();
            this.watermarkOpacityTextBox = new WatermarkPDF.CueTextBox();
            this.watermarkOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.watermarkOpacityPourcentLabel = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.watermarkPDFBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.foldersGroupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.watermarkGroupBox.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkOpacityTrackBar)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.inputPdfFolderBrowseButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputPdfFolderTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputFolderLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputPdfFolderBrowseButton
            // 
            this.inputPdfFolderBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPdfFolderBrowseButton.Location = new System.Drawing.Point(397, 3);
            this.inputPdfFolderBrowseButton.Name = "inputPdfFolderBrowseButton";
            this.inputPdfFolderBrowseButton.Size = new System.Drawing.Size(80, 20);
            this.inputPdfFolderBrowseButton.TabIndex = 1;
            this.inputPdfFolderBrowseButton.Text = "Browse";
            this.inputPdfFolderBrowseButton.UseVisualStyleBackColor = true;
            this.inputPdfFolderBrowseButton.Click += new System.EventHandler(this.inputPdfFolderBrowseButton_Click);
            // 
            // inputPdfFolderTextBox
            // 
            this.inputPdfFolderTextBox.Cue = "Select your PDF folder to watermark";
            this.inputPdfFolderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPdfFolderTextBox.Location = new System.Drawing.Point(132, 3);
            this.inputPdfFolderTextBox.Name = "inputPdfFolderTextBox";
            this.inputPdfFolderTextBox.Size = new System.Drawing.Size(259, 20);
            this.inputPdfFolderTextBox.TabIndex = 2;
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFolderLabel.Location = new System.Drawing.Point(3, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(123, 26);
            this.inputFolderLabel.TabIndex = 3;
            this.inputFolderLabel.Text = "Input folder:";
            this.inputFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.generateWatermarkedPdfButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.descriptionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.foldersGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.watermarkGroupBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 280);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // generateWatermarkedPdfButton
            // 
            this.generateWatermarkedPdfButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateWatermarkedPdfButton.Location = new System.Drawing.Point(3, 254);
            this.generateWatermarkedPdfButton.Name = "generateWatermarkedPdfButton";
            this.generateWatermarkedPdfButton.Size = new System.Drawing.Size(486, 23);
            this.generateWatermarkedPdfButton.TabIndex = 2;
            this.generateWatermarkedPdfButton.Text = "Generate watermarked PDF";
            this.generateWatermarkedPdfButton.UseVisualStyleBackColor = true;
            this.generateWatermarkedPdfButton.Click += new System.EventHandler(this.generateWatermarkedPdfButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(486, 43);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Watermark every PDF file of a folder in one click!";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foldersGroupBox
            // 
            this.foldersGroupBox.Controls.Add(this.tableLayoutPanel6);
            this.foldersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldersGroupBox.Location = new System.Drawing.Point(3, 46);
            this.foldersGroupBox.Name = "foldersGroupBox";
            this.foldersGroupBox.Size = new System.Drawing.Size(486, 72);
            this.foldersGroupBox.TabIndex = 4;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = "Folders to use";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(480, 53);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.Controls.Add(this.outputFolderBrowseButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.outputFolderTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 27);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // outputFolderBrowseButton
            // 
            this.outputFolderBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFolderBrowseButton.Location = new System.Drawing.Point(397, 3);
            this.outputFolderBrowseButton.Name = "outputFolderBrowseButton";
            this.outputFolderBrowseButton.Size = new System.Drawing.Size(80, 21);
            this.outputFolderBrowseButton.TabIndex = 1;
            this.outputFolderBrowseButton.Text = "Browse";
            this.outputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outputFolderBrowseButton.Click += new System.EventHandler(this.outputFolderBrowseButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Cue = "Select the output folder";
            this.outputFolderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFolderTextBox.Location = new System.Drawing.Point(132, 3);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(259, 20);
            this.outputFolderTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkGroupBox
            // 
            this.watermarkGroupBox.Controls.Add(this.tableLayoutPanel7);
            this.watermarkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkGroupBox.Location = new System.Drawing.Point(3, 124);
            this.watermarkGroupBox.Name = "watermarkGroupBox";
            this.watermarkGroupBox.Size = new System.Drawing.Size(486, 124);
            this.watermarkGroupBox.TabIndex = 5;
            this.watermarkGroupBox.TabStop = false;
            this.watermarkGroupBox.Text = "Watermark customisation";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(480, 105);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.watermarkTextLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.watermarkTextBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(480, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // watermarkTextLabel
            // 
            this.watermarkTextLabel.AutoSize = true;
            this.watermarkTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkTextLabel.Location = new System.Drawing.Point(3, 0);
            this.watermarkTextLabel.Name = "watermarkTextLabel";
            this.watermarkTextLabel.Size = new System.Drawing.Size(123, 26);
            this.watermarkTextLabel.TabIndex = 3;
            this.watermarkTextLabel.Text = "Text:";
            this.watermarkTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkTextBox
            // 
            this.watermarkTextBox.Cue = "Type your watermark";
            this.watermarkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkTextBox.Location = new System.Drawing.Point(132, 3);
            this.watermarkTextBox.Name = "watermarkTextBox";
            this.watermarkTextBox.Size = new System.Drawing.Size(345, 20);
            this.watermarkTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel3.Controls.Add(this.watermarkDateLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addDatecheckBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateToAddToWatermarkTimePicker, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 26);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // watermarkDateLabel
            // 
            this.watermarkDateLabel.AutoSize = true;
            this.watermarkDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkDateLabel.Location = new System.Drawing.Point(3, 0);
            this.watermarkDateLabel.Name = "watermarkDateLabel";
            this.watermarkDateLabel.Size = new System.Drawing.Size(123, 26);
            this.watermarkDateLabel.TabIndex = 3;
            this.watermarkDateLabel.Text = "Date:";
            this.watermarkDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDatecheckBox
            // 
            this.addDatecheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDatecheckBox.AutoSize = true;
            this.addDatecheckBox.Location = new System.Drawing.Point(159, 4);
            this.addDatecheckBox.Name = "addDatecheckBox";
            this.addDatecheckBox.Size = new System.Drawing.Size(69, 17);
            this.addDatecheckBox.TabIndex = 4;
            this.addDatecheckBox.Text = "Add date";
            this.addDatecheckBox.UseVisualStyleBackColor = true;
            // 
            // dateToAddToWatermarkTimePicker
            // 
            this.dateToAddToWatermarkTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateToAddToWatermarkTimePicker.Location = new System.Drawing.Point(261, 3);
            this.dateToAddToWatermarkTimePicker.Name = "dateToAddToWatermarkTimePicker";
            this.dateToAddToWatermarkTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateToAddToWatermarkTimePicker.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel8.Controls.Add(this.watermarkColorLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.watermarkColorTextBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.watermarkColorPickerButton, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(480, 26);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // watermarkColorLabel
            // 
            this.watermarkColorLabel.AutoSize = true;
            this.watermarkColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkColorLabel.Location = new System.Drawing.Point(3, 0);
            this.watermarkColorLabel.Name = "watermarkColorLabel";
            this.watermarkColorLabel.Size = new System.Drawing.Size(123, 26);
            this.watermarkColorLabel.TabIndex = 3;
            this.watermarkColorLabel.Text = "Color:";
            this.watermarkColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkColorTextBox
            // 
            this.watermarkColorTextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.watermarkColorTextBox.Cue = null;
            this.watermarkColorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkColorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.watermarkColorTextBox.Location = new System.Drawing.Point(132, 3);
            this.watermarkColorTextBox.Name = "watermarkColorTextBox";
            this.watermarkColorTextBox.ReadOnly = true;
            this.watermarkColorTextBox.Size = new System.Drawing.Size(259, 20);
            this.watermarkColorTextBox.TabIndex = 4;
            // 
            // watermarkColorPickerButton
            // 
            this.watermarkColorPickerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkColorPickerButton.Location = new System.Drawing.Point(397, 3);
            this.watermarkColorPickerButton.Name = "watermarkColorPickerButton";
            this.watermarkColorPickerButton.Size = new System.Drawing.Size(80, 20);
            this.watermarkColorPickerButton.TabIndex = 5;
            this.watermarkColorPickerButton.Text = "Pick a color";
            this.watermarkColorPickerButton.UseVisualStyleBackColor = true;
            this.watermarkColorPickerButton.Click += new System.EventHandler(this.watermarkColorPickerButton_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel9.Controls.Add(this.watermarkOpacityLabel, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.watermarkOpacityTextBox, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.watermarkOpacityTrackBar, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.watermarkOpacityPourcentLabel, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(480, 27);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // watermarkOpacityLabel
            // 
            this.watermarkOpacityLabel.AutoSize = true;
            this.watermarkOpacityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkOpacityLabel.Location = new System.Drawing.Point(3, 0);
            this.watermarkOpacityLabel.Name = "watermarkOpacityLabel";
            this.watermarkOpacityLabel.Size = new System.Drawing.Size(123, 27);
            this.watermarkOpacityLabel.TabIndex = 3;
            this.watermarkOpacityLabel.Text = "Opacity:";
            this.watermarkOpacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkOpacityTextBox
            // 
            this.watermarkOpacityTextBox.Cue = "50";
            this.watermarkOpacityTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.watermarkOpacityTextBox.Location = new System.Drawing.Point(216, 4);
            this.watermarkOpacityTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.watermarkOpacityTextBox.Name = "watermarkOpacityTextBox";
            this.watermarkOpacityTextBox.Size = new System.Drawing.Size(24, 20);
            this.watermarkOpacityTextBox.TabIndex = 4;
            this.watermarkOpacityTextBox.TextChanged += new System.EventHandler(this.watermarkOpacityTextBox_TextChanged);
            // 
            // watermarkOpacityTrackBar
            // 
            this.watermarkOpacityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkOpacityTrackBar.Location = new System.Drawing.Point(269, 3);
            this.watermarkOpacityTrackBar.Maximum = 100;
            this.watermarkOpacityTrackBar.Name = "watermarkOpacityTrackBar";
            this.watermarkOpacityTrackBar.Size = new System.Drawing.Size(208, 21);
            this.watermarkOpacityTrackBar.TabIndex = 5;
            this.watermarkOpacityTrackBar.Value = 50;
            this.watermarkOpacityTrackBar.ValueChanged += new System.EventHandler(this.watermarkOpacityTrackBar_ValueChanged);
            // 
            // watermarkOpacityPourcentLabel
            // 
            this.watermarkOpacityPourcentLabel.AutoSize = true;
            this.watermarkOpacityPourcentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkOpacityPourcentLabel.Location = new System.Drawing.Point(243, 0);
            this.watermarkOpacityPourcentLabel.Name = "watermarkOpacityPourcentLabel";
            this.watermarkOpacityPourcentLabel.Size = new System.Drawing.Size(20, 27);
            this.watermarkOpacityPourcentLabel.TabIndex = 6;
            this.watermarkOpacityPourcentLabel.Text = "%";
            this.watermarkOpacityPourcentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 280);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(492, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(86, 16);
            this.toolStripProgressBar.Step = 1;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel.Text = "Idle.";
            // 
            // watermarkPDFBackgroundWorker
            // 
            this.watermarkPDFBackgroundWorker.WorkerReportsProgress = true;
            this.watermarkPDFBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.watermarkPDFBackgroundWorker_DoWork);
            this.watermarkPDFBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.watermarkPDFBackgroundWorker_ProgressChanged);
            this.watermarkPDFBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.watermarkPDFBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 302);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark PDF";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.foldersGroupBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.watermarkGroupBox.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkOpacityTrackBar)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button inputPdfFolderBrowseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button generateWatermarkedPdfButton;
        private CueTextBox inputPdfFolderTextBox;
        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label watermarkTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button outputFolderBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox addDatecheckBox;
        private System.Windows.Forms.DateTimePicker dateToAddToWatermarkTimePicker;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox watermarkGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label watermarkDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label watermarkColorLabel;
        private System.Windows.Forms.Label watermarkOpacityLabel;
        private System.Windows.Forms.Button watermarkColorPickerButton;
        private System.Windows.Forms.TrackBar watermarkOpacityTrackBar;
        private System.Windows.Forms.Label watermarkOpacityPourcentLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private CueTextBox watermarkTextBox;
        private CueTextBox outputFolderTextBox;
        private CueTextBox watermarkColorTextBox;
        private CueTextBox watermarkOpacityTextBox;
        private System.ComponentModel.BackgroundWorker watermarkPDFBackgroundWorker;
    }
}

