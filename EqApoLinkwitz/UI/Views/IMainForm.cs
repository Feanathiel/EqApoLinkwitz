using EqApoLinkwitz.DataStructures;
using EqApoLinkwitz.UI.Events;

namespace EqApoLinkwitz.UI.Views;

interface IMainForm
{
    bool SaveEnabled { set; }

    event EventHandler<LoadEventArgs> LoadFile;
    event EventHandler<SaveEventArgs> SaveFile;
    event EventHandler LoadSaveDataUpdated;
    
    LoadSaveData LoadSaveData { get; set; }
    FilterParameters FilterParameters { set; }
    IEnumerable<EqualizerBand> EqualizerBands { set; }
}