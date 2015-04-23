namespace SnipVideo
{
  partial class MainForm
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
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.progStatus = new System.Windows.Forms.TextProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnAddVideo = new System.Windows.Forms.Button();
      this.btnRemoveVideo = new System.Windows.Forms.Button();
      this.btnClearVideos = new System.Windows.Forms.Button();
      this.tpnlTrimButtons = new System.Windows.Forms.TableLayoutPanel();
      this.btnAddTrim = new System.Windows.Forms.Button();
      this.btnEditTrim = new System.Windows.Forms.Button();
      this.btnRemoveTrim = new System.Windows.Forms.Button();
      this.btnClearTrims = new System.Windows.Forms.Button();
      this.btnRun = new System.Windows.Forms.Button();
      this.treeFiles = new System.Windows.Forms.TreeView();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tpnlTrimButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog
      // 
      this.openFileDialog.Multiselect = true;
      this.openFileDialog.RestoreDirectory = true;
      this.openFileDialog.SupportMultiDottedExtensions = true;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.treeFiles, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 482);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // progStatus
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.progStatus, 2);
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 455);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(390, 24);
      this.progStatus.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Files:";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.btnAddVideo, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnRemoveVideo, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.btnClearVideos, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.tpnlTrimButtons, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.btnRun, 0, 6);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(311, 20);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 7;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(85, 432);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // btnAddVideo
      // 
      this.btnAddVideo.AutoSize = true;
      this.btnAddVideo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddVideo.Location = new System.Drawing.Point(3, 3);
      this.btnAddVideo.Name = "btnAddVideo";
      this.btnAddVideo.Size = new System.Drawing.Size(79, 24);
      this.btnAddVideo.TabIndex = 0;
      this.btnAddVideo.Text = "Add Video";
      this.btnAddVideo.UseVisualStyleBackColor = true;
      this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
      // 
      // btnRemoveVideo
      // 
      this.btnRemoveVideo.AutoSize = true;
      this.btnRemoveVideo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRemoveVideo.Location = new System.Drawing.Point(3, 33);
      this.btnRemoveVideo.Name = "btnRemoveVideo";
      this.btnRemoveVideo.Size = new System.Drawing.Size(79, 39);
      this.btnRemoveVideo.TabIndex = 1;
      this.btnRemoveVideo.Text = "Remove Video";
      this.btnRemoveVideo.UseVisualStyleBackColor = true;
      this.btnRemoveVideo.Click += new System.EventHandler(this.btnRemoveVideo_Click);
      // 
      // btnClearVideos
      // 
      this.btnClearVideos.AutoSize = true;
      this.btnClearVideos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnClearVideos.Location = new System.Drawing.Point(3, 78);
      this.btnClearVideos.Name = "btnClearVideos";
      this.btnClearVideos.Size = new System.Drawing.Size(79, 24);
      this.btnClearVideos.TabIndex = 2;
      this.btnClearVideos.Text = "Clear Videos";
      this.btnClearVideos.UseVisualStyleBackColor = true;
      this.btnClearVideos.Click += new System.EventHandler(this.btnClearVideos_Click);
      // 
      // tpnlTrimButtons
      // 
      this.tpnlTrimButtons.ColumnCount = 1;
      this.tpnlTrimButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tpnlTrimButtons.Controls.Add(this.btnAddTrim, 0, 0);
      this.tpnlTrimButtons.Controls.Add(this.btnEditTrim, 0, 1);
      this.tpnlTrimButtons.Controls.Add(this.btnRemoveTrim, 0, 2);
      this.tpnlTrimButtons.Controls.Add(this.btnClearTrims, 0, 3);
      this.tpnlTrimButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tpnlTrimButtons.Location = new System.Drawing.Point(0, 135);
      this.tpnlTrimButtons.Margin = new System.Windows.Forms.Padding(0);
      this.tpnlTrimButtons.Name = "tpnlTrimButtons";
      this.tpnlTrimButtons.RowCount = 4;
      this.tpnlTrimButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tpnlTrimButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tpnlTrimButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tpnlTrimButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tpnlTrimButtons.Size = new System.Drawing.Size(85, 120);
      this.tpnlTrimButtons.TabIndex = 7;
      // 
      // btnAddTrim
      // 
      this.btnAddTrim.AutoSize = true;
      this.btnAddTrim.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddTrim.Location = new System.Drawing.Point(3, 3);
      this.btnAddTrim.Name = "btnAddTrim";
      this.btnAddTrim.Size = new System.Drawing.Size(79, 24);
      this.btnAddTrim.TabIndex = 3;
      this.btnAddTrim.Text = "Add Trim";
      this.btnAddTrim.UseVisualStyleBackColor = true;
      this.btnAddTrim.Click += new System.EventHandler(this.btnAddTrim_Click);
      // 
      // btnEditTrim
      // 
      this.btnEditTrim.AutoSize = true;
      this.btnEditTrim.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnEditTrim.Location = new System.Drawing.Point(3, 33);
      this.btnEditTrim.Name = "btnEditTrim";
      this.btnEditTrim.Size = new System.Drawing.Size(79, 24);
      this.btnEditTrim.TabIndex = 4;
      this.btnEditTrim.Text = "Edit Trim";
      this.btnEditTrim.UseVisualStyleBackColor = true;
      this.btnEditTrim.Click += new System.EventHandler(this.btnEditTrim_Click);
      // 
      // btnRemoveTrim
      // 
      this.btnRemoveTrim.AutoSize = true;
      this.btnRemoveTrim.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRemoveTrim.Location = new System.Drawing.Point(3, 63);
      this.btnRemoveTrim.Name = "btnRemoveTrim";
      this.btnRemoveTrim.Size = new System.Drawing.Size(79, 24);
      this.btnRemoveTrim.TabIndex = 5;
      this.btnRemoveTrim.Text = "Remove Trim";
      this.btnRemoveTrim.UseVisualStyleBackColor = true;
      this.btnRemoveTrim.Click += new System.EventHandler(this.btnRemoveTrim_Click);
      // 
      // btnClearTrims
      // 
      this.btnClearTrims.AutoSize = true;
      this.btnClearTrims.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnClearTrims.Location = new System.Drawing.Point(3, 93);
      this.btnClearTrims.Name = "btnClearTrims";
      this.btnClearTrims.Size = new System.Drawing.Size(79, 24);
      this.btnClearTrims.TabIndex = 6;
      this.btnClearTrims.Text = "Clear Trims";
      this.btnClearTrims.UseVisualStyleBackColor = true;
      this.btnClearTrims.Click += new System.EventHandler(this.btnClearTrims_Click);
      // 
      // btnRun
      // 
      this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRun.Location = new System.Drawing.Point(3, 405);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(79, 24);
      this.btnRun.TabIndex = 8;
      this.btnRun.Text = "Run";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // treeFiles
      // 
      this.treeFiles.AllowDrop = true;
      this.treeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeFiles.FullRowSelect = true;
      this.treeFiles.HideSelection = false;
      this.treeFiles.Location = new System.Drawing.Point(3, 23);
      this.treeFiles.Name = "treeFiles";
      this.treeFiles.Size = new System.Drawing.Size(305, 426);
      this.treeFiles.TabIndex = 4;
      this.treeFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFiles_AfterSelect);
      this.treeFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeFiles_DragDrop);
      this.treeFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeFiles_DragEnter);
      this.treeFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.treeFiles_DragEnter);
      this.treeFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeFiles_KeyDown);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(416, 502);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SnipVideo";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tpnlTrimButtons.ResumeLayout(false);
      this.tpnlTrimButtons.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextProgressBar progStatus;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TreeView treeFiles;
    private System.Windows.Forms.Button btnAddVideo;
    private System.Windows.Forms.Button btnRemoveVideo;
    private System.Windows.Forms.Button btnClearVideos;
    private System.Windows.Forms.Button btnAddTrim;
    private System.Windows.Forms.Button btnEditTrim;
    private System.Windows.Forms.Button btnRemoveTrim;
    private System.Windows.Forms.Button btnClearTrims;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.TableLayoutPanel tpnlTrimButtons;
    private System.Windows.Forms.Button btnRun;
  }
}

