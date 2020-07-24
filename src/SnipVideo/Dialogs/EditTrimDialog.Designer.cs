namespace SnipVideo
{
  partial class EditTrimDialog
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.lblEndDisplay = new System.Windows.Forms.Label();
      this.txtEnd = new SnipVideo.TimeSpanEditBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkEnd = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.lblStartDisplay = new System.Windows.Forms.Label();
      this.txtStart = new SnipVideo.TimeSpanEditBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.chkEnd, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 8;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 198);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel4.Controls.Add(this.lblEndDisplay, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.txtEnd, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 138);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(325, 30);
      this.tableLayoutPanel4.TabIndex = 5;
      // 
      // lblEndDisplay
      // 
      this.lblEndDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblEndDisplay.AutoSize = true;
      this.lblEndDisplay.Location = new System.Drawing.Point(247, 8);
      this.lblEndDisplay.Name = "lblEndDisplay";
      this.lblEndDisplay.Size = new System.Drawing.Size(55, 13);
      this.lblEndDisplay.TabIndex = 1;
      this.lblEndDisplay.Text = "0 seconds";
      // 
      // txtEnd
      // 
      this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtEnd.Location = new System.Drawing.Point(3, 4);
      this.txtEnd.MaximumSize = new System.Drawing.Size(0, 21);
      this.txtEnd.MinimumSize = new System.Drawing.Size(100, 21);
      this.txtEnd.Name = "txtEnd";
      this.txtEnd.Size = new System.Drawing.Size(219, 21);
      this.txtEnd.TabIndex = 0;
      this.txtEnd.Value = System.TimeSpan.Parse("00:00:00");
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(230, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Start (everything before this will be removed):";
      // 
      // chkEnd
      // 
      this.chkEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.chkEnd.AutoSize = true;
      this.chkEnd.Location = new System.Drawing.Point(3, 116);
      this.chkEnd.Name = "chkEnd";
      this.chkEnd.Size = new System.Drawing.Size(166, 17);
      this.chkEnd.TabIndex = 4;
      this.chkEnd.Text = "End (go to end of the video):";
      this.chkEnd.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel3.Controls.Add(this.lblStartDisplay, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.txtStart, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 82);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(325, 30);
      this.tableLayoutPanel3.TabIndex = 3;
      // 
      // lblStartDisplay
      // 
      this.lblStartDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblStartDisplay.AutoSize = true;
      this.lblStartDisplay.Location = new System.Drawing.Point(247, 8);
      this.lblStartDisplay.Name = "lblStartDisplay";
      this.lblStartDisplay.Size = new System.Drawing.Size(55, 13);
      this.lblStartDisplay.TabIndex = 1;
      this.lblStartDisplay.Text = "0 seconds";
      // 
      // txtStart
      // 
      this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStart.Location = new System.Drawing.Point(3, 4);
      this.txtStart.MaximumSize = new System.Drawing.Size(0, 21);
      this.txtStart.MinimumSize = new System.Drawing.Size(100, 21);
      this.txtStart.Name = "txtStart";
      this.txtStart.Size = new System.Drawing.Size(219, 21);
      this.txtStart.TabIndex = 0;
      this.txtStart.Value = System.TimeSpan.Parse("00:00:00");
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 168);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 30);
      this.tableLayoutPanel2.TabIndex = 6;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnOK.Location = new System.Drawing.Point(168, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 24);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCancel.Location = new System.Drawing.Point(248, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Name (this can be empty):";
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(3, 30);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(319, 21);
      this.txtName.TabIndex = 1;
      // 
      // EditTrimDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(345, 218);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditTrimDialog";
      this.Text = "EditTrimDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkEnd;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label lblStartDisplay;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label lblEndDisplay;
    private TimeSpanEditBox txtEnd;
    private TimeSpanEditBox txtStart;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
  }
}