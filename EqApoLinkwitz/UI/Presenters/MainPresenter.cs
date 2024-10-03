using EqApoLinkwitz.DataStructures;
using EqApoLinkwitz.Logic;
using EqApoLinkwitz.UI.Events;
using EqApoLinkwitz.UI.Views;

namespace EqApoLinkwitz.UI.Presenters;

class MainPresenter : IDisposable
{
    private readonly IMainForm _mainForm;

    private string? _activeFilePath;

    private LoadSaveData _loadSaveData;
    private Correction _correction;
    
    public MainPresenter(IMainForm mainForm)
    {
        _mainForm = mainForm;

        _mainForm.LoadFile += OnLoad;
        _mainForm.SaveFile += OnSave;
        _mainForm.LoadSaveDataUpdated += OnLoadSaveDataUpdated;
        
        Initialize();
    }
    
    public void Dispose()
    {
        _mainForm.LoadFile -= OnLoad;
        _mainForm.SaveFile -= OnSave;
        _mainForm.LoadSaveDataUpdated -= OnLoadSaveDataUpdated;
    }
    
    private async void OnLoad(object? sender, LoadEventArgs e)
    {
        var data = await FileIo.LoadAsync(e.FilePath);

        if (data == null)
        {
            return;
        }

        _activeFilePath = e.FilePath;
        _mainForm.SaveEnabled = true;
        _mainForm.LoadSaveData = data;
        Update();
    }
    
    private async void OnSave(object? sender, SaveEventArgs e)
    {
        if(e.FilePath == null)
        {
            // save
        }
        else
        {
            // save as
            _activeFilePath = e.FilePath;           
        }

        if (_activeFilePath == null)
        {
            throw new InvalidOperationException("Filename should have been set at this point");
        }

        await FileIo.SaveAsync(_activeFilePath, _loadSaveData, _correction);

        _mainForm.SaveEnabled = true;
    }

    private void OnLoadSaveDataUpdated(object? sender, EventArgs e)
    {
        Update();
    }
    
    private void Initialize()
    {
        _loadSaveData = FileIo.GetDefault();
        _correction = new Correction([], 0);
        _mainForm.LoadSaveData = _loadSaveData;
        _mainForm.SaveEnabled = false;
        Update();
    }
    
    private void Update()
    {
        // Load
        var loadSaveData = _mainForm.LoadSaveData;

        // Calculate
        var filterParameters = Calculations.CreateFilterParameters(loadSaveData);
        var correction = Calculations.CreateCorrection(filterParameters, loadSaveData);

        // Save locally
        _loadSaveData = loadSaveData;
        _correction = correction;
        
        // Update the UI
        _mainForm.FilterParameters = filterParameters;
        _mainForm.EqualizerBands = correction.EqualizerBands;
    }
}