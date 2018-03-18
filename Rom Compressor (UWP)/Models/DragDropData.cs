using Windows.ApplicationModel.DataTransfer;

namespace Rom_Compressor__UWP_.Models
{
    public class DragDropData
    {
        public DataPackageOperation AcceptedOperation { get; set; }

        public DataPackageView DataView { get; set; }
    }
}
