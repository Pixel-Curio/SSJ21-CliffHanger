using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _formPrefab;
    [SerializeField] private Transform _formStackPoint;

    private List<PaperFormView> _forms = new List<PaperFormView>();

    private void Start()
    {
        _forms.Add(Instantiate(_formPrefab, _formStackPoint, true).GetComponent<PaperFormView>());
        _forms[0].FormName.text = "1-1A";
        _forms[0].BodyText.text = "Application for mech pilot training, certification, future rehabilitation, and mechanical device lubrication expert. Please sign your name.";
    }

    private void Update()
    {
        
    }
}
