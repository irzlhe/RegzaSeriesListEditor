using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RegzaSeriesListEditor
{
    public partial class SeriesListForm : Form
    {
        private string targetDirectoryname;
        private string dirInfoFilename;
        private string serieslistFilename;
        private List<FileData> files = new List<FileData>();
        private List<SeriesData> series = new List<SeriesData>();
        private Encoding encoding = Encoding.GetEncoding("euc-jp");

        public SeriesListForm()
        {
            InitializeComponent();

            seriesListView.Columns.Add("番組名", 360);
            seriesListView.Columns.Add("日付", 120);
            nonSeriesListView.Columns.Add("番組名", 360);
            nonSeriesListView.Columns.Add("日付", 120);
        }

        private void selectTargetButton_Click(object sender, EventArgs e)
        {
            targetFolderBrowserDialog.SelectedPath = targetPathTextBox.Text;
            DialogResult result = targetFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                targetPathTextBox.Text = targetFolderBrowserDialog.SelectedPath;
            }
        }

        private void targetPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (data.Length > 0 && Directory.Exists(data[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void targetPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (data.Length > 0 && Directory.Exists(data[0]))
                {
                    targetPathTextBox.Text = data[0];
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Clear();

            string target_path = targetPathTextBox.Text;
            if (!Directory.Exists(target_path)) return;

            var dir_info_files = Directory.GetFiles(target_path, ".toshiba_dir_info_*");
            if (dir_info_files.Length != 1) return;

            var serieslist_files = Directory.GetFiles(target_path, ".toshiba_serieslist_*");
            if (serieslist_files.Length != 1) return;

            if (dir_info_files[0].Replace("dir_info", "serieslist") != serieslist_files[0]) return;
            targetDirectoryname = target_path;
            dirInfoFilename = dir_info_files[0];
            serieslistFilename = serieslist_files[0];

            LoadFiles();
            LoadSeries();

            UpdateSeriesComboBox();
            //UpdateSeriesListView();
            UpdateNonSeriesListView();
        }

        private void seriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSeriesListView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int series_id = GetCurrentSeriesId();
            bool need_update = false;
            foreach (ListViewItem item in nonSeriesListView.SelectedItems)
            {
                FileData file_data = files[(int)item.Tag];
                file_data.SetSeriesId(series_id);
                need_update = true;
            }
            if (need_update)
            {
                UpdateSeriesListView();
                UpdateNonSeriesListView();
                UpdateSaveButton();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            bool need_update = false;
            foreach (ListViewItem item in seriesListView.SelectedItems)
            {
                FileData file_data = files[(int)item.Tag];
                file_data.SetSeriesId(0);
                need_update = true;
            }
            if (need_update)
            {
                UpdateSeriesListView();
                UpdateNonSeriesListView();
                UpdateSaveButton();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFiles();
            UpdateSaveButton();
        }

        private void Clear()
        {
            saveButton.Enabled = false;
            nonSeriesListView.Items.Clear();
            seriesListView.Items.Clear();
            seriesComboBox.DataSource = null;
            series.Clear();
            files.Clear();
            serieslistFilename = "";
            dirInfoFilename = "";
            targetDirectoryname = "";
        }

        private void LoadFiles()
        {
            using (FileStream file_stream = File.Open(dirInfoFilename, FileMode.Open, FileAccess.ReadWrite))
            {
                while (file_stream.Position < file_stream.Length)
                {
                    FileData file_data = new FileData();
                    file_data.index = files.Count;
                    file_data.filename = ReadString(file_stream, 540);
                    file_stream.Seek(4, SeekOrigin.Current);
                    file_data.seriesId = ReadInt(file_stream);
                    file_stream.Seek(16, SeekOrigin.Current);
                    file_data.metaData = LoadMeta(Path.Combine(targetDirectoryname, file_data.filename + ".meta"));
                    files.Add(file_data);
                }
            }
        }

        private MetaData LoadMeta(string meta_filename)
        {
            if (File.Exists(meta_filename))
            {
                MetaData meta_data = new MetaData();
                using (FileStream file_stream = File.Open(meta_filename, FileMode.Open, FileAccess.ReadWrite))
                {
                    file_stream.Seek(27, SeekOrigin.Current);
                    meta_data.title = ReadString(file_stream, 128);
                    file_stream.Seek(83, SeekOrigin.Current);
                    meta_data.date = DateTime.ParseExact(ReadString(file_stream, 32), "yyyy/MM/dd HH_mm_ss", null);
                    file_stream.Seek(1202, SeekOrigin.Current);
                    meta_data.seriesId = ReadInt(file_stream);
                }
                return meta_data;
            }
            return null;
        }

        private void LoadSeries()
        {
            using (FileStream file_stream = File.Open(serieslistFilename, FileMode.Open, FileAccess.ReadWrite))
            {
                while (file_stream.Position < file_stream.Length)
                {
                    SeriesData series_data = new SeriesData();
                    series_data.index = series.Count;
                    series_data.id = ReadInt(file_stream);
                    series_data.name = ReadString(file_stream, 128);
                    series_data.count = ReadInt(file_stream);
                    series.Add(series_data);
                }
            }
        }

        private void SaveFiles()
        {
            using (FileStream file_stream = File.Open(dirInfoFilename, FileMode.Open, FileAccess.Write))
            {
                foreach (FileData file_data in files)
                {
                    if (file_data.IsDirty())
                    {
                        int series_id = file_data.newSeriesId.Value;
                        file_data.seriesId = series_id;
                        file_data.metaData.seriesId = series_id;
                        file_data.newSeriesId = null;

                        file_stream.Seek(564 * file_data.index, SeekOrigin.Begin);
                        file_stream.Seek(540, SeekOrigin.Current);
                        file_stream.Seek(4, SeekOrigin.Current);
                        WriteInt(file_stream, file_data.seriesId);
                        //file_stream.Seek(16, SeekOrigin.Current);
                        SaveMeta(Path.Combine(targetDirectoryname, file_data.filename + ".meta"), file_data.metaData);
                    }
                }
            }
        }

        private void SaveMeta(string meta_filename, MetaData meta_data)
        {
            if (File.Exists(meta_filename))
            {
                using (FileStream file_stream = File.Open(meta_filename, FileMode.Open, FileAccess.Write))
                {
                    file_stream.Seek(27, SeekOrigin.Current);
                    file_stream.Seek(128, SeekOrigin.Current);
                    file_stream.Seek(83, SeekOrigin.Current);
                    file_stream.Seek(32, SeekOrigin.Current);
                    file_stream.Seek(1202, SeekOrigin.Current);
                    WriteInt(file_stream, meta_data.seriesId);
                }
            }
        }

        private void UpdateSeriesComboBox()
        {
            seriesComboBox.DataSource = series;
            seriesComboBox.DisplayMember = "Name";
        }

        private void UpdateSeriesListView()
        {
            int series_id = GetCurrentSeriesId();
            seriesListView.BeginUpdate();
            seriesListView.Items.Clear();
            foreach (FileData file_data in files)
            {
                if (file_data.IsValid())
                {
                    if (file_data.GetSeriesId() == series_id)
                    {
                        ListViewItem item = new ListViewItem(new string[] { file_data.metaData.title, file_data.metaData.date.ToString() });
                        item.Tag = file_data.index;
                        seriesListView.Items.Add(item);
                    }
                }
            }
            seriesListView.EndUpdate();
        }

        private void UpdateNonSeriesListView()
        {
            nonSeriesListView.BeginUpdate();
            nonSeriesListView.Items.Clear();
            foreach (FileData file_data in files)
            {
                if (file_data.IsValid())
                {
                    if (file_data.GetSeriesId() == 0)
                    {
                        ListViewItem item = new ListViewItem(new string[] { file_data.metaData.title, file_data.metaData.date.ToString() });
                        item.Tag = file_data.index;
                        nonSeriesListView.Items.Add(item);
                    }
                }
            }
            nonSeriesListView.EndUpdate();
        }

        private void UpdateSaveButton()
        {
            bool dirty = false;
            foreach (FileData file_data in files)
            {
                if (file_data.IsDirty())
                {
                    dirty = true;
                    break;
                }
            }
            saveButton.Enabled = dirty;
        }

        private int ReadInt(FileStream file_stream)
        {
            byte[] data = new byte[4];
            if (file_stream.Read(data, 0, 4) == 4)
            {
                return data[0] | data[1] << 8 | data[2] << 16 | data[3] << 24;
            }
            return 0;
        }

        private string ReadString(FileStream file_stream, int length)
        {
            byte[] data = new byte[length];
            if (file_stream.Read(data, 0, length) == length)
            {
                StringBuilder string_builder = new StringBuilder();
                int size = Array.IndexOf<byte>(data, 0);
                int byte_index = 0;
                int byte_count = 1;
                while (byte_index + byte_count <= size)
                {
                    bool flush = byte_index + byte_count == size;
                    int char_count = encoding.GetDecoder().GetCharCount(data, byte_index, byte_count, flush);
                    if (char_count == 0)
                    {
                        byte_count++;
                        continue;
                    }

                    if (char_count == 1 && byte_count == 2)
                    {
                        int code = data[byte_index] << 8 | data[byte_index + 1];
                        if (AribCharacterMapper.table.ContainsKey(code))
                        {
                            string_builder.Append(AribCharacterMapper.table[code]);
                            byte_index += byte_count;
                            byte_count = 1;
                            continue;
                        }
                    }
                    string_builder.Append(encoding.GetString(data, byte_index, byte_count));
                    byte_index += byte_count;
                    byte_count = 1;
                }
                return string_builder.ToString();
            }
            return "";
        }

        private void WriteInt(FileStream file_stream, int value)
        {
            byte[] data = new byte[4];
            data[0] = (byte)(value & 0xff);
            data[1] = (byte)((value >> 8) & 0xff);
            data[2] = (byte)((value >> 16) & 0xff);
            data[3] = (byte)((value >> 24) & 0xff);
            file_stream.Write(data, 0, 4);
        }

        private int GetCurrentSeriesId()
        {
            if (seriesComboBox.SelectedItem != null)
            {
                return ((SeriesData)seriesComboBox.SelectedItem).id;
            }
            return 0;
        }
    }
}
