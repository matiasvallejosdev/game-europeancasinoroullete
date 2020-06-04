﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasHUD : MonoBehaviour
{
    [SerializeField] Button PlayButtonUI;

    [SerializeField] Text _txtSaldo;
    [SerializeField] Text _txtApuestas;

    [SerializeField] fichas _fichaAll;

    // Start is called before the first frame update
    void Start()
    {
        RoundController.Instance.OnRoundChanged.AddListener(HandleRoundStateChanged);
        RoundController.Instance.OnApuestaChanged.AddListener(HandleApuestaStateChanged);
    }

    void HandleRoundStateChanged(int saldoAnterior, int saldoNuevo)
    {
        _txtSaldo.text = saldoNuevo.ToString();
        _fichaAll._valor = saldoNuevo;
    }
    void HandleApuestaStateChanged(int apuestaAnterior, int apuestaNueva, int apuestaTotal)
    {
        _txtApuestas.text = apuestaTotal.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}