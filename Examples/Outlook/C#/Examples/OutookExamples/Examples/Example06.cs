﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ExampleBase;

using LateBindingApi.Core;
using Outlook = NetOffice.OutlookApi;
using NetOffice.OutlookApi.Enums;

namespace OutlookExamplesCS4
{
    public partial class Example06 : UserControl, IExample
    {
        IHost _hostApplication;

        private delegate void UpdateEventTextDelegate(string Message);
        UpdateEventTextDelegate _updateDelegate;

        public Example06()
        {
            InitializeComponent();
            _updateDelegate = new UpdateEventTextDelegate(UpdateTextbox);
        }

        #region IExample Member

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout buttonStartExample_Click
        }

        public string Caption
        {
            get { return _hostApplication.LCID == 1033 ? "Example06" : "Beispiel06"; }
        }

        public string Description
        {
            get { return _hostApplication.LCID == 1033 ? "Events" : "Ereignisse"; }
        }

        public void Connect(IHost hostApplication)
        {
            _hostApplication = hostApplication;
        }

        public UserControl Panel
        {
            get { return this; }
        }

        #endregion

        #region UI Trigger

        private void buttonStartExample_Click(object sender, EventArgs e)
        {
            // Initialize NetOffice
            LateBindingApi.Core.Factory.Initialize();

            // start outlook
            Outlook.Application outlookApplication = new Outlook.Application();

            // create MailItem and register close event
            Outlook.MailItem mailItem = outlookApplication.CreateItem(OlItemType.olMailItem) as Outlook.MailItem;
            mailItem.CloseEvent += new NetOffice.OutlookApi.MailItem_CloseEventHandler(mailItem_CloseEvent);

            // BodyFormat is not available in Outlook 2000, we check at runtime the property is available
            if (mailItem.EntityIsAvailable("BodyFormat"))
                mailItem.BodyFormat = OlBodyFormat.olFormatPlain;
            mailItem.Body = "ExampleBody";
            mailItem.Subject = "ExampleSubject";
            mailItem.Display();
            mailItem.Close(OlInspectorClose.olDiscard);

            // close outlook and dispose
            outlookApplication.Quit();
            outlookApplication.Dispose();
        }

        #endregion

        #region Outlook Trigger

        void mailItem_CloseEvent(ref bool Cancel)
        {
            textBoxEvents.BeginInvoke(_updateDelegate, new object[] { "Event Close called." });
        }

        private void UpdateTextbox(string message)
        {
            textBoxEvents.AppendText(message + "\r\n");
        }
        
        #endregion
    }
}
