using System.Collections.Generic;
using UnityEngine;

namespace Pixel_Curio.SSJ21
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private GameObject _formPrefab;
        [SerializeField] private Transform _formStackPoint;

        private List<PaperFormViewController> _forms = new List<PaperFormViewController>();

        private void Start()
        {
            _forms.Add(new PaperFormViewController(
                    Instantiate(_formPrefab, _formStackPoint, true).GetComponent<PaperFormView>()));
        }

        private void Update()
        {

        }
    }
}
