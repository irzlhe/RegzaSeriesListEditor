namespace RegzaSeriesListEditor
{
    partial class SeriesListForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox targetGroupBox;
            this.selectTargetButton = new System.Windows.Forms.Button();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.seriesListView = new System.Windows.Forms.ListView();
            this.nonSeriesListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            targetGroupBox = new System.Windows.Forms.GroupBox();
            targetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetGroupBox
            // 
            targetGroupBox.Controls.Add(this.selectTargetButton);
            targetGroupBox.Controls.Add(this.targetPathTextBox);
            targetGroupBox.Location = new System.Drawing.Point(12, 12);
            targetGroupBox.Name = "targetGroupBox";
            targetGroupBox.Size = new System.Drawing.Size(424, 40);
            targetGroupBox.TabIndex = 0;
            targetGroupBox.TabStop = false;
            // 
            // selectTargetButton
            // 
            this.selectTargetButton.Location = new System.Drawing.Point(6, 11);
            this.selectTargetButton.Name = "selectTargetButton";
            this.selectTargetButton.Size = new System.Drawing.Size(75, 23);
            this.selectTargetButton.TabIndex = 0;
            this.selectTargetButton.Text = "HDD選択";
            this.selectTargetButton.UseVisualStyleBackColor = true;
            this.selectTargetButton.Click += new System.EventHandler(this.selectTargetButton_Click);
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.AllowDrop = true;
            this.targetPathTextBox.Location = new System.Drawing.Point(87, 13);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(331, 19);
            this.targetPathTextBox.TabIndex = 1;
            this.targetPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.targetPathTextBox_DragDrop);
            this.targetPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.targetPathTextBox_DragEnter);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(442, 23);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "連ドラ読み込み";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(12, 58);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(280, 20);
            this.seriesComboBox.TabIndex = 2;
            this.seriesComboBox.SelectedIndexChanged += new System.EventHandler(this.seriesComboBox_SelectedIndexChanged);
            // 
            // seriesListView
            // 
            this.seriesListView.FullRowSelect = true;
            this.seriesListView.HideSelection = false;
            this.seriesListView.Location = new System.Drawing.Point(12, 84);
            this.seriesListView.Name = "seriesListView";
            this.seriesListView.Size = new System.Drawing.Size(520, 190);
            this.seriesListView.TabIndex = 3;
            this.seriesListView.UseCompatibleStateImageBehavior = false;
            this.seriesListView.View = System.Windows.Forms.View.Details;
            // 
            // nonSeriesListView
            // 
            this.nonSeriesListView.FullRowSelect = true;
            this.nonSeriesListView.HideSelection = false;
            this.nonSeriesListView.Location = new System.Drawing.Point(12, 309);
            this.nonSeriesListView.Name = "nonSeriesListView";
            this.nonSeriesListView.Size = new System.Drawing.Size(520, 190);
            this.nonSeriesListView.TabIndex = 6;
            this.nonSeriesListView.UseCompatibleStateImageBehavior = false;
            this.nonSeriesListView.View = System.Windows.Forms.View.Details;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(147, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "追加↑";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(322, 280);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "↓外す";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(442, 505);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "連ドラ保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // targetFolderBrowserDialog
            // 
            this.targetFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.targetFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // SeriesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 540);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nonSeriesListView);
            this.Controls.Add(this.seriesListView);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(targetGroupBox);
            this.MaximizeBox = false;
            this.Name = "SeriesListForm";
            this.ShowIcon = false;
            this.Text = "連ドラリスト編集";
            targetGroupBox.ResumeLayout(false);
            targetGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectTargetButton;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.ListView seriesListView;
        private System.Windows.Forms.ListView nonSeriesListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
    }
}

