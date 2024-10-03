using EqApoLinkwitz.DataStructures;
using EqApoLinkwitz.UI.Events;

namespace EqApoLinkwitz.UI.Views;

partial class MainForm : Form, IMainForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    public event EventHandler<LoadEventArgs>? LoadFile;
    public event EventHandler<SaveEventArgs>? SaveFile;

    public event EventHandler? LoadSaveDataUpdated;

    public LoadSaveData LoadSaveData
    {
        get => new(
            (double)num_q0.Value,
            (double)num_fp.Value,
            (double)num_qp.Value,
            (double)num_lphp.Value,
            (double)num_fs.Value,
            (double)num_scale.Value,
            (double)num_f0.Value
        );
        set
        {
            num_f0.Value = (decimal)value.Frequency0;
            num_q0.Value = (decimal)value.Qtc0;
            num_fp.Value = (decimal)value.FrequencyP;
            num_qp.Value = (decimal)value.QtcP;
            num_lphp.Value = (decimal)value.LowPassHighPassRatio;
            num_fs.Value = (decimal)value.SampleFrequency;
            num_scale.Value = (decimal)value.Scale;
        }
    }

    public FilterParameters FilterParameters
    {
        set
        {
            var biquadFilterParameters = value.BiquadFilter;
            num_a0.Value = (decimal)biquadFilterParameters.a0;
            num_a1.Value = (decimal)biquadFilterParameters.a1;
            num_a2.Value = (decimal)biquadFilterParameters.a2;

            num_b0.Value = (decimal)biquadFilterParameters.b0;
            num_b1.Value = (decimal)biquadFilterParameters.b1;
            num_b2.Value = (decimal)biquadFilterParameters.b2;

            txt_isStable.Text = biquadFilterParameters.IsStable().ToString();
        }
    }

    public IEnumerable<EqualizerBand> EqualizerBands
    {
        set
        {
            var series = chart_equalizerBands.Series.Single();
            series.XValueMember = nameof(EqualizerBand.Frequency);
            series.YValueMembers = nameof(EqualizerBand.Gain);

            chart_equalizerBands.DataSource = value;
            chart_equalizerBands.DataBind();
        }
    }

    public bool SaveEnabled
    {
        set { btn_save.Enabled = value; }
    }

    private void NumF0ValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumQ0ValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumFpValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumQpValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumLphpValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumFsValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();
    private void NumScaleValueChanged(object sender, EventArgs e) => OnLoadSaveDataUpdated();

    protected virtual void OnLoadSaveDataUpdated()
    {
        LoadSaveDataUpdated?.Invoke(this, EventArgs.Empty);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        var result = ofd_filepath.ShowDialog();

        if (result == DialogResult.OK)
        {
            LoadFile?.Invoke(this, new LoadEventArgs(ofd_filepath.FileName));
        }
    }

    private void BtnSaveClick(object sender, EventArgs e)
    {
        SaveFile?.Invoke(this, new SaveEventArgs(null));
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        var result = sfd_filepath.ShowDialog();

        if (result == DialogResult.OK)
        {
            SaveFile?.Invoke(this, new SaveEventArgs(sfd_filepath.FileName));
        }
    }
}