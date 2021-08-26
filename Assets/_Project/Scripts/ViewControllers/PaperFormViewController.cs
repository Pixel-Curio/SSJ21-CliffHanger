using JetBrains.Annotations;

namespace Pixel_Curio.SSJ21
{
    public class PaperFormViewController
    {
        private PaperFormView _view;

        public PaperFormViewController(PaperFormView view, string seed = null)
        {
            _view = view;

            if (seed == null) GenerateDefaultForm();
        }

        private void GenerateDefaultForm()
        {
            _view.FormName.text = "1-1A";
            _view.BodyText.text =
                "Application for mech pilot training, certification, future rehabilitation, and mechanical device lubrication expert. Please sign your name.";
        }
    }
}
