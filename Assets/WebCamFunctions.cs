using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
//using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

// Reference path for the following assemblies --> C:\Program Files\Microsoft Expression\Encoder 4\SDK\
using Microsoft.Expression;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using UnityEngine.UI;

public class WebCamFunctions : MonoBehaviour {

    public Dropdown combobox;
    
    /// <summary>
    /// Creates job for capture of live source
    /// </summary>
    private LiveJob _job;

    /// <summary>
    /// Device for live source
    /// </summary>
    private LiveDeviceSource _deviceSource;

    private bool _bStartedRecording = false;






    // Use this for initialization
    void Start () {
        foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
        {
            combobox.options.Add(new Dropdown.OptionData(edv.Name));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
