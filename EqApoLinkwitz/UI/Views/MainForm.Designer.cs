namespace EqApoLinkwitz.UI.Views;

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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        lbl_f0 = new Label();
        lbl_q0 = new Label();
        num_f0 = new NumericUpDown();
        num_q0 = new NumericUpDown();
        num_qp = new NumericUpDown();
        num_fp = new NumericUpDown();
        lbl_qp = new Label();
        lbl_fp = new Label();
        num_lphp = new NumericUpDown();
        lbl_lphp = new Label();
        num_fs = new NumericUpDown();
        lbl_fs = new Label();
        lbl_a0 = new Label();
        lbl_a1 = new Label();
        lbl_a2 = new Label();
        lbl_b0 = new Label();
        lbl_b1 = new Label();
        lbl_b2 = new Label();
        lbl_isStable = new Label();
        chart_equalizerBands = new System.Windows.Forms.DataVisualization.Charting.Chart();
        grp_parameters = new GroupBox();
        num_scale = new NumericUpDown();
        lbl_scale = new Label();
        sfd_filepath = new SaveFileDialog();
        ofd_filepath = new OpenFileDialog();
        toolStrip = new ToolStrip();
        toolStripButton1 = new ToolStripButton();
        btn_save = new ToolStripButton();
        toolStripButton3 = new ToolStripButton();
        grp_biquad = new GroupBox();
        txt_isStable = new TextBox();
        num_b2 = new NumericUpDown();
        num_b1 = new NumericUpDown();
        num_b0 = new NumericUpDown();
        num_a2 = new NumericUpDown();
        num_a1 = new NumericUpDown();
        num_a0 = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)num_f0).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_q0).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_qp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_fp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_lphp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_fs).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chart_equalizerBands).BeginInit();
        grp_parameters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)num_scale).BeginInit();
        toolStrip.SuspendLayout();
        grp_biquad.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)num_b2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_b1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_b0).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_a2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_a1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)num_a0).BeginInit();
        SuspendLayout();
        // 
        // lbl_f0
        // 
        lbl_f0.AutoSize = true;
        lbl_f0.Location = new Point(8, 49);
        lbl_f0.Name = "lbl_f0";
        lbl_f0.Size = new Size(25, 15);
        lbl_f0.TabIndex = 0;
        lbl_f0.Text = "f(0)";
        // 
        // lbl_q0
        // 
        lbl_q0.AutoSize = true;
        lbl_q0.Location = new Point(8, 78);
        lbl_q0.Name = "lbl_q0";
        lbl_q0.Size = new Size(30, 15);
        lbl_q0.TabIndex = 1;
        lbl_q0.Text = "Q(0)";
        // 
        // num_f0
        // 
        num_f0.Location = new Point(157, 47);
        num_f0.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        num_f0.Name = "num_f0";
        num_f0.Size = new Size(120, 23);
        num_f0.TabIndex = 2;
        num_f0.Value = new decimal(new int[] { 130, 0, 0, 0 });
        num_f0.ValueChanged += NumF0ValueChanged;
        // 
        // num_q0
        // 
        num_q0.DecimalPlaces = 3;
        num_q0.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
        num_q0.Location = new Point(157, 76);
        num_q0.Name = "num_q0";
        num_q0.Size = new Size(120, 23);
        num_q0.TabIndex = 3;
        num_q0.Value = new decimal(new int[] { 707, 0, 0, 196608 });
        num_q0.ValueChanged += NumQ0ValueChanged;
        // 
        // num_qp
        // 
        num_qp.DecimalPlaces = 3;
        num_qp.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
        num_qp.Location = new Point(157, 134);
        num_qp.Name = "num_qp";
        num_qp.Size = new Size(120, 23);
        num_qp.TabIndex = 7;
        num_qp.Value = new decimal(new int[] { 707, 0, 0, 196608 });
        num_qp.ValueChanged += NumQpValueChanged;
        // 
        // num_fp
        // 
        num_fp.Location = new Point(157, 105);
        num_fp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        num_fp.Name = "num_fp";
        num_fp.Size = new Size(120, 23);
        num_fp.TabIndex = 6;
        num_fp.Value = new decimal(new int[] { 15, 0, 0, 0 });
        num_fp.ValueChanged += NumFpValueChanged;
        // 
        // lbl_qp
        // 
        lbl_qp.AutoSize = true;
        lbl_qp.Location = new Point(8, 136);
        lbl_qp.Name = "lbl_qp";
        lbl_qp.Size = new Size(31, 15);
        lbl_qp.TabIndex = 5;
        lbl_qp.Text = "Q(p)";
        // 
        // lbl_fp
        // 
        lbl_fp.AutoSize = true;
        lbl_fp.Location = new Point(8, 107);
        lbl_fp.Name = "lbl_fp";
        lbl_fp.Size = new Size(26, 15);
        lbl_fp.TabIndex = 4;
        lbl_fp.Text = "f(p)";
        // 
        // num_lphp
        // 
        num_lphp.DecimalPlaces = 3;
        num_lphp.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
        num_lphp.Location = new Point(157, 178);
        num_lphp.Name = "num_lphp";
        num_lphp.Size = new Size(120, 23);
        num_lphp.TabIndex = 9;
        num_lphp.Value = new decimal(new int[] { 75, 0, 0, 131072 });
        num_lphp.ValueChanged += NumLphpValueChanged;
        // 
        // lbl_lphp
        // 
        lbl_lphp.AutoSize = true;
        lbl_lphp.Location = new Point(8, 180);
        lbl_lphp.Name = "lbl_lphp";
        lbl_lphp.Size = new Size(41, 15);
        lbl_lphp.TabIndex = 8;
        lbl_lphp.Text = "LP/HP";
        // 
        // num_fs
        // 
        num_fs.Location = new Point(157, 207);
        num_fs.Maximum = new decimal(new int[] { 192000, 0, 0, 0 });
        num_fs.Name = "num_fs";
        num_fs.Size = new Size(120, 23);
        num_fs.TabIndex = 11;
        num_fs.Value = new decimal(new int[] { 48000, 0, 0, 0 });
        num_fs.ValueChanged += NumFsValueChanged;
        // 
        // lbl_fs
        // 
        lbl_fs.AutoSize = true;
        lbl_fs.Location = new Point(8, 209);
        lbl_fs.Name = "lbl_fs";
        lbl_fs.Size = new Size(104, 15);
        lbl_fs.TabIndex = 10;
        lbl_fs.Text = "Sample Frequency";
        // 
        // lbl_a0
        // 
        lbl_a0.AutoSize = true;
        lbl_a0.Location = new Point(10, 23);
        lbl_a0.Name = "lbl_a0";
        lbl_a0.Size = new Size(19, 15);
        lbl_a0.TabIndex = 14;
        lbl_a0.Text = "a0";
        // 
        // lbl_a1
        // 
        lbl_a1.AutoSize = true;
        lbl_a1.Location = new Point(10, 46);
        lbl_a1.Name = "lbl_a1";
        lbl_a1.Size = new Size(19, 15);
        lbl_a1.TabIndex = 16;
        lbl_a1.Text = "a1";
        // 
        // lbl_a2
        // 
        lbl_a2.AutoSize = true;
        lbl_a2.Location = new Point(9, 75);
        lbl_a2.Name = "lbl_a2";
        lbl_a2.Size = new Size(19, 15);
        lbl_a2.TabIndex = 18;
        lbl_a2.Text = "a2";
        // 
        // lbl_b0
        // 
        lbl_b0.AutoSize = true;
        lbl_b0.Location = new Point(9, 107);
        lbl_b0.Name = "lbl_b0";
        lbl_b0.Size = new Size(20, 15);
        lbl_b0.TabIndex = 20;
        lbl_b0.Text = "b0";
        // 
        // lbl_b1
        // 
        lbl_b1.AutoSize = true;
        lbl_b1.Location = new Point(9, 136);
        lbl_b1.Name = "lbl_b1";
        lbl_b1.Size = new Size(20, 15);
        lbl_b1.TabIndex = 22;
        lbl_b1.Text = "b1";
        // 
        // lbl_b2
        // 
        lbl_b2.AutoSize = true;
        lbl_b2.Location = new Point(8, 162);
        lbl_b2.Name = "lbl_b2";
        lbl_b2.Size = new Size(20, 15);
        lbl_b2.TabIndex = 24;
        lbl_b2.Text = "b2";
        // 
        // lbl_isStable
        // 
        lbl_isStable.AutoSize = true;
        lbl_isStable.Location = new Point(10, 200);
        lbl_isStable.Name = "lbl_isStable";
        lbl_isStable.Size = new Size(54, 15);
        lbl_isStable.TabIndex = 26;
        lbl_isStable.Text = "Is stable?";
        // 
        // chart_equalizerBands
        // 
        chartArea2.AxisX.Interval = 1D;
        chartArea2.AxisX.IsLogarithmic = true;
        chartArea2.AxisX.Minimum = 10D;
        chartArea2.AxisX.MinorGrid.Enabled = true;
        chartArea2.AxisX.MinorGrid.Interval = 1D;
        chartArea2.AxisX.MinorGrid.LineColor = Color.Silver;
        chartArea2.AxisX.Title = "Frequency (Hz)";
        chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
        chartArea2.AxisX2.IsLogarithmic = true;
        chartArea2.AxisY.Interval = 3D;
        chartArea2.AxisY.MajorGrid.LineColor = Color.DarkGray;
        chartArea2.AxisY.MajorTickMark.LineColor = Color.Silver;
        chartArea2.AxisY.MinorGrid.Enabled = true;
        chartArea2.AxisY.MinorGrid.Interval = 1D;
        chartArea2.AxisY.MinorGrid.LineColor = Color.LightGray;
        chartArea2.AxisY.MinorTickMark.Enabled = true;
        chartArea2.AxisY.MinorTickMark.Interval = 1D;
        chartArea2.AxisY.MinorTickMark.LineColor = Color.Gainsboro;
        chartArea2.AxisY.Title = "Eq (dB)";
        chartArea2.Name = "ChartArea1";
        chart_equalizerBands.ChartAreas.Add(chartArea2);
        legend2.Enabled = false;
        legend2.Name = "Legend1";
        chart_equalizerBands.Legends.Add(legend2);
        chart_equalizerBands.Location = new Point(301, 28);
        chart_equalizerBands.Name = "chart_equalizerBands";
        series2.ChartArea = "ChartArea1";
        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series2.Legend = "Legend1";
        series2.Name = "SeriesEq";
        chart_equalizerBands.Series.Add(series2);
        chart_equalizerBands.Size = new Size(555, 483);
        chart_equalizerBands.TabIndex = 31;
        chart_equalizerBands.Text = "chart";
        // 
        // grp_parameters
        // 
        grp_parameters.Controls.Add(num_scale);
        grp_parameters.Controls.Add(lbl_scale);
        grp_parameters.Controls.Add(lbl_f0);
        grp_parameters.Controls.Add(lbl_q0);
        grp_parameters.Controls.Add(num_f0);
        grp_parameters.Controls.Add(num_q0);
        grp_parameters.Controls.Add(lbl_fp);
        grp_parameters.Controls.Add(lbl_qp);
        grp_parameters.Controls.Add(num_fp);
        grp_parameters.Controls.Add(num_qp);
        grp_parameters.Controls.Add(lbl_lphp);
        grp_parameters.Controls.Add(num_lphp);
        grp_parameters.Controls.Add(lbl_fs);
        grp_parameters.Controls.Add(num_fs);
        grp_parameters.Location = new Point(12, 28);
        grp_parameters.Name = "grp_parameters";
        grp_parameters.Size = new Size(283, 239);
        grp_parameters.TabIndex = 32;
        grp_parameters.TabStop = false;
        grp_parameters.Text = "Parameters";
        // 
        // num_scale
        // 
        num_scale.DecimalPlaces = 3;
        num_scale.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
        num_scale.Location = new Point(157, 22);
        num_scale.Name = "num_scale";
        num_scale.Size = new Size(120, 23);
        num_scale.TabIndex = 32;
        num_scale.Value = new decimal(new int[] { 1, 0, 0, 0 });
        num_scale.ValueChanged += NumScaleValueChanged;
        // 
        // lbl_scale
        // 
        lbl_scale.AutoSize = true;
        lbl_scale.Location = new Point(8, 24);
        lbl_scale.Name = "lbl_scale";
        lbl_scale.Size = new Size(34, 15);
        lbl_scale.TabIndex = 31;
        lbl_scale.Text = "Scale";
        // 
        // ofd_filepath
        // 
        ofd_filepath.FileName = "openFileDialog1";
        // 
        // toolStrip
        // 
        toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, btn_save, toolStripButton3 });
        toolStrip.Location = new Point(0, 0);
        toolStrip.Name = "toolStrip";
        toolStrip.Size = new Size(866, 25);
        toolStrip.TabIndex = 37;
        toolStrip.Text = "toolStrip1";
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(23, 22);
        toolStripButton1.Text = "Open";
        toolStripButton1.Click += toolStripButton1_Click;
        // 
        // btn_save
        // 
        btn_save.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btn_save.Image = (Image)resources.GetObject("btn_save.Image");
        btn_save.ImageTransparentColor = Color.Magenta;
        btn_save.Name = "btn_save";
        btn_save.Size = new Size(23, 22);
        btn_save.Text = "Save";
        btn_save.Click += BtnSaveClick;
        // 
        // toolStripButton3
        // 
        toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
        toolStripButton3.ImageTransparentColor = Color.Magenta;
        toolStripButton3.Name = "toolStripButton3";
        toolStripButton3.Size = new Size(23, 22);
        toolStripButton3.Text = "Save as";
        toolStripButton3.Click += toolStripButton3_Click;
        // 
        // grp_biquad
        // 
        grp_biquad.Controls.Add(txt_isStable);
        grp_biquad.Controls.Add(num_b2);
        grp_biquad.Controls.Add(num_b1);
        grp_biquad.Controls.Add(num_b0);
        grp_biquad.Controls.Add(num_a2);
        grp_biquad.Controls.Add(num_a1);
        grp_biquad.Controls.Add(num_a0);
        grp_biquad.Controls.Add(lbl_isStable);
        grp_biquad.Controls.Add(lbl_a1);
        grp_biquad.Controls.Add(lbl_a0);
        grp_biquad.Controls.Add(lbl_a2);
        grp_biquad.Controls.Add(lbl_b0);
        grp_biquad.Controls.Add(lbl_b1);
        grp_biquad.Controls.Add(lbl_b2);
        grp_biquad.Location = new Point(12, 281);
        grp_biquad.Name = "grp_biquad";
        grp_biquad.Size = new Size(283, 230);
        grp_biquad.TabIndex = 38;
        grp_biquad.TabStop = false;
        grp_biquad.Text = "Biquad";
        // 
        // txt_isStable
        // 
        txt_isStable.Location = new Point(157, 197);
        txt_isStable.Name = "txt_isStable";
        txt_isStable.ReadOnly = true;
        txt_isStable.Size = new Size(120, 23);
        txt_isStable.TabIndex = 34;
        // 
        // num_b2
        // 
        num_b2.DecimalPlaces = 9;
        num_b2.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_b2.Location = new Point(157, 163);
        num_b2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_b2.Name = "num_b2";
        num_b2.ReadOnly = true;
        num_b2.Size = new Size(120, 23);
        num_b2.TabIndex = 33;
        // 
        // num_b1
        // 
        num_b1.DecimalPlaces = 9;
        num_b1.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_b1.Location = new Point(157, 134);
        num_b1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_b1.Name = "num_b1";
        num_b1.ReadOnly = true;
        num_b1.Size = new Size(120, 23);
        num_b1.TabIndex = 32;
        // 
        // num_b0
        // 
        num_b0.DecimalPlaces = 9;
        num_b0.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_b0.Location = new Point(157, 105);
        num_b0.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_b0.Name = "num_b0";
        num_b0.ReadOnly = true;
        num_b0.Size = new Size(120, 23);
        num_b0.TabIndex = 31;
        // 
        // num_a2
        // 
        num_a2.DecimalPlaces = 9;
        num_a2.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_a2.Location = new Point(157, 73);
        num_a2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_a2.Name = "num_a2";
        num_a2.ReadOnly = true;
        num_a2.Size = new Size(120, 23);
        num_a2.TabIndex = 30;
        // 
        // num_a1
        // 
        num_a1.DecimalPlaces = 9;
        num_a1.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_a1.Location = new Point(157, 44);
        num_a1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_a1.Name = "num_a1";
        num_a1.ReadOnly = true;
        num_a1.Size = new Size(120, 23);
        num_a1.TabIndex = 29;
        // 
        // num_a0
        // 
        num_a0.DecimalPlaces = 9;
        num_a0.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
        num_a0.Location = new Point(157, 15);
        num_a0.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        num_a0.Name = "num_a0";
        num_a0.ReadOnly = true;
        num_a0.Size = new Size(120, 23);
        num_a0.TabIndex = 28;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(866, 521);
        Controls.Add(grp_biquad);
        Controls.Add(toolStrip);
        Controls.Add(chart_equalizerBands);
        Controls.Add(grp_parameters);
        Name = "MainForm";
        Text = "EqualizerAPO Linkwitz editor";
        ((System.ComponentModel.ISupportInitialize)num_f0).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_q0).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_qp).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_fp).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_lphp).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_fs).EndInit();
        ((System.ComponentModel.ISupportInitialize)chart_equalizerBands).EndInit();
        grp_parameters.ResumeLayout(false);
        grp_parameters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)num_scale).EndInit();
        toolStrip.ResumeLayout(false);
        toolStrip.PerformLayout();
        grp_biquad.ResumeLayout(false);
        grp_biquad.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)num_b2).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_b1).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_b0).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_a2).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_a1).EndInit();
        ((System.ComponentModel.ISupportInitialize)num_a0).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_f0;
    private Label lbl_q0;
    private NumericUpDown num_f0;
    private NumericUpDown num_q0;
    private NumericUpDown num_qp;
    private NumericUpDown num_fp;
    private Label lbl_qp;
    private Label lbl_fp;
    private NumericUpDown num_lphp;
    private Label lbl_lphp;
    private NumericUpDown num_fs;
    private Label lbl_fs;
    private Label lbl_a0;
    private Label lbl_a1;
    private Label lbl_a2;
    private Label lbl_b0;
    private Label lbl_b1;
    private Label lbl_b2;
    private Label lbl_isStable;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_equalizerBands;
    private GroupBox grp_parameters;
    private SaveFileDialog sfd_filepath;
    private OpenFileDialog ofd_filepath;
    private NumericUpDown num_scale;
    private Label lbl_scale;
    private ToolStrip toolStrip;
    private ToolStripButton toolStripButton1;
    private ToolStripButton btn_save;
    private ToolStripButton toolStripButton3;
    private GroupBox grp_biquad;
    private NumericUpDown num_a0;
    private TextBox txt_isStable;
    private NumericUpDown num_b2;
    private NumericUpDown num_b1;
    private NumericUpDown num_b0;
    private NumericUpDown num_a2;
    private NumericUpDown num_a1;
}
