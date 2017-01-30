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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.selectTargetButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nonSeriesListView = new System.Windows.Forms.ListView();
            this.seriesListView = new System.Windows.Forms.ListView();
            this.loadButton = new System.Windows.Forms.Button();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            targetGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            targetGroupBox.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetGroupBox
            // 
            targetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            targetGroupBox.Controls.Add(this.targetPathTextBox);
            targetGroupBox.Controls.Add(this.selectTargetButton);
            targetGroupBox.Location = new System.Drawing.Point(12, 12);
            targetGroupBox.Name = "targetGroupBox";
            targetGroupBox.Size = new System.Drawing.Size(424, 40);
            targetGroupBox.TabIndex = 0;
            targetGroupBox.TabStop = false;
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.AllowDrop = true;
            this.targetPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPathTextBox.Location = new System.Drawing.Point(87, 13);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(331, 19);
            this.targetPathTextBox.TabIndex = 1;
            this.targetPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.targetPathTextBox_DragDrop);
            this.targetPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.targetPathTextBox_DragEnter);
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
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(this.removeButton, 1, 1);
            tableLayoutPanel.Controls.Add(this.addButton, 0, 1);
            tableLayoutPanel.Controls.Add(this.nonSeriesListView, 0, 2);
            tableLayoutPanel.Controls.Add(this.seriesListView, 0, 0);
            tableLayoutPanel.Location = new System.Drawing.Point(12, 84);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(520, 415);
            tableLayoutPanel.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(310, 196);
            this.removeButton.Margin = new System.Windows.Forms.Padding(50, 6, 3, 6);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "↓外す";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(135, 196);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 6, 50, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "追加↑";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nonSeriesListView
            // 
            this.nonSeriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel.SetColumnSpan(this.nonSeriesListView, 2);
            this.nonSeriesListView.FullRowSelect = true;
            this.nonSeriesListView.HideSelection = false;
            this.nonSeriesListView.Location = new System.Drawing.Point(0, 225);
            this.nonSeriesListView.Margin = new System.Windows.Forms.Padding(0);
            this.nonSeriesListView.Name = "nonSeriesListView";
            this.nonSeriesListView.Size = new System.Drawing.Size(520, 190);
            this.nonSeriesListView.TabIndex = 3;
            this.nonSeriesListView.UseCompatibleStateImageBehavior = false;
            this.nonSeriesListView.View = System.Windows.Forms.View.Details;
            // 
            // seriesListView
            // 
            this.seriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel.SetColumnSpan(this.seriesListView, 2);
            this.seriesListView.FullRowSelect = true;
            this.seriesListView.HideSelection = false;
            this.seriesListView.Location = new System.Drawing.Point(0, 0);
            this.seriesListView.Margin = new System.Windows.Forms.Padding(0);
            this.seriesListView.Name = "seriesListView";
            this.seriesListView.Size = new System.Drawing.Size(520, 190);
            this.seriesListView.TabIndex = 0;
            this.seriesListView.UseCompatibleStateImageBehavior = false;
            this.seriesListView.View = System.Windows.Forms.View.Details;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.seriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(12, 58);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(280, 20);
            this.seriesComboBox.TabIndex = 2;
            this.seriesComboBox.SelectedIndexChanged += new System.EventHandler(this.seriesComboBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(442, 505);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 3;
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
            this.Controls.Add(tableLayoutPanel);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(targetGroupBox);
            this.MaximizeBox = false;
            this.Name = "SeriesListForm";
            this.ShowIcon = false;
            this.Text = "連ドラリスト編集";
            targetGroupBox.ResumeLayout(false);
            targetGroupBox.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
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

