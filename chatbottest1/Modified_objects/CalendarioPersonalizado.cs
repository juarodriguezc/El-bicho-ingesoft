﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
public class CalendarioPersonalizado : MonthCalendar
{
    private ErrorProvider errorProvider1;
    private System.ComponentModel.IContainer components;
   

    [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
    static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
    protected override void OnHandleCreated(EventArgs e)
    {
        SetWindowTheme(Handle, string.Empty, string.Empty);
        base.OnHandleCreated(e);
    }


}