using qr_app.ViewModels;
using qr_app.Model;
using qr_app.Services;

namespace qr_app.Services
{
	public class QRMainService
	{
		private MainWindowViewModel mainWindowView;

		private QRCode qrCode;

		private IOService iOService;

		private QRPreparerService qrPreparerService;

		private QRWriterService qrWriterService;

		private BinaryComputeService binaryComputeService;

		private TemplateFinderService templateFinderService;

		private VersionComputeService versionComputeService;

	}

}

